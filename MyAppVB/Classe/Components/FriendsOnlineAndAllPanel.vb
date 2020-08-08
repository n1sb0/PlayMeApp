Imports Guna.UI.WinForms

Public Class FriendsOnlineAndAllPanel
    Inherits GenericPanel

    '*****///// CONSTRUCTOR OF PANELS

    '*****///// ONLINE FRIENDS PANEL
    Sub New(ByRef oForm As OnlineFriendsForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String, userPicture As Byte(), userName As String, userStateOnline As String)
        _UserName = userName
        _OnlineFriendsForm = oForm
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _UserStateOnlineStr = userStateOnline
        _ScrollBarOfUserChat = friendScrollBar

        Create_FriendsPanelOnline()
    End Sub

    '*****///// ALL FRIENDS PANEL
    Sub New(ByRef allFForm As AllFriendsForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String, userPicture As Byte(), userName As String, userStateOnline As String)
        _UserName = userName
        _AllFriendsForm = allFForm
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _UserStateOnlineStr = userStateOnline
        _ScrollBarOfUserChat = friendScrollBar

        Create_FriendsPanelOnline()
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_FriendsPanelOnline()
        Create_UserName()
        Create_MenuButton()
        Create_Line(865, 1)
        Create_Panel(865, 62)
        Create_OnlineButton()
        Create_UserPictureBox()
        Create_SendMessageButton()
        Create_RadiusBackGround_Left()
        Create_UserStateOnline_Label()
        Create_RadiusBackGround_Right()

        UpdateComponents()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    '*****///// CHANGE SOMETHING INSIDE A PANEL
    Private Sub UpdateComponents()
        _UserPanel.Anchor = AnchorStyles.Right Or AnchorStyles.Left Or AnchorStyles.Top
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserNameLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        AddHandler _MenuBtn.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserPanel.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _OvalOnline.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _SendMessageBtn.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserStateOnline_Label.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _LeftRadiusBorderOfPanel.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _RightRadiusBorderOfPanel.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter

        '*****///// ON MOUSE LEAVE THE PANEL
        AddHandler _UserPanel.MouseLeave, AddressOf On_FriendsOnlineAndAllPanel_Leave
    End Sub

    '*****///// SET NAME OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserLine.Name = "pnlLine" + _NumberOfPanel
        _MenuBtn.Name = "pnlMenubtn" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnlineOval" + _NumberOfPanel
        _SendMessageBtn.Name = "pnlMsgbtn" + _NumberOfPanel
        _UserStateOnline_Label.Name = "pnlOnlineLbl" + _NumberOfPanel
        _LeftRadiusBorderOfPanel.Name = "pnlBackLeft" + _NumberOfPanel
        _RightRadiusBorderOfPanel.Name = "pnlBackRight" + _NumberOfPanel
    End Sub

    '*****///// SET LOCATION OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Location()
        Dim locationUserLine As Point = New Point(0, 61)
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationMenuBtn As Point = New Point(820, 12)
        Dim locationOfUserName As Point = New Point(55, 15)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationMessageBtn As Point = New Point(775, 12)
        Dim locationUserStateOnlineLabel As Point = New Point(55, 35)

        _MenuBtn.Location = locationMenuBtn
        _UserLine.Location = locationUserLine
        _UserPanel.Location = _LocationOfPanel
        _OvalOnline.Location = locationOnlineLabel
        _UserNameLbl.Location = locationOfUserName
        _UserPictureBox.Location = locationOfPicture
        _SendMessageBtn.Location = locationMessageBtn
        _UserStateOnline_Label.Location = locationUserStateOnlineLabel
    End Sub

    '*****///// ADD ALL ELEMENTS ON THE PANEL
    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_MenuBtn)
        _UserPanel.Controls.Add(_UserLine)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_SendMessageBtn)
        _UserPanel.Controls.Add(_UserStateOnline_Label)
    End Sub

    '*****///// ON PANEL MOUSE HOVER EVENT
    Private Sub On_FriendsOnlineAndAllPanel_Enter()
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _UserLine.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))

        UnderLine_SelectedUser(_PanelsColorLightDarkBlue)

        BorderOfPanel_Visible(True)

        _SendMessageBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
        _MenuBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Private Sub On_FriendsOnlineAndAllPanel_Leave()
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserLine.BackColor = Color.Gray

        UnderLine_SelectedUser(Color.Gray.ToArgb)

        BorderOfPanel_Visible(False)

        _SendMessageBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _MenuBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// UNDER LINE USER PANEL
    Private Sub UnderLine_SelectedUser(ccolor As String)

        If Application.OpenForms().OfType(Of OnlineFriendsForm).Any Then
            Dim index As Integer = _OnlineFriendsForm._ListOfUserFriendsOnline.IndexOf(Me)
            If index > 0 Then
                _OnlineFriendsForm._ListOfUserFriendsOnline.Item(index - 1)._UserLine.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(ccolor))
            Else
                _OnlineFriendsForm.pnlUnderTextOnlineFriends.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(ccolor))
            End If
        ElseIf Application.OpenForms().OfType(Of AllFriendsForm).Any Then
            Dim index As Integer = _AllFriendsForm._ListOfUserFriendsAllPanel.IndexOf(Me)
            If index > 0 Then
                _AllFriendsForm._ListOfUserFriendsAllPanel.Item(index - 1)._UserLine.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(ccolor))
            Else
                _AllFriendsForm.pnlUnderlblAllFriends.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(ccolor))
            End If
        End If
    End Sub
End Class
