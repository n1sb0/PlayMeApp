Imports Guna.UI.WinForms

Public Class MenuMoreForm
    Private _MainForm As HomeForm
    Private _Subject As Subject
    Private _SubjFriend As Subject
    Private _DeleteFriendForm As DeleteFriendForm
    Private _GenericButton As GunaButton

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
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.Clear(Me.Parent.BackColor)
        Dim control As Control = Me
        Dim radius As Integer = 12

        Using path As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
            path.AddLine(radius, 0, control.Width - radius, 0)
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90)
            path.AddLine(control.Width, radius, control.Width, control.Height - radius)
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90)
            path.AddLine(control.Width - radius, control.Height, radius, control.Height)
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90)
            path.AddLine(0, control.Height - radius, 0, radius)
            path.AddArc(0, 0, radius, radius, 180, 90)

            Using brush As SolidBrush = New SolidBrush(control.BackColor)
                e.Graphics.FillPath(brush, path)
            End Using
        End Using
    End Sub

    Private Sub On_Buttons_Click(sender As Object, e As EventArgs) Handles btnStartVideoCall.Click, btnStartVoiceCall.Click, btnDeleteFriend.Click

        _GenButton = DirectCast(sender, GunaButton)

        Select Case _GenButton.Name

            Case "btnStartVoiceCall"

            Case "btmStartVideoCall"

            Case "btnDeleteFriend"

                If Not Application.OpenForms().OfType(Of DeleteFriendForm).Any Then
                    _MainForm.TransparentBackGround.Size = _MainForm.MainPanel.Size
                    _MainForm.TransparentBackGround.Location = New Point(0, 0)
                    _MainForm.TransparentBackGround.Visible = True
                    _DeleteFriendForm = New DeleteFriendForm(_Subject, _SubjFriend)

                    _DeleteFriendForm.TopLevel = False
                    _DeleteFriendForm.Parent = _MainForm

                    _DeleteFriendForm.SetBounds(_MainForm.Width / 2 - 175, _MainForm.Height / 2 - 150, 400, 200)
                    _DeleteFriendForm.BringToFront()
                    _DeleteFriendForm.Show()

                    _MainForm._DeleteFriendForm = _DeleteFriendForm
                End If
        End Select

        Close()
    End Sub

    Private Sub MenuMoreForm_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Dim count As Integer = 0

        For Each c In Me.Controls
            If Not MouseIsOverControl(c) Then
                count += 1
            End If
        Next

        If count = 3 Then
            Close()
        End If
    End Sub

    Public Function MouseIsOverControl(ByVal c As Control) As Boolean
        Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
    End Function
End Class