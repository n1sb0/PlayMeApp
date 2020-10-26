Public Class Utility_OpenForm

    '*****///// VARS
    Public _DmFormWidth As Integer = 400

    '*****///// CLASSES
    Private _Subject As Subject
    Private _SubjFriend As Subject

    '*****///// FORMS
    Private _MainForm As HomeForm
    Private _PopUpmsgForm As PopUpMessageForm
    Private _DeleteFriendForm As DeleteFriendForm
    Private _StateOnlineForm As StateOnlineForm
    Private _CreateDmForm As CreateDMForm

    Sub New()
    End Sub

    Sub New(subj As Subject, subjfr As Subject, hform As HomeForm, dform As DeleteFriendForm)
        _Subject = subj
        _SubjFriend = subjfr
        _MainForm = hform
        _DeleteFriendForm = dform
    End Sub

    Public Sub Open_PopUpMsgForm(Optional _Form As Form = Nothing, Optional _MsgText As String = "", Optional x As Integer = 0, Optional y As Integer = 0)

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

    Public Sub Open_DeleteOrBlockFriendForm(str As String)
        If Not Application.OpenForms().OfType(Of DeleteFriendForm).Any Then
            _MainForm.TransparentBackGround.Size = _MainForm.MainPanel.Size
            _MainForm.TransparentBackGround.Location = New Point(0, 0)
            _MainForm.TransparentBackGround.Visible = True
            _DeleteFriendForm = New DeleteFriendForm(_Subject, _SubjFriend, _MainForm, str)

            _DeleteFriendForm.TopLevel = False
            _DeleteFriendForm.Parent = _MainForm

            _DeleteFriendForm.SetBounds(_MainForm.Width / 2 - 175, _MainForm.Height / 2 - 150, 400, 200)
            _DeleteFriendForm.BringToFront()
            _DeleteFriendForm.Show()

            _MainForm._DeleteFriendForm = _DeleteFriendForm
        End If
    End Sub

    Public Sub Open_StateOnlineForm(x As Integer, y As Integer, _Form As Form, subj As Subject)

        If Not Application.OpenForms().OfType(Of StateOnlineForm).Any Then
            _StateOnlineForm = New StateOnlineForm(_Form, subj)

            _StateOnlineForm.TopLevel = False
            _StateOnlineForm.Parent = _Form

            _StateOnlineForm.SetBounds(x, y - 150, 150, 160)
            _StateOnlineForm.BringToFront()
            _StateOnlineForm.Show()
        End If

    End Sub

    Public Sub Open_CreateChatForm(x As Integer, y As Integer, _Form As Form, subj As Subject)

        If Not Application.OpenForms().OfType(Of CreateDMForm).Any Then
            _CreateDmForm = New CreateDMForm(_Form, subj)

            _CreateDmForm.TopLevel = False
            _CreateDmForm.Parent = _Form

            _CreateDmForm.SetBounds(x, y, _DmFormWidth, _DmFormWidth - 50)
            _CreateDmForm.BringToFront()
            _CreateDmForm.Show()
        End If
    End Sub
End Class