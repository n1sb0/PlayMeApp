Public Class AllFriendsForm
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Public _Subject As Subject
    Private _MainForm As HomeForm
    Public _ListOfUserFriendsAllPanel As New List(Of OnlineAndAllFriendsPanel)
    Sub New(ByRef subject As Subject, ByRef mForm As HomeForm)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        _Subject = subject
        _MainForm = mForm
        Create_AllFriends()
    End Sub

    Private Sub Create_AllFriends()
        Dim createListOfPanels As New Create_ListOf_Panels(_Subject, AllFriendScrollBar, Me, 61, "All", _ListOfUserFriendsAllPanel, AllFriendsPanel, _MainForm)

        createListOfPanels.Create_ListOfPanels()

        lblAllFriends.Text += " " + (_ListOfUserFriendsAllPanel.Count()).ToString
    End Sub

    Private Sub AllFriendsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(AllFriendsPanel, AllFriendScrollBar, True)
        vScrollHelper.UpdateScrollBar()

        If _ListOfUserFriendsAllPanel.Count = 0 Then
            pnlImgAllFriends.Visible = True
        Else
            pnlImgAllFriends.Visible = False
            lblAllFriends.Visible = True
            pnlUnderlblAllFriends.Visible = True

            For Each pnl In _ListOfUserFriendsAllPanel
                AllFriendsPanel.Controls.Remove(pnl._UserPanel)
            Next

            Dim yl As Integer = 1

            _ListOfUserFriendsAllPanel.Sort(Function(x, y) x._UserName.CompareTo(y._UserName))

            For Each pnl In _ListOfUserFriendsAllPanel
                pnl._UserPanel.Location = New Point(10, yl)
                yl += 61

                AllFriendsPanel.Controls.Add(pnl._UserPanel)
            Next
        End If
    End Sub

    Private Sub OnlineFriendsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AllFriendsPanel.Visible = True
    End Sub

    Private Sub btnAddNewFriends_Click(sender As Object, e As EventArgs) Handles btnAddNewFriends.Click

        _MainForm.Change_lastGenericButton()

        _MainForm.Onclick_OpenChildForm_FriendPanels("btnAddNewFriends")
    End Sub
End Class