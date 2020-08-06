Public Class PendingForm

    Private _Subject As Subject
    Private vScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Public _ListOfUserPendingReq As New List(Of FriendsOnlineAndAllPanel)


    Sub New(subject As Subject)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        _Subject = subject
    End Sub

    Private Sub PendingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _ListOfUserPendingReq.Count = 0 Then
            pnlImgPendingReq.Visible = True
        Else
            lblPendingReq.Visible = True
            pnlImgPendingReq.Visible = False
            pnlUnderTextPeddingReq.Visible = True
        End If
    End Sub
End Class