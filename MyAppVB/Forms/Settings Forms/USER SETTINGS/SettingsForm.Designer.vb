<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.btnLinkedin = New FontAwesome.Sharp.IconPictureBox()
        Me.btnLogOut = New Guna.UI.WinForms.GunaButton()
        Me.btnVoiceAndVideo = New Guna.UI.WinForms.GunaButton()
        Me.btnLanguage = New Guna.UI.WinForms.GunaButton()
        Me.btnPrivacyAndSefty = New Guna.UI.WinForms.GunaButton()
        Me.btnMyAccount = New Guna.UI.WinForms.GunaButton()
        Me.btnFaceBook = New FontAwesome.Sharp.IconPictureBox()
        Me.btnInstagram = New FontAwesome.Sharp.IconPictureBox()
        Me.btnVk = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAppSettings = New System.Windows.Forms.Label()
        Me.lblUserSettings = New System.Windows.Forms.Label()
        Me.pnlEditAccount = New System.Windows.Forms.Panel()
        Me.btnDeleteAccount = New Guna.UI.WinForms.GunaButton()
        Me.btnSave = New Guna.UI.WinForms.GunaButton()
        Me.btnCancel = New Guna.UI.WinForms.GunaButton()
        Me.btnEdit = New Guna.UI.WinForms.GunaButton()
        Me.lblWrongPassword = New System.Windows.Forms.Label()
        Me.userPictureBox = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblMsgWarningPass = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRemoveImage = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.pnlNewPassword = New System.Windows.Forms.Panel()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblChangePassword = New System.Windows.Forms.Label()
        Me.pnlCurrentPassword = New System.Windows.Forms.Panel()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.pnlUserName = New System.Windows.Forms.Panel()
        Me.pnlUserEmail = New System.Windows.Forms.Panel()
        Me.txtUserEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblMyAccount = New System.Windows.Forms.Label()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconPictureBox()
        Me.LeftPanel.SuspendLayout()
        CType(Me.btnLinkedin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFaceBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInstagram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditAccount.SuspendLayout()
        CType(Me.userPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.centerPanel.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftPanel
        '
        Me.LeftPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LeftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LeftPanel.Controls.Add(Me.btnLinkedin)
        Me.LeftPanel.Controls.Add(Me.btnLogOut)
        Me.LeftPanel.Controls.Add(Me.btnVoiceAndVideo)
        Me.LeftPanel.Controls.Add(Me.btnLanguage)
        Me.LeftPanel.Controls.Add(Me.btnPrivacyAndSefty)
        Me.LeftPanel.Controls.Add(Me.btnMyAccount)
        Me.LeftPanel.Controls.Add(Me.btnFaceBook)
        Me.LeftPanel.Controls.Add(Me.btnInstagram)
        Me.LeftPanel.Controls.Add(Me.btnVk)
        Me.LeftPanel.Controls.Add(Me.Panel4)
        Me.LeftPanel.Controls.Add(Me.Panel3)
        Me.LeftPanel.Controls.Add(Me.Panel2)
        Me.LeftPanel.Controls.Add(Me.lblAppSettings)
        Me.LeftPanel.Controls.Add(Me.lblUserSettings)
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(350, 720)
        Me.LeftPanel.TabIndex = 1
        '
        'btnLinkedin
        '
        Me.btnLinkedin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLinkedin.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLinkedin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLinkedin.ForeColor = System.Drawing.Color.DarkGray
        Me.btnLinkedin.IconChar = FontAwesome.Sharp.IconChar.Linkedin
        Me.btnLinkedin.IconColor = System.Drawing.Color.DarkGray
        Me.btnLinkedin.IconSize = 25
        Me.btnLinkedin.Location = New System.Drawing.Point(298, 323)
        Me.btnLinkedin.Name = "btnLinkedin"
        Me.btnLinkedin.Size = New System.Drawing.Size(25, 25)
        Me.btnLinkedin.TabIndex = 94
        Me.btnLinkedin.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.Animated = True
        Me.btnLogOut.AnimationHoverSpeed = 0.07!
        Me.btnLogOut.AnimationSpeed = 0.03!
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLogOut.BorderColor = System.Drawing.Color.Black
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogOut.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogOut.Image = Nothing
        Me.btnLogOut.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogOut.Location = New System.Drawing.Point(204, 280)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLogOut.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogOut.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLogOut.OnHoverImage = Nothing
        Me.btnLogOut.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogOut.Radius = 7
        Me.btnLogOut.Size = New System.Drawing.Size(141, 30)
        Me.btnLogOut.TabIndex = 93
        Me.btnLogOut.Text = "Log Out"
        '
        'btnVoiceAndVideo
        '
        Me.btnVoiceAndVideo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoiceAndVideo.Animated = True
        Me.btnVoiceAndVideo.AnimationHoverSpeed = 0.07!
        Me.btnVoiceAndVideo.AnimationSpeed = 0.03!
        Me.btnVoiceAndVideo.BackColor = System.Drawing.Color.Transparent
        Me.btnVoiceAndVideo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnVoiceAndVideo.BorderColor = System.Drawing.Color.Black
        Me.btnVoiceAndVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoiceAndVideo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnVoiceAndVideo.FocusedColor = System.Drawing.Color.Empty
        Me.btnVoiceAndVideo.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnVoiceAndVideo.ForeColor = System.Drawing.Color.DarkGray
        Me.btnVoiceAndVideo.Image = Nothing
        Me.btnVoiceAndVideo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnVoiceAndVideo.Location = New System.Drawing.Point(204, 235)
        Me.btnVoiceAndVideo.Name = "btnVoiceAndVideo"
        Me.btnVoiceAndVideo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnVoiceAndVideo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnVoiceAndVideo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnVoiceAndVideo.OnHoverImage = Nothing
        Me.btnVoiceAndVideo.OnPressedColor = System.Drawing.Color.Black
        Me.btnVoiceAndVideo.Radius = 7
        Me.btnVoiceAndVideo.Size = New System.Drawing.Size(141, 30)
        Me.btnVoiceAndVideo.TabIndex = 92
        Me.btnVoiceAndVideo.Text = "Voice & Video"
        '
        'btnLanguage
        '
        Me.btnLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLanguage.Animated = True
        Me.btnLanguage.AnimationHoverSpeed = 0.07!
        Me.btnLanguage.AnimationSpeed = 0.03!
        Me.btnLanguage.BackColor = System.Drawing.Color.Transparent
        Me.btnLanguage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnLanguage.BorderColor = System.Drawing.Color.Black
        Me.btnLanguage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLanguage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLanguage.FocusedColor = System.Drawing.Color.Empty
        Me.btnLanguage.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLanguage.ForeColor = System.Drawing.Color.DarkGray
        Me.btnLanguage.Image = Nothing
        Me.btnLanguage.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLanguage.Location = New System.Drawing.Point(204, 199)
        Me.btnLanguage.Name = "btnLanguage"
        Me.btnLanguage.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnLanguage.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLanguage.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLanguage.OnHoverImage = Nothing
        Me.btnLanguage.OnPressedColor = System.Drawing.Color.Black
        Me.btnLanguage.Radius = 7
        Me.btnLanguage.Size = New System.Drawing.Size(141, 30)
        Me.btnLanguage.TabIndex = 91
        Me.btnLanguage.Text = "Language"
        '
        'btnPrivacyAndSefty
        '
        Me.btnPrivacyAndSefty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrivacyAndSefty.Animated = True
        Me.btnPrivacyAndSefty.AnimationHoverSpeed = 0.07!
        Me.btnPrivacyAndSefty.AnimationSpeed = 0.03!
        Me.btnPrivacyAndSefty.BackColor = System.Drawing.Color.Transparent
        Me.btnPrivacyAndSefty.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnPrivacyAndSefty.BorderColor = System.Drawing.Color.Black
        Me.btnPrivacyAndSefty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrivacyAndSefty.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrivacyAndSefty.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrivacyAndSefty.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPrivacyAndSefty.ForeColor = System.Drawing.Color.DarkGray
        Me.btnPrivacyAndSefty.Image = Nothing
        Me.btnPrivacyAndSefty.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrivacyAndSefty.Location = New System.Drawing.Point(204, 134)
        Me.btnPrivacyAndSefty.Name = "btnPrivacyAndSefty"
        Me.btnPrivacyAndSefty.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnPrivacyAndSefty.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrivacyAndSefty.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrivacyAndSefty.OnHoverImage = Nothing
        Me.btnPrivacyAndSefty.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrivacyAndSefty.Radius = 7
        Me.btnPrivacyAndSefty.Size = New System.Drawing.Size(141, 30)
        Me.btnPrivacyAndSefty.TabIndex = 90
        Me.btnPrivacyAndSefty.Text = "Privacy & Sefty"
        '
        'btnMyAccount
        '
        Me.btnMyAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMyAccount.Animated = True
        Me.btnMyAccount.AnimationHoverSpeed = 0.07!
        Me.btnMyAccount.AnimationSpeed = 0.03!
        Me.btnMyAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnMyAccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMyAccount.BorderColor = System.Drawing.Color.Black
        Me.btnMyAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMyAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnMyAccount.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMyAccount.ForeColor = System.Drawing.Color.DarkGray
        Me.btnMyAccount.Image = Nothing
        Me.btnMyAccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMyAccount.Location = New System.Drawing.Point(204, 103)
        Me.btnMyAccount.Name = "btnMyAccount"
        Me.btnMyAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMyAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMyAccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMyAccount.OnHoverImage = Nothing
        Me.btnMyAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnMyAccount.Radius = 7
        Me.btnMyAccount.Size = New System.Drawing.Size(141, 30)
        Me.btnMyAccount.TabIndex = 89
        Me.btnMyAccount.Text = "My Account"
        '
        'btnFaceBook
        '
        Me.btnFaceBook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFaceBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnFaceBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFaceBook.ForeColor = System.Drawing.Color.DarkGray
        Me.btnFaceBook.IconChar = FontAwesome.Sharp.IconChar.Facebook
        Me.btnFaceBook.IconColor = System.Drawing.Color.DarkGray
        Me.btnFaceBook.IconSize = 25
        Me.btnFaceBook.Location = New System.Drawing.Point(267, 323)
        Me.btnFaceBook.Name = "btnFaceBook"
        Me.btnFaceBook.Size = New System.Drawing.Size(25, 25)
        Me.btnFaceBook.TabIndex = 88
        Me.btnFaceBook.TabStop = False
        '
        'btnInstagram
        '
        Me.btnInstagram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInstagram.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnInstagram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInstagram.ForeColor = System.Drawing.Color.DarkGray
        Me.btnInstagram.IconChar = FontAwesome.Sharp.IconChar.Instagram
        Me.btnInstagram.IconColor = System.Drawing.Color.DarkGray
        Me.btnInstagram.IconSize = 25
        Me.btnInstagram.Location = New System.Drawing.Point(236, 323)
        Me.btnInstagram.Name = "btnInstagram"
        Me.btnInstagram.Size = New System.Drawing.Size(25, 25)
        Me.btnInstagram.TabIndex = 87
        Me.btnInstagram.TabStop = False
        '
        'btnVk
        '
        Me.btnVk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVk.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnVk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVk.ForeColor = System.Drawing.Color.DarkGray
        Me.btnVk.IconChar = FontAwesome.Sharp.IconChar.Vk
        Me.btnVk.IconColor = System.Drawing.Color.DarkGray
        Me.btnVk.IconSize = 25
        Me.btnVk.Location = New System.Drawing.Point(205, 323)
        Me.btnVk.Name = "btnVk"
        Me.btnVk.Size = New System.Drawing.Size(25, 25)
        Me.btnVk.TabIndex = 86
        Me.btnVk.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Location = New System.Drawing.Point(205, 315)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(140, 1)
        Me.Panel4.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(205, 173)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(140, 1)
        Me.Panel3.TabIndex = 84
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(205, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(140, 1)
        Me.Panel2.TabIndex = 83
        '
        'lblAppSettings
        '
        Me.lblAppSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAppSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblAppSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAppSettings.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAppSettings.ForeColor = System.Drawing.Color.Gray
        Me.lblAppSettings.Location = New System.Drawing.Point(211, 180)
        Me.lblAppSettings.Name = "lblAppSettings"
        Me.lblAppSettings.Size = New System.Drawing.Size(103, 20)
        Me.lblAppSettings.TabIndex = 79
        Me.lblAppSettings.Text = "APP SETTINGS"
        Me.lblAppSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserSettings
        '
        Me.lblUserSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblUserSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUserSettings.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblUserSettings.ForeColor = System.Drawing.Color.Gray
        Me.lblUserSettings.Location = New System.Drawing.Point(211, 80)
        Me.lblUserSettings.Name = "lblUserSettings"
        Me.lblUserSettings.Size = New System.Drawing.Size(103, 20)
        Me.lblUserSettings.TabIndex = 78
        Me.lblUserSettings.Text = "USER SETTINGS"
        Me.lblUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlEditAccount
        '
        Me.pnlEditAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlEditAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlEditAccount.Controls.Add(Me.btnDeleteAccount)
        Me.pnlEditAccount.Controls.Add(Me.btnSave)
        Me.pnlEditAccount.Controls.Add(Me.btnCancel)
        Me.pnlEditAccount.Controls.Add(Me.btnEdit)
        Me.pnlEditAccount.Controls.Add(Me.lblWrongPassword)
        Me.pnlEditAccount.Controls.Add(Me.userPictureBox)
        Me.pnlEditAccount.Controls.Add(Me.lblMsgWarningPass)
        Me.pnlEditAccount.Controls.Add(Me.Panel1)
        Me.pnlEditAccount.Controls.Add(Me.btnRemoveImage)
        Me.pnlEditAccount.Controls.Add(Me.txtUserName)
        Me.pnlEditAccount.Controls.Add(Me.pnlNewPassword)
        Me.pnlEditAccount.Controls.Add(Me.txtNewPassword)
        Me.pnlEditAccount.Controls.Add(Me.lblChangePassword)
        Me.pnlEditAccount.Controls.Add(Me.pnlCurrentPassword)
        Me.pnlEditAccount.Controls.Add(Me.txtCurrentPassword)
        Me.pnlEditAccount.Controls.Add(Me.lblCurrentPassword)
        Me.pnlEditAccount.Controls.Add(Me.pnlUserName)
        Me.pnlEditAccount.Controls.Add(Me.pnlUserEmail)
        Me.pnlEditAccount.Controls.Add(Me.txtUserEmail)
        Me.pnlEditAccount.Controls.Add(Me.lblEmail)
        Me.pnlEditAccount.Controls.Add(Me.lblUserName)
        Me.pnlEditAccount.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.pnlEditAccount.Location = New System.Drawing.Point(10, 124)
        Me.pnlEditAccount.Name = "pnlEditAccount"
        Me.pnlEditAccount.Size = New System.Drawing.Size(650, 175)
        Me.pnlEditAccount.TabIndex = 3
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.Animated = True
        Me.btnDeleteAccount.AnimationHoverSpeed = 0.07!
        Me.btnDeleteAccount.AnimationSpeed = 0.03!
        Me.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnDeleteAccount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteAccount.BorderSize = 1
        Me.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteAccount.Image = Nothing
        Me.btnDeleteAccount.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDeleteAccount.Location = New System.Drawing.Point(40, 370)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteAccount.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteAccount.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnDeleteAccount.OnHoverImage = Nothing
        Me.btnDeleteAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteAccount.Radius = 5
        Me.btnDeleteAccount.Size = New System.Drawing.Size(125, 30)
        Me.btnDeleteAccount.TabIndex = 94
        Me.btnDeleteAccount.Text = "Delete Account"
        Me.btnDeleteAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.AnimationHoverSpeed = 0.07!
        Me.btnSave.AnimationSpeed = 0.03!
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSave.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSave.BorderSize = 1
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FocusedColor = System.Drawing.Color.Empty
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSave.Image = Nothing
        Me.btnSave.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSave.Location = New System.Drawing.Point(535, 370)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSave.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSave.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSave.OnHoverImage = Nothing
        Me.btnSave.OnPressedColor = System.Drawing.Color.Black
        Me.btnSave.Radius = 5
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 93
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnCancel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCancel.BorderSize = 1
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancel.Location = New System.Drawing.Point(447, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Radius = 5
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 92
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.AnimationHoverSpeed = 0.07!
        Me.btnEdit.AnimationSpeed = 0.03!
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnEdit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnEdit.BorderSize = 1
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnEdit.Image = Nothing
        Me.btnEdit.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEdit.Location = New System.Drawing.Point(535, 20)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Black
        Me.btnEdit.Radius = 5
        Me.btnEdit.Size = New System.Drawing.Size(75, 30)
        Me.btnEdit.TabIndex = 76
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblWrongPassword
        '
        Me.lblWrongPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblWrongPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblWrongPassword.Location = New System.Drawing.Point(198, 239)
        Me.lblWrongPassword.Name = "lblWrongPassword"
        Me.lblWrongPassword.Size = New System.Drawing.Size(113, 15)
        Me.lblWrongPassword.TabIndex = 91
        Me.lblWrongPassword.Text = "Wrong Password!"
        Me.lblWrongPassword.Visible = False
        '
        'userPictureBox
        '
        Me.userPictureBox.BaseColor = System.Drawing.Color.White
        Me.userPictureBox.Image = Global.PlayME.My.Resources.Resources.t9f6bjjt7br31
        Me.userPictureBox.Location = New System.Drawing.Point(40, 20)
        Me.userPictureBox.Name = "userPictureBox"
        Me.userPictureBox.Size = New System.Drawing.Size(125, 125)
        Me.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userPictureBox.TabIndex = 90
        Me.userPictureBox.TabStop = False
        Me.userPictureBox.UseTransfarantBackground = False
        '
        'lblMsgWarningPass
        '
        Me.lblMsgWarningPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgWarningPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblMsgWarningPass.Location = New System.Drawing.Point(17, 328)
        Me.lblMsgWarningPass.Name = "lblMsgWarningPass"
        Me.lblMsgWarningPass.Size = New System.Drawing.Size(506, 15)
        Me.lblMsgWarningPass.TabIndex = 89
        Me.lblMsgWarningPass.Text = "Your password must contain:"
        Me.lblMsgWarningPass.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(20, 355)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 1)
        Me.Panel1.TabIndex = 88
        '
        'btnRemoveImage
        '
        Me.btnRemoveImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRemoveImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveImage.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRemoveImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnRemoveImage.Location = New System.Drawing.Point(51, 155)
        Me.btnRemoveImage.Name = "btnRemoveImage"
        Me.btnRemoveImage.Size = New System.Drawing.Size(105, 20)
        Me.btnRemoveImage.TabIndex = 88
        Me.btnRemoveImage.Text = "Change Image"
        Me.btnRemoveImage.Visible = False
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Enabled = False
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtUserName.Location = New System.Drawing.Point(200, 50)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(323, 21)
        Me.txtUserName.TabIndex = 80
        Me.txtUserName.Text = "UserName"
        '
        'pnlNewPassword
        '
        Me.pnlNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlNewPassword.Location = New System.Drawing.Point(200, 315)
        Me.pnlNewPassword.Name = "pnlNewPassword"
        Me.pnlNewPassword.Size = New System.Drawing.Size(323, 1)
        Me.pnlNewPassword.TabIndex = 87
        Me.pnlNewPassword.Visible = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtNewPassword.Location = New System.Drawing.Point(199, 290)
        Me.txtNewPassword.Multiline = True
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(324, 20)
        Me.txtNewPassword.TabIndex = 86
        Me.txtNewPassword.Text = "NEW PASSWORD"
        Me.txtNewPassword.Visible = False
        '
        'lblChangePassword
        '
        Me.lblChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lblChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblChangePassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblChangePassword.Location = New System.Drawing.Point(197, 260)
        Me.lblChangePassword.Name = "lblChangePassword"
        Me.lblChangePassword.Size = New System.Drawing.Size(129, 20)
        Me.lblChangePassword.TabIndex = 87
        Me.lblChangePassword.Text = "Change Password?"
        '
        'pnlCurrentPassword
        '
        Me.pnlCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlCurrentPassword.Location = New System.Drawing.Point(199, 235)
        Me.pnlCurrentPassword.Name = "pnlCurrentPassword"
        Me.pnlCurrentPassword.Size = New System.Drawing.Size(323, 1)
        Me.pnlCurrentPassword.TabIndex = 85
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtCurrentPassword.Location = New System.Drawing.Point(199, 210)
        Me.txtCurrentPassword.Multiline = True
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(323, 20)
        Me.txtCurrentPassword.TabIndex = 84
        Me.txtCurrentPassword.Text = "CURRENT PASSWORD"
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lblCurrentPassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblCurrentPassword.Location = New System.Drawing.Point(196, 180)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(150, 20)
        Me.lblCurrentPassword.TabIndex = 83
        Me.lblCurrentPassword.Text = "CURRENT PASSWORD"
        Me.lblCurrentPassword.Visible = False
        '
        'pnlUserName
        '
        Me.pnlUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlUserName.Location = New System.Drawing.Point(200, 75)
        Me.pnlUserName.Name = "pnlUserName"
        Me.pnlUserName.Size = New System.Drawing.Size(323, 1)
        Me.pnlUserName.TabIndex = 83
        Me.pnlUserName.Visible = False
        '
        'pnlUserEmail
        '
        Me.pnlUserEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlUserEmail.Location = New System.Drawing.Point(200, 155)
        Me.pnlUserEmail.Name = "pnlUserEmail"
        Me.pnlUserEmail.Size = New System.Drawing.Size(323, 1)
        Me.pnlUserEmail.TabIndex = 82
        Me.pnlUserEmail.Visible = False
        '
        'txtUserEmail
        '
        Me.txtUserEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserEmail.Enabled = False
        Me.txtUserEmail.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtUserEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtUserEmail.Location = New System.Drawing.Point(200, 130)
        Me.txtUserEmail.Multiline = True
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.Size = New System.Drawing.Size(323, 20)
        Me.txtUserEmail.TabIndex = 81
        Me.txtUserEmail.Text = "UserEmail"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(197, 100)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 20)
        Me.lblEmail.TabIndex = 77
        Me.lblEmail.Text = "EMAIL"
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(197, 20)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(86, 20)
        Me.lblUserName.TabIndex = 75
        Me.lblUserName.Text = "USERNAME"
        '
        'lblMyAccount
        '
        Me.lblMyAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMyAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lblMyAccount.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMyAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblMyAccount.Location = New System.Drawing.Point(10, 85)
        Me.lblMyAccount.Name = "lblMyAccount"
        Me.lblMyAccount.Size = New System.Drawing.Size(131, 20)
        Me.lblMyAccount.TabIndex = 74
        Me.lblMyAccount.Text = "MY ACCOUNT"
        '
        'centerPanel
        '
        Me.centerPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.centerPanel.Controls.Add(Me.pnlEditAccount)
        Me.centerPanel.Controls.Add(Me.lblMyAccount)
        Me.centerPanel.Location = New System.Drawing.Point(370, 0)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(670, 720)
        Me.centerPanel.TabIndex = 75
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.btnClose.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.IconSize = 35
        Me.btnClose.Location = New System.Drawing.Point(1050, 85)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsForm"
        Me.Text = "SettingsForm"
        Me.LeftPanel.ResumeLayout(False)
        CType(Me.btnLinkedin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFaceBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInstagram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditAccount.ResumeLayout(False)
        Me.pnlEditAccount.PerformLayout()
        CType(Me.userPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.centerPanel.ResumeLayout(False)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents pnlEditAccount As Panel
    Friend WithEvents lblMyAccount As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtUserEmail As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents pnlUserName As Panel
    Friend WithEvents pnlUserEmail As Panel
    Friend WithEvents pnlCurrentPassword As Panel
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents pnlNewPassword As Panel
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblChangePassword As Label
    Friend WithEvents btnRemoveImage As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMsgWarningPass As Label
    Friend WithEvents lblAppSettings As Label
    Friend WithEvents lblUserSettings As Label
    Friend WithEvents btnVk As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnInstagram As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnFaceBook As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents centerPanel As Panel
    Friend WithEvents btnLogOut As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnVoiceAndVideo As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnLanguage As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPrivacyAndSefty As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMyAccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents userPictureBox As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblWrongPassword As Label
    Friend WithEvents btnLinkedin As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnSave As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDeleteAccount As Guna.UI.WinForms.GunaButton
End Class
