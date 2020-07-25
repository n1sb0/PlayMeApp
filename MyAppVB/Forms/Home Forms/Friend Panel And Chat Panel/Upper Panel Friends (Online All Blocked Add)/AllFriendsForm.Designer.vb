<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllFriendsForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AllFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.AllFriendsPanel = New Guna.UI.WinForms.GunaPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblFriendName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.FriendsPicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblFriendOnline = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.AllFriendsPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.FriendsPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(25, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 2)
        Me.Panel1.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(40, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "All Friends - "
        '
        'AllFriendScrollBar
        '
        Me.AllFriendScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllFriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AllFriendScrollBar.LargeChange = 10
        Me.AllFriendScrollBar.Location = New System.Drawing.Point(935, 30)
        Me.AllFriendScrollBar.Maximum = 5000
        Me.AllFriendScrollBar.MouseWheelBarPartitions = 2
        Me.AllFriendScrollBar.Name = "AllFriendScrollBar"
        Me.AllFriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.AllFriendScrollBar.Size = New System.Drawing.Size(10, 610)
        Me.AllFriendScrollBar.TabIndex = 79
        Me.AllFriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AllFriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AllFriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        '
        'AllFriendsPanel
        '
        Me.AllFriendsPanel.Controls.Add(Me.Panel2)
        Me.AllFriendsPanel.Location = New System.Drawing.Point(25, 38)
        Me.AllFriendsPanel.Name = "AllFriendsPanel"
        Me.AllFriendsPanel.Size = New System.Drawing.Size(900, 610)
        Me.AllFriendsPanel.TabIndex = 80
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GunaButton2)
        Me.Panel2.Controls.Add(Me.GunaButton1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblFriendName)
        Me.Panel2.Controls.Add(Me.FriendsPicture)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 62)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(900, 2)
        Me.Panel3.TabIndex = 78
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
        Me.Label2.Text = "Offline"
        '
        'GunaButton2
        '
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
        Me.GunaButton2.Image = Global.PlayME.My.Resources.Resources.VerticleMenuDots
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
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.PlayME.My.Resources.Resources.chatToFriendx1
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton1.ImageSize = New System.Drawing.Size(22, 22)
        Me.GunaButton1.Location = New System.Drawing.Point(790, 12)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(35, 35)
        Me.GunaButton1.TabIndex = 99
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
        'AllFriendsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.AllFriendsPanel)
        Me.Controls.Add(Me.AllFriendScrollBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllFriendsForm"
        Me.Text = "AllFriendsForm"
        Me.AllFriendsPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.FriendsPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents AllFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents AllFriendsPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFriendName As Label
    Friend WithEvents FriendsPicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents lblFriendOnline As PowerPacks.OvalShape
End Class
