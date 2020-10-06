Public Class Subject

    Property SUBJECT_SALT As String
    Property SUBJECT_ID As Integer
    Property SUBJECT_EMAIL As String
    Property SUBJECT_USERNAME As String
    Property SUBJECT_PASSWORD As String
    Property SUBJECT_BIRTHDAY As String
    Property SUBJECT_USER_PICTURE As Byte()
    Property SUBJECT_STATE_ONLINE As String = "Offline"
    Property SUBJECT_EMAIL_NOTIFICATION As String

    Private _Utility_Style As New Utility_Style


    Private NewAccout As Boolean = False

    Public Sub ClearObj()
        SUBJECT_ID = 0
        NewAccout = False
        SUBJECT_SALT = Nothing
        SUBJECT_EMAIL = Nothing
        SUBJECT_USERNAME = Nothing
        SUBJECT_PASSWORD = Nothing
        SUBJECT_BIRTHDAY = Nothing
        SUBJECT_USER_PICTURE = Nothing
        SUBJECT_EMAIL_NOTIFICATION = Nothing
        SUBJECT_STATE_ONLINE = "Offline"
    End Sub

    Public Sub Insert_UserData_With_Transaction()
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection())
        Dim transaction As SqlClient.SqlTransaction = Nothing

        Try
            connection.Open()
            transaction = connection.BeginTransaction()

            Insert_All_Data(transaction, connection)

            ClearObj()

            connection.Close()
        Catch ex As Exception

            If Not IsNothing(transaction) Then
                transaction.Rollback()
            End If

            If Not IsNothing(connection) AndAlso connection.State = ConnectionState.Closed Then
                connection.Close()
            End If

            Throw New Exception("Errore: " + vbCrLf + ex.Message)
        End Try
    End Sub

    Public Sub Insert_All_Data(transazione As SqlClient.SqlTransaction, Connection As SqlClient.SqlConnection)
        Dim command As New SqlClient.SqlCommand
        Dim commandB As New SqlClient.SqlCommand

        Dim queryS As String = MyConnection.Get_Insert_Query_SubjectData()
        Dim querySB As String = MyConnection.Get_Insert_Query_Birthday()

        NewAccout = True

        Try
            With command
                .CommandText = queryS
                .Connection = Connection
                .Transaction = transazione

                AddParameters(command)

                .ExecuteNonQuery()
            End With

            With commandB
                .CommandText = querySB
                .Connection = Connection
                .Transaction = transazione

                AddParameters(commandB)

                .ExecuteNonQuery()
            End With

            transazione.Commit()

            NewAccout = False

            commandB.Connection.Close()
            commandB.Dispose()

            command.Connection.Close()
            command.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Update_Subject_Password()
        Dim command As New SqlClient.SqlCommand
        Dim query As String = MyConnection.Get_Update_Password_Query()
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection())

        Try
            connection.Open()

            With command
                .CommandText = query
                .Connection = connection

                .Parameters.AddWithValue("@SALT", SUBJECT_SALT)
                .Parameters.AddWithValue("@SUBJECT_EMAIL", SUBJECT_EMAIL)
                .Parameters.AddWithValue("@SUBJECT_PASSWORD", SUBJECT_PASSWORD)

                .ExecuteNonQuery()
            End With

            command.Connection.Close()
            command.Dispose()
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Update_Subject_Data(strQuery As String)
        Dim query As String = strQuery
        Dim command As New SqlClient.SqlCommand
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

        Try
            connection.Open()

            With command
                .Connection = connection
                .CommandText = query

                .Parameters.AddWithValue("@SALT", SUBJECT_SALT)
                .Parameters.AddWithValue("@SUBJECT_ID", SUBJECT_ID)
                .Parameters.AddWithValue("@SUBJECT_EMAIL", SUBJECT_EMAIL)
                .Parameters.AddWithValue("@SUBJECT_USERNAME", SUBJECT_USERNAME)
                .Parameters.AddWithValue("@SUBJECT_PASSWORD", SUBJECT_PASSWORD)
                .Parameters.Add("@SUBJECT_PICTURE", SqlDbType.Image).Value = SUBJECT_USER_PICTURE
            End With

            command.ExecuteNonQuery()

            command.Connection.Close()
            command.Dispose()
            connection.Close()
            connection.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function Get_Subject_Data_By(userName As String)
        Dim subject As New Subject

        If Not String.IsNullOrEmpty(userName) Then
            Dim Connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)
            Dim command As New SqlClient.SqlCommand

            Dim login As String
            Dim strQuery As String

            If userName.Contains("@") Then
                login = "@EMAIL"
                strQuery = " WHERE SUBJECT_EMAIL = @EMAIL"
            Else
                login = "@USERNAME"
                strQuery = " WHERE SUBJECT_USERNAME = @USERNAME"
            End If

            Try
                With command
                    .CommandText = MyConnection.Get_Base_Select_SujectData() + strQuery
                    .Connection = Connection

                    .Parameters.AddWithValue(login, userName)
                End With

                command.Connection.Open()
                Dim reader As SqlClient.SqlDataReader = command.ExecuteReader()

                If reader.Read Then
                    ReadFromDataReader(subject, reader)
                End If

                reader.Close()
                command.Dispose()
                Connection.Close()
                Connection.Dispose()
            Catch ex As Exception
                MessageBox.Show("Can't read data :(" + vbCrLf + ex.Message, "ERRORE")
            End Try

        End If

        Return subject
    End Function

    Public Shared Function Get_SubjectByID(user_id As Integer)
        Dim subject As New Subject

        Dim Connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)
        Dim command As New SqlClient.SqlCommand

        Try
            With command
                .CommandText = MyConnection.Get_SubjectData_ByID
                .Connection = Connection

                .Parameters.AddWithValue("@USER_ID", user_id)
                .Connection.Open()
            End With

            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader()

            If reader.Read Then
                ReadFromDataReader(subject, reader)
            End If

            reader.Close()
            command.Dispose()
            Connection.Close()
            Connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Can't read data :(" + vbCrLf + ex.Message, "ERRORE")
        End Try

        Return subject
    End Function

    Public Sub Delete_Subject_Accout()
        Try
            Dim conn As New SqlClient.SqlConnection(MyConnection.Get_Connection)
            Dim queryS As String = MyConnection.Get_Delete_By_IDQuery
            Dim command As New SqlClient.SqlCommand

            conn.Open()

            With command
                .CommandText = queryS
                .Connection = conn

                .Parameters.AddWithValue("@SUBJECT_ID", SUBJECT_ID)
                .ExecuteNonQuery()
            End With

            command.Connection.Close()
            command.Dispose()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert_Pending_Request(request_to As Integer, Optional transazione As SqlClient.SqlTransaction = Nothing,
                                                    Optional cmd As SqlClient.SqlCommand = Nothing, Optional connection As SqlClient.SqlConnection = Nothing)
        Try
            Dim conn As SqlClient.SqlConnection
            Dim command As New SqlClient.SqlCommand
            Dim queryS As String = MyConnection.Get_Insert_PendingReq()

            If Not connection Is Nothing Then
                command = cmd
                conn = connection
            Else
                command = New SqlClient.SqlCommand
                conn = New SqlClient.SqlConnection(MyConnection.Get_Connection)

                conn.Open()
            End If

            With command
                .CommandText = queryS
                .Connection = conn
                .Transaction = transazione

                .Parameters.AddWithValue("@REQUEST_FROM", SUBJECT_ID)
                .Parameters.AddWithValue("@REQUEST_TO", request_to)
                .ExecuteNonQuery()
            End With

            If connection Is Nothing Then
                command.Connection.Close()
                command.Dispose()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub ReadFromDataReader(ByRef rec As Subject, ByVal reader As SqlClient.SqlDataReader)
        With rec
            .SUBJECT_ID = ReadValue(reader("SUBJECT_ID"))
            .SUBJECT_SALT = ReadValue(reader("SALT"))
            .SUBJECT_EMAIL = ReadValue(reader("SUBJECT_EMAIL"))
            .SUBJECT_USERNAME = ReadValue(reader("SUBJECT_USERNAME"))
            .SUBJECT_PASSWORD = ReadValue(reader("SUBJECT_PASSWORD"))
            .SUBJECT_USER_PICTURE = ReadValue(reader("SUBJECT_PICTURE"))
            .SUBJECT_STATE_ONLINE = ReadValue(reader("SUBJECT_STATE_ONLINE"))
        End With
    End Sub

    Public Sub AddParameters(ByRef cmd As SqlClient.SqlCommand)
        Dim utisParam = Nothing

        With cmd
            .Parameters.AddWithValue("@SUBJECT_ID", SUBJECT_ID)
            .Parameters.AddWithValue("@SALT", SUBJECT_SALT)
            .Parameters.AddWithValue("@SUBJECT_EMAIL", SUBJECT_EMAIL)
            .Parameters.AddWithValue("@SUBJECT_USERNAME", SUBJECT_USERNAME)
            .Parameters.AddWithValue("@SUBJECT_PASSWORD", SUBJECT_PASSWORD)
            .Parameters.AddWithValue("@SUBJECT_BIRTHDAY", SUBJECT_BIRTHDAY)
            .Parameters.AddWithValue("@SUBJECT_EMAIL_NOTIFICATION", SUBJECT_EMAIL_NOTIFICATION)
            .Parameters.AddWithValue("@SUBJECT_STATE_ONLINE", SUBJECT_STATE_ONLINE)

            If Not NewAccout Then
                .Parameters.AddWithValue("@SUBJECT_PICTURE", SUBJECT_USER_PICTURE)
            Else
                Get_Standard_Picture()
                .Parameters.AddWithValue("@SUBJECT_PICTURE", SUBJECT_USER_PICTURE)
            End If
        End With
    End Sub

    Private Sub Get_Standard_Picture()
        Dim passPic As New PictureBox
        Dim _ResizeImage As New ResizeImage

        passPic.Image = My.Resources.NewUserPicture
        passPic.Image = ResizeImage.ResizeImage(passPic.Image, 300, 300)

        SUBJECT_USER_PICTURE = _ResizeImage.ConvertImage(passPic.Image)
    End Sub

    Private Shared Function ReadValue(value As Object) As Object
        If IsDBNull(value) Then
            Return Nothing
        Else
            Return value
        End If
    End Function
End Class