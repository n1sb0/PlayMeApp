<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OnlineFriendsForm
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
        Me.pnlUnderTextOnlineFriends = New System.Windows.Forms.Panel()
        Me.lblFriendsOnlineNow = New System.Windows.Forms.Label()
        Me.pnlFriendsOnlineNow = New Guna.UI.WinForms.GunaPanel()
        Me.pnlImgOnlineFriends = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox7 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicFly = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.iconPicUsers = New FontAwesome.Sharp.IconPictureBox()
        Me.OnlineFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.pnlFriendsOnlineNow.SuspendLayout()
        Me.pnlImgOnlineFriends.SuspendLayout()
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
        'pnlUnderTextOnlineFriends
        '
        Me.pnlUnderTextOnlineFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderTextOnlineFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnderTextOnlineFriends.Location = New System.Drawing.Point(10, 1)
        Me.pnlUnderTextOnlineFriends.Name = "pnlUnderTextOnlineFriends"
        Me.pnlUnderTextOnlineFriends.Size = New System.Drawing.Size(865, 1)
        Me.pnlUnderTextOnlineFriends.TabIndex = 89
        Me.pnlUnderTextOnlineFriends.Visible = False
        '
        'lblFriendsOnlineNow
        '
        Me.lblFriendsOnlineNow.AutoSize = True
        Me.lblFriendsOnlineNow.BackColor = System.Drawing.Color.Transparent
        Me.lblFriendsOnlineNow.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFriendsOnlineNow.ForeColor = System.Drawing.Color.Silver
        Me.lblFriendsOnlineNow.Location = New System.Drawing.Point(32, 15)
        Me.lblFriendsOnlineNow.Name = "lblFriendsOnlineNow"
        Me.lblFriendsOnlineNow.Size = New System.Drawing.Size(65, 17)
        Me.lblFriendsOnlineNow.TabIndex = 90
        Me.lblFriendsOnlineNow.Text = "ONLINE -"
        Me.lblFriendsOnlineNow.Visible = False
        '
        'pnlFriendsOnlineNow
        '
        Me.pnlFriendsOnlineNow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFriendsOnlineNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.pnlFriendsOnlineNow.Controls.Add(Me.pnlImgOnlineFriends)
        Me.pnlFriendsOnlineNow.Controls.Add(Me.pnlUnderTextOnlineFriends)
        Me.pnlFriendsOnlineNow.Location = New System.Drawing.Point(15, 50)
        Me.pnlFriendsOnlineNow.Name = "pnlFriendsOnlineNow"
        Me.pnlFriendsOnlineNow.Size = New System.Drawing.Size(900, 600)
        Me.pnlFriendsOnlineNow.TabIndex = 92
        Me.pnlFriendsOnlineNow.Visible = False
        '
        'pnlImgOnlineFriends
        '
        Me.pnlImgOnlineFriends.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlImgOnlineFriends.Controls.Add(Me.Label1)
        Me.pnlImgOnlineFriends.Controls.Add(Me.IconPictureBox3)
        Me.pnlImgOnlineFriends.Controls.Add(Me.IconPictureBox2)
        Me.pnlImgOnlineFriends.Controls.Add(Me.IconPictureBox7)
        Me.pnlImgOnlineFriends.Controls.Add(Me.iconPicFly)
        Me.pnlImgOnlineFriends.Controls.Add(Me.IconPictureBox6)
        Me.pnlImgOnlineFriends.Controls.Add(Me.IconPictureBox4)
        Me.pnlImgOnlineFriends.Controls.Add(Me.IconPictureBox5)
        Me.pnlImgOnlineFriends.Controls.Add(Me.iconPicUsers)
        Me.pnlImgOnlineFriends.Location = New System.Drawing.Point(270, 120)
        Me.pnlImgOnlineFriends.Name = "pnlImgOnlineFriends"
        Me.pnlImgOnlineFriends.Size = New System.Drawing.Size(390, 320)
        Me.pnlImgOnlineFriends.TabIndex = 110
        Me.pnlImgOnlineFriends.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(8, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 22)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Sense like you don't have friends online now."
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.TelegramPlane
        Me.IconPictureBox3.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox3.IconSize = 40
        Me.IconPictureBox3.Location = New System.Drawing.Point(89, 85)
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
        Me.IconPictureBox2.Location = New System.Drawing.Point(35, 166)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(40, 39)
        Me.IconPictureBox2.TabIndex = 100
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox7
        '
        Me.IconPictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox7.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        Me.IconPictureBox7.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox7.IconSize = 46
        Me.IconPictureBox7.Location = New System.Drawing.Point(312, 142)
        Me.IconPictureBox7.Name = "IconPictureBox7"
        Me.IconPictureBox7.Size = New System.Drawing.Size(46, 51)
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
        Me.iconPicFly.Location = New System.Drawing.Point(35, 244)
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
        Me.IconPictureBox6.IconSize = 49
        Me.IconPictureBox6.Location = New System.Drawing.Point(149, 239)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(50, 49)
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
        Me.IconPictureBox4.Location = New System.Drawing.Point(128, 9)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(40, 37)
        Me.IconPictureBox4.TabIndex = 102
        Me.IconPictureBox4.TabStop = False
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconPictureBox5.IconColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox5.IconSize = 36
        Me.IconPictureBox5.Location = New System.Drawing.Point(258, 33)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(36, 38)
        Me.IconPictureBox5.TabIndex = 103
        Me.IconPictureBox5.TabStop = False
        '
        'iconPicUsers
        '
        Me.iconPicUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.iconPicUsers.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.iconPicUsers.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.iconPicUsers.IconSize = 250
        Me.iconPicUsers.Location = New System.Drawing.Point(55, 16)
        Me.iconPicUsers.Name = "iconPicUsers"
        Me.iconPicUsers.Size = New System.Drawing.Size(250, 250)
        Me.iconPicUsers.TabIndex = 97
        Me.iconPicUsers.TabStop = False
        '
        'OnlineFriendScrollBar
        '
        Me.OnlineFriendScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OnlineFriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OnlineFriendScrollBar.LargeChange = 10
        Me.OnlineFriendScrollBar.Location = New System.Drawing.Point(920, 50)
        Me.OnlineFriendScrollBar.Maximum = 5000
        Me.OnlineFriendScrollBar.MouseWheelBarPartitions = 2
        Me.OnlineFriendScrollBar.Name = "OnlineFriendScrollBar"
        Me.OnlineFriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.OnlineFriendScrollBar.Size = New System.Drawing.Size(10, 595)
        Me.OnlineFriendScrollBar.TabIndex = 91
        Me.OnlineFriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OnlineFriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OnlineFriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.OnlineFriendScrollBar.Visible = False
        '
        'OnlineFriendsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.lblFriendsOnlineNow)
        Me.Controls.Add(Me.pnlFriendsOnlineNow)
        Me.Controls.Add(Me.OnlineFriendScrollBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OnlineFriendsForm"
        Me.Text = "OnlineFriendsForm"
        Me.pnlFriendsOnlineNow.ResumeLayout(False)
        Me.pnlImgOnlineFriends.ResumeLayout(False)
        Me.pnlImgOnlineFriends.PerformLayout()
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

    Friend WithEvents pnlUnderTextOnlineFriends As Panel
    Friend WithEvents lblFriendsOnlineNow As Label
    Friend WithEvents pnlFriendsOnlineNow As Guna.UI.WinForms.GunaPanel
    Friend WithEvents OnlineFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents pnlImgOnlineFriends As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox7 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicFly As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents iconPicUsers As FontAwesome.Sharp.IconPictureBox
End Class
