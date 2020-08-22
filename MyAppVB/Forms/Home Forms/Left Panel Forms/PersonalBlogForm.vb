Imports Guna.UI.WinForms

Public Class PersonalBlogForm
    Private _vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        Form_style()
    End Sub

    Public Sub Form_style()
        _vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(FeedPanel, FeedScrollBar, True)
        _vScrollHelper.UpdateScrollBar()
    End Sub

End Class