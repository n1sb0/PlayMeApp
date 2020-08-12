Public Class RegisterForm
    '*****///// VARS
    Private _ris_ComoBox As Boolean
    Private _StrPassword = "PASSWORD"
    Private _StrUserName = "USERNAME"
    Private _StrEmail = "EMAIL ADDRESS"
    Private _StrConfPassword = "CONFIRM PASSWORD"

    '*****///// CLASSES
    Private _NewSubj As New Subject
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure

    '*****///// COLORS
    Private _RedColor As String = _Utility_Style.RedColor
    Private _MainColor As String = _Utility_Style.MainColor
    Private _GrayColor As String = _Utility_Style.GrayColor
    Private _OrngColor As String = _Utility_Style.OrngColor
    Private _GreenColor As String = _Utility_Style.GreenColor
    Private _BackGColor As String = _Utility_Style.BackGroundColor

    Sub New()
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle_For_Components()
    End Sub

    '*****///// STYLE COMPONENTS
    Private Sub SetStyle_For_Components()
        Lbl_Style()
        Txt_Style()
        Form_Style()
        CmbBox_Style()
    End Sub

    Private Sub Form_Style()
        Me.ActiveControl = lblCreaAcc
        Me.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub Txt_Style()
        txtEmail.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        txtUserName.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        txtPassword.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        txtConfPassword.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub CmbBox_Style()
        cmbBoxDay.SelectedIndex = 0
        cmbBoxYear.SelectedIndex = 0
        cmbBoxMonth.SelectedIndex = 0

        cmbBoxDay.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        cmbBoxYear.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        cmbBoxMonth.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
    End Sub

    Private Sub Lbl_Style()
        lblDay.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblPass.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblYear.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblMoth.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblEmail.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblConfPass.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblUserName.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
        lblMsgEmail.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_OrngColor))
        lblMsgPass.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        lblMsgConfPass.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_RedColor))
        lblMsgUserName.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_OrngColor))
    End Sub
    '*****///// END STYLE COMPONENTS

    '*****///// EVENTS MOUSE CLICK AND LEAVE FOR TEXT BOXES
    Private Sub txtEmail_MouseClick(sender As Object, e As MouseEventArgs) Handles txtEmail.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtEmail, lblEmail, pnlEmail, _StrEmail)

        lblMsgEmail.Visible = True
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtEmail, lblEmail, pnlEmail, _StrEmail)
    End Sub
    Private Sub txtPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtPassword, lblPass, pnlPass, _StrPassword)

        If Not confPass.Text.Equals("✔") Then
            lblMsgPass.Visible = True
        End If
        confPass.Visible = True

        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtPassword, lblPass, pnlPass, _StrPassword)

        _Utility_Style.On_Empty_TextBox(txtPassword, _StrPassword, confPass, lblMsgPass)
    End Sub

    Private Sub txtConfPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtConfPassword.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtConfPassword, lblConfPass, pnlConfPass, _StrConfPassword)

        txtConfPassword.PasswordChar = "*"
    End Sub

    Private Sub txtConfPassword_Leave(sender As Object, e As EventArgs) Handles txtConfPassword.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtConfPassword, lblConfPass, pnlConfPass, _StrConfPassword)

        _Utility_Style.On_Empty_TextBox(txtConfPassword, _StrConfPassword, confConfPass, lblMsgConfPass)
    End Sub

    Private Sub txtUserName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUserName.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtUserName, lblUserName, pnlUserName, _StrUserName)
    End Sub

    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtUserName, lblUserName, pnlUserName, _StrUserName)
    End Sub
    '*****///// END EVENTS MOUSE CLICK AND LEAVE FOR TEXT BOXES

    '*****///// STYLE COMBO BOX ON CHANGED INDEX
    Private Sub cmbBoxDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxDay.SelectedIndexChanged
        _Utility_Style.ComboBox_On_Change_SelectedIndex(cmbBoxDay, lblDay)
    End Sub

    Private Sub cmbBoxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxMonth.SelectedIndexChanged
        _Utility_Style.ComboBox_On_Change_SelectedIndex(cmbBoxMonth, lblMoth)
    End Sub

    Private Sub cmbBoxYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxYear.SelectedIndexChanged
        _Utility_Style.ComboBox_On_Change_SelectedIndex(cmbBoxYear, lblYear)
    End Sub
    '*****///// END COMBO BOX ON CHANGED INDEX

    '*****///// BTN EXIT
    Private Sub btnComeBack_Click(sender As Object, e As EventArgs) Handles btnComeBack.Click

    End Sub
    '*****///// END BTN EXIT 

    '*****///// CHANGE STYLE FOR CHECKBOX ON CLICK
    Private Sub ckBoxPrivacy_CheckedChanged(sender As Object, e As EventArgs) Handles ckBoxPrivacy.CheckedChanged
        _Utility_Style.CheckBox_On_Change_State(ckBoxPrivacy)
    End Sub

    Private Sub ckBoxMail_CheckedChanged(sender As Object, e As EventArgs) Handles ckBoxMail.CheckedChanged
        _Utility_Style.CheckBox_On_Change_State(ckBoxMail)
    End Sub
    '*****///// END CHANGE STYLE FOR CHECKBOX ON CLICK

    '*****///// SHOW PASSWORD ON CLICK
    Private Sub btnSeePassword_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSeePassword.MouseDown
        _Utility_Style.Mouse_Down_To_See_Password(txtPassword, btnSeePassword)
    End Sub

    Private Sub btnSeePassword_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSeePassword.MouseUp
        _Utility_Style.Mouse_Up_To_Hide_Password(txtPassword, _StrPassword, btnSeePassword)
    End Sub

    Private Sub btnSeeConfPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSeeConfPassword.MouseDown
        _Utility_Style.Mouse_Down_To_See_Password(txtConfPassword, btnSeeConfPassword)
    End Sub

    Private Sub btnSeeConfPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSeeConfPassword.MouseUp
        _Utility_Style.Mouse_Up_To_Hide_Password(txtConfPassword, _StrConfPassword, btnSeeConfPassword)
    End Sub

    '*****///// END SHOW PASSWORD ON CLICK

    '*****///// CHECK ALL PARAMETERS FOR PASSWORD
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        _Utility_Secure.On_Password_Change(txtPassword, txtConfPassword, lblMsgPass, lblMsgConfPass, confPass, confConfPass, pnlPass, lblPass, "PASSWORD")
    End Sub
    '*****///// CHECK ALL PARAMETERS FOR PASSWORD

    '*****///// CHECK ALL PARAMETERS FOR EMAIL
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If Not lblEmail.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtEmail, lblEmail, pnlEmail, _StrEmail)
        End If

        lblMsgEmail.Visible = False

        _Utility_Secure.Control_Email(txtEmail, confEmail, lblMsgEmail)
    End Sub
    '*****///// END CHECK ALL PARAMETERS FOR EMAIL

    '*****///// CONFIRM PASSWORD 
    Private Sub txtConfPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfPassword.TextChanged
        If Not lblConfPass.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtConfPassword, lblConfPass, pnlConfPass, _StrConfPassword)
        End If

        _Utility_Style.Hide_Password_Text(txtConfPassword, _StrConfPassword)

        _Utility_Secure.Confront_Passwords(txtConfPassword, txtPassword, confConfPass, lblMsgConfPass, _StrConfPassword)
    End Sub
    '*****///// END CONFIRM PASSWORD 

    '*****///// TXT USER NAME TEXT CHANGE
    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

        If lblMsgUserName.Visible Then
            lblMsgUserName.Visible = False
        End If

        If Not lblUserName.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtUserName, lblUserName, pnlUserName, _StrUserName)
        End If

        If _Utility_Secure.ContainsSpecialChars(txtUserName.Text) Then
            _Utility_Style.Change_Msg_Warning_To(confUserName, "✖")
            confUserName.Visible = True
        Else
            confUserName.Visible = False
        End If
    End Sub

    '*****/////END TXT USER NAME TEXT CHANGE

    '*****///// RISULT COMBOBOX 
    Private Sub Risult_CmbBox()
        If _ris_ComoBox Then
            _Utility_Style.Change_Msg_Warning_To(confData, "✔")
        Else
            _Utility_Style.Change_Msg_Warning_To(confData, "✖")
        End If
        confData.Visible = True
    End Sub

    Private Sub Risult_CheckBox()
        If ckBoxPrivacy.Checked Then
            _Utility_Style.Change_Msg_Warning_To(confPrivicy, "✔")
        Else
            _Utility_Style.Change_Msg_Warning_To(confPrivicy, "✖")
        End If
        confPrivicy.Visible = True
    End Sub
    '*****/////END RISULT COMBOBOX 

    '*****/////WHEN ALL DATA WAS COMPLETED ON CLICK BUTTON CONTINUE TO CONFIRM REGISTRATION

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        _ris_ComoBox = _Utility_Style.ComboBox_Check_Data(cmbBoxDay, cmbBoxMonth, cmbBoxYear)

        Risult_CmbBox()
        Risult_CheckBox()

        If txtUserName.Text.Equals(_StrUserName) OrElse DR_Subject.Get_Subject_By("username", txtUserName.Text) Then
            _Utility_Style.Change_Msg_Warning_To(confUserName, "✖")

            If Not txtUserName.Text.Equals(_StrUserName) Then
                lblMsgUserName.Visible = True
            End If
        Else
            _Utility_Style.Change_Msg_Warning_To(confUserName, "✔")
            lblMsgUserName.Visible = False
        End If
        confUserName.Visible = True

        If txtEmail.Text.Equals(_StrEmail) OrElse DR_Subject.Get_Subject_By("email", txtEmail.Text) Then
            _Utility_Style.Change_Msg_Warning_To(confEmail, "✖")

            If Not txtEmail.Text.Equals(_StrEmail) Then
                Dim ris As MsgBoxResult = MessageBox.Show("This Email Address is already Registered!" + vbCrLf + "If you want to recovery your Account click Yes.", "Attention!", MessageBoxButtons.YesNo)

                _Utility_Secure.Close_LoginForm(Me, ris)
            End If
        Else
            _Utility_Style.Change_Msg_Warning_To(confEmail, "✔")
            lblMsgEmail.Visible = False
        End If
        confEmail.Visible = True


        _Utility_Style.Check_If_TextBox_Is_Empty(txtPassword, _StrPassword, confPass)

        If txtConfPassword.Text.Equals(_StrConfPassword) OrElse Not txtConfPassword.Text.Equals(txtPassword.Text) Then
            _Utility_Style.Show_Error_Button(confConfPass)
        End If

        If confEmail.Text.Equals("✔") AndAlso confPass.Text.Equals("✔") AndAlso confConfPass.Text.Equals("✔") AndAlso confUserName.Text.Equals("✔") AndAlso
            confData.Text.Equals("✔") AndAlso confPrivicy.Text.Equals("✔") Then

            SaveAll_Data()

            _NewSubj.Insert_With_Transaction()

            Me.Close()
        End If
    End Sub
    '*****///// END WHEN ALL DATA WAS COMPLETED ON CLICK BUTTON CONTINUE TO CONFIRM REGISTRATION

    '*****///// SAVE ALL SUBJECT DATA
    Private Sub SaveAll_Data()
        Dim password As String = Encryption.HashString(txtPassword.Text)
        Dim salt As String = Encryption.GenereateSalt()
        Dim hashedAndSolted = Encryption.HashString(String.Format("{0}{1}", password, salt))

        With _NewSubj
            .SUBJECT_EMAIL = txtEmail.Text
            .SUBJECT_PASSWORD = hashedAndSolted
            .SUBJECT_USERNAME = txtUserName.Text
            .SUBJECT_SALT = salt

            If ckBoxMail.Checked Then
                .SUBJECT_EMAIL_NOTIFICATION = "Yes"
            Else
                .SUBJECT_EMAIL_NOTIFICATION = "No"
            End If

            .SUBJECT_BIRTHDAY = cmbBoxDay.SelectedItem.ToString + "/" + cmbBoxMonth.SelectedItem.ToString + "/" + cmbBoxYear.SelectedItem.ToString
        End With
    End Sub
    '*****///// END SAVE ALL SUBJECT DATA

    '*****///// UI CHANGE COLOR OF COMEBACK BUTTON
    Private Sub btnComeBack_MouseHover(sender As Object, e As EventArgs) Handles btnComeBack.MouseHover
        btnComeBack.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_MainColor))
    End Sub

    Private Sub btnComeBack_MouseLeave(sender As Object, e As EventArgs) Handles btnComeBack.MouseLeave
        btnComeBack.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(_GrayColor))
    End Sub

    '*****///// END UI CHANGE COLOR OF COMEBACK BUTTON
End Class