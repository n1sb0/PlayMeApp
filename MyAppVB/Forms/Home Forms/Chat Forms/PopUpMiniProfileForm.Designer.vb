<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpMiniProfileForm
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
        Me.btnSendOrMessage = New Guna.UI.WinForms.GunaButton()
        Me.btnCancel = New Guna.UI.WinForms.GunaButton()
        Me.UserPicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.pointOnline = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnUserInfo = New Guna.UI.WinForms.GunaButton()
        Me.btnMatualFriends = New Guna.UI.WinForms.GunaButton()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSendOrMessage
        '
        Me.btnSendOrMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendOrMessage.Animated = True
        Me.btnSendOrMessage.AnimationHoverSpeed = 0.07!
        Me.btnSendOrMessage.AnimationSpeed = 0.03!
        Me.btnSendOrMessage.BackColor = System.Drawing.Color.Transparent
        Me.btnSendOrMessage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSendOrMessage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnSendOrMessage.BorderSize = 1
        Me.btnSendOrMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendOrMessage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSendOrMessage.FocusedColor = System.Drawing.Color.Empty
        Me.btnSendOrMessage.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSendOrMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSendOrMessage.Image = Nothing
        Me.btnSendOrMessage.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSendOrMessage.Location = New System.Drawing.Point(364, 59)
        Me.btnSendOrMessage.Name = "btnSendOrMessage"
        Me.btnSendOrMessage.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSendOrMessage.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSendOrMessage.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSendOrMessage.OnHoverImage = Nothing
        Me.btnSendOrMessage.OnPressedColor = System.Drawing.Color.Black
        Me.btnSendOrMessage.Radius = 5
        Me.btnSendOrMessage.Size = New System.Drawing.Size(155, 36)
        Me.btnSendOrMessage.TabIndex = 103
        Me.btnSendOrMessage.Text = "Send Friend Request"
        Me.btnSendOrMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Animated = True
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderSize = 1
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCancel.Image = Global.PlayME.My.Resources.Resources.VerticleMenuDots
        Me.btnCancel.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancel.Location = New System.Drawing.Point(525, 59)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnCancel.Radius = 5
        Me.btnCancel.Size = New System.Drawing.Size(50, 36)
        Me.btnCancel.TabIndex = 104
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserPicture
        '
        Me.UserPicture.BaseColor = System.Drawing.Color.White
        Me.UserPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UserPicture.Image = Global.PlayME.My.Resources.Resources._123123c12321
        Me.UserPicture.Location = New System.Drawing.Point(50, 50)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(100, 100)
        Me.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPicture.TabIndex = 105
        Me.UserPicture.TabStop = False
        Me.UserPicture.UseTransfarantBackground = False
        '
        'pointOnline
        '
        Me.pointOnline.BackColor = System.Drawing.Color.Transparent
        Me.pointOnline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.pointOnline.BorderWidth = 3
        Me.pointOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pointOnline.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pointOnline.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.pointOnline.Location = New System.Drawing.Point(125, 125)
        Me.pointOnline.Name = "pointOnline"
        Me.pointOnline.SelectionColor = System.Drawing.Color.Transparent
        Me.pointOnline.Size = New System.Drawing.Size(20, 20)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.pointOnline})
        Me.ShapeContainer1.Size = New System.Drawing.Size(625, 225)
        Me.ShapeContainer1.TabIndex = 106
        Me.ShapeContainer1.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(156, 67)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(89, 19)
        Me.lblUserName.TabIndex = 107
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(625, 2)
        Me.Panel4.TabIndex = 108
        '
        'btnUserInfo
        '
        Me.btnUserInfo.Animated = True
        Me.btnUserInfo.AnimationHoverSpeed = 0.07!
        Me.btnUserInfo.AnimationSpeed = 0.03!
        Me.btnUserInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.BaseColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.BorderColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.BorderSize = 1
        Me.btnUserInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserInfo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUserInfo.FocusedColor = System.Drawing.Color.Empty
        Me.btnUserInfo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUserInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnUserInfo.Image = Nothing
        Me.btnUserInfo.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnUserInfo.Location = New System.Drawing.Point(50, 175)
        Me.btnUserInfo.Name = "btnUserInfo"
        Me.btnUserInfo.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnUserInfo.OnHoverImage = Nothing
        Me.btnUserInfo.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnUserInfo.Radius = 5
        Me.btnUserInfo.Size = New System.Drawing.Size(75, 36)
        Me.btnUserInfo.TabIndex = 109
        Me.btnUserInfo.Text = "User Info"
        Me.btnUserInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMatualFriends
        '
        Me.btnMatualFriends.Animated = True
        Me.btnMatualFriends.AnimationHoverSpeed = 0.07!
        Me.btnMatualFriends.AnimationSpeed = 0.03!
        Me.btnMatualFriends.BackColor = System.Drawing.Color.Transparent
        Me.btnMatualFriends.BaseColor = System.Drawing.Color.Transparent
        Me.btnMatualFriends.BorderColor = System.Drawing.Color.Transparent
        Me.btnMatualFriends.BorderSize = 1
        Me.btnMatualFriends.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMatualFriends.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMatualFriends.FocusedColor = System.Drawing.Color.Empty
        Me.btnMatualFriends.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMatualFriends.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnMatualFriends.Image = Nothing
        Me.btnMatualFriends.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMatualFriends.Location = New System.Drawing.Point(150, 175)
        Me.btnMatualFriends.Name = "btnMatualFriends"
        Me.btnMatualFriends.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnMatualFriends.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnMatualFriends.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMatualFriends.OnHoverImage = Nothing
        Me.btnMatualFriends.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnMatualFriends.Radius = 5
        Me.btnMatualFriends.Size = New System.Drawing.Size(115, 36)
        Me.btnMatualFriends.TabIndex = 110
        Me.btnMatualFriends.Text = "Matual Friends"
        Me.btnMatualFriends.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PopUpMiniProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(625, 225)
        Me.Controls.Add(Me.btnMatualFriends)
        Me.Controls.Add(Me.btnUserInfo)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSendOrMessage)
        Me.Controls.Add(Me.UserPicture)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PopUpMiniProfileForm"
        Me.Text = "PopUpMiniProfileForm"
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSendOrMessage As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents UserPicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents pointOnline As PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents lblUserName As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnUserInfo As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMatualFriends As Guna.UI.WinForms.GunaButton
End Class
