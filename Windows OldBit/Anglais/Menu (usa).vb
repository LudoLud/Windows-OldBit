Public Class Menu__usa_

    Private Sub Menu__usa__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__usa_.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\usa\install.bat")
        MsgBox("Installation of NTVDMx64 is in progress.

Created by leecher1337")
    End Sub

    Private Sub Menu__usa__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class