Public Class AllFriendsForm

    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Private _Subject As Subject
    Public _ListOfUserFriendsAllPanel As New List(Of FriendsOnlineAndAllPanel)
    Sub New(subject As Subject)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        _Subject = subject
        Create_AllFriends()
    End Sub

    Private Sub Create_AllFriends()
        Dim createListOfPanels As New Create_ListOf_Panels(_Subject, AllFriendScrollBar, Me, 61, "All", _ListOfUserFriendsAllPanel, AllFriendsPanel)

        createListOfPanels.Create_ListOfPanels(pnlAllFriends)

        lblAllFriends.Text += " " + (_ListOfUserFriendsAllPanel.Count()).ToString
    End Sub

    Private Sub AllFriendsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(AllFriendsPanel, AllFriendScrollBar, True)
        vScrollHelper.UpdateScrollBar()
    End Sub

    Private Sub OnlineFriendsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AllFriendsPanel.Visible = True
    End Sub
End Class