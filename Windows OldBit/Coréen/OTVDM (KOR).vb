Public Class OTVDM__KOR_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("설치로드 중 ...")
            Else
                MsgBox("호환 가능한 설치의 경우 Microsoft Visual C ++ 2015 재배포 가능 업데이트 3 RC를 설치하는 것이 좋습니다.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("설치로드 중 ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("설치로드 중 ...")
            Else
                MsgBox("호환 가능한 설치의 경우 Microsoft Visual C ++ 2015 재배포 가능 업데이트 3 RC를 설치하는 것이 좋습니다.")
                Process.Start("\build\otvdm.exe")
                MsgBox("설치로드 중 ...")
            End If
        End If
    End Sub
End Class