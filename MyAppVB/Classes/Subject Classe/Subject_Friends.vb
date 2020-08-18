Class Subject_Friends
    Sub New()
    End Sub

    Property USER_ID As Integer
    Property FRIEND_ID As Integer
    Property FRIENDS_PICTURE As Byte()
    Property FRIENDS_USERNAME As String
    Property FRIENDS_STATE_ONLINE As String

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

                    If controlBy.Equals("Request") Then
                        sbjFriend.USER_ID = ReadValue(reader("REQUEST_FROM"))
                        sbjFriend.FRIEND_ID = ReadValue(reader("REQUEST_TO"))
                        ReadFromDataReader(sbjFriend, reader)
                    Else
                        sbjFriend.USER_ID = ReadValue(reader("USER_ID"))
                        sbjFriend.FRIEND_ID = ReadValue(reader("FRIEND_ID"))
                        ReadFromDataReader(sbjFriend, reader)
                    End If


                    listOfUserFriends.Add(sbjFriend)
                End While

                reader.Close()
                command.Dispose()
                connection.Close()
                connection.Dispose()

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

            Case "Request"
                query += "SELECT REQUEST_FROM, REQUEST_TO, tblU.SUBJECT_PICTURE, tblU.SUBJECT_USERNAME, tblU.SUBJECT_STATE_ONLINE " &
                "FROM TBL_PENDING_FRENDS_REQUEST "
                leftJoin = "LEFT JOIN TBL_USER_DATA AS tblU ON tblU.SUBJECT_ID = REQUEST_FROM WHERE REQUEST_TO = @USER_ID"

        End Select

        Return query + leftJoin
    End Function

    Public Shared Sub ReadFromDataReader(ByRef rec As Subject_Friends, ByVal reader As SqlClient.SqlDataReader)
        With rec
            .FRIENDS_PICTURE = ReadValue(reader("SUBJECT_PICTURE"))
            .FRIENDS_USERNAME = ReadValue(reader("SUBJECT_USERNAME"))
            .FRIENDS_STATE_ONLINE = ReadValue(reader("SUBJECT_STATE_ONLINE"))
        End With
    End Sub

    Private Shared Function ReadValue(value As Object) As Object
        If IsDBNull(value) Then
            Return Nothing
        Else
            Return value
        End If
    End Function
End Class
