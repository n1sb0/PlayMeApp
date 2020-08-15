Public Class DR_Subject

    Public Class Row_Subject
        Property SUBJECT_SALT As String
        Property SUBJECT_ID As Integer
        Property SUBJECT_EMAIL As String
        Property SUBJECT_USERNAME As String
        Property SUBJECT_PASSWORD As String
        Property SUBJECT_BIRTHDAY As String
        Property SUBJECT_USER_PICTURE As Byte
        Property SUBJECT_EMAIL_NOTIFICATION As String
    End Class

    Public Shared Function Get_Subject_Login_And_Password(userName As String, userPassword As String) As Boolean
        Dim row As New Row_Subject
        Dim command As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader = Nothing
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

        Dim login As String
        If userName.Contains("@") Then
            login = "SUBJECT_EMAIL"
        Else
            login = "SUBJECT_USERNAME"
        End If

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = MyConnection.Get_Base_Select_SujectData()
            reader = command.ExecuteReader()

            While reader.Read()
                row = New Row_Subject

                With row
                    .SUBJECT_USERNAME = ReadValue(reader(login))
                    If .SUBJECT_USERNAME.Equals(userName) Then
                        .SUBJECT_PASSWORD = ReadValue(reader("SUBJECT_PASSWORD"))
                        userPassword = Encryption.HashString(userPassword)
                        .SUBJECT_SALT = ReadValue(reader("SALT"))

                        userPassword = Encryption.HashString(String.Format("{0}{1}", userPassword, .SUBJECT_SALT))

                        If .SUBJECT_PASSWORD.Equals(userPassword) Then
                            Return True
                        End If
                    End If
                End With
            End While

            reader.Close()
            command.Dispose()
            connection.Close()
            connection.Dispose()

            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function Get_Subject_By(value As String, userData As String) As Boolean
        Dim row As New Row_Subject
        Dim command As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader = Nothing
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

        Dim dataToRead As String = Value_Equel(value)

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = MyConnection.Get_Base_Select_SujectData()
            reader = command.ExecuteReader()

            While reader.Read()
                Dim Subject_Element As String = ReadValue(reader(dataToRead))
                If Subject_Element.Equals(userData) Then
                    Return True
                End If
            End While

            reader.Close()
            command.Dispose()
            connection.Close()
            connection.Dispose()

            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Shared Function ReadValue(value As Object) As Object
        If IsDBNull(value) Then
            Return Nothing
        Else
            Return value
        End If
    End Function

    Public Shared Function Value_Equel(value As String)
        If value.Equals("username") Then
            Return "SUBJECT_USERNAME"
        Else
            Return "SUBJECT_EMAIL"
        End If
    End Function
End Class
