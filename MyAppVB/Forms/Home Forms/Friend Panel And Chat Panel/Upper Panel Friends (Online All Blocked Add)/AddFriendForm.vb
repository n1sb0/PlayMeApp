Public Class AddFriendForm
    Private Sub txtFindFriend_TextChanged(sender As Object, e As EventArgs) Handles txtFindFriend.TextChanged
        If String.IsNullOrEmpty(txtFindFriend.Text) Then
            Active_DisActive_TextBox(True)
        Else
            Active_DisActive_TextBox(False)
        End If
    End Sub

    Private Sub Active_DisActive_TextBox(state As Boolean)
        lblEnterUserName.Visible = state
        btnSendFriendRequest.Enabled = Not state
    End Sub

    Private Sub btnSendFriendRequest_Click(sender As Object, e As EventArgs) Handles btnSendFriendRequest.Click

        If txtFindFriend.Text.Length > 4 Then

        Else

        End If

    End Sub
End Class