Public Class CreateDMForm
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private _MainForm As New MainForm
    Private _Subject As Subject
    Public _ListOfUserDmFriendsPanel As New List(Of DmFriendsPanel)

    Sub New(ByRef mForm As MainForm, ByRef subject As Subject)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        _MainForm = mForm
        _Subject = subject
        Create_All_DM_Friends()

        Style_Form()
    End Sub

    Private Sub Style_Form()
    End Sub

    Private Sub Create_All_DM_Friends()
        Dim createListOfPanels As New Create_ListOf_Panels(_Subject, dmFriendScrollBar, Me, 50, "DM", _ListOfUserDmFriendsPanel, pnlOfFriends)

        createListOfPanels.Create_ListOfPanels()
    End Sub

    Private Sub CreateDMForm_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.LostFocus
        _MainForm.btnNewDirect.IconColor = Color.Silver
        _MainForm.btnNewDirect.Rotation = 0

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub CreateDM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlOfFriends, dmFriendScrollBar, True)
        vScrollHelper.UpdateScrollBar()
    End Sub
End Class