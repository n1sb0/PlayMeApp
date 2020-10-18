Public Class Utility_Secure
    '*****///// VARS
    Private _MinLength As Boolean = False
    Private _SomeNumbers As Boolean = False
    Private _UpperLetter As Boolean = False
    Private _SpecialChars As Boolean = False

    '*****///// CLASSES
    Private _Utility_Style As New Utility_Style

    Public Sub Control_Email(ByRef txtEmail As TextBox, ByRef confEmail As Label, ByRef lblMsgEmail As Label)
        Dim numOfC As Integer = CountCharacter(txtEmail.Text, "@")

        If Not txtEmail.Text.Equals("EMAIL ADDRESS") Then

            If txtEmail.Text.Contains(".") AndAlso (numOfC = 1) Then
                _Utility_Style.Change_Msg_Warning_To(confEmail, "✔")
            Else
                _Utility_Style.Change_Msg_Warning_To(confEmail, "✖")
                lblMsgEmail.Visible = True
            End If
            confEmail.Visible = True
        Else
            confEmail.Visible = False
        End If
    End Sub

    Public Sub Confront_Passwords(ByRef txtConfPassword As TextBox, ByRef txtPassword As TextBox, ByRef confConfPass As Label, ByRef lblMsgConfPass As Label, text As String)
        If Not txtConfPassword.Text.Equals(txtPassword.Text) AndAlso Not txtConfPassword.Text.Equals(text) Then
            _Utility_Style.Change_Msg_Warning_To(confConfPass, "✖")

            confConfPass.Visible = True
            lblMsgConfPass.Visible = True
        Else
            _Utility_Style.Change_Msg_Warning_To(confConfPass, "✔")

            lblMsgConfPass.Visible = False
        End If
    End Sub

    Public Sub On_Password_Change(ByRef txtMainPassword As TextBox, ByRef txtConfPassword As TextBox, ByRef lblMsgPass As Label, ByRef lblMsgConfPass As Label, ByRef confPass As Label, ByRef confConfPass As Label, ByRef pnlPass As Panel, ByRef lblPass As Label, txtMainPass As String)
        If Not lblPass.Visible Then
            _Utility_Style.On_Mouse_Click_Change_TextBox(txtMainPassword, lblPass, pnlPass, "NEW PASSWORD")
        End If

        _Utility_Style.Hide_Password_Text(txtMainPassword, txtMainPass)

        If Not txtConfPassword.Text.Equals(txtMainPassword.Text) Then
            _Utility_Style.Change_Msg_Warning_To(confConfPass, "✖")
        Else
            _Utility_Style.Change_Msg_Warning_To(confConfPass, "✔")
            lblMsgConfPass.Visible = False
        End If

        confPass.Visible = True

        WarningMsgPassword(txtMainPassword, lblMsgPass, confPass)
    End Sub

    Public Sub WarningMsgPassword(ByRef txtMainPassword As TextBox, ByRef lblMsgPass As Label, Optional confPass As Label = Nothing)
        _UpperLetter = CheckUpperLetter(txtMainPassword.Text)
        _SpecialChars = ContainsSpecialChars(txtMainPassword.Text)
        _MinLength = txtMainPassword.Text.Length >= 8
        _SomeNumbers = ContainsNumbers(txtMainPassword.Text)

        If Not _UpperLetter Then
            If Not lblMsgPass.Text.Contains(" Upper Letter,") Then
                lblMsgPass.Text += " Upper Letter,"
            End If
        Else
            lblMsgPass.Text = lblMsgPass.Text.Replace(" Upper Letter,", "").Trim()
        End If

        If Not _SpecialChars Then
            If Not lblMsgPass.Text.Contains(" Special Char,") Then
                lblMsgPass.Text += " Special Char,"
            End If
        Else
            lblMsgPass.Text = lblMsgPass.Text.Replace(" Special Char,", "").Trim()
        End If

        If Not _MinLength Then
            If Not lblMsgPass.Text.Contains(" Min Length = 8,") Then
                lblMsgPass.Text += " Min Length = 8,"
            End If
        Else
            lblMsgPass.Text = lblMsgPass.Text.Replace(" Min Length = 8,", "").Trim()
        End If

        If Not _SomeNumbers Then
            If Not lblMsgPass.Text.Contains(" Some Numbers,") Then
                lblMsgPass.Text += " Some Numbers,"
            End If
        Else
            lblMsgPass.Text = lblMsgPass.Text.Replace(" Some Numbers,", "").Trim()
        End If


        If _UpperLetter AndAlso _MinLength AndAlso _SpecialChars AndAlso _SomeNumbers Then
            If confPass IsNot Nothing Then
                _Utility_Style.Change_Msg_Warning_To(confPass, "✔")
            End If

            lblMsgPass.Visible = False
        Else
            If confPass IsNot Nothing Then
                _Utility_Style.Change_Msg_Warning_To(confPass, "✖")

                If Not confPass.Text.Equals("✔") Then
                    lblMsgPass.Visible = True
                End If
            Else
                If Not _UpperLetter AndAlso Not _MinLength AndAlso Not _SpecialChars AndAlso Not _SomeNumbers Then
                    lblMsgPass.Visible = True
                End If
            End If
        End If
    End Sub

    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Return value.Count(Function(c As Char) c = ch)
    End Function

    Private Function CheckUpperLetter(text As String) As Boolean
        Dim ris As Boolean = False

        For Each lt As Char In text
            If lt.ToString() = Char.ToUpper(lt).ToString() Then

                If Not ContainsSpecialChars(lt) AndAlso Not ContainsNumbers(lt) Then
                    ris = True
                End If
            End If
        Next

        Return ris
    End Function

    Public Function ContainsSpecialChars(s As String) As Boolean
        Return s.IndexOfAny("[~`!@#$%^&*()-+=|{}':;.,<>/?]".ToCharArray) <> -1
    End Function

    Public Function ContainsNumbers(s As String) As Boolean
        Return s.IndexOfAny("[1234567890]".ToCharArray) <> -1
    End Function

    Public Sub Close_AllOpenedFormAndLeftOnlyOne(NotCloseForm As String)
        Dim forms As Form() = Application.OpenForms.Cast(Of Form)().ToArray()

        For Each thisForm As Form In forms
            If thisForm.Name <> NotCloseForm Then thisForm.Close()
        Next
    End Sub
End Class
