Class Subject_Friends
    Sub New()
    End Sub

    Property USER_ID As Integer
    Property FRIEND_ID As Integer
    Property HAVE_CHAT As String
    Property FRIENDS_PICTURE As Byte()
    Property FRIENDS_USERNAME As String
    Property FRIENDS_STATE_ONLINE As String

    Public Sub Clean()
        USER_ID = 0
        FRIEND_ID = 0
        HAVE_CHAT = Nothing
        FRIENDS_PICTURE = Nothing
        FRIENDS_USERNAME = Nothing
        FRIENDS_STATE_ONLINE = Nothing
    End Sub

    Public Shared Function Get_SubjectFriends_ByID(userID As Integer) As List(Of Subject_Friends)
        Dim listOfUserFriends As New List(Of Subject_Friends)


        If Not String.IsNullOrEmpty(userID) Then
            Dim sbjFriend As New Subject_Friends
            Dim reader As SqlClient.SqlDataReader
            Dim command As New SqlClient.SqlCommand
            Dim strQuery As String = MyConnection.Get_SubjectFriends_ByIdQuery()
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

                If reader.Read Then
                    sbjFriend = New Subject_Friends

                    ReadFromDataReader(sbjFriend, reader)

                    listOfUserFriends.Add(sbjFriend)
                End If

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

    Public Shared Sub ReadFromDataReader(ByRef rec As Subject_Friends, ByVal reader As SqlClient.SqlDataReader)
        With rec
            .USER_ID = ReadValue(reader("USER_ID"))
            .FRIEND_ID = ReadValue(reader("FRIEND_ID"))
            .HAVE_CHAT = ReadValue(reader("HAVE_CHAT"))
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
