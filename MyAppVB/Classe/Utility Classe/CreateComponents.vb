Imports Guna.UI.WinForms
Imports FontAwesome.Sharp
Imports Microsoft.VisualBasic.PowerPacks

Public Class CreateComponents
    Private _FriendsPanel As New Panel
    Private _FriendsUserName As New Label
    Private ctr As ShapeContainer = New ShapeContainer()
    Private _LblFriendsOnline As OvalShape = New OvalShape(ctr)
    Private _FriendsPictureBox As New GunaCirclePictureBox
    Private _BtnDeleteChatWithFriend As New IconPictureBox

    Private _Utility_Style As New Utility_Style

    Private _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue

    Public Function Get_FriendPanel(panelName As String)
        Create_FriendPanel()
        Create_UserFriend_Label()
        Create_FriendPictureBox()
        Create_DeleteChat_Button()
        Create_FriendOnline_Label()

        Set_Name(panelName)

        Set_Location()

        AddComponents()

        Return _FriendsPanel
    End Function

    Public Sub Set_Name(panelName As String)
        _FriendsPanel.Name = "pnl" + panelName
        _FriendsUserName.Name = "lblName" + panelName
        _FriendsPictureBox.Name = "picBox" + panelName
        _LblFriendsOnline.Name = "lblOnline" + panelName
        _BtnDeleteChatWithFriend.Name = "btn" + panelName
    End Sub

    Public Sub AddComponents()
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

        _FriendsUserName.Location = locationOfUserName
        _FriendsPictureBox.Location = locationOfPicture
        _LblFriendsOnline.Location = locationOnlineLabel
        _BtnDeleteChatWithFriend.Location = locationOfDeleteButton
    End Sub

    Private Sub Create_FriendPanel()
        Dim width = 260, hight = 60

        Dim size As Size = New Size(width, hight)

        _FriendsPanel.Size = size
        _FriendsPanel.Cursor = Cursors.Hand
        _FriendsPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Private Sub Create_FriendOnline_Label()
        Dim width = 12
        Dim hight = width

        Dim size As Size = New Size(width, hight)

        _LblFriendsOnline.Size = size
        _LblFriendsOnline.BorderWidth = 2
        _LblFriendsOnline.Cursor = Cursors.Hand
        _LblFriendsOnline.FillColor = Color.Gray
        _LblFriendsOnline.FillStyle = FillStyle.Solid
        _LblFriendsOnline.BorderColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub
    Private Sub Create_FriendPictureBox()
        Dim width = 40, hight = 40

        Dim size As Size = New Size(width, hight)

        _FriendsPictureBox.Size = size
        _FriendsPictureBox.SendToBack()
        _FriendsPictureBox.Cursor = Cursors.Hand
        _FriendsPictureBox.BackColor = Color.Transparent
    End Sub

    Private Sub Create_UserFriend_Label()
        Dim width = 150, hight = 20

        Dim size As Size = New Size(width, hight)

        _FriendsUserName.Size = size
        _FriendsUserName.Text = "Friend Name"
        _FriendsUserName.Cursor = Cursors.Hand
        _FriendsUserName.ForeColor = Color.Gray
        _FriendsUserName.BackColor = Color.Transparent
        _FriendsUserName.Font = New Font("Microsoft YaHei", 9.75, FontStyle.Bold)
    End Sub

    Private Sub Create_DeleteChat_Button()
        Dim width = 20
        Dim hight = width

        Dim size As Size = New Size(width, hight)

        _BtnDeleteChatWithFriend.Size = size
        _BtnDeleteChatWithFriend.Cursor = Cursors.Hand
        _BtnDeleteChatWithFriend.IconColor = Color.Silver
        _BtnDeleteChatWithFriend.BackColor = Color.Transparent
        _BtnDeleteChatWithFriend.IconChar = FontAwesome.Sharp.IconChar.Times
    End Sub

End Class
