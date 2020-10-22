Public Class Open_DeleteRemoveForm

    Private _Subject As Subject
    Private _SubjFriend As Subject

    Private _MainForm As HomeForm
    Private _DeleteFriendForm As DeleteFriendForm

    Sub New(subj As Subject, subjfr As Subject, hform As HomeForm, dform As DeleteFriendForm)

        _Subject = subj
        _SubjFriend = subjfr
        _MainForm = hform
        _DeleteFriendForm = dform

    End Sub

    Public Sub Open_Form(str As String)
        If Not Application.OpenForms().OfType(Of DeleteFriendForm).Any Then
            _MainForm.TransparentBackGround.Size = _MainForm.MainPanel.Size
            _MainForm.TransparentBackGround.Location = New Point(0, 0)
            _MainForm.TransparentBackGround.Visible = True
            _DeleteFriendForm = New DeleteFriendForm(_Subject, _SubjFriend, _MainForm, str)

            _DeleteFriendForm.TopLevel = False
            _DeleteFriendForm.Parent = _MainForm

            _DeleteFriendForm.SetBounds(_MainForm.Width / 2 - 175, _MainForm.Height / 2 - 150, 400, 200)
            _DeleteFriendForm.BringToFront()
            _DeleteFriendForm.Show()

            _MainForm._DeleteFriendForm = _DeleteFriendForm
        End If
    End Sub

End Class
