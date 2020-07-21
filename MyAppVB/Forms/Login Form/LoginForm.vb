Public Class LoginForm
    Private MoveForm As Boolean
    Private GenericLabel As Label
    Private MoveForm_MousePosition As Point
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure

    Private _RedColor As String = _Utility_Style.RedColor
    Private _MainColor As String = _Utility_Style.MainColor
    Private _GrayColor As String = _Utility_Style.GrayColor
    Private _OrgnColor As String = _Utility_Style.OrngColor
    Private _BackGColor As String = _Utility_Style.BackGroundColor

    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.7
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        SetStyle_For_Components()
    End Sub

    Private Sub SetStyle_For_Components()
        Btn_Style()
        Form_style()
        TxtBox_Style()
    End Sub

    Private Sub Form_style()
        Me.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub TxtBox_Style()
        lblLogin.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblPassword.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        txtLogin.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        txtPassword.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub Btn_Style()
        btnLogin.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        btnLogin.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
    End Sub

    '*****///// TEXT BOX STYLE 
    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged
        If Not lblLogin.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtLogin, lblLogin, panelLogin, "USERNAME OR EMAIL")
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If Not lblPassword.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtPassword, lblPassword, panelPass, "PASSWORD")
        End If

        If Not txtPassword.PasswordChar = "*" AndAlso Not txtPassword.Text.Equals("PASSWORD") Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtLogin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLogin.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtLogin, lblLogin, panelLogin, "USERNAME OR EMAIL")

        If confLogin.Visible Then
            confLogin.Visible = False
        End If
    End Sub

    Private Sub txtLogin_Leave(sender As Object, e As EventArgs) Handles txtLogin.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtLogin, lblLogin, panelLogin, "USERNAME OR EMAIL")
    End Sub

    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtPassword, lblPassword, panelPass, "PASSWORD")

        If confPassword.Visible Then
            confPassword.Visible = False
            txtPassword.Text = String.Empty
        End If

        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtPassword, lblPassword, panelPass, "PASSWORD")

        If txtPassword.Text.Equals("PASSWORD") Then
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnSeePassword_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSeePassword.MouseDown
        _Utility_Style.Mouse_Down_To_See_Password(txtPassword, btnSeePassword)
    End Sub

    Private Sub btnSeePassword_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSeePassword.MouseUp
        _Utility_Style.Mouse_Up_To_Hide_Password(txtPassword, "PASSWORD", btnSeePassword)
    End Sub
    '*****///// END TEXT BOX STYLE

    '*****///// BUTTON MOUSE HOVER
    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        _Utility_Style.Mouse_Hover_Button(btnLogin)
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        _Utility_Style.Mouse_Leave_Button(btnLogin)
    End Sub
    '*****///// END BUTTON MOUSE HOVER

    '*****///// CHECK BOX CHEKED
    Private Sub ckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ckBox.CheckedChanged
        _Utility_Style.CheckBox_On_Change_State(ckBox)
    End Sub
    '*****/////

    '*****///// MOUSE HOVER LABEL STYLE
    Private Sub Mouse_Hover_Text(sender As System.Object, e As System.EventArgs) _
      Handles lblCreaAcc.MouseHover, lblResetAcc.MouseHover

        GenericLabel = DirectCast(sender, Label)
        GenericLabel.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
    End Sub

    Private Sub Mouse_Leave_Text(sender As System.Object, e As System.EventArgs) _
      Handles lblCreaAcc.MouseLeave, lblResetAcc.MouseLeave

        GenericLabel = DirectCast(sender, Label)
        GenericLabel.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub
    '*****///// END MOUSE HOVER LABEL STYLE

    ''*****///// MOVE FORM 
    Private Sub myMoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles myMoveForm.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub myMoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles myMoveForm.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Private Sub myMoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles myMoveForm.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If
    End Sub
    '*****/////

    '*****///// ON CLICK OPEN REGISTER FORM AND RECOVER PASSWORD FORM 
    Private Sub lblCreaAcc_Click(sender As Object, e As EventArgs) Handles lblCreaAcc.Click
        Dim regForm As New RegisterForm
        regForm.ShowDialog()
    End Sub

    Private Sub lblResetAcc_Click(sender As Object, e As EventArgs) Handles lblResetAcc.Click
        Dim recForm As New PassRecForm
        recForm.ShowDialog()
    End Sub

    '*****/////

    '*****///// UPPER PANEL HIDE-CLOSE MAIN FORM

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// END UPPER PANEL CLOSE BUTTON MAIN FORM
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dr_Subject As New DR_Subject

        Dim ris As Boolean = DR_Subject.Get_Subject_Login_And_Password(txtLogin.Text, txtPassword.Text)

        If ris Then
            Dim homeform As New MainForm(txtLogin.Text)
            homeform.Show()
            _Utility_Secure.Close_AllOpenedFormAndLeftOnlyOne("MainForm")
        Else
            lblErroreMsg.Visible = True

            txtPassword.Text = String.Empty

            _Utility_Style.Change_Msg_Warning_To(confLogin, "✖")
            _Utility_Style.Change_Msg_Warning_To(confPassword, "✖")

            confLogin.Visible = True
            confPassword.Visible = True
        End If
    End Sub
    '*****/////

    '*****///// keyDown (Enter to Login)
    Private Sub txtPassword_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtPassword.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Me, New EventArgs())
        End If
    End Sub
    '*****/////END keyDown (Enter to Login)
End Class