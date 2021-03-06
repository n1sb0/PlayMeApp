﻿Imports FontAwesome.Sharp

Public Class ChatFriendForm
    '*****///// VARS
    Private _Subject As Subject
    Private _SubjectFriend As Subject
    Private _MsgText As String
    Public _MsgToUser As String
    Private _pnlMsgLoc As Point
    Public _StateOnline As String
    Private _LocX, _LocY As Integer
    Private _pnlMsgHeight As Integer
    Private _keyPressed As KeyEventArgs
    Private _NewHeightMsgPnl As Integer
    Private _OldHeightMsgPnl As Integer = 40
    Public _ListOfMessagePanel As New List(Of MessagePanel)
    Private _vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    '*****///// CLASSES
    Private _PopUpmsgForm As PopUpMessageForm
    Private _Utility_Style As New Utility_Style
    Private _Utility_OpenForm As New Utility_OpenForm

    '*****///// COMPONENTS
    Private _IconPic As New IconPictureBox

    '*****///// COLORS
    Private _GreenColor As String = "#2ecc71"
    Private _WhiteCOlor As String = _Utility_Style.WhiteColor

    '*****////// FORMS
    Private _MainForm As HomeForm
    Private _RightClickMenuForm As RightClickMenuForm

    '*****///// SUB NEW
    Sub New(ByRef subj As Subject, ByRef mform As HomeForm, ByRef subjF As Subject, userName As String, userStateOnline As String)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        _Subject = subj
        _MainForm = mform
        _SubjectFriend = subjF
        _MsgToUser = userName
        _StateOnline = userStateOnline


        Form_style()
    End Sub

    '*****///// FORM STYLE
    Private Sub Form_style()

        _vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(MainChatPanel, ChatScrollBar, True)
        _vScrollHelper.UpdateScrollBar()

        'txtMessage.ScrollBars = RichTextBoxScrollBars.None
        _pnlMsgHeight = pnlMessage.Height
    End Sub

    '*****///// ON LOAD FORM
    Private Sub ChatFriendForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFriendName.Text = _MsgToUser
        lblTextMsg.Text = "MESSEGE @" + _MsgToUser

        Set_StateOnline()

        Dim positionOflblOnline As New Point(lblFriendName.Location.X + lblFriendName.Width + 5, lblStateOnlineOfFriend.Location.Y)
        lblStateOnlineOfFriend.Location = New Point(positionOflblOnline)
    End Sub

    '*****///// STATE ONLINE OF PERSONE WITH WHO CHAT 
    Private Sub Set_StateOnline()
        lblStateOnlineOfFriend.Location = New Point(lblFriendName.Location.X + lblFriendName.Width, lblStateOnlineOfFriend.Location.Y)

        _Utility_Style.Set_UserStateOnline(lblStateOnlineOfFriend, _StateOnline)
    End Sub

    '*****///// MOUSE ENTER UPPER PANEL (POP UP MSG)
    Private Sub On_Buttons_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnCall.MouseEnter, btnVideoCall.MouseEnter, btnAddFriendToChat.MouseEnter, btnHelp.MouseEnter, btnAddFiles.MouseEnter

        _IconPic = DirectCast(sender, IconPictureBox)

        _IconPic.ForeColor = Color.White

        _LocX = _IconPic.Location.X + _IconPic.Width / 2
        _LocY = _IconPic.Location.Y + 35

        Select Case _IconPic.Name
            Case "btnCall"
                _MsgText = "Strat Voice Call"

            Case "btnVideoCall"
                _MsgText = "Strat Video Call"

            Case "btnAddFriendToChat"
                _MsgText = "Add Friend to DM"

            Case "btnHelp"
                _MsgText = "Help"

            Case "btnAddFiles"
                _MsgText = "Add File"
                _LocX = 30 + _IconPic.Width / 2
                _LocY = Me.Height - 80
        End Select

        _Utility_OpenForm.Open_PopUpMsgForm(Me, _MsgText, _LocX, _LocY)
    End Sub

    '*****///// ON MOUSE LEAVE UPPER PANEL (POP UP MSG)
    Private Sub On_Buttons_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnCall.MouseLeave, btnVideoCall.MouseLeave, btnAddFriendToChat.MouseLeave, btnHelp.MouseLeave, btnAddFiles.MouseLeave

        _IconPic = DirectCast(sender, IconPictureBox)

        _IconPic.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_WhiteCOlor))

        _Utility_OpenForm.Open_PopUpMsgForm(Me)
    End Sub

    '*****///// STATE OF TEXT BOX
    Private Sub Active_DisActive_TextBox(state As Boolean)
        lblTextMsg.Visible = state
        btnSentMsg.Enabled = Not state

        If btnSentMsg.Enabled Then
            btnSentMsg.IconColor = Color.FromArgb(255, ColorTranslator.FromHtml(_WhiteCOlor))
        Else
            btnSentMsg.IconColor = Color.DimGray
        End If
    End Sub

    '*****///// SENT MESSAGE
    Private Sub btnSentMsg_Click(sender As Object, e As EventArgs) Handles btnSentMsg.Click
        Debug.WriteLine("Message was sent")

        My.Computer.FileSystem.WriteAllText("A:\test.txt", vbCrLf + _Subject.SUBJECT_ID.ToString + " | " + txtMessage.Text, True)

    End Sub

    '*****///// ON txtMessage TEXT CHANGED
    Private Sub txtMessage_TextChanged(sender As Object, e As EventArgs) Handles txtMessage.TextChanged
        If String.IsNullOrEmpty(txtMessage.Text) Then
            pnlMessage.Location = New Point(15, Me.Height - 60)
            Active_DisActive_TextBox(True)
            _OldHeightMsgPnl = 40
        Else
            Active_DisActive_TextBox(False)
        End If
    End Sub

    '*****///// ON CONTENTS txtMessage RESIZE
    Private Sub txtMessage_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles txtMessage.ContentsResized
        txtMessage.Height = e.NewRectangle.Height + 5

        '  If txtMessage.Height <= 100 Then
        pnlMessage.Height = e.NewRectangle.Height + 20
        ' End If
    End Sub

    '*****///// ON pnlMessage SIZE CHANGED
    Private Sub pnlMessage_SizeChanged() Handles pnlMessage.SizeChanged
        ' If txtMessage.Height <= 100 AndAlso Not String.IsNullOrEmpty(txtMessage.Text) Then
        _NewHeightMsgPnl = _OldHeightMsgPnl - pnlMessage.Height

            If _NewHeightMsgPnl < 0 Then
                _NewHeightMsgPnl *= -1
            End If

            'If _pnlMsgHeight <> pnlMessage.Height Then
            If _pnlMsgHeight > pnlMessage.Height Then
                MainChatPanel.Height += _NewHeightMsgPnl
                pnlMessage.Location = New Point(15, pnlMessage.Location.Y + _NewHeightMsgPnl)
            Else
                MainChatPanel.Height -= _NewHeightMsgPnl
                pnlMessage.Location = New Point(15, pnlMessage.Location.Y - _NewHeightMsgPnl)
            End If

            _pnlMsgHeight = pnlMessage.Height
            _OldHeightMsgPnl = pnlMessage.Height
        'End If
        'End If

    End Sub

    '*****///// ON txtMessage KEY DOWN
    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        _keyPressed = e

        If _keyPressed.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSentMsg_Click(Me, New EventArgs())
            txtMessage.Text = String.Empty
        End If
    End Sub

    Private Sub ChatFriendForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        _pnlMsgLoc = pnlMessage.Location
    End Sub


    Private Sub Mouse_Hover_Buttons(sender As System.Object, e As MouseEventArgs) _
      Handles picFriend.Click, lblFriendName.Click

        Select Case e.Button
            Case MouseButtons.Left

                'Open Person Profile form ...

            Case MouseButtons.Right

                On_RightButtonMenu_Click()
        End Select

    End Sub

    Public Sub On_RightButtonMenu_Click()
        _MainForm._FriendID = _SubjectFriend.SUBJECT_ID

        Dim _MouseLocationX = HomeForm.MousePosition.X - _MainForm.Bounds.Location.X
        Dim _MouseLocationY = HomeForm.MousePosition.Y - _MainForm.Bounds.Location.Y - 8

        If _MouseLocationX > _MainForm.Size.Width - 320 Then
            _MouseLocationX -= 170
        End If

        Open_RightClick_Menu(_MouseLocationX, _MouseLocationY)
    End Sub

    Public Sub Open_RightClick_Menu(Optional x As Integer = 0, Optional y As Integer = 0)

        If Application.OpenForms().OfType(Of RightClickMenuForm).Any Then
            RightClickMenuForm.Close()
        End If

        If Not Application.OpenForms().OfType(Of RightClickMenuForm).Any Then
            _RightClickMenuForm = New RightClickMenuForm(_Subject, _SubjectFriend, _MainForm)
            _MainForm._RightClickMenuForm = _RightClickMenuForm

            _RightClickMenuForm.TopLevel = False
            _RightClickMenuForm.Parent = _MainForm

            _RightClickMenuForm.SetBounds(x, y, 160, 190)
            _RightClickMenuForm.BringToFront()
            _RightClickMenuForm.Show()
        End If
    End Sub

    '*****///// ON pnlMessage RESIZE
    Private Sub pnlMessage_Resize(sender As Object, e As EventArgs) Handles pnlMessage.Resize
        txtMessage.Width = (CInt(btnAddSmile.Location.X) - CInt(txtMessage.Location.X)) - 5
    End Sub
End Class