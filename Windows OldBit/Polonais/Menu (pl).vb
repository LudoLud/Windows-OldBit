Public Class Menu__pl_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\pl\install.bat")
        MsgBox("Trwa instalacja NTVDMx64.

Utworzony przez leecher1337")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__pl_.Show()
    End Sub

    Private Sub Menu__pl__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu__pl__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class