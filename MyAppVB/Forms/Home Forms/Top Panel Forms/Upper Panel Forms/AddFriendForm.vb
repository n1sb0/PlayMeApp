Public Class AddFriendForm

    Private _SeccessMsgRequest As String = "Success! Your friend request to "
    Private _MsgFriendAlreadyAdded As String = "Hm, didn't work. Double check maybe this Persone "
    Private _MsgFriendIsWaiting As String = "Hm, didn't work. Double check maybe this Person "
    Private _FriendReqWasSent As String = "Hm, didn't work. Double check maybe you are already sent a Friend Request to this Person "
    Private _StartMsg As String = "You can add a friend with thair Name. Be careful to write the Name in right way!"
    Private _ErroreMsgShortName As String = "Hm, didn't work. Double check that the NAME contains at least 4 characters."
    Private _ErroreMsgNotFoundName As String = "Hm, didn't work. Double check that the capitalization, spelling, any spaces, and numbers are correct."

    Private _Utility_Style As New Utility_Style
    Private _RedColor As String = _Utility_Style.RedColor
    Private _WhiteColor As String = _Utility_Style.WhiteColor
    Private _GreenColor As String = _Utility_Style.GreenColor
    Private _OrngColor As String = _Utility_Style.OrngColor

    Private _keyPressed As Integer
    Private _PaintPanelBool As Boolean = False
    Private _Subject As New Subject
    Private _Friend As New Subject

    Sub New(ByRef subject As Subject)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        _Subject = subject
    End Sub

    Private Sub txtFindFriend_TextChanged(sender As Object, e As EventArgs) Handles txtFindFriend.TextChanged

        If Not _keyPressed = Keys.Enter Then
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
            If DR_Subject.Get_Subject_By("username", txtFindFriend.Text) AndAlso Not _Subject.SUBJECT_USERNAME.Equals(txtFindFriend.Text) Then
                _Friend = Subject.Get_Subject_Data(txtFindFriend.Text)

                Dim dr_subjFriend As New DR_Subject_Friend(_Subject.SUBJECT_ID, _Friend.SUBJECT_ID)

                If dr_subjFriend.Check_Friend_Request Then
                    Change_MSG(_FriendReqWasSent + "(" + txtFindFriend.Text + ").", _OrngColor)
                Else
                    If dr_subjFriend.Check_Friend_Request(_Friend.SUBJECT_ID, _Subject.SUBJECT_ID) Then
                        Change_MSG(_MsgFriendIsWaiting + "(" + txtFindFriend.Text + ") already in pending request list", _OrngColor)
                    Else
                        If Not dr_subjFriend.Check_Friend_List Then
                            _Subject.Insert_Pending_Request(_Friend.SUBJECT_ID)

                            Change_MSG(_SeccessMsgRequest + txtFindFriend.Text + " was sent.", _GreenColor)
                        Else
                            Change_MSG(_MsgFriendAlreadyAdded + "(" + txtFindFriend.Text + "), already in your friend list!", _OrngColor)
                        End If
                    End If
                End If
            Else
                Change_MSG(_ErroreMsgNotFoundName, _RedColor)
            End If
        Else
            Change_MSG(_ErroreMsgShortName, _RedColor)
        End If
    End Sub

    Private Sub Change_MSG(msg As String, strColor As String)
        lblMsgAddFriend.Text = msg
        lblMsgAddFriend.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(strColor))
    End Sub

    Private Sub txtFindFriend_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFindFriend.KeyDown
        _keyPressed = e.KeyCode

        If _keyPressed = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSendFriendRequest_Click(Me, New EventArgs())
        End If
    End Sub

End Class