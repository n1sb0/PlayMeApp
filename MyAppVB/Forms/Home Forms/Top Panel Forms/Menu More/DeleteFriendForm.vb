Public Class DeleteFriendForm

    Private _strBy As String

    Private _Subject As Subject
    Private _SubjFriend As Subject

    Private _MainForm As HomeForm

    Sub New(subject As Subject, subjFriend As Subject, ByRef mForm As HomeForm, strBy As String)
        InitializeComponent()

        _strBy = strBy
        _MainForm = mForm
        _Subject = subject
        _SubjFriend = subjFriend
        _MainForm._DeleteFriendForm = Me

        Select Case _strBy
            Case "Block"
                Style_Form_To_Block()

            Case "Delete"
                Style_Form_To_Delete()
        End Select
    End Sub

    Private Sub Style_Form_To_Delete()
        btnDeleteFriend.Text = "Remove Friend"
        lblRemoveName.Text = "REMOVE " + _SubjFriend.SUBJECT_USERNAME + "?"
        lblMsgToDeleteUser.Text += "remove " + _SubjFriend.SUBJECT_USERNAME + " from your friends?"
    End Sub

    Private Sub Style_Form_To_Block()
        btnDeleteFriend.Text = "Block Friend"
        lblRemoveName.Text = "BLOCK " + _SubjFriend.SUBJECT_USERNAME + "?"
        lblMsgToDeleteUser.Text = "Are you sure you want to block " + _SubjFriend.SUBJECT_USERNAME + "? Blocking this user will also remove them form your firends list."
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close_Delete_Friend_Form()
    End Sub

    Private Sub btnDeleteFriend_Click(sender As Object, e As EventArgs) Handles btnDeleteFriend.Click

        If _MainForm._CurrentChildForm.Name.Equals("OnlineFriendsForm") _
            OrElse _MainForm._CurrentChildForm.Name.Equals("AllFriendsForm") Then

            Dim friendObj As New Subject_Friends

            If _strBy.Equals("Delete") Then
                friendObj.UpdateData_With_Transaction(_Subject.SUBJECT_ID, _SubjFriend.SUBJECT_ID, "Delete")
            Else
                friendObj.UpdateData_With_Transaction(_Subject.SUBJECT_ID, _SubjFriend.SUBJECT_ID, "Block")
            End If

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