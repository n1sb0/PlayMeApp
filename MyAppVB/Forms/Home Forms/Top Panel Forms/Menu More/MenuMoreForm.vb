Imports Guna.UI.WinForms

Public Class MenuMoreForm

    Private _Subject As Subject
    Private _SubjFriend As Subject

    Private _GenericButton As GunaButton

    Private _MainForm As HomeForm
    Private _DeleteFriendForm As DeleteFriendForm
    Private _Utility_OpenForm As Utility_OpenForm

    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

    End Sub

    Sub New(subject As Subject, subjFriend As Subject, ByRef mForm As HomeForm)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        _Subject = subject
        _SubjFriend = subjFriend
        _MainForm = mForm

        Controls.Add(btnStartVoiceCall)
        Controls.Add(btnDeleteFriend)
        Controls.Add(btnStartVideoCall)
    End Sub

    Private _GenButton As GunaButton
    Private Sub MenuMoreForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim RComp_OnPaint As New RoundComponent_OnPaint

        RComp_OnPaint.On_Paint_Forms(sender, e, Me)
    End Sub

    Private Sub On_Buttons_Click(sender As Object, e As EventArgs) Handles btnStartVideoCall.Click, btnStartVoiceCall.Click, btnDeleteFriend.Click

        _GenButton = DirectCast(sender, GunaButton)

        _Utility_OpenForm = New Utility_OpenForm(_Subject, _SubjFriend, _MainForm, _DeleteFriendForm)

        Select Case _GenButton.Name

            Case "btnStartVoiceCall"

            Case "btmStartVideoCall"

            Case "btnDeleteFriend"
                _Utility_OpenForm.Open_DeleteOrBlockFriendForm("Delete")
        End Select

        Close()
    End Sub

    Public Function MouseIsOverControl(ByVal c As Control) As Boolean
        Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
    End Function
End Class