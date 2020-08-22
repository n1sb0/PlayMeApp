Public Class DeleteFriendForm
    Private _Subject As Subject
    Private _SubjFriend As Subject

    Sub New(subject As Subject, subjFriend As Subject)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        _Subject = subject
        _SubjFriend = subjFriend

        Style_From()
    End Sub

    Private Sub Style_From()
        lblRemoveName.Text &= " " + _SubjFriend.SUBJECT_USERNAME
        lblMsgToDeleteUser.Text += " " + _SubjFriend.SUBJECT_USERNAME + " from your friends?"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
        HomeForm.TransparentBackGround.Visible = False
    End Sub

    Private Sub btnDeleteFriend_Click(sender As Object, e As EventArgs) Handles btnDeleteFriend.Click

    End Sub
End Class