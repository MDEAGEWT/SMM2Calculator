Imports System.IO
Imports System.Net.Http
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

' Map import.
'  * mm2list (https://mm2list.cyzon.us/cached-view/<course id>) serves no course data, only toost
'    renders of both areas at 16 px per block. They are drawn with the same game textures this
'    program ships, so blocks and hazards are found by comparing pixels with those textures.
'  * Course files (course_data_XXX.bcd from a save, encrypted or decrypted) are read exactly.
'    Format: toost level.ksy (MIT, TheGreatRambler), decryption: SMM2CourseDecryptor (MIT, simontime).
Module CourseImport

    ' Obstacle kinds, numbered like the obstacle list (Form1.SpikeBlk.type)
    Public Const ObjSpikeTrap As Integer = 0
    Public Const ObjPiranha As Integer = 1
    Public Const ObjPiranhaDown As Integer = 2
    Public Const ObjMuncher As Integer = 3
    Public Const ObjBigPiranha As Integer = 4
    Public Const ObjBigPiranhaDown As Integer = 5
    Public Const ObjGrinder As Integer = 6

    Public ReadOnly StyleNames() As String = {"Plain", "Underground", "Castle", "Airship", "Water",
                                              "Hauntedhouse", "Snow", "Desert", "Athletic", "Woods"}

    Public Structure MapObject
        Dim Type As Integer
        Dim X As Integer ' px from the left edge of the area; the obstacle is drawn at SpikeBlk.x * 8
        Dim Y As Integer ' px from the top edge of the area; the obstacle is drawn at SpikeBlk.y * 8
    End Structure

    Public Class ImportedMap
        Public Title As String = ""
        Public Source As String = ""
        Public Style As String = ""   ' M1 / M3 / MW
        Public Theme As Integer       ' index into StyleNames
        Public Night As Boolean
        Public Width As Integer       ' blocks
        Public Height As Integer
        Public TileX(,) As Integer    ' tilesheet cell drawn at (column, row counted from the top), -1 = none
        Public TileY(,) As Integer
        Public Solid(,) As Boolean    ' blocks Mario can stand on
        Public Objects As New List(Of MapObject)
        Public Unrecognized As Integer

        Public Sub New(w As Integer, h As Integer)
            Width = w
            Height = h
            ReDim TileX(w - 1, h - 1), TileY(w - 1, h - 1), Solid(w - 1, h - 1)
            For x = 0 To w - 1
                For y = 0 To h - 1
                    TileX(x, y) = -1
                    TileY(x, y) = -1
                Next
            Next
        End Sub

        Public Sub SetTile(x As Integer, row As Integer, tx As Integer, ty As Integer, isSolid As Boolean)
            If x < 0 OrElse row < 0 OrElse x >= Width OrElse row >= Height Then Exit Sub
            TileX(x, row) = tx
            TileY(x, row) = ty
            Solid(x, row) = isSolid
        End Sub

        Public Function Count(type As Integer) As Integer
            Return Objects.Where(Function(o) o.Type = type).Count()
        End Function
    End Class

    ' ARGB pixels, row by row
    Public Class PixelImage
        Public ReadOnly Width As Integer
        Public ReadOnly Height As Integer
        Public ReadOnly Px() As Integer

        Public Sub New(w As Integer, h As Integer, px() As Integer)
            Width = w
            Height = h
            Me.Px = px
        End Sub

        Public Function Crop(x0 As Integer, y0 As Integer, w As Integer, h As Integer) As PixelImage
            Dim p(w * h - 1) As Integer
            For y = 0 To h - 1
                Array.Copy(Px, (y0 + y) * Width + x0, p, y * w, w)
            Next
            Return New PixelImage(w, h, p)
        End Function

        Public Function FlipY() As PixelImage
            Dim p(Px.Length - 1) As Integer
            For y = 0 To Height - 1
                Array.Copy(Px, y * Width, p, (Height - 1 - y) * Width, Width)
            Next
            Return New PixelImage(Width, Height, p)
        End Function

        Public Function Scale(n As Integer) As PixelImage
            Dim w = Width * n, h = Height * n
            Dim p(w * h - 1) As Integer
            For y = 0 To h - 1
                For x = 0 To w - 1
                    p(y * w + x) = Px((y \ n) * Width + x \ n)
                Next
            Next
            Return New PixelImage(w, h, p)
        End Function
    End Class

    ' ------------------------------------------------------------------ course codes and mm2list

    Private Const CodeChars As String = "0123456789BCDFGHJKLMNPQRSTVWXY"

    ' "J18-0TG-33G", "j180tg33g" or a URL containing the code -> "J180TG33G"; "" if there is none
    Public Function NormalizeCourseCode(text As String) As String
        Dim m = Regex.Match(text.ToUpperInvariant(), "(?<![0-9A-Z])([0-9A-Z]{3})[- ]?([0-9A-Z]{3})[- ]?([0-9A-Z]{3})(?![0-9A-Z])")
        Do While m.Success
            Dim code = m.Groups(1).Value & m.Groups(2).Value & m.Groups(3).Value
            If code.All(Function(c) CodeChars.IndexOf(c) >= 0) Then Return code
            m = m.NextMatch()
        Loop
        Return ""
    End Function

    Public Class CachedView
        Public Code As String
        Public Title As String = ""
        Public GameStyle As String = ""      ' as the page writes it: SMB1, SMB3, SMW, NSMBU, SM3DW
        Public ImageUrl(1) As String         ' overworld, subworld
        Public Theme(1) As Integer
        Public Night(1) As Boolean
    End Class

    Public Const Mm2ListBase As String = "https://mm2list.cyzon.us"

    Public Function ParseCachedView(code As String, html As String) As CachedView
        Dim v As New CachedView With {.Code = code}
        Dim t = Regex.Match(html, "<h3 id=""level-title"">(.*?)</h3>", RegexOptions.Singleline)
        If t.Success Then v.Title = Net.WebUtility.HtmlDecode(t.Groups(1).Value.Trim())
        Dim s = Regex.Match(html, "<figcaption>\s*(SMB1|SMB3|SMW|NSMBU|SM3DW)\s*</figcaption>")
        If s.Success Then v.GameStyle = s.Groups(1).Value

        Dim area = 0
        For Each m As Match In Regex.Matches(html, "<img class=""cached-image([^""]*)"" src=""([^""]+)""")
            If area > 1 Then Exit For
            Dim cls = m.Groups(1).Value
            v.ImageUrl(area) = If(m.Groups(2).Value.StartsWith("/"), Mm2ListBase & m.Groups(2).Value, m.Groups(2).Value)
            Dim th = Regex.Match(cls, "cv-theme-(\d+)")
            v.Theme(area) = If(th.Success, Math.Min(9, CInt(th.Groups(1).Value)), 0)
            v.Night(area) = cls.Contains("night-theme")
            area += 1
        Next
        Return v
    End Function

    Private ReadOnly Http As New HttpClient() With {.Timeout = TimeSpan.FromSeconds(30)}

    Private Function GetBytes(url As String) As Byte()
        Using req As New HttpRequestMessage(HttpMethod.Get, url)
            req.Headers.UserAgent.ParseAdd("SMM2Calculator")
            Using res = Http.Send(req)
                res.EnsureSuccessStatusCode()
                Using ms As New MemoryStream()
                    res.Content.ReadAsStream().CopyTo(ms)
                    Return ms.ToArray()
                End Using
            End Using
        End Using
    End Function

    Public Function DownloadCachedView(code As String) As CachedView
        Dim html = Encoding.UTF8.GetString(GetBytes(Mm2ListBase & "/cached-view/" & code))
        Return ParseCachedView(code, html)
    End Function

    Public Function DownloadImage(url As String) As Byte()
        Return GetBytes(url)
    End Function

    Public Function StyleFromPage(gameStyle As String) As String
        Select Case gameStyle
            Case "SMB1" : Return "M1"
            Case "SMB3" : Return "M3"
            Case "SMW" : Return "MW"
            Case Else : Return "" ' NSMBU / SM3DW: no textures in Assets.zip
        End Select
    End Function

    ' ------------------------------------------------------------------ textures

    ' Loads a texture as PixelImage; Nothing if the file does not exist. Set by the form, so this
    ' module needs no System.Drawing.
    Public TextureLoader As Func(Of String, PixelImage)

    Public Function FieldTexturePath(imgDir As String, style As String, theme As Integer, night As Boolean) As String
        Dim n = style & "_Field_" & StyleNames(theme) & If(night, "_D", "")
        Return Path.Combine(imgDir, "Model", n & ".Nin_NX_NVN", n & ".png")
    End Function

    Private Function SpritePath(imgDir As String, style As String, name As String) As String
        Return Path.Combine(imgDir, "Pack", style & "_Model", style & "_" & name & ".Nin_NX_NVN", "wait.0.png")
    End Function

    ' Tilesheet cells toost draws terrain with (16 x 48 cells of 16 px, same layout for every theme)
    Private Function IsGroundCell(tx As Integer, ty As Integer) As Boolean
        Return ty >= 13 AndAlso ty <= 15
    End Function

    Private ReadOnly BlockCells As New HashSet(Of Integer) From {
        Cell(1, 0), Cell(2, 0), Cell(3, 0), Cell(4, 0), Cell(5, 0), Cell(6, 0), Cell(6, 5), Cell(6, 6), Cell(8, 7),
        Cell(0, 4), Cell(2, 43), Cell(1, 43), Cell(0, 43), Cell(2, 23), Cell(3, 22), Cell(2, 21)}

    Private Function Cell(tx As Integer, ty As Integer) As Integer
        Return ty * 16 + tx
    End Function

    Private Function IsPipeCell(tx As Integer, ty As Integer) As Boolean
        Return (ty <= 2 AndAlso tx >= 11) OrElse ((ty = 37 OrElse ty = 38) AndAlso tx <= 15) OrElse (ty = 24 AndAlso tx >= 4 AndAlso tx <= 7)
    End Function

    Private Function IsPlatformTop(tx As Integer, ty As Integer) As Boolean
        Return (tx >= 3 AndAlso tx <= 5 AndAlso ty >= 2 AndAlso ty <= 4) OrElse ' mushroom platforms
               (ty = 3 AndAlso tx >= 7) OrElse                                  ' semisolid platforms
               (ty = 2 AndAlso tx <= 2)                                         ' bridges
    End Function

    Private Const SpikeTrapX As Integer = 2, SpikeTrapY As Integer = 4

    ' ------------------------------------------------------------------ mm2list renders

    Private Class Template
        Public Type As Integer
        Public W As Integer
        Public H As Integer
        Public AnchorY As Integer   ' SpikeBlk anchor = top of the drawn image + AnchorY
        Public MinMatch As Double
        Public Blended As Boolean   ' toost draws it at 70% opacity
        Public Idx() As Integer     ' y * W + x of the opaque pixels
        Public Rgb() As Integer

        Public Sub New(type As Integer, img As PixelImage, anchorY As Integer, minMatch As Double)
            Me.Type = type
            W = img.Width
            H = img.Height
            Me.AnchorY = anchorY
            Me.MinMatch = minMatch
            Dim idxs As New List(Of Integer), rgbs As New List(Of Integer)
            For i = 0 To img.Px.Length - 1
                If (img.Px(i) >> 24 And 255) >= 200 Then
                    idxs.Add(i)
                    rgbs.Add(img.Px(i) And &HFFFFFF)
                End If
            Next
            Idx = idxs.ToArray()
            Rgb = rgbs.ToArray()
        End Sub
    End Class

    Private Function SameRgb(a As Integer, b As Integer, tol As Integer) As Boolean
        Return Math.Abs((a >> 16 And 255) - (b >> 16 And 255)) <= tol AndAlso
               Math.Abs((a >> 8 And 255) - (b >> 8 And 255)) <= tol AndAlso
               Math.Abs((a And 255) - (b And 255)) <= tol
    End Function

    ' Share of the template's opaque pixels found at (x0, y0), or -1 once it cannot reach minMatch
    Private Function MatchAt(img As PixelImage, t As Template, x0 As Integer, y0 As Integer) As Double
        Dim allowedMisses = CInt(t.Idx.Length * (1 - t.MinMatch))
        Dim misses = 0
        For k = 0 To t.Idx.Length - 1
            Dim p = img.Px((y0 + t.Idx(k) \ t.W) * img.Width + x0 + t.Idx(k) Mod t.W)
            If (p >> 24 And 255) = 0 OrElse Not SameRgb(p, t.Rgb(k), 8) Then
                misses += 1
                If misses > allowedMisses Then Return -1
            End If
        Next
        Return 1 - misses / t.Idx.Length
    End Function

    Private Function LoadTemplates(imgDir As String, style As String) As List(Of Template)
        Dim list As New List(Of Template)
        Dim add = Sub(name As String, makeList As Action(Of PixelImage))
                      Dim img = TextureLoader(SpritePath(imgDir, style, name))
                      If img IsNot Nothing Then makeList(img)
                  End Sub
        ' toost draws the sprites at their own size: Piranha Plant 16x24 (32x48 when big),
        ' Muncher 16x16, Grinder 48x48 at 70% opacity.
        For Each name In {"Enemy_packun", "Enemy_packunfire"}
            add(name, Sub(img)
                          list.Add(New Template(ObjPiranha, img, 8, 0.9))
                          list.Add(New Template(ObjPiranhaDown, img.FlipY(), 0, 0.9))
                          list.Add(New Template(ObjBigPiranha, img.Scale(2), 32, 0.9))
                          list.Add(New Template(ObjBigPiranhaDown, img.Scale(2).FlipY(), 0, 0.9))
                      End Sub)
        Next
        For Each name In {"Enemy_packunblack", "Enemy_packunblack_D"}
            add(name, Sub(img) list.Add(New Template(ObjMuncher, img, 0, 0.9)))
        Next
        add("Object_saw", Sub(img) list.Add(New Template(ObjGrinder, img, 0, 0.45) With {.Blended = True}))
        Return list
    End Function

    ' Grinders are drawn at 70% opacity. Over an empty background the render keeps the sprite's
    ' colours; over blocks every pixel is 0.7 * sprite + 0.3 * whatever was behind it. Blocks drawn
    ' later can cover part of it, so either test only needs part of the pixels.
    Private Function BlendedMatch(img As PixelImage, t As Template, x0 As Integer, y0 As Integer) As Boolean
        Dim n = t.Idx.Length, exact = 0, blend = 0
        For k = 0 To n - 1
            Dim p = img.Px((y0 + t.Idx(k) \ t.W) * img.Width + x0 + t.Idx(k) Mod t.W)
            Dim a = p >> 24 And 255
            If a > 0 AndAlso SameRgb(p, t.Rgb(k), 8) Then
                exact += 1
                blend += 1
            ElseIf a >= 250 AndAlso BehindOk(p >> 16 And 255, t.Rgb(k) >> 16 And 255) AndAlso
                   BehindOk(p >> 8 And 255, t.Rgb(k) >> 8 And 255) AndAlso BehindOk(p And 255, t.Rgb(k) And 255) Then
                blend += 1
            End If
            Dim left = n - 1 - k
            If exact + left < n * 0.45 AndAlso blend + left < n * 0.85 Then Return False
        Next
        If exact >= n * 0.45 Then Return True
        Return blend >= n * 0.85 AndAlso Correlation(img, t, x0, y0) >= 0.5
    End Function

    ' Can the colour c be 0.7 * s + 0.3 * (some colour behind)?
    Private Function BehindOk(c As Integer, s As Integer) As Boolean
        Dim behind = (c - 0.7 * s) / 0.3
        Return behind >= -8 AndAlso behind <= 263
    End Function

    ' Pearson correlation of brightness between the sprite and the render; a flat background
    ' would pass the blend test everywhere, a real Grinder still shows its pattern
    Private Function Correlation(img As PixelImage, t As Template, x0 As Integer, y0 As Integer) As Double
        Dim n = t.Idx.Length
        Dim sa = 0.0, sb = 0.0, saa = 0.0, sbb = 0.0, sab = 0.0
        For k = 0 To n - 1
            Dim p = img.Px((y0 + t.Idx(k) \ t.W) * img.Width + x0 + t.Idx(k) Mod t.W)
            Dim a = ((p >> 16 And 255) + (p >> 8 And 255) + (p And 255)) / 3.0
            Dim b = ((t.Rgb(k) >> 16 And 255) + (t.Rgb(k) >> 8 And 255) + (t.Rgb(k) And 255)) / 3.0
            sa += a : sb += b : saa += a * a : sbb += b * b : sab += a * b
        Next
        Dim va = saa - sa * sa / n, vb = sbb - sb * sb / n
        If va <= 0 OrElse vb <= 0 Then Return 0
        Return (sab - sa * sb / n) / Math.Sqrt(va * vb)
    End Function

    Private Class TileSheet
        Public Cells As New List(Of Template)                         ' cells with something drawn
        Public Exact As New Dictionary(Of String, Template)           ' fully opaque cells by pixels
        Public Pos As New Dictionary(Of Template, Point)

        Public Sub New(sheet As PixelImage)
            For ty = 0 To sheet.Height \ 16 - 1
                For tx = 0 To sheet.Width \ 16 - 1
                    Dim t = New Template(-1, sheet.Crop(tx * 16, ty * 16, 16, 16), 0, 0.8)
                    If t.Idx.Length < 32 Then Continue For
                    Cells.Add(t)
                    Pos(t) = New Point(tx, ty)
                    If t.Idx.Length = 256 Then
                        Dim key = String.Join(",", t.Rgb)
                        ' identical cells: keep the one that says what the block is
                        If Not Exact.ContainsKey(key) OrElse Rank(Pos(Exact(key))) < Rank(Pos(t)) Then Exact(key) = t
                    End If
                Next
            Next
        End Sub

        Public Function Rank(p As Point) As Integer
            If IsGroundCell(p.X, p.Y) Then Return 3
            If BlockCells.Contains(Cell(p.X, p.Y)) OrElse IsPipeCell(p.X, p.Y) Then Return 2
            If IsPlatformTop(p.X, p.Y) Then Return 1
            Return 0
        End Function

        ' Best matching cell for the 16x16 block at (x0, y0), Nothing if none
        Public Function Find(img As PixelImage, x0 As Integer, y0 As Integer) As Template
            Dim px(255) As Integer, opaque = 0
            For y = 0 To 15
                For x = 0 To 15
                    Dim p = img.Px((y0 + y) * img.Width + x0 + x)
                    px(y * 16 + x) = p And &HFFFFFF
                    If (p >> 24 And 255) >= 200 Then opaque += 1
                Next
            Next
            If opaque < 16 Then Return Nothing
            If opaque = 256 Then
                Dim hit As Template = Nothing
                If Exact.TryGetValue(String.Join(",", px), hit) Then Return hit
            End If
            ' Something is drawn over the block (the goal pole, grid numbers...): a full cell that
            ' still matches 80% of its pixels
            Dim best As Template = Nothing, bestScore = 0.0
            For Each t In Cells
                If t.Idx.Length < 256 Then Continue For
                Dim s = MatchAt(img, t, x0, y0)
                If s > bestScore OrElse (s = bestScore AndAlso best IsNot Nothing AndAlso Rank(Pos(t)) > Rank(Pos(best))) Then
                    bestScore = s
                    best = t
                End If
            Next
            If best IsNot Nothing Then Return best

            ' A cell with holes (Spike Trap, edges...) drawn over the background: it must match 90%
            ' of its own pixels and cover most of the block
            bestScore = 0.0
            For Each t In Cells
                If t.Idx.Length = 256 OrElse t.Idx.Length < 64 OrElse t.Idx.Length < opaque * 0.6 Then Continue For
                Dim s = MatchAt(img, t, x0, y0)
                If s >= 0.9 AndAlso (s > bestScore OrElse (s = bestScore AndAlso t.Idx.Length > best.Idx.Length)) Then
                    bestScore = s
                    best = t
                End If
            Next
            Return best
        End Function
    End Class

    Private Function CountMatches(img As PixelImage, sheet As TileSheet) As Integer
        ' Quick score of a tilesheet: exact hits over a sample of the opaque blocks
        Dim hits = 0, tried = 0
        For row = 0 To img.Height \ 16 - 1
            For col = 0 To img.Width \ 16 - 1
                If tried >= 400 Then Return hits
                Dim px(255) As Integer, opaque = True
                For y = 0 To 15
                    For x = 0 To 15
                        Dim p = img.Px((row * 16 + y) * img.Width + col * 16 + x)
                        If (p >> 24 And 255) < 200 Then opaque = False
                        px(y * 16 + x) = p And &HFFFFFF
                    Next
                Next
                If Not opaque Then Continue For
                tried += 1
                If sheet.Exact.ContainsKey(String.Join(",", px)) Then hits += 1
            Next
        Next
        Return hits
    End Function

    ' Recognises a toost render (16 px per block). style "" = try every style/theme.
    Public Function ReadRender(img As PixelImage, imgDir As String, style As String, theme As Integer, night As Boolean) As ImportedMap
        If img.Width Mod 16 <> 0 OrElse img.Height Mod 16 <> 0 Then
            Throw New InvalidDataException("not a 16 px per block render")
        End If

        ' pick the tilesheet the render was drawn with
        Dim candidates As New List(Of Tuple(Of String, Integer, Boolean))
        If style <> "" Then
            candidates.Add(Tuple.Create(style, theme, night))
            candidates.Add(Tuple.Create(style, theme, Not night))
        Else
            For Each s In {"M1", "M3", "MW"}
                For th = 0 To 9
                    candidates.Add(Tuple.Create(s, th, False))
                    candidates.Add(Tuple.Create(s, th, True))
                Next
            Next
        End If
        Dim sheet As TileSheet = Nothing, bestHits = -1
        Dim chosen = candidates(0)
        For Each c In candidates
            Dim tex = TextureLoader(FieldTexturePath(imgDir, c.Item1, c.Item2, c.Item3))
            If tex Is Nothing Then Continue For
            Dim ts = New TileSheet(tex)
            Dim hits = CountMatches(img, ts)
            If hits > bestHits Then
                bestHits = hits
                sheet = ts
                chosen = c
            End If
        Next
        If sheet Is Nothing Then Throw New FileNotFoundException("tilesheet not found", FieldTexturePath(imgDir, style, theme, night))

        Dim map As New ImportedMap(img.Width \ 16, img.Height \ 16) With {
            .Style = chosen.Item1, .Theme = chosen.Item2, .Night = chosen.Item3}

        ' sprites first: their pixels are not terrain
        Dim covered(map.Width - 1, map.Height - 1) As Boolean
        For Each t In LoadTemplates(imgDir, map.Style)
            For y = 0 To img.Height - t.H Step 8
                For x = 0 To img.Width - t.W Step 8
                    If If(t.Blended, Not BlendedMatch(img, t, x, y), MatchAt(img, t, x, y) < 0) Then Continue For
                    Dim found As New MapObject With {.Type = t.Type, .X = x, .Y = y + t.AnchorY}
                    If map.Objects.Any(Function(o) o.Type = found.Type AndAlso Math.Abs(o.X - found.X) < t.W AndAlso Math.Abs(o.Y - found.Y) < t.H) Then Continue For
                    map.Objects.Add(found)
                    For cy = y \ 16 To Math.Min(map.Height - 1, (y + t.H - 1) \ 16)
                        For cx = x \ 16 To Math.Min(map.Width - 1, (x + t.W - 1) \ 16)
                            covered(cx, cy) = True
                        Next
                    Next
                Next
            Next
        Next

        For row = 0 To map.Height - 1
            For col = 0 To map.Width - 1
                Dim t = sheet.Find(img, col * 16, row * 16)
                If t Is Nothing Then
                    If Not covered(col, row) AndAlso HasOpaquePixels(img, col * 16, row * 16) Then map.Unrecognized += 1
                    Continue For
                End If
                Dim p = sheet.Pos(t)
                If p.X = SpikeTrapX AndAlso p.Y = SpikeTrapY Then
                    map.Objects.Add(New MapObject With {.Type = ObjSpikeTrap, .X = col * 16, .Y = row * 16})
                Else
                    map.SetTile(col, row, p.X, p.Y, IsGroundCell(p.X, p.Y) OrElse BlockCells.Contains(Cell(p.X, p.Y)) OrElse
                                IsPipeCell(p.X, p.Y) OrElse IsPlatformTop(p.X, p.Y))
                End If
            Next
        Next
        Return map
    End Function

    Private Function HasOpaquePixels(img As PixelImage, x0 As Integer, y0 As Integer) As Boolean
        Dim n = 0
        For y = 0 To 15
            For x = 0 To 15
                If (img.Px((y0 + y) * img.Width + x0 + x) >> 24 And 255) >= 200 Then n += 1
            Next
        Next
        Return n >= 32
    End Function

    ' ------------------------------------------------------------------ course files

    Private ReadOnly CourseKeyTable() As UInteger = {
        &H7AB1C9D2UI, &HCA750936UI, &H3003E59CUI, &HF261014BUI, &H2E25160AUI, &HED614811UI, &HF1AC6240UI, &HD59272CDUI,
        &HF38549BFUI, &H6CF5B327UI, &HDA4DB82AUI, &H820C435AUI, &HC95609BAUI, &H19BE08B0UI, &H738E2B81UI, &HED3C349AUI,
        &H45275D1UI, &HE0A73635UI, &H1DEBF4DAUI, &H9924B0DEUI, &H6A1FC367UI, &H71970467UI, &HFC55ABEBUI, &H368D7489UI,
        &HCC97D1DUI, &H17CC441EUI, &H3528D152UI, &HD0129B53UI, &HE12A69E9UI, &H13D1BDB7UI, &H32EAA9EDUI, &H42F41D1BUI,
        &HAEA5F51FUI, &H42C5D23CUI, &H7CC742EDUI, &H723BA5F9UI, &HDE5B99E3UI, &H2C0055A4UI, &HC38807B4UI, &H4C099B61UI,
        &HC4E4568EUI, &H8C29C901UI, &HE13B34ACUI, &HE7C3F212UI, &HB67EF941UI, &H8038965UI, &H8AFD1E6AUI, &H8E5341A3UI,
        &HA4C61107UI, &HFBAF1418UI, &H9B05EF64UI, &H3C91734EUI, &H82EC6646UI, &HFB19F33EUI, &H3BDE6FE2UI, &H17A84CCAUI,
        &HCCDF0CE9UI, &H50E4135CUI, &HFF2658B2UI, &H3780F156UI, &H7D8F5D68UI, &H517CBED1UI, &H1FCDDF0DUI, &H77A58C94UI}

    Public Const EncryptedCourseSize As Integer = &H5C000
    Public Const CourseSize As Integer = &H5BFC0

    ' sead::Random (xorshift128) as used by the game's key derivation
    Private Function NextRand(s() As UInteger) As UInteger
        Dim n = s(0) Xor (s(0) << 11)
        s(0) = s(1)
        s(1) = s(2)
        s(2) = s(3)
        n = n Xor (n >> 8) Xor s(3) Xor (s(3) >> 19)
        s(3) = n
        Return n
    End Function

    Public Function DecryptCourse(file() As Byte) As Byte()
        If file.Length = CourseSize Then Return file
        If file.Length <> EncryptedCourseSize Then Throw New InvalidDataException("not a course file")

        Dim footer = CourseSize + &H10
        Dim s(3) As UInteger
        For i = 0 To 3
            s(i) = BitConverter.ToUInt32(file, footer + &H10 + i * 4)
        Next
        If (s(0) Or s(1) Or s(2) Or s(3)) = 0 Then s = {1UI, &H6C078967UI, &H714ACB41UI, &H48077044UI}

        Dim key(15) As Byte
        For i = 0 To 3
            Dim k As UInteger = 0
            For j = 0 To 3
                k = (k << 8) Or ((CourseKeyTable(CInt(NextRand(s) >> 26)) >> CInt((NextRand(s) >> 27) And 24UI)) And &HFFUI)
            Next
            BitConverter.GetBytes(k).CopyTo(key, i * 4)
        Next

        Dim iv(15) As Byte, data(CourseSize - 1) As Byte
        Array.Copy(file, footer, iv, 0, 16)
        Array.Copy(file, &H10, data, 0, CourseSize)
        Using cipher = Aes.Create()
            cipher.Key = key
            Return cipher.DecryptCbc(data, iv, PaddingMode.None)
        End Using
    End Function

    ' toost GrdLoc: tilesheet cell of a ground block for each neighbour pattern
    Private ReadOnly GroundCells() As Byte = {
        &HD, &H4D, &H1D, &HAD, &H3D, &H9D, &H2D, &HCD, &H6D, &H5D, &H8D, &HED, &H7D, &HDD, &HBD, &HFD,
        &HD, &H4D, &H1D, &H2F, &H3D, &H9D, &H2D, &H4E, &H6D, &H5D, &H8D, &HE, &H7D, &HDD, &HBD, &H8E,
        &HD, &H4D, &H1D, &HAD, &H3D, &H4F, &H2D, &H5E, &H6D, &H5D, &H8D, &HED, &H7D, &H1E, &HBD, &H9E,
        &HD, &H4D, &H1D, &H2F, &H3D, &H4F, &H2D, &H3F, &H6D, &H5D, &H8D, &HE, &H7D, &H1E, &HBD, &HCE,
        &HD, &H4D, &H1D, &HAD, &H3D, &H9D, &H2D, &HCD, &H6D, &H5D, &H8F, &H2E, &H7D, &HDD, &H6E, &HAE,
        &HD, &H4D, &H1D, &H2F, &H3D, &H9D, &H2D, &H4E, &H6D, &H5D, &H8F, &H5F, &H7D, &HDD, &H6E, &HEE,
        &HD, &H4D, &H1D, &HAD, &H3D, &H4F, &H2D, &H5E, &H6D, &H5D, &H8F, &H2E, &HAF, &H1E, &H6E, &H1F,
        &HD, &H4D, &H1D, &H2F, &H3D, &H4F, &H2D, &H3F, &H6D, &H5D, &H8F, &H5F, &H7D, &H1E, &H6E, &HBF,
        &HD, &H4D, &H1D, &HAD, &H3D, &H9D, &H2D, &HCD, &H6D, &H5D, &H8D, &HED, &HAF, &H3E, &H7E, &HBE,
        &HD, &H4D, &H1D, &H2F, &H3D, &H9D, &H2D, &H4E, &H6D, &H5D, &H8D, &HE, &H7D, &H3E, &H7E, &HF,
        &HD, &H4D, &H1D, &HAD, &H3D, &H4F, &H2D, &H5E, &H6D, &H5D, &H8D, &HED, &HAF, &H7F, &H7E, &HFE,
        &HD, &H4D, &H1D, &H2F, &H3D, &H4F, &H2D, &H3F, &H6D, &H5D, &H8D, &HE, &HAF, &H7F, &H7E, &HCF,
        &HD, &H4D, &H1D, &HAD, &H3D, &H9D, &H2D, &HCD, &H6D, &H5D, &H8F, &H2E, &HAF, &H3E, &H9F, &HDE,
        &HD, &H4D, &H1D, &H2F, &H3D, &H9D, &H2D, &H4E, &H6D, &H5D, &H8F, &H5F, &HAF, &H3E, &H9F, &HDF,
        &HD, &H4D, &H1D, &HAD, &H3D, &H4F, &H2D, &H5E, &H6D, &H5D, &H8F, &H2E, &HAF, &H7F, &H9F, &HEF,
        &HD, &H4D, &H1D, &H2F, &H3D, &H4F, &H2D, &H3F, &H6D, &H5D, &H8F, &H5F, &HAF, &H7F, &H9F, &H6F}

    ' toost TileLoc for blocks drawn from the tilesheet
    Private Function BlockCell(id As Integer, flag As Integer) As Point
        Dim alt = (flag \ 4) Mod 2 = 1
        Select Case id
            Case 4 : Return If(alt, New Point(2, 43), New Point(1, 0))
            Case 5 : Return New Point(2, 0)
            Case 6 : Return New Point(6, 0)
            Case 21 : Return New Point(0, 4)
            Case 22 : Return New Point(6, 6)
            Case 23 : Return If(alt, New Point(6, 5), New Point(4, 0))
            Case 29 : Return New Point(3, 0)
            Case 63 : Return New Point(8, 7)
            Case 79 : Return If(alt, New Point(0, 43), New Point(1, 43))
            Case 99 : Return New Point(2, 23)
            Case 100 : Return If(alt, New Point(2, 21), New Point(3, 22))
            Case Else : Return New Point(-1, -1)
        End Select
    End Function

    Private ReadOnly PipeCells(,) As Point = {
        {New Point(14, 0), New Point(14, 2), New Point(11, 0), New Point(13, 0), New Point(12, 0), New Point(14, 1)},
        {New Point(6, 37), New Point(12, 37), New Point(4, 24), New Point(6, 24), New Point(5, 24), New Point(6, 38)},
        {New Point(10, 37), New Point(12, 38), New Point(3, 37), New Point(5, 37), New Point(4, 37), New Point(10, 38)},
        {New Point(8, 37), New Point(14, 37), New Point(0, 37), New Point(2, 37), New Point(1, 37), New Point(8, 38)}}

    ' Reads one area of a course file (encrypted .bcd or decrypted).
    Public Function ReadCourse(file() As Byte, subArea As Boolean) As ImportedMap
        Dim d = DecryptCourse(file)
        Dim style As String
        Select Case BitConverter.ToInt16(d, &HF1)
            Case 12621 : style = "M1"
            Case 13133 : style = "M3"
            Case 22349 : style = "MW"
            Case Else : style = ""
        End Select
        Dim title = Encoding.Unicode.GetString(d, &HF4, &H42)
        If title.Contains(ChrW(0)) Then title = title.Substring(0, title.IndexOf(ChrW(0)))
        Dim startY = CInt(d(0)), goalY = CInt(d(1)), goalX = CInt(BitConverter.ToInt16(d, 2))

        Dim a = If(subArea, &H2E0E0, &H200)
        Dim theme = Math.Min(9, CInt(d(a)))
        Dim w = Math.Max(1, BitConverter.ToInt32(d, a + 8) \ 16)
        Dim h = Math.Max(1, BitConverter.ToInt32(d, a + 12) \ 16)
        Dim map As New ImportedMap(w, h) With {.Title = title, .Style = style, .Theme = theme,
            .Night = (BitConverter.ToInt32(d, a + &H18) And 2) <> 0}

        ' ground, including what the game adds under the start and the goal
        Dim ground(w + 1, h + 1) As Boolean ' (x + 1, y + 1), y counted from the bottom
        Dim setGround = Sub(x As Integer, y As Integer)
                            If x >= 0 AndAlso y >= 0 AndAlso x < w AndAlso y < h Then ground(x + 1, y + 1) = True
                        End Sub
        For i = 0 To Math.Min(4000, BitConverter.ToInt32(d, a + &H3C)) - 1
            setGround(d(a + &H247A4 + i * 4), d(a + &H247A4 + i * 4 + 1))
        Next
        If Not subArea Then
            For x = 0 To 6
                For y = 0 To startY - 1
                    setGround(x, y)
                Next
            Next
            For x = CInt(Math.Round((goalX - 5) / 10.0, MidpointRounding.AwayFromZero)) To CInt(Math.Floor((goalX - 5) / 10.0 + 9))
                For y = 0 To goalY - 1
                    setGround(x, y)
                Next
            Next
        End If
        For x = 0 To w - 1
            For y = 0 To h - 1
                If Not ground(x + 1, y + 1) Then Continue For
                Dim code = If(ground(x, y + 2), 128, 0) Or If(ground(x + 2, y + 2), 64, 0) Or If(ground(x, y), 32, 0) Or
                           If(ground(x + 2, y), 16, 0) Or If(ground(x + 1, y + 2), 8, 0) Or If(ground(x, y + 1), 4, 0) Or
                           If(ground(x + 2, y + 1), 2, 0) Or If(ground(x + 1, y), 1, 0)
                map.SetTile(x, h - 1 - y, GroundCells(code) >> 4, GroundCells(code) And 15, True)
            Next
        Next

        For i = 0 To Math.Min(2600, BitConverter.ToInt32(d, a + &H1C)) - 1
            Dim o = a + &H48 + i * &H20
            Dim ox = BitConverter.ToInt32(d, o) / 160.0         ' blocks; horizontal centre
            Dim oy = BitConverter.ToInt32(d, o + 4) / 160.0     ' blocks; centre of the bottom row
            Dim ow = CInt(d(o + &HA)), oh = CInt(d(o + &HB))
            Dim flag = BitConverter.ToInt32(d, o + &HC)
            Dim id = CInt(BitConverter.ToInt16(d, o + &H18))
            Dim left = CInt(Math.Round(ox - ow / 2.0)), bottom = CInt(Math.Round(oy - 0.5))
            Dim topPx = (h - bottom) * 16           ' px from the top to the bottom edge of the object
            Dim big = (flag And &H4000) <> 0

            Select Case id
                Case 43 ' Spike Trap
                    For x = 0 To ow - 1
                        For y = 0 To oh - 1
                            map.Objects.Add(New MapObject With {.Type = ObjSpikeTrap, .X = (left + x) * 16, .Y = topPx - (y + 1) * 16})
                        Next
                    Next
                Case 57 ' Muncher
                    For x = 0 To ow - 1
                        For y = 0 To oh - 1
                            map.Objects.Add(New MapObject With {.Type = ObjMuncher, .X = (left + x) * 16, .Y = topPx - (y + 1) * 16})
                        Next
                    Next
                Case 2 ' Piranha Plant (fire ones too); direction 6 up, 4 down, 0/2 sideways (not simulated)
                    Select Case (flag >> 24) And 7
                        Case 6
                            map.Objects.Add(New MapObject With {.Type = If(big, ObjBigPiranha, ObjPiranha), .X = left * 16,
                                            .Y = topPx - If(big, 48, 24) + If(big, 32, 8)})
                        Case 4
                            ' hangs from the top edge of its first block
                            map.Objects.Add(New MapObject With {.Type = If(big, ObjBigPiranhaDown, ObjPiranhaDown), .X = left * 16,
                                            .Y = (h - bottom - If(big, 2, 1)) * 16})
                    End Select
                Case 68 ' Grinder: 3x3, centred on the middle of its blocks
                    Dim cx = CInt(Math.Round(ox * 16)), cy = (h - bottom) * 16 - ow * 8
                    map.Objects.Add(New MapObject With {.Type = ObjGrinder, .X = cx - 24, .Y = cy - 24})
                Case 9 ' Pipe
                    Dim pp = Math.Min(3, ((flag >> 16) And 15) \ 4)
                    Dim bx = CInt(Math.Round(ox - 0.5))
                    Select Case flag And &H7F
                        Case &H40 ' up
                            For j = 0 To oh - 1
                                Dim c = If(j = oh - 1, PipeCells(pp, 0), PipeCells(pp, 5))
                                map.SetTile(bx, h - 1 - (bottom + j), c.X, c.Y, True)
                                map.SetTile(bx + 1, h - 1 - (bottom + j), c.X + 1, c.Y, True)
                            Next
                        Case &H60 ' down
                            For j = 0 To oh - 1
                                Dim c = If(j = oh - 1, PipeCells(pp, 1), PipeCells(pp, 5))
                                map.SetTile(bx - 1, h - 1 - (bottom - j), c.X, c.Y, True)
                                map.SetTile(bx, h - 1 - (bottom - j), c.X + 1, c.Y, True)
                            Next
                        Case &H0 ' right
                            For j = 0 To oh - 1
                                Dim c = If(j = oh - 1, PipeCells(pp, 3), PipeCells(pp, 4))
                                map.SetTile(bx + j, h - 1 - bottom, c.X, c.Y, True)
                                map.SetTile(bx + j, h - bottom, c.X, c.Y + 1, True)
                            Next
                        Case &H20 ' left
                            For j = 0 To oh - 1
                                Dim c = If(j = oh - 1, PipeCells(pp, 2), PipeCells(pp, 4))
                                map.SetTile(bx - j, h - 2 - bottom, c.X, c.Y, True)
                                map.SetTile(bx - j, h - 1 - bottom, c.X, c.Y + 1, True)
                            Next
                    End Select
                Case Else
                    Dim c = BlockCell(id, flag)
                    If c.X >= 0 Then
                        For x = 0 To ow - 1
                            For y = 0 To oh - 1
                                map.SetTile(left + x, h - 1 - (bottom + y), c.X, c.Y, True)
                            Next
                        Next
                    End If
            End Select
        Next
        Return map
    End Function

    ' ------------------------------------------------------------------ fitting into the calculator

    ' Height (blocks) of the solid column at x, counted up from row "bottom" (from the bottom)
    Public Function ColumnHeight(map As ImportedMap, x As Integer, bottom As Integer) As Integer
        Dim n = 0
        Do While x >= 0 AndAlso x < map.Width AndAlso bottom + n < map.Height AndAlso map.Solid(x, map.Height - 1 - (bottom + n))
            n += 1
        Loop
        Return n
    End Function
End Module
