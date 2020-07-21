﻿Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices

Public Class MainForm
    Private _UserName As String
    Private MoveForm As Boolean

    Private currentChildForm As Form
    Private GenericButton As GunaButton
    Private ButtonWasSelected As GunaButton
    Private MoveForm_MousePosition As Point

    Private _Subject As New Subject
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure
    Private _ControlChildForm As New ControlChildForm

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
        SetStyle_For_Components()

        'Take UserName
        Save_UserName(userName)
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
    End Sub

    Private Sub Form_style()
        UserPicture.SendToBack()
        ButtonWasSelected = btnHomeChat

        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

        Me.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        TopPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColor))
        LeftButtomPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColor))
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
            FormBorderStyle = FormBorderStyle.Sizable
            Me.Cursor = Cursors.SizeAll

            ReleaseCapture()
            SendMessage(Me.Handle, &H112&, &HF012&, 0)
            FormBorderStyle = FormBorderStyle.None
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
            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Else
            btnMaxSizeForm.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        End If
    End Sub
    '*****///// END MOVE RESIZE FORM

    '*****///// BUTTON OPEN SETTINGS FORM
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim settingsForm As New SettingsForm(lblUserName.Text)
        _ControlChildForm.OpenChildForm(settingsForm, MainPanel, currentChildForm)
    End Sub

    '*****///// END BUTTON OPEN SETTINGS FORM

    '*****///// MOUSE HOVER AND CLICK ON BUTTONS UI
    Private Sub Mouse_Hover_Buttons(sender As System.Object, e As System.EventArgs) _
      Handles btnHomeChat.MouseHover, btnPersonalBlog.MouseHover, btnVideo.MouseHover, btnMusic.MouseHover, btnGames.MouseHover

        GenericButton = DirectCast(sender, GunaButton)

        _Utility_Style.Select_Btn_UI(selectedPoint, New Point(selectedPoint.Location.X, GenericButton.Location.Y + 18))
    End Sub

    Private Sub On_Click_Buttons(sender As System.Object, e As System.EventArgs) _
      Handles btnHomeChat.Click, btnPersonalBlog.Click, btnVideo.Click, btnMusic.Click, btnGames.Click
        ButtonWasSelected.Radius = 25

        GenericButton = DirectCast(sender, GunaButton)

        Onclick_OpenForm(GenericButton.Name)

        _Utility_Style.Select_Btn_UI(selectedPoint, New Point(selectedPoint.Location.X, GenericButton.Location.Y + 18))
        _Utility_Style.Selected_Btn_Cliked_UI(clikedPoint, GenericButton)
        ButtonWasSelected = GenericButton
    End Sub
    '*****///// END MOUSE HOVER AND CLICK ON BUTTONS UI

    '*****///// FUNCTION TO OPEN OTHER FORMS ON LEFT MAIN PANEL
    Private Sub Onclick_OpenForm(buttonName As String)
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

    Private Sub pnlFriend_MouseHover(sender As Object, e As EventArgs) Handles pnlFriend.MouseHover
        pnlFriend.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub pnlFriend_MouseLeave(sender As Object, e As EventArgs) Handles pnlFriend.MouseLeave
        pnlFriend.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColorLightDarkBlue))
    End Sub
End Class