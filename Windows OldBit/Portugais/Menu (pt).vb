Public Class Menu__pt_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\pt\install.bat")
        MsgBox("A instalação do NTVDMx64 está em andamento.

Criado por leecher1337")
    End Sub

    Private Sub Menu__pt__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu__pt__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__pt_.Show()
    End Sub
End Class