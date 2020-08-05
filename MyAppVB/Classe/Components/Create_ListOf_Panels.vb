Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Create_ListOf_Panels

    Private _Iy As Integer
    Private _MForm As MainForm
    Private _AForm As AllFriendsForm
    Private _BForm As BlockedFriendsForm
    Private _OForm As OnlineFriendsForm
    Private _MainPanel As Panel
    Private _Subject As Subject
    Private _ControlBy As String
    Private _MainPanelG As GunaPanel
    Private _ScrollBar As GunaVScrollBar
    Private _ListOfUserPanel
    Private friendPanel
    Private _ListOfsbjFriends As List(Of Subject_Friends)
    Private _X = 0, _Y = 0, _Count = 1
    Private locationOfFriendPanel As Point

    Sub New()

    End Sub

    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef bForm As BlockedFriendsForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of BlockedFriendsPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _BForm = bForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanel = listOfUserPanel
    End Sub

    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef mForm As MainForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of FriendsChatPanel), ByRef mainPanlG As GunaPanel)

        _Iy = iy
        _MForm = mForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanelG = mainPanlG
        _ScrollBar = scrollBar
        _ListOfUserPanel = listOfUserPanel
    End Sub

    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef oForm As OnlineFriendsForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of FriendsOnlineAndAllPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _OForm = oForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanel = listOfUserPanel
    End Sub

    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef aForm As AllFriendsForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of FriendsOnlineAndAllPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _AForm = aForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanel = listOfUserPanel
    End Sub

    Public Sub Create_ListOfPanels(pnlToDelete As Panel)

        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            pnlToDelete.Dispose()

            Control_By()
        End If
    End Sub


    Private Sub Control_By()
        _ListOfsbjFriends = Subject_Friends.Get_SubjectFriends_ByID(_Subject.SUBJECT_ID)

        If _ListOfsbjFriends IsNot Nothing Then
            For i As Integer = 0 To _ListOfsbjFriends.Count - 1
                locationOfFriendPanel = New Point(_X, _Y)

                Select Case _ControlBy
                    Case "All"
                        If _ListOfsbjFriends.Item(i).FRIENDS_BLOCKED.Equals("NO") Then
                            friendPanel = New FriendsOnlineAndAllPanel(_AForm, locationOfFriendPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)


                            Create_Panel(friendPanel)
                        End If

                    Case "Chat"
                        If _ListOfsbjFriends.Item(i).HAVE_CHAT.Equals("Yes") Then
                            friendPanel = New FriendsChatPanel(_MForm, locationOfFriendPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(friendPanel)
                        End If
                    Case "Online"
                        If _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE.Equals("Online") Then
                            friendPanel = New FriendsOnlineAndAllPanel(_MForm, locationOfFriendPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(friendPanel)
                        End If
                    Case "Blocked"
                        If _ListOfsbjFriends.Item(i).FRIENDS_BLOCKED.Equals("Yes") Then
                            friendPanel = New BlockedFriendsPanel(_BForm, locationOfFriendPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME)

                            Create_Panel(friendPanel)
                        End If
                End Select
            Next
        End If
    End Sub

    Private Sub Create_Panel(ByRef friendPanel As Object)

        _Y += _Iy
        _Count += 1

        _ListOfUserPanel.Add(friendPanel)

        If _MainPanel IsNot Nothing Then
            _MainPanel.Controls.Add(friendPanel._UserPanel)
        Else
            _MainPanelG.Controls.Add(friendPanel._UserPanel)
        End If
    End Sub

End Class
