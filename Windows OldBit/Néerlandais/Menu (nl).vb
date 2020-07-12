Public Class Menu__nl_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\nl\install.bat")
        MsgBox("De installatie van NTVDMx64 wordt uitgevoerd.

Vervaardigd door leecher1337")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__nl_.Show()
    End Sub

    Private Sub Menu__nl__FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class