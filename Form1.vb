
Imports System.IO
Imports System.Reflection
Imports PgpCore

<Assembly: AssemblyVersion("1.0.0.1")>
<Assembly: AssemblyFileVersion("1.0.0.1")>

Public Class Form1
    Dim pgp As New PGP, sFile As New s_File, sPass As New s_Passwort, sReg As New s_Registry, eMail As New s_EMail

    Private Sub cmd_Keys_Erstellen_Click(sender As Object, e As EventArgs) Handles cmd_Keys_Erstellen.Click
        txt_Pfad.Text = sFile.FolderBrowserDialog(s_File.StartFolder.MyComputer, True)
        Dim sAdresse() As String = txt_eMail.Text.Split("@")
        pgp.GenerateKey(txt_Pfad.Text & "\" & sAdresse.First & "_public.asc", txt_Pfad.Text & "\" & sAdresse.First & "_private.asc", txt_eMail.Text, txt_Passwort.Text)
        sReg.SetValue(s_Registry.Reg.HKEY_CURRENT_USER, "Software\APP_PGP", "Key_Pfad", txt_Pfad.Text, Microsoft.Win32.RegistryValueKind.String)
        sReg.SetValue(s_Registry.Reg.HKEY_CURRENT_USER, "Software\APP_PGP", "Private_Key", txt_Pfad.Text & "\private.asc", Microsoft.Win32.RegistryValueKind.String)
        txt_Passwort.Text = ""
        txt_eMail.Text = ""

        Load_Keys()
        MessageBox.Show("Key(s) wurden erfolgreich erstellt")
    End Sub

    Private Sub cmd_DeCrypt_Click(sender As Object, e As EventArgs) Handles cmd_DeCrypt.Click
        txt_IN.Text = ""
        txt_Out.Text = ""
        txt_IN.Text = sFile.OpenFileDialog(My.Computer.FileSystem.SpecialDirectories.Desktop, "*.pgp|*.pgp")
        Dim Pfad As String = ""

        If txt_IN.Text <> "" Then
            Dim strFile() As String = txt_IN.Text.Split("\")
            For i = 0 To strFile.Length - 2
                Pfad = Pfad & strFile(i) & "\"
            Next

            Try
                Dim privateKey As FileInfo = New FileInfo(txt_P_Key.Text)
                Dim encryptionKeys As EncryptionKeys = New EncryptionKeys(privateKey, txt_DeCrypt.Text)
                Dim pgp As PGP = New PGP(encryptionKeys)

                pgp.DecryptFile(sFile.Left(txt_IN.Text, txt_IN.Text.Length - 4) & ".crypt", Pfad & "temp.txt")

                Dim Datei As String = IO.File.ReadAllText(Pfad & "temp.txt")

                txt_Out.Text = Pfad & Datei
                pgp.DecryptFile(txt_IN.Text.Trim, txt_Out.Text.Trim)
                IO.File.Delete(Pfad & "temp.txt")
                txt_DeCrypt.Text = ""
            Catch ex As Exception
                MessageBox.Show("Passwort oder Key sind falsch")
            End Try
        End If
    End Sub

    Private Sub cmd_Crypt_Text_Click(sender As Object, e As EventArgs) Handles cmd_Crypt_Text.Click
        If txt_Text.Text <> "" Then
            Dim strKey As String = txt_Pfad.Text & "\" & cbo_Keys_Text.SelectedIndex
            Dim publicKey As FileInfo = New FileInfo(strKey)
            Dim encryptionKeys As EncryptionKeys = New EncryptionKeys(publicKey)
            Dim pgp As PGP = New PGP(encryptionKeys)
            txt_Text.Text = pgp.EncryptArmoredString(txt_Text.Text)

            cbo_Keys_Text.SelectedIndex = -1
            cmd_Crypt_Text.Enabled = False

            Load_Keys()
        End If
    End Sub

    Private Sub cmd_DeCrypt_Text_Click(sender As Object, e As EventArgs) Handles cmd_DeCrypt_Text.Click
        Try
            Dim privateKey As FileInfo = New FileInfo(txt_P_Key.Text)
            Dim encryptionKeys As EncryptionKeys = New EncryptionKeys(privateKey, txt_DeCrypt_Text.Text)
            Dim pgp As PGP = New PGP(encryptionKeys)
            txt_Text.Text = pgp.DecryptArmoredString(txt_Text.Text)
        Catch ex As Exception
            MessageBox.Show("Passwort oder Key sind falsch")
        End Try
    End Sub

    Private Sub txt_DeCrypt_TextChanged(sender As Object, e As EventArgs) Handles txt_DeCrypt.TextChanged
        If txt_DeCrypt.Text <> "" Then
            cmd_DeCrypt.Enabled = True
        Else
            cmd_DeCrypt.Enabled = False
        End If
    End Sub

    Private Sub txt_DeCrypt_Text_TextChanged(sender As Object, e As EventArgs) Handles txt_DeCrypt_Text.TextChanged
        If txt_DeCrypt_Text.Text <> "" Then
            cmd_DeCrypt_Text.Enabled = True
        Else
            cmd_DeCrypt.Enabled = False
        End If
    End Sub

    Private Sub cmd_Crypt_Click(sender As Object, e As EventArgs) Handles cmd_Crypt.Click
        Dim List As New ListBox, strKey As String = "", Pfad As String = ""
        txt_IN.Text = ""
        txt_Out.Text = ""
        strKey = Application.StartupPath & "\" & cbo_Keys.SelectedItem.ToString.Trim

        If strKey <> "" Then
            Dim publicKey As FileInfo = New FileInfo(strKey)
            Dim encryptionKeys As EncryptionKeys = New EncryptionKeys(publicKey)
            txt_IN.Text = sFile.OpenFileDialog(My.Computer.FileSystem.SpecialDirectories.Desktop, "*.*|*.*")

            If txt_IN.Text <> "" Then
                Dim strFile() As String = txt_IN.Text.Split("\")
                For i = 0 To strFile.Length - 2
                    Pfad = Pfad & strFile(i) & "\"
                Next

                Dim sName As String = s_Passwort.GeneratePassword(10, True, True, True, False)
                sFile.WriteFile(Pfad & "temp.txt", strFile.Last, False)
                txt_Out.Text = Pfad & sName & ".pgp"
                Dim pgp As PGP = New PGP(encryptionKeys)
                pgp.EncryptFile(txt_IN.Text, txt_Out.Text)

                pgp.EncryptFile(Pfad & "temp.txt", Pfad & sName & ".crypt")
                IO.File.Delete(Pfad & "temp.txt")

                cbo_Keys.SelectedIndex = -1
                cmd_Crypt.Enabled = False
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Text = Text & " " & Application.ProductVersion
        Load_Keys()
    End Sub

    Private Sub cmd_Open_Click(sender As Object, e As EventArgs) Handles cmd_Open.Click
        txt_Pfad.Text = sFile.FolderBrowserDialog(s_File.StartFolder.MyComputer)
        sReg.SetValue(s_Registry.Reg.HKEY_CURRENT_USER, "Software\APP_PGP", "Key_Pfad", txt_Pfad.Text, Microsoft.Win32.RegistryValueKind.String)
        Load_Keys()
    End Sub

    Private Sub cbo_Keys_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_Keys.SelectedValueChanged
        If cbo_Keys.SelectedItem <> "" Then
            cmd_Crypt.Enabled = True
        End If
    End Sub

    Private Sub txt_Passwort_TextChanged(sender As Object, e As EventArgs) Handles txt_Passwort.TextChanged
        If txt_eMail.Text <> "" And txt_Passwort.Text <> "" Then
            cmd_Keys_Erstellen.Enabled = True
        Else
            cmd_Keys_Erstellen.Enabled = False
        End If
    End Sub

    Private Sub cmd_P_Key_Click(sender As Object, e As EventArgs) Handles cmd_P_Key.Click
        txt_P_Key.Text = sFile.OpenFileDialog("C:\", "*.asc|*.asc")
        sReg.SetValue(s_Registry.Reg.HKEY_CURRENT_USER, "Software\APP_PGP", "Private_Key", txt_P_Key.Text, Microsoft.Win32.RegistryValueKind.String)
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub txt_eMail_TextChanged(sender As Object, e As EventArgs) Handles txt_eMail.TextChanged
        If txt_eMail.Text <> "" And txt_Passwort.Text <> "" Then
            cmd_Keys_Erstellen.Enabled = True
        Else
            cmd_Keys_Erstellen.Enabled = False
        End If
    End Sub

    Private Sub cbo_Keys_Text_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_Keys_Text.SelectedValueChanged
        If cbo_Keys_Text.SelectedItem <> "" Then
            cmd_Crypt_Text.Enabled = True
        End If
    End Sub

    Private Sub Load_Keys()
        Dim List As New List(Of String), sName() As String, Pfad As String = "", pKey As String = ""
        cbo_Keys.Items.Clear()
        cbo_Keys_Text.Items.Clear()

        pKey = sReg.GetValue(s_Registry.Reg.HKEY_CURRENT_USER, "Software\APP_PGP", "Private_Key")
        If pKey <> "Fehler" Then
            txt_P_Key.Text = pKey
        End If

        Pfad = sReg.GetValue(s_Registry.Reg.HKEY_CURRENT_USER, "Software\APP_PGP", "Key_Pfad")
        If Pfad <> "Fehler" Then
            txt_Pfad.Text = Pfad

            sFile.GetFiles(txt_Pfad.Text, List, "*.asc", FileIO.SearchOption.SearchTopLevelOnly)

            For i = 0 To List.Count - 1
                sName = List.Item(i).Split("\")
                If sName.Last <> "private.asc" Then
                    cbo_Keys.Items.Add(sName.Last)
                    cbo_Keys_Text.Items.Add(sName.Last)
                End If
            Next
        End If
    End Sub

    Private Sub txt_eMail_LostFocus(sender As Object, e As EventArgs) Handles txt_eMail.LostFocus
        If eMail.CheckSyntax(txt_eMail.Text) = False Then
            MessageBox.Show("Syntax der Mail-Adresse nicht korrekt")
        End If
    End Sub
End Class
