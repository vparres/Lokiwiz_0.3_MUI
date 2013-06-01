
Public Class LokiwizFR
    Private Sub BT_DESIMLOCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DESIMLOCK.Click
        If MsgBox("Souhaitez-vous vraiment effectuer cette opération ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Avertissement") = MsgBoxResult.Yes Then
            MsgBox("Rappel : Cette opération est faite sous votre seule responsabilitée", MsgBoxStyle.Information, "Petite précision")
            MsgBox("Installez EnableRAPI.cab sur votre téléphone puis cliquez sur OK", MsgBoxStyle.Information, "Pré-requis")
            MsgBox("Connectez maintenant vote appareil et appuyez sur OK", MsgBoxStyle.Information, "Connexion")
            MsgBox("Ne fermez pas les fenêtres de commandes Windows (CMD.EXE) !", MsgBoxStyle.SystemModal, "Dernier Point")
            Shell("Utils\pdocread.exe -n 1 0x000000 0x10000 -b 0x4000 lock_backup.bin")
            Shell("Utils\wizardunlock.exe lock_backup.bin -nolock -w unlocked.bin")
            Shell("Utils\pdocwrite.exe -n 1 -b 0x4000 unlocked.bin 0x000000 0x010000")
            Shell("Utils\preboot.exe")
            MsgBox("Votre appareil est maintenant Désimlocké !", MsgBoxStyle.Information, "Effectué")
            MsgBox("Conservez précieusement le fichier lock_backup.bin, car il peut servir en cas de problèmes :)", MsgBoxStyle.Critical, "Attention")
            MsgBox("'Standing on the shoulder of giants' Ricardo Afonso, 2005", MsgBoxStyle.SystemModal, "Note de fin")
        End If
    End Sub

    Private Sub BT_SIMLOCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SIMLOCK.Click
        If MsgBox("Souhaitez-vous vraiment effectuer cette opération ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Avertissement") = MsgBoxResult.Yes Then
            MsgBox("Rappel : Cette opération est faite sous votre seule responsabilitée", MsgBoxStyle.Information, "Petite précision")
            MsgBox("Installez EnableRAPI.cab sur votre téléphone puis cliquez sur OK", MsgBoxStyle.Exclamation, "Pré-requis")
            MsgBox("Connectez maintenant vote appareil et appuyez sur OK", MsgBoxStyle.Exclamation, "Connexion")
            MsgBox("Ne fermez pas les fenêtres de commandes Windows (CMD.EXE) !", MsgBoxStyle.SystemModal, "Dernier Point")
            Shell("Utils\pdocread.exe -n 1 0x000000 0x10000 -b 0x4000 lock_backup.bin")
            Shell("Utils\wizardunlock.exe lock_backup.bin -lock -w locked.bin")
            Shell("Utils\pdocwrite.exe -n 1 -b 0x4000 locked.bin 0x000000 0x010000")
            Shell("Utils\preboot.exe")
            MsgBox("Votre appareil est maintenant Simlocké !", MsgBoxStyle.Information, "Effectué")
            MsgBox("Conservez précieusement le fichier lock_backup.bin, car il peut servir en cas de problèmes :)", MsgBoxStyle.Critical, "Attention")
            MsgBox("'Standing on the shoulder of giants' Ricardo Afonso, 2005", MsgBoxStyle.SystemModal, "Note de fin")
        End If
    End Sub

    Private Sub BT_SCID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SCID.Click
        If MsgBox("Souhaitez-vous vraiment effectuer cette opération ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Avertissement") = MsgBoxResult.Yes Then
            MsgBox("Rappel : Cette opération est faite sous votre seule responsabilitée", MsgBoxStyle.Information, "Petite précision")
            MsgBox("Installez EnableRAPI.cab sur votre téléphone puis cliquez sur OK", MsgBoxStyle.Information, "Pré-requis")
            MsgBox("Connectez maintenant vote appareil et appuyez sur OK", MsgBoxStyle.Information, "Connexion")
            MsgBox("Ne fermez pas les fenêtres de commandes Windows (CMD.EXE) !", MsgBoxStyle.SystemModal, "Dernier Point")
            Shell("Utils\pdocread.exe -n 1 0x000000 0x10000 -b 0x4000 lock_backup.bin")
            Shell("Utils\wizardunlock.exe lock_backup.bin -c 11111111 -w cidunlocked.bin")
            Shell("Utils\pdocwrite.exe -n 1 -b 0x4000 cidunlocked.bin 0x000000 0x010000")
            Shell("Utils\preboot.exe")
            MsgBox("Votre appareil est maintenant Simlocké !", MsgBoxStyle.Information, "Effectué")
            MsgBox("Conservez précieusement le fichier lock_backup.bin, car il peut servir en cas de problèmes :)", MsgBoxStyle.Critical, "Attention")
            MsgBox("'Standing on the shoulder of giants' Ricardo Afonso, 2005", MsgBoxStyle.SystemModal, "Note de fin")
        End If
    End Sub

    Private Sub BT_CLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_CLOSE.Click
        End
    End Sub
End Class
