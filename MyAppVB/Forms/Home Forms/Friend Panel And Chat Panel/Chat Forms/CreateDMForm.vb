Public Class CreateDMForm
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private _MainForm As New HomeForm
    Private _Subject As Subject
    Public _ListOfUserDmFriendsPanel As New List(Of DmFriendsPanel)

    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
    End Sub

    Sub New(ByRef mForm As HomeForm, ByRef subject As Subject)

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

        For i As Integer = 0 To _ListOfUserDmFriendsPanel.Count - 1
            pnlOfFriends.Controls.Remove(_ListOfUserDmFriendsPanel.Item(i)._UserPanel)
        Next

        Dim yl As Integer = 1

        _ListOfUserDmFriendsPanel.Sort(Function(x, y) x._UserName.CompareTo(y._UserName))

        For i As Integer = 0 To _ListOfUserDmFriendsPanel.Count - 1
            _ListOfUserDmFriendsPanel.Item(i)._UserPanel.Location = New Point(10, yl)
            yl += 61

            pnlOfFriends.Controls.Add(_ListOfUserDmFriendsPanel.Item(i)._UserPanel)
        Next
    End Sub

    Private Sub CreateDMForm_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub

    Private Sub pnlFindOrStartDM_Paint(sender As Object, e As PaintEventArgs) Handles pnlFindOrStartDM.Paint
        Dim rbp As New RadiusBorderPanel

        rbp.On_Panel_Paint(sender, e, pnlFindOrStartDM, 15)
    End Sub
End Class