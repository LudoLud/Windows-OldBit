Public Class OTVDM__nl_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Installatie laden ...")
            Else
                MsgBox("Voor een compatibele installatie raden we aan Microsoft Visual C ++ 2015 Redistributable Update 3 RC te installeren.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Installatie laden ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Installatie laden ...")
            Else
                MsgBox("Voor een compatibele installatie raden we aan Microsoft Visual C ++ 2015 Redistributable Update 3 RC te installeren.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Installatie laden ...")
            End If
        End If
    End Sub
End Class