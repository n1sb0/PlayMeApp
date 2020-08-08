﻿Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Create_ListOf_Panels

    '*****///// 'dynamic' vars 
    Private _UserPanel_Class
    Private _ListOfUserPanels

    Private _Iy As Integer
    Private _ControlBy As String
    Private _X = 10, _Y = 0, _Count = 1

    Private _MainForm As MainForm
    Private _DmForm As CreateDMForm
    Private _AllFriendsForm As AllFriendsForm
    Private _OnlineFriendsForm As OnlineFriendsForm
    Private _BlockedFriendsForm As BlockedFriendsForm

    Private _Subject As Subject
    Private _MainPanel As Panel
    Private _MainPanelG As GunaPanel
    Private _ScrollBar As GunaVScrollBar
    Private _LocationOfUserPanel As Point

    Private _ListOfsbjFriends As List(Of Subject_Friends)

    Sub New()
    End Sub

    '*****///// CONSTRUCTOR OF PANELS

    '*****///// CREATE DM PANEL
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef cForm As CreateDMForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of DmFriendsPanel), ByRef mainPanl As GunaPanel)

        _X = 16
        _Iy = iy
        _DmForm = cForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanelG = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanels = listOfUserPanel
    End Sub

    '*****///// BLOCKED FRIENDS PANEL
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef bForm As BlockedFriendsForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of BlockedFriendsPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _BlockedFriendsForm = bForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanels = listOfUserPanel
    End Sub

    '*****///// CHAT PANEL
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef mForm As MainForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of FriendsChatPanel), ByRef mainPanlG As GunaPanel)

        _X = 0
        _Iy = iy
        _MainForm = mForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanelG = mainPanlG
        _ScrollBar = scrollBar
        _ListOfUserPanels = listOfUserPanel
    End Sub

    '*****///// FRIENDS ONLINE PANEL
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef oForm As OnlineFriendsForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of FriendsOnlineAndAllPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _OnlineFriendsForm = oForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanels = listOfUserPanel
    End Sub

    '*****///// ALL FRIENDS PANEL
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef aForm As AllFriendsForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of FriendsOnlineAndAllPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _AllFriendsForm = aForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanels = listOfUserPanel
    End Sub
    '*****///// END CONSTRUCTOR OF PANELS

    '*****///// CREATE LIST OF PANELS TAKING DATA FROM DB 
    Public Sub Create_ListOfPanels()
        If Not String.IsNullOrEmpty(_Subject.SUBJECT_USERNAME) Then
            Control_By()
        End If
    End Sub

    '*****///// CONTROL WHICH PANEL NEEDS TO BE CREATED
    Private Sub Control_By()
        _ListOfsbjFriends = Subject_Friends.Get_SubjectFriends_ByID(_Subject.SUBJECT_ID)

        If _ListOfsbjFriends IsNot Nothing Then
            For i As Integer = 0 To _ListOfsbjFriends.Count - 1
                _LocationOfUserPanel = New Point(_X, _Y)

                '*****///// DIFFERENT PANELS TO CREATE
                Select Case _ControlBy
                    Case "All"
                        If _ListOfsbjFriends.Item(i).FRIENDS_BLOCKED.Equals("NO") Then
                            _UserPanel_Class = New FriendsOnlineAndAllPanel(_AllFriendsForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(_UserPanel_Class)
                        End If

                    Case "Chat"
                        If _ListOfsbjFriends.Item(i).HAVE_CHAT.Equals("Yes") Then
                            _UserPanel_Class = New FriendsChatPanel(_MainForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(_UserPanel_Class)
                        End If

                    Case "Online"
                        If _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE.Equals("Online") Then
                            _UserPanel_Class = New FriendsOnlineAndAllPanel(_OnlineFriendsForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(_UserPanel_Class)
                        End If

                    Case "Blocked"
                        If _ListOfsbjFriends.Item(i).FRIENDS_BLOCKED.Equals("Yes") Then
                            _UserPanel_Class = New BlockedFriendsPanel(_BlockedFriendsForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME)

                            Create_Panel(_UserPanel_Class)
                        End If

                    Case "DM"
                        If _ListOfsbjFriends.Item(i).FRIENDS_BLOCKED.Equals("NO") Then
                            _UserPanel_Class = New DmFriendsPanel(_DmForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE)

                            Create_Panel(_UserPanel_Class)
                        End If
                End Select
            Next
        End If
    End Sub

    '*****///// FINALLY TAKE AS PARAMETER ALL CLASS WHICH CONTAINS A PANEL WITH ALL COMPONENTS (PIC BOX, USERNAME ...)
    '*****///// AND ADD IT TO A MAIN PANEL
    Private Sub Create_Panel(ByRef userPanel_Class As Object)

        _Y += _Iy
        _Count += 1

        _ListOfUserPanels.Add(userPanel_Class)

        If _MainPanel IsNot Nothing Then

            userPanel_Class._BackGRadLeft.Location = New Point(_LocationOfUserPanel.X - 7, _LocationOfUserPanel.Y)
            userPanel_Class._BackGRadRight.Location = New Point(_LocationOfUserPanel.X + 809, _LocationOfUserPanel.Y + 12)

            _MainPanel.Controls.Add(userPanel_Class._UserPanel)
            _MainPanel.Controls.Add(userPanel_Class._BackGRadLeft)
            _MainPanel.Controls.Add(userPanel_Class._BackGRadRight)
        Else
            _MainPanelG.Controls.Add(userPanel_Class._UserPanel)

            If _ControlBy.Equals("DM") Then
                userPanel_Class._BackGRadLeft.Location = New Point(_LocationOfUserPanel.X - 10, _LocationOfUserPanel.Y)
                userPanel_Class._BackGRadRight.Location = New Point(_LocationOfUserPanel.X + 330, _LocationOfUserPanel.Y - 15)

                _MainPanelG.Controls.Add(userPanel_Class._BackGRadLeft)
                _MainPanelG.Controls.Add(userPanel_Class._BackGRadRight)
            End If
        End If
    End Sub
End Class
