Imports Guna.UI.WinForms

Public Class PendingRequestPanel
    Inherits GenericPanel

    Private _Friend As New Subject
    Private _Subject As New Subject
    Private _Request As String
    '*****///// CONSTRUCTOR OF PANELS
    Sub New(ByRef pForm As PendingForm, locationOfPanel As Point, ByRef friendScrollBar As GunaVScrollBar,
            panelname As String, userPicture As Byte(), userName As String, userStateOnline As String, user_id As Integer, request As String)

        _PanelName = "Pending Request Panel"
        _User_ID = user_id
        _UserName = userName
        _PendingForm = pForm
        _NumberOfPanel = panelname
        _UserPicture = userPicture
        _LocationOfPanel = locationOfPanel
        _UserStateOnlineStr = userStateOnline
        _ScrollBarOfUserChat = friendScrollBar
        _Request = request

        If _Request.Equals("Friend Request") Then
            Create_FriendRequest()
        ElseIf _Request.Equals("Outgoing Friend Request") Then
            Create_OutGoingFriendRequest()
        End If
    End Sub

    '*****///// CREATE A PANEL WITH ALL COMPONENTS
    Private Sub Create_FriendRequest()
        Create_UserName()
        Create_Line(865, 1)
        Create_Panel(865, 62)
        Create_OnlineButton()
        Create_AcceptButton()
        Create_DeleteBtn()
        Create_UserPictureBox()
        Create_UserStateOnline_Label()

        UpdateComponents()

        AddEventRef()

        Set_Name()

        Set_Location()

        AddComponents()
    End Sub

    Private Sub Create_OutGoingFriendRequest()
        Create_UserName()
        Create_Line(865, 1)
        Create_Panel(865, 62)
        Create_OnlineButton()
        Create_DeleteBtn()
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

        _DeleteBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))

        _AcceptBtn.OnHoverBaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GreenHoverColor))

        _UserStateOnline_Label.Text = _Request
    End Sub

    '*****///// ADD EVENT REFERENCE TO ELEMENTS
    Public Sub AddEventRef()
        '*****///// ON MOUSE ENTER HOVER THE PANEL EVENT
        AddHandler _DeleteBtn.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserPanel.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _AcceptBtn.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _OvalOnline.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserNameLbl.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserPictureBox.MouseEnter, AddressOf On_PendingReqPanel_Enter
        AddHandler _UserStateOnline_Label.MouseEnter, AddressOf On_PendingReqPanel_Enter

        '*****///// ON MOUSE LEAVE THE PANEL
        AddHandler _UserPanel.MouseLeave, AddressOf On_PendingReqPanel_Leave

        '*****///// ON BUTTON CLICK EVENT
        AddHandler _DeleteBtn.MouseClick, AddressOf On_DeleteRequest_Click
        AddHandler _AcceptBtn.MouseClick, AddressOf On_AcceptButton_Click
    End Sub

    '*****///// SET NAME OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Name()
        _UserPanel.Name = "pnl" + _NumberOfPanel
        _UserLine.Name = "pnlLine" + _NumberOfPanel
        _UserNameLbl.Name = "pnlName" + _NumberOfPanel
        _AcceptBtn.Name = "pnlAccBtn" + _NumberOfPanel
        _UserPictureBox.Name = "pnlPic" + _NumberOfPanel
        _OvalOnline.Name = "pnlOnlineOval" + _NumberOfPanel
        _DeleteBtn.Name = "pnlDeletebtn" + _NumberOfPanel
        _UserStateOnline_Label.Name = "pnlOnlineLbl" + _NumberOfPanel
    End Sub

    '*****///// SET LOCATION OF WHICH ELEMENT INSIDE OF PANEL
    Private Sub Set_Location()
        Dim locationUserLine As Point = New Point(0, 61)
        Dim locationOfPicture As Point = New Point(10, 9)
        Dim locationDeleteBtn As Point = New Point(820, 12)
        Dim locationOfUserName As Point = New Point(55, 15)
        Dim locationOnlineLabel As Point = New Point(39, 37)
        Dim locationUserStateOnlineLabel As Point = New Point(55, 35)
        Dim locationAcceptBtn As Point = New Point(775, 12)


        _UserLine.Location = locationUserLine
        _UserPanel.Location = _LocationOfPanel
        _AcceptBtn.Location = locationAcceptBtn
        _OvalOnline.Location = locationOnlineLabel
        _UserNameLbl.Location = locationOfUserName
        _UserPictureBox.Location = locationOfPicture
        _DeleteBtn.Location = locationDeleteBtn
        _UserStateOnline_Label.Location = locationUserStateOnlineLabel
    End Sub

    '*****///// ADD ALL ELEMENTS ON THE PANEL
    Private Sub AddComponents()
        _UserPanel.Controls.Add(Ctr)
        _UserPanel.Controls.Add(_UserLine)
        _UserPanel.Controls.Add(_DeleteBtn)
        _UserPanel.Controls.Add(_UserNameLbl)
        _UserPanel.Controls.Add(_UserPictureBox)
        _UserPanel.Controls.Add(_UserStateOnline_Label)

        If _Request.Equals("Friend Request") Then
            _UserPanel.Controls.Add(_AcceptBtn)
        End If
    End Sub

    '*****///// ON DELETE BUTTON CLICK
    Private Sub On_DeleteRequest_Click()
        _PendingForm.pnlPendingReq.Controls.Remove(_UserPanel)

        Dim indexOfPanel As Integer = _PendingForm._ListOfUserPendingReq.IndexOf(Me)

        _PendingForm._ListOfUserPendingReq.RemoveAt(indexOfPanel)

        On_ClosedRequest(indexOfPanel)

        _Friend = Subject.Get_Subject_Data(_UserName)
        Dim strQuery As String = MyConnection.Get_Delete_Pending_Request

        If _Request.Equals("Friend Request") Then
            Subject_Friends.Delete_Reference_OfTwoFriends(_Friend.SUBJECT_ID, _PendingForm._Subject.SUBJECT_ID, strQuery)
        ElseIf _Request.Equals("Outgoing Friend Request") Then
            Subject_Friends.Delete_Reference_OfTwoFriends(_PendingForm._Subject.SUBJECT_ID, _Friend.SUBJECT_ID, strQuery)
        End If

    End Sub

    Private Sub On_ClosedRequest(index As Integer)
        For i As Integer = index To _PendingForm._ListOfUserPendingReq.Count - 1
            _PendingForm._ListOfUserPendingReq.Item(i)._UserPanel.Location = New Point(10, _PendingForm._ListOfUserPendingReq.Item(i)._UserPanel.Location.Y - 61)
        Next
    End Sub


    '*****///// ON PANEL MOUSE HOVER EVENT
    Private Sub On_PendingReqPanel_Enter()
        _PnlSelected = True
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _UserLine.Visible = False

        UnderLine_SelectedUser(False)

        _AcceptBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
        _DeleteBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_DarkBlue))
    End Sub

    '*****///// ON MOUSE LEAVE EVENT
    Private Sub On_PendingReqPanel_Leave()
        If Not _PendingForm.pnlPendingReq.GetChildAtPoint(_PendingForm.pnlPendingReq.PointToClient(Cursor.Position)) Is _UserPanel OrElse _UserPanel.GetChildAtPoint(_UserPanel.PointToClient(Cursor.Position)) Is Nothing Then
            _PnlSelected = False
            Leave_ListOfPanels()
        End If
    End Sub

    Private Sub Leave_ListOfPanels()
        _UserPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        _UserLine.Visible = True

        UnderLine_SelectedUser(True)

        _AcceptBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        _DeleteBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
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

    '*****///// ON ACCPET BUTTON CLICK
    Private Sub On_AcceptButton_Click()
        _PendingForm.pnlPendingReq.Controls.Remove(_UserPanel)

        Dim indexOfPanel As Integer = _PendingForm._ListOfUserPendingReq.IndexOf(Me)

        _PendingForm._ListOfUserPendingReq.RemoveAt(indexOfPanel)

        On_ClosedRequest(indexOfPanel)

        _Subject = _PendingForm._Subject
        _Friend = Subject.Get_Subject_Data(_UserName)

        Dim friendObj As New Subject_Friends

        friendObj.Update_DataWith_Transaction(_Subject.SUBJECT_ID, _Friend.SUBJECT_ID)

    End Sub
End Class