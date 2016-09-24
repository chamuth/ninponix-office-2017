Public Class Form1
    Dim open = True

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If open Then
            If Not Opacity = 1 Then
                Opacity += 0.1
            End If
        Else
            If Not Opacity = 0 Then
                Opacity -= 0.1
            Else
                End
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (Environment.CommandLine.Replace("""", "").Replace(Application.ExecutablePath, "").EndsWith(".nvldoc") Or Environment.CommandLine.Replace("""", "").Replace(Application.ExecutablePath, "").EndsWith(".nvlexp") Or Environment.CommandLine.Replace("""", "").Replace(Application.ExecutablePath, "").EndsWith("-edit")) Then
            End
            Application.Exit()
        End If
    End Sub

    Dim count = 0

    Private Sub SuperLocation_Tick(sender As Object, e As EventArgs) Handles SuperLocation.Tick
        count += 1

        Select Case count
            Case 1
                Try
                    Process.Start(Application.ExecutablePath.Replace("VD_Launcher.exe", "") + "Ninponix Office.exe", Environment.CommandLine.Replace(Application.ExecutablePath, "").Replace("""", "").ToString())
                Catch ex As Exception
                    open = False
                    MessageBox.Show("Cannot access Ninponix Office.exe, make sure Ninponix Office has installed successfully on your computer.", "Ninponix Office 2017", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Case 200
                open = False
                SuperLocation.Stop()
        End Select
    End Sub
End Class
