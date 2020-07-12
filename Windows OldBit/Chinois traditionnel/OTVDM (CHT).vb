Public Class OTVDM__CHT_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("正在載入安裝...")
            Else
                MsgBox("對於兼容安裝，我們建議安裝Microsoft Visual C ++ 2015 Redistributable Update 3 RC。")
                Process.Start("\build\otvdmw.exe")
                MsgBox("正在載入安裝...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("正在載入安裝...")
            Else
                MsgBox("對於兼容安裝，我們建議安裝Microsoft Visual C ++ 2015 Redistributable Update 3 RC。")
                Process.Start("\build\otvdm.exe")
                MsgBox("正在載入安裝...")
            End If
        End If
    End Sub
End Class