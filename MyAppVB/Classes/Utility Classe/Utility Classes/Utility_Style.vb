Imports System.IO
Imports FontAwesome.Sharp
Imports Guna.UI.WinForms
Imports Microsoft.VisualBasic.PowerPacks

Public Class Utility_Style
    Property RedColor As String = "#e74c3c"
    Property DarkBlue As String = "#282828"
    Property MainColor As String = "#2ecc71"
    Property WhiteColor As String = "#ecf0f1"
    Property OrngColor As String = "#e67e22"
    Property LightBlue As String = "#3a3e44"
    Property GreenColor As String = "#27ae60"
    Property BorderColor As String = "#282828"
    Property BtnHoverColor As String = "#27ae60"
    Property LightDarkBlue As String = "#2f3136"
    Property BackGroundColor As String = "#36393f"
    Property LightDarkHoverButtonColor As String = "#34373c"
    Property LightDarkClickOnButtonColor As String = "#393c43"

    Public defaultLabel As New Label

    Public Sub On_Mouse_Click_Change_TextBox(ByRef txtBox As TextBox, ByRef lbl As Label, ByRef pnl As Panel, myText As String)
        lbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(MainColor))
        pnl.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(MainColor))
        pnl.Height = 2
        lbl.Visible = True
        txtBox.ForeColor = Color.White

        If txtBox.Text.Equals(myText) Then
            txtBox.Clear()
        End If
    End Sub

    Public Sub Mouse_Leave_TextBox(ByRef txtBox As TextBox, ByRef lbl As Label, ByRef pnl As Panel, myText As String)
        pnl.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(WhiteColor))
        pnl.Height = 1

        If String.IsNullOrEmpty(txtBox.Text) OrElse txtBox.Text.Equals(myText) Then
            lbl.ForeColor = Color.Silver
            txtBox.Text = myText
            txtBox.ForeColor = Color.Gray
            lbl.Visible = False
        End If

        If myText.Equals("left") Then
            lbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(WhiteColor))
        End If
    End Sub

    Public Sub ComboBox_On_Change_SelectedIndex(ByRef cmbBox As ComboBox, ByRef lbl As Label)
        If Not cmbBox.SelectedIndex = 0 Then
            lbl.Visible = True
        Else
            lbl.Visible = False
        End If
    End Sub

    Public Sub CheckBox_On_Change_State(ByRef chkBox As CheckBox)
        If chkBox.Checked Then
            chkBox.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(MainColor))
        Else
            chkBox.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(WhiteColor))
        End If
    End Sub

    Public Function ComboBox_Check_Data(ByRef cmbBoxDay As ComboBox, ByRef cmbBoxMonth As ComboBox, ByRef cmbBoxYear As ComboBox) As Boolean
        If cmbBoxDay.SelectedIndex = 0 OrElse cmbBoxMonth.SelectedIndex = 0 OrElse cmbBoxYear.SelectedIndex = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub Mouse_Up_To_Hide_Password(ByRef txtPassword As TextBox, text As String, ByRef btnSeePassword As IconPictureBox)
        If Not txtPassword.Text.Equals(text) Then
            txtPassword.PasswordChar = "*"
        End If
        btnSeePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
    End Sub

    Public Sub Mouse_Down_To_See_Password(ByRef txtPassword As TextBox, ByRef btnSeePassword As IconPictureBox)
        txtPassword.PasswordChar = ""
        btnSeePassword.IconChar = FontAwesome.Sharp.IconChar.Eye
    End Sub

    Public Sub Mouse_Hover_Button(ByRef btn As Button)
        btn.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(BtnHoverColor))
        btn.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(BackGroundColor))
    End Sub

    Public Sub Mouse_Leave_Button(ByRef btn As Button)
        btn.BackColor = Color.FromArgb(255, ColorTranslator.FromHtml(BackGroundColor))
        btn.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(MainColor))
        btn.FlatAppearance.BorderColor = Color.FromArgb(255, ColorTranslator.FromHtml(MainColor))
    End Sub

    Public Sub Hide_Password_Text(ByRef txtBox As TextBox, text As String)
        If Not txtBox.PasswordChar = "*" AndAlso Not txtBox.Text.Equals(text) Then
            txtBox.PasswordChar = "*"
        End If
    End Sub

    Public Sub Check_If_TextBox_Is_Empty(ByRef txtBox As TextBox, text As String, ByRef confBtn As Label)
        If txtBox.Text.Equals(text) Then
            Show_Error_Button(confBtn)
        End If
    End Sub

    Public Sub Show_Error_Button(ByRef confBtn As Label)
        confBtn.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(RedColor))
        confBtn.Text = "✖"
        confBtn.Visible = True
    End Sub

    Public Sub On_Empty_TextBox(ByRef txtBox As TextBox, text As String, Optional ByRef confBtn As Label = Nothing, Optional ByRef lblMsg As Label = Nothing)
        If txtBox.Text.Equals(text) Then
            txtBox.PasswordChar = ""

            If confBtn IsNot Nothing Then
                confBtn.Visible = False
            End If

            If lblMsg IsNot Nothing Then
                lblMsg.Visible = False
            End If
        End If
    End Sub

    Public Sub Change_Msg_Warning_To(ByRef confLbl As Label, text As String)
        If text.Equals("✔") Then
            confLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(GreenColor))
            confLbl.Text = "✔"
        Else
            confLbl.ForeColor = Color.FromArgb(255, ColorTranslator.FromHtml(RedColor))
            confLbl.Text = "✖"
        End If
    End Sub

    Public Sub Switch_Button(ByRef btnSwitch As OvalShape, ByRef btnSwitchBackGround As RectangleShape, ByRef btnSwitchState As Boolean)
        If btnSwitchState Then
            btnSwitch.Left -= 30
            btnSwitchState = False

            btnSwitch.FillColor = Color.White
            btnSwitch.BackColor = Color.Transparent
            btnSwitchBackGround.BorderColor = Color.White
            btnSwitchBackGround.FillColor = Color.FromArgb(255, ColorTranslator.FromHtml(BackGroundColor))
        Else
            btnSwitch.Left += 30
            btnSwitchState = True

            btnSwitch.BackColor = Color.White
            btnSwitchBackGround.FillColor = Color.White
            btnSwitch.FillColor = Color.FromArgb(255, ColorTranslator.FromHtml(BackGroundColor))
            btnSwitchBackGround.BorderColor = Color.FromArgb(255, ColorTranslator.FromHtml(BackGroundColor))
        End If
    End Sub

    Public Sub Select_Btn_UI(ByRef SelectedBtn As GunaButton, ByRef newPoint As Point)
        SelectedBtn.Height = 15

        SelectedBtn.Visible = True
        SelectedBtn.Location = newPoint
    End Sub

    Public Sub Selected_Btn_Cliked_UI(ByRef SelectedBtn As GunaButton, ByRef btn As GunaButton)
        SelectedBtn.Top -= 5
        SelectedBtn.Location = New Point(SelectedBtn.Location.X, btn.Location.Y + 10)

        btn.Radius = 10
    End Sub

    Public Sub Set_UserPicture(ByRef userPictureBox As PictureBox, userPicture As Byte())
        Dim img() As Byte

        img = userPicture

        Dim ms As New MemoryStream(img)

        userPictureBox.Image = Image.FromStream(ms)
    End Sub

    Public Sub Set_UserStateOnline(ByRef ovalOnline As OvalShape, userStateOnline As String)

        Select Case userStateOnline
            Case "Online"
                ovalOnline.FillColor = Color.FromArgb(255, ColorTranslator.FromHtml("#2ecc71"))
            Case "Offline", "Blocked"
                ovalOnline.FillColor = Color.Silver
        End Select

    End Sub
End Class