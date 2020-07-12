Public Class OTVDM__hu_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Telepítés betöltése...")
            Else
                MsgBox("A kompatibilis telepítéshez javasoljuk a Microsoft Visual C ++ 2015 újraelosztható frissítés 3 RC telepítését.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Telepítés betöltése...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Telepítés betöltése...")
            Else
                MsgBox("A kompatibilis telepítéshez javasoljuk a Microsoft Visual C ++ 2015 újraelosztható frissítés 3 RC telepítését.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Telepítés betöltése...")
            End If
        End If
    End Sub
End Class