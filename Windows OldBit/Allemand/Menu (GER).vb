Public Class Menu__GER_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\GER\install.bat")
        MsgBox("Die Installation von NTVDMx64 ist im Gange.

Erstellt von leecher1337")
    End Sub

    Private Sub Menu__GER__FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__GER_.Show()
    End Sub
End Class