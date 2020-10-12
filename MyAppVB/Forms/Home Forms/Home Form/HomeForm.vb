Imports FontAwesome.Sharp
Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices

Public Class HomeForm

    '*****///// VARS
    Private _MsgText As String
    Private _UserName As String
    Private _MoveForm As Boolean
    Public _FriendID As Integer
    Private _LocX, _LocY As Integer
    Private _IconPic As IconPictureBox
    Private _DmFormWidth As Integer = 400
    Private _FirstClick As Boolean = False
    Private _SaveSecondChildForm As Boolean
    Private _MoveForm_MousePosition As Point
    Private _StillSerching As Boolean = False
    Private _IsFirstTimeSerchChatPnl As Boolean = True
    Public _SerchListOfChatPanels As New List(Of ChatFriendsPanel)
    Public _ListOfUserFriendsChatPanel As New List(Of ChatFriendsPanel)
    Public _ChatPnltoUnSelect As ChatFriendsPanel
    Public _OnlAllFPnltoUnSelect As OnlineAndAllFriendsPanel

    '*****///// FORM LOCATION
    Private _FormLocationX As Integer = 0
    Private _FormLocationY As Integer = 0

    '*****///// FORM SIZE
    Private _FormWidth As Integer = 0
    Private _FormHeight As Integer = 0

    '*****///// MOUSE LOCATION
    Private _MouseLocationX As Integer = 0
    Private _MouseLocationY As Integer = 0

    Private _Sender As New Object
    Private _E As MouseEventArgs

    '*****///// FORMS
    Private _PopUpForm
    Public _SecondChildForm As Form
    Public _CurrentChildForm As Form
    Public _CreateDmForm As CreateDMForm
    Public _MenuMoreForm As MenuMoreForm
    Public _DeleteFriendForm As DeleteFriendForm
    Public _RightClickMenuForm As RightClickMenuForm

    '*****///// COMPONENTS
    Private _GenericButton As GunaButton
    Private _TransBackGroud As New Panel
    Private _ButtonWasSelected As GunaButton
    Private _LastGenericButton As New GunaButton
    Public _LastOpenedFriendsPanel As GunaButton = btnFriendsOnline
    Private _vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    '*****///// CLASSES
    Private _Subject As New Subject
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure
    Public _ControlChildForm As New ControlChildForm
    Private _ShowPopUpMsg As New Open_PopUpForm(Me)

    '*****///// COLORS
    Private _RedColor As String = _Utility_Style.RedColor
    Private _OrngColor As String = _Utility_Style.OrngColor
    Private _MainColor As String = _Utility_Style.MainColor
    Private _GrayColor As String = _Utility_Style.WhiteColor
    Private _PanelsColor As String = _Utility_Style.DarkBlue
    Private _WhiteCOlor As String = _Utility_Style.WhiteColor
    Private _BackGColor As String = _Utility_Style.BackGroundColor
    Private _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue
    Private _GreenSeaColor As String = _Utility_Style.GreenSeaColor

    '*****///// SUB NEW FOR TESTS
    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        Save_UserName("n1sb0")
        SetStyle_For_Components()
    End Sub
    '*****///// SUB NEW
    Sub New(userName As String)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        'Take UserName
        Save_UserName(userName)
        SetStyle_For_Components()
    End Sub

    '*****///// SAVE USER DATA AND UPDATE USER DATA ON UI
    Private Sub Save_UserName(userName As String)
        _Subject = Subject.Get_Subject_Data_By(userName)

        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            Update_UserData()
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H210 AndAlso m.WParam.ToInt32() = 513 Then
            Check_Opened_Form()
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub Check_Opened_Form()
        Dim forms As Form() = Application.OpenForms.Cast(Of Form)().ToArray()

        For Each thisForm As Form In forms
            If thisForm.Name.Equals("RightClickMenuForm") OrElse thisForm.Name.Equals("MenuMoreForm") OrElse thisForm.Name.Equals("CreateDMForm") Then _PopUpForm = thisForm
        Next

        If Not _PopUpForm Is Nothing Then
            Close_PopUp_Form()
        End If
    End Sub

    Public Sub Close_PopUp_Form()
        _FormWidth = _PopUpForm.Width
        _FormLocationX = _PopUpForm.Bounds.Location.X
        _MouseLocationX = MousePosition.X - Bounds.Location.X

        _FormHeight = _PopUpForm.Height
        _FormLocationY = _PopUpForm.Bounds.Location.Y
        _MouseLocationY = MousePosition.Y - Bounds.Location.Y - 8

        If _FormLocationX > _MouseLocationX OrElse _MouseLocationX > _FormLocationX + _FormWidth _
            OrElse _FormLocationY > _MouseLocationY OrElse _MouseLocationY > _FormLocationY + _FormHeight Then

            If _MouseLocationY > 20 Then
                _PopUpForm.Close()

                If Not _ChatPnltoUnSelect Is Nothing Then
                    _ChatPnltoUnSelect.Leave_ListOfPanels()
                    _ChatPnltoUnSelect = Nothing
                End If

                If Not _OnlAllFPnltoUnSelect Is Nothing Then
                    _OnlAllFPnltoUnSelect.Leave_ListOfPanels()
                    _OnlAllFPnltoUnSelect = Nothing
                End If
            End If
        End If
    End Sub


    '*****///// UPDATE USER DATA
    Private Sub Update_UserData()
        lblUserName.Text = _Subject.SUBJECT_USERNAME

        If _Subject.SUBJECT_USER_PICTURE IsNot Nothing Then
            _Utility_Style.Set_UserPicture(UserPicture, _Subject.SUBJECT_USER_PICTURE)
        End If
    End Sub

    '*****///// ON HOME FORM SHOW
    Private Sub HomeForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Onclick_OpenChildForm_FriendPanels(btnFriendsOnline.Name)
        _LastOpenedFriendsPanel = btnFriendsOnline
    End Sub

    '*****///// STYLE FORM
    Private Sub SetStyle_For_Components()
        Form_style()
        Create_ListOfFriends()
    End Sub

    Public Sub Form_style()
        _vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(PanelListOfChatFriends, FriendsChatScrollBar, True)
        _vScrollHelper.UpdateScrollBar()

        MainPanel.Controls.Add(TransparentBackGround)

        TransparentBackGround.BringToFront()

        TransparentBackGround.Visible = False

        FriendsChatScrollBar.BringToFront()
        LeftButtomPanel.Visible = True

        UserPicture.SendToBack()
        _ButtonWasSelected = btnHomeChat

        pointOnline.BringToFront()
        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

        Me.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub Create_ListOfFriends()
        Dim createListOfPanels As New Create_ListOf_Panels(_Subject, FriendsChatScrollBar, Me, 60, "Chat", _ListOfUserFriendsChatPanel, PanelListOfChatFriends)

        createListOfPanels.Create_ListOfPanels()
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of LoginForm).Any Then
            LoginForm.Close()
        End If

        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            Update_UserData()
        End If
    End Sub


    '*****///// UPPER PANEL CLOSE HIDE RESIZE BUTTONS
    Private Sub btnMaxSizeForm_Click(sender As Object, e As EventArgs) Handles btnMaxSizeForm.Click
        If WindowState = FormWindowState.Normal Then
            Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
            Me.WindowState = FormWindowState.Maximized

            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Else
            WindowState = FormWindowState.Normal
            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        End If
    End Sub

    Private Sub btnHide_Click_1(sender As Object, e As EventArgs) Handles btnHide.Click
        If WindowState = FormWindowState.Normal Or WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// MOVE RESIZE FORM
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub myMoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        _MoveForm = True
    End Sub

    Private Sub myMoveForm_DoubleClick(sender As Object, e As EventArgs) Handles TopPanel.DoubleClick
        If WindowState = FormWindowState.Normal Then
            Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
            Me.WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub myMoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove
        If _MoveForm Then
            _MoveForm = False
            'FormBorderStyle = FormBorderStyle.Sizable
            Me.Cursor = Cursors.SizeAll

            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
            'FormBorderStyle = FormBorderStyle.None
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub myMoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseUp
        If e.Button = MouseButtons.Left Then
            _MoveForm = False
        End If
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            'FormBorderStyle = FormBorderStyle.None
            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Else
            'FormBorderStyle = FormBorderStyle.Sizable
            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        End If

        If Application.OpenForms().OfType(Of CreateDMForm).Any Then
            _CreateDmForm.Close()
        End If

        If Application.OpenForms().OfType(Of MenuMoreForm).Any Then
            _MenuMoreForm.Close()
        End If

        If Application.OpenForms().OfType(Of RightClickMenuForm).Any Then
            _RightClickMenuForm.Close()
        End If

        If Application.OpenForms().OfType(Of DeleteFriendForm).Any Then
            _DeleteFriendForm.Close()
            TransparentBackGround.Visible = False
        End If
    End Sub

    '*****///// BUTTON OPEN SETTINGS FORM
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        LeftButtomPanel.Visible = False
        Dim settingsForm As New SettingsForm(lblUserName.Text)
        _ControlChildForm.OpenChildForm(settingsForm, MainPanel, _CurrentChildForm)
    End Sub

    '*****///// MOUSE HOVER AND CLICK ON BUTTONS UI
    Private Sub Mouse_Hover_Buttons(sender As System.Object, e As System.EventArgs) _
      Handles btnHomeChat.MouseEnter, btnPersonalBlog.MouseEnter, btnVideo.MouseEnter, btnMusic.MouseEnter, btnGames.MouseEnter

        _GenericButton = DirectCast(sender, GunaButton)

        _Utility_Style.Select_Btn_UI(selectedPoint, New Point(selectedPoint.Location.X, _GenericButton.Location.Y + 18))
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click

        If _CurrentChildForm IsNot Nothing Then
            _CurrentChildForm.Close()
        End If

        Onclick_OpenChildForm_FriendPanels(_LastOpenedFriendsPanel.Name)
    End Sub

    '*****///// FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL
    Public Sub On_Click_LeftPanel_Buttons(Optional sender As System.Object = Nothing, Optional e As System.EventArgs = Nothing,
                                          Optional genButt As GunaButton = Nothing, Optional outsubj As Subject = Nothing) _
      Handles btnHomeChat.Click, btnVideo.Click, btnMusic.Click, btnGames.Click, btnPersonalBlog.Click
        Dim subj As Subject

        _ButtonWasSelected.Radius = 25
        _ButtonWasSelected.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))

        If Not genButt Is Nothing Then
            _GenericButton = genButt
            subj = outsubj
        Else
            _GenericButton = DirectCast(sender, GunaButton)
            subj = _Subject
        End If

        _GenericButton.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GreenSeaColor))

        Onclick_OpenChildForm_LeftPanel(_GenericButton.Name, subj)

        _Utility_Style.Select_Btn_UI(selectedPoint, New Point(selectedPoint.Location.X, _GenericButton.Location.Y + 18))
        _Utility_Style.Selected_Btn_Cliked_UI(clikedPoint, _GenericButton)
        _ButtonWasSelected = _GenericButton
    End Sub

    Public Sub Onclick_OpenChildForm_LeftPanel(buttonName As String, subj As Subject)

        If Not _SaveSecondChildForm Then
            Change_lastGenericButton()
            pnlMsgFriends.Visible = False
            _SecondChildForm = _CurrentChildForm
            _SaveSecondChildForm = True
        End If

        Select Case buttonName
            Case "btnPersonalBlog"
                Dim persinalBlogForm As New PersonalBlogForm(subj)
                _ControlChildForm.OpenChildForm(persinalBlogForm, PlayGroundPanel, _CurrentChildForm)

            Case "btnGames"
                Dim gameForm As New GameForm
                _ControlChildForm.OpenChildForm(gameForm, PlayGroundPanel, _CurrentChildForm)

            Case "btnMusic"
                Dim musicForm As New MusicForm
                _ControlChildForm.OpenChildForm(musicForm, PlayGroundPanel, _CurrentChildForm)

            Case "btnVideo"
                Dim videoForm As New VideoForm
                _ControlChildForm.OpenChildForm(videoForm, PlayGroundPanel, _CurrentChildForm)

            Case "btnHomeChat"
                _SaveSecondChildForm = False

                pnlMsgFriends.Visible = True
                If _CurrentChildForm IsNot Nothing Then
                    _CurrentChildForm.Close()
                End If

                Open_SavedChildForm()

                If Not _LastOpenedFriendsPanel.Name.Equals("btnAddNewFriends") Then
                    OnClick_GenericButton(_LastOpenedFriendsPanel)
                End If
        End Select
    End Sub

    Private Sub Open_SavedChildForm()
        Select Case _SecondChildForm.Name
            Case "AddFriendForm", "AllFriendsForm", "BlockedFriendsForm", "OnlineFriendsForm", "PendingForm"
                Onclick_OpenChildForm_FriendPanels(_SecondChildForm.Name)
            Case "ChatFriendForm"
                If _ListOfUserFriendsChatPanel.Count > 0 Then
                    Dim _SubjFriend As Subject

                    _SubjFriend = Subject.Get_SubjectByID(_FriendID)

                    Dim chatform As New ChatFriendForm(_Subject, _SubjFriend, _SubjFriend.SUBJECT_USERNAME, _SubjFriend.SUBJECT_STATE_ONLINE)
                    _ControlChildForm.OpenChildForm(chatform, MainChatAndFriendPanel, _CurrentChildForm)
                Else
                    Onclick_OpenChildForm_FriendPanels("OnlineFriendsForm")
                End If
        End Select
    End Sub

    '*****///// FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL
    Private Sub On_Click_UpperPanel_FriendPanel_Button(sender As System.Object, e As System.EventArgs) _
      Handles btnFriendsOnline.Click, btnAllFrineds.Click, btnBlockedFriends.Click, btnAddNewFriends.Click, btnPending.Click

        Change_lastGenericButton()

        _GenericButton = DirectCast(sender, GunaButton)

        If _FirstClick Then
            _LastGenericButton = _GenericButton
        Else
            _LastGenericButton = btnFriendsOnline

            Change_lastGenericButton()

            _LastGenericButton = _GenericButton
            _FirstClick = True
        End If

        If Not _LastGenericButton.Name.Equals("btnAddNewFriends") Then
            OnClick_GenericButton(_GenericButton)
        End If

        _LastOpenedFriendsPanel = _GenericButton

        Onclick_OpenChildForm_FriendPanels(_GenericButton.Name)

    End Sub

    Public Sub Change_lastGenericButton()
        If Not _LastGenericButton.Name.Equals("btnAddNewFriends") Then
            _LastGenericButton.BaseColor = Color.Transparent
            _LastGenericButton.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub OnClick_GenericButton(ByRef genBtn As GunaButton)
        genBtn.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
        genBtn.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    Public Sub Onclick_OpenChildForm_FriendPanels(buttonName As String)

        Select Case buttonName
            Case "btnAllFrineds", "AllFriendsForm"
                Dim allFriendsForm As New AllFriendsForm(_Subject, Me)
                _ControlChildForm.OpenChildForm(allFriendsForm, FriendsPanelChild, _CurrentChildForm)

            Case "btnBlockedFriends", "BlockedFriendsForm"
                Dim blockedFriendsForm As New BlockedFriendsForm(_Subject)
                _ControlChildForm.OpenChildForm(blockedFriendsForm, FriendsPanelChild, _CurrentChildForm)

            Case "btnAddNewFriends", "AddFriendForm"
                Dim addNewFriendsForm As New AddFriendForm(_Subject)
                _ControlChildForm.OpenChildForm(addNewFriendsForm, FriendsPanelChild, _CurrentChildForm)

            Case "btnFriendsOnline", "OnlineFriendsForm"
                Dim onlineFriendsForm As New OnlineFriendsForm(_Subject, Me)
                _ControlChildForm.OpenChildForm(onlineFriendsForm, FriendsPanelChild, _CurrentChildForm)

            Case "btnPending", "PendingForm"
                Dim pandingForm As New PendingForm(_Subject)
                _ControlChildForm.OpenChildForm(pandingForm, FriendsPanelChild, _CurrentChildForm)

        End Select
    End Sub

    '*****///// ON SCROLL FRIENDSLIST TO NOT SEE MILTIPLE SELECTED FIRENDS
    Private Sub FriendScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles FriendsChatScrollBar.Scroll
        For i As Integer = 0 To _ListOfUserFriendsChatPanel.Count - 1
            _ListOfUserFriendsChatPanel.Item(i).Leave_ListOfChatPanels()
        Next
    End Sub

    '*****///// SEARCH CHAT WITH FRIEND
    Public Sub txtFindFriends_Leave(sender As Object, e As EventArgs) Handles txtFindFriends.Leave
        txtFindFriends.Text = "Find Your Friends"
        Me.ActiveControl = lblDirectMessages
    End Sub

    Private Sub txtFindFriends_Enter(sender As Object, e As EventArgs) Handles txtFindFriends.Enter
        If txtFindFriends.Text.Equals("Find Your Friends") Then
            txtFindFriends.Text = ""
        End If
    End Sub

    Private Sub txtFindFriends_TextChanged(sender As Object, e As EventArgs) Handles txtFindFriends.TextChanged

        If Not txtFindFriends.Text.Equals("Find Your Friends") AndAlso Not String.IsNullOrEmpty(txtFindFriends.Text) Then

            Dim y As String = 0
            _StillSerching = True
            Dim txtString As String = (txtFindFriends.Text).ToLower()
            Dim maxNum As Integer = _ListOfUserFriendsChatPanel.Count - 1

            Clear_ChatPanel(_SerchListOfChatPanels, True)
            Clear_ChatPanel(_ListOfUserFriendsChatPanel, True)

            Create_ListOfFriends()

            For Each pnl In _ListOfUserFriendsChatPanel
                If pnl._UserName.ToLower().Contains(txtString) Then
                    _SerchListOfChatPanels.Add(pnl)
                End If
            Next

            Clear_ChatPanel(_ListOfUserFriendsChatPanel, True)

            For j As Integer = 0 To _SerchListOfChatPanels.Count - 1
                _ListOfUserFriendsChatPanel.Add(_SerchListOfChatPanels.Item(j))
            Next

            For i As Integer = 0 To _ListOfUserFriendsChatPanel.Count - 1
                _ListOfUserFriendsChatPanel.Item(i)._UserPanel.Location = New Point(0, y)
                y += 60

                PanelListOfChatFriends.Controls.Add(_ListOfUserFriendsChatPanel.Item(i)._UserPanel)
            Next
        Else
            _StillSerching = False
        End If

        If Not _StillSerching Then
            Clear_ChatPanel(_ListOfUserFriendsChatPanel, True)
            Create_ListOfFriends()
        End If
    End Sub

    Private Sub Clear_ChatPanel(ByRef listOfChatPnl As List(Of ChatFriendsPanel), clearList As Boolean)

        If Not listOfChatPnl Is Nothing Then
            For i As Integer = 0 To listOfChatPnl.Count - 1
                PanelListOfChatFriends.Controls.Remove(listOfChatPnl.Item(i)._UserPanel)
            Next

            If clearList Then
                listOfChatPnl.Clear()
            End If
        End If
    End Sub

    '*****///// OPEN NEW FORM CREAT CHAT 
    Private Sub btnNewDirect_Click(sender As Object, e As EventArgs) Handles btnNewDirect.Click

        _LocX = btnNewDirect.Location.X + 70
        _LocY = btnNewDirect.Location.Y + 40

        Open_CreateChatForm(_LocX, _LocY)
    End Sub

    Private Sub btnCreateChat_Click(sender As Object, e As EventArgs) Handles btnCreateChat.Click
        _LocX = (btnCreateChat.Location.X + 330) - (_DmFormWidth - 30)
        _LocY = btnCreateChat.Location.Y + 50

        Open_CreateChatForm(_LocX, _LocY)
    End Sub

    Private Sub On_CreateDM_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnNewDirect.MouseEnter, btnCreateChat.MouseEnter, btnHelp.MouseEnter, btnSettings.MouseEnter

        _IconPic = DirectCast(sender, IconPictureBox)

        _IconPic.ForeColor = Color.White

        Select Case _IconPic.Name
            Case "btnNewDirect"
                _MsgText = "Create DM"

                _LocX = (_IconPic.Location.X + _IconPic.Width / 2) + 70
                _LocY = _IconPic.Location.Y - 12

            Case "btnCreateChat"
                _MsgText = "New Gruop DM"

                _LocX = (_IconPic.Location.X + _IconPic.Width / 2) + 330
                _LocY = _IconPic.Location.Y + 55

            Case "btnHelp"
                _MsgText = "Help"

                _LocX = (_IconPic.Location.X + _IconPic.Width / 2) + 330
                _LocY = _IconPic.Location.Y + 55

            Case "btnSettings"
                _MsgText = "User Settings"

                _LocX = _IconPic.Location.X + 95
                _LocY = _IconPic.Location.Y + 18

        End Select

        _ShowPopUpMsg.Open_MessageForm(_MsgText, _LocX, _LocY)
    End Sub

    Private Sub On_CreateDM_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnNewDirect.MouseLeave, btnCreateChat.MouseLeave, btnHelp.MouseLeave, btnSettings.MouseLeave

        _IconPic = DirectCast(sender, IconPictureBox)

        _IconPic.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_WhiteCOlor))

        _ShowPopUpMsg.Open_MessageForm()

    End Sub

    Private Sub TransparentBackGround_Click(sender As Object, e As EventArgs) Handles TransparentBackGround.Click
        TransparentBackGround.Visible = False
        _DeleteFriendForm.Close()
    End Sub

    Private Sub UserPicture_Click(sender As Object, e As EventArgs) Handles UserPicture.Click

    End Sub

    Private Sub HomeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'To save subject state online
        My.Settings.StateOnline = _Subject.SUBJECT_STATE_ONLINE
        _Subject.Update_Subject_StateOnline("Offline")
    End Sub

    Private Sub Open_CreateChatForm(x As Integer, y As Integer)

        If Not Application.OpenForms().OfType(Of CreateDMForm).Any Then
            _CreateDmForm = New CreateDMForm(Me, _Subject)

            _CreateDmForm.TopLevel = False
            _CreateDmForm.Parent = Me

            _CreateDmForm.SetBounds(x, y, _DmFormWidth, _DmFormWidth - 50)
            _CreateDmForm.BringToFront()
            _CreateDmForm.Show()
        End If
    End Sub
End Class