Public Class OTVDM__cs_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Načítání instalace ...")
            Else
                MsgBox("Pro kompatibilní instalaci doporučujeme nainstalovat Microsoft Visual C ++ 2015 Redistribuovatelná aktualizace 3 RC.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Načítání instalace ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Načítání instalace ...")
            Else
                MsgBox("Pro kompatibilní instalaci doporučujeme nainstalovat Microsoft Visual C ++ 2015 Redistribuovatelná aktualizace 3 RC.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Installation en cours...")
            End If
        End If
    End Sub
End Class