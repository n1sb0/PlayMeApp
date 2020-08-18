Public Class PendingForm

    Private _Subject As Subject
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Public _ListOfUserPendingReq As New List(Of PendingRequestPanel)


    Sub New(subject As Subject)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        _Subject = subject

        Create_PendingReq()
    End Sub

    Private Sub Create_PendingReq()
        Dim createListOfPanels As New Create_ListOf_Panels(_Subject, PendingReqScrollBar, Me, 61, "Request", _ListOfUserPendingReq, pnlPendingReq)

        createListOfPanels.Create_ListOfPanels()

        lblPendingReq.Text += " " + (_ListOfUserPendingReq.Count()).ToString
    End Sub

    Private Sub PendingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlPendingReq, PendingReqScrollBar, True)
        vScrollHelper.UpdateScrollBar()

        If _ListOfUserPendingReq.Count = 0 Then
            pnlImgPendingReq.Visible = True
        Else
            lblPendingReq.Visible = True
            pnlImgPendingReq.Visible = False
            pnlUnderTextPeddingReq.Visible = True
        End If
    End Sub
End Class