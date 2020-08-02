﻿Imports System
Imports System.Windows.Forms
Imports Guna.UI.WinForms
Imports FontAwesome.Sharp
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Object
Imports System.EventArgs

Public Class FriendsPanel
    Inherits GenericPanel

    Private _LocationOfPanel As New Point

    Property _FriendsPanel As New Panel
    Property _FriendsUserName As New Label
    Private Ctr As ShapeContainer = New ShapeContainer()
    Property _LblFriendsOnline As OvalShape = New OvalShape(Ctr)
    Property _FriendsPictureBox As New GunaCirclePictureBox
    Property _BtnDeleteChatWithFriend As New IconPictureBox

    Private _Utility_Style As New Utility_Style
    Private _ControlChildForm As New ControlChildForm
    Private _FriendScrollBar As GunaVScrollBar

    Private _UserName As String
    Private _UserPicture As Byte()
    Private _UserStateOnline As String

    Private _PnlNumber As String
    Private _MainForm As MainForm

    Private _GrayColor As String = _Utility_Style.GrayColor
    Private _BackGColor As String = _Utility_Style.BackGroundColor
    Private _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue

    Sub New(ByRef mainForm As MainForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String, userPicture As Byte(), userName As String, userStateOnline As String)
        _MainForm = mainForm
        _UserName = userName
        _PnlNumber = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _FriendScrollBar = friendScrollBar
        _UserStateOnline = userStateOnline

        Create_FriendsPanel()
    End Sub

    Private Sub Create_FriendsPanel()
        Create_Panel(_FriendsPanel, 260, 60)
        Create_UserName(_FriendsUserName, _UserName)
        Create_OnlineButton(_LblFriendsOnline, _UserStateOnline)
        Create_UserPictureBox(_FriendsPictureBox, _UserPicture)
        Create_DeleteDirectButton(_BtnDeleteChatWithFriend)

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    Public Sub AddEventRef()
        AddHandler _FriendsPanel.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _FriendsUserName.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _LblFriendsOnline.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _FriendsPictureBox.MouseEnter, AddressOf On_FriendsPanel_Hover

        AddHandler _FriendsPanel.Click, AddressOf On_MouseClickFriendList
        AddHandler _FriendsUserName.Click, AddressOf On_MouseClickFriendList
        AddHandler _LblFriendsOnline.Click, AddressOf On_MouseClickFriendList
        AddHandler _FriendsPictureBox.Click, AddressOf On_MouseClickFriendList


        AddHandler _FriendsPanel.MouseLeave, AddressOf On_FriendsPanel_Leave
        AddHandler _FriendScrollBar.MouseEnter, AddressOf On_ScrollBar_Hover
        AddHandler _BtnDeleteChatWithFriend.Click, AddressOf btnDeleteMessages_Click
    End Sub

    Private Sub Set_Name()
        _FriendsPanel.Name = "pnl" + _PnlNumber
        _FriendsUserName.Name = "pnlName" + _PnlNumber
        _FriendsPictureBox.Name = "pnlPic" + _PnlNumber
        _LblFriendsOnline.Name = "pnlOnline" + _PnlNumber
        _BtnDeleteChatWithFriend.Name = "pnlBtn" + _PnlNumber
    End Sub

    Private Sub AddComponents()
        _FriendsPanel.Controls.Add(Ctr)
        _FriendsPanel.Controls.Add(_FriendsUserName)
        _FriendsPanel.Controls.Add(_FriendsPictureBox)
        _FriendsPanel.Controls.Add(_BtnDeleteChatWithFriend)
    End Sub

    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 20)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationOfDeleteButton As Point = New Point(215, 21)

        _FriendsPanel.Location = _LocationOfPanel
        _FriendsUserName.Location = locationOfUserName
        _FriendsPictureBox.Location = locationOfPicture
        _LblFriendsOnline.Location = locationOnlineLabel
        _BtnDeleteChatWithFriend.Location = locationOfDeleteButton
    End Sub

    Private Sub On_FriendsPanel_Hover(sender As Object, e As EventArgs)
        _BtnDeleteChatWithFriend.Visible = True
        _FriendsPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _FriendsUserName.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    Private Sub On_FriendsPanel_Leave(sender As Object, e As EventArgs)
        If _MainForm.PanelListOfFriends.GetChildAtPoint(_MainForm.PanelListOfFriends.PointToClient(Cursor.Position)) Is _MainForm.FriendScrollBar OrElse _FriendsPanel.GetChildAtPoint(_FriendsPanel.PointToClient(Cursor.Position)) Is Nothing Then
            Leave_ListOfFriend()
        End If
    End Sub

    Private Sub On_ScrollBar_Hover()
        Leave_ListOfFriend()
    End Sub

    Public Sub Leave_ListOfFriend()
        _BtnDeleteChatWithFriend.Visible = False

        _FriendsUserName.ForeColor = Color.Gray
        _FriendsPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Private Sub On_MouseClickFriendList(sender As System.Object, e As System.EventArgs)
        Dim chatform As New ChatFriendForm

        _MainForm._OpenedChat = _PnlNumber

        _MainForm.txtFindFriends_Leave(sender, e)

        chatform._MsgToUser = _UserName
        chatform._StateOnline = _UserStateOnline

        Dim positionOflblOnline As New Point(chatform.lblFriendName.Location.X + chatform.lblFriendName.Width + 5, chatform.lblStateOnlineOfFriend.Location.Y)

        chatform.lblStateOnlineOfFriend.Location = New Point(positionOflblOnline)

        _ControlChildForm.OpenChildForm(chatform, _MainForm.MainChatAndFriendPanel, _MainForm.currentChildForm)
    End Sub

    Private Sub btnDeleteMessages_Click(sender As Object, e As EventArgs)

        Dim btn = DirectCast(sender, IconPictureBox)

        Dim s As String = btn.Name.Substring(btn.Name.IndexOf("Btn") + 3)

        Dim index = _MainForm._ListOfUserFriendsPanel.FindIndex(Function(panel) panel._FriendsPanel.Name = "pnl" + s)

        _MainForm.PanelListOfFriends.Controls.Remove(_FriendsPanel)
        _MainForm._ListOfUserFriendsPanel.RemoveAt(index)

        On_DirectWasDeleted(index)

        If MainForm._OpenedChat = _PnlNumber Then
            If _MainForm.currentChildForm IsNot Nothing Then
                _MainForm.currentChildForm.Close()
            End If
        End If
    End Sub

    Private Sub On_DirectWasDeleted(index As Integer)
        For i As Integer = index To _MainForm._ListOfUserFriendsPanel.Count - 1
            _MainForm._ListOfUserFriendsPanel.Item(i)._FriendsPanel.Location = New Point(0, _MainForm._ListOfUserFriendsPanel.Item(i)._FriendsPanel.Location.Y - 60)
        Next
    End Sub

End Class