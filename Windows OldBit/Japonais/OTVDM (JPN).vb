Public Class OTVDM__JPN_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("インストールを読み込んでいます...")
            Else
                MsgBox("互換性のあるインストールを行うには、Microsoft Visual C ++ 2015 Redistributable Update 3 RCをインストールすることをお勧めします。")
                Process.Start("\build\otvdmw.exe")
                MsgBox("インストールを読み込んでいます...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("インストールを読み込んでいます...")
            Else
                MsgBox("互換性のあるインストールを行うには、Microsoft Visual C ++ 2015 Redistributable Update 3 RCをインストールすることをお勧めします。")
                Process.Start("\build\otvdm.exe")
                MsgBox("インストールを読み込んでいます...")
            End If
        End If
    End Sub
End Class