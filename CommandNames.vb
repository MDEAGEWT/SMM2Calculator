Imports System.IO

' Command names for the command box.
' MarioMove dispatches on the canonical (Chinese) name. Each language file may list names for
' the commands in a [COMMANDS] section, e.g.
'     右走=RightWalk|OldName
' The first name is the one shown in the UI; every name is accepted as input, whatever the
' current UI language is. CommandTexts.txt from older releases (中文=English) still works too.
Module CommandNames
    Private Structure CmdAlias
        Dim Cn As String
        Dim Lang As String
    End Structure

    Private ReadOnly Aliases As New Dictionary(Of String, CmdAlias)(StringComparer.OrdinalIgnoreCase)
    Private ReadOnly Names As New Dictionary(Of String, String) ' Lang & vbTab & Cn -> first name
    Private DisplayLang As String = ""

    Public Sub LoadCommandNames(langDir As String, currentLang As String, legacyFile As String)
        Aliases.Clear()
        Names.Clear()
        DisplayLang = ""

        Dim files As New List(Of String)
        If Directory.Exists(langDir) Then files.AddRange(Directory.GetFiles(langDir, "*.ini"))
        ' The current language goes first so its spelling wins if two languages share one.
        files = files.OrderBy(Function(f) If(Path.GetFileNameWithoutExtension(f) = currentLang, 0, 1)).ToList()

        For Each f In files
            Dim lang = Path.GetFileNameWithoutExtension(f)
            Dim section = ReadCommandSection(File.ReadAllLines(f))
            For Each kv In section
                AddNames(kv.Key, kv.Value.Split("|"c), lang)
            Next
            If section.Count > 0 AndAlso lang = currentLang Then DisplayLang = lang
        Next

        If File.Exists(legacyFile) Then
            For Each line In File.ReadAllLines(legacyFile)
                Dim p = line.Split("="c)
                If p.Length >= 2 Then AddNames(p(0), {p(1)}, "CommandTexts")
            Next
        End If
    End Sub

    Private Function ReadCommandSection(lines() As String) As List(Of KeyValuePair(Of String, String))
        Dim result As New List(Of KeyValuePair(Of String, String))
        Dim inSection = False
        For Each raw In lines
            Dim line = raw.Trim()
            If line = "" OrElse line.StartsWith(";") Then Continue For
            If line.StartsWith("[") AndAlso line.EndsWith("]") Then
                inSection = String.Equals(line, "[COMMANDS]", StringComparison.OrdinalIgnoreCase)
            ElseIf inSection AndAlso line.Contains("=") Then
                Dim eq = line.IndexOf("="c)
                result.Add(New KeyValuePair(Of String, String)(line.Substring(0, eq).Trim(), line.Substring(eq + 1)))
            End If
        Next
        Return result
    End Function

    Private Sub AddNames(cn As String, newNames() As String, lang As String)
        cn = cn.Trim()
        If cn = "" Then Exit Sub
        For Each n In newNames
            Dim name = n.Trim()
            If name = "" Then Continue For
            If Not Names.ContainsKey(lang & vbTab & cn) Then Names(lang & vbTab & cn) = name
            If Not Aliases.ContainsKey(name) Then Aliases(name) = New CmdAlias With {.Cn = cn, .Lang = lang}
        Next
    End Sub

    ' Cn = True: canonical name used by MarioMove. Cn = False: name to show in the UI.
    Public Function GetCnCmd(cmd As String, Cn As Boolean) As String
        Dim a As CmdAlias = Nothing
        Dim known = Aliases.TryGetValue(cmd, a)
        Dim canonical = If(known, a.Cn, cmd)
        If Cn Then Return canonical

        Dim name As String = Nothing
        If DisplayLang <> "" AndAlso Names.TryGetValue(DisplayLang & vbTab & canonical, name) Then Return name
        If known AndAlso Names.TryGetValue(a.Lang & vbTab & canonical, name) Then Return name
        Return cmd
    End Function

    ' Left/right mirror of one command, answered in the language it was written in.
    Public Function MirrorCmd(cmd As String) As String
        Dim a As CmdAlias = Nothing
        Dim known = Aliases.TryGetValue(cmd, a)
        Dim canonical = If(known, a.Cn, cmd)
        Dim mirrored = canonical.Replace("右", vbNullChar).Replace("左", "右").Replace(vbNullChar, "左")
        If mirrored = canonical Then
            mirrored = canonical.Replace("Right", vbNullChar).Replace("Left", "Right").Replace(vbNullChar, "Left")
        End If

        Dim name As String = Nothing
        If known AndAlso Names.TryGetValue(a.Lang & vbTab & mirrored, name) Then Return name
        Return mirrored
    End Function

    ' Applies f to the command part of every token ("右走12" -> f("右走") & "12"),
    ' leaving notes such as "[12+3]" untouched.
    Public Function MapCmdText(text As String, f As Func(Of String, String)) As String
        Dim tokens = text.Split(" "c)
        For i = 0 To tokens.Length - 1
            Dim t = tokens(i)
            If t.Length = 0 OrElse t.Contains("[") Then Continue For
            Dim n = 0
            Do While n < t.Length AndAlso Not IsNumeric(t(n).ToString())
                n += 1
            Loop
            tokens(i) = f(t.Substring(0, n)) & t.Substring(n)
        Next
        Return String.Join(" ", tokens)
    End Function

    Public Function CmdTextToCn(text As String) As String
        Return MapCmdText(text, Function(c) GetCnCmd(c, True))
    End Function

    Public Function CmdTextToDisplay(text As String) As String
        Return MapCmdText(text, Function(c) GetCnCmd(c, False))
    End Function

    Public Function MirrorCmdText(text As String) As String
        Return MapCmdText(text, AddressOf MirrorCmd)
    End Function
End Module
