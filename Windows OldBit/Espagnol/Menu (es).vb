Public Class Menu__es_


    Private Sub Menu__es__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__es_.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\es\install.bat")
        MsgBox("La instalación de NTVDMx64 está en progreso.

Creado por leecher1337")
    End Sub

    Private Sub Menu__es__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class