﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonalBlogForm
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
        Me.FeedPanel = New Guna.UI.WinForms.GunaPanel()
        Me.post2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.post1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMenuPost = New FontAwesome.Sharp.IconPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.CreatePostPanel = New System.Windows.Forms.Panel()
        Me.UserPicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.btnAddSmile = New FontAwesome.Sharp.IconPictureBox()
        Me.lblEnterUserName = New System.Windows.Forms.Label()
        Me.txtFindFriend = New System.Windows.Forms.TextBox()
        Me.UserProfilePanel = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UserPicBox = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStateOnline = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEdit = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FeedScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.FeedPanel.SuspendLayout()
        Me.post2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.post1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenuPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CreatePostPanel.SuspendLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddSmile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserProfilePanel.SuspendLayout()
        CType(Me.UserPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FeedPanel
        '
        Me.FeedPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.FeedPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FeedPanel.Controls.Add(Me.post2)
        Me.FeedPanel.Controls.Add(Me.post1)
        Me.FeedPanel.Controls.Add(Me.CreatePostPanel)
        Me.FeedPanel.Controls.Add(Me.UserProfilePanel)
        Me.FeedPanel.Location = New System.Drawing.Point(228, 0)
        Me.FeedPanel.Name = "FeedPanel"
        Me.FeedPanel.Size = New System.Drawing.Size(831, 740)
        Me.FeedPanel.TabIndex = 5
        '
        'post2
        '
        Me.post2.Controls.Add(Me.Label8)
        Me.post2.Controls.Add(Me.PictureBox2)
        Me.post2.Controls.Add(Me.IconPictureBox1)
        Me.post2.Controls.Add(Me.Label9)
        Me.post2.Controls.Add(Me.Label10)
        Me.post2.Controls.Add(Me.GunaCirclePictureBox2)
        Me.post2.Location = New System.Drawing.Point(0, 670)
        Me.post2.Name = "post2"
        Me.post2.Size = New System.Drawing.Size(815, 350)
        Me.post2.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(30, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(728, 17)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "UserName"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PlayME.My.Resources.Resources._123123c12321
        Me.PictureBox2.Location = New System.Drawing.Point(30, 92)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 96
        Me.PictureBox2.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.IconPictureBox1.IconSize = 25
        Me.IconPictureBox1.Location = New System.Drawing.Point(760, 15)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(31, 25)
        Me.IconPictureBox1.TabIndex = 98
        Me.IconPictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(80, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "09/08/2020"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(80, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 17)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "UserName"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = Global.PlayME.My.Resources.Resources._123123c12321
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(30, 15)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 98
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'post1
        '
        Me.post1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.post1.Controls.Add(Me.Label7)
        Me.post1.Controls.Add(Me.PictureBox1)
        Me.post1.Controls.Add(Me.btnMenuPost)
        Me.post1.Controls.Add(Me.Label6)
        Me.post1.Controls.Add(Me.Label1)
        Me.post1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.post1.Location = New System.Drawing.Point(0, 305)
        Me.post1.Name = "post1"
        Me.post1.Size = New System.Drawing.Size(815, 350)
        Me.post1.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(27, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(728, 17)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "UserName"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PlayME.My.Resources.Resources.i2gb4m7j7cb41
        Me.PictureBox1.Location = New System.Drawing.Point(30, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'btnMenuPost
        '
        Me.btnMenuPost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuPost.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuPost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnMenuPost.IconChar = FontAwesome.Sharp.IconChar.AngleDown
        Me.btnMenuPost.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnMenuPost.IconSize = 25
        Me.btnMenuPost.Location = New System.Drawing.Point(755, 15)
        Me.btnMenuPost.Name = "btnMenuPost"
        Me.btnMenuPost.Size = New System.Drawing.Size(31, 25)
        Me.btnMenuPost.TabIndex = 98
        Me.btnMenuPost.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(77, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "09/08/2020"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(77, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "UserName"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.PlayME.My.Resources.Resources._123123c12321
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(30, 15)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 98
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'CreatePostPanel
        '
        Me.CreatePostPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreatePostPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CreatePostPanel.Controls.Add(Me.UserPicture)
        Me.CreatePostPanel.Controls.Add(Me.Panel4)
        Me.CreatePostPanel.Controls.Add(Me.GunaButton1)
        Me.CreatePostPanel.Controls.Add(Me.btnAddSmile)
        Me.CreatePostPanel.Controls.Add(Me.lblEnterUserName)
        Me.CreatePostPanel.Controls.Add(Me.txtFindFriend)
        Me.CreatePostPanel.Location = New System.Drawing.Point(30, 240)
        Me.CreatePostPanel.Name = "CreatePostPanel"
        Me.CreatePostPanel.Size = New System.Drawing.Size(760, 50)
        Me.CreatePostPanel.TabIndex = 104
        '
        'UserPicture
        '
        Me.UserPicture.BaseColor = System.Drawing.Color.White
        Me.UserPicture.Image = Global.PlayME.My.Resources.Resources._123123c12321
        Me.UserPicture.Location = New System.Drawing.Point(22, 8)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(35, 35)
        Me.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPicture.TabIndex = 97
        Me.UserPicture.TabStop = False
        Me.UserPicture.UseTransfarantBackground = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Location = New System.Drawing.Point(22, 115)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(723, 1)
        Me.Panel4.TabIndex = 88
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(655, 125)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 7
        Me.GunaButton1.Size = New System.Drawing.Size(65, 30)
        Me.GunaButton1.TabIndex = 96
        Me.GunaButton1.Text = "Post"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddSmile
        '
        Me.btnAddSmile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddSmile.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSmile.ForeColor = System.Drawing.Color.Gray
        Me.btnAddSmile.IconChar = FontAwesome.Sharp.IconChar.SmileWink
        Me.btnAddSmile.IconColor = System.Drawing.Color.Gray
        Me.btnAddSmile.IconSize = 25
        Me.btnAddSmile.Location = New System.Drawing.Point(718, 14)
        Me.btnAddSmile.Name = "btnAddSmile"
        Me.btnAddSmile.Size = New System.Drawing.Size(25, 25)
        Me.btnAddSmile.TabIndex = 96
        Me.btnAddSmile.TabStop = False
        '
        'lblEnterUserName
        '
        Me.lblEnterUserName.AutoSize = True
        Me.lblEnterUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblEnterUserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblEnterUserName.Enabled = False
        Me.lblEnterUserName.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEnterUserName.ForeColor = System.Drawing.Color.Gray
        Me.lblEnterUserName.Location = New System.Drawing.Point(67, 16)
        Me.lblEnterUserName.Name = "lblEnterUserName"
        Me.lblEnterUserName.Size = New System.Drawing.Size(86, 19)
        Me.lblEnterUserName.TabIndex = 80
        Me.lblEnterUserName.Text = "What's new?"
        '
        'txtFindFriend
        '
        Me.txtFindFriend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFindFriend.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtFindFriend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFindFriend.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFindFriend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFindFriend.Location = New System.Drawing.Point(63, 16)
        Me.txtFindFriend.Multiline = True
        Me.txtFindFriend.Name = "txtFindFriend"
        Me.txtFindFriend.Size = New System.Drawing.Size(649, 25)
        Me.txtFindFriend.TabIndex = 95
        '
        'UserProfilePanel
        '
        Me.UserProfilePanel.Controls.Add(Me.Label20)
        Me.UserProfilePanel.Controls.Add(Me.Label19)
        Me.UserProfilePanel.Controls.Add(Me.Label18)
        Me.UserProfilePanel.Controls.Add(Me.Label17)
        Me.UserProfilePanel.Controls.Add(Me.UserPicBox)
        Me.UserProfilePanel.Controls.Add(Me.Label4)
        Me.UserProfilePanel.Controls.Add(Me.lblUserName)
        Me.UserProfilePanel.Controls.Add(Me.Label3)
        Me.UserProfilePanel.Controls.Add(Me.lblStateOnline)
        Me.UserProfilePanel.Controls.Add(Me.Label2)
        Me.UserProfilePanel.Controls.Add(Me.txtUserStatus)
        Me.UserProfilePanel.Controls.Add(Me.Label5)
        Me.UserProfilePanel.Controls.Add(Me.btnEdit)
        Me.UserProfilePanel.Controls.Add(Me.Panel2)
        Me.UserProfilePanel.Controls.Add(Me.Panel1)
        Me.UserProfilePanel.Location = New System.Drawing.Point(0, 0)
        Me.UserProfilePanel.Name = "UserProfilePanel"
        Me.UserProfilePanel.Size = New System.Drawing.Size(815, 230)
        Me.UserProfilePanel.TabIndex = 103
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(382, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(327, 17)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "https://www.linkedin.com/in/bohdan-sivak-b630921b2/"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(382, 154)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 17)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "Single"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(382, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 17)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "Trento"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(382, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 17)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "6/March/2000"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserPicBox
        '
        Me.UserPicBox.Image = Global.PlayME.My.Resources.Resources._123123c12321
        Me.UserPicBox.Location = New System.Drawing.Point(30, 30)
        Me.UserPicBox.Name = "UserPicBox"
        Me.UserPicBox.Size = New System.Drawing.Size(150, 150)
        Me.UserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPicBox.TabIndex = 91
        Me.UserPicBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(200, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Website:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(196, 30)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(79, 19)
        Me.lblUserName.TabIndex = 69
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(200, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Relationship:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStateOnline
        '
        Me.lblStateOnline.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStateOnline.AutoSize = True
        Me.lblStateOnline.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblStateOnline.ForeColor = System.Drawing.Color.LightGray
        Me.lblStateOnline.Location = New System.Drawing.Point(744, 33)
        Me.lblStateOnline.Name = "lblStateOnline"
        Me.lblStateOnline.Size = New System.Drawing.Size(43, 16)
        Me.lblStateOnline.TabIndex = 70
        Me.lblStateOnline.Text = "Online"
        Me.lblStateOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(200, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Current city:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserStatus
        '
        Me.txtUserStatus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUserStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtUserStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserStatus.Enabled = False
        Me.txtUserStatus.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtUserStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtUserStatus.Location = New System.Drawing.Point(200, 52)
        Me.txtUserStatus.Multiline = True
        Me.txtUserStatus.Name = "txtUserStatus"
        Me.txtUserStatus.Size = New System.Drawing.Size(587, 20)
        Me.txtUserStatus.TabIndex = 81
        Me.txtUserStatus.Text = "User Status"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(200, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Birthday:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.AnimationHoverSpeed = 0.07!
        Me.btnEdit.AnimationSpeed = 0.03!
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEdit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEdit.BorderSize = 1
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.FocusedColor = System.Drawing.Color.Empty
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnEdit.Image = Nothing
        Me.btnEdit.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEdit.Location = New System.Drawing.Point(30, 195)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnEdit.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnEdit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEdit.OnHoverImage = Nothing
        Me.btnEdit.OnPressedColor = System.Drawing.Color.Black
        Me.btnEdit.Radius = 7
        Me.btnEdit.Size = New System.Drawing.Size(150, 27)
        Me.btnEdit.TabIndex = 86
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(205, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 1)
        Me.Panel2.TabIndex = 87
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(205, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 1)
        Me.Panel1.TabIndex = 86
        '
        'FeedScrollBar
        '
        Me.FeedScrollBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.FeedScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FeedScrollBar.LargeChange = 10
        Me.FeedScrollBar.Location = New System.Drawing.Point(1049, 0)
        Me.FeedScrollBar.Maximum = 5000
        Me.FeedScrollBar.MouseWheelBarPartitions = 2
        Me.FeedScrollBar.Name = "FeedScrollBar"
        Me.FeedScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.FeedScrollBar.Size = New System.Drawing.Size(10, 720)
        Me.FeedScrollBar.TabIndex = 106
        Me.FeedScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FeedScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.FeedScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        '
        'PersonalBlogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.FeedScrollBar)
        Me.Controls.Add(Me.FeedPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PersonalBlogForm"
        Me.Text = "PersonalBlogForm"
        Me.FeedPanel.ResumeLayout(False)
        Me.post2.ResumeLayout(False)
        Me.post2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.post1.ResumeLayout(False)
        Me.post1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenuPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CreatePostPanel.ResumeLayout(False)
        Me.CreatePostPanel.PerformLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddSmile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserProfilePanel.ResumeLayout(False)
        Me.UserProfilePanel.PerformLayout()
        CType(Me.UserPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FeedPanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents CreatePostPanel As Panel
    Friend WithEvents UserPicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAddSmile As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblEnterUserName As Label
    Friend WithEvents txtFindFriend As TextBox
    Friend WithEvents UserProfilePanel As Panel
    Friend WithEvents UserPicBox As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStateOnline As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEdit As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents post1 As Panel
    Friend WithEvents FeedScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnMenuPost As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents post2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
End Class
