Public Class DR_Subject_Friend

    Property _Subject_ID
    Property _SubjFriend_ID

    Sub New()

    End Sub

    Sub New(subj_id As Integer, subjFriend_id As Integer)
        _Subject_ID = subj_id
        _SubjFriend_ID = subjFriend_id
    End Sub

    Public Function Check_Friend_List() As Boolean

        Dim row As New DR_Subject_Friend
        Dim command As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader = Nothing
        Dim queryS As String = MyConnection.Get_Subject_Friend
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = queryS
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

    Public Function Check_Friend_Request() As Boolean

        Dim row As New DR_Subject_Friend
        Dim command As New SqlClient.SqlCommand
        Dim reader As SqlClient.SqlDataReader = Nothing
        Dim queryS As String = MyConnection.Get_Subject_Request
        Dim connection As New SqlClient.SqlConnection(MyConnection.Get_Connection)

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = queryS
            reader = command.ExecuteReader()

            While reader.Read()
                row = New DR_Subject_Friend

                With row
                    ._Subject_ID = ReadValue(reader("REQUEST_FROM"))
                    ._SubjFriend_ID = ReadValue(reader("REQUEST_TO"))

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

    Private Shared Function ReadValue(value As Object) As Object
        If IsDBNull(value) Then
            Return Nothing
        Else
            Return value
        End If
    End Function


End Class
