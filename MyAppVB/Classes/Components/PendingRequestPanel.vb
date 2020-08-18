Imports Guna.UI.WinForms

Public Class PendingRequestPanel
    Inherits GenericPanel

    '*****///// CONSTRUCTOR OF PANELS

    '*****///// ONLINE FRIENDS PANEL
    Sub New(ByRef pForm As PendingForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, userStateOnline As String, user_id As Integer)

        _User_ID = user_id
        _UserName = userName
        _PendingForm = pForm
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _UserStateOnlineStr = userStateOnline
        _ScrollBarOfUserChat = friendScrollBar

        Create_FriendsPanelOnline()
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_FriendsPanelOnline()
        Create_UserName()
        Create_Line(865, 1)
        Create_Panel(865, 62)
        Create_OnlineButton()
        Create_AcceptButton()
        Create_UnBlockButton()
        Create_UserPictureBox()
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

        _UnBlockBtn.ImageSize = New Size(20, 20)
        _UnBlockBtn.Image = My.Resources.icon_delete
        _UnBlockBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))

        _AcceptBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GreenColor))
        _AcceptBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GreenHoverColor))
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        AddHandler _UnBlockBtn.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserPanel.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _AcceptBtn.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _OvalOnline.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserStateOnline_Label.MouseEnter, AddressOf On_PendingReqPanel_Enter

        '*****///// ON MOUSE LEAVE THE PANEL
        AddHandler _UserPanel.MouseLeave, AddressOf On_PendingReqPanel_Leave
    End Sub

    '*****///// SET NAME OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserLine.Name = "pnlLine" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _AcceptBtn.Name = "pnlAccBtn" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnlineOval" + _NumberOfPanel
        _UnBlockBtn.Name = "pnlMenuDeclicebtn" + _NumberOfPanel
        _UserStateOnline_Label.Name = "pnlOnlineLbl" + _NumberOfPanel
    End Sub

    '*****///// SET LOCATION OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Location()
        Dim locationUserLine As Point = New Point(0, 61)
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationMenuDeclineBtn As Point = New Point(820, 12)
        Dim locationOfUserName As Point = New Point(55, 15)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationUserStateOnlineLabel As Point = New Point(55, 35)
        Dim locationAcceptBtn As Point = New Point(690, 15)


        _UserLine.Location = locationUserLine
        _UserPanel.Location = _LocationOfPanel
        _AcceptBtn.Location = locationAcceptBtn
        _OvalOnline.Location = locationOnlineLabel
        _UserNameLbl.Location = locationOfUserName
        _UserPictureBox.Location = locationOfPicture
        _UnBlockBtn.Location = locationMenuDeclineBtn
        _UserStateOnline_Label.Location = locationUserStateOnlineLabel
    End Sub

    '*****///// ADD ALL ELEMENTS ON THE PANEL
    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserLine)
        _UserPanel.Controls.Add(_AcceptBtn)
        _UserPanel.Controls.Add(_UnBlockBtn)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_UserStateOnline_Label)
    End Sub

    '*****///// ON PANEL MOUSE HOVER EVENT
    Private Sub On_PendingReqPanel_Enter()
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _UserLine.Visible = False

        UnderLine_SelectedUser(False)

        _UnBlockBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Private Sub On_PendingReqPanel_Leave()
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserLine.Visible = True

        UnderLine_SelectedUser(True)

        _UnBlockBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub

    '*****///// UNDER LINE USER PANEL
    Private Sub UnderLine_SelectedUser(state As Boolean)
        Dim index As Integer = _PendingForm._ListOfUserPendingReq.IndexOf(Me)

        If index > 0 Then
            _PendingForm._ListOfUserPendingReq.Item(index - 1)._UserLine.Visible = state
        Else
            _PendingForm.pnlUnderTextPeddingReq.Visible = state
        End If
    End Sub
End Class
