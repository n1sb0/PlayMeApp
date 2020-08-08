Imports System.Net
Imports System.Net.Mail

Public Class PassRecForm
    '*****///// VARS
    Private _RandomCode As String

    '*****///// CLASSES
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure

    '*****///// COLORS
    Private _RedColor As String = _Utility_Style.RedColor
    Private _OrngColor As String = _Utility_Style.OrngColor
    Private _MainColor As String = _Utility_Style.MainColor
    Private _GrayColor As String = _Utility_Style.GrayColor
    Private _BackGColor As String = _Utility_Style.BackGroundColor

    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
    End Sub

    Private Sub PassRecForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle_For_Components()
    End Sub

    '*****///// STYLE COMPONENTS
    Private Sub SetStyle_For_Components()
        Lbl_Style()
        Txt_Style()
        Form_Style()
    End Sub
    Private Sub Form_Style()
        Me.ActiveControl = lblCreaAcc
        Me.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub Txt_Style()
        txtCode.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        txtEmail.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        txtNewPassword.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        txtConfPassword.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub Lbl_Style()
        lblCode.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblEmail.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblMsgEmail.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_OrngColor))
        lblMsgComfCode.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        lblNewPassword.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblConfPassword.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblMsgNewPassword.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        lblMsgConfPassword.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
    End Sub
    '*****///// END STYLE COMPONENTS

    '*****///// EVENTS MOUSE CLICK AND LEAVE FOR TEXT BOXES
    Private Sub txtEmail_MouseClick(sender As Object, e As MouseEventArgs) Handles txtEmail.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtEmail, lblEmail, pnlEmail, "EMAIL ADDRESS")

        lblMsgEmail.Visible = True
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtEmail, lblEmail, pnlEmail, "EMAIL ADDRESS")
    End Sub

    Private Sub txtCode_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCode.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtCode, lblCode, pnlCode, "CODE")
    End Sub

    Private Sub txtCode_Leave(sender As Object, e As EventArgs) Handles txtCode.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtCode, lblCode, pnlCode, "CODE")

    End Sub

    '*****///// END EVENTS MOUSE CLICK AND LEAVE FOR TEXT BOXES

    '*****///// GET RANDOM NUMBER FUNCTION
    Private Sub Get_RandNum()
        Dim rand As Random = New Random()
        _RandomCode = (rand.Next(99999)).ToString()
    End Sub

    '*****///// BUTTON SUBMIT TO GET EMAIL CODE TO RECOVERY PASSWORD
    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit_Click(Me, New EventArgs())
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If DR_Subject.Get_Subject_By("email", txtEmail.Text) Then
            Dim message As New MailMessage()
            Get_RandNum()

            Try
                message.From = New MailAddress("nsb.app0@gmail.com")
                message.To.Add(txtEmail.Text)
                message.Subject = "Your recovery code."
                message.Body = "Your recovery code is: " + _RandomCode

                Dim smtp As New SmtpClient("smtp.gmail.com")
                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("nsb.app0@gmail.com", My.Settings.EmailPass)
                smtp.Send(message)

                Me.Height = 650
                txtEmail.ReadOnly = True
                btnSubmit.Enabled = False
                pnlVirCode.Visible = True
                Me.CenterToScreen()
            Catch ex As Exception
                MessageBox.Show("Please, try again! " + vbCrLf + ex.ToString())
            End Try
        Else
            If confEmail.Text.Equals("✔") Then
                Dim ris As MsgBoxResult = MessageBox.Show("This Email Address doesn't Registered!" + vbCrLf + "If you want to create a new Account click Yes.", "Attention!", MessageBoxButtons.YesNo)

                _Utility_Style.Change_Msg_Warning_To(confEmail, "✖")

                _Utility_Secure.Close_LoginForm(Me, ris)
            End If

            If confEmail.Text.Equals("✖") Then
                _Utility_Style.Change_Msg_Warning_To(confEmail, "✖")
            End If
            confEmail.Visible = True
        End If
    End Sub
    '*****///// END BUTTON SUBMIT TO GET EMAIL CODE TO RECOVERY PASSWORD

    '*****///// BUTTON VERIFY RANDON CODE 
    Private Sub btnVerifyCode_Click(sender As Object, e As EventArgs) Handles btnVerifyCode.Click
        If (_RandomCode = txtCode.Text) Then
            Me.Width = 1000
            Me.CenterToScreen()
            btnVerifyCode.Enabled = False
            txtCode.Enabled = False
            _Utility_Style.Change_Msg_Warning_To(confCode, "✔")
        Else
            _Utility_Style.Change_Msg_Warning_To(confCode, "✖")
            lblMsgComfCode.Visible = True
        End If
        confCode.Visible = True
    End Sub
    '*****///// END  BUTTON VERIFY RANDON CODE 

    '*****///// BUTTON CONFIRM TO CHANGE PASSWOR
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If confNewPassword.Text.Equals("✔") AndAlso confConfPassword.Text.Equals("✔") Then
            Dim subj As New Subject

            Dim password As String = Encryption.HashString(txtNewPassword.Text)
            Dim salt As String = Encryption.GenereateSalt()
            Dim hashedAndSolted As String = Encryption.HashString(String.Format("{0}{1}", password, salt))

            subj.SUBJECT_SALT = salt
            subj.SUBJECT_EMAIL = txtEmail.Text
            subj.SUBJECT_PASSWORD = hashedAndSolted

            subj.Update_Subject_Password()
        End If

        Me.Close()
    End Sub
    '*****///// END BUTTON CONFIRM TO CHANGE PASSWOR


    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If Not lblEmail.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtEmail, lblEmail, pnlEmail, "EMAIL ADDRESS")
        End If

        If Not txtEmail.ReadOnly Then
            lblMsgEmail.Visible = False
        End If

        _Utility_Secure.Control_Email(txtEmail, confEmail, lblMsgEmail)
    End Sub


    '*****///// TEXT BOX NEW PASSWORD MOUSE CLICK AND ON TEXT CHANGED
    Private Sub txtTest_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        _Utility_Secure.On_Password_Change(txtNewPassword, txtConfPassword, lblMsgNewPassword, lblMsgConfPassword, confNewPassword, confConfPassword, pnlNewPassword, lblNewPassword, "NEW PASSWORD")
    End Sub

    Private Sub txtTest_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNewPassword.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtNewPassword, lblNewPassword, pnlNewPassword, "NEW PASSWORD")

        If Not confConfPassword.Text.Equals("✔") Then
            lblMsgNewPassword.Visible = True
        End If
        confNewPassword.Visible = True

        txtNewPassword.PasswordChar = "*"
    End Sub

    Private Sub txtTest_Leave(sender As Object, e As EventArgs) Handles txtNewPassword.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtNewPassword, lblNewPassword, pnlNewPassword, "NEW PASSWORD")

        _Utility_Style.On_Empty_TextBox(txtNewPassword, "NEW PASSWORD", confNewPassword, lblMsgNewPassword)
    End Sub

    Private Sub txtConfPassword_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtConfPassword.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword_Click(Me, New EventArgs())
        End If
    End Sub


    Private Sub txtConfPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfPassword.TextChanged
        If Not lblMsgConfPassword.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtConfPassword, lblConfPassword, pnlConfPassword, "CONFIRM PASSWORD")
        End If

        _Utility_Style.Hide_Password_Text(txtConfPassword, "CONFIRM PASSWORD")

        _Utility_Secure.Confront_Passwords(txtConfPassword, txtNewPassword, confConfPassword, lblMsgConfPassword, "CONFIRM PASSWORD")
    End Sub

    Private Sub txtConfPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtConfPassword.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtConfPassword, lblConfPassword, pnlConfPassword, "CONFIRM PASSWORD")

        txtConfPassword.PasswordChar = "*"
    End Sub

    Private Sub txtConfPassword_Leave(sender As Object, e As EventArgs) Handles txtConfPassword.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtConfPassword, lblMsgConfPassword, pnlConfPassword, "CONFIRM PASSWORD")

        _Utility_Style.On_Empty_TextBox(txtConfPassword, "CONFIRM PASSWORD", confConfPassword, lblMsgConfPassword)
    End Sub
    '*****///// END TEXT BOX NEW PASSWORD MOUSE CLICK AND ON TEXT CHANGED

    '*****///// TEXT BOX RANDOME CODE
    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        If Not lblCode.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtCode, lblCode, pnlCode, "CODE")
        End If
    End Sub

    '*****///// END TEXT BOX RANDOME CODE

    '*****///// BUTTONS TO SEE PASSWORD 
    Private Sub btnSeeNewPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSeeNewPassword.MouseDown
        _Utility_Style.Mouse_Down_To_See_Password(txtNewPassword, btnSeeNewPassword)
    End Sub

    Private Sub btnSeeNewPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSeeNewPassword.MouseUp
        _Utility_Style.Mouse_Up_To_Hide_Password(txtNewPassword, "NEW PASSWORD", btnSeeNewPassword)
    End Sub

    Private Sub btnSeeConfPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSeeConfPassword.MouseDown
        _Utility_Style.Mouse_Down_To_See_Password(txtConfPassword, btnSeeConfPassword)
    End Sub

    Private Sub btnSeeConfPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSeeConfPassword.MouseUp
        _Utility_Style.Mouse_Up_To_Hide_Password(txtConfPassword, "CONFIRM PASSWORD", btnSeeConfPassword)
    End Sub
    '*****///// END BUTTONS TO SEE PASSWORD 

    '*****///// BUTTON COME BACK
    Private Sub btnComeBack_Click(sender As Object, e As EventArgs) Handles btnComeBack.Click
        If Not Application.OpenForms().OfType(Of LoginForm).Any Then
            LoginForm.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btnComeBack_MouseHover(sender As Object, e As EventArgs) Handles btnComeBack.MouseHover
        btnComeBack.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
    End Sub

    Private Sub btnComeBack_MouseLeave(sender As Object, e As EventArgs) Handles btnComeBack.MouseLeave
        btnComeBack.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// END BUTTON COME BACK
End Class