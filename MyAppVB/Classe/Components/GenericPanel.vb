Imports System
Imports System.Windows.Forms
Imports Guna.UI.WinForms
Imports FontAwesome.Sharp
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Object
Imports System.EventArgs

Public Class GenericPanel

    Property _UserPanel As New Panel
    Property _UserLine As New Panel
    Property _UserNameLbl As New Label
    Property _UserStateOnline_Label As New Label
    Property Ctr As ShapeContainer = New ShapeContainer()
    Property _UserPictureBox As New GunaCirclePictureBox
    Property _DeleteChatWithUserBtn As New IconPictureBox
    Property _OvalOnline As OvalShape = New OvalShape(Ctr)
    Property _SendMessageBtn As New GunaButton
    Property _MenuBtn As New GunaButton


    Public _LocationOfPanel As New Point

    Public _Utility_Style As New Utility_Style
    Public _ScrollBarOfUserChat As GunaVScrollBar
    Public _ControlChildForm As New ControlChildForm

    Public _UserName As String
    Public _UserPicture As Byte()
    Public _UserStateOnlineStr As String

    Public _NumberOfPanel As String
    Public _MainForm As MainForm

    Public _GrayColor As String = _Utility_Style.GrayColor
    Public _BackGColor As String = _Utility_Style.BackGroundColor
    Public _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue

    Public Sub Create_Panel(width As Integer, hight As Integer)

        Dim size As Size = New Size(width, hight)

        _UserPanel.Size = size
        _UserPanel.Cursor = Cursors.Hand
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Public Sub Create_Line(width As Integer, hight As Integer)

        Dim size As Size = New Size(width, hight)

        _UserLine.Size = size
        _UserLine.Cursor = Cursors.Hand
        _UserLine.BackColor = Color.Gray
        _UserLine.Anchor = AnchorStyles.Right Or AnchorStyles.Left
    End Sub

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

    Public Sub Create_UserPictureBox()
        Dim width = 40, hight = 40

        Dim size As Size = New Size(width, hight)

        _Utility_Style.Set_UserPicture(_UserPictureBox, _UserPicture)
        _UserPictureBox.Size = size
        _UserPictureBox.Cursor = Cursors.Hand
        _UserPictureBox.BackColor = Color.Transparent
    End Sub

    Public Sub Create_UserName()
        'Dim width = 150, hight = 20

        'Dim size As Size = New Size(width, hight)

        '_FriendsUserName.Size = size

        _UserNameLbl.AutoSize = True
        _UserNameLbl.Text = _UserName
        _UserNameLbl.Cursor = Cursors.Hand
        _UserNameLbl.ForeColor = Color.Gray
        _UserNameLbl.BackColor = Color.Transparent
        _UserNameLbl.Font = New Font("Microsoft YaHei", 9.75, FontStyle.Bold)
    End Sub

    Public Sub Create_UserStateOnline_Label()
        _UserStateOnline_Label.AutoSize = True
        _UserStateOnline_Label.Text = _UserStateOnlineStr
        _UserStateOnline_Label.Cursor = Cursors.Hand
        _UserStateOnline_Label.ForeColor = Color.Gray
        _UserStateOnline_Label.BackColor = Color.Transparent
        _UserStateOnline_Label.Font = New Font("Microsoft YaHei", 8, FontStyle.Bold)
    End Sub

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

    Public Sub Create_SendMessageButton()
        Default_Button_Settings(_SendMessageBtn)
        _SendMessageBtn.Image = My.Resources.chatToFriendx1

        _SendMessageBtn.ImageSize = New Size(22, 22)

    End Sub

    Public Sub Create_MenuButton()
        Default_Button_Settings(_MenuBtn)
        _MenuBtn.Image = My.Resources.VerticleMenuDots

        _MenuBtn.ImageSize = New Size(25, 25)

    End Sub

    Private Sub Default_Button_Settings(btn As GunaButton)
        btn.Size = New Size(35, 35)
        btn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        btn.Radius = 14
        btn.ImageAlign = HorizontalAlignment.Center
        btn.Anchor = AnchorStyles.Right
    End Sub

End Class
