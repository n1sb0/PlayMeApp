Imports Guna.UI.WinForms
Imports FontAwesome.Sharp

Public Class FriendsPanel
    Inherits GenericPanel

    Sub New(ByRef mainForm As MainForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String, userPicture As Byte(), userName As String, userStateOnline As String)
        _MainForm = mainForm
        _UserName = userName
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar
        _UserStateOnlineStr = userStateOnline

        Create_FriendsPanelOnline()
    End Sub

    Private Sub Create_FriendsPanelOnline()
        Create_Panel(900, 62)
        Create_UserName()
        Create_UserStateOnline_Label()
        Create_OnlineButton()
        Create_UserPictureBox()
        Create_SendMessageButton()
        Create_MenuButton()
        Create_Line(865, 1)

        UpdateComponents()

        'AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    Private Sub UpdateComponents()
        _UserPanel.Anchor = AnchorStyles.Right Or AnchorStyles.Left Or AnchorStyles.Top
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnlineOval" + _NumberOfPanel
        _UserStateOnline_Label.Name = "pnlOnlineLbl" + _NumberOfPanel
        _SendMessageBtn.Name = "pnlMsgbtn" + _NumberOfPanel
        _MenuBtn.Name = "pnlMenubtn" + _NumberOfPanel
        _UserLine.Name = "pnlLine" + _NumberOfPanel
    End Sub

    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 15)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationUserStateOnlineLabel As Point = New Point(55, 35)
        Dim locationMessageBtn As Point = New Point(790, 12)
        Dim locationMenuBtn As Point = New Point(840, 12)
        Dim locationUserLine As Point = New Point(10, 60)

        _UserPanel.Location = _LocationOfPanel
        _UserNameLbl.Location = locationOfUserName
        _UserPictureBox.Location = locationOfPicture
        _OvalOnline.Location = locationOnlineLabel
        _UserStateOnline_Label.Location = locationUserStateOnlineLabel
        _SendMessageBtn.Location = locationMessageBtn
        _MenuBtn.Location = locationMenuBtn
        _UserLine.Location = locationUserLine
    End Sub

    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_UserStateOnline_Label)
        _UserPanel.Controls.Add(_SendMessageBtn)
        _UserPanel.Controls.Add(_MenuBtn)
        _UserPanel.Controls.Add(_UserLine)
    End Sub
End Class
