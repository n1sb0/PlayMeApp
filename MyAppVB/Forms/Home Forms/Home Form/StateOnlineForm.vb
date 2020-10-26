Imports Guna.UI.WinForms

Public Class StateOnlineForm

    Private _GenericButton As GunaButton
    Private _MainForm As HomeForm
    Private _Utility_Style As New Utility_Style

    Private _Subject As Subject

    Sub New(ByRef mform As HomeForm, ByRef subj As Subject)
        InitializeComponent()

        _Subject = subj
        _MainForm = mform
    End Sub

    Private Sub On_ChangeState_Click(sender As Object, e As EventArgs) _
       Handles btnOnline.MouseClick, btnAway.MouseClick, btnNotDisturb.MouseClick, btnOffline.MouseClick

        _GenericButton = DirectCast(sender, GunaButton)

        Dim stateOnlie As String = ""

        Select Case _GenericButton.Name
            Case "btnOnline"
                stateOnlie = "Online"
                _Subject.Update_Subject_StateOnline("Online")
            Case "btnAway"
                stateOnlie = "Away"
                _Subject.Update_Subject_StateOnline("Away")

            Case "btnNotDisturb"
                stateOnlie = "NotDisturb"
                _Subject.Update_Subject_StateOnline("NotDisturb")

            Case "btnOffline"
                stateOnlie = "Offline"
                _Subject.Update_Subject_StateOnline("Offline")
        End Select

        _Subject.SUBJECT_STATE_ONLINE = stateOnlie

        _Subject.Update_Subject_StateOnline(_Subject.SUBJECT_STATE_ONLINE, "save state online")

        _Utility_Style.Set_UserStateOnline(_MainForm.pointOnline, stateOnlie)

        Close()
    End Sub

End Class