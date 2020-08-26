<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatFriendForm
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
        Me.lblFriendName = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblStateOnlineOfFriend = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.txtFindMessage = New Guna.UI.WinForms.GunaTextBox()
        Me.picFriend = New System.Windows.Forms.PictureBox()
        Me.UpperPanelLine = New System.Windows.Forms.Panel()
        Me.btnAddFriendToChat = New FontAwesome.Sharp.IconPictureBox()
        Me.btnCall = New FontAwesome.Sharp.IconPictureBox()
        Me.btnHelp = New FontAwesome.Sharp.IconPictureBox()
        Me.btnVideoCall = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSentMsg = New FontAwesome.Sharp.IconPictureBox()
        Me.lblTextMsg = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnAddSmile = New FontAwesome.Sharp.IconPictureBox()
        Me.btnAddFiles = New FontAwesome.Sharp.IconPictureBox()
        Me.MessagesPanel = New System.Windows.Forms.Panel()
        Me.pnlMessage = New Guna.UI.WinForms.GunaElipsePanel()
        CType(Me.picFriend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddFriendToChat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVideoCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSentMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddSmile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFriendName
        '
        Me.lblFriendName.AutoSize = True
        Me.lblFriendName.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.lblFriendName.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFriendName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblFriendName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFriendName.Location = New System.Drawing.Point(55, 15)
        Me.lblFriendName.Name = "lblFriendName"
        Me.lblFriendName.Size = New System.Drawing.Size(106, 19)
        Me.lblFriendName.TabIndex = 79
        Me.lblFriendName.Text = "Friend Name"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lblStateOnlineOfFriend})
        Me.ShapeContainer1.Size = New System.Drawing.Size(950, 700)
        Me.ShapeContainer1.TabIndex = 81
        Me.ShapeContainer1.TabStop = False
        '
        'lblStateOnlineOfFriend
        '
        Me.lblStateOnlineOfFriend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblStateOnlineOfFriend.BorderWidth = 3
        Me.lblStateOnlineOfFriend.FillColor = System.Drawing.Color.Gray
        Me.lblStateOnlineOfFriend.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.lblStateOnlineOfFriend.Location = New System.Drawing.Point(165, 19)
        Me.lblStateOnlineOfFriend.Name = "lblStateOnlineOfFriend"
        Me.lblStateOnlineOfFriend.SelectionColor = System.Drawing.Color.Transparent
        Me.lblStateOnlineOfFriend.Size = New System.Drawing.Size(13, 13)
        '
        'txtFindMessage
        '
        Me.txtFindMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFindMessage.BackColor = System.Drawing.Color.Transparent
        Me.txtFindMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtFindMessage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFindMessage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtFindMessage.BorderSize = 1
        Me.txtFindMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFindMessage.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtFindMessage.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFindMessage.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFindMessage.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFindMessage.ForeColor = System.Drawing.Color.Silver
        Me.txtFindMessage.Location = New System.Drawing.Point(770, 12)
        Me.txtFindMessage.Name = "txtFindMessage"
        Me.txtFindMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFindMessage.Radius = 7
        Me.txtFindMessage.SelectedText = ""
        Me.txtFindMessage.Size = New System.Drawing.Size(120, 30)
        Me.txtFindMessage.TabIndex = 85
        Me.txtFindMessage.Text = "Search"
        '
        'picFriend
        '
        Me.picFriend.Image = Global.PlayME.My.Resources.Resources.Person
        Me.picFriend.Location = New System.Drawing.Point(25, 12)
        Me.picFriend.Name = "picFriend"
        Me.picFriend.Size = New System.Drawing.Size(25, 25)
        Me.picFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFriend.TabIndex = 80
        Me.picFriend.TabStop = False
        '
        'UpperPanelLine
        '
        Me.UpperPanelLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpperPanelLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.UpperPanelLine.Location = New System.Drawing.Point(0, 50)
        Me.UpperPanelLine.Name = "UpperPanelLine"
        Me.UpperPanelLine.Size = New System.Drawing.Size(950, 2)
        Me.UpperPanelLine.TabIndex = 87
        '
        'btnAddFriendToChat
        '
        Me.btnAddFriendToChat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddFriendToChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAddFriendToChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFriendToChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddFriendToChat.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnAddFriendToChat.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddFriendToChat.IconSize = 30
        Me.btnAddFriendToChat.Location = New System.Drawing.Point(725, 12)
        Me.btnAddFriendToChat.Name = "btnAddFriendToChat"
        Me.btnAddFriendToChat.Size = New System.Drawing.Size(30, 30)
        Me.btnAddFriendToChat.TabIndex = 88
        Me.btnAddFriendToChat.TabStop = False
        '
        'btnCall
        '
        Me.btnCall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCall.IconChar = FontAwesome.Sharp.IconChar.Phone
        Me.btnCall.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCall.IconSize = 28
        Me.btnCall.Location = New System.Drawing.Point(645, 12)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Rotation = 90.0R
        Me.btnCall.Size = New System.Drawing.Size(30, 28)
        Me.btnCall.TabIndex = 89
        Me.btnCall.TabStop = False
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
        Me.btnHelp.TabIndex = 90
        Me.btnHelp.TabStop = False
        '
        'btnVideoCall
        '
        Me.btnVideoCall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVideoCall.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnVideoCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVideoCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnVideoCall.IconChar = FontAwesome.Sharp.IconChar.Video
        Me.btnVideoCall.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnVideoCall.IconSize = 30
        Me.btnVideoCall.Location = New System.Drawing.Point(685, 12)
        Me.btnVideoCall.Name = "btnVideoCall"
        Me.btnVideoCall.Size = New System.Drawing.Size(30, 30)
        Me.btnVideoCall.TabIndex = 91
        Me.btnVideoCall.TabStop = False
        '
        'btnSentMsg
        '
        Me.btnSentMsg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSentMsg.BackColor = System.Drawing.Color.Transparent
        Me.btnSentMsg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSentMsg.ForeColor = System.Drawing.Color.DimGray
        Me.btnSentMsg.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        Me.btnSentMsg.IconColor = System.Drawing.Color.DimGray
        Me.btnSentMsg.IconSize = 25
        Me.btnSentMsg.Location = New System.Drawing.Point(883, 10)
        Me.btnSentMsg.Name = "btnSentMsg"
        Me.btnSentMsg.Size = New System.Drawing.Size(25, 25)
        Me.btnSentMsg.TabIndex = 98
        Me.btnSentMsg.TabStop = False
        '
        'lblTextMsg
        '
        Me.lblTextMsg.AutoSize = True
        Me.lblTextMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblTextMsg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTextMsg.Enabled = False
        Me.lblTextMsg.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTextMsg.ForeColor = System.Drawing.Color.Gray
        Me.lblTextMsg.Location = New System.Drawing.Point(51, 11)
        Me.lblTextMsg.Name = "lblTextMsg"
        Me.lblTextMsg.Size = New System.Drawing.Size(145, 20)
        Me.lblTextMsg.TabIndex = 96
        Me.lblTextMsg.Text = "MESSAGE @NAME"
        '
        'txtMessage
        '
        Me.txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMessage.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtMessage.Location = New System.Drawing.Point(48, 11)
        Me.txtMessage.MaximumSize = New System.Drawing.Size(801, 500)
        Me.txtMessage.MinimumSize = New System.Drawing.Size(417, 25)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(801, 25)
        Me.txtMessage.TabIndex = 97
        '
        'btnAddSmile
        '
        Me.btnAddSmile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddSmile.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSmile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSmile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddSmile.IconChar = FontAwesome.Sharp.IconChar.SmileWink
        Me.btnAddSmile.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddSmile.IconSize = 25
        Me.btnAddSmile.Location = New System.Drawing.Point(851, 10)
        Me.btnAddSmile.Name = "btnAddSmile"
        Me.btnAddSmile.Size = New System.Drawing.Size(25, 25)
        Me.btnAddSmile.TabIndex = 24
        Me.btnAddSmile.TabStop = False
        '
        'btnAddFiles
        '
        Me.btnAddFiles.BackColor = System.Drawing.Color.Transparent
        Me.btnAddFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddFiles.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddFiles.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAddFiles.IconSize = 25
        Me.btnAddFiles.Location = New System.Drawing.Point(13, 10)
        Me.btnAddFiles.Name = "btnAddFiles"
        Me.btnAddFiles.Size = New System.Drawing.Size(25, 25)
        Me.btnAddFiles.TabIndex = 23
        Me.btnAddFiles.TabStop = False
        '
        'MessagesPanel
        '
        Me.MessagesPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessagesPanel.BackColor = System.Drawing.Color.DimGray
        Me.MessagesPanel.Location = New System.Drawing.Point(15, 50)
        Me.MessagesPanel.Name = "MessagesPanel"
        Me.MessagesPanel.Size = New System.Drawing.Size(920, 590)
        Me.MessagesPanel.TabIndex = 93
        '
        'pnlMessage
        '
        Me.pnlMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMessage.BackColor = System.Drawing.Color.Transparent
        Me.pnlMessage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlMessage.Controls.Add(Me.btnAddSmile)
        Me.pnlMessage.Controls.Add(Me.lblTextMsg)
        Me.pnlMessage.Controls.Add(Me.btnSentMsg)
        Me.pnlMessage.Controls.Add(Me.btnAddFiles)
        Me.pnlMessage.Controls.Add(Me.txtMessage)
        Me.pnlMessage.Location = New System.Drawing.Point(15, 640)
        Me.pnlMessage.Name = "pnlMessage"
        Me.pnlMessage.Radius = 13
        Me.pnlMessage.Size = New System.Drawing.Size(920, 40)
        Me.pnlMessage.TabIndex = 0
        '
        'ChatFriendForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 700)
        Me.Controls.Add(Me.pnlMessage)
        Me.Controls.Add(Me.btnVideoCall)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.btnAddFriendToChat)
        Me.Controls.Add(Me.UpperPanelLine)
        Me.Controls.Add(Me.txtFindMessage)
        Me.Controls.Add(Me.picFriend)
        Me.Controls.Add(Me.lblFriendName)
        Me.Controls.Add(Me.MessagesPanel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChatFriendForm"
        Me.Text = "UpperPanelFriendNameForm"
        CType(Me.picFriend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddFriendToChat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVideoCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSentMsg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddSmile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMessage.ResumeLayout(False)
        Me.pnlMessage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFriend As PictureBox
    Friend WithEvents lblFriendName As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents lblStateOnlineOfFriend As PowerPacks.OvalShape
    Friend WithEvents txtFindMessage As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents UpperPanelLine As Panel
    Friend WithEvents btnAddFriendToChat As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnCall As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnHelp As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnVideoCall As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnAddFiles As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnAddSmile As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblTextMsg As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSentMsg As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents MessagesPanel As Panel
    Friend WithEvents pnlMessage As Guna.UI.WinForms.GunaElipsePanel
End Class
