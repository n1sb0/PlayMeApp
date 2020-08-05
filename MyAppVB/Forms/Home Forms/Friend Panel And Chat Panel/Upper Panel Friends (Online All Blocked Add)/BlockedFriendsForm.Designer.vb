<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockedFriendsForm
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
        Me.BlockedFriendsPanel = New Guna.UI.WinForms.GunaPanel()
        Me.pnlBlocekdFriend = New System.Windows.Forms.Panel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFriendName = New System.Windows.Forms.Label()
        Me.FriendsPicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblFriendOnline = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.lblBlocekdFriends = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BlockedFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.BlockedFriendsPanel.SuspendLayout()
        Me.pnlBlocekdFriend.SuspendLayout()
        CType(Me.FriendsPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlockedFriendsPanel
        '
        Me.BlockedFriendsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BlockedFriendsPanel.Controls.Add(Me.pnlBlocekdFriend)
        Me.BlockedFriendsPanel.Location = New System.Drawing.Point(15, 50)
        Me.BlockedFriendsPanel.Name = "BlockedFriendsPanel"
        Me.BlockedFriendsPanel.Size = New System.Drawing.Size(900, 600)
        Me.BlockedFriendsPanel.TabIndex = 84
        '
        'pnlBlocekdFriend
        '
        Me.pnlBlocekdFriend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBlocekdFriend.Controls.Add(Me.GunaButton2)
        Me.pnlBlocekdFriend.Controls.Add(Me.Label2)
        Me.pnlBlocekdFriend.Controls.Add(Me.lblFriendName)
        Me.pnlBlocekdFriend.Controls.Add(Me.FriendsPicture)
        Me.pnlBlocekdFriend.Controls.Add(Me.Panel3)
        Me.pnlBlocekdFriend.Controls.Add(Me.ShapeContainer1)
        Me.pnlBlocekdFriend.Location = New System.Drawing.Point(0, 0)
        Me.pnlBlocekdFriend.Name = "pnlBlocekdFriend"
        Me.pnlBlocekdFriend.Size = New System.Drawing.Size(900, 62)
        Me.pnlBlocekdFriend.TabIndex = 0
        '
        'GunaButton2
        '
        Me.GunaButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Global.PlayME.My.Resources.Resources.BlockedUser
        Me.GunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton2.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaButton2.Location = New System.Drawing.Point(840, 12)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 15
        Me.GunaButton2.Size = New System.Drawing.Size(35, 35)
        Me.GunaButton2.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(66, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Blocked"
        '
        'lblFriendName
        '
        Me.lblFriendName.BackColor = System.Drawing.Color.Transparent
        Me.lblFriendName.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFriendName.ForeColor = System.Drawing.Color.Gray
        Me.lblFriendName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFriendName.Location = New System.Drawing.Point(66, 10)
        Me.lblFriendName.Name = "lblFriendName"
        Me.lblFriendName.Size = New System.Drawing.Size(150, 20)
        Me.lblFriendName.TabIndex = 96
        Me.lblFriendName.Text = "Friends"
        '
        'FriendsPicture
        '
        Me.FriendsPicture.BackColor = System.Drawing.Color.Transparent
        Me.FriendsPicture.BaseColor = System.Drawing.Color.White
        Me.FriendsPicture.Image = Global.PlayME.My.Resources.Resources.i2gb4m7j7cb41
        Me.FriendsPicture.Location = New System.Drawing.Point(20, 10)
        Me.FriendsPicture.Name = "FriendsPicture"
        Me.FriendsPicture.Size = New System.Drawing.Size(40, 40)
        Me.FriendsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FriendsPicture.TabIndex = 95
        Me.FriendsPicture.TabStop = False
        Me.FriendsPicture.UseTransfarantBackground = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(900, 2)
        Me.Panel3.TabIndex = 78
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lblFriendOnline})
        Me.ShapeContainer1.Size = New System.Drawing.Size(900, 62)
        Me.ShapeContainer1.TabIndex = 101
        Me.ShapeContainer1.TabStop = False
        '
        'lblFriendOnline
        '
        Me.lblFriendOnline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFriendOnline.BorderWidth = 3
        Me.lblFriendOnline.FillColor = System.Drawing.Color.Gray
        Me.lblFriendOnline.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.lblFriendOnline.Location = New System.Drawing.Point(47, 34)
        Me.lblFriendOnline.Name = "lblFriendOnline"
        Me.lblFriendOnline.SelectionColor = System.Drawing.Color.Transparent
        Me.lblFriendOnline.Size = New System.Drawing.Size(12, 12)
        '
        'lblBlocekdFriends
        '
        Me.lblBlocekdFriends.AutoSize = True
        Me.lblBlocekdFriends.BackColor = System.Drawing.Color.Transparent
        Me.lblBlocekdFriends.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBlocekdFriends.ForeColor = System.Drawing.Color.Silver
        Me.lblBlocekdFriends.Location = New System.Drawing.Point(30, 15)
        Me.lblBlocekdFriends.Name = "lblBlocekdFriends"
        Me.lblBlocekdFriends.Size = New System.Drawing.Size(75, 17)
        Me.lblBlocekdFriends.TabIndex = 82
        Me.lblBlocekdFriends.Text = "BLOCKED -"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(25, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 1)
        Me.Panel1.TabIndex = 81
        '
        'BlockedFriendScrollBar
        '
        Me.BlockedFriendScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BlockedFriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BlockedFriendScrollBar.LargeChange = 10
        Me.BlockedFriendScrollBar.Location = New System.Drawing.Point(920, 50)
        Me.BlockedFriendScrollBar.Maximum = 5000
        Me.BlockedFriendScrollBar.MouseWheelBarPartitions = 2
        Me.BlockedFriendScrollBar.Name = "BlockedFriendScrollBar"
        Me.BlockedFriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.BlockedFriendScrollBar.Size = New System.Drawing.Size(10, 595)
        Me.BlockedFriendScrollBar.TabIndex = 80
        Me.BlockedFriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BlockedFriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BlockedFriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.BlockedFriendScrollBar.Visible = False
        '
        'BlockedFriendsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.BlockedFriendScrollBar)
        Me.Controls.Add(Me.BlockedFriendsPanel)
        Me.Controls.Add(Me.lblBlocekdFriends)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BlockedFriendsForm"
        Me.Text = "BlockedFriendsForm"
        Me.BlockedFriendsPanel.ResumeLayout(False)
        Me.pnlBlocekdFriend.ResumeLayout(False)
        CType(Me.FriendsPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BlockedFriendsPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlBlocekdFriend As Panel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFriendName As Label
    Friend WithEvents FriendsPicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents lblFriendOnline As PowerPacks.OvalShape
    Friend WithEvents lblBlocekdFriends As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BlockedFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
End Class
