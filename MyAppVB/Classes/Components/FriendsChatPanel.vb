Imports Guna.UI.WinForms
Imports FontAwesome.Sharp

Public Class FriendsChatPanel
    Inherits GenericPanel

    Public _E As New System.EventArgs
    Public _Sender As New System.Object

    Sub New(ByRef mainForm As HomeForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, userStateOnline As String, user_id As Integer)

        _MainForm = mainForm
        _User_ID = user_id
        _UserName = userName
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar
        _UserStateOnlineStr = userStateOnline

        Create_ChatPanel()
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_ChatPanel()
        Create_UserName()
        Create_Panel(260, 60)
        Create_OnlineButton()
        Create_UserPictureBox()
        Create_DeleteDirectButton()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        AddHandler _UserPanel.MouseEnter, AddressOf On_ChatPanel_Enter
        AddHandler _OvalOnline.MouseEnter, AddressOf On_ChatPanel_Enter
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_ChatPanel_Enter
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_ChatPanel_Enter

        AddHandler _ScrollBarOfUserChat.MouseEnter, AddressOf On_ScrollBar_Enter

        '*****///// ON MOUSE CLICK EVENT
        AddHandler _UserPanel.Click, AddressOf On_ChatPanel_Click
        AddHandler _OvalOnline.Click, AddressOf On_ChatPanel_Click
        AddHandler _UserNameLbl.Click, AddressOf On_ChatPanel_Click
        AddHandler _UserPictureBox.Click, AddressOf On_ChatPanel_Click

        AddHandler _DeleteChatWithUserBtn.Click, AddressOf On_DeleteChatButton_Click

        '*****///// ON MOUSE LEAVE THE PANEL
        AddHandler _UserPanel.MouseLeave, AddressOf On_ChatPanel_Leave
    End Sub

    '*****///// SET NAME OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnline" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _DeleteChatWithUserBtn.Name = "pnlBtn" + _NumberOfPanel
    End Sub

    '*****///// SET LOCATION OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 20)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationOfDeleteButton As Point = New Point(215, 21)

        _UserPanel.Location = _LocationOfPanel
        _UserNameLbl.Location = locationOfUserName
        _OvalOnline.Location = locationOnlineLabel
        _UserPictureBox.Location = locationOfPicture
        _DeleteChatWithUserBtn.Location = locationOfDeleteButton
    End Sub

    '*****///// ADD ALL ELEMENTS ON THE PANEL
    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_DeleteChatWithUserBtn)
    End Sub

    '*****///// ON PANEL MOUSE HOVER EVENT
    Private Sub On_ChatPanel_Enter(sender As Object, e As EventArgs)
        _DeleteChatWithUserBtn.Visible = True
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserNameLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Private Sub On_ChatPanel_Leave(sender As Object, e As EventArgs)
        If _MainForm.PanelListOfChatFriends.GetChildAtPoint(_MainForm.PanelListOfChatFriends.PointToClient(Cursor.Position)) Is _MainForm.FriendsChatScrollBar OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then
            Leave_ListOfChatPanels()
        End If
    End Sub

    '*****///// ON SCROLLBAR MOUSE HOVER
    Private Sub On_ScrollBar_Enter()
        Leave_ListOfChatPanels()
    End Sub

    '*****///// ON LEAVE LIST OF PANELS
    Public Sub Leave_ListOfChatPanels()
        _DeleteChatWithUserBtn.Visible = False

        _UserNameLbl.ForeColor = Color.Gray
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// ON CHAT PANEL MOUSE CLICK EVENT
    Public Sub On_ChatPanel_Click(sender As System.Object, e As System.EventArgs)
        _Sender = sender
        _E = e
        Dim chatform As New ChatFriendForm

        _MainForm._OpenedChat = _NumberOfPanel - 1

        _MainForm.txtFindFriends_Leave(sender, e)

        chatform._MsgToUser = _UserName
        chatform._StateOnline = _UserStateOnlineStr

        Dim positionOflblOnline As New Point(chatform.lblFriendName.Location.X + chatform.lblFriendName.Width + 5, chatform.lblStateOnlineOfFriend.Location.Y)

        chatform.lblStateOnlineOfFriend.Location = New Point(positionOflblOnline)

        _ControlChildForm.OpenChildForm(chatform, _MainForm.MainChatAndFriendPanel, _MainForm._CurrentChildForm)
    End Sub

    '*****///// ON DELETE CHAT BUTTON MOUSE CLICK EVENT
    Private Sub On_DeleteChatButton_Click(sender As Object, e As EventArgs)
        _MainForm.PanelListOfChatFriends.Controls.Remove(_UserPanel)

        Dim indexOfPanel As Integer = _MainForm._ListOfUserFriendsChatPanel.IndexOf(Me)

        _MainForm._ListOfUserFriendsChatPanel.RemoveAt(indexOfPanel)

        On_DirectWasDeleted(_NumberOfPanel - 1)

        If HomeForm._OpenedChat = _NumberOfPanel Then
            If _MainForm._CurrentChildForm IsNot Nothing Then
                _MainForm._CurrentChildForm.Close()
            End If
        End If
    End Sub

    '*****///// WHEN CHAT WAS DELETED TO RELOCATE ALL PANELS
    Private Sub On_DirectWasDeleted(index As Integer)
        For i As Integer = index To _MainForm._ListOfUserFriendsChatPanel.Count - 1
            _MainForm._ListOfUserFriendsChatPanel.Item(i)._UserPanel.Location = New Point(0, _MainForm._ListOfUserFriendsChatPanel.Item(i)._UserPanel.Location.Y - 60)
        Next
    End Sub
End Class