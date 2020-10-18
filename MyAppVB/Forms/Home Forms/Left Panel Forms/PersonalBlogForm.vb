Imports Guna.UI.WinForms

Public Class PersonalBlogForm
    Private _vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Private _Subject As Subject

    Private _Utility_Style As New Utility_Style

    Private _ModOfGest As String
    Sub New(subj As Subject, modOfGest As String)
        InitializeComponent()

        _ModOfGest = modOfGest
        _Subject = subj

        Form_style()
    End Sub

    Public Sub Form_style()

        _Utility_Style.Set_UserPicture(UserPicBox, _Subject.SUBJECT_USER_PICTURE)
        lblUserName.Text = _Subject.SUBJECT_USERNAME

        Select Case _ModOfGest
            Case "Subject"
                btnEdit.Text = "Edit"

            Case "Friend"
                btnEdit.Text = "Message"
                FeedPanel.Controls.Remove(CreatePostPanel)

                post1.Location = New Point(post1.Location.X, post1.Location.Y - 60)

        End Select

        _vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FeedPanel, FeedScrollBar, True)
        _vScrollHelper.UpdateScrollBar()
    End Sub

End Class