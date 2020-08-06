<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllFriendsForm
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
        Me.pnlUnderlblAllFriends = New System.Windows.Forms.Panel()
        Me.lblAllFriends = New System.Windows.Forms.Label()
        Me.AllFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.AllFriendsPanel = New Guna.UI.WinForms.GunaPanel()
        Me.pnlImgAllFriends = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnAddNewFriends = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox7 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicFly = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicUsers = New FontAwesome.Sharp.IconPictureBox()
        Me.AllFriendsPanel.SuspendLayout()
        Me.pnlImgAllFriends.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPicFly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconPicUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlUnderlblAllFriends
        '
        Me.pnlUnderlblAllFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderlblAllFriends.BackColor = System.Drawing.Color.Gray
        Me.pnlUnderlblAllFriends.Location = New System.Drawing.Point(10, 1)
        Me.pnlUnderlblAllFriends.Name = "pnlUnderlblAllFriends"
        Me.pnlUnderlblAllFriends.Size = New System.Drawing.Size(865, 1)
        Me.pnlUnderlblAllFriends.TabIndex = 77
        Me.pnlUnderlblAllFriends.Visible = False
        '
        'lblAllFriends
        '
        Me.lblAllFriends.AutoSize = True
        Me.lblAllFriends.BackColor = System.Drawing.Color.Transparent
        Me.lblAllFriends.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAllFriends.ForeColor = System.Drawing.Color.Silver
        Me.lblAllFriends.Location = New System.Drawing.Point(30, 15)
        Me.lblAllFriends.Name = "lblAllFriends"
        Me.lblAllFriends.Size = New System.Drawing.Size(97, 17)
        Me.lblAllFriends.TabIndex = 78
        Me.lblAllFriends.Text = "ALL FRIENDS -"
        Me.lblAllFriends.Visible = False
        '
        'AllFriendScrollBar
        '
        Me.AllFriendScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllFriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AllFriendScrollBar.LargeChange = 10
        Me.AllFriendScrollBar.Location = New System.Drawing.Point(920, 50)
        Me.AllFriendScrollBar.Maximum = 5000
        Me.AllFriendScrollBar.MouseWheelBarPartitions = 2
        Me.AllFriendScrollBar.Name = "AllFriendScrollBar"
        Me.AllFriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.AllFriendScrollBar.Size = New System.Drawing.Size(10, 595)
        Me.AllFriendScrollBar.TabIndex = 79
        Me.AllFriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AllFriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AllFriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.AllFriendScrollBar.Visible = False
        '
        'AllFriendsPanel
        '
        Me.AllFriendsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllFriendsPanel.Controls.Add(Me.pnlUnderlblAllFriends)
        Me.AllFriendsPanel.Location = New System.Drawing.Point(15, 50)
        Me.AllFriendsPanel.Name = "AllFriendsPanel"
        Me.AllFriendsPanel.Size = New System.Drawing.Size(900, 600)
        Me.AllFriendsPanel.TabIndex = 80
        '
        'pnlImgAllFriends
        '
        Me.pnlImgAllFriends.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlImgAllFriends.Controls.Add(Me.IconPictureBox1)
        Me.pnlImgAllFriends.Controls.Add(Me.btnAddNewFriends)
        Me.pnlImgAllFriends.Controls.Add(Me.Label1)
        Me.pnlImgAllFriends.Controls.Add(Me.IconPictureBox3)
        Me.pnlImgAllFriends.Controls.Add(Me.IconPictureBox2)
        Me.pnlImgAllFriends.Controls.Add(Me.IconPictureBox7)
        Me.pnlImgAllFriends.Controls.Add(Me.iconPicFly)
        Me.pnlImgAllFriends.Controls.Add(Me.IconPictureBox6)
        Me.pnlImgAllFriends.Controls.Add(Me.IconPictureBox4)
        Me.pnlImgAllFriends.Controls.Add(Me.IconPictureBox5)
        Me.pnlImgAllFriends.Controls.Add(Me.iconPicUsers)
        Me.pnlImgAllFriends.Location = New System.Drawing.Point(278, 121)
        Me.pnlImgAllFriends.Name = "pnlImgAllFriends"
        Me.pnlImgAllFriends.Size = New System.Drawing.Size(358, 380)
        Me.pnlImgAllFriends.TabIndex = 111
        Me.pnlImgAllFriends.Visible = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.DimGray
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Female
        Me.IconPictureBox1.IconColor = System.Drawing.Color.DimGray
        Me.IconPictureBox1.IconSize = 27
        Me.IconPictureBox1.Location = New System.Drawing.Point(219, 19)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(30, 27)
        Me.IconPictureBox1.TabIndex = 108
        Me.IconPictureBox1.TabStop = False
        '
        'btnAddNewFriends
        '
        Me.btnAddNewFriends.Animated = True
        Me.btnAddNewFriends.AnimationHoverSpeed = 0.07!
        Me.btnAddNewFriends.AnimationSpeed = 0.03!
        Me.btnAddNewFriends.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNewFriends.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnAddNewFriends.BorderColor = System.Drawing.Color.Black
        Me.btnAddNewFriends.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNewFriends.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddNewFriends.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddNewFriends.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAddNewFriends.ForeColor = System.Drawing.Color.White
        Me.btnAddNewFriends.Image = Nothing
        Me.btnAddNewFriends.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddNewFriends.Location = New System.Drawing.Point(126, 301)
        Me.btnAddNewFriends.Name = "btnAddNewFriends"
        Me.btnAddNewFriends.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddNewFriends.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddNewFriends.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddNewFriends.OnHoverImage = Nothing
        Me.btnAddNewFriends.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddNewFriends.Radius = 7
        Me.btnAddNewFriends.Size = New System.Drawing.Size(150, 40)
        Me.btnAddNewFriends.TabIndex = 107
        Me.btnAddNewFriends.Text = "Add Friend"
        Me.btnAddNewFriends.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(42, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 22)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Sense like you don't have friends yet."
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.DarkGray
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.IconPictureBox3.IconColor = System.Drawing.Color.DarkGray
        Me.IconPictureBox3.IconSize = 40
        Me.IconPictureBox3.Location = New System.Drawing.Point(256, 279)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.IconPictureBox3.TabIndex = 106
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.DimGray
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.IconPictureBox2.IconColor = System.Drawing.Color.DimGray
        Me.IconPictureBox2.IconSize = 39
        Me.IconPictureBox2.Location = New System.Drawing.Point(10, 180)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(40, 39)
        Me.IconPictureBox2.TabIndex = 100
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox7
        '
        Me.IconPictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox7.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Snowboarding
        Me.IconPictureBox7.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox7.IconSize = 52
        Me.IconPictureBox7.Location = New System.Drawing.Point(144, 232)
        Me.IconPictureBox7.Name = "IconPictureBox7"
        Me.IconPictureBox7.Size = New System.Drawing.Size(65, 52)
        Me.IconPictureBox7.TabIndex = 105
        Me.IconPictureBox7.TabStop = False
        '
        'iconPicFly
        '
        Me.iconPicFly.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicFly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.iconPicFly.IconChar = FontAwesome.Sharp.IconChar.Cookie
        Me.iconPicFly.IconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.iconPicFly.IconSize = 63
        Me.iconPicFly.Location = New System.Drawing.Point(76, 289)
        Me.iconPicFly.Name = "iconPicFly"
        Me.iconPicFly.Size = New System.Drawing.Size(63, 66)
        Me.iconPicFly.TabIndex = 101
        Me.iconPicFly.TabStop = False
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox6.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Walking
        Me.IconPictureBox6.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox6.IconSize = 29
        Me.IconPictureBox6.Location = New System.Drawing.Point(285, 93)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(29, 32)
        Me.IconPictureBox6.TabIndex = 104
        Me.IconPictureBox6.TabStop = False
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.DarkGray
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.IconPictureBox4.IconColor = System.Drawing.Color.DarkGray
        Me.IconPictureBox4.IconSize = 37
        Me.IconPictureBox4.Location = New System.Drawing.Point(55, 19)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(40, 37)
        Me.IconPictureBox4.TabIndex = 102
        Me.IconPictureBox4.TabStop = False
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Baby
        Me.IconPictureBox5.IconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.IconPictureBox5.IconSize = 36
        Me.IconPictureBox5.Location = New System.Drawing.Point(89, 93)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(36, 38)
        Me.IconPictureBox5.TabIndex = 103
        Me.IconPictureBox5.TabStop = False
        '
        'iconPicUsers
        '
        Me.iconPicUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.iconPicUsers.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.iconPicUsers.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.iconPicUsers.IconSize = 207
        Me.iconPicUsers.Location = New System.Drawing.Point(71, 33)
        Me.iconPicUsers.Name = "iconPicUsers"
        Me.iconPicUsers.Size = New System.Drawing.Size(208, 207)
        Me.iconPicUsers.TabIndex = 97
        Me.iconPicUsers.TabStop = False
        '
        'AllFriendsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.pnlImgAllFriends)
        Me.Controls.Add(Me.AllFriendsPanel)
        Me.Controls.Add(Me.AllFriendScrollBar)
        Me.Controls.Add(Me.lblAllFriends)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllFriendsForm"
        Me.Text = "AllFriendsForm"
        Me.AllFriendsPanel.ResumeLayout(False)
        Me.pnlImgAllFriends.ResumeLayout(False)
        Me.pnlImgAllFriends.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPicFly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconPicUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlUnderlblAllFriends As Panel
    Friend WithEvents lblAllFriends As Label
    Friend WithEvents AllFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents AllFriendsPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlImgAllFriends As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox7 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicFly As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicUsers As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnAddNewFriends As Guna.UI.WinForms.GunaButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
End Class
