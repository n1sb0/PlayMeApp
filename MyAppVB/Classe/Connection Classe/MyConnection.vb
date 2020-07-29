Public Class MyConnection
    Public Shared Function Get_Connection() As String
        Dim ConnQuery As String = "*****"
        Return ConnQuery
    End Function

    Public Shared Function Get_Insert_Query_SubjectData() As String
        Dim query As String = "INSERT INTO TBL_USER_DATA (SUBJECT_USERNAME, SUBJECT_EMAIL, SUBJECT_PASSWORD, SALT ,SUBJECT_EMAIL_NOTIFICATION, SUBJECT_PICTURE, SUBJECT_STATE_ONLINE) " &
                              "VALUES (@SUBJECT_USERNAME, @SUBJECT_EMAIL, @SUBJECT_PASSWORD, @SALT, @SUBJECT_EMAIL_NOTIFICATION, @SUBJECT_PICTURE, @SUBJECT_STATE_ONLINE)"

        Return query
    End Function

    Public Shared Function Get_Insert_Query_Birthday() As String
        Dim query As String = "INSERT INTO TBL_USER_BIRTHDAY (USER_ID, USER_BIRTHDAY) " &
                              "VALUES (IDENT_CURRENT('TBL_USER_DATA'),  @SUBJECT_BIRTHDAY) "
        Return query
    End Function

    Public Shared Function Get_Base_Select_SujectData() As String
        Dim query As String = "SELECT * FROM  TBL_USER_DATA"
        Return query
    End Function

    Public Shared Function Get_Update_Password_Query() As String
        Dim query As String = "UPDATE TBL_USER_DATA " &
                              "SET SUBJECT_PASSWORD = @SUBJECT_PASSWORD, SALT = @SALT " &
                              "WHERE SUBJECT_EMAIL = @SUBJECT_EMAIL"
        Return query
    End Function

    Public Shared Function Get_Update_Some_Data_Query() As String
        Dim query As String = "UPDATE TBL_USER_DATA " &
                              "SET SUBJECT_USERNAME = @SUBJECT_USERNAME, SUBJECT_EMAIL = @SUBJECT_EMAIL, SUBJECT_PICTURE = @SUBJECT_PICTURE "
        Return query
    End Function

    Public Shared Function Get_SubjectFriends_ByIdQuery() As String
        Dim query As String = "SELECT USER_ID, FRIEND_ID, HAVE_CHAT, tblU.SUBJECT_PICTURE, tblU.SUBJECT_USERNAME, tblU.SUBJECT_STATE_ONLINE " &
                              "FROM TBL_USER_FRIENDS AS tblF" &
                              "LEFT JOIN  TBL_USER_DATA AS tblU ON tblU.SUBJECT_ID = FRIEND_ID " &
                              "WHERE USER_ID = @USER_ID"
        Return query
    End Function
End Class