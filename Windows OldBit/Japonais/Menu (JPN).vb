Public Class Menu__JPN_

    Private Sub Menu__JPN__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__JPN_.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\JPN\install.bat")
        MsgBox("NTVDMx64のインストールが進行中です。

作成者：leecher1337")
    End Sub

    Private Sub Menu__JPN__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class