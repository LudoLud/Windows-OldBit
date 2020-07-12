Public Class OTVDM__pl_
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdmw.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Ładowanie instalacji ...")
            Else
                MsgBox("W celu zgodnej instalacji zalecamy zainstalowanie redystrybucyjnej aktualizacji 3 RC programu Microsoft Visual C ++ 2015.")
                Process.Start("\build\otvdmw.exe")
                MsgBox("Ładowanie instalacji ...")
            End If
        Else
            If Me.CheckBox1.CheckState = CheckState.Checked Then
                Process.Start("\build\otvdm.exe")
                Process.Start("\build\vc_redist.x86.exe")
                MsgBox("Ładowanie instalacji ...")
            Else
                MsgBox("W celu zgodnej instalacji zalecamy zainstalowanie redystrybucyjnej aktualizacji 3 RC programu Microsoft Visual C ++ 2015.")
                Process.Start("\build\otvdm.exe")
                MsgBox("Ładowanie instalacji ...")
            End If
        End If
    End Sub
End Class