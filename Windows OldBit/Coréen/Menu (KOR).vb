Public Class Menu__KOR_
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\KOR\install.bat")
        MsgBox("NTVDMx64 설치가 진행 중입니다.

만든 사람 leecher1337")
    End Sub

    Private Sub Menu__KOR__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu__KOR__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__KOR_.Show()
    End Sub
End Class