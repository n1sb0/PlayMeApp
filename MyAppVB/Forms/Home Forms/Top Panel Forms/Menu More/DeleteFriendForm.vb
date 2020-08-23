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
        Close_Delete_Friend_Form()
    End Sub

    Private Sub btnDeleteFriend_Click(sender As Object, e As EventArgs) Handles btnDeleteFriend.Click

        If HomeForm._CurrentChildForm.Name.Equals("OnlineFriendsForm") _
            OrElse HomeForm._CurrentChildForm.Name.Equals("AllFriendsForm") Then

            Dim strQuery As String = MyConnection.Delete_From_FriendList()
            Subject_Friends.Delete_Reference_OfTwoFriends(_Subject.SUBJECT_ID, _SubjFriend.SUBJECT_ID, strQuery)

            If Application.OpenForms().OfType(Of OnlineFriendsForm).Any Then
                HomeForm.Onclick_OpenChildForm_FriendPanels("OnlineFriendsForm")
            Else
                HomeForm.Onclick_OpenChildForm_FriendPanels("AllFriendsForm")
            End If
        End If

        Close_Delete_Friend_Form()
    End Sub

    Private Sub Close_Delete_Friend_Form()
        Close()
        HomeForm.TransparentBackGround.Visible = False
    End Sub
End Class