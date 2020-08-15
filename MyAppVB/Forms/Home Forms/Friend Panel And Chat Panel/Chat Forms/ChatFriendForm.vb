Public Class ChatFriendForm
    '*****///// VARS
    Public _MsgToUser As String
    Public _StateOnline As String

    '*****///// CLASSES
    Private _Utility_Style As New Utility_Style

    '*****///// COLORS
    Private _GreenColor As String = "#2ecc71"

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
End Class