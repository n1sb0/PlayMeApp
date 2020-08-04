Imports System
Imports System.Windows.Forms
Imports Guna.UI.WinForms
Imports FontAwesome.Sharp
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Object
Imports System.EventArgs

Public Class FriendsChatPanel
    Inherits GenericPanel

    Sub New(ByRef mainForm As MainForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String, userPicture As Byte(), userName As String, userStateOnline As String)
        _MainForm = mainForm
        _UserName = userName
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar
        _UserStateOnlineStr = userStateOnline

        Create_FriendsPanel()
    End Sub

    Private Sub Create_FriendsPanel()
        Create_Panel(260, 60)
        Create_UserName()
        Create_OnlineButton()
        Create_UserPictureBox()
        Create_DeleteDirectButton()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    Public Sub AddEventRef()
        AddHandler _UserPanel.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _OvalOnline.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_FriendsPanel_Hover

        AddHandler _UserPanel.Click, AddressOf On_MouseClickFriendList
        AddHandler _UserNameLbl.Click, AddressOf On_MouseClickFriendList
        AddHandler _OvalOnline.Click, AddressOf On_MouseClickFriendList
        AddHandler _UserPictureBox.Click, AddressOf On_MouseClickFriendList


        AddHandler _UserPanel.MouseLeave, AddressOf On_FriendsPanel_Leave
        AddHandler _ScrollBarOfUserChat.MouseEnter, AddressOf On_ScrollBar_Hover
        AddHandler _DeleteChatWithUserBtn.Click, AddressOf btnDeleteMessages_Click
    End Sub

    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnline" + _NumberOfPanel
        _DeleteChatWithUserBtn.Name = "pnlBtn" + _NumberOfPanel
    End Sub

    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_DeleteChatWithUserBtn)
    End Sub

    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 20)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationOfDeleteButton As Point = New Point(215, 21)

        _UserPanel.Location = _LocationOfPanel
        _UserNameLbl.Location = locationOfUserName
        _UserPictureBox.Location = locationOfPicture
        _OvalOnline.Location = locationOnlineLabel
        _DeleteChatWithUserBtn.Location = locationOfDeleteButton
    End Sub

    Private Sub On_FriendsPanel_Hover(sender As Object, e As EventArgs)
        _DeleteChatWithUserBtn.Visible = True
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserNameLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    Private Sub On_FriendsPanel_Leave(sender As Object, e As EventArgs)
        If _MainForm.PanelListOfFriends.GetChildAtPoint(_MainForm.PanelListOfFriends.PointToClient(Cursor.Position)) Is _MainForm.FriendScrollBar OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then
            Leave_ListOfFriend()
        End If
    End Sub

    Private Sub On_ScrollBar_Hover()
        Leave_ListOfFriend()
    End Sub

    Public Sub Leave_ListOfFriend()
        _DeleteChatWithUserBtn.Visible = False

        _UserNameLbl.ForeColor = Color.Gray
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Private Sub On_MouseClickFriendList(sender As System.Object, e As System.EventArgs)
        Dim chatform As New ChatFriendForm

        _MainForm._OpenedChat = _NumberOfPanel

        _MainForm.txtFindFriends_Leave(sender, e)

        chatform._MsgToUser = _UserName
        chatform._StateOnline = _UserStateOnlineStr

        Dim positionOflblOnline As New Point(chatform.lblFriendName.Location.X + chatform.lblFriendName.Width + 5, chatform.lblStateOnlineOfFriend.Location.Y)

        chatform.lblStateOnlineOfFriend.Location = New Point(positionOflblOnline)

        _MainForm.pnlOnlineUsers.Visible = False

        _ControlChildForm.OpenChildForm(chatform, _MainForm.MainChatAndFriendPanel, _MainForm.currentChildForm)
    End Sub

    Private Sub btnDeleteMessages_Click(sender As Object, e As EventArgs)

        Dim btn = DirectCast(sender, IconPictureBox)

        Dim s As String = btn.Name.Substring(btn.Name.IndexOf("Btn") + 3)

        Dim index = _MainForm._ListOfUserFriendsPanel.FindIndex(Function(panel) panel._UserPanel.Name = "pnl" + s)

        _MainForm.PanelListOfFriends.Controls.Remove(_UserPanel)
        _MainForm._ListOfUserFriendsPanel.RemoveAt(index)

        On_DirectWasDeleted(index)

        If MainForm._OpenedChat = _NumberOfPanel Then
            If _MainForm.currentChildForm IsNot Nothing Then
                _MainForm.currentChildForm.Close()
            End If
        End If
    End Sub

    Private Sub On_DirectWasDeleted(index As Integer)
        For i As Integer = index To _MainForm._ListOfUserFriendsPanel.Count - 1
            _MainForm._ListOfUserFriendsPanel.Item(i)._UserPanel.Location = New Point(0, _MainForm._ListOfUserFriendsPanel.Item(i)._UserPanel.Location.Y - 60)
        Next
    End Sub

End Class