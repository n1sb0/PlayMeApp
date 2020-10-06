Public Class CreateDMForm
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private _MainForm As New HomeForm
    Private _Subject As Subject
    Public _ListOfUserDmFriendsPanel As New List(Of DmFriendsPanel)
    Public createListOfPanels As New Create_ListOf_Panels

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
        createListOfPanels = New Create_ListOf_Panels(_Subject, dmFriendScrollBar, Me, 50, "DM", _ListOfUserDmFriendsPanel, pnlOfFriends)

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

        For Each pnl In _ListOfUserDmFriendsPanel
            pnlOfFriends.Controls.Remove(pnl._UserPanel)
        Next

        Dim yl As Integer = 1

        _ListOfUserDmFriendsPanel.Sort(Function(x, y) x._UserName.CompareTo(y._UserName))

        For Each pnl In _ListOfUserDmFriendsPanel
            pnl._UserPanel.Location = New Point(10, yl)
            yl += 61

            pnlOfFriends.Controls.Add(pnl._UserPanel)
        Next
    End Sub

    Private Sub CreateDMForm_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        Me.Close()
    End Sub

    Private Sub pnlFindOrStartDM_Paint(sender As Object, e As PaintEventArgs) Handles pnlFindOrStartDM.Paint
        Dim rbp As New RadiusBorderPanel

        rbp.On_Panel_Paint(sender, e, pnlFindOrStartDM, 15)
    End Sub

    Private Sub btnCreateGruopDM_Click(sender As Object, e As EventArgs) Handles btnCreateGruopDM.Click
        Dim subjF As New Subject_Friends
        Dim subj As Subject
        Dim _NameOfUserChat As String = ""

        subjF.USER_ID = _Subject.SUBJECT_ID

        For Each item In _ListOfUserDmFriendsPanel
            If item._Cheked Then
                subj = Subject.Get_Subject_Data_By(item._UserName)
                _NameOfUserChat = item._UserName
                subjF.FRIEND_ID = subj.SUBJECT_ID
                subj.ClearObj()
            End If
        Next

        Dim dr_subjFriend As New DR_Subject_Friend(subjF.USER_ID, subjF.FRIEND_ID, MyConnection.Get_Subject_ChatWith)

        If Not dr_subjFriend.Check_Friend_List() Then
            subjF.Insert_Chat_With()

            _MainForm.PanelListOfChatFriends.Controls.Clear()
            _MainForm._ListOfUserFriendsChatPanel.Clear()

            createListOfPanels = New Create_ListOf_Panels(_Subject, _MainForm.FriendsChatScrollBar, _MainForm, 60, "Chat", _MainForm._ListOfUserFriendsChatPanel, _MainForm.PanelListOfChatFriends)

            createListOfPanels.Create_ListOfPanels()

        Else
            For Each item In _MainForm._ListOfUserFriendsChatPanel
                If item._UserName.Equals(_NameOfUserChat) Then

                End If
            Next

            'FIX CREATE LIST OF(Subject's ID) or (Subject) to add all person to a common gruop
            '_MainForm._ListOfUserFriendsChatPanel.Item(_OpenChat).On_ChatPanel_Click(_MainForm._ListOfUserFriendsChatPanel.Item(_OpenChat)._Sender, _MainForm._ListOfUserFriendsChatPanel.Item(_OpenChat)._E)
        End If

        Me.Close()
    End Sub
End Class