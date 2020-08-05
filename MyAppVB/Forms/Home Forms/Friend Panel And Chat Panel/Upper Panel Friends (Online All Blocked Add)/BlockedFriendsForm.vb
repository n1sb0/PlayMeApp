Public Class BlockedFriendsForm
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Private _Subject As New Subject
    Public _ListOfUserBlockedFriendsPanel As New List(Of BlockedFriendsPanel)

    Sub New(subject As Subject)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        _Subject = subject
        Create_AllFriends()
    End Sub

    Private Sub Create_AllFriends()
        Dim createListOfPanels As New Create_ListOf_Panels(_Subject, BlockedFriendScrollBar, Me, 61, "Blocked", _ListOfUserBlockedFriendsPanel, BlockedFriendsPanel)

        createListOfPanels.Create_ListOfPanels()

        lblBlocekdFriends.Text += " " + (_ListOfUserBlockedFriendsPanel.Count()).ToString
    End Sub

    Private Sub AllFriendsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(BlockedFriendsPanel, BlockedFriendScrollBar, True)
        vScrollHelper.UpdateScrollBar()
    End Sub


End Class