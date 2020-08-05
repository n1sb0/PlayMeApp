Public Class PendingForm

    Private _Subject As Subject

    Sub New(subject As Subject)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        _Subject = subject
    End Sub

End Class