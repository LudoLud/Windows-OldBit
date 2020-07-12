Public Class Menu__fr_
    Private Sub Menu__fr__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu__fr__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__fr_.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\fr\install.bat")
        MsgBox("L'installation de NTVDMx64 est en cours.

Créé par leecher1337")
    End Sub
End Class