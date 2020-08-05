<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnlineFriendsForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlUnderTextOnlineFriends = New System.Windows.Forms.Panel()
        Me.lblFriendsOnlineNow = New System.Windows.Forms.Label()
        Me.pnlFriendsOnlineNow = New Guna.UI.WinForms.GunaPanel()
        Me.pnlOfFriendOnlineNow = New System.Windows.Forms.Panel()
        Me.btnMenuOnlineFriend = New Guna.UI.WinForms.GunaButton()
        Me.btnMessageToFriendOnline = New Guna.UI.WinForms.GunaButton()
        Me.lblStateOnline = New System.Windows.Forms.Label()
        Me.lblNameOnlineFriend = New System.Windows.Forms.Label()
        Me.UserOnlinePictureBox = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblOnlineNow = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OnlineFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.pnlFriendsOnlineNow.SuspendLayout()
        Me.pnlOfFriendOnlineNow.SuspendLayout()
        CType(Me.UserOnlinePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlUnderTextOnlineFriends
        '
        Me.pnlUnderTextOnlineFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderTextOnlineFriends.BackColor = System.Drawing.Color.Gray
        Me.pnlUnderTextOnlineFriends.Location = New System.Drawing.Point(25, 49)
        Me.pnlUnderTextOnlineFriends.Name = "pnlUnderTextOnlineFriends"
        Me.pnlUnderTextOnlineFriends.Size = New System.Drawing.Size(865, 1)
        Me.pnlUnderTextOnlineFriends.TabIndex = 89
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
        '
        'pnlFriendsOnlineNow
        '
        Me.pnlFriendsOnlineNow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFriendsOnlineNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.pnlFriendsOnlineNow.Controls.Add(Me.pnlOfFriendOnlineNow)
        Me.pnlFriendsOnlineNow.Location = New System.Drawing.Point(15, 50)
        Me.pnlFriendsOnlineNow.Name = "pnlFriendsOnlineNow"
        Me.pnlFriendsOnlineNow.Size = New System.Drawing.Size(900, 600)
        Me.pnlFriendsOnlineNow.TabIndex = 92
        Me.pnlFriendsOnlineNow.Visible = False
        '
        'pnlOfFriendOnlineNow
        '
        Me.pnlOfFriendOnlineNow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOfFriendOnlineNow.Controls.Add(Me.btnMenuOnlineFriend)
        Me.pnlOfFriendOnlineNow.Controls.Add(Me.btnMessageToFriendOnline)
        Me.pnlOfFriendOnlineNow.Controls.Add(Me.lblStateOnline)
        Me.pnlOfFriendOnlineNow.Controls.Add(Me.lblNameOnlineFriend)
        Me.pnlOfFriendOnlineNow.Controls.Add(Me.UserOnlinePictureBox)
        Me.pnlOfFriendOnlineNow.Controls.Add(Me.Panel7)
        Me.pnlOfFriendOnlineNow.Controls.Add(Me.ShapeContainer3)
        Me.pnlOfFriendOnlineNow.Location = New System.Drawing.Point(0, 0)
        Me.pnlOfFriendOnlineNow.Name = "pnlOfFriendOnlineNow"
        Me.pnlOfFriendOnlineNow.Size = New System.Drawing.Size(900, 60)
        Me.pnlOfFriendOnlineNow.TabIndex = 0
        '
        'btnMenuOnlineFriend
        '
        Me.btnMenuOnlineFriend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuOnlineFriend.AnimationHoverSpeed = 0.07!
        Me.btnMenuOnlineFriend.AnimationSpeed = 0.03!
        Me.btnMenuOnlineFriend.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuOnlineFriend.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMenuOnlineFriend.BorderColor = System.Drawing.Color.Black
        Me.btnMenuOnlineFriend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuOnlineFriend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMenuOnlineFriend.FocusedColor = System.Drawing.Color.Empty
        Me.btnMenuOnlineFriend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenuOnlineFriend.ForeColor = System.Drawing.Color.White
        Me.btnMenuOnlineFriend.Image = Global.PlayME.My.Resources.Resources.VerticleMenuDots
        Me.btnMenuOnlineFriend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMenuOnlineFriend.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMenuOnlineFriend.Location = New System.Drawing.Point(840, 12)
        Me.btnMenuOnlineFriend.Name = "btnMenuOnlineFriend"
        Me.btnMenuOnlineFriend.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMenuOnlineFriend.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMenuOnlineFriend.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMenuOnlineFriend.OnHoverImage = Nothing
        Me.btnMenuOnlineFriend.OnPressedColor = System.Drawing.Color.Black
        Me.btnMenuOnlineFriend.Radius = 15
        Me.btnMenuOnlineFriend.Size = New System.Drawing.Size(35, 35)
        Me.btnMenuOnlineFriend.TabIndex = 100
        '
        'btnMessageToFriendOnline
        '
        Me.btnMessageToFriendOnline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMessageToFriendOnline.AnimationHoverSpeed = 0.07!
        Me.btnMessageToFriendOnline.AnimationSpeed = 0.03!
        Me.btnMessageToFriendOnline.BackColor = System.Drawing.Color.Transparent
        Me.btnMessageToFriendOnline.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMessageToFriendOnline.BorderColor = System.Drawing.Color.Black
        Me.btnMessageToFriendOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMessageToFriendOnline.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMessageToFriendOnline.FocusedColor = System.Drawing.Color.Empty
        Me.btnMessageToFriendOnline.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMessageToFriendOnline.ForeColor = System.Drawing.Color.White
        Me.btnMessageToFriendOnline.Image = Global.PlayME.My.Resources.Resources.chatToFriendx1
        Me.btnMessageToFriendOnline.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMessageToFriendOnline.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnMessageToFriendOnline.Location = New System.Drawing.Point(790, 12)
        Me.btnMessageToFriendOnline.Name = "btnMessageToFriendOnline"
        Me.btnMessageToFriendOnline.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMessageToFriendOnline.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMessageToFriendOnline.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMessageToFriendOnline.OnHoverImage = Nothing
        Me.btnMessageToFriendOnline.OnPressedColor = System.Drawing.Color.Black
        Me.btnMessageToFriendOnline.Radius = 15
        Me.btnMessageToFriendOnline.Size = New System.Drawing.Size(35, 35)
        Me.btnMessageToFriendOnline.TabIndex = 99
        '
        'lblStateOnline
        '
        Me.lblStateOnline.AutoSize = True
        Me.lblStateOnline.BackColor = System.Drawing.Color.Transparent
        Me.lblStateOnline.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblStateOnline.ForeColor = System.Drawing.Color.Gray
        Me.lblStateOnline.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblStateOnline.Location = New System.Drawing.Point(66, 30)
        Me.lblStateOnline.Name = "lblStateOnline"
        Me.lblStateOnline.Size = New System.Drawing.Size(49, 17)
        Me.lblStateOnline.TabIndex = 97
        Me.lblStateOnline.Text = "Online"
        '
        'lblNameOnlineFriend
        '
        Me.lblNameOnlineFriend.AutoSize = True
        Me.lblNameOnlineFriend.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOnlineFriend.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNameOnlineFriend.ForeColor = System.Drawing.Color.Gray
        Me.lblNameOnlineFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNameOnlineFriend.Location = New System.Drawing.Point(66, 10)
        Me.lblNameOnlineFriend.Name = "lblNameOnlineFriend"
        Me.lblNameOnlineFriend.Size = New System.Drawing.Size(57, 19)
        Me.lblNameOnlineFriend.TabIndex = 96
        Me.lblNameOnlineFriend.Text = "Friends"
        '
        'UserOnlinePictureBox
        '
        Me.UserOnlinePictureBox.BackColor = System.Drawing.Color.Transparent
        Me.UserOnlinePictureBox.BaseColor = System.Drawing.Color.White
        Me.UserOnlinePictureBox.Image = Global.PlayME.My.Resources.Resources.i2gb4m7j7cb41
        Me.UserOnlinePictureBox.Location = New System.Drawing.Point(20, 10)
        Me.UserOnlinePictureBox.Name = "UserOnlinePictureBox"
        Me.UserOnlinePictureBox.Size = New System.Drawing.Size(40, 40)
        Me.UserOnlinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserOnlinePictureBox.TabIndex = 95
        Me.UserOnlinePictureBox.TabStop = False
        Me.UserOnlinePictureBox.UseTransfarantBackground = False
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(0, 60)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(900, 2)
        Me.Panel7.TabIndex = 78
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lblOnlineNow})
        Me.ShapeContainer3.Size = New System.Drawing.Size(900, 60)
        Me.ShapeContainer3.TabIndex = 101
        Me.ShapeContainer3.TabStop = False
        '
        'lblOnlineNow
        '
        Me.lblOnlineNow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblOnlineNow.BorderWidth = 3
        Me.lblOnlineNow.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblOnlineNow.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.lblOnlineNow.Location = New System.Drawing.Point(47, 34)
        Me.lblOnlineNow.Name = "lblOnlineNow"
        Me.lblOnlineNow.SelectionColor = System.Drawing.Color.Transparent
        Me.lblOnlineNow.Size = New System.Drawing.Size(12, 12)
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
        Me.Controls.Add(Me.pnlUnderTextOnlineFriends)
        Me.Controls.Add(Me.lblFriendsOnlineNow)
        Me.Controls.Add(Me.pnlFriendsOnlineNow)
        Me.Controls.Add(Me.OnlineFriendScrollBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OnlineFriendsForm"
        Me.Text = "OnlineFriendsForm"
        Me.pnlFriendsOnlineNow.ResumeLayout(False)
        Me.pnlOfFriendOnlineNow.ResumeLayout(False)
        Me.pnlOfFriendOnlineNow.PerformLayout()
        CType(Me.UserOnlinePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlUnderTextOnlineFriends As Panel
    Friend WithEvents lblFriendsOnlineNow As Label
    Friend WithEvents pnlFriendsOnlineNow As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlOfFriendOnlineNow As Panel
    Friend WithEvents btnMenuOnlineFriend As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMessageToFriendOnline As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblStateOnline As Label
    Friend WithEvents lblNameOnlineFriend As Label
    Friend WithEvents UserOnlinePictureBox As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents lblOnlineNow As PowerPacks.OvalShape
    Friend WithEvents OnlineFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
End Class
