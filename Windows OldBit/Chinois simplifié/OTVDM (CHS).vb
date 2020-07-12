Public Class OTVDM__CHS_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("正在载入安装...")
            Else
                MsgBox("对于兼容安装，我们建议安装Microsoft Visual C ++ 2015 Redistributable Update 3 RC。")
                Process.Start("\build\otvdmw.exe")
                MsgBox("正在载入安装...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("正在载入安装...")
            Else
                MsgBox("对于兼容安装，我们建议安装Microsoft Visual C ++ 2015 Redistributable Update 3 RC。")
                Process.Start("\build\otvdm.exe")
                MsgBox("正在载入安装...")
            End If
        End If
    End Sub
End Class