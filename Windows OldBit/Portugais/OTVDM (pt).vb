﻿Public Class OTVDM__pt_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Carregando instalação ...")
            Else
                MsgBox("Para uma instalação compatível, recomendamos a instalação do Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Carregando instalação ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Carregando instalação ...")
            Else
                MsgBox("Para uma instalação compatível, recomendamos a instalação do Microsoft Visual C ++ 2015 Redistributable Update 3 RC.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Carregando instalação ...")
            End If
        End If
    End Sub
End Class