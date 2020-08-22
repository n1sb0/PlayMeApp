Public Class OnlineFriendsForm
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper

    Public _Subject As Subject
    Private _MainForm As HomeForm
    Public _ListOfUserFriendsOnline As New List(Of OnlineAndAllFriendsPanel)
    Sub New(subject As Subject, ByRef mform As HomeForm)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        _Subject = subject
        _MainForm = mform
        Create_AllFriends()
    End Sub

    Private Sub Create_AllFriends()
        Dim createListOfPanels As New Create_ListOf_Panels(_Subject, OnlineFriendScrollBar, Me, 61, "Online", _ListOfUserFriendsOnline, pnlFriendsOnlineNow, _MainForm)

        createListOfPanels.Create_ListOfPanels()

        lblFriendsOnlineNow.Text += " " + (_ListOfUserFriendsOnline.Count()).ToString
    End Sub

    Private Sub AllFriendsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlFriendsOnlineNow, OnlineFriendScrollBar, True)
        vScrollHelper.UpdateScrollBar()

        If _ListOfUserFriendsOnline.Count = 0 Then
            pnlImgOnlineFriends.Visible = True
        Else
            pnlImgOnlineFriends.Visible = False
            pnlUnderTextOnlineFriends.Visible = True
            lblFriendsOnlineNow.Visible = True
        End If
    End Sub

    Private Sub OnlineFriendsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        pnlFriendsOnlineNow.Visible = True
    End Sub

End Class