Public Class Menu__CHT_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\CHT\install.bat")
        MsgBox("NTVDMx64的安裝正在進行中。

由leecher1337創建")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__CHT_.Show()
    End Sub



    Private Sub Menu__CHT__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class