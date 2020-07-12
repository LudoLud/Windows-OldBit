Public Class Menu__cs_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\cs\install.bat")
        MsgBox("Probíhá instalace NTVDMx64.

Vytvořil leecher1337")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__cs_.Show()
    End Sub

    Private Sub Menu__cs__FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class