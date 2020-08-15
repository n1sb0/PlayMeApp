﻿Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices

Public Class MainForm

    '*****///// VARS
    Private _UserName As String
    Private _MoveForm As Boolean
    Public _OpenedChat As Integer
    Private _LocX, _LocY As Integer
    Private _DmFormWidth As Integer = 400
    Private _FirstClick As Boolean = False
    Private _SaveSecondChildForm As Boolean
    Private _MoveForm_MousePosition As Point
    Public _ListOfUserFriendsChatPanel As New List(Of FriendsChatPanel)

    '*****///// FORMS
    Public _SecondChildForm As Form
    Public _CurrentChildForm As Form
    Private _CreateDmForm As CreateDMForm
    Private _MenuMoreForm As MenuMoreForm
    Private _DeleteFriendForm As DeleteFriendForm

    '*****///// COMPONENTS
    Private _GenericButton As GunaButton
    Private _ButtonWasSelected As GunaButton
    Private _LastGenericButton As New GunaButton
    Public _LastOpenedFriendsPanel As GunaButton = btnFriendsOnline
    Private _vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    '*****///// CLASSES
    Private _Subject As New Subject
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure
    Public _ControlChildForm As New ControlChildForm

    '*****///// COLORS
    Private _RedColor As String = _Utility_Style.RedColor
    Private _OrngColor As String = _Utility_Style.OrngColor
    Private _MainColor As String = _Utility_Style.MainColor
    Private _GrayColor As String = _Utility_Style.GrayColor
    Private _PanelsColor As String = _Utility_Style.DarkBlue
    Private _BackGColor As String = _Utility_Style.BackGroundColor
    Private _PanelsColorLightDarkBlue As String = _Utility_Style.LightDarkBlue

    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        Save_UserName("n1sb0")
        SetStyle_For_Components()
    End Sub


    Sub New(userName As String)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        'Take UserName
        Save_UserName(userName)
        SetStyle_For_Components()
    End Sub

    '*****///// SAVE USER DATA AND UPDATE USER DATA ON UI
    Private Sub Save_UserName(userName As String)
        _Subject = Subject.Get_Subject_Data(userName)

        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            Update_UserData()
        End If
    End Sub

    Private Sub Update_UserData()
        lblUserName.Text = _Subject.SUBJECT_USERNAME

        If _Subject.SUBJECT_USER_PICTURE IsNot Nothing Then
            _Utility_Style.Set_UserPicture(UserPicture, _Subject.SUBJECT_USER_PICTURE)
        End If
    End Sub
    '*****///// END SAVE USER DATA AND UPDATE USER DATA ON UI

    '*****///// STYLE FORM
    Private Sub SetStyle_For_Components()
        Form_style()
        Create_ListOfFriends()
    End Sub

    Public Sub Form_style()
        _vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(PanelListOfChatFriends, FriendsChatScrollBar, True)
        _vScrollHelper.UpdateScrollBar()

        FriendsChatScrollBar.BringToFront()
        LeftButtomPanel.Visible = True

        UserPicture.SendToBack()
        _ButtonWasSelected = btnHomeChat

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
    '*****///// END STYLE FORM

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
    '*****///// END UPPER PANEL CLOSE HIDE RESIZE BUTTONS

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
            ' FormBorderStyle = FormBorderStyle.Sizable
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
            FormBorderStyle = FormBorderStyle.None
            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Else
            FormBorderStyle = FormBorderStyle.Sizable
            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        End If

        If Application.OpenForms().OfType(Of CreateDMForm).Any Then
            _CreateDmForm.Close()
        End If

        If Application.OpenForms().OfType(Of MenuMoreForm).Any Then
            _MenuMoreForm.Close()
        End If

        If Application.OpenForms().OfType(Of DeleteFriendForm).Any Then
            _DeleteFriendForm.Close()
        End If
    End Sub
    '*****///// END MOVE RESIZE FORM

    '*****///// BUTTON OPEN SETTINGS FORM
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        LeftButtomPanel.Visible = False
        Dim settingsForm As New SettingsForm(lblUserName.Text)
        _ControlChildForm.OpenChildForm(settingsForm, MainPanel, _CurrentChildForm)
    End Sub

    '*****///// END BUTTON OPEN SETTINGS FORM

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
    '*****///// END MOUSE HOVER AND CLICK ON BUTTONS UI

    '*****///// FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL
    Private Sub On_Click_LeftPanel_Buttons(sender As System.Object, e As System.EventArgs) _
      Handles btnHomeChat.Click, btnPersonalBlog.Click, btnVideo.Click, btnMusic.Click, btnGames.Click
        _ButtonWasSelected.Radius = 25
        _ButtonWasSelected.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColor))


        _GenericButton = DirectCast(sender, GunaButton)

        _GenericButton.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))

        Onclick_OpenChildForm_LeftPanel(_GenericButton.Name)

        _Utility_Style.Select_Btn_UI(selectedPoint, New Point(selectedPoint.Location.X, _GenericButton.Location.Y + 18))
        _Utility_Style.Selected_Btn_Cliked_UI(clikedPoint, _GenericButton)
        _ButtonWasSelected = _GenericButton
    End Sub

    Private Sub Onclick_OpenChildForm_LeftPanel(buttonName As String)

        If Not _SaveSecondChildForm Then
            Change_lastGenericButton()
            pnlMsgFriends.Visible = False
            _SecondChildForm = _CurrentChildForm
            _SaveSecondChildForm = True
        End If

        Select Case buttonName
            Case "btnPersonalBlog"
                Dim persinalBlogForm As New PersonalBlogForm
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
    '*****///// END FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL

    Private Sub Open_SavedChildForm()
        Debug.WriteLine(_SecondChildForm.Name)

        Select Case _SecondChildForm.Name
            Case "AddFriendForm", "AllFriendsForm", "BlockedFriendsForm", "OnlineFriendsForm", "PendingForm"
                Onclick_OpenChildForm_FriendPanels(_SecondChildForm.Name)
            Case "ChatFriendForm"
                _ListOfUserFriendsChatPanel.Item(_OpenedChat).On_ChatPanel_Click(_ListOfUserFriendsChatPanel.Item(_OpenedChat)._Sender, _ListOfUserFriendsChatPanel.Item(_OpenedChat)._E)
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
                Dim addNewFriendsForm As New AddFriendForm
                _ControlChildForm.OpenChildForm(addNewFriendsForm, FriendsPanelChild, _CurrentChildForm)

            Case "btnFriendsOnline", "OnlineFriendsForm"
                Dim onlineFriendsForm As New OnlineFriendsForm(_Subject)
                _ControlChildForm.OpenChildForm(onlineFriendsForm, FriendsPanelChild, _CurrentChildForm)

            Case "btnPending", "PendingForm"
                Dim pandingForm As New PendingForm(_Subject)
                _ControlChildForm.OpenChildForm(pandingForm, FriendsPanelChild, _CurrentChildForm)

        End Select
    End Sub
    '*****///// END FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL

    '*****///// ON SCROLL FRIENDSLIST TO NOT SEE MILTIPLE SELECTED FIRENDS
    Private Sub FriendScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles FriendsChatScrollBar.Scroll
        For i As Integer = 0 To _ListOfUserFriendsChatPanel.Count - 1
            _ListOfUserFriendsChatPanel.Item(i).Leave_ListOfChatPanels()
        Next
    End Sub

    Public Sub txtFindFriends_Leave(sender As Object, e As EventArgs) Handles txtFindFriends.Leave
        txtFindFriends.Text = "Find Your Friends"
        Me.ActiveControl = lblDirectMessages
    End Sub

    Private Sub txtFindFriends_Enter(sender As Object, e As EventArgs) Handles txtFindFriends.Enter
        If txtFindFriends.Text.Equals("Find Your Friends") Then
            txtFindFriends.Text = ""
        End If
    End Sub
    '*****///// END ON SCROLL FRIENDSLIST TO NOT SEE MILTIPLE SELECTED FIRENDS

    Private Sub txtFindFriends_TextChanged(sender As Object, e As EventArgs) Handles txtFindFriends.TextChanged
        If Not txtFindFriends.Text.Equals("Find Your Friends") Then
            Dim txtString As String = txtFindFriends.Text

            For Each pnl In _ListOfUserFriendsChatPanel
                If Not String.IsNullOrEmpty(txtString) Then
                    If pnl._UserNameLbl.Text.Contains(txtString) Then
                        pnl._UserPanel.Visible = True
                    Else
                        pnl._UserPanel.Visible = False
                    End If
                Else
                    pnlVisible(True)
                End If
            Next
        Else
            pnlVisible(True)
        End If
    End Sub

    Private Sub pnlVisible(state As Boolean)
        For Each pnl In _ListOfUserFriendsChatPanel
            pnl._UserPanel.Visible = state
        Next
    End Sub

    Private Sub HomeForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Onclick_OpenChildForm_FriendPanels(btnFriendsOnline.Name)
        _LastOpenedFriendsPanel = btnFriendsOnline
    End Sub

    Private Sub btnNewDirect_Click(sender As Object, e As EventArgs) Handles btnNewDirect.Click
        _LocX = btnNewDirect.Location.X + 70
        _LocY = btnNewDirect.Location.Y + 40

        Open_CreateChatForm(_LocX, _LocY)

        If btnNewDirect.Rotation = 0 Then

            btnNewDirect.Rotation = 45
            btnNewDirect.IconColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        Else
            btnNewDirect.IconColor = Color.Silver
            btnNewDirect.Rotation = 0
        End If
    End Sub

    Private Sub btnCreateChat_Click(sender As Object, e As EventArgs) Handles btnCreateChat.Click
        _LocX = (btnCreateChat.Location.X + 330) - (_DmFormWidth - 30)
        _LocY = btnCreateChat.Location.Y + 50

        Open_CreateChatForm(_LocX, _LocY)
    End Sub

    Private Sub Open_CreateChatForm(x As Integer, y As Integer)

        If Not Application.OpenForms().OfType(Of CreateDMForm).Any Then
            _CreateDmForm = New CreateDMForm(Me, _Subject)

            _CreateDmForm.TopLevel = False
            _CreateDmForm.Parent = Me

            _CreateDmForm.SetBounds(x, y, _DmFormWidth, _DmFormWidth - 50)
            _CreateDmForm.BringToFront()
            _CreateDmForm.Show()
        Else
            _CreateDmForm.Close()
        End If
    End Sub
End Class