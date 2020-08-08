Imports System.IO
Imports FontAwesome.Sharp
Imports Guna.UI.WinForms

Public Class SettingsForm

    '*****///// VARS
    Private _UserName As String
    Private _BtnSaveCliked As Boolean = False
    Private _SizeOfCenterForm As Integer = 660
    Private _DistanceRightLeftPnlToCenterForm As Integer = 10

    '*****///// FORMS
    Private _CurrentChildForm As Form

    '*****///// COMPONENTS
    Private _PassPic As New PictureBox
    Private _GenericButton As GunaButton
    Private _MemoryStream As New MemoryStream

    '*****///// CLASSES
    Private _Subject As New Subject
    Private _ResizeImage As New ResizeImage
    Private _Utility_Style As New Utility_Style
    Private _Utility_Secure As New Utility_Secure
    Private _ControlChildForm As New ControlChildForm

    '*****///// COLORS
    Private _DarkBlue As String = _Utility_Style.DarkBlue
    Private _RedColor As String = _Utility_Style.RedColor
    Private _OrngColor As String = _Utility_Style.OrngColor
    Private _MainColor As String = _Utility_Style.MainColor
    Private _GrayColor As String = _Utility_Style.GrayColor
    Private _PanelsColor As String = _Utility_Style.LightDarkBlue
    Private _BackGColor As String = _Utility_Style.BackGroundColor
    Private _ButtonSelectedColor As String = _Utility_Style.LightDarkHoverButtonColor
    Private _ButtonClickedColor As String = _Utility_Style.LightDarkClickOnButtonColor

    Sub New(userName As String)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        _UserName = userName
        Put_Subject_Data()
        SetStyle_For_Components()
    End Sub

    '*****///// FORM STYLE 
    Private Sub SetStyle_For_Components()
        Form_style()
    End Sub


    Private Sub Form_style()
        Me.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_BackGColor))
        LeftPanel.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(_PanelsColor))
    End Sub

    '*****///// END FORM STYLE 

    '*****///// UPDATE USER DATA ON UI
    Private Sub Put_Subject_Data()
        _Subject = Subject.Get_Subject_Data(_UserName)

        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            txtUserEmail.Text = _Subject.SUBJECT_EMAIL
            txtUserName.Text = _Subject.SUBJECT_USERNAME

            If _Subject.SUBJECT_USER_PICTURE IsNot Nothing Then
                _Utility_Style.Set_UserPicture(userPictureBox, _Subject.SUBJECT_USER_PICTURE)
            End If
        End If
    End Sub
    '*****///// END UPDATE USER DATA ON UI

    '*****///// BUTTON CLOSE FORM
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Change_EditState(False)

        Dim homeform As New MainForm(_Subject.SUBJECT_USERNAME)
        _Utility_Secure.Close_AllOpenedFormAndLeftOnlyOne("deff")
        homeform.Show()
    End Sub
    '*****///// END BUTTON CLOSE FORM

    '*****///// ON CLICK LABEL CHANGE PASSWORD 
    Private Sub lblChangePassword_Click(sender As Object, e As EventArgs) Handles lblChangePassword.Click
        lblChangePassword.Text = "NEW PASSWORD"
        lblChangePassword.Visible = False
        txtNewPassword.Visible = True
        pnlNewPassword.Visible = True
    End Sub
    '*****///// END ON CLICK LABEL CHANGE PASSWORD 

    '*****///// OPEN OR CLOSE EDIT FORM ON CLICK EDIT OR CANCEL BUTTONS
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Change_EditState(False)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.ActiveControl = lblUserName

        Change_EditState(True)
    End Sub
    Private Sub Change_EditState(state As Boolean)
        If state Then
            pnlEditAccount.Height = 420
        Else
            pnlEditAccount.Height = 175

            txtNewPassword.Visible = state
            pnlNewPassword.Visible = state
            lblChangePassword.Text = "Change Password?"

            If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
                If Not txtUserName.Text.Equals(_Subject.SUBJECT_USERNAME) AndAlso Not _BtnSaveCliked Then
                    txtUserName.Text = _Subject.SUBJECT_USERNAME
                End If

                If Not txtUserEmail.Text.Equals(_Subject.SUBJECT_EMAIL) AndAlso Not _BtnSaveCliked Then
                    txtUserEmail.Text = _Subject.SUBJECT_EMAIL
                End If
            End If

            If Not txtCurrentPassword.Text.Equals("CURRENT PASSWORD") Then
                txtCurrentPassword.Text = String.Empty
                _Utility_Style.Mouse_Leave_TextBox(txtCurrentPassword, lblCurrentPassword, pnlCurrentPassword, "CURRENT PASSWORD")
                _Utility_Style.On_Empty_TextBox(txtCurrentPassword, "CURRENT PASSWORD")
            End If

            If Not txtNewPassword.Text.Equals("NEW PASSWORD") Then
                txtNewPassword.Text = String.Empty
                _Utility_Style.Mouse_Leave_TextBox(txtNewPassword, lblChangePassword, pnlNewPassword, "NEW PASSWORD")
                _Utility_Style.On_Empty_TextBox(txtNewPassword, "NEW PASSWORD", Nothing, lblMsgWarningPass)
            End If
        End If

        btnEdit.Visible = Not state
        pnlUserName.Visible = state
        txtUserName.Enabled = state
        txtUserEmail.Enabled = state
        pnlUserEmail.Visible = state
        btnRemoveImage.Visible = state
        lblChangePassword.Visible = state
    End Sub
    '*****///// END OPEN OR CLOSE EDIT FORM ON CLICK EDIT OR CANCEL BUTTONS

    '*****///// TEXT BOXS CURRENT AND NEW PASSWORD EVENTS ON CLOCK CHANGEE TEXT 
    Private Sub txtCurrentPassword_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentPassword.TextChanged
        _Utility_Style.Hide_Password_Text(txtCurrentPassword, "CURRENT PASSWORD")

        If Not lblCurrentPassword.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtCurrentPassword, lblCurrentPassword, pnlCurrentPassword, "CURRENT PASSWORD")
        End If
    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        _Utility_Style.Hide_Password_Text(txtNewPassword, "NEW PASSWORD")

        _Utility_Secure.WarningMsgPassword(txtNewPassword, lblMsgWarningPass)
    End Sub

    Private Sub txtNewPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNewPassword.MouseClick
        _Utility_Style.On_Mouse_Click_Change_TextBox(txtNewPassword, lblChangePassword, pnlNewPassword, "NEW PASSWORD")
    End Sub

    Private Sub txtNewPassword_Leave(sender As Object, e As EventArgs) Handles txtNewPassword.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtNewPassword, lblChangePassword, pnlNewPassword, "NEW PASSWORD")

        _Utility_Style.On_Empty_TextBox(txtNewPassword, "NEW PASSWORD", Nothing, lblMsgWarningPass)
    End Sub

    Private Sub txtCurrentPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCurrentPassword.MouseClick
        If lblWrongPassword.Visible = True Then
            txtCurrentPassword.Text = String.Empty
            lblWrongPassword.Visible = False
        End If

        _Utility_Style.On_Mouse_Click_Change_TextBox(txtCurrentPassword, lblCurrentPassword, pnlCurrentPassword, "CURRENT PASSWORD")
    End Sub

    Private Sub txtCurrentPassword_Leave(sender As Object, e As EventArgs) Handles txtCurrentPassword.Leave
        _Utility_Style.Mouse_Leave_TextBox(txtCurrentPassword, lblCurrentPassword, pnlCurrentPassword, "CURRENT PASSWORD")

        _Utility_Style.On_Empty_TextBox(txtCurrentPassword, "CURRENT PASSWORD")
    End Sub
    '*****///// END  TEXT BOXS CURRENT AND NEW PASSWORD EVENTS ON CLOCK CHANGEE TEXT 

    '*****///// ON RESIZE SETTINGS FORM TO MAKE RESPONSIVE UI FORM
    Private Sub SettingsForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        LeftPanel.Width = Convert.ToInt32(centerPanel.Location.X) - _DistanceRightLeftPnlToCenterForm
        btnClose.Left = Convert.ToInt32(centerPanel.Location.X) + _SizeOfCenterForm + _DistanceRightLeftPnlToCenterForm
        btnClose.Width = Screen.PrimaryScreen.Bounds.Width - Convert.ToInt32(btnClose.Location.X)
    End Sub
    '*****///// END ON RESIZE SETTINGS FORM TO MAKE RESPONSIVE UI FORM

    '*****///// LOG OUT FROM MAIN FORM AND OPEN LOGIN FORM
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        OpenLoginForm()
    End Sub
    '*****///// END LOG OUT FROM MAIN FORM AND OPEN LOGIN FORM

    '*****///// BUTTON REMOVE USER IMAGE AND CHANGE IT 
    Private Sub btnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
        Dim openFile As New OpenFileDialog

        openFile.FileName = ""
        openFile.Filter = "png|*.png|jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
        If openFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            _PassPic.Image = Image.FromFile(openFile.FileName)

            _PassPic.Image = ResizeImage.ResizeImage(_PassPic.Image, 300, 300)

            userPictureBox.Image = _PassPic.Image

            _Subject.SUBJECT_USER_PICTURE = _ResizeImage.ConvertImage(userPictureBox.Image)
        End If

        Debug.WriteLine(_Subject.SUBJECT_USER_PICTURE)
    End Sub
    '*****///// END BUTTON REMOVE USER IMAGE AND CHANGE IT 

    '*****///// WHEN DATA WERE CHANGED ON ON CLICK BUTTON SAVE GO TO UPDATE ALL DATA IN DATA BASE
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        _BtnSaveCliked = True
        Dim setQuery As String

        Dim userPassword As String = txtCurrentPassword.Text
        userPassword = Encryption.HashString(userPassword)
        userPassword = Encryption.HashString(String.Format("{0}{1}", userPassword, _Subject.SUBJECT_SALT))

        If userPassword.Equals(_Subject.SUBJECT_PASSWORD) Then

            Save_Subject_Data()

            If txtNewPassword.Visible Then
                Dim salt As String = Encryption.GenereateSalt()
                Dim password As String = Encryption.HashString(txtNewPassword.Text)
                Dim hashedAndSolted As String = Encryption.HashString(String.Format("{0}{1}", password, salt))

                _Subject.SUBJECT_PASSWORD = hashedAndSolted
                _Subject.SUBJECT_SALT = salt

                setQuery = MyConnection.Get_Update_Some_Data_Query() + ", SUBJECT_PASSWORD = @SUBJECT_PASSWORD, SALT = @SALT WHERE SUBJECT_ID = @SUBJECT_ID"
            Else
                setQuery = MyConnection.Get_Update_Some_Data_Query() + "WHERE SUBJECT_ID = @SUBJECT_ID"
            End If

            _Subject.Update_Subject_Data(setQuery)

            Change_EditState(False)

            _Subject = Subject.Get_Subject_Data(_Subject.SUBJECT_USERNAME)
        Else
            lblWrongPassword.Visible = True
        End If

        _BtnSaveCliked = False
    End Sub

    Private Sub Save_Subject_Data()
        With _Subject
            .SUBJECT_USERNAME = txtUserName.Text
            .SUBJECT_EMAIL = txtUserEmail.Text

            _Subject.SUBJECT_USER_PICTURE = _ResizeImage.ConvertImage(userPictureBox.Image)
        End With
    End Sub

    '*****///// END WHEN DATA WERE CHANGED ON ON CLICK BUTTON SAVE GO TO UPDATE ALL DATA IN DATA BASE

    '*****///// OPEN MY SOCIAL-MIDIA ACCOUNTS ON CLICK 
    Private Sub On_Click_Links(sender As System.Object, e As System.EventArgs) _
      Handles btnVk.Click, btnFaceBook.Click, btnInstagram.Click, btnLinkedin.Click

        Dim url As String = Nothing

        Dim GenericButton = DirectCast(sender, IconPictureBox)

        Select Case GenericButton.Name
            Case "btnVk"
                url = "https://vk.com/bogdan.naic"

            Case "btnFaceBook"
                url = "https://www.facebook.com/profile.php?id=100017275208092"

            Case "btnInstagram"
                url = "https://www.instagram.com/n1sb0/"

            Case "btnLinkedin"
                url = "https://www.linkedin.com/in/bohdan-sivak-b630921b2/"

        End Select

        Process.Start(url)
    End Sub
    '*****///// END OPEN MY SOCIAL-MIDIA ACCOUNTS ON CLICK 

    '*****///// OPEN OTHER FORM IN SETTINGS FORM
    Private Sub On_Click_Buttons(sender As System.Object, e As System.EventArgs) _
      Handles btnMyAccount.Click, btnPrivacyAndSefty.Click, btnVoiceAndVideo.Click, btnLanguage.Click

        _GenericButton = DirectCast(sender, GunaButton)

        Onclick_OpenForm(_GenericButton.Name)
    End Sub


    Private Sub Onclick_OpenForm(buttonName As String)

        pnlEditAccount.Visible = False

        If Not buttonName.Equals("btnMyAccount") Then
            Change_EditState(False)
        End If

        Select Case buttonName
            Case "btnPrivacyAndSefty"
                Dim privacyandSeftyForm As New PrivacyAndSeftyForm
                _ControlChildForm.OpenChildForm(privacyandSeftyForm, centerPanel, _CurrentChildForm)

            Case "btnLanguage"
                Dim languageForm As New LanguageForm
                _ControlChildForm.OpenChildForm(languageForm, centerPanel, _CurrentChildForm)

            Case "btnVoiceAndVideo"
                Dim voiceAndVideoForm As New VoiceAndVideoForm
                _ControlChildForm.OpenChildForm(voiceAndVideoForm, centerPanel, _CurrentChildForm)

            Case "btnMyAccount"
                If _CurrentChildForm IsNot Nothing Then
                    _CurrentChildForm.Close()
                End If
                pnlEditAccount.Visible = True
        End Select
    End Sub
    '*****///// END OPEN OTHER FORM IN SETTINGS FORM

    '*****///// BUTTON DELETE ACCOUT AND OPEN LOGIN FORM WHEN ACCOUNT WAS DELETED
    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        Dim result As MsgBoxResult = MessageBox.Show("Are you sure?" + vbCrLf + "Do you want to delete your Account?", "Attention!", MessageBoxButtons.YesNo)

        If result = MsgBoxResult.Yes Then
            'Need to delete all ref with this id with transactions
            '_Subject.Delete_Subject_Accout()
            OpenLoginForm()
        End If
    End Sub

    Private Sub OpenLoginForm()
        If Not Application.OpenForms().OfType(Of LoginForm).Any Then
            Dim logForm As New LoginForm
            logForm.Show()
        End If

        _Utility_Secure.Close_AllOpenedFormAndLeftOnlyOne("LoginForm")
    End Sub
    '*****///// END BUTTON DELETE ACCOUT AND OPEN LOGIN FORM WHEN ACCOUNT WAS DELETED

    Private Sub OnFocus_UserAndEmail_text(sender As Object, e As MouseEventArgs) Handles txtUserName.Click, txtUserEmail.Click
        Dim GenericText = DirectCast(sender, TextBox)

        If GenericText.Name.Equals("txtUserName") Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtUserName, lblUserName, pnlUserName, "left")
        ElseIf GenericText.Name.Equals("txtUserEmail") Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtUserEmail, lblEmail, pnlUserEmail, "left")
        End If
    End Sub

    Private Sub OnLeave_UserAndEmail_text(sender As Object, e As EventArgs) Handles txtUserName.Leave, txtUserEmail.Leave
        Dim GenericText = DirectCast(sender, TextBox)

        If GenericText.Name.Equals("txtUserName") Then
            _Utility_Style.Mouse_Leave_TextBox(txtUserName, lblUserName, pnlUserName, "left")
        ElseIf GenericText.Name.Equals("txtUserEmail") Then
            _Utility_Style.Mouse_Leave_TextBox(txtUserEmail, lblEmail, pnlUserEmail, "left")
        End If
    End Sub
End Class