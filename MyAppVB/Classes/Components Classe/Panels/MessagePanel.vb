Imports Guna.UI.WinForms
Imports FontAwesome.Sharp

Public Class MessagePanel
    Inherits GenericPanel

    'Private _Subject As Subject
    'Private _SubjFriend As Subject
    Public _E As New System.EventArgs
    Public _Sender As New System.Object


    '*****///// CONSTRUCTOR OF PANELS
    Sub New(ByRef chatForm As ChatFriendForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, userStateOnline As String, user_id As Integer, msgText As String)

        _PanelName = "Message Panel"
        _ChatFirendForm = chatForm
        _MessageText = msgText
        _Friend_ID = user_id
        _UserName = userName
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar
        _UserStateOnlineStr = userStateOnline

        '_SubjFriend = Subject.Get_Subject_Data(_UserName)
        '_Subject = Subject.Get_Subject_Data(_ChatFirendForm.lblFriendName.Text)

        Create_ChatPanel()
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_ChatPanel()
        Create_UserName()
        Create_Panel(300, 60)
        Create_OnlineButton()
        Create_UserPictureBox()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        'AddHandler _UserPanel.MouseEnter, AddressOf On_ChatPanel_Enter
        'AddHandler _OvalOnline.MouseEnter, AddressOf On_ChatPanel_Enter
        'AddHandler _UserNameLbl.MouseEnter, AddressOf On_ChatPanel_Enter
        'AddHandler _UserPictureBox.MouseEnter, AddressOf On_ChatPanel_Enter

        'AddHandler _ScrollBarOfUserChat.MouseEnter, AddressOf On_ScrollBar_Enter

        ''*****///// ON MOUSE CLICK EVENT
        'AddHandler _UserPanel.Click, AddressOf On_ChatPanel_Click
        'AddHandler _OvalOnline.Click, AddressOf On_ChatPanel_Click
        'AddHandler _UserNameLbl.Click, AddressOf On_ChatPanel_Click
        'AddHandler _UserPictureBox.Click, AddressOf On_ChatPanel_Click

        '' AddHandler _DeleteChatWithUserBtn.Click, AddressOf On_DeleteChatButton_Click

        ''*****///// ON MOUSE LEAVE THE PANEL
        'AddHandler _UserPanel.MouseLeave, AddressOf On_ChatPanel_Leave
    End Sub

    '*****///// SET NAME OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnline" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
    End Sub

    '*****///// SET LOCATION OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 20)
        Dim locationOnlineLabel As Point = New Point(39, 37)

        _UserPanel.Location = _LocationOfPanel
        _UserNameLbl.Location = locationOfUserName
        _OvalOnline.Location = locationOnlineLabel
        _UserPictureBox.Location = locationOfPicture
    End Sub

    '*****///// ADD ALL ELEMENTS ON THE PANEL
    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
    End Sub

    '*****///// ON PANEL MOUSE HOVER EVENT
    Private Sub On_ChatPanel_Enter(sender As Object, e As EventArgs)
        _PnlSelected = True
        _DeleteChatWithUserBtn.Visible = True
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserNameLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Private Sub On_ChatPanel_Leave(sender As Object, e As EventArgs)
        If Not _MainForm.PanelListOfChatFriends.GetChildAtPoint(_MainForm.PanelListOfChatFriends.PointToClient(Cursor.Position)) Is _UserPanel _
           OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then

            Leave_ListOfChatPanels()
        End If
    End Sub

    '*****///// ON SCROLLBAR MOUSE HOVER
    Private Sub On_ScrollBar_Enter()
        Leave_ListOfChatPanels()
    End Sub

    '*****///// ON LEAVE LIST OF PANELS
    Public Sub Leave_ListOfChatPanels()
        _PnlSelected = False
        _DeleteChatWithUserBtn.Visible = False

        _UserNameLbl.ForeColor = Color.Gray
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// WHEN CHAT WAS DELETED TO RELOCATE ALL PANELS
    Private Sub On_DirectWasDeleted(index As Integer)
        For i As Integer = index To _MainForm._ListOfUserFriendsChatPanel.Count - 1
            _MainForm._ListOfUserFriendsChatPanel.Item(i)._UserPanel.Location = New Point(0, _MainForm._ListOfUserFriendsChatPanel.Item(i)._UserPanel.Location.Y - 60)
        Next
    End Sub
End Class
