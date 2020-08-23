Imports Guna.UI.WinForms
Public Class BlockedFriendsPanel
    Inherits GenericPanel

    Private _Friend As New Subject
    Sub New(ByRef bForm As BlockedFriendsForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, user_id As Integer)

        _PanelName = "Blocekd Friends Panel"
        _UserName = userName
        _User_ID = user_id
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _BlockedFriendsForm = bForm
        _UserStateOnlineStr = "Blocked"
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar

        Create_BlockedFriendPanel()
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_BlockedFriendPanel()
        Create_UserName()
        Create_Line(865, 1)
        Create_Panel(865, 62)
        Create_OnlineButton()
        Create_UnBlockButton()
        Create_UserPictureBox()
        Create_UserStateOnline_Label()
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
        _UnBlockBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        _UserStateOnline_Label.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        AddHandler _UserPanel.MouseEnter, AddressOf On_BlockedFriendPanel_Enter
        AddHandler _UnBlockBtn.MouseEnter, AddressOf On_BlockedFriendPanel_Enter
        AddHandler _OvalOnline.MouseEnter, AddressOf On_BlockedFriendPanel_Enter
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_BlockedFriendPanel_Enter
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_BlockedFriendPanel_Enter
        AddHandler _UserStateOnline_Label.MouseEnter, AddressOf On_BlockedFriendPanel_Enter

        '*****///// ON MOUSE LEAVE THE PANEL
        AddHandler _UserPanel.MouseLeave, AddressOf On_BlockedFriendPanel_Leave

        '*****///// ON UNBLOCK BUTTON CLICK EVENY
        AddHandler _UnBlockBtn.MouseClick, AddressOf On_UnBlockButton_Click
    End Sub

    '*****///// SET NAME OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserLine.Name = "pnlLine" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnlineOval" + _NumberOfPanel
        _UnBlockBtn.Name = "pnlUnBlockBtn" + _NumberOfPanel
        _UserStateOnline_Label.Name = "pnlOnlineLbl" + _NumberOfPanel
    End Sub

    '*****///// SET LOCATION OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Location()
        Dim locationUserLine As Point = New Point(0, 61)
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 15)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationOfUnBlockBtn As Point = New Point(820, 12)
        Dim locationUserStateOnlineLabel As Point = New Point(55, 35)

        _UserLine.Location = locationUserLine
        _UserPanel.Location = _LocationOfPanel
        _UserNameLbl.Location = locationOfUserName
        _OvalOnline.Location = locationOnlineLabel
        _UnBlockBtn.Location = locationOfUnBlockBtn
        _UserPictureBox.Location = locationOfPicture
        _UserStateOnline_Label.Location = locationUserStateOnlineLabel
    End Sub

    '*****///// ADD ALL ELEMENTS ON THE PANEL
    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserLine)
        _UserPanel.Controls.Add(_UnBlockBtn)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_UserStateOnline_Label)
    End Sub

    '*****///// ON UNBLOCK BUTTON CLICK
    Private Sub On_UnBlockButton_Click()
        _BlockedFriendsForm.BlockedFriendsPanel.Controls.Remove(_UserPanel)

        Dim indexOfPanel As Integer = _BlockedFriendsForm._ListOfUserBlockedFriendsPanel.IndexOf(Me)

        _BlockedFriendsForm._ListOfUserBlockedFriendsPanel.RemoveAt(indexOfPanel)

        On_UnBlockFriend(indexOfPanel)

        _Friend = Subject.Get_Subject_Data(_UserName)
        Dim strQuery As String = MyConnection.Get_UnBlock_Query

        Subject_Friends.Delete_Reference_OfTwoFriends(_BlockedFriendsForm._Subject.SUBJECT_ID, _Friend.SUBJECT_ID, strQuery)
    End Sub
    Private Sub On_UnBlockFriend(index As Integer)
        For i As Integer = index To  _BlockedFriendsForm._ListOfUserBlockedFriendsPanel.Count - 1
            _BlockedFriendsForm._ListOfUserBlockedFriendsPanel.Item(i)._UserPanel.Location = New Point(10, _BlockedFriendsForm._ListOfUserBlockedFriendsPanel.Item(i)._UserPanel.Location.Y - 61)
        Next
    End Sub

    '*****///// ON MOUSE HOVER EVENT
    Private Sub On_BlockedFriendPanel_Enter()
        _PnlSelected = True
        _UserLine.Visible = False
        _UnBlockBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))

        UnderLine_SelectedUser(False)

        _UnBlockBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Private Sub On_BlockedFriendPanel_Leave()
        If Not _BlockedFriendsForm.BlockedFriendsPanel.GetChildAtPoint(_BlockedFriendsForm.BlockedFriendsPanel.PointToClient(Cursor.Position)) Is _UserPanel OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then
            Leave_ListOfPanels()
        End If
    End Sub

    Private Sub Leave_ListOfPanels()
        _PnlSelected = False
        _UserLine.Visible = True
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))

        UnderLine_SelectedUser(True)

        _UnBlockBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// UNDERLINE SELECTED USER
    Private Sub UnderLine_SelectedUser(state As Boolean)
        Dim index As Integer = _BlockedFriendsForm._ListOfUserBlockedFriendsPanel.IndexOf(Me)

        If index > 0 Then
            _BlockedFriendsForm._ListOfUserBlockedFriendsPanel.Item(index - 1)._UserLine.Visible = state
        Else
            _BlockedFriendsForm.pnlUnderText.Visible = state
        End If
    End Sub
End Class
