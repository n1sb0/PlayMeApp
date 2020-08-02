Imports System
Imports System.Windows.Forms
Imports Guna.UI.WinForms
Imports FontAwesome.Sharp
Imports Microsoft.VisualBasic.PowerPacks
Imports System.Object
Imports System.EventArgs

Public Class GenericPanel

    Private _Utility_Style As New Utility_Style
    Private _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue

    Public Sub Create_Panel(ByRef _FriendsPanel As Panel, width As Integer, hight As Integer)

        Dim size As Size = New Size(width, hight)

        _FriendsPanel.Size = size
        _FriendsPanel.Cursor = Cursors.Hand
        _FriendsPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Public Sub Create_OnlineButton(ByRef _LblFriendsOnline As OvalShape, _UserStateOnline As String)
        Dim width = 12
        Dim hight = width

        Dim size As Size = New Size(width, hight)

        _Utility_Style.Set_UserStateOnline(_LblFriendsOnline, _UserStateOnline)

        _LblFriendsOnline.Size = size
        _LblFriendsOnline.BorderWidth = 3
        _LblFriendsOnline.Enabled = False
        _LblFriendsOnline.Cursor = Cursors.Hand
        _LblFriendsOnline.FillStyle = FillStyle.Solid
        _LblFriendsOnline.BorderColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Public Sub Create_UserPictureBox(ByRef _FriendsPictureBox As GunaCirclePictureBox, _UserPicture As Byte())
        Dim width = 40, hight = 40

        Dim size As Size = New Size(width, hight)

        _Utility_Style.Set_UserPicture(_FriendsPictureBox, _UserPicture)
        _FriendsPictureBox.Size = size
        _FriendsPictureBox.Cursor = Cursors.Hand
        _FriendsPictureBox.BackColor = Color.Transparent
    End Sub

    Public Sub Create_UserName(ByRef _FriendsUserName As Label, _UserName As String)
        'Dim width = 150, hight = 20

        'Dim size As Size = New Size(width, hight)

        '_FriendsUserName.Size = size

        _FriendsUserName.AutoSize = True
        _FriendsUserName.Text = _UserName
        _FriendsUserName.Cursor = Cursors.Hand
        _FriendsUserName.ForeColor = Color.Gray
        _FriendsUserName.BackColor = Color.Transparent
        _FriendsUserName.Font = New Font("Microsoft YaHei", 9.75, FontStyle.Bold)
    End Sub

    Public Sub Create_DeleteDirectButton(ByRef _BtnDeleteChatWithFriend As IconPictureBox)
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

End Class
