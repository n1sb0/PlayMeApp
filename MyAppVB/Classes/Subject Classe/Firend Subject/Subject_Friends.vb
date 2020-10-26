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
                            If ReadValue(reader("USER_ID")) = userID Then
                                sbjFriend.USER_ID = ReadValue(reader("USER_ID"))
                                sbjFriend.FRIEND_ID = ReadValue(reader("FRIEND_ID"))
                            Else
                                sbjFriend.USER_ID = ReadValue(reader("FRIEND_ID"))
                                sbjFriend.FRIEND_ID = ReadValue(reader("USER_ID"))
                            End If

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
        Dim leftJoin As String = ""

        Select Case str
            Case "DM", "All", "Online"
                query += MyConnection.Get_SubjectFriends_ByIdQuery + "FROM TBL_USER_FRIENDS as tuf "

            Case "Chat"
                query += MyConnection.Get_SubjectFriends_ByIdQuery + "FROM TBL_HAVE_CHAT_WITH_USER "

            Case "Blocked"
                query += MyConnection.Get_SubjectFriends_ByIdQuery + "FROM TBL_BLOCKED_FRIENDS "

            Case "Friend Request", "Outgoing Friend Request"
                query += "SELECT REQUEST_FROM, REQUEST_TO, tblU.SUBJECT_PICTURE, tblU.SUBJECT_USERNAME, tblUSO.SUBJECT_STATE_ONLINE FROM TBL_PENDING_FRENDS_REQUEST "

        End Select

        leftJoin = Get_Join_Query(str)

        Return query + leftJoin
    End Function

    Public Shared Function Get_Join_Query(str As String) As String
        Dim reqStr As String = ""
        Dim leftJoin As String = ""

        Select Case str
            Case "DM", "All", "Online"
                leftJoin = " LEFT JOIN TBL_USER_STATE_ONLINE AS tblUSO ON tblUSO.SUBJECT_ID = CASE WHEN tuf.FRIEND_ID = @USER_ID THEN tuf.USER_ID ELSE tuf.FRIEND_ID END" &
                           " LEFT JOIN TBL_USER_DATA AS tblU ON tblU.SUBJECT_ID = CASE WHEN tuf.FRIEND_ID = @USER_ID THEN tuf.USER_ID ELSE tuf.FRIEND_ID END" &
                           " WHERE USER_ID = @USER_ID OR FRIEND_ID = @USER_ID "


            Case "Chat", "Blocked"
                leftJoin = " LEFT JOIN TBL_USER_STATE_ONLINE AS tblUSO ON tblUSO.SUBJECT_ID = FRIEND_ID" &
                           " LEFT JOIN TBL_USER_DATA AS tblU ON tblU.SUBJECT_ID = FRIEND_ID"


            Case "Friend Request", "Outgoing Friend Request"
                If str.Equals("Friend Request") Then
                    reqStr = " REQUEST_FROM"
                    leftJoin = Get_JoinFor_FriendRequest(reqStr)
                    leftJoin += " WHERE REQUEST_TO = @USER_ID"

                ElseIf str.Equals("Outgoing Friend Request") Then
                    reqStr = " REQUEST_TO"
                    leftJoin = Get_JoinFor_FriendRequest(reqStr)
                    leftJoin += " WHERE REQUEST_FROM = @USER_ID"
                End If
        End Select

        Return leftJoin
    End Function

    Private Shared Function Get_JoinFor_FriendRequest(reqStr As String)
        Dim joinStr = " LEFT JOIN TBL_USER_STATE_ONLINE AS tblUSO ON tblUSO.SUBJECT_ID = " + reqStr &
                      " LEFT JOIN TBL_USER_DATA AS tblU ON tblU.SUBJECT_ID = " + reqStr

        Return joinStr
    End Function

    Public Shared Sub ReadFromDataReader(ByRef rec As Subject_Friends, ByVal reader As SqlClient.SqlDataReader)
        With rec
            .FRIENDS_PICTURE = ReadValue(reader("SUBJECT_PICTURE"))
            .FRIENDS_USERNAME = ReadValue(reader("SUBJECT_USERNAME"))
            .FRIENDS_STATE_ONLINE = ReadValue(reader("SUBJECT_STATE_ONLINE"))
        End With
    End Sub

    Public Sub UpdateData_With_Transaction(subject_id As Integer, friend_id As Integer, UpdateBy As String)

        _Subject_ID = subject_id
        _SubFriend_ID = friend_id

        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection())
        Dim transaction As SqlClient.SqlTransaction = Nothing

        Try
            connection.Open()
            transaction = connection.BeginTransaction()

            Select Case UpdateBy
                Case "Accept"
                    Accept_FriendRequest_UpdateData(transaction, connection)
                Case "Delete"
                    DeleteFriend_FromFriendList_UpdateData(transaction, connection)
                Case "ADD"
                    AddFriend_ToFriendList_UpdateData(transaction, connection)
                Case "Block"
                    BlockFriend_FromFriendList_UpdateData(transaction, connection)
            End Select

            transaction.Commit()
            connection.Close()
        Catch ex As Exception

            If Not IsNothing(transaction) Then
                transaction.Rollback()
            End If

            If Not IsNothing(connection) AndAlso Not connection.State = ConnectionState.Closed Then
                connection.Close()
            End If

            Throw New Exception("Errore! : " + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub AddFriend_ToFriendList_UpdateData(ByRef transazione As SqlClient.SqlTransaction, ByRef Connection As SqlClient.SqlConnection)
        Dim subj As Subject
        Dim strQuery As String
        Dim dr_subjFriend As New DR_Subject_Friend
        Dim commandRequest As New SqlClient.SqlCommand
        Dim commandUnBlock As New SqlClient.SqlCommand

        Try
            subj = Subject.Get_SubjectByID(_Subject_ID)
            subj.Insert_Pending_Request(_SubFriend_ID, transazione, commandRequest, Connection)

            If dr_subjFriend.Check_If_RequestData_Exist("Block", _Subject_ID, _SubFriend_ID) Then

                strQuery = MyConnection.Get_UnBlock_Query
                Subject_Friends.Create_Reference_OfTwoSubjects(_Subject_ID, _SubFriend_ID, strQuery, transazione, commandUnBlock, Connection)
            End If

            commandRequest.Dispose()
            commandUnBlock.Dispose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Accept_FriendRequest_UpdateData(ByRef transazione As SqlClient.SqlTransaction, ByRef Connection As SqlClient.SqlConnection)
        Dim strQuery As String
        Dim commandInsert As New SqlClient.SqlCommand
        Dim commandDelete As New SqlClient.SqlCommand
        Dim commandInsert2 As New SqlClient.SqlCommand

        Try
            strQuery = MyConnection.Get_Delete_Pending_Request
            Create_Reference_OfTwoSubjects(_SubFriend_ID, _Subject_ID, strQuery, transazione, commandDelete, Connection)

            strQuery = MyConnection.Insert_Query_Add_Friend
            Add_User_To_FriendList(_Subject_ID, _SubFriend_ID, strQuery, transazione, commandInsert, Connection)

            commandInsert.Dispose()
            commandInsert2.Dispose()
            commandDelete.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DeleteFriend_FromFriendList_UpdateData(ByRef transazione As SqlClient.SqlTransaction, ByRef Connection As SqlClient.SqlConnection)
        Dim strQuery As String
        Dim subj As Subject
        Dim commandDeleteUser1 As New SqlClient.SqlCommand
        Dim commandDeleteUser2 As New SqlClient.SqlCommand
        Dim commandPendingRequest As New SqlClient.SqlCommand

        Try
            strQuery = MyConnection.Delete_From_FriendList()
            Create_Reference_OfTwoSubjects(_SubFriend_ID, _Subject_ID, strQuery, transazione, commandDeleteUser2, Connection)
            Create_Reference_OfTwoSubjects(_Subject_ID, _SubFriend_ID, strQuery, transazione, commandDeleteUser1, Connection)

            subj = Subject.Get_SubjectByID(_SubFriend_ID)
            subj.Insert_Pending_Request(_Subject_ID, transazione, commandPendingRequest, Connection)

            commandPendingRequest.Dispose()
            commandDeleteUser1.Dispose()
            commandDeleteUser2.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BlockFriend_FromFriendList_UpdateData(ByRef transazione As SqlClient.SqlTransaction, ByRef Connection As SqlClient.SqlConnection)
        Dim strQuery As String
        Dim subj As Subject
        Dim commandDeleteUser1 As New SqlClient.SqlCommand
        Dim commandDeleteUser2 As New SqlClient.SqlCommand
        Dim commandBlock As New SqlClient.SqlCommand

        Try
            strQuery = MyConnection.Delete_From_FriendList()
            Create_Reference_OfTwoSubjects(_SubFriend_ID, _Subject_ID, strQuery, transazione, commandDeleteUser2, Connection)
            Create_Reference_OfTwoSubjects(_Subject_ID, _SubFriend_ID, strQuery, transazione, commandDeleteUser1, Connection)

            subj = Subject.Get_SubjectByID(_SubFriend_ID)
            strQuery = MyConnection.Insert_Add_ToBlockList_Query()
            Create_Reference_OfTwoSubjects(_Subject_ID, _SubFriend_ID, strQuery, transazione, commandBlock, Connection)


            commandBlock.Dispose()
            commandDeleteUser1.Dispose()
            commandDeleteUser2.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub Create_Reference_OfTwoSubjects(user_1 As Integer, user_2 As Integer, strQuery As String, ByRef Optional transazione As SqlClient.SqlTransaction = Nothing,
                                                    Optional cmd As SqlClient.SqlCommand = Nothing, ByRef Optional connection As SqlClient.SqlConnection = Nothing)

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
            End If
            command.Dispose()

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
            End If
            command.Dispose()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Insert_Chat_With()
        Try
            Dim conn As New SqlClient.SqlConnection(MyConnection.Get_Connection)
            Dim queryS As String = MyConnection.Get_Insert_ChatWith()
            Dim command As New SqlClient.SqlCommand

            conn.Open()

            With command
                .CommandText = queryS
                .Connection = conn

                .Parameters.AddWithValue("@USER_ID", USER_ID)
                .Parameters.AddWithValue("@FRIEND_ID", FRIEND_ID)
                .ExecuteNonQuery()
            End With

            command.Connection.Close()
            command.Dispose()
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
