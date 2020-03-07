Imports System
Imports System.IO


Public Class FrmStudyNotifier

    Dim ad As String = AppDomain.CurrentDomain.BaseDirectory
    Dim cache As String = "C:\ProgramData\NovaRad\NovaPACS\Images\Cache"
    Dim mylist As String = ""
    Public Sub findwhich()
        If File.Exists(cache) = False Then
            cache = "C:\Documents and Settings\All Users\Application Data\NovaRad\NovaPACS\Images\Cache"
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        findwhich()
        Me.MaximizeBox = False
        My.Computer.Audio.Play(ad & "pop.wav", AudioPlayMode.Background)
        If Directory.Exists(cache) = False Then
            Directory.CreateDirectory(cache)
        End If
        For Each Dir As String In Directory.GetDirectories(cache)
            For Each subdir As String In Directory.GetDirectories(Dir)
                For Each suid As String In Directory.GetDirectories(subdir)
                    Dim name As String = suid.Replace(subdir & "\", "")
                    mylist &= name & " "
                Next
            Next
        Next
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            For Each Dir As String In Directory.GetDirectories(cache)
                For Each subdir As String In Directory.GetDirectories(Dir)
                    For Each suid As String In Directory.GetDirectories(subdir)
                        Dim mrn As String = subdir.Replace(Dir & "\", "")
                        Dim name As String = suid.Replace(subdir & "\", "")
                        If mylist.Contains(name) = False Then
                            My.Computer.Audio.Play(ad & "pop.wav", AudioPlayMode.Background)
                            TxtMRN.Text = mrn
                            mylist &= name & " "
                        End If
                    Next
                Next
            Next
        Catch ex As Exception
            Directory.CreateDirectory(cache)
        End Try
    End Sub

    Private Sub BtnToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToggle.Click
        If BtnToggle.Text = "Stop" Then
            BtnToggle.Text = "Start"
            Timer1.Enabled = False
        Else
            BtnToggle.Text = "Stop"
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub BtnCopyMRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopyMRN.Click
        Dim t As Boolean = False

        If TxtMRN.Text <> "" Then
            Do Until t = True
                Try
                    Windows.Forms.Clipboard.SetText(TxtMRN.Text)
                    t = True
                Catch ex As Exception
                End Try
            Loop
        End If
    End Sub

    Private Sub BtnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTop.Click
        If BtnTop.Text = "Not Top" Then
            BtnTop.Text = "Top Most"
            Me.TopMost = True
        Else
            BtnTop.Text = "Not Top"
            Me.TopMost = False
        End If
    End Sub
End Class
