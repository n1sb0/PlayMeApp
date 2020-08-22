Public Class Open_PopUpForm

    Private _Form
    Private _PopUpmsgForm As PopUpMessageForm

    Sub New(ByRef f As HomeForm)
        _Form = f
    End Sub

    Sub New(ByRef f As ChatFriendForm)
        _Form = f
    End Sub

    Public Sub Open_MessageForm(Optional _MsgText As String = "", Optional x As Integer = 0, Optional y As Integer = 0)

        If Not Application.OpenForms().OfType(Of PopUpMessageForm).Any Then
            _PopUpmsgForm = New PopUpMessageForm

            _PopUpmsgForm.TopLevel = False
            _PopUpmsgForm.Parent = _Form

            _PopUpmsgForm.lblMessage.Text = _MsgText

            Dim formWidth = _PopUpmsgForm.lblMessage.Width + 10

            _PopUpmsgForm.SetBounds((x + 4) - (formWidth / 2), y, formWidth, 25)
            _PopUpmsgForm.BringToFront()
            _PopUpmsgForm.Show()
        Else
            _PopUpmsgForm.Close()
        End If
    End Sub

End Class
