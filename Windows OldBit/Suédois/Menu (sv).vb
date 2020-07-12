Public Class Menu__sv_
    Private Sub Menu__sv__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu__sv__FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("\build\sv\install.bat")
        MsgBox("Installationen av NTVDMx64 pågår.

Skapad av leecher1337")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OTVDM__sv_.Show()
    End Sub
End Class