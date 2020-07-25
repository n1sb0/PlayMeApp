Imports System
Imports System.Windows.Forms
Imports Guna.UI.WinForms
Imports FontAwesome.Sharp
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Object
Imports System.EventArgs

Public Class FriendsPanel
    Private _locationOfPanel As New Point

    Property _FriendsPanel As New Panel
    Property _FriendsUserName As New Label
    Private ctr As ShapeContainer = New ShapeContainer()
    Property _LblFriendsOnline As OvalShape = New OvalShape(ctr)
    Property _FriendsPictureBox As New GunaCirclePictureBox
    Property _BtnDeleteChatWithFriend As New IconPictureBox

    Private _Utility_Style As New Utility_Style
    Private _ControlChildForm As New ControlChildForm
    Private _friendScrollBar As GunaVScrollBar

    Private _enter As Boolean = False
    Private _pnlNumber As String
    Private _mainForm As MainForm

    Private _GrayColor As String = _Utility_Style.GrayColor
    Private _BackGColor As String = _Utility_Style.BackGroundColor
    Private _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue

    Public Function Get_FriendsPanel()
        Return _FriendsPanel
    End Function

    Sub New(ByRef mainForm As MainForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String)
        _mainForm = mainForm
        _locationOfPanel = locationOfPanel
        _friendScrollBar = friendScrollBar
        _pnlNumber = panelname

        Create_FriendsPanel()
    End Sub

    Private Sub Create_FriendsPanel()
        Create_Panel()
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
        AddHandler _FriendsPanel.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _FriendsUserName.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _LblFriendsOnline.MouseEnter, AddressOf On_FriendsPanel_Hover
        AddHandler _FriendsPictureBox.MouseEnter, AddressOf On_FriendsPanel_Hover

        AddHandler _FriendsPanel.Click, AddressOf On_MouseClickFriendList
        AddHandler _FriendsUserName.Click, AddressOf On_MouseClickFriendList
        AddHandler _LblFriendsOnline.Click, AddressOf On_MouseClickFriendList
        AddHandler _FriendsPictureBox.Click, AddressOf On_MouseClickFriendList


        AddHandler _FriendsPanel.MouseLeave, AddressOf On_FriendsPanel_Leave
        AddHandler _friendScrollBar.MouseEnter, AddressOf On_ScrollBar_Hover
        AddHandler _BtnDeleteChatWithFriend.Click, AddressOf btnDeleteMessages_Click
    End Sub

    Private Sub Set_Name()
        _FriendsPanel.Name = "pnl" + _pnlNumber
        _FriendsUserName.Name = "pnlName" + _pnlNumber
        _FriendsPictureBox.Name = "pnlPic" + _pnlNumber
        _LblFriendsOnline.Name = "pnlOnline" + _pnlNumber
        _BtnDeleteChatWithFriend.Name = "pnlBtn" + _pnlNumber
    End Sub

    Private Sub AddComponents()
        _FriendsPanel.Controls.Add(ctr)
        _FriendsPanel.Controls.Add(_FriendsUserName)
        _FriendsPanel.Controls.Add(_FriendsPictureBox)
        _FriendsPanel.Controls.Add(_BtnDeleteChatWithFriend)
    End Sub

    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationOfUserName As Point = New Point(55, 20)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationOfDeleteButton As Point = New Point(215, 21)

        _FriendsPanel.Location = _locationOfPanel
        _FriendsUserName.Location = locationOfUserName
        _FriendsPictureBox.Location = locationOfPicture
        _LblFriendsOnline.Location = locationOnlineLabel
        _BtnDeleteChatWithFriend.Location = locationOfDeleteButton
    End Sub

    Private Sub Create_Panel()
        Dim width = 260, hight = 60

        Dim size As Size = New Size(width, hight)

        _FriendsPanel.Size = size
        _FriendsPanel.Cursor = Cursors.Hand
        _FriendsPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Private Sub Create_OnlineButton()
        Dim width = 12
        Dim hight = width

        Dim size As Size = New Size(width, hight)

        _LblFriendsOnline.Size = size
        _LblFriendsOnline.BorderWidth = 3
        _LblFriendsOnline.Enabled = False
        _LblFriendsOnline.Cursor = Cursors.Hand
        _LblFriendsOnline.FillColor = Color.Gray
        _LblFriendsOnline.FillStyle = FillStyle.Solid
        _LblFriendsOnline.BorderColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Private Sub Create_UserPictureBox()
        Dim width = 40, hight = 40

        Dim size As Size = New Size(width, hight)

        _FriendsPictureBox.Size = size
        _FriendsPictureBox.Cursor = Cursors.Hand
        _FriendsPictureBox.BackColor = Color.Transparent
    End Sub

    Private Sub Create_UserName()
        Dim width = 150, hight = 20

        Dim size As Size = New Size(width, hight)

        _FriendsUserName.Size = size
        _FriendsUserName.Text = "Friend Name " + _pnlNumber
        _FriendsUserName.Cursor = Cursors.Hand
        _FriendsUserName.ForeColor = Color.Gray
        _FriendsUserName.BackColor = Color.Transparent
        _FriendsUserName.Font = New Font("Microsoft YaHei", 9.75, FontStyle.Bold)
    End Sub

    Private Sub Create_DeleteDirectButton()
        Dim width = 20
        Dim hight = width

        Dim size As Size = New Size(width, hight)

        _BtnDeleteChatWithFriend.Visible = False
        _BtnDeleteChatWithFriend.Size = size
        _BtnDeleteChatWithFriend.Cursor = Cursors.Hand
        _BtnDeleteChatWithFriend.IconColor = Color.Silver
        _BtnDeleteChatWithFriend.BackColor = Color.Transparent
        _BtnDeleteChatWithFriend.IconChar = FontAwesome.Sharp.IconChar.Times
    End Sub

    Private Sub On_FriendsPanel_Hover(sender As Object, e As EventArgs)
        _BtnDeleteChatWithFriend.Visible = True
        _FriendsPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _FriendsUserName.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    Private Sub On_FriendsPanel_Leave(sender As Object, e As EventArgs)
        If _mainForm.PanelListOfFriends.GetChildAtPoint(_mainForm.PanelListOfFriends.PointToClient(Cursor.Position)) Is _mainForm.FriendScrollBar OrElse _FriendsPanel.GetChildAtPoint(_FriendsPanel.PointToClient(Cursor.Position)) Is Nothing Then
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

        _ControlChildForm.OpenChildForm(chatform, _mainForm.MainChatAndFriendPanel, _mainForm.currentChildForm)
    End Sub

    Private Sub btnDeleteMessages_Click(sender As Object, e As EventArgs)


        Dim btn = DirectCast(sender, IconPictureBox)

        Dim s As String = btn.Name.Substring(btn.Name.IndexOf("Btn") + 3)

        Dim index = _mainForm._ListOfUserFriendsPanel.FindIndex(Function(panel) panel._FriendsPanel.Name = "pnl" + s)

        _mainForm.PanelListOfFriends.Controls.Remove(_FriendsPanel)
        _mainForm._ListOfUserFriendsPanel.RemoveAt(index)

        For i As Integer = 0 To _mainForm._ListOfUserFriendsPanel.Count - 1
            Debug.WriteLine(_mainForm._ListOfUserFriendsPanel.Item(i)._FriendsPanel.Name)
        Next

        Debug.WriteLine(index)

        On_DirectWasDeleted(index)

        If _mainForm.currentChildForm IsNot Nothing Then
            _mainForm.currentChildForm.Close()
        End If
    End Sub

    Private Sub On_DirectWasDeleted(index As Integer)
        For i As Integer = index To _mainForm._ListOfUserFriendsPanel.Count - 1
            _mainForm._ListOfUserFriendsPanel.Item(i)._FriendsPanel.Location = New Point(0, _mainForm._ListOfUserFriendsPanel.Item(i)._FriendsPanel.Location.Y - 60)
        Next
    End Sub

End Class