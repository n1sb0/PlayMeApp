Public Class AddFriendForm

    Private _SeccessMsgRequest As String = "Success! Your friend request to "
    Private _StartMsg As String = "You can add a friend with thair Name. Be careful to write the Name in right way!"
    Private _ErroreMsgShortName As String = "Hm, didn't work. Double check that the NAME contains at least 4 characters."
    Private _ErroreMsgNotFoundName As String = "Hm, didn't work. Double check that the capitalization, spelling, any spaces, and numbers are correct."

    Private _Utility_Style As New Utility_Style
    Private _RedColor As String = _Utility_Style.RedColor
    Private _WhiteColor As String = _Utility_Style.WhiteColor
    Private _GreenColor As String = _Utility_Style.GreenColor

    Private _Subject As New Subject
    Private _Friend As New Subject

    Sub New(ByRef subject As Subject)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        _Subject = subject
    End Sub

    Private Sub txtFindFriend_TextChanged(sender As Object, e As EventArgs) Handles txtFindFriend.TextChanged

        If lblMsgAddFriend.Text.Equals(_ErroreMsgShortName) OrElse lblMsgAddFriend.Text.Equals(_ErroreMsgNotFoundName) _
            OrElse lblMsgAddFriend.Text.Equals(_SeccessMsgRequest) Then

            lblMsgAddFriend.Text = _StartMsg
            lblMsgAddFriend.ForeColor = Color.Silver
        End If

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

        If txtFindFriend.Text.Length >= 4 Then
            If DR_Subject.Get_Subject_By("username", txtFindFriend.Text) Then
                _Friend = Subject.Get_Subject_Data(txtFindFriend.Text)

                _Subject.Insert_Pending_Request(_Friend.SUBJECT_ID)

                lblMsgAddFriend.Text = _SeccessMsgRequest + txtFindFriend.Text + " was sent."
                lblMsgAddFriend.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GreenColor))
            Else
                lblMsgAddFriend.Text = _ErroreMsgNotFoundName
                lblMsgAddFriend.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
            End If
        Else
            lblMsgAddFriend.Text = _ErroreMsgShortName
            lblMsgAddFriend.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        End If

    End Sub

    Private Sub FindFriendPanel_Paint(sender As Object, e As PaintEventArgs) Handles FindFriendPanel.Paint
        Dim rbp As New RadiusBorderPanel

        rbp.On_Panel_Paint(sender, e, FindFriendPanel)
    End Sub
End Class