Public Class Menu__CHS_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\CHS\install.bat")
        MsgBox("NTVDMx64的安装正在进行中。

由leecher1337创建")
    End Sub

    Private Sub Menu__CHS__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu__CHS__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__CHS_.Show()
    End Sub
End Class