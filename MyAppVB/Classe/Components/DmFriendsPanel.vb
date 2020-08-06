Imports Guna.UI.WinForms

Public Class DmFriendsPanel
    Inherits GenericPanel

    Public _Cheked As Integer = 0

    Sub New(ByRef dForm As CreateDMForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar, panelname As String, userPicture As Byte(), userName As String, userStateOnline As String)
        _DmForm = dForm
        _UserName = userName
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _ScrollBarOfUserChat = friendScrollBar
        _UserStateOnlineStr = userStateOnline

        Create_DmPanel()
    End Sub

    Private Sub Create_DmPanel()
        Create_Panel(350, 50)
        Create_RadiusBackGround_Left()
        Create_RadiusBackGround_Right()
        Create_UserName()
        Create_OnlineButton()
        Create_UserPictureBox()
        Create_CheckBox()

        UpdateComponents()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    Private Sub UpdateComponents()
        _UserPanel.BackColor = Color.Transparent
        _UserNameLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))

        _BackGRadLeft.Size = New Size(50, 50)
        _BackGRadRight.Size = New Size(50, 50)

    End Sub

    Public Sub AddEventRef()
        AddHandler _UserPanel.MouseEnter, AddressOf On_UserDmPanel_Hover
        AddHandler _OvalOnline.MouseEnter, AddressOf On_UserDmPanel_Hover
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_UserDmPanel_Hover
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_UserDmPanel_Hover
        AddHandler _CheckBoxBtn.MouseEnter, AddressOf On_UserDmPanel_Hover

        AddHandler _UserPanel.MouseClick, AddressOf On_Panel_Click
        AddHandler _OvalOnline.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserNameLbl.MouseClick, AddressOf On_Panel_Click
        AddHandler _UserPictureBox.MouseClick, AddressOf On_Panel_Click
        AddHandler _CheckBoxBtn.MouseClick, AddressOf On_Panel_Click

        AddHandler _UserPanel.MouseLeave, AddressOf On_UserDmPanel_Leave
    End Sub

    Private Sub On_Panel_Click()
        If _Cheked = 0 Then
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

    Private Sub On_UserDmPanel_Hover()
        BorderOfPanel_Visible(True)

        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    Private Sub On_UserDmPanel_Leave()
        BorderOfPanel_Visible(False)

        _UserPanel.BackColor = Color.Transparent
    End Sub

    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnline" + _NumberOfPanel
        _CheckBoxBtn.Name = "pnlCheckBox" + _NumberOfPanel
    End Sub

    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_CheckBoxBtn)
    End Sub

    Private Sub Set_Location()
        Dim locationOfPicture As Point = New Point(5, 5)
        Dim locationOfUserName As Point = New Point(50, 17)
        Dim locationOnlineLabel As Point = New Point(34, 32)
        Dim locationCheckBox As Point = New Point(315, 12)

        _UserPanel.Location = _LocationOfPanel
        _UserNameLbl.Location = locationOfUserName
        _UserPictureBox.Location = locationOfPicture
        _OvalOnline.Location = locationOnlineLabel
        _CheckBoxBtn.Location = locationCheckBox
    End Sub

End Class
