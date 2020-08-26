<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddFriendForm
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
        Me.lblAddFriend = New System.Windows.Forms.Label()
        Me.lblMsgAddFriend = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEnterUserName = New System.Windows.Forms.Label()
        Me.txtFindFriend = New System.Windows.Forms.TextBox()
        Me.btnSendFriendRequest = New Guna.UI.WinForms.GunaButton()
        Me.iconPicUsers = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconPicGlobeAfrica = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPicAmerica = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicGlobAsia = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicGlobEu = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicFly = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicCloud = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlImgAddFriends = New System.Windows.Forms.Panel()
        Me.FindFriendPanel = New Guna.UI.WinForms.GunaElipsePanel()
        CType(Me.iconPicUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPicGlobeAfrica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPicAmerica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPicGlobAsia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPicGlobEu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPicFly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPicCloud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlImgAddFriends.SuspendLayout()
        Me.FindFriendPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddFriend
        '
        Me.lblAddFriend.BackColor = System.Drawing.Color.Transparent
        Me.lblAddFriend.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAddFriend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblAddFriend.Location = New System.Drawing.Point(40, 35)
        Me.lblAddFriend.Name = "lblAddFriend"
        Me.lblAddFriend.Size = New System.Drawing.Size(110, 20)
        Me.lblAddFriend.TabIndex = 74
        Me.lblAddFriend.Text = "ADD FRIEND"
        '
        'lblMsgAddFriend
        '
        Me.lblMsgAddFriend.AutoSize = True
        Me.lblMsgAddFriend.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgAddFriend.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgAddFriend.ForeColor = System.Drawing.Color.Silver
        Me.lblMsgAddFriend.Location = New System.Drawing.Point(40, 65)
        Me.lblMsgAddFriend.Name = "lblMsgAddFriend"
        Me.lblMsgAddFriend.Size = New System.Drawing.Size(506, 17)
        Me.lblMsgAddFriend.TabIndex = 75
        Me.lblMsgAddFriend.Text = "You can add a friend with thair Name. Be careful to write the Name in right way!"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 2)
        Me.Panel1.TabIndex = 76
        '
        'lblEnterUserName
        '
        Me.lblEnterUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblEnterUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblEnterUserName.Enabled = False
        Me.lblEnterUserName.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEnterUserName.ForeColor = System.Drawing.Color.Gray
        Me.lblEnterUserName.Location = New System.Drawing.Point(20, 14)
        Me.lblEnterUserName.Name = "lblEnterUserName"
        Me.lblEnterUserName.Size = New System.Drawing.Size(146, 20)
        Me.lblEnterUserName.TabIndex = 80
        Me.lblEnterUserName.Text = "Enter a Username"
        '
        'txtFindFriend
        '
        Me.txtFindFriend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFindFriend.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtFindFriend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFindFriend.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFindFriend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFindFriend.Location = New System.Drawing.Point(17, 14)
        Me.txtFindFriend.Multiline = True
        Me.txtFindFriend.Name = "txtFindFriend"
        Me.txtFindFriend.Size = New System.Drawing.Size(650, 25)
        Me.txtFindFriend.TabIndex = 95
        '
        'btnSendFriendRequest
        '
        Me.btnSendFriendRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendFriendRequest.Animated = True
        Me.btnSendFriendRequest.AnimationHoverSpeed = 0.07!
        Me.btnSendFriendRequest.AnimationSpeed = 0.03!
        Me.btnSendFriendRequest.BackColor = System.Drawing.Color.Transparent
        Me.btnSendFriendRequest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSendFriendRequest.BorderColor = System.Drawing.Color.Black
        Me.btnSendFriendRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendFriendRequest.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSendFriendRequest.Enabled = False
        Me.btnSendFriendRequest.FocusedColor = System.Drawing.Color.Empty
        Me.btnSendFriendRequest.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSendFriendRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSendFriendRequest.Image = Nothing
        Me.btnSendFriendRequest.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSendFriendRequest.Location = New System.Drawing.Point(682, 9)
        Me.btnSendFriendRequest.Name = "btnSendFriendRequest"
        Me.btnSendFriendRequest.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnSendFriendRequest.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSendFriendRequest.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSendFriendRequest.OnHoverImage = Nothing
        Me.btnSendFriendRequest.OnPressedColor = System.Drawing.Color.Black
        Me.btnSendFriendRequest.Radius = 7
        Me.btnSendFriendRequest.Size = New System.Drawing.Size(175, 30)
        Me.btnSendFriendRequest.TabIndex = 94
        Me.btnSendFriendRequest.Text = "Send Friend Request"
        '
        'iconPicUsers
        '
        Me.iconPicUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.iconPicUsers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.iconPicUsers.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.iconPicUsers.IconSize = 250
        Me.iconPicUsers.Location = New System.Drawing.Point(60, -13)
        Me.iconPicUsers.Name = "iconPicUsers"
        Me.iconPicUsers.Size = New System.Drawing.Size(250, 250)
        Me.iconPicUsers.TabIndex = 99
        Me.iconPicUsers.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(127, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 22)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Find your friends! :)"
        '
        'iconPicGlobeAfrica
        '
        Me.iconPicGlobeAfrica.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicGlobeAfrica.ForeColor = System.Drawing.Color.Gray
        Me.iconPicGlobeAfrica.IconChar = FontAwesome.Sharp.IconChar.GlobeAfrica
        Me.iconPicGlobeAfrica.IconColor = System.Drawing.Color.Gray
        Me.iconPicGlobeAfrica.IconSize = 46
        Me.iconPicGlobeAfrica.Location = New System.Drawing.Point(59, 88)
        Me.iconPicGlobeAfrica.Name = "iconPicGlobeAfrica"
        Me.iconPicGlobeAfrica.Size = New System.Drawing.Size(46, 51)
        Me.iconPicGlobeAfrica.TabIndex = 106
        Me.iconPicGlobeAfrica.TabStop = False
        '
        'IconPicAmerica
        '
        Me.IconPicAmerica.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPicAmerica.ForeColor = System.Drawing.Color.Gray
        Me.IconPicAmerica.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas
        Me.IconPicAmerica.IconColor = System.Drawing.Color.Gray
        Me.IconPicAmerica.IconSize = 46
        Me.IconPicAmerica.Location = New System.Drawing.Point(315, 88)
        Me.IconPicAmerica.Name = "IconPicAmerica"
        Me.IconPicAmerica.Size = New System.Drawing.Size(46, 51)
        Me.IconPicAmerica.TabIndex = 107
        Me.IconPicAmerica.TabStop = False
        '
        'iconPicGlobAsia
        '
        Me.iconPicGlobAsia.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicGlobAsia.ForeColor = System.Drawing.Color.Gray
        Me.iconPicGlobAsia.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia
        Me.iconPicGlobAsia.IconColor = System.Drawing.Color.Gray
        Me.iconPicGlobAsia.IconSize = 46
        Me.iconPicGlobAsia.Location = New System.Drawing.Point(367, 88)
        Me.iconPicGlobAsia.Name = "iconPicGlobAsia"
        Me.iconPicGlobAsia.Size = New System.Drawing.Size(46, 51)
        Me.iconPicGlobAsia.TabIndex = 108
        Me.iconPicGlobAsia.TabStop = False
        '
        'iconPicGlobEu
        '
        Me.iconPicGlobEu.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicGlobEu.ForeColor = System.Drawing.Color.Gray
        Me.iconPicGlobEu.IconChar = FontAwesome.Sharp.IconChar.GlobeEurope
        Me.iconPicGlobEu.IconColor = System.Drawing.Color.Gray
        Me.iconPicGlobEu.IconSize = 46
        Me.iconPicGlobEu.Location = New System.Drawing.Point(7, 88)
        Me.iconPicGlobEu.Name = "iconPicGlobEu"
        Me.iconPicGlobEu.Size = New System.Drawing.Size(46, 51)
        Me.iconPicGlobEu.TabIndex = 109
        Me.iconPicGlobEu.TabStop = False
        '
        'iconPicFly
        '
        Me.iconPicFly.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicFly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.iconPicFly.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.iconPicFly.IconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.iconPicFly.IconSize = 23
        Me.iconPicFly.Location = New System.Drawing.Point(42, 131)
        Me.iconPicFly.Name = "iconPicFly"
        Me.iconPicFly.Size = New System.Drawing.Size(23, 23)
        Me.iconPicFly.TabIndex = 110
        Me.iconPicFly.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox1.IconSize = 22
        Me.IconPictureBox1.Location = New System.Drawing.Point(352, 72)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.IconPictureBox1.TabIndex = 111
        Me.IconPictureBox1.TabStop = False
        '
        'iconPicCloud
        '
        Me.iconPicCloud.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicCloud.ForeColor = System.Drawing.Color.Gray
        Me.iconPicCloud.IconChar = FontAwesome.Sharp.IconChar.CloudSun
        Me.iconPicCloud.IconColor = System.Drawing.Color.Gray
        Me.iconPicCloud.IconSize = 31
        Me.iconPicCloud.Location = New System.Drawing.Point(146, 14)
        Me.iconPicCloud.Name = "iconPicCloud"
        Me.iconPicCloud.Size = New System.Drawing.Size(31, 31)
        Me.iconPicCloud.TabIndex = 112
        Me.iconPicCloud.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.IconPictureBox2.IconSize = 18
        Me.IconPictureBox2.Location = New System.Drawing.Point(245, 27)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(23, 18)
        Me.IconPictureBox2.TabIndex = 113
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox3.IconSize = 38
        Me.IconPictureBox3.Location = New System.Drawing.Point(303, 167)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(44, 38)
        Me.IconPictureBox3.TabIndex = 114
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Cloud
        Me.IconPictureBox4.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox4.IconSize = 53
        Me.IconPictureBox4.Location = New System.Drawing.Point(77, 184)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(54, 53)
        Me.IconPictureBox4.TabIndex = 115
        Me.IconPictureBox4.TabStop = False
        '
        'pnlImgAddFriends
        '
        Me.pnlImgAddFriends.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlImgAddFriends.Controls.Add(Me.iconPicFly)
        Me.pnlImgAddFriends.Controls.Add(Me.IconPictureBox4)
        Me.pnlImgAddFriends.Controls.Add(Me.Label1)
        Me.pnlImgAddFriends.Controls.Add(Me.IconPictureBox3)
        Me.pnlImgAddFriends.Controls.Add(Me.iconPicGlobeAfrica)
        Me.pnlImgAddFriends.Controls.Add(Me.IconPictureBox2)
        Me.pnlImgAddFriends.Controls.Add(Me.IconPicAmerica)
        Me.pnlImgAddFriends.Controls.Add(Me.iconPicCloud)
        Me.pnlImgAddFriends.Controls.Add(Me.iconPicGlobAsia)
        Me.pnlImgAddFriends.Controls.Add(Me.IconPictureBox1)
        Me.pnlImgAddFriends.Controls.Add(Me.iconPicGlobEu)
        Me.pnlImgAddFriends.Controls.Add(Me.iconPicUsers)
        Me.pnlImgAddFriends.Location = New System.Drawing.Point(265, 285)
        Me.pnlImgAddFriends.Name = "pnlImgAddFriends"
        Me.pnlImgAddFriends.Size = New System.Drawing.Size(420, 240)
        Me.pnlImgAddFriends.TabIndex = 116
        '
        'FindFriendPanel
        '
        Me.FindFriendPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindFriendPanel.BackColor = System.Drawing.Color.Transparent
        Me.FindFriendPanel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FindFriendPanel.Controls.Add(Me.lblEnterUserName)
        Me.FindFriendPanel.Controls.Add(Me.btnSendFriendRequest)
        Me.FindFriendPanel.Controls.Add(Me.txtFindFriend)
        Me.FindFriendPanel.Location = New System.Drawing.Point(40, 100)
        Me.FindFriendPanel.Name = "FindFriendPanel"
        Me.FindFriendPanel.Radius = 13
        Me.FindFriendPanel.Size = New System.Drawing.Size(870, 50)
        Me.FindFriendPanel.TabIndex = 117
        '
        'AddFriendForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.FindFriendPanel)
        Me.Controls.Add(Me.pnlImgAddFriends)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMsgAddFriend)
        Me.Controls.Add(Me.lblAddFriend)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddFriendForm"
        Me.Text = "AddFriendForm"
        CType(Me.iconPicUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPicGlobeAfrica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPicAmerica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPicGlobAsia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPicGlobEu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPicFly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPicCloud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlImgAddFriends.ResumeLayout(False)
        Me.pnlImgAddFriends.PerformLayout()
        Me.FindFriendPanel.ResumeLayout(False)
        Me.FindFriendPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddFriend As Label
    Friend WithEvents lblMsgAddFriend As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSendFriendRequest As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtFindFriend As TextBox
    Friend WithEvents lblEnterUserName As Label
    Friend WithEvents iconPicUsers As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents iconPicGlobeAfrica As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPicAmerica As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicGlobAsia As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicGlobEu As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicFly As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicCloud As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlImgAddFriends As Panel
    Friend WithEvents FindFriendPanel As Guna.UI.WinForms.GunaElipsePanel
End Class
