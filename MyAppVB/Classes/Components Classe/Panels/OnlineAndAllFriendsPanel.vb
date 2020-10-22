Imports Guna.UI.WinForms

Public Class OnlineAndAllFriendsPanel
    Inherits GenericPanel

    'Private _Subject As Subject
    'Private _SubjFriend As Subject
    Private _MenuMoreForm As New MenuMoreForm
    'Private _RightClickMenuForm As New RightClickMenuForm

    '*****///// CONSTRUCTOR OF PANELS
    '*****///// ONLINE FRIENDS PANEL
    Sub New(ByRef oForm As OnlineFriendsForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, userStateOnline As String, user_id As Integer, ByRef mform As HomeForm)

        _PanelName = "Online Friends Panel"
        _Friend_ID = user_id
        _MainForm = mform
        _UserName = userName
        _OnlineFriendsForm = oForm
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _UserStateOnlineStr = userStateOnline
        _ScrollBarOfUserChat = friendScrollBar

        _Subject = _OnlineFriendsForm._Subject

        Create_FriendsPanelOnline()
    End Sub

    '*****///// ALL FRIENDS PANEL
    Sub New(ByRef allFForm As AllFriendsForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, userStateOnline As String, user_id As Integer, ByRef mform As HomeForm)

        _PanelName = "All Friends Panel"
        _Friend_ID = user_id
        _MainForm = mform
        _UserName = userName
        _AllFriendsForm = allFForm
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _UserStateOnlineStr = userStateOnline
        _ScrollBarOfUserChat = friendScrollBar

        _Subject = _AllFriendsForm._Subject

        Create_FriendsPanelOnline()
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_FriendsPanelOnline()
        _SubjFriend = Subject.Get_Subject_Data_By(_UserName)

        Create_UserName()
        Create_MenuButton()
        Create_Line(865, 1)
        Create_Panel(865, 62)
        Create_OnlineButton()
        Create_UserPictureBox()
        Create_SendMessageButton()
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
        _UserNameLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        AddHandler _MenuBtn.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserLine.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserPanel.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _OvalOnline.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _SendMessageBtn.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter
        AddHandler _UserStateOnline_Label.MouseEnter, AddressOf On_FriendsOnlineAndAllPanel_Enter

        '*****///// ON MOUSE CLICK HOVER THE PANEL EVENT
        AddHandler _UserLine.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserPanel.MouseClick, AddressOf On_Panel_Click
        AddHandler _OvalOnline.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserNameLbl.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserPictureBox.MouseClick, AddressOf On_Panel_Click
        AddHandler _SendMessageBtn.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserStateOnline_Label.MouseClick, AddressOf On_Panel_Click


        AddHandler _MenuBtn.MouseClick, AddressOf On_MenuButton_Click

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

    Public Sub On_Panel_Click(sender As System.Object, e As MouseEventArgs)

        Select Case e.Button
            Case MouseButtons.Left

                Dim chatform As New ChatFriendForm(_Subject, _MainForm, _SubjFriend, _UserName, _UserStateOnlineStr)

                _MainForm._FriendID = _Friend_ID

                _MainForm.txtFindFriends_Leave(sender, e)

                _ControlChildForm.OpenChildForm(chatform, _MainForm.MainChatAndFriendPanel, _MainForm._CurrentChildForm)

            Case MouseButtons.Right

                On_RightButtonMenu_Click()
        End Select
    End Sub

    '*****///// ON PANEL MOUSE HOVER EVENT
    Private Sub On_FriendsOnlineAndAllPanel_Enter(sender As Object, e As EventArgs)

        If Not _MainForm._ChatPnltoUnSelect Is Nothing Then
            _MainForm._ChatPnltoUnSelect.Leave_ListOfPanels()
            _MainForm._ChatPnltoUnSelect = Nothing
        End If

        _MainForm._OnlAllFPnltoUnSelect = Me
        Check_PopUp_MenuForms()

        If Application.OpenForms().OfType(Of OnlineFriendsForm).Any Then
            Leave_AllOther_Panels(_OnlineFriendsForm._ListOfUserFriendsOnline)

        ElseIf Application.OpenForms().OfType(Of AllFriendsForm).Any Then
            Leave_AllOther_Panels(_AllFriendsForm._ListOfUserFriendsAllPanel)
        End If

        _PnlSelected = True
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _UserLine.Visible = False

        UnderLine_SelectedUser(False)

        _SendMessageBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
        _MenuBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
    End Sub

    Private Sub Leave_AllOther_Panels(_ListOfUserFriendsOnline As List(Of OnlineAndAllFriendsPanel))
        For Each thisPanel In _ListOfUserFriendsOnline
            If thisPanel._Friend_ID <> _Friend_ID Then thisPanel.Leave_ListOfPanels()
        Next
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Public Sub On_FriendsOnlineAndAllPanel_Leave(sender As Object, e As EventArgs)

        If Application.OpenForms().OfType(Of OnlineFriendsForm).Any Then
            If Not _OnlineFriendsForm.pnlFriendsOnlineNow.GetChildAtPoint(_OnlineFriendsForm.pnlFriendsOnlineNow.PointToClient(Cursor.Position)) Is _UserPanel OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then
                Leave_ListOfPanels()
            End If
        ElseIf Application.OpenForms().OfType(Of AllFriendsForm).Any Then
            If Not _AllFriendsForm.AllFriendsPanel.GetChildAtPoint(_AllFriendsForm.AllFriendsPanel.PointToClient(Cursor.Position)) Is _UserPanel OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then
                Leave_ListOfPanels()
            End If
        End If

        Check_PopUp_MenuForms()
    End Sub

    Public Sub Leave_ListOfPanels()
        _PnlSelected = False
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserLine.Visible = True

        UnderLine_SelectedUser(True)

        _SendMessageBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _MenuBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// UNDER LINE USER PANEL
    Private Sub UnderLine_SelectedUser(state As Boolean)

        If Application.OpenForms().OfType(Of OnlineFriendsForm).Any Then
            Dim index As Integer = _OnlineFriendsForm._ListOfUserFriendsOnline.IndexOf(Me)

            If index > 0 Then
                _OnlineFriendsForm._ListOfUserFriendsOnline.Item(index - 1)._UserLine.Visible = state
            Else
                _OnlineFriendsForm.pnlUnderTextOnlineFriends.Visible = state
            End If

        ElseIf Application.OpenForms().OfType(Of AllFriendsForm).Any Then
            Dim index As Integer = _AllFriendsForm._ListOfUserFriendsAllPanel.IndexOf(Me)
            If index > 0 Then
                _AllFriendsForm._ListOfUserFriendsAllPanel.Item(index - 1)._UserLine.Visible = state
            Else
                _AllFriendsForm.pnlUnderlblAllFriends.Visible = state
            End If
        End If
    End Sub

    Private Sub On_MenuButton_Click()
        _MainForm._FriendID = _Friend_ID

        Dim _LocX = 360 + _UserPanel.Location.X + _MenuBtn.Location.X - _MenuMoreForm.Width
        Dim _LocY = 115 + _UserPanel.Location.Y + _UserPanel.Height / 2

        Open_Menu(_LocX, _LocY)
    End Sub

    Public Sub Open_Menu(Optional x As Integer = 0, Optional y As Integer = 0)

        If Not Application.OpenForms().OfType(Of MenuMoreForm).Any Then
            _MenuMoreForm = New MenuMoreForm(_Subject, _SubjFriend, _MainForm)
            _MainForm._MenuMoreForm = _MenuMoreForm

            _MenuMoreForm.TopLevel = False
            _MenuMoreForm.Parent = _MainForm

            _MenuMoreForm.SetBounds(x, y, 196, 116)
            _MenuMoreForm.BringToFront()
            _MenuMoreForm.Show()
        End If
    End Sub

End Class
