Public Class Menu__it_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\it\install.bat")
        MsgBox("L'installazione di NTVDMx64 è in corso.

Creato da leecher1337")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__it_.Show()
    End Sub

    Private Sub Menu__it__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu__it__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class