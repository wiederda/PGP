<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_Text = New System.Windows.Forms.TextBox()
        Me.cmd_Crypt_Text = New System.Windows.Forms.Button()
        Me.cmd_DeCrypt_Text = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_Keys = New System.Windows.Forms.ComboBox()
        Me.chk_Delete = New System.Windows.Forms.CheckBox()
        Me.cmd_DeCrypt = New System.Windows.Forms.Button()
        Me.txt_DeCrypt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Out = New System.Windows.Forms.TextBox()
        Me.cmd_Crypt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_IN = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_Keys_Text = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_DeCrypt_Text = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_P_Key = New System.Windows.Forms.Button()
        Me.txt_P_Key = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmd_Open = New System.Windows.Forms.Button()
        Me.txt_Pfad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Passwort = New System.Windows.Forms.TextBox()
        Me.txt_eMail = New System.Windows.Forms.TextBox()
        Me.cmd_Keys_Erstellen = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Text
        '
        Me.txt_Text.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Text.Location = New System.Drawing.Point(13, 15)
        Me.txt_Text.Multiline = True
        Me.txt_Text.Name = "txt_Text"
        Me.txt_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_Text.Size = New System.Drawing.Size(1042, 340)
        Me.txt_Text.TabIndex = 18
        '
        'cmd_Crypt_Text
        '
        Me.cmd_Crypt_Text.Enabled = False
        Me.cmd_Crypt_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Crypt_Text.Location = New System.Drawing.Point(13, 377)
        Me.cmd_Crypt_Text.Name = "cmd_Crypt_Text"
        Me.cmd_Crypt_Text.Size = New System.Drawing.Size(137, 40)
        Me.cmd_Crypt_Text.TabIndex = 19
        Me.cmd_Crypt_Text.Text = "Verschlüsseln"
        Me.cmd_Crypt_Text.UseVisualStyleBackColor = True
        '
        'cmd_DeCrypt_Text
        '
        Me.cmd_DeCrypt_Text.Enabled = False
        Me.cmd_DeCrypt_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_DeCrypt_Text.Location = New System.Drawing.Point(904, 377)
        Me.cmd_DeCrypt_Text.Name = "cmd_DeCrypt_Text"
        Me.cmd_DeCrypt_Text.Size = New System.Drawing.Size(137, 40)
        Me.cmd_DeCrypt_Text.TabIndex = 20
        Me.cmd_DeCrypt_Text.Text = "Entschlüsseln"
        Me.cmd_DeCrypt_Text.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1066, 458)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.cbo_Keys)
        Me.TabPage2.Controls.Add(Me.chk_Delete)
        Me.TabPage2.Controls.Add(Me.cmd_DeCrypt)
        Me.TabPage2.Controls.Add(Me.txt_DeCrypt)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txt_Out)
        Me.TabPage2.Controls.Add(Me.cmd_Crypt)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txt_IN)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1058, 427)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datei"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Public Key(s)"
        '
        'cbo_Keys
        '
        Me.cbo_Keys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Keys.FormattingEnabled = True
        Me.cbo_Keys.Location = New System.Drawing.Point(17, 145)
        Me.cbo_Keys.Name = "cbo_Keys"
        Me.cbo_Keys.Size = New System.Drawing.Size(260, 26)
        Me.cbo_Keys.TabIndex = 27
        '
        'chk_Delete
        '
        Me.chk_Delete.AutoSize = True
        Me.chk_Delete.Location = New System.Drawing.Point(17, 239)
        Me.chk_Delete.Name = "chk_Delete"
        Me.chk_Delete.Size = New System.Drawing.Size(133, 22)
        Me.chk_Delete.TabIndex = 26
        Me.chk_Delete.Text = "Orginal löschen"
        Me.chk_Delete.UseVisualStyleBackColor = True
        Me.chk_Delete.Visible = False
        '
        'cmd_DeCrypt
        '
        Me.cmd_DeCrypt.Enabled = False
        Me.cmd_DeCrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_DeCrypt.Location = New System.Drawing.Point(908, 183)
        Me.cmd_DeCrypt.Name = "cmd_DeCrypt"
        Me.cmd_DeCrypt.Size = New System.Drawing.Size(137, 40)
        Me.cmd_DeCrypt.TabIndex = 23
        Me.cmd_DeCrypt.Text = "Entschlüsseln"
        Me.cmd_DeCrypt.UseVisualStyleBackColor = True
        '
        'txt_DeCrypt
        '
        Me.txt_DeCrypt.Location = New System.Drawing.Point(908, 145)
        Me.txt_DeCrypt.Name = "txt_DeCrypt"
        Me.txt_DeCrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_DeCrypt.Size = New System.Drawing.Size(137, 24)
        Me.txt_DeCrypt.TabIndex = 25
        Me.txt_DeCrypt.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(840, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Passwort"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Datei (Out)"
        '
        'txt_Out
        '
        Me.txt_Out.BackColor = System.Drawing.Color.White
        Me.txt_Out.Location = New System.Drawing.Point(17, 98)
        Me.txt_Out.Name = "txt_Out"
        Me.txt_Out.ReadOnly = True
        Me.txt_Out.Size = New System.Drawing.Size(1028, 24)
        Me.txt_Out.TabIndex = 21
        Me.txt_Out.TabStop = False
        '
        'cmd_Crypt
        '
        Me.cmd_Crypt.Enabled = False
        Me.cmd_Crypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Crypt.Location = New System.Drawing.Point(17, 183)
        Me.cmd_Crypt.Name = "cmd_Crypt"
        Me.cmd_Crypt.Size = New System.Drawing.Size(137, 40)
        Me.cmd_Crypt.TabIndex = 20
        Me.cmd_Crypt.Text = "Verschlüsseln"
        Me.cmd_Crypt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Datei (IN)"
        '
        'txt_IN
        '
        Me.txt_IN.BackColor = System.Drawing.Color.White
        Me.txt_IN.Location = New System.Drawing.Point(17, 36)
        Me.txt_IN.Name = "txt_IN"
        Me.txt_IN.ReadOnly = True
        Me.txt_IN.Size = New System.Drawing.Size(1028, 24)
        Me.txt_IN.TabIndex = 18
        Me.txt_IN.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.cbo_Keys_Text)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txt_DeCrypt_Text)
        Me.TabPage3.Controls.Add(Me.txt_Text)
        Me.TabPage3.Controls.Add(Me.cmd_Crypt_Text)
        Me.TabPage3.Controls.Add(Me.cmd_DeCrypt_Text)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1058, 427)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Text"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(156, 376)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Public Key(s)"
        '
        'cbo_Keys_Text
        '
        Me.cbo_Keys_Text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Keys_Text.FormattingEnabled = True
        Me.cbo_Keys_Text.Location = New System.Drawing.Point(156, 394)
        Me.cbo_Keys_Text.Name = "cbo_Keys_Text"
        Me.cbo_Keys_Text.Size = New System.Drawing.Size(200, 26)
        Me.cbo_Keys_Text.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(695, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Passwort"
        '
        'txt_DeCrypt_Text
        '
        Me.txt_DeCrypt_Text.Location = New System.Drawing.Point(698, 394)
        Me.txt_DeCrypt_Text.Name = "txt_DeCrypt_Text"
        Me.txt_DeCrypt_Text.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_DeCrypt_Text.Size = New System.Drawing.Size(200, 24)
        Me.txt_DeCrypt_Text.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1058, 427)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Key"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_P_Key)
        Me.GroupBox2.Controls.Add(Me.txt_P_Key)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmd_Open)
        Me.GroupBox2.Controls.Add(Me.txt_Pfad)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(426, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 236)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Key(s)"
        '
        'cmd_P_Key
        '
        Me.cmd_P_Key.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_P_Key.Location = New System.Drawing.Point(496, 180)
        Me.cmd_P_Key.Name = "cmd_P_Key"
        Me.cmd_P_Key.Size = New System.Drawing.Size(101, 40)
        Me.cmd_P_Key.TabIndex = 6
        Me.cmd_P_Key.Text = "Öffnen"
        Me.cmd_P_Key.UseVisualStyleBackColor = True
        '
        'txt_P_Key
        '
        Me.txt_P_Key.BackColor = System.Drawing.Color.White
        Me.txt_P_Key.Location = New System.Drawing.Point(16, 147)
        Me.txt_P_Key.Name = "txt_P_Key"
        Me.txt_P_Key.ReadOnly = True
        Me.txt_P_Key.Size = New System.Drawing.Size(581, 24)
        Me.txt_P_Key.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Private Key"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(289, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Vorhandenen Key(s) Ordner einbinden"
        '
        'cmd_Open
        '
        Me.cmd_Open.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Open.Location = New System.Drawing.Point(496, 78)
        Me.cmd_Open.Name = "cmd_Open"
        Me.cmd_Open.Size = New System.Drawing.Size(101, 40)
        Me.cmd_Open.TabIndex = 2
        Me.cmd_Open.Text = "Öffnen"
        Me.cmd_Open.UseVisualStyleBackColor = True
        '
        'txt_Pfad
        '
        Me.txt_Pfad.BackColor = System.Drawing.Color.White
        Me.txt_Pfad.Location = New System.Drawing.Point(16, 48)
        Me.txt_Pfad.Name = "txt_Pfad"
        Me.txt_Pfad.ReadOnly = True
        Me.txt_Pfad.Size = New System.Drawing.Size(581, 24)
        Me.txt_Pfad.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Key(s) Pfad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Passwort)
        Me.GroupBox1.Controls.Add(Me.txt_eMail)
        Me.GroupBox1.Controls.Add(Me.cmd_Keys_Erstellen)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 201)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keys erstellen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Passwort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "eMail"
        '
        'txt_Passwort
        '
        Me.txt_Passwort.Location = New System.Drawing.Point(17, 99)
        Me.txt_Passwort.Name = "txt_Passwort"
        Me.txt_Passwort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Passwort.Size = New System.Drawing.Size(353, 24)
        Me.txt_Passwort.TabIndex = 8
        '
        'txt_eMail
        '
        Me.txt_eMail.Location = New System.Drawing.Point(17, 48)
        Me.txt_eMail.Name = "txt_eMail"
        Me.txt_eMail.Size = New System.Drawing.Size(353, 24)
        Me.txt_eMail.TabIndex = 7
        '
        'cmd_Keys_Erstellen
        '
        Me.cmd_Keys_Erstellen.Enabled = False
        Me.cmd_Keys_Erstellen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Keys_Erstellen.Location = New System.Drawing.Point(269, 147)
        Me.cmd_Keys_Erstellen.Name = "cmd_Keys_Erstellen"
        Me.cmd_Keys_Erstellen.Size = New System.Drawing.Size(101, 40)
        Me.cmd_Keys_Erstellen.TabIndex = 6
        Me.cmd_Keys_Erstellen.Text = "Erstellen"
        Me.cmd_Keys_Erstellen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 462)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PGP"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Text As TextBox
    Friend WithEvents cmd_Crypt_Text As Button
    Friend WithEvents cmd_DeCrypt_Text As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Passwort As TextBox
    Friend WithEvents txt_eMail As TextBox
    Friend WithEvents cmd_Keys_Erstellen As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chk_Delete As CheckBox
    Friend WithEvents cmd_DeCrypt As Button
    Friend WithEvents txt_DeCrypt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Out As TextBox
    Friend WithEvents cmd_Crypt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_IN As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txt_DeCrypt_Text As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbo_Keys As ComboBox
    Friend WithEvents cbo_Keys_Text As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmd_Open As Button
    Friend WithEvents txt_Pfad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmd_P_Key As Button
    Friend WithEvents txt_P_Key As TextBox
    Friend WithEvents Label11 As Label
End Class
