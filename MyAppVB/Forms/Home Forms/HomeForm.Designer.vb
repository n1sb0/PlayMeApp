<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LeftButtomPanel = New System.Windows.Forms.Panel()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.btnMyAccount = New Guna.UI.WinForms.GunaButton()
        Me.picFriend = New System.Windows.Forms.PictureBox()
        Me.lblFriends = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlMsgFriends = New System.Windows.Forms.Panel()
        Me.PanelListOfFriends = New Guna.UI.WinForms.GunaPanel()
        Me.pnlFriend = New System.Windows.Forms.Panel()
        Me.lblFriendName = New System.Windows.Forms.Label()
        Me.btnDeleteMessages = New FontAwesome.Sharp.IconPictureBox()
        Me.FriendsPicture = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblFriendOnline = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.FriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.btnNewDirect = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFriends = New Guna.UI.WinForms.GunaButton()
        Me.txtFindFriends = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnHide = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMaxSizeForm = New FontAwesome.Sharp.IconPictureBox()
        Me.btnExit = New FontAwesome.Sharp.IconPictureBox()
        Me.LeftButtomPanel.SuspendLayout()
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.PlayGroundPanel.SuspendLayout()
        Me.MainChatAndFriendPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picFriend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMsgFriends.SuspendLayout()
        Me.PanelListOfFriends.SuspendLayout()
        Me.pnlFriend.SuspendLayout()
        CType(Me.btnDeleteMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FriendsPicture, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LeftButtomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
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
        Me.LeftButtomPanel.Location = New System.Drawing.Point(0, -20)
        Me.LeftButtomPanel.Name = "LeftButtomPanel"
        Me.LeftButtomPanel.Size = New System.Drawing.Size(70, 720)
        Me.LeftButtomPanel.TabIndex = 65
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
        Me.clikedPoint.Location = New System.Drawing.Point(-15, 44)
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
        Me.Panel1.Location = New System.Drawing.Point(15, 100)
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
        Me.selectedPoint.Location = New System.Drawing.Point(-15, 50)
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
        Me.btnGames.AnimationHoverSpeed = 0.07!
        Me.btnGames.AnimationSpeed = 0.03!
        Me.btnGames.BackColor = System.Drawing.Color.Transparent
        Me.btnGames.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnGames.BorderColor = System.Drawing.Color.Black
        Me.btnGames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGames.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGames.FocusedColor = System.Drawing.Color.Empty
        Me.btnGames.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGames.ForeColor = System.Drawing.Color.White
        Me.btnGames.Image = Global.PlayME.My.Resources.Resources.icon_Game
        Me.btnGames.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnGames.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGames.Location = New System.Drawing.Point(10, 310)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnGames.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGames.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGames.OnHoverImage = Nothing
        Me.btnGames.OnPressedColor = System.Drawing.Color.Black
        Me.btnGames.Radius = 25
        Me.btnGames.Size = New System.Drawing.Size(50, 50)
        Me.btnGames.TabIndex = 71
        '
        'btnMusic
        '
        Me.btnMusic.AnimationHoverSpeed = 0.07!
        Me.btnMusic.AnimationSpeed = 0.03!
        Me.btnMusic.BackColor = System.Drawing.Color.Transparent
        Me.btnMusic.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMusic.BorderColor = System.Drawing.Color.Black
        Me.btnMusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMusic.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMusic.FocusedColor = System.Drawing.Color.Empty
        Me.btnMusic.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMusic.ForeColor = System.Drawing.Color.White
        Me.btnMusic.Image = Global.PlayME.My.Resources.Resources.icon_Music
        Me.btnMusic.ImageOffsetX = 2
        Me.btnMusic.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMusic.Location = New System.Drawing.Point(10, 245)
        Me.btnMusic.Name = "btnMusic"
        Me.btnMusic.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMusic.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMusic.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMusic.OnHoverImage = Nothing
        Me.btnMusic.OnPressedColor = System.Drawing.Color.Black
        Me.btnMusic.Radius = 25
        Me.btnMusic.Size = New System.Drawing.Size(50, 50)
        Me.btnMusic.TabIndex = 70
        '
        'btnVideo
        '
        Me.btnVideo.AnimationHoverSpeed = 0.07!
        Me.btnVideo.AnimationSpeed = 0.03!
        Me.btnVideo.BackColor = System.Drawing.Color.Transparent
        Me.btnVideo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnVideo.BorderColor = System.Drawing.Color.Black
        Me.btnVideo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVideo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnVideo.FocusedColor = System.Drawing.Color.Empty
        Me.btnVideo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVideo.ForeColor = System.Drawing.Color.White
        Me.btnVideo.Image = Global.PlayME.My.Resources.Resources.icons8_play_52
        Me.btnVideo.ImageOffsetX = 1
        Me.btnVideo.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnVideo.Location = New System.Drawing.Point(10, 180)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnVideo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnVideo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnVideo.OnHoverImage = Nothing
        Me.btnVideo.OnPressedColor = System.Drawing.Color.Black
        Me.btnVideo.Radius = 25
        Me.btnVideo.Size = New System.Drawing.Size(50, 50)
        Me.btnVideo.TabIndex = 69
        '
        'btnPersonalBlog
        '
        Me.btnPersonalBlog.AnimationHoverSpeed = 0.07!
        Me.btnPersonalBlog.AnimationSpeed = 0.03!
        Me.btnPersonalBlog.BackColor = System.Drawing.Color.Transparent
        Me.btnPersonalBlog.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnPersonalBlog.BorderColor = System.Drawing.Color.Black
        Me.btnPersonalBlog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonalBlog.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPersonalBlog.FocusedColor = System.Drawing.Color.Empty
        Me.btnPersonalBlog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPersonalBlog.ForeColor = System.Drawing.Color.White
        Me.btnPersonalBlog.Image = Global.PlayME.My.Resources.Resources.icons8_list_48
        Me.btnPersonalBlog.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPersonalBlog.Location = New System.Drawing.Point(10, 115)
        Me.btnPersonalBlog.Name = "btnPersonalBlog"
        Me.btnPersonalBlog.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnPersonalBlog.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPersonalBlog.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPersonalBlog.OnHoverImage = Nothing
        Me.btnPersonalBlog.OnPressedColor = System.Drawing.Color.Black
        Me.btnPersonalBlog.Radius = 25
        Me.btnPersonalBlog.Size = New System.Drawing.Size(50, 50)
        Me.btnPersonalBlog.TabIndex = 68
        '
        'btnHomeChat
        '
        Me.btnHomeChat.AnimationHoverSpeed = 0.07!
        Me.btnHomeChat.AnimationSpeed = 0.03!
        Me.btnHomeChat.BackColor = System.Drawing.Color.Transparent
        Me.btnHomeChat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnHomeChat.BorderColor = System.Drawing.Color.Black
        Me.btnHomeChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHomeChat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHomeChat.FocusedColor = System.Drawing.Color.Empty
        Me.btnHomeChat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHomeChat.ForeColor = System.Drawing.Color.White
        Me.btnHomeChat.Image = Global.PlayME.My.Resources.Resources.icons8_chat_50__1_
        Me.btnHomeChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnHomeChat.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnHomeChat.Location = New System.Drawing.Point(10, 35)
        Me.btnHomeChat.Name = "btnHomeChat"
        Me.btnHomeChat.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnHomeChat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHomeChat.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHomeChat.OnHoverImage = Nothing
        Me.btnHomeChat.OnPressedColor = System.Drawing.Color.Black
        Me.btnHomeChat.Radius = 10
        Me.btnHomeChat.Size = New System.Drawing.Size(50, 50)
        Me.btnHomeChat.TabIndex = 66
        '
        'UserPicture
        '
        Me.UserPicture.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UserPicture.BaseColor = System.Drawing.Color.White
        Me.UserPicture.Image = Global.PlayME.My.Resources.Resources.t9f6bjjt7br31
        Me.UserPicture.Location = New System.Drawing.Point(10, 599)
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
        Me.lblUserName.ForeColor = System.Drawing.Color.Transparent
        Me.lblUserName.Location = New System.Drawing.Point(0, 661)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(70, 22)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.btnSettings.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSettings.IconSize = 20
        Me.btnSettings.Location = New System.Drawing.Point(25, 688)
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(70, 720)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'pointOnline
        '
        Me.pointOnline.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pointOnline.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pointOnline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pointOnline.BorderWidth = 5
        Me.pointOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pointOnline.FillColor = System.Drawing.Color.Lime
        Me.pointOnline.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.pointOnline.Location = New System.Drawing.Point(45, 635)
        Me.pointOnline.Name = "pointOnline"
        Me.pointOnline.SelectionColor = System.Drawing.Color.Transparent
        Me.pointOnline.Size = New System.Drawing.Size(15, 15)
        '
        'TopPanel
        '
        Me.TopPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TopPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.TopPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1280, 20)
        Me.TopPanel.TabIndex = 69
        '
        'LogoName
        '
        Me.LogoName.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LogoName.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LogoName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LogoName.Location = New System.Drawing.Point(10, 0)
        Me.LogoName.Name = "LogoName"
        Me.LogoName.Size = New System.Drawing.Size(55, 20)
        Me.LogoName.TabIndex = 73
        Me.LogoName.Text = "PlayMe"
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.MainChatAndFriendPanel.Controls.Add(Me.Panel2)
        Me.MainChatAndFriendPanel.Location = New System.Drawing.Point(260, 0)
        Me.MainChatAndFriendPanel.Name = "MainChatAndFriendPanel"
        Me.MainChatAndFriendPanel.Size = New System.Drawing.Size(950, 700)
        Me.MainChatAndFriendPanel.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.GunaButton4)
        Me.Panel2.Controls.Add(Me.GunaButton3)
        Me.Panel2.Controls.Add(Me.GunaButton1)
        Me.Panel2.Controls.Add(Me.btnMyAccount)
        Me.Panel2.Controls.Add(Me.picFriend)
        Me.Panel2.Controls.Add(Me.lblFriends)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 52)
        Me.Panel2.TabIndex = 1
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(343, 10)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 7
        Me.GunaButton4.Size = New System.Drawing.Size(106, 30)
        Me.GunaButton4.TabIndex = 93
        Me.GunaButton4.Text = "Add Friend"
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.DarkGray
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(257, 10)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 7
        Me.GunaButton3.Size = New System.Drawing.Size(80, 30)
        Me.GunaButton3.TabIndex = 92
        Me.GunaButton3.Text = "Blocked"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.DarkGray
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(210, 10)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 7
        Me.GunaButton1.Size = New System.Drawing.Size(41, 30)
        Me.GunaButton1.TabIndex = 91
        Me.GunaButton1.Text = "All"
        '
        'btnMyAccount
        '
        Me.btnMyAccount.AnimationHoverSpeed = 0.07!
        Me.btnMyAccount.AnimationSpeed = 0.03!
        Me.btnMyAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnMyAccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnMyAccount.BorderColor = System.Drawing.Color.Black
        Me.btnMyAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMyAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnMyAccount.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMyAccount.ForeColor = System.Drawing.Color.DarkGray
        Me.btnMyAccount.Image = Nothing
        Me.btnMyAccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMyAccount.Location = New System.Drawing.Point(138, 10)
        Me.btnMyAccount.Name = "btnMyAccount"
        Me.btnMyAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnMyAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMyAccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMyAccount.OnHoverImage = Nothing
        Me.btnMyAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnMyAccount.Radius = 7
        Me.btnMyAccount.Size = New System.Drawing.Size(66, 30)
        Me.btnMyAccount.TabIndex = 90
        Me.btnMyAccount.Text = "Online"
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(131, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 30)
        Me.Panel5.TabIndex = 67
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
        'pnlMsgFriends
        '
        Me.pnlMsgFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlMsgFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pnlMsgFriends.Controls.Add(Me.PanelListOfFriends)
        Me.pnlMsgFriends.Controls.Add(Me.FriendScrollBar)
        Me.pnlMsgFriends.Controls.Add(Me.btnNewDirect)
        Me.pnlMsgFriends.Controls.Add(Me.Label1)
        Me.pnlMsgFriends.Controls.Add(Me.btnFriends)
        Me.pnlMsgFriends.Controls.Add(Me.txtFindFriends)
        Me.pnlMsgFriends.Controls.Add(Me.Panel3)
        Me.pnlMsgFriends.Location = New System.Drawing.Point(0, 0)
        Me.pnlMsgFriends.Name = "pnlMsgFriends"
        Me.pnlMsgFriends.Size = New System.Drawing.Size(260, 700)
        Me.pnlMsgFriends.TabIndex = 0
        '
        'PanelListOfFriends
        '
        Me.PanelListOfFriends.Controls.Add(Me.pnlFriend)
        Me.PanelListOfFriends.Location = New System.Drawing.Point(0, 140)
        Me.PanelListOfFriends.Name = "PanelListOfFriends"
        Me.PanelListOfFriends.Size = New System.Drawing.Size(260, 580)
        Me.PanelListOfFriends.TabIndex = 3
        '
        'pnlFriend
        '
        Me.pnlFriend.Controls.Add(Me.lblFriendName)
        Me.pnlFriend.Controls.Add(Me.btnDeleteMessages)
        Me.pnlFriend.Controls.Add(Me.FriendsPicture)
        Me.pnlFriend.Controls.Add(Me.ShapeContainer2)
        Me.pnlFriend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlFriend.Location = New System.Drawing.Point(0, 0)
        Me.pnlFriend.Name = "pnlFriend"
        Me.pnlFriend.Size = New System.Drawing.Size(260, 60)
        Me.pnlFriend.TabIndex = 77
        Me.pnlFriend.Visible = False
        '
        'lblFriendName
        '
        Me.lblFriendName.BackColor = System.Drawing.Color.Transparent
        Me.lblFriendName.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFriendName.ForeColor = System.Drawing.Color.Gray
        Me.lblFriendName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFriendName.Location = New System.Drawing.Point(55, 20)
        Me.lblFriendName.Name = "lblFriendName"
        Me.lblFriendName.Size = New System.Drawing.Size(150, 20)
        Me.lblFriendName.TabIndex = 94
        Me.lblFriendName.Text = "Friends"
        '
        'btnDeleteMessages
        '
        Me.btnDeleteMessages.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteMessages.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteMessages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteMessages.ForeColor = System.Drawing.Color.Silver
        Me.btnDeleteMessages.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnDeleteMessages.IconColor = System.Drawing.Color.Silver
        Me.btnDeleteMessages.IconSize = 20
        Me.btnDeleteMessages.Location = New System.Drawing.Point(232, 21)
        Me.btnDeleteMessages.Name = "btnDeleteMessages"
        Me.btnDeleteMessages.Size = New System.Drawing.Size(20, 20)
        Me.btnDeleteMessages.TabIndex = 76
        Me.btnDeleteMessages.TabStop = False
        '
        'FriendsPicture
        '
        Me.FriendsPicture.BackColor = System.Drawing.Color.Transparent
        Me.FriendsPicture.BaseColor = System.Drawing.Color.White
        Me.FriendsPicture.Image = Global.PlayME.My.Resources.Resources.i2gb4m7j7cb41
        Me.FriendsPicture.Location = New System.Drawing.Point(11, 9)
        Me.FriendsPicture.Name = "FriendsPicture"
        Me.FriendsPicture.Size = New System.Drawing.Size(40, 40)
        Me.FriendsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FriendsPicture.TabIndex = 74
        Me.FriendsPicture.TabStop = False
        Me.FriendsPicture.UseTransfarantBackground = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lblFriendOnline})
        Me.ShapeContainer2.Size = New System.Drawing.Size(260, 60)
        Me.ShapeContainer2.TabIndex = 95
        Me.ShapeContainer2.TabStop = False
        '
        'lblFriendOnline
        '
        Me.lblFriendOnline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblFriendOnline.BorderWidth = 2
        Me.lblFriendOnline.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblFriendOnline.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.lblFriendOnline.Location = New System.Drawing.Point(39, 37)
        Me.lblFriendOnline.Name = "lblFriendOnline"
        Me.lblFriendOnline.SelectionColor = System.Drawing.Color.Transparent
        Me.lblFriendOnline.Size = New System.Drawing.Size(12, 12)
        '
        'FriendScrollBar
        '
        Me.FriendScrollBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FriendScrollBar.LargeChange = 10
        Me.FriendScrollBar.Location = New System.Drawing.Point(250, 140)
        Me.FriendScrollBar.Maximum = 100
        Me.FriendScrollBar.Name = "FriendScrollBar"
        Me.FriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.FriendScrollBar.Size = New System.Drawing.Size(10, 580)
        Me.FriendScrollBar.TabIndex = 2
        Me.FriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        '
        'btnNewDirect
        '
        Me.btnNewDirect.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnNewDirect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewDirect.ForeColor = System.Drawing.Color.Silver
        Me.btnNewDirect.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnNewDirect.IconColor = System.Drawing.Color.Silver
        Me.btnNewDirect.IconSize = 20
        Me.btnNewDirect.Location = New System.Drawing.Point(215, 108)
        Me.btnNewDirect.Name = "btnNewDirect"
        Me.btnNewDirect.Size = New System.Drawing.Size(20, 20)
        Me.btnNewDirect.TabIndex = 76
        Me.btnNewDirect.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(15, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 22)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "DIRECT MESSAGES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnFriends
        '
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
        Me.txtFindFriends.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFindFriends.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtFindFriends.BorderSize = 1
        Me.txtFindFriends.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFindFriends.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtFindFriends.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFindFriends.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFindFriends.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFindFriends.ForeColor = System.Drawing.Color.Silver
        Me.txtFindFriends.Location = New System.Drawing.Point(15, 10)
        Me.txtFindFriends.Name = "txtFindFriends"
        Me.txtFindFriends.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFindFriends.Radius = 7
        Me.txtFindFriends.SelectedText = ""
        Me.txtFindFriends.Size = New System.Drawing.Size(230, 30)
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
        'btnHide
        '
        Me.btnHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
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
        Me.btnMaxSizeForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
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
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.LogoName)
        Me.Controls.Add(Me.btnMaxSizeForm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TopPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.LeftButtomPanel.ResumeLayout(False)
        CType(Me.UserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PlayGroundPanel.ResumeLayout(False)
        Me.MainChatAndFriendPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.picFriend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMsgFriends.ResumeLayout(False)
        Me.PanelListOfFriends.ResumeLayout(False)
        Me.pnlFriend.ResumeLayout(False)
        CType(Me.btnDeleteMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FriendsPicture, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtFindFriends As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents FriendsPicture As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFriends As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnNewDirect As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFriends As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents picFriend As PictureBox
    Friend WithEvents btnMyAccount As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents pnlFriend As Panel
    Friend WithEvents btnDeleteMessages As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents MainChatAndFriendPanel As Panel
    Friend WithEvents lblFriendName As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents lblFriendOnline As PowerPacks.OvalShape
    Friend WithEvents FriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents PanelListOfFriends As Guna.UI.WinForms.GunaPanel
End Class
