Public Class Langue
    'Chargement
    Private Sub Langue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Environment.Is64BitOperatingSystem = True Then

        Else
            MsgBox("Your operating system must be 64-bit. Otherwise, some majors problems may arise.")
            End
        End If
        If My.Computer.Info.OSFullName.Contains("10") Then

        Else
            If My.Computer.Info.OSFullName.Contains("8") Then
                MsgBox("Your operating system requires Windows 10 or higher.")
                End
            Else
                MsgBox("Your operating system requires Windows 10 or higher. You are using an older version and no longer supported by Microsoft. We recommend that you upgrade to Windows 10.")
                End
            End If
        End If
    End Sub

    'Français
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As Integer = MessageBox.Show("Vous avez choisi ""Français"". Nous vous recommandons de sauvegarder vos données car la désinstallation de NTVDMx64 peux laissez quelque fichier restant. Continuer?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__fr_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Espagnol
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim result As Integer = MessageBox.Show("Has elegido ""Español"". Recomendamos que haga una copia de seguridad de sus datos porque la desinstalación de NTVDMx64 puede dejar algunos archivos restantes. ¿Seguir?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__es_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Allemand
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result As Integer = MessageBox.Show("Sie haben ""Deutsch"" gewählt. Wir empfehlen, dass Sie Ihre Daten sichern, da bei der Deinstallation von NTVDMx64 möglicherweise einige Dateien übrig bleiben. Mach weiter?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__GER_.Visible = True
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Japonais
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim result As Integer = MessageBox.Show("「日本語」を選択しました。 NTVDMx64をアンインストールすると一部のファイルが残る場合があるため、データをバックアップすることをお勧めします。続ける？", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__JPN_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Coréen
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim result As Integer = MessageBox.Show("""한국어""를 선택했습니다. NTVDMx64를 제거하면 일부 파일이 남아있을 수 있으므로 데이터를 백업하는 것이 좋습니다. 계속 하시겠습니까?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__KOR_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Russe
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim result As Integer = MessageBox.Show("Вы выбрали ""русский"". Мы рекомендуем сделать резервную копию ваших данных, потому что удаление NTVDMx64 может оставить некоторые файлы. Продолжать?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__ru_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Anglais
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim result As Integer = MessageBox.Show("You have chosen ""English"". We recommend that you back up your data because uninstalling NTVDMx64 may leave some files remaining. Carry on?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__usa_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Chinois simplifié
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("您选择了““简体中文””。我们建议您备份数据，因为卸载NTVDMx64可能会留下一些文件。继续？", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__CHS_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Chinois traditionnel
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As Integer = MessageBox.Show("您選擇了““繁體中文””。我們建議您保存數據，因為卸載NTVDMx64可能會留下某些文件。繼續嗎？", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__CHT_.Show()
        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Italien
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim result As Integer = MessageBox.Show("Hai scelto ""Italiano"". È consigliabile eseguire il backup dei dati poiché la disinstallazione di NTVDMx64 potrebbe lasciare alcuni file. Continuare?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__it_.Show()

        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Hongrois
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim result As Integer = MessageBox.Show("Ön a ""Magyar"" választotta. Javasoljuk, hogy készítsen biztonsági másolatot az adatokról, mert az NTVDMx64 eltávolításakor néhány fájl maradhat. Folytasd?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__hu_.Show()

        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Néerlandais
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim result As Integer = MessageBox.Show("U heeft gekozen voor ""Nederlands"". We raden u aan een back-up van uw gegevens te maken, omdat bij het verwijderen van NTVDMx64 mogelijk enkele bestanden overblijven. Doorgaan?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__nl_.Show()

        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Tchèque
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Vybrali jste ""Czech"". Doporučujeme zálohovat data, protože odinstalace NTVDMx64 může některé soubory ponechat. Pokračovat?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__cs_.Show()

        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Suédois
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim result As Integer = MessageBox.Show("Du har valt ""Svenska"". Vi rekommenderar att du säkerhetskopierar dina data eftersom avinstallering av NTVDMx64 kan lämna vissa filer kvar. Fortsätt?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__sv_.Show()

        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Portugais
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim result As Integer = MessageBox.Show("Você escolheu ""Português"". Recomendamos que você faça backup dos seus dados porque a desinstalação do NTVDMx64 pode deixar alguns arquivos restantes. Continue?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__pt_.Show()

        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Polonais
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim result As Integer = MessageBox.Show("Wybrałeś „Polski””. Zalecamy wykonanie kopii zapasowej danych, ponieważ odinstalowanie NTVDMx64 może pozostawić niektóre pliki. Kontynuować?", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            Menu__pl_.Show()

        ElseIf result = DialogResult.No Then

        End If


    End Sub

    'Désinstaller
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Do you want to uninstall NTVDMx64?
(To uninstall WineVDM, uninstall it in the control panel.)

Warning! Some files will still be present. It was therefore important to make a backup of your data.", "Windows OldBit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Process.Start("\build\uninstall\uninstall.bat")
            MsgBox("Install in process... Restart your computer after uninstalling.

Warning! Some files will still be present. It was therefore important to make a backup of your data.", "Windows OldBit")
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    'Boutton Quitter
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        End
    End Sub
End Class
