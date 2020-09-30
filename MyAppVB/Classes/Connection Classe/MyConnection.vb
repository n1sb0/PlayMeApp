Public Class MyConnection

    '*****///// STRING OF CONNECTION TO DATA BASE
    Public Shared Function Get_Connection() As String
        Dim connQuery As String = ""

        Return connQuery
    End Function

    '*****///// INSERT QUERY ALL DATA DATA BASE
    Public Shared Function Get_Insert_Query_SubjectData() As String
        Dim query As String = "INSERT INTO TBL_USER_DATA (SUBJECT_USERNAME, SUBJECT_EMAIL, SUBJECT_PASSWORD, SALT ,SUBJECT_EMAIL_NOTIFICATION, SUBJECT_PICTURE, SUBJECT_STATE_ONLINE) " &
                              "VALUES (@SUBJECT_USERNAME, @SUBJECT_EMAIL, @SUBJECT_PASSWORD, @SALT, @SUBJECT_EMAIL_NOTIFICATION, @SUBJECT_PICTURE, @SUBJECT_STATE_ONLINE)"

        Return query
    End Function

    '*****///// INSERT TO SAVE BIRTHDAY DATA OF USER
    Public Shared Function Get_Insert_Query_Birthday() As String
        Dim query As String = "INSERT INTO TBL_USER_BIRTHDAY (USER_ID, USER_BIRTHDAY) " &
                              "VALUES (IDENT_CURRENT('TBL_USER_DATA'),  @SUBJECT_BIRTHDAY) "

        Return query
    End Function

    '*****///// DEFAULT SELECT QUERY
    Public Shared Function Get_Base_Select_SujectData() As String
        Dim query As String = "SELECT * FROM  TBL_USER_DATA"

        Return query
    End Function

    '*****///// UPDATE PASSWORD QUERY
    Public Shared Function Get_Update_Password_Query() As String
        Dim query As String = "UPDATE TBL_USER_DATA " &
                              "SET SUBJECT_PASSWORD = @SUBJECT_PASSWORD, SALT = @SALT " &
                              "WHERE SUBJECT_EMAIL = @SUBJECT_EMAIL"

        Return query
    End Function

    '*****///// UPDATE USER DATA 
    Public Shared Function Get_Update_Some_Data_Query() As String
        Dim query As String = "UPDATE TBL_USER_DATA " &
                              "SET SUBJECT_USERNAME = @SUBJECT_USERNAME, SUBJECT_EMAIL = @SUBJECT_EMAIL, SUBJECT_PICTURE = @SUBJECT_PICTURE "

        Return query
    End Function

    '*****///// SELECT QUERY TO CHECK USER FRIENDS 
    Public Shared Function Get_SubjectFriends_ByIdQuery() As String
        Dim query As String = "SELECT USER_ID, FRIEND_ID, tblU.SUBJECT_PICTURE, tblU.SUBJECT_USERNAME, tblU.SUBJECT_STATE_ONLINE "

        Return query
    End Function

    '*****///// DELETE USER QUERY
    Public Shared Function Get_Delete_By_IDQuery() As String
        Dim query As String = "DELETE FROM TBL_USER_DATA WHERE SUBJECT_ID = @SUBJECT_ID"

        Return query
    End Function

    Public Shared Function Get_Insert_PendingReq() As String
        Dim query As String = "INSERT INTO TBL_PENDING_FRENDS_REQUEST (REQUEST_FROM, REQUEST_TO) " &
                              "VALUES (@REQUEST_FROM,  @REQUEST_TO) "

        Return query
    End Function

    Public Shared Function Get_Delete_Pending_Request() As String
        Dim query As String = "DELETE FROM TBL_PENDING_FRENDS_REQUEST WHERE REQUEST_FROM = @USER_1 AND REQUEST_TO = @USER_2"

        Return query
    End Function

    Public Shared Function Insert_Query_Add_Friend() As String
        Dim query As String = "INSERT INTO TBL_USER_FRIENDS (USER_ID, FRIEND_ID) " &
                              "VALUES (@USER_1, @USER_2)"

        Return query
    End Function

    Public Shared Function Get_UnBlock_Query() As String
        Dim query As String = "DELETE FROM TBL_BLOCKED_FRIENDS WHERE USER_ID = @USER_1 AND FRIEND_ID = @USER_2"

        Return query
    End Function

    Public Shared Function Get_Subject_Friend() As String
        Dim query As String = "SELECT * FROM TBL_USER_FRIENDS"

        Return query
    End Function

    Public Shared Function Get_Subject_Request() As String
        Dim query As String = "SELECT * FROM TBL_PENDING_FRENDS_REQUEST"

        Return query
    End Function

    Public Shared Function Get_Subject_ChatWith() As String
        Dim query As String = "SELECT * FROM TBL_HAVE_CHAT_WITH_USER"

        Return query
    End Function

    Public Shared Function Delete_From_FriendList() As String
        Dim query As String = "DELETE FROM TBL_USER_FRIENDS WHERE USER_ID = @USER_1 AND FRIEND_ID = @USER_2"

        Return query
    End Function

    Public Shared Function Delete_Chat_With() As String
        Dim query As String = "DELETE FROM TBL_HAVE_CHAT_WITH_USER WHERE USER_ID = @USER_1 AND FRIEND_ID = @USER_2"

        Return query
    End Function

    Public Shared Function Get_Insert_ChatWith() As String
        Dim query As String = "INSERT INTO TBL_HAVE_CHAT_WITH_USER (USER_ID, FRIEND_ID) " &
                              "VALUES (@USER_ID,  @FRIEND_ID) "

        Return query
    End Function


End Class