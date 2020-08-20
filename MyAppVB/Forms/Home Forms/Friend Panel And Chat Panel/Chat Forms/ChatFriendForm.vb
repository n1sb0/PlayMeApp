Imports FontAwesome.Sharp

Public Class ChatFriendForm
    '*****///// VARS
    Private _MsgText As String
    Public _MsgToUser As String
    Public _StateOnline As String
    Private _LocX, _LocY As Integer
    Private _PopUpmsgForm As PopUpMessageForm
    Private _ShowPopUpMsg As New Show_PopUpMessageForm(Me)

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

    End Sub

    Private Sub ChatFriendForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFriendName.Text = _MsgToUser
        txtMessage.Text = "MESSEGE @" + _MsgToUser

        Set_StateOnline()
    End Sub

    Private Sub Set_StateOnline()
        lblStateOnlineOfFriend.Location = New Point(lblFriendName.Location.X + lblFriendName.Width, lblStateOnlineOfFriend.Location.Y)

        _Utility_Style.Set_UserStateOnline(lblStateOnlineOfFriend, _StateOnline)

    End Sub

    Private Sub pnlMessage_Paint(sender As Object, e As PaintEventArgs) Handles pnlMessage.Paint
        Dim rbp As New RadiusBorderPanel

        rbp.On_Panel_Paint(sender, e, pnlMessage, 20)
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

    Private Sub On_Buttons_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnCall.MouseLeave, btnVideoCall.MouseLeave, btnAddFriendToChat.MouseLeave, btnHelp.MouseLeave

        _IconPic = DirectCast(sender, IconPictureBox)

        _IconPic.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_WhiteCOlor))

        _ShowPopUpMsg.Open_MessageForm()
    End Sub

End Class