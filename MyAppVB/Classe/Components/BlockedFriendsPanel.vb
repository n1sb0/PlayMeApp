Imports Guna.UI.WinForms
Public Class BlockedFriendsPanel
    Inherits GenericPanel

    Sub New(ByRef bForm As BlockedFriendsForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String, userPicture As Byte(), userName As String)
        _BlockedForm = bForm
        _UserName = userName
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar
        _UserStateOnlineStr = "Blocked"

        Create_FriendsPanelOnline()
    End Sub

    Private Sub Create_FriendsPanelOnline()
        Create_Panel(865, 62)
        Create_UserName()
        Create_RadiusBackGround_Left()
        Create_RadiusBackGround_Right()
        Create_UserStateOnline_Label()
        Create_OnlineButton()
        Create_UserPictureBox()
        Create_UnBlockButton()
        Create_Line(865, 1)

        UpdateComponents()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    Public Sub AddEventRef()
        AddHandler _UserPanel.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover
        AddHandler _OvalOnline.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover
        AddHandler _UserStateOnline_Label.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover
        AddHandler _BackGRadLeft.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover
        AddHandler _BackGRadRight.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover
        AddHandler _UnBlockBtn.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Hover


        AddHandler _UserPanel.MouseLeave, AddressOf On_FriendsOnlineAndAllPanel_Leave
    End Sub
    Private Sub UpdateComponents()
        _UserPanel.Anchor = AnchorStyles.Right Or AnchorStyles.Left Or AnchorStyles.Top
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserStateOnline_Label.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        _UnBlockBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
    End Sub

    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnlineOval" + _NumberOfPanel
        _UserStateOnline_Label.Name = "pnlOnlineLbl" + _NumberOfPanel
        _UnBlockBtn.Name = "pnlUnBlockBtn" + _NumberOfPanel
        _UserLine.Name = "pnlLine" + _NumberOfPanel
        _BackGRadLeft.Name = "pnlBackLeft" + _NumberOfPanel
        _BackGRadRight.Name = "pnlBackRight" + _NumberOfPanel
    End Sub

    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 15)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationUserStateOnlineLabel As Point = New Point(55, 35)
        Dim locationOfUnBlockBtn As Point = New Point(820, 12)
        Dim locationUserLine As Point = New Point(0, 61)

        _UserPanel.Location = _LocationOfPanel
        _UserNameLbl.Location = locationOfUserName
        _UserPictureBox.Location = locationOfPicture
        _OvalOnline.Location = locationOnlineLabel
        _UserStateOnline_Label.Location = locationUserStateOnlineLabel
        _UnBlockBtn.Location = locationOfUnBlockBtn
        _UserLine.Location = locationUserLine
    End Sub

    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_UserStateOnline_Label)
        _UserPanel.Controls.Add(_UnBlockBtn)
        _UserPanel.Controls.Add(_UserLine)
    End Sub

    Private Sub On_FriendsOnlineAndAllPanel_Hover()
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _UserLine.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _UnBlockBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))

        UnderLine_SelectedUser(_PanelsColorLightDarkBlue)

        BorderOfPanel_Visible(True)
        _UnBlockBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
    End Sub

    Private Sub On_FriendsOnlineAndAllPanel_Leave()
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserLine.BackColor = Color.Gray

        UnderLine_SelectedUser(Color.Gray.ToArgb)

        BorderOfPanel_Visible(False)
        _UnBlockBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Private Sub UnderLine_SelectedUser(ccolor As String)

        Dim index As Integer = _BlockedForm._ListOfUserBlockedFriendsPanel.IndexOf(Me)
        If index > 0 Then
            _BlockedForm._ListOfUserBlockedFriendsPanel.Item(index - 1)._UserLine.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(ccolor))
        Else
            _BlockedForm.pnlUnderText.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(ccolor))
        End If

    End Sub

End Class
