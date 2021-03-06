﻿Imports Guna.UI.WinForms

Public Class DmFriendsPanel
    Inherits GenericPanel

    Public _Cheked As Boolean = False

    Sub New(ByRef dForm As CreateDMForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, userStateOnline As String, user_id As Integer)

        _PanelName = "DM Friends Panel"
        _DmForm = dForm
        _Friend_ID = user_id
        _UserName = userName
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar
        _UserStateOnlineStr = userStateOnline
        _RadiusBnum = 20

        Create_DmPanel()
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_DmPanel()
        Create_UserName()
        Create_CheckBox()
        Create_Panel(370, 50)
        Create_OnlineButton()
        Create_UserPictureBox()

        UpdateComponents()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    '*****///// CHANGE SOMETHING INSIDE A PANEL
    Private Sub UpdateComponents()
        _UserPanel.BackColor = Color.Transparent
        _UserNameLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        AddHandler _UserPanel.MouseEnter, AddressOf On_UserDmPanel_Enter
        AddHandler _OvalOnline.MouseEnter, AddressOf On_UserDmPanel_Enter
        AddHandler _CheckBoxBtn.MouseEnter, AddressOf On_UserDmPanel_Enter
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_UserDmPanel_Enter
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_UserDmPanel_Enter

        '*****///// ON MOUSE CLICK EVENT
        AddHandler _UserPanel.MouseClick, AddressOf On_Panel_Click
        AddHandler _OvalOnline.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserNameLbl.MouseClick, AddressOf On_Panel_Click
        AddHandler _CheckBoxBtn.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserPictureBox.MouseClick, AddressOf On_Panel_Click

        '*****///// ON MOUSE LEAVE THE PANEL
        AddHandler _UserPanel.MouseLeave, AddressOf On_UserDmPanel_Leave
    End Sub

    '*****///// SET NAME OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnline" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _CheckBoxBtn.Name = "pnlCheckBox" + _NumberOfPanel
    End Sub

    '*****///// SET LOCATION OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(10, 5)
        Dim locationCheckBox As Point = New Point(325, 12)
        Dim locationOfUserName As Point = New Point(55, 17)
        Dim locationOnlineLabel As Point = New Point(40, 32)

        _UserPanel.Location = _LocationOfPanel
        _CheckBoxBtn.Location = locationCheckBox
        _UserNameLbl.Location = locationOfUserName
        _OvalOnline.Location = locationOnlineLabel
        _UserPictureBox.Location = locationOfPicture
    End Sub

    '*****///// ADD ALL ELEMENTS ON THE PANEL
    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_CheckBoxBtn)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
    End Sub

    '*****///// ON PANEL CLICK EVENT
    Private Sub On_Panel_Click()
        If Not _Cheked Then
            _CheckBoxBtn.IconChar = FontAwesome.Sharp.IconChar.CheckSquare
            _Cheked = Not _Cheked
        Else
            _CheckBoxBtn.IconChar = FontAwesome.Sharp.IconChar.Square
            _Cheked = Not _Cheked
        End If

        Dim numOfPersoneInGroup As Integer = 9

        For Each pnl As DmFriendsPanel In _DmForm._ListOfUserDmFriendsPanel
            numOfPersoneInGroup -= -pnl._Cheked
        Next

        _DmForm.lblMsg.Text = "You can add " + (numOfPersoneInGroup).ToString + " more friends."
    End Sub

    '*****///// ON PANEL MOUSE HOVER EVENT
    Private Sub On_UserDmPanel_Enter()
        _PnlSelected = True
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Private Sub On_UserDmPanel_Leave()
        _PnlSelected = False
        If Not _DmForm.pnlOfFriends.GetChildAtPoint(_DmForm.pnlOfFriends.PointToClient(Cursor.Position)) Is _UserPanel OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then
            _UserPanel.BackColor = Color.Transparent
        End If
    End Sub
End Class
