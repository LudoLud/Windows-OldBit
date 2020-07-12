Public Class Menu__ru_


    Private Sub Menu__ru__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\ru\install.bat")
        MsgBox("Установка NTVDMx64.

Создано leecher1337")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__ru_.Show()
    End Sub

    Private Sub Menu__ru__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class