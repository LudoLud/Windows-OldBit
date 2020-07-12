Public Class Menu__hu_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\hu\install.bat")
        MsgBox("Az NTVDMx64 telepítése folyamatban van.

Készítette: leecher1337")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__hu_.Show()
    End Sub

    Private Sub Menu__hu__FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class