Public Class DR_Subject_Friend

    Property _Subject_ID As Integer
    Property _SubjFriend_ID As Integer
    Property _QueryString As String

    Sub New()

    End Sub

    Sub New(subj_id As Integer, subjFriend_id As Integer, Optional qS As String = Nothing)
        _Subject_ID = subj_id
        _SubjFriend_ID = subjFriend_id
        _QueryString = qS
    End Sub

    Public Function Check_Friend_List() As Boolean

        If String.IsNullOrEmpty(_QueryString) Then
            _QueryString = MyConnection.Get_Subject_Friend
        End If

        Dim row As New DR_Subject_Friend
        Dim command As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader = Nothing
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = _QueryString
            reader = command.ExecuteReader()

            While reader.Read()
                row = New DR_Subject_Friend

                With row
                    ._Subject_ID = ReadValue(reader("USER_ID"))
                    ._SubjFriend_ID = ReadValue(reader("FRIEND_ID"))

                    If _Subject_ID = ._Subject_ID AndAlso _SubjFriend_ID = ._SubjFriend_ID Then
                        Return True
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

    Public Function Check_If_RequestData_Exist(checkBy As String, Optional user_1 As Integer = Nothing, Optional user_2 As Integer = Nothing) As Boolean

        If IsNothing(user_1) Or IsNothing(user_2) Then
            user_1 = _Subject_ID
            user_2 = _SubjFriend_ID
        End If

        Dim queryS As String = ""
        Dim row1 As String = ""
        Dim row2 As String = ""
        Dim row As New DR_Subject_Friend
        Dim command As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader = Nothing

        Select Case checkBy
            Case "Request"
                queryS = MyConnection.Get_Subject_Request
                row1 = "REQUEST_FROM"
                row2 = "REQUEST_TO"

            Case "Block"
                queryS = MyConnection.Get_Subject_BlockedFriends
                row1 = "USER_ID"
                row2 = "FRIEND_ID"
        End Select

        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = queryS
            reader = command.ExecuteReader()

            While reader.Read()
                row = New DR_Subject_Friend

                With row
                    ._Subject_ID = ReadValue(reader(row1))
                    ._SubjFriend_ID = ReadValue(reader(row2))

                    If user_1 = ._Subject_ID AndAlso user_2 = ._SubjFriend_ID Then
                        Return True
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

    Private Shared Function ReadValue(value As Object) As Object
        If IsDBNull(value) Then
            Return Nothing
        Else
            Return value
        End If
    End Function


End Class
