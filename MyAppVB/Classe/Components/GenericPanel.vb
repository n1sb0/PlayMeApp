Imports System
Imports System.Windows.Forms
Imports Guna.UI.WinForms
Imports FontAwesome.Sharp
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Object
Imports System.EventArgs

Public Class GenericPanel

    '*****///// COMPONENTS TO USE ON THE PANEL
    Property _UserLine As New Panel
    Property _UserPanel As New Panel
    Property _UserNameLbl As New Label
    Property _MenuBtn As New GunaButton
    Property _UnBlockBtn As New GunaButton
    Property _SendMessageBtn As New GunaButton
    Property _CheckBoxBtn As New IconPictureBox
    Property _UserStateOnline_Label As New Label
    Property _UserPictureBox As New GunaCirclePictureBox
    Property _DeleteChatWithUserBtn As New IconPictureBox
    Property Ctr As ShapeContainer = New ShapeContainer()
    Property _OvalOnline As OvalShape = New OvalShape(Ctr)

    Public _Utility_Style As New Utility_Style
    Public _ScrollBarOfUserChat As GunaVScrollBar
    Public _ControlChildForm As New ControlChildForm

    Public _UserName As String
    Public _UserPicture As Byte()
    Public _NumberOfPanel As String
    Public _UserStateOnlineStr As String
    Public _LocationOfPanel As New Point

    '*****///// FORMS ON WHICH WE ADD A PANEL
    Public _MainForm As MainForm
    Public _DmForm As CreateDMForm
    Public _AllFriendsForm As AllFriendsForm
    Public _OnlineFriendsForm As OnlineFriendsForm
    Public _BlockedFriendsForm As BlockedFriendsForm

    '*****///// COLORS
    Public _DarkBlue As String = _Utility_Style.DarkBlue
    Public _RedColor As String = _Utility_Style.RedColor
    Public _LightBlue As String = _Utility_Style.LightBlue
    Public _GrayColor As String = _Utility_Style.GrayColor
    Public _BackGColor As String = _Utility_Style.BackGroundColor
    Public _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue

    '*****///// CREATE A PANEL
    Public Sub Create_Panel(width As Integer, hight As Integer)

        Dim size As Size = New Size(width, hight)

        _UserPanel.BringToFront()
        _UserPanel.Size = size
        _UserPanel.Cursor = Cursors.Hand
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))

        If _MainForm Is Nothing Then
            AddHandler _UserPanel.Paint, AddressOf On_Panel_Paint
        End If

    End Sub

    Private Sub On_Panel_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.Clear(_UserPanel.Parent.BackColor)
        Dim control As Control = _UserPanel
        Dim radius As Integer = 30

        Using path As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
            path.AddLine(radius, 0, control.Width - radius, 0)
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90)
            path.AddLine(control.Width, radius, control.Width, control.Height - radius)
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90)
            path.AddLine(control.Width - radius, control.Height, radius, control.Height)
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90)
            path.AddLine(0, control.Height - radius, 0, radius)
            path.AddArc(0, 0, radius, radius, 180, 90)

            Using brush As SolidBrush = New SolidBrush(control.BackColor)
                e.Graphics.FillPath(brush, path)
            End Using
        End Using
    End Sub

    '*****///// CREATE UNDER LINE OF PANEL
    Public Sub Create_Line(width As Integer, hight As Integer)

        Dim size As Size = New Size(width, hight)

        _UserLine.Size = size
        _UserLine.Cursor = Cursors.Hand
        _UserLine.BackColor = Color.Gray
        _UserLine.Anchor = AnchorStyles.Right Or AnchorStyles.Left
    End Sub

    '*****///// CREATE ONLINE CIRCLE BUTTON
    Public Sub Create_OnlineButton()
        Dim width = 12
        Dim hight = width

        Dim size As Size = New Size(width, hight)

        _Utility_Style.Set_UserStateOnline(_OvalOnline, _UserStateOnlineStr)

        _OvalOnline.Size = size
        _OvalOnline.BorderWidth = 3
        _OvalOnline.Enabled = False
        _OvalOnline.Cursor = Cursors.Hand
        _OvalOnline.FillStyle = FillStyle.Solid
        _OvalOnline.BorderColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// CREATE USER PICTURE BOX 
    Public Sub Create_UserPictureBox()
        Dim width = 40, hight = 40

        Dim size As Size = New Size(width, hight)

        _Utility_Style.Set_UserPicture(_UserPictureBox, _UserPicture)
        _UserPictureBox.Size = size
        _UserPictureBox.Cursor = Cursors.Hand
        _UserPictureBox.BackColor = Color.Transparent
    End Sub

    '*****///// CREATE USER NAME LABEL
    Public Sub Create_UserName()
        _UserNameLbl.AutoSize = True
        _UserNameLbl.Text = _UserName
        _UserNameLbl.Cursor = Cursors.Hand
        _UserNameLbl.ForeColor = Color.Gray
        _UserNameLbl.BackColor = Color.Transparent
        _UserNameLbl.Font = New Font("Microsoft YaHei", 9.75, FontStyle.Bold)
    End Sub

    '*****///// CREATE USER STATE ONLINE LABEL UNDER THE NAME 
    Public Sub Create_UserStateOnline_Label()
        _UserStateOnline_Label.AutoSize = True
        _UserStateOnline_Label.Text = _UserStateOnlineStr
        _UserStateOnline_Label.Cursor = Cursors.Hand
        _UserStateOnline_Label.ForeColor = Color.Gray
        _UserStateOnline_Label.BackColor = Color.Transparent
        _UserStateOnline_Label.Font = New Font("Microsoft YaHei", 8, FontStyle.Bold)
    End Sub

    '*****///// CREATE DELETE CHAT WITH FRIEND
    Public Sub Create_DeleteDirectButton()
        Dim width = 20
        Dim hight = width

        Dim size As Size = New Size(width, hight)

        _DeleteChatWithUserBtn.Visible = False
        _DeleteChatWithUserBtn.Size = size
        _DeleteChatWithUserBtn.Cursor = Cursors.Hand
        _DeleteChatWithUserBtn.IconColor = Color.Silver
        _DeleteChatWithUserBtn.BackColor = Color.Transparent
        _DeleteChatWithUserBtn.IconChar = FontAwesome.Sharp.IconChar.Times
    End Sub

    '*****///// CREATE SEND MESSAGE TO FRIEND BUTTON
    Public Sub Create_SendMessageButton()
        Default_Button_Settings(_SendMessageBtn)
        _SendMessageBtn.Image = My.Resources.chatToFriendx1

        _SendMessageBtn.ImageSize = New Size(22, 22)
    End Sub

    '*****///// CREATE MENU BUTTON (START VIDEO CALL, START VOICE CALL, REMOVE FRIEND)
    Public Sub Create_MenuButton()
        Default_Button_Settings(_MenuBtn)
        _MenuBtn.Image = My.Resources.VerticleMenuDots

        _MenuBtn.ImageSize = New Size(25, 25)

    End Sub

    '*****///// CREATE UNBLOCK FRIEND BUTTON
    Public Sub Create_UnBlockButton()
        Default_Button_Settings(_UnBlockBtn)
        _UnBlockBtn.Image = My.Resources.BlockedUser

        _UnBlockBtn.ImageSize = New Size(25, 25)

    End Sub

    '*****///// SOME DEFAULT BUTTON SETTINGS
    Private Sub Default_Button_Settings(btn As GunaButton)
        btn.Size = New Size(35, 35)
        btn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        btn.Radius = 14
        btn.ImageAlign = HorizontalAlignment.Center
        btn.Anchor = AnchorStyles.Right
        btn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
    End Sub

    '*****///// DEFAULT SETTINGS FOR RADIUSE BORDER
    Private Sub Default_BackRadius_Settings(btn As GunaButton)
        btn.Size = New Size(62, 62)
        btn.Radius = 12
        btn.Visible = False
        btn.SendToBack()

        btn.Image = Nothing

        btn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        btn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        btn.OnPressedColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// CREATE CHECK BOX FOR ADD A FRIENDS TO GROUP CHAT
    Public Sub Create_CheckBox()
        _CheckBoxBtn.Size = New Size(30, 30)
        _CheckBoxBtn.IconChar = FontAwesome.Sharp.IconChar.Square
        _CheckBoxBtn.IconColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
        _CheckBoxBtn.BackColor = Color.Transparent
    End Sub
End Class


