Public Class OTVDM__it_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Caricamento installazione in corso ...")
            Else
                MsgBox("Per un'installazione compatibile, si consiglia di installare l'aggiornamento 3 ridistribuibile di Microsoft Visual C ++ 2015 RC.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Caricamento installazione in corso ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Caricamento installazione in corso ...")
            Else
                MsgBox("Per un'installazione compatibile, si consiglia di installare l'aggiornamento 3 ridistribuibile di Microsoft Visual C ++ 2015 RC.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Caricamento installazione in corso ...")
            End If
        End If
    End Sub
End Class