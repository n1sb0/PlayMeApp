<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.LeftButtomPanel = New System.Windows.Forms.Panel()
        Me.TransparentBackGround = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.clikedPoint = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.selectedPoint = New Guna.UI.WinForms.GunaButton()
        Me.btnGames = New Guna.UI.WinForms.GunaButton()
        Me.btnMusic = New Guna.UI.WinForms.GunaButton()
        Me.btnVideo = New Guna.UI.WinForms.GunaButton()
        Me.btnPersonalBlog = New Guna.UI.WinForms.GunaButton()
        Me.btnHomeChat = New Guna.UI.WinForms.GunaButton()
        Me.UserPicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnSettings = New FontAwesome.Sharp.IconPictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.pointOnline = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.TopPanel = New System.Windows.Forms.Label()
        Me.LogoName = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.PlayGroundPanel = New System.Windows.Forms.Panel()
        Me.MainChatAndFriendPanel = New System.Windows.Forms.Panel()
        Me.FriendsPanelChild = New System.Windows.Forms.Panel()
        Me.topNavFriend = New System.Windows.Forms.Panel()
        Me.btnPending = New Guna.UI.WinForms.GunaButton()
        Me.btnAddNewFriends = New Guna.UI.WinForms.GunaButton()
        Me.btnBlockedFriends = New Guna.UI.WinForms.GunaButton()
        Me.btnAllFrineds = New Guna.UI.WinForms.GunaButton()
        Me.btnFriendsOnline = New Guna.UI.WinForms.GunaButton()
        Me.picFriend = New System.Windows.Forms.PictureBox()
        Me.lblFriends = New System.Windows.Forms.Label()
        Me.pnlBFA = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnHelp = New FontAwesome.Sharp.IconPictureBox()
        Me.btnCreateChat = New FontAwesome.Sharp.IconPictureBox()
        Me.pnBCH = New System.Windows.Forms.Panel()
        Me.pnlMsgFriends = New System.Windows.Forms.Panel()
        Me.btnNewDirect = New FontAwesome.Sharp.IconPictureBox()
        Me.FriendsChatScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.PanelListOfChatFriends = New Guna.UI.WinForms.GunaPanel()
        Me.lblDirectMessages = New System.Windows.Forms.Label()
        Me.btnFriends = New Guna.UI.WinForms.GunaButton()
        Me.txtFindFriends = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHide = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMaxSizeForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnExit = New FontAwesome.Sharp.IconPictureBox()
        Me.LeftButtomPanel.SuspendLayout()
        CType(Me.TransparentBackGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.PlayGroundPanel.SuspendLayout()
        Me.MainChatAndFriendPanel.SuspendLayout()
        Me.topNavFriend.SuspendLayout()
        CType(Me.picFriend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCreateChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMsgFriends.SuspendLayout()
        CType(Me.btnNewDirect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaxSizeForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LeftButtomPanel
        '
        Me.LeftButtomPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LeftButtomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.LeftButtomPanel.Controls.Add(Me.TransparentBackGround)
        Me.LeftButtomPanel.Controls.Add(Me.clikedPoint)
        Me.LeftButtomPanel.Controls.Add(Me.Panel1)
        Me.LeftButtomPanel.Controls.Add(Me.selectedPoint)
        Me.LeftButtomPanel.Controls.Add(Me.btnGames)
        Me.LeftButtomPanel.Controls.Add(Me.btnMusic)
        Me.LeftButtomPanel.Controls.Add(Me.btnVideo)
        Me.LeftButtomPanel.Controls.Add(Me.btnPersonalBlog)
        Me.LeftButtomPanel.Controls.Add(Me.btnHomeChat)
        Me.LeftButtomPanel.Controls.Add(Me.UserPicture)
        Me.LeftButtomPanel.Controls.Add(Me.lblUserName)
        Me.LeftButtomPanel.Controls.Add(Me.btnSettings)
        Me.LeftButtomPanel.Controls.Add(Me.ShapeContainer1)
        Me.LeftButtomPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftButtomPanel.Name = "LeftButtomPanel"
        Me.LeftButtomPanel.Size = New System.Drawing.Size(70, 700)
        Me.LeftButtomPanel.TabIndex = 65
        '
        'TransparentBackGround
        '
        Me.TransparentBackGround.BackColor = System.Drawing.Color.Transparent
        Me.TransparentBackGround.BaseColor = System.Drawing.Color.Black
        Me.TransparentBackGround.Image = Global.PlayME.My.Resources.Resources.TransBackGround
        Me.TransparentBackGround.Location = New System.Drawing.Point(0, 0)
        Me.TransparentBackGround.Name = "TransparentBackGround"
        Me.TransparentBackGround.Size = New System.Drawing.Size(10, 10)
        Me.TransparentBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TransparentBackGround.TabIndex = 76
        Me.TransparentBackGround.TabStop = False
        '
        'clikedPoint
        '
        Me.clikedPoint.AnimationHoverSpeed = 0.07!
        Me.clikedPoint.AnimationSpeed = 0.03!
        Me.clikedPoint.BackColor = System.Drawing.Color.Transparent
        Me.clikedPoint.BaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.clikedPoint.BorderColor = System.Drawing.Color.Black
        Me.clikedPoint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.clikedPoint.FocusedColor = System.Drawing.Color.Empty
        Me.clikedPoint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.clikedPoint.ForeColor = System.Drawing.Color.White
        Me.clikedPoint.Image = Nothing
        Me.clikedPoint.ImageSize = New System.Drawing.Size(20, 20)
        Me.clikedPoint.Location = New System.Drawing.Point(-15, 36)
        Me.clikedPoint.Name = "clikedPoint"
        Me.clikedPoint.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.clikedPoint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.clikedPoint.OnHoverForeColor = System.Drawing.Color.White
        Me.clikedPoint.OnHoverImage = Nothing
        Me.clikedPoint.OnPressedColor = System.Drawing.Color.Black
        Me.clikedPoint.Radius = 5
        Me.clikedPoint.Size = New System.Drawing.Size(20, 30)
        Me.clikedPoint.TabIndex = 73
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(15, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(40, 1)
        Me.Panel1.TabIndex = 66
        '
        'selectedPoint
        '
        Me.selectedPoint.AnimationHoverSpeed = 0.07!
        Me.selectedPoint.AnimationSpeed = 0.03!
        Me.selectedPoint.BackColor = System.Drawing.Color.Transparent
        Me.selectedPoint.BaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.selectedPoint.BorderColor = System.Drawing.Color.Black
        Me.selectedPoint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.selectedPoint.FocusedColor = System.Drawing.Color.Empty
        Me.selectedPoint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.selectedPoint.ForeColor = System.Drawing.Color.White
        Me.selectedPoint.Image = Nothing
        Me.selectedPoint.ImageSize = New System.Drawing.Size(20, 20)
        Me.selectedPoint.Location = New System.Drawing.Point(-15, 42)
        Me.selectedPoint.Name = "selectedPoint"
        Me.selectedPoint.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.selectedPoint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.selectedPoint.OnHoverForeColor = System.Drawing.Color.White
        Me.selectedPoint.OnHoverImage = Nothing
        Me.selectedPoint.OnPressedColor = System.Drawing.Color.Black
        Me.selectedPoint.Radius = 5
        Me.selectedPoint.Size = New System.Drawing.Size(20, 15)
        Me.selectedPoint.TabIndex = 72
        '
        'btnGames
        '
        Me.btnGames.Animated = True
        Me.btnGames.AnimationHoverSpeed = 0.07!
        Me.btnGames.AnimationSpeed = 0.03!
        Me.btnGames.BackColor = System.Drawing.Color.Transparent
        Me.btnGames.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnGames.BorderColor = System.Drawing.Color.Black
        Me.btnGames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGames.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGames.FocusedColor = System.Drawing.Color.Empty
        Me.btnGames.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGames.ForeColor = System.Drawing.Color.White
        Me.btnGames.Image = Global.PlayME.My.Resources.Resources.icon_Game
        Me.btnGames.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnGames.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGames.Location = New System.Drawing.Point(10, 302)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnGames.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGames.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGames.OnHoverImage = Nothing
        Me.btnGames.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnGames.Radius = 25
        Me.btnGames.Size = New System.Drawing.Size(50, 50)
        Me.btnGames.TabIndex = 71
        '
        'btnMusic
        '
        Me.btnMusic.Animated = True
        Me.btnMusic.AnimationHoverSpeed = 0.07!
        Me.btnMusic.AnimationSpeed = 0.03!
        Me.btnMusic.BackColor = System.Drawing.Color.Transparent
        Me.btnMusic.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMusic.BorderColor = System.Drawing.Color.Black
        Me.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMusic.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMusic.FocusedColor = System.Drawing.Color.Empty
        Me.btnMusic.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMusic.ForeColor = System.Drawing.Color.White
        Me.btnMusic.Image = Global.PlayME.My.Resources.Resources.icon_Music
        Me.btnMusic.ImageOffsetX = 2
        Me.btnMusic.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMusic.Location = New System.Drawing.Point(10, 237)
        Me.btnMusic.Name = "btnMusic"
        Me.btnMusic.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMusic.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMusic.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMusic.OnHoverImage = Nothing
        Me.btnMusic.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMusic.Radius = 25
        Me.btnMusic.Size = New System.Drawing.Size(50, 50)
        Me.btnMusic.TabIndex = 70
        '
        'btnVideo
        '
        Me.btnVideo.Animated = True
        Me.btnVideo.AnimationHoverSpeed = 0.07!
        Me.btnVideo.AnimationSpeed = 0.03!
        Me.btnVideo.BackColor = System.Drawing.Color.Transparent
        Me.btnVideo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnVideo.BorderColor = System.Drawing.Color.Black
        Me.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVideo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnVideo.FocusedColor = System.Drawing.Color.Empty
        Me.btnVideo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVideo.ForeColor = System.Drawing.Color.White
        Me.btnVideo.Image = Global.PlayME.My.Resources.Resources.icons8_play_52
        Me.btnVideo.ImageOffsetX = 1
        Me.btnVideo.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnVideo.Location = New System.Drawing.Point(10, 172)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnVideo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnVideo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnVideo.OnHoverImage = Nothing
        Me.btnVideo.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnVideo.Radius = 25
        Me.btnVideo.Size = New System.Drawing.Size(50, 50)
        Me.btnVideo.TabIndex = 69
        '
        'btnPersonalBlog
        '
        Me.btnPersonalBlog.Animated = True
        Me.btnPersonalBlog.AnimationHoverSpeed = 0.07!
        Me.btnPersonalBlog.AnimationSpeed = 0.03!
        Me.btnPersonalBlog.BackColor = System.Drawing.Color.Transparent
        Me.btnPersonalBlog.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnPersonalBlog.BorderColor = System.Drawing.Color.Black
        Me.btnPersonalBlog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonalBlog.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPersonalBlog.FocusedColor = System.Drawing.Color.Empty
        Me.btnPersonalBlog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPersonalBlog.ForeColor = System.Drawing.Color.White
        Me.btnPersonalBlog.Image = Global.PlayME.My.Resources.Resources.icons8_list_48
        Me.btnPersonalBlog.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPersonalBlog.Location = New System.Drawing.Point(10, 107)
        Me.btnPersonalBlog.Name = "btnPersonalBlog"
        Me.btnPersonalBlog.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnPersonalBlog.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPersonalBlog.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPersonalBlog.OnHoverImage = Nothing
        Me.btnPersonalBlog.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnPersonalBlog.Radius = 25
        Me.btnPersonalBlog.Size = New System.Drawing.Size(50, 50)
        Me.btnPersonalBlog.TabIndex = 68
        '
        'btnHomeChat
        '
        Me.btnHomeChat.Animated = True
        Me.btnHomeChat.AnimationHoverSpeed = 0.07!
        Me.btnHomeChat.AnimationSpeed = 0.03!
        Me.btnHomeChat.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeChat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnHomeChat.BorderColor = System.Drawing.Color.Black
        Me.btnHomeChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHomeChat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomeChat.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomeChat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHomeChat.ForeColor = System.Drawing.Color.White
        Me.btnHomeChat.Image = Global.PlayME.My.Resources.Resources.icons8_chat_50__1_
        Me.btnHomeChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnHomeChat.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnHomeChat.Location = New System.Drawing.Point(10, 27)
        Me.btnHomeChat.Name = "btnHomeChat"
        Me.btnHomeChat.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnHomeChat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeChat.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeChat.OnHoverImage = Nothing
        Me.btnHomeChat.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnHomeChat.Radius = 15
        Me.btnHomeChat.Size = New System.Drawing.Size(50, 50)
        Me.btnHomeChat.TabIndex = 66
        '
        'UserPicture
        '
        Me.UserPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UserPicture.BaseColor = System.Drawing.Color.White
        Me.UserPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UserPicture.Image = Global.PlayME.My.Resources.Resources._123123c12321
        Me.UserPicture.Location = New System.Drawing.Point(10, 579)
        Me.UserPicture.Name = "UserPicture"
        Me.UserPicture.Size = New System.Drawing.Size(50, 50)
        Me.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPicture.TabIndex = 67
        Me.UserPicture.TabStop = False
        Me.UserPicture.UseTransfarantBackground = False
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(0, 641)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(70, 22)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.btnSettings.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSettings.IconSize = 20
        Me.btnSettings.Location = New System.Drawing.Point(25, 668)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(20, 20)
        Me.btnSettings.TabIndex = 1
        Me.btnSettings.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.pointOnline})
        Me.ShapeContainer1.Size = New System.Drawing.Size(70, 700)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'pointOnline
        '
        Me.pointOnline.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pointOnline.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pointOnline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pointOnline.BorderWidth = 3
        Me.pointOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pointOnline.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pointOnline.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.pointOnline.Location = New System.Drawing.Point(45, 616)
        Me.pointOnline.Name = "pointOnline"
        Me.pointOnline.SelectionColor = System.Drawing.Color.Transparent
        Me.pointOnline.Size = New System.Drawing.Size(13, 13)
        '
        'TopPanel
        '
        Me.TopPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.TopPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.TopPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1280, 20)
        Me.TopPanel.TabIndex = 69
        '
        'LogoName
        '
        Me.LogoName.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.LogoName.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LogoName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LogoName.Location = New System.Drawing.Point(6, -1)
        Me.LogoName.Name = "LogoName"
        Me.LogoName.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.LogoName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LogoName.Size = New System.Drawing.Size(35, 20)
        Me.LogoName.TabIndex = 73
        Me.LogoName.Text = "Play"
        Me.LogoName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.PlayGroundPanel)
        Me.MainPanel.Controls.Add(Me.LeftButtomPanel)
        Me.MainPanel.Location = New System.Drawing.Point(0, 20)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1280, 700)
        Me.MainPanel.TabIndex = 74
        '
        'PlayGroundPanel
        '
        Me.PlayGroundPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayGroundPanel.Controls.Add(Me.MainChatAndFriendPanel)
        Me.PlayGroundPanel.Controls.Add(Me.pnlMsgFriends)
        Me.PlayGroundPanel.Location = New System.Drawing.Point(70, 0)
        Me.PlayGroundPanel.Name = "PlayGroundPanel"
        Me.PlayGroundPanel.Size = New System.Drawing.Size(1210, 700)
        Me.PlayGroundPanel.TabIndex = 66
        '
        'MainChatAndFriendPanel
        '
        Me.MainChatAndFriendPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainChatAndFriendPanel.Controls.Add(Me.FriendsPanelChild)
        Me.MainChatAndFriendPanel.Controls.Add(Me.topNavFriend)
        Me.MainChatAndFriendPanel.Location = New System.Drawing.Point(260, 0)
        Me.MainChatAndFriendPanel.Name = "MainChatAndFriendPanel"
        Me.MainChatAndFriendPanel.Size = New System.Drawing.Size(950, 700)
        Me.MainChatAndFriendPanel.TabIndex = 2
        '
        'FriendsPanelChild
        '
        Me.FriendsPanelChild.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FriendsPanelChild.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FriendsPanelChild.Location = New System.Drawing.Point(0, 52)
        Me.FriendsPanelChild.Name = "FriendsPanelChild"
        Me.FriendsPanelChild.Size = New System.Drawing.Size(950, 650)
        Me.FriendsPanelChild.TabIndex = 2
        '
        'topNavFriend
        '
        Me.topNavFriend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.topNavFriend.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.topNavFriend.Controls.Add(Me.btnPending)
        Me.topNavFriend.Controls.Add(Me.btnAddNewFriends)
        Me.topNavFriend.Controls.Add(Me.btnBlockedFriends)
        Me.topNavFriend.Controls.Add(Me.btnAllFrineds)
        Me.topNavFriend.Controls.Add(Me.btnFriendsOnline)
        Me.topNavFriend.Controls.Add(Me.picFriend)
        Me.topNavFriend.Controls.Add(Me.lblFriends)
        Me.topNavFriend.Controls.Add(Me.pnlBFA)
        Me.topNavFriend.Controls.Add(Me.Panel4)
        Me.topNavFriend.Controls.Add(Me.btnHelp)
        Me.topNavFriend.Controls.Add(Me.btnCreateChat)
        Me.topNavFriend.Controls.Add(Me.pnBCH)
        Me.topNavFriend.Location = New System.Drawing.Point(0, 0)
        Me.topNavFriend.Name = "topNavFriend"
        Me.topNavFriend.Size = New System.Drawing.Size(950, 52)
        Me.topNavFriend.TabIndex = 1
        '
        'btnPending
        '
        Me.btnPending.Animated = True
        Me.btnPending.AnimationHoverSpeed = 0.07!
        Me.btnPending.AnimationSpeed = 0.03!
        Me.btnPending.BackColor = System.Drawing.Color.Transparent
        Me.btnPending.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnPending.BorderColor = System.Drawing.Color.Black
        Me.btnPending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPending.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPending.FocusedColor = System.Drawing.Color.Empty
        Me.btnPending.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPending.ForeColor = System.Drawing.Color.DarkGray
        Me.btnPending.Image = Nothing
        Me.btnPending.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPending.Location = New System.Drawing.Point(271, 10)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnPending.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPending.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPending.OnHoverImage = Nothing
        Me.btnPending.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnPending.Radius = 7
        Me.btnPending.Size = New System.Drawing.Size(80, 30)
        Me.btnPending.TabIndex = 95
        Me.btnPending.Text = "Pending"
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
        Me.btnAddNewFriends.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAddNewFriends.ForeColor = System.Drawing.Color.White
        Me.btnAddNewFriends.Image = Nothing
        Me.btnAddNewFriends.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddNewFriends.Location = New System.Drawing.Point(449, 10)
        Me.btnAddNewFriends.Name = "btnAddNewFriends"
        Me.btnAddNewFriends.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnAddNewFriends.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddNewFriends.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddNewFriends.OnHoverImage = Nothing
        Me.btnAddNewFriends.OnPressedColor = System.Drawing.Color.Black
        Me.btnAddNewFriends.Radius = 7
        Me.btnAddNewFriends.Size = New System.Drawing.Size(105, 30)
        Me.btnAddNewFriends.TabIndex = 93
        Me.btnAddNewFriends.Text = "Add Friend"
        '
        'btnBlockedFriends
        '
        Me.btnBlockedFriends.Animated = True
        Me.btnBlockedFriends.AnimationHoverSpeed = 0.07!
        Me.btnBlockedFriends.AnimationSpeed = 0.03!
        Me.btnBlockedFriends.BackColor = System.Drawing.Color.Transparent
        Me.btnBlockedFriends.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnBlockedFriends.BorderColor = System.Drawing.Color.Black
        Me.btnBlockedFriends.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlockedFriends.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBlockedFriends.FocusedColor = System.Drawing.Color.Empty
        Me.btnBlockedFriends.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBlockedFriends.ForeColor = System.Drawing.Color.DarkGray
        Me.btnBlockedFriends.Image = Nothing
        Me.btnBlockedFriends.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBlockedFriends.Location = New System.Drawing.Point(357, 10)
        Me.btnBlockedFriends.Name = "btnBlockedFriends"
        Me.btnBlockedFriends.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnBlockedFriends.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBlockedFriends.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBlockedFriends.OnHoverImage = Nothing
        Me.btnBlockedFriends.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnBlockedFriends.Radius = 7
        Me.btnBlockedFriends.Size = New System.Drawing.Size(80, 30)
        Me.btnBlockedFriends.TabIndex = 92
        Me.btnBlockedFriends.Text = "Blocked"
        '
        'btnAllFrineds
        '
        Me.btnAllFrineds.Animated = True
        Me.btnAllFrineds.AnimationHoverSpeed = 0.07!
        Me.btnAllFrineds.AnimationSpeed = 0.03!
        Me.btnAllFrineds.BackColor = System.Drawing.Color.Transparent
        Me.btnAllFrineds.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAllFrineds.BorderColor = System.Drawing.Color.Black
        Me.btnAllFrineds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAllFrineds.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAllFrineds.FocusedColor = System.Drawing.Color.Empty
        Me.btnAllFrineds.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAllFrineds.ForeColor = System.Drawing.Color.DarkGray
        Me.btnAllFrineds.Image = Nothing
        Me.btnAllFrineds.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAllFrineds.Location = New System.Drawing.Point(224, 10)
        Me.btnAllFrineds.Name = "btnAllFrineds"
        Me.btnAllFrineds.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAllFrineds.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAllFrineds.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAllFrineds.OnHoverImage = Nothing
        Me.btnAllFrineds.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnAllFrineds.Radius = 7
        Me.btnAllFrineds.Size = New System.Drawing.Size(41, 30)
        Me.btnAllFrineds.TabIndex = 91
        Me.btnAllFrineds.Text = "All"
        '
        'btnFriendsOnline
        '
        Me.btnFriendsOnline.Animated = True
        Me.btnFriendsOnline.AnimationHoverSpeed = 0.07!
        Me.btnFriendsOnline.AnimationSpeed = 0.03!
        Me.btnFriendsOnline.BackColor = System.Drawing.Color.Transparent
        Me.btnFriendsOnline.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnFriendsOnline.BorderColor = System.Drawing.Color.Black
        Me.btnFriendsOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFriendsOnline.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFriendsOnline.FocusedColor = System.Drawing.Color.Empty
        Me.btnFriendsOnline.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnFriendsOnline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnFriendsOnline.Image = Nothing
        Me.btnFriendsOnline.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFriendsOnline.Location = New System.Drawing.Point(150, 10)
        Me.btnFriendsOnline.Name = "btnFriendsOnline"
        Me.btnFriendsOnline.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnFriendsOnline.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFriendsOnline.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFriendsOnline.OnHoverImage = Nothing
        Me.btnFriendsOnline.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnFriendsOnline.Radius = 7
        Me.btnFriendsOnline.Size = New System.Drawing.Size(66, 30)
        Me.btnFriendsOnline.TabIndex = 90
        Me.btnFriendsOnline.Text = "Online"
        '
        'picFriend
        '
        Me.picFriend.Image = Global.PlayME.My.Resources.Resources.Person
        Me.picFriend.Location = New System.Drawing.Point(25, 12)
        Me.picFriend.Name = "picFriend"
        Me.picFriend.Size = New System.Drawing.Size(25, 25)
        Me.picFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFriend.TabIndex = 77
        Me.picFriend.TabStop = False
        '
        'lblFriends
        '
        Me.lblFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lblFriends.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFriends.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFriends.Location = New System.Drawing.Point(55, 15)
        Me.lblFriends.Name = "lblFriends"
        Me.lblFriends.Size = New System.Drawing.Size(65, 20)
        Me.lblFriends.TabIndex = 76
        Me.lblFriends.Text = "Friends"
        '
        'pnlBFA
        '
        Me.pnlBFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlBFA.Location = New System.Drawing.Point(131, 10)
        Me.pnlBFA.Name = "pnlBFA"
        Me.pnlBFA.Size = New System.Drawing.Size(1, 30)
        Me.pnlBFA.TabIndex = 67
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(950, 2)
        Me.Panel4.TabIndex = 68
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHelp.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.btnHelp.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHelp.IconSize = 30
        Me.btnHelp.Location = New System.Drawing.Point(905, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(30, 30)
        Me.btnHelp.TabIndex = 94
        Me.btnHelp.TabStop = False
        '
        'btnCreateChat
        '
        Me.btnCreateChat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnCreateChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCreateChat.IconChar = FontAwesome.Sharp.IconChar.CommentMedical
        Me.btnCreateChat.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCreateChat.IconSize = 30
        Me.btnCreateChat.Location = New System.Drawing.Point(838, 12)
        Me.btnCreateChat.Name = "btnCreateChat"
        Me.btnCreateChat.Size = New System.Drawing.Size(30, 30)
        Me.btnCreateChat.TabIndex = 96
        Me.btnCreateChat.TabStop = False
        '
        'pnBCH
        '
        Me.pnBCH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnBCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnBCH.Location = New System.Drawing.Point(890, 10)
        Me.pnBCH.Name = "pnBCH"
        Me.pnBCH.Size = New System.Drawing.Size(1, 30)
        Me.pnBCH.TabIndex = 68
        '
        'pnlMsgFriends
        '
        Me.pnlMsgFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlMsgFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pnlMsgFriends.Controls.Add(Me.btnNewDirect)
        Me.pnlMsgFriends.Controls.Add(Me.FriendsChatScrollBar)
        Me.pnlMsgFriends.Controls.Add(Me.PanelListOfChatFriends)
        Me.pnlMsgFriends.Controls.Add(Me.lblDirectMessages)
        Me.pnlMsgFriends.Controls.Add(Me.btnFriends)
        Me.pnlMsgFriends.Controls.Add(Me.txtFindFriends)
        Me.pnlMsgFriends.Controls.Add(Me.Panel3)
        Me.pnlMsgFriends.Location = New System.Drawing.Point(0, 0)
        Me.pnlMsgFriends.Name = "pnlMsgFriends"
        Me.pnlMsgFriends.Size = New System.Drawing.Size(260, 700)
        Me.pnlMsgFriends.TabIndex = 0
        '
        'btnNewDirect
        '
        Me.btnNewDirect.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnNewDirect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewDirect.ForeColor = System.Drawing.Color.Silver
        Me.btnNewDirect.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnNewDirect.IconColor = System.Drawing.Color.Silver
        Me.btnNewDirect.IconSize = 20
        Me.btnNewDirect.ImageLocation = ""
        Me.btnNewDirect.Location = New System.Drawing.Point(215, 108)
        Me.btnNewDirect.Name = "btnNewDirect"
        Me.btnNewDirect.Size = New System.Drawing.Size(20, 20)
        Me.btnNewDirect.TabIndex = 77
        Me.btnNewDirect.TabStop = False
        '
        'FriendsChatScrollBar
        '
        Me.FriendsChatScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FriendsChatScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FriendsChatScrollBar.LargeChange = 10
        Me.FriendsChatScrollBar.Location = New System.Drawing.Point(250, 140)
        Me.FriendsChatScrollBar.Maximum = 5000
        Me.FriendsChatScrollBar.MouseWheelBarPartitions = 2
        Me.FriendsChatScrollBar.Name = "FriendsChatScrollBar"
        Me.FriendsChatScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.FriendsChatScrollBar.Size = New System.Drawing.Size(10, 560)
        Me.FriendsChatScrollBar.TabIndex = 2
        Me.FriendsChatScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FriendsChatScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FriendsChatScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        '
        'PanelListOfChatFriends
        '
        Me.PanelListOfChatFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelListOfChatFriends.Location = New System.Drawing.Point(0, 140)
        Me.PanelListOfChatFriends.Name = "PanelListOfChatFriends"
        Me.PanelListOfChatFriends.Size = New System.Drawing.Size(260, 577)
        Me.PanelListOfChatFriends.TabIndex = 3
        '
        'lblDirectMessages
        '
        Me.lblDirectMessages.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDirectMessages.ForeColor = System.Drawing.Color.Gray
        Me.lblDirectMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDirectMessages.Location = New System.Drawing.Point(15, 105)
        Me.lblDirectMessages.Name = "lblDirectMessages"
        Me.lblDirectMessages.Size = New System.Drawing.Size(192, 22)
        Me.lblDirectMessages.TabIndex = 74
        Me.lblDirectMessages.Text = "DIRECT MESSAGES"
        Me.lblDirectMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFriends
        '
        Me.btnFriends.Animated = True
        Me.btnFriends.AnimationHoverSpeed = 0.07!
        Me.btnFriends.AnimationSpeed = 0.03!
        Me.btnFriends.BackColor = System.Drawing.Color.Transparent
        Me.btnFriends.BaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnFriends.BorderColor = System.Drawing.Color.Black
        Me.btnFriends.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFriends.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFriends.FocusedColor = System.Drawing.Color.Empty
        Me.btnFriends.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnFriends.ForeColor = System.Drawing.Color.White
        Me.btnFriends.Image = Global.PlayME.My.Resources.Resources.Person
        Me.btnFriends.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnFriends.Location = New System.Drawing.Point(15, 58)
        Me.btnFriends.Name = "btnFriends"
        Me.btnFriends.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnFriends.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnFriends.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFriends.OnHoverImage = Nothing
        Me.btnFriends.OnPressedColor = System.Drawing.Color.Black
        Me.btnFriends.Radius = 7
        Me.btnFriends.Size = New System.Drawing.Size(230, 30)
        Me.btnFriends.TabIndex = 74
        Me.btnFriends.Text = "Friends"
        '
        'txtFindFriends
        '
        Me.txtFindFriends.BackColor = System.Drawing.Color.Transparent
        Me.txtFindFriends.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtFindFriends.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtFindFriends.BorderSize = 1
        Me.txtFindFriends.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFindFriends.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFindFriends.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFindFriends.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFindFriends.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFindFriends.ForeColor = System.Drawing.Color.Silver
        Me.txtFindFriends.Location = New System.Drawing.Point(10, 10)
        Me.txtFindFriends.Name = "txtFindFriends"
        Me.txtFindFriends.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFindFriends.Radius = 5
        Me.txtFindFriends.SelectedText = ""
        Me.txtFindFriends.Size = New System.Drawing.Size(240, 30)
        Me.txtFindFriends.TabIndex = 68
        Me.txtFindFriends.Text = "Find Your Friends"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 2)
        Me.Panel3.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Me"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHide.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btnHide.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHide.IconSize = 18
        Me.btnHide.Location = New System.Drawing.Point(1205, 2)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(20, 18)
        Me.btnHide.TabIndex = 75
        Me.btnHide.TabStop = False
        '
        'btnMaxSizeForm
        '
        Me.btnMaxSizeForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaxSizeForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnMaxSizeForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaxSizeForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaxSizeForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnMaxSizeForm.IconSize = 18
        Me.btnMaxSizeForm.Location = New System.Drawing.Point(1231, 2)
        Me.btnMaxSizeForm.Name = "btnMaxSizeForm"
        Me.btnMaxSizeForm.Size = New System.Drawing.Size(20, 18)
        Me.btnMaxSizeForm.TabIndex = 72
        Me.btnMaxSizeForm.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnExit.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnExit.IconSize = 18
        Me.btnExit.Location = New System.Drawing.Point(1256, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 18)
        Me.btnExit.TabIndex = 70
        Me.btnExit.TabStop = False
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogoName)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.btnMaxSizeForm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TopPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(910, 550)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.LeftButtomPanel.ResumeLayout(False)
        CType(Me.TransparentBackGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PlayGroundPanel.ResumeLayout(False)
        Me.MainChatAndFriendPanel.ResumeLayout(False)
        Me.topNavFriend.ResumeLayout(False)
        CType(Me.picFriend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCreateChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMsgFriends.ResumeLayout(False)
        CType(Me.btnNewDirect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaxSizeForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LeftButtomPanel As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents TopPanel As Label
    Friend WithEvents btnMaxSizeForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LogoName As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents btnSettings As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btnHomeChat As Guna.UI.WinForms.GunaButton
    Friend WithEvents UserPicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents pointOnline As PowerPacks.OvalShape
    Friend WithEvents btnGames As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMusic As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnVideo As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPersonalBlog As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents selectedPoint As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnHide As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PlayGroundPanel As Panel
    Friend WithEvents clikedPoint As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlMsgFriends As Panel
    Friend WithEvents topNavFriend As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtFindFriends As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblDirectMessages As Label
    Friend WithEvents btnFriends As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblFriends As Label
    Friend WithEvents pnlBFA As Panel
    Friend WithEvents picFriend As PictureBox
    Friend WithEvents btnFriendsOnline As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAddNewFriends As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnBlockedFriends As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAllFrineds As Guna.UI.WinForms.GunaButton
    Friend WithEvents MainChatAndFriendPanel As Panel
    Friend WithEvents FriendsChatScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents PanelListOfChatFriends As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnHelp As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents FriendsPanelChild As Panel
    Friend WithEvents btnPending As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnNewDirect As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnBCH As Panel
    Friend WithEvents btnCreateChat As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TransparentBackGround As Guna.UI.WinForms.GunaTransfarantPictureBox
End Class
