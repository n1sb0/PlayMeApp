Imports Guna.UI.WinForms

Public Class PersonalBlogForm
    Private _vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Private _Subject As Subject

    Private _Utility_Style As New Utility_Style
    Sub New(subj As Subject)
        InitializeComponent()

        _Subject = subj

        Form_style()
    End Sub

    Public Sub Form_style()

        _Utility_Style.Set_UserPicture(UserPicBox, _Subject.SUBJECT_USER_PICTURE)
        lblUserName.Text = _Subject.SUBJECT_USERNAME

        _vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FeedPanel, FeedScrollBar, True)
        _vScrollHelper.UpdateScrollBar()
    End Sub

End Class