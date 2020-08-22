Class Subject_Friends
    Sub New()
    End Sub

    Property USER_ID As Integer
    Property FRIEND_ID As Integer
    Property FRIENDS_PICTURE As Byte()
    Property FRIENDS_USERNAME As String
    Property FRIENDS_STATE_ONLINE As String

    Private _Subject_ID As Integer
    Private _SubFriend_ID As Integer

    Public Sub Clean()
        USER_ID = 0
        FRIEND_ID = 0
        FRIENDS_PICTURE = Nothing
        FRIENDS_USERNAME = Nothing
        FRIENDS_STATE_ONLINE = Nothing
    End Sub

    Public Shared Function Get_SubjectFriends_ByID(userID As Integer, controlBy As String) As List(Of Subject_Friends)
        Dim listOfUserFriends As New List(Of Subject_Friends)

        If Not String.IsNullOrEmpty(userID) Then
            Dim sbjFriend As New Subject_Friends
            Dim reader As SqlClient.SqlDataReader
            Dim command As New SqlClient.SqlCommand
            Dim strQuery As String = Get_Query(controlBy)
            Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

            Try
                With command
                    .Connection = connection
                    .CommandText = strQuery
                    .Parameters.Add("@USER_ID", SqlDbType.Int)
                    .Parameters.Item("@USER_ID").Value = userID
                End With

                sbjFriend.Clean()

                command.Connection.Open()
                reader = command.ExecuteReader()

                While reader.Read
                    sbjFriend = New Subject_Friends

                    Select Case controlBy
                        Case "Friend Request"
                            sbjFriend.USER_ID = ReadValue(reader("REQUEST_FROM"))
                            sbjFriend.FRIEND_ID = ReadValue(reader("REQUEST_TO"))

                        Case "Outgoing Friend Request"
                            sbjFriend.USER_ID = ReadValue(reader("REQUEST_TO"))
                            sbjFriend.FRIEND_ID = ReadValue(reader("REQUEST_FROM"))

                        Case Else
                            sbjFriend.USER_ID = ReadValue(reader("USER_ID"))
                            sbjFriend.FRIEND_ID = ReadValue(reader("FRIEND_ID"))
                    End Select

                    ReadFromDataReader(sbjFriend, reader)

                    listOfUserFriends.Add(sbjFriend)
                End While

                reader.Close()
                command.Connection.Close()
                command.Dispose()
            Catch ex As Exception
                Throw ex
            End Try
        End If

        Return listOfUserFriends
    End Function

    Public Shared Function Get_Query(str As String)
        Dim query As String = ""
        Dim leftJoin As String = "LEFT JOIN TBL_USER_DATA AS tblU ON tblU.SUBJECT_ID = FRIEND_ID WHERE USER_ID = @USER_ID"

        Select Case str
            Case "DM", "All", "Online"
                query += MyConnection.Get_SubjectFriends_ByIdQuery + "FROM TBL_USER_FRIENDS "

            Case "Chat"
                query += MyConnection.Get_SubjectFriends_ByIdQuery + "FROM TBL_HAVE_CHAT_WITH_USER "

            Case "Blocked"
                query += MyConnection.Get_SubjectFriends_ByIdQuery + "FROM TBL_BLOCKED_FRIENDS "

            Case "Friend Request", "Outgoing Friend Request"
                query += "SELECT REQUEST_FROM, REQUEST_TO, tblU.SUBJECT_PICTURE, tblU.SUBJECT_USERNAME, tblU.SUBJECT_STATE_ONLINE " &
                "FROM TBL_PENDING_FRENDS_REQUEST "
                leftJoin = "LEFT JOIN TBL_USER_DATA AS tblU ON tblU.SUBJECT_ID = "
        End Select

        If str.Equals("Friend Request") Then
            leftJoin += "REQUEST_FROM WHERE REQUEST_TO = @USER_ID"

        ElseIf str.Equals("Outgoing Friend Request") Then
            leftJoin += "REQUEST_TO WHERE REQUEST_FROM = @USER_ID"

        End If

        Return query + leftJoin
    End Function

    Public Shared Sub ReadFromDataReader(ByRef rec As Subject_Friends, ByVal reader As SqlClient.SqlDataReader)
        With rec
            .FRIENDS_PICTURE = ReadValue(reader("SUBJECT_PICTURE"))
            .FRIENDS_USERNAME = ReadValue(reader("SUBJECT_USERNAME"))
            .FRIENDS_STATE_ONLINE = ReadValue(reader("SUBJECT_STATE_ONLINE"))
        End With
    End Sub

    Public Sub Update_DataWith_Transaction(subject_id As Integer, friend_id As Integer)

        _Subject_ID = subject_id
        _SubFriend_ID = friend_id

        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection())
        Dim transaction As SqlClient.SqlTransaction = Nothing

        Try
            connection.Open()
            transaction = connection.BeginTransaction()

            Update_Date_T(transaction, connection)

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

    Private Sub Update_Date_T(transazione As SqlClient.SqlTransaction, Connection As SqlClient.SqlConnection)
        Dim strQuery As String
        Dim commandInsert As New SqlClient.SqlCommand
        Dim commandDelete As New SqlClient.SqlCommand

        Try
            strQuery = MyConnection.Get_Delete_Pending_Request
            Delete_Reference_OfTwoFriends(_SubFriend_ID, _Subject_ID, strQuery, transazione, commandDelete, Connection)

            strQuery = MyConnection.Insert_Query_Add_Friend
            Add_User_To_FriendList(_Subject_ID, _SubFriend_ID, strQuery, transazione, commandInsert, Connection)

            transazione.Commit()

            commandInsert.Connection.Close()
            commandInsert.Dispose()

            commandDelete.Connection.Close()
            commandDelete.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub Delete_Reference_OfTwoFriends(user_1 As Integer, user_2 As Integer, strQuery As String, Optional transazione As SqlClient.SqlTransaction = Nothing,
                                                    Optional cmd As SqlClient.SqlCommand = Nothing, Optional connection As SqlClient.SqlConnection = Nothing)

        Dim queryS As String = strQuery
        Dim command As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection

        Try
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

                .Parameters.AddWithValue("@USER_1", user_1)
                .Parameters.AddWithValue("@USER_2", user_2)
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

    Public Shared Sub Add_User_To_FriendList(user_1 As Integer, user_2 As Integer, strQuery As String, Optional transazione As SqlClient.SqlTransaction = Nothing,
                                                    Optional cmd As SqlClient.SqlCommand = Nothing, Optional connection As SqlClient.SqlConnection = Nothing)
        Dim queryS As String = strQuery
        Dim command As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection

        Try
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

                .Parameters.AddWithValue("@USER_1", user_1)
                .Parameters.AddWithValue("@USER_2", user_2)
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

    Private Shared Function ReadValue(value As Object) As Object
        If IsDBNull(value) Then
            Return Nothing
        Else
            Return value
        End If
    End Function
End Class
