﻿Public Class OTVDM__GER_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Installation laden ...")
            Else
                MsgBox("Für eine kompatible Installation empfehlen wir die Installation von Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Installation laden ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Installation laden ...")
            Else
                MsgBox("Für eine kompatible Installation empfehlen wir die Installation von Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Installation laden ...")
            End If
        End If
    End Sub
End Class