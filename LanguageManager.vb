Imports System.Collections.Specialized.BitVector32

Public Class LanguageManager

    Public Const tooltipIdentifier As String = ".tooltip"

    Private Shared Contents As Dictionary(Of String, Dictionary(Of String, String))
    Private Shared Lists As Dictionary(Of String, List(Of String))

    Public Shared Sub Load(ByVal LangFile() As String)
        Contents = New Dictionary(Of String, Dictionary(Of String, String))()
        Lists = New Dictionary(Of String, List(Of String))()

        Dim ListMode As Boolean = False
        Dim CurrentSection As Dictionary(Of String, String) = Nothing
        Dim CurrentList As List(Of String) = Nothing

        For Each Line As String In LangFile
            Dim CheckLine As String = Line.Trim()
            If CheckLine = "" Then Continue For
            If CheckLine(0) = ";"c Then Continue For

            If CheckLine.StartsWith("[") AndAlso CheckLine.EndsWith("]") Then
                Dim SectionName As String = CheckLine.Substring(1, CheckLine.Length - 2)

                If SectionName.StartsWith("LIST_") Then
                    CurrentList = New List(Of String)()
                    Lists(SectionName.Substring(5)) = CurrentList
                    ListMode = True
                Else
                    If Contents.ContainsKey(SectionName) Then
                        CurrentSection = Contents(SectionName)
                    Else
                        CurrentSection = New Dictionary(Of String, String)()
                        Contents(SectionName) = CurrentSection
                    End If
                    ListMode = False
                End If
            Else
                If ListMode Then
                    CurrentList.Add(CheckLine)
                Else
                    If CheckLine.Contains("=") Then
                        Dim EqPos As Integer = CheckLine.IndexOf("="c)
                        CurrentSection(CheckLine.Substring(0, EqPos)) = CheckLine.Substring(EqPos + 1).Replace("\n", vbLf)
                    End If
                End If
            End If
        Next
    End Sub

    Public Shared Function GetText(ByVal Area As String, ByVal Key As String) As String
        If Contents Is Nothing Then Return "<NOT LOADED>"

        If Contents.ContainsKey(Area) Then
            Dim Referred = Contents(Area)
            If Referred.ContainsKey(Key) Then
                Return Referred(Key)
            End If
        End If

        Return String.Format("<ERROR {0}:{1}>", Area, Key)
    End Function

    Public Shared Function GetText(ByVal Area As String, ByVal Number As Integer) As String
        If Contents Is Nothing Then Return "<NOT LOADED>"

        If Contents.ContainsKey(Area) Then
            Dim keys(Contents(Area).Keys.Count - 1) As String
            Contents(Area).Keys.CopyTo(keys, 0)
            Return Contents(Area)(keys(Number))
        End If

        Return String.Format("<ERROR {0}:{1}>", Area, Number)
    End Function

    Public Shared Function GetList(ByVal Name As String) As List(Of String)
        If Lists Is Nothing Then Return New List(Of String)(New String() {"<NOT LOADED>"})

        If Lists.ContainsKey(Name) Then
            Return Lists(Name)
        End If

        Return New List(Of String)(New String() {String.Format("<ERROR {0}>", Name)})
    End Function

    Public Shared Sub ApplyToContainer(ByVal Container As Control, ByVal Area As String, Optional ByVal tooltip As ToolTip = Nothing)
        If Contents Is Nothing Then Return

        If Contents.ContainsKey(Area) Then
            Dim Referred = Contents(Area)

            ApplyToContainer(Container, Referred, tooltip)

            If Referred.ContainsKey("_TITLE") Then
                Container.Text = Referred("_TITLE")
            End If
        Else
            MessageBox.Show(Area & " was missing from the language file." & vbLf & "The editor cannot continue.",
            "SMM2 Calculator",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Shared Sub ApplyToContainer(ByVal Container As Control, ByVal Referred As Dictionary(Of String, String), Optional ByVal tooltip As ToolTip = Nothing)
        For Each ctrl As Control In Container.Controls
            If Referred.ContainsKey(ctrl.Name) Then
                ctrl.Text = Referred(ctrl.Name)
            End If

            If tooltip IsNot Nothing AndAlso Referred.ContainsKey(ctrl.Name & tooltipIdentifier) Then
                tooltip.SetToolTip(ctrl, Referred(ctrl.Name & tooltipIdentifier))
            End If

            If TypeOf ctrl Is ToolStrip Then
                Dim TS = DirectCast(ctrl, ToolStrip)
                For Each TSItem As ToolStripItem In TS.Items
                    If Referred.ContainsKey(TSItem.Name) Then
                        TSItem.Text = Referred(TSItem.Name)
                    End If

                    If Referred.ContainsKey(TSItem.Name & tooltipIdentifier) Then
                        TSItem.ToolTipText = Referred(TSItem.Name & tooltipIdentifier)
                    End If

                    If TypeOf TSItem Is ToolStripMenuItem Then
                        Dim menuItem = DirectCast(TSItem, ToolStripMenuItem)
                        If menuItem.HasDropDownItems Then
                            ApplyToToolStripMenuItemRecursive(menuItem, Referred)
                        End If
                    End If
                Next
            End If

            If ctrl.Controls.Count > 0 Then
                ApplyToContainer(ctrl, Referred, tooltip)
            End If
        Next
    End Sub

    Private Shared Sub ApplyToToolStripMenuItemRecursive(ByVal parent As ToolStripMenuItem, ByVal Referred As Dictionary(Of String, String))
        For Each subItem As ToolStripItem In parent.DropDownItems
            If Not String.IsNullOrEmpty(subItem.Name) AndAlso Referred.ContainsKey(subItem.Name) Then
                subItem.Text = Referred(subItem.Name)
            End If

            If TypeOf subItem Is ToolStripMenuItem Then
                Dim subMenuItem = DirectCast(subItem, ToolStripMenuItem)
                If subMenuItem.HasDropDownItems Then
                    ApplyToToolStripMenuItemRecursive(subMenuItem, Referred)
                End If
            End If
        Next
    End Sub
End Class

'ATTEMPT TO TRY TO MAKE COMMAND TRANSLATIONS FROM .INI FILE BUT FAILED

'Public Module LocalizationManager
'    Public Sections As New Dictionary(Of String, Dictionary(Of String, String))()

'    Public Function GetCommandKey(localizedCommand As String) As String
'        If Sections.ContainsKey("LIST_Commands") Then
'            For Each kvp In Sections("LIST_Commands")
'                If kvp.Value = localizedCommand Then
'                    Return kvp.Key
'                End If
'            Next
'        End If
'        Return Nothing
'    End Function

'    Public Function GetCommandText(key As String) As String
'        If Sections.ContainsKey("LIST_Commands") AndAlso Sections("LIST_Commands").ContainsKey(key) Then
'            Return Sections("LIST_Commands")(key)
'        End If
'        Return key
'    End Function
'End Module