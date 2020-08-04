Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Create_ListOf_Panels

    Private _Iy As Integer
    Private _MForm As MainForm
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

    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef mForm As MainForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of FriendsPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _MForm = mForm
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
                            Create_Panel(i, friendPanel)
                        End If

                    Case "Chat"
                        If _ListOfsbjFriends.Item(i).HAVE_CHAT.Equals("Yes") Then
                            friendPanel = New FriendsChatPanel(_MForm, locationOfFriendPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(i, friendPanel)
                        End If
                    Case "Online"
                        If _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE.Equals("Online") Then
                            friendPanel = New FriendsPanel(_MForm, locationOfFriendPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(i, friendPanel)
                        End If
                    Case "Blocked"
                        If _ListOfsbjFriends.Item(i).FRIENDS_BLOCKED.Equals("Yes") Then
                            Create_Panel(i, friendPanel)
                        End If
                End Select
            Next
        End If
    End Sub

    Private Sub Create_Panel(i As Integer, friendPanel As Object)

        Dim pnl As New Panel

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
