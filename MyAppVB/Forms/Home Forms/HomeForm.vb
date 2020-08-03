﻿Imports FontAwesome.Sharp
Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices
Imports System
Imports System.Windows.Forms
Imports System.Threading

Public Class MainForm

    Private _UserName As String
    Private MoveForm As Boolean
    Private lastGenericButton As New GunaButton
    Private firstClick As Boolean = False

    Public currentChildForm As Form
    Private GenericButton As GunaButton
    Private ButtonWasSelected As GunaButton
    Private MoveForm_MousePosition As Point

    Public _OpenedChat As Integer

    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Private _Subject As New Subject
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure
    Public _ControlChildForm As New ControlChildForm

    Public _ListOfUserFriendsPanel As New List(Of FriendsChatPanel)
    Public _ListOfUserFriendsOnline As New List(Of FriendsPanel)

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

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        SetStyle_For_Components()
    End Sub


    Sub New(userName As String)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
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
        Create_ListOfFriendsOnline()
    End Sub

    Public Sub Form_style()
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(PanelListOfFriends, FriendScrollBar, True)
        vScrollHelper.UpdateScrollBar()

        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlFriendsOnlineNow, OnlineFriendScrollBar, True)
        vScrollHelper.UpdateScrollBar()

        FriendScrollBar.BringToFront()
        LeftButtomPanel.Visible = True

        UserPicture.SendToBack()
        ButtonWasSelected = btnHomeChat

        FormBorderStyle = FormBorderStyle.Sizable
        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

        Me.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        TopPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColor))
        LeftButtomPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColor))
    End Sub

    Private Sub Create_ListOfFriends()
        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            pnlFriend.Dispose()

            Dim x = 0, y = 0, count = 1

            Dim ListOfsbjFriends As List(Of Subject_Friends) = Subject_Friends.Get_SubjectFriends_ByID(_Subject.SUBJECT_ID)

            If ListOfsbjFriends IsNot Nothing Then
                For i As Integer = 0 To ListOfsbjFriends.Count - 1

                    If ListOfsbjFriends.Item(i).HAVE_CHAT.Equals("Yes") Then
                        Dim locationOfFriendPanel As Point = New Point(x, y)
                        Dim pnl As New Panel

                        Dim friendPanel As New FriendsChatPanel(Me, locationOfFriendPanel, FriendScrollBar, (count).ToString _
                                                            , ListOfsbjFriends.Item(i).FRIENDS_PICTURE, ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                                            , ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)
                        y += 60
                        count += 1

                        _ListOfUserFriendsPanel.Add(friendPanel)
                        PanelListOfFriends.Controls.Add(friendPanel._UserPanel)
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Create_ListOfFriendsOnline()

        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            pnlOfFriendOnlineNow.Dispose()

            Dim x = 0, y = 0, count = 1

            Dim ListOfsbjFriends As List(Of Subject_Friends) = Subject_Friends.Get_SubjectFriends_ByID(_Subject.SUBJECT_ID)

            If ListOfsbjFriends IsNot Nothing Then
                For i As Integer = 0 To ListOfsbjFriends.Count - 1

                    If ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE.Equals("Online") Then
                        Dim locationOfFriendPanel As Point = New Point(x, y)
                        Dim pnl As New Panel

                        Dim friendsPanelOnline As New FriendsPanel(Me, locationOfFriendPanel, FriendScrollBar, (count).ToString _
                                                            , ListOfsbjFriends.Item(i).FRIENDS_PICTURE, ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                                            , ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)
                        y += 62
                        count += 1

                        _ListOfUserFriendsOnline.Add(friendsPanelOnline)
                        pnlFriendsOnlineNow.Controls.Add(friendsPanelOnline._UserPanel)
                    End If
                Next
            End If
        End If

        lblFriendsOnlineNow.Text += " " + (_ListOfUserFriendsOnline.Count()).ToString
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

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
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
        MoveForm = True
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
        If MoveForm Then
            MoveForm = False
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
            MoveForm = False
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
    End Sub
    '*****///// END MOVE RESIZE FORM

    '*****///// BUTTON OPEN SETTINGS FORM
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        LeftButtomPanel.Visible = False
        Dim settingsForm As New SettingsForm(lblUserName.Text)
        _ControlChildForm.OpenChildForm(settingsForm, MainPanel, currentChildForm)
    End Sub

    '*****///// END BUTTON OPEN SETTINGS FORM

    '*****///// MOUSE HOVER AND CLICK ON BUTTONS UI
    Private Sub Mouse_Hover_Buttons(sender As System.Object, e As System.EventArgs) _
      Handles btnHomeChat.MouseEnter, btnPersonalBlog.MouseEnter, btnVideo.MouseEnter, btnMusic.MouseEnter, btnGames.MouseEnter

        GenericButton = DirectCast(sender, GunaButton)

        _Utility_Style.Select_Btn_UI(selectedPoint, New Point(selectedPoint.Location.X, GenericButton.Location.Y + 18))
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
    End Sub
    '*****///// END MOUSE HOVER AND CLICK ON BUTTONS UI

    '*****///// FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL
    Private Sub On_Click_LeftPanel_Buttons(sender As System.Object, e As System.EventArgs) _
      Handles btnHomeChat.Click, btnPersonalBlog.Click, btnVideo.Click, btnMusic.Click, btnGames.Click
        ButtonWasSelected.Radius = 25

        GenericButton = DirectCast(sender, GunaButton)

        Onclick_OpenChildForm_LeftPanel(GenericButton.Name)

        _Utility_Style.Select_Btn_UI(selectedPoint, New Point(selectedPoint.Location.X, GenericButton.Location.Y + 18))
        _Utility_Style.Selected_Btn_Cliked_UI(clikedPoint, GenericButton)
        ButtonWasSelected = GenericButton
    End Sub

    Private Sub Onclick_OpenChildForm_LeftPanel(buttonName As String)
        Select Case buttonName
            Case "btnPersonalBlog"
                Dim persinalBlogForm As New PersonalBlogForm
                _ControlChildForm.OpenChildForm(persinalBlogForm, PlayGroundPanel, currentChildForm)

            Case "btnGames"
                Dim gameForm As New GameForm
                _ControlChildForm.OpenChildForm(gameForm, PlayGroundPanel, currentChildForm)

            Case "btnMusic"
                Dim musicForm As New MusicForm
                _ControlChildForm.OpenChildForm(musicForm, PlayGroundPanel, currentChildForm)

            Case "btnVideo"
                Dim videoForm As New VideoForm
                _ControlChildForm.OpenChildForm(videoForm, PlayGroundPanel, currentChildForm)

            Case "btnHomeChat"
                If currentChildForm IsNot Nothing Then
                    currentChildForm.Close()
                End If
        End Select
    End Sub
    '*****///// END FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL

    '*****///// FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL
    Private Sub On_Click_UpperPanel_FriendPanel_Button(sender As System.Object, e As System.EventArgs) _
      Handles btnFriendsOnile.Click, btnAllFrineds.Click, btnBlockedFriends.Click, btnAddNewFriends.Click

        If Not lastGenericButton.Name.Equals("btnAddNewFriends") Then
            Change_lastGenericButton()
        End If

        GenericButton = DirectCast(sender, GunaButton)

        If firstClick Then
            lastGenericButton = GenericButton
        Else
            lastGenericButton = btnFriendsOnile

            Change_lastGenericButton()

            lastGenericButton = GenericButton
            firstClick = True
        End If


        If Not lastGenericButton.Name.Equals("btnAddNewFriends") Then
            GenericButton.BaseColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
            GenericButton.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
        End If

        Onclick_OpenChildForm_FriendPanels(GenericButton.Name)
    End Sub

    Private Sub Change_lastGenericButton()
        lastGenericButton.BaseColor = Color.Transparent
        lastGenericButton.ForeColor = Color.DarkGray
    End Sub

    Private Sub Onclick_OpenChildForm_FriendPanels(buttonName As String)
        Select Case buttonName
            Case "btnAllFrineds"
                Dim allFriendsForm As New AllFriendsForm
                _ControlChildForm.OpenChildForm(allFriendsForm, FriendsPanelChild, currentChildForm)

            Case "btnBlockedFriends"
                Dim blockedFriendsForm As New BlockedFriendsForm
                _ControlChildForm.OpenChildForm(blockedFriendsForm, FriendsPanelChild, currentChildForm)

            Case "btnAddNewFriends"
                Dim addNewFriendsForm As New AddFriendForm
                _ControlChildForm.OpenChildForm(addNewFriendsForm, FriendsPanelChild, currentChildForm)

            Case "btnFriendsOnile"
                If currentChildForm IsNot Nothing Then
                    currentChildForm.Close()
                End If
        End Select
    End Sub
    '*****///// END FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL

    '*****///// ON SCROLL FRIENDSLIST TO NOT SEE MILTIPLE SELECTED FIRENDS
    Private Sub FriendScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles FriendScrollBar.Scroll
        For i As Integer = 0 To _ListOfUserFriendsPanel.Count - 1
            _ListOfUserFriendsPanel.Item(i).Leave_ListOfFriend()
        Next
    End Sub

    Public Sub txtFindFriends_Leave(sender As Object, e As EventArgs) Handles txtFindFriends.Leave
        txtFindFriends.Text = "Find Your Friends"
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

            For Each pnl In _ListOfUserFriendsPanel
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
        For Each pnl In _ListOfUserFriendsPanel
            pnl._UserPanel.Visible = state
        Next
    End Sub
End Class