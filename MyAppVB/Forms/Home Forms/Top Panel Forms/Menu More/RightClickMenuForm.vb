Imports Guna.UI.WinForms

Public Class RightClickMenuForm

    Private _GenericButton As GunaButton
    Private _Subject As Subject
    Private _SubjFriend As Subject
    Private _MainForm As HomeForm
    Private _ControlChildForm As New ControlChildForm
    Private _DeleteFriendForm As DeleteFriendForm
    Private _Open_DeleteBlockForm As Open_DeleteRemoveForm

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(subject As Subject, subjFriend As Subject, ByRef mForm As HomeForm)
        InitializeComponent()

        _Subject = subject
        _SubjFriend = subjFriend
        _MainForm = mForm
    End Sub

    Private Sub On_Click_UpperPanel_FriendPanel_Button(sender As System.Object, e As System.EventArgs) _
      Handles btnProfile.Click, btnMessage.Click, btnCall.Click, btnRemove.Click, btnBlock.Click

        _GenericButton = DirectCast(sender, GunaButton)

        _Open_DeleteBlockForm = New Open_DeleteRemoveForm(_Subject, _SubjFriend, _MainForm, _DeleteFriendForm)

        Select Case _GenericButton.Name
            Case "btnProfile"
                _MainForm.On_Click_LeftPanel_Buttons(Nothing, Nothing, _MainForm.btnPersonalBlog, _SubjFriend)

            Case "btnMessage"
                Dim chatform As New ChatFriendForm(_Subject, _SubjFriend, _SubjFriend.SUBJECT_USERNAME, _SubjFriend.SUBJECT_STATE_ONLINE)

                _MainForm._FriendID = _SubjFriend.SUBJECT_ID

                _ControlChildForm.OpenChildForm(chatform, _MainForm.MainChatAndFriendPanel, _MainForm._CurrentChildForm)

            Case "btnCall"

            Case "btnRemove"
                _Open_DeleteBlockForm.Open_Form("Delete")

            Case "btnBlock"
                _Open_DeleteBlockForm.Open_Form("Block")

        End Select

        Close()
    End Sub

    Private Sub RightClickMenuForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim RComp_OnPaint As New RoundComponent_OnPaint

        RComp_OnPaint.On_Paint_Forms(sender, e, Me)
    End Sub

End Class