Public Class DeleteFriendForm
    Private _Subject As Subject
    Private _SubjFriend As Subject
    Private _MainForm As HomeForm

    Sub New(subject As Subject, subjFriend As Subject, ByRef mForm As HomeForm)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        _MainForm = mForm
        _Subject = subject
        _SubjFriend = subjFriend

        Style_From()
    End Sub

    Private Sub Style_From()
        _MainForm._DeleteFriendForm = Me

        lblRemoveName.Text &= " " + _SubjFriend.SUBJECT_USERNAME
        lblMsgToDeleteUser.Text += " " + _SubjFriend.SUBJECT_USERNAME + " from your friends?"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close_Delete_Friend_Form()
    End Sub

    Private Sub btnDeleteFriend_Click(sender As Object, e As EventArgs) Handles btnDeleteFriend.Click

        If _MainForm._CurrentChildForm.Name.Equals("OnlineFriendsForm") _
            OrElse _MainForm._CurrentChildForm.Name.Equals("AllFriendsForm") Then

            Dim friendObj As New Subject_Friends

            friendObj.UpdateData_With_Transaction(_Subject.SUBJECT_ID, _SubjFriend.SUBJECT_ID, "Delete")

            If Application.OpenForms().OfType(Of OnlineFriendsForm).Any Then
                _MainForm.Onclick_OpenChildForm_FriendPanels("OnlineFriendsForm")
            Else
                _MainForm.Onclick_OpenChildForm_FriendPanels("AllFriendsForm")
            End If
        End If

        Close_Delete_Friend_Form()
    End Sub

    Private Sub Close_Delete_Friend_Form()
        _MainForm.TransparentBackGround.Visible = False
        Close()
    End Sub
End Class