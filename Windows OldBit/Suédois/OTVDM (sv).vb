Public Class OTVDM__sv_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Laddar installation ...")
            Else
                MsgBox("För kompatibel installation rekommenderar vi att du installerar Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Laddar installation ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Laddar installation ...")
            Else
                MsgBox("För kompatibel installation rekommenderar vi att du installerar Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Laddar installation ...")
            End If
        End If
    End Sub
End Class