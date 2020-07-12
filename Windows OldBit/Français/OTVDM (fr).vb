Public Class OTVDM__fr_
    Private Sub OTVDM__fr__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Installation en cours...")
            Else
                MsgBox("Pour une installation compatible, nous vous recommandons d'installer Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Installation en cours...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Installation en cours...")
            Else
                MsgBox("Pour une installation compatible, nous vous recommandons d'installer Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Installation en cours...")
            End If
        End If
    End Sub
End Class