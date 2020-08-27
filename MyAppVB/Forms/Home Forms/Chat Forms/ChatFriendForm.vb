Imports FontAwesome.Sharp

Public Class ChatFriendForm
    '*****///// VARS
    Private _MsgText As String
    Public _MsgToUser As String
    Public _StateOnline As String
    Private _LocX, _LocY As Integer
    Private _PopUpmsgForm As PopUpMessageForm
    Private _ShowPopUpMsg As New Open_PopUpForm(Me)
    Private _keyPressed As Integer
    Private _PaintPanelBool As Boolean = False
    Private _NumOfLine As Integer = 1
    Private _vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private _pnlMsgHeight As Integer
    Private _pnlMsgLoc As Point

    '*****///// CLASSES
    Private _Utility_Style As New Utility_Style

    '*****///// COMPONENTS
    Private _IconPic As New IconPictureBox

    '*****///// COLORS
    Private _GreenColor As String = "#2ecc71"
    Private _WhiteCOlor As String = _Utility_Style.WhiteColor

    Sub New()

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()


        _vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(MainChatPanel, ChatScrollBar, True)
        _vScrollHelper.UpdateScrollBar()


        Form_style()
    End Sub

    Private Sub Form_style()

        txtMessage.ScrollBars = RichTextBoxScrollBars.None
        _pnlMsgHeight = pnlMessage.Height
        _pnlMsgLoc = pnlMessage.Location
    End Sub

    Private Sub ChatFriendForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFriendName.Text = _MsgToUser
        lblTextMsg.Text = "MESSEGE @" + _MsgToUser

        Set_StateOnline()
    End Sub

    Private Sub Set_StateOnline()
        lblStateOnlineOfFriend.Location = New Point(lblFriendName.Location.X + lblFriendName.Width, lblStateOnlineOfFriend.Location.Y)

        _Utility_Style.Set_UserStateOnline(lblStateOnlineOfFriend, _StateOnline)

    End Sub

    Private Sub On_Buttons_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnCall.MouseEnter, btnVideoCall.MouseEnter, btnAddFriendToChat.MouseEnter, btnHelp.MouseEnter

        _IconPic = DirectCast(sender, IconPictureBox)

        _IconPic.ForeColor = Color.White

        Select Case _IconPic.Name
            Case "btnCall"
                _MsgText = "Strat Voice Call"

            Case "btnVideoCall"
                _MsgText = "Strat Video Call"

            Case "btnAddFriendToChat"
                _MsgText = "Add Friend to DM"

            Case "btnHelp"
                _MsgText = "Help"
        End Select

        _LocX = _IconPic.Location.X + _IconPic.Width / 2
        _LocY = _IconPic.Location.Y + 35

        _ShowPopUpMsg.Open_MessageForm(_MsgText, _LocX, _LocY)
    End Sub

    Private txtSize As Size
    Private _textChanged As Boolean

    Private Sub Active_DisActive_TextBox(state As Boolean)
        lblTextMsg.Visible = state
        btnSentMsg.Enabled = Not state

        If btnSentMsg.Enabled Then
            btnSentMsg.IconColor = Color.FromArgb(255, ColorTranslator.FromHtml(_WhiteCOlor))
        Else
            btnSentMsg.IconColor = Color.DimGray
        End If
    End Sub

    Private Sub btnSentMsg_Click(sender As Object, e As EventArgs) Handles btnSentMsg.Click
        Debug.WriteLine("Message was sent")
    End Sub

    Private Sub txtMessage_TextChanged(sender As Object, e As EventArgs) Handles txtMessage.TextChanged
        If String.IsNullOrEmpty(txtMessage.Text) Then
            pnlMessage.Location = _pnlMsgLoc
            Active_DisActive_TextBox(True)
        Else
            Active_DisActive_TextBox(False)
        End If
    End Sub

    Private Sub txtMessage_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles txtMessage.ContentsResized
        txtMessage.Height = e.NewRectangle.Height + 5
        pnlMessage.Height = e.NewRectangle.Height + 20

    End Sub

    Private Sub pnlMessage_SizeChanged() Handles pnlMessage.SizeChanged

        If _pnlMsgHeight <> pnlMessage.Height Then
            If _pnlMsgHeight > pnlMessage.Height Then
                MainChatPanel.Height += 20
                pnlMessage.Location = New Point(15, pnlMessage.Location.Y + 20)
            Else
                MainChatPanel.Height -= 20
                pnlMessage.Location = New Point(15, pnlMessage.Location.Y - 20)
            End If

            _pnlMsgHeight = pnlMessage.Height
        End If
    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        _keyPressed = e.KeyCode

        If _keyPressed = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSentMsg_Click(Me, New EventArgs())
            txtMessage.Text = String.Empty
        End If
    End Sub

    Private Sub pnlMessage_Resize(sender As Object, e As EventArgs) Handles pnlMessage.Resize

        'MainMessagesPanel.Height -= 20
    End Sub

    Private Sub On_Buttons_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnCall.MouseLeave, btnVideoCall.MouseLeave, btnAddFriendToChat.MouseLeave, btnHelp.MouseLeave

        _IconPic = DirectCast(sender, IconPictureBox)

        _IconPic.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_WhiteCOlor))

        _ShowPopUpMsg.Open_MessageForm()
    End Sub

End Class