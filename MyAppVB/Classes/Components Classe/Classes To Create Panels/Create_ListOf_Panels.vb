Imports Guna.UI.WinForms
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Create_ListOf_Panels

    '*****///// 'dynamic' VARS
    Private _UserPanel_Class
    Private _ListOfUserPanels

    '*****///// VARS
    Private _Iy As Integer
    Private _ControlBy As String
    Private _X = 10, _Y = 0, _Count = 1
    Private _msgText As String
    Private _ListOfsbjFriends As List(Of Subject_Friends)

    '*****///// FORMS
    Private _MainForm As HomeForm
    Private _DmForm As CreateDMForm
    Private _ChatFriendForm As ChatFriendForm
    Private _PendingForm As PendingForm
    Private _AllFriendsForm As AllFriendsForm
    Private _OnlineFriendsForm As OnlineFriendsForm
    Private _BlockedFriendsForm As BlockedFriendsForm

    '*****///// CLASSES
    Private _Subject As Subject

    '*****///// COMPONENTS
    Private _MainPanel As Panel
    Private _MainPanelG As GunaPanel
    Private _ScrollBar As GunaVScrollBar
    Private _LocationOfUserPanel As Point

    Sub New()
    End Sub

    '*****///// CONSTRUCTOR OF PANELS

    '*****///// CREATE DM PANEL
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef cForm As CreateDMForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of DmFriendsPanel), ByRef mainPanl As GunaPanel)

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
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef mForm As HomeForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of ChatFriendsPanel), ByRef mainPanlG As GunaPanel)

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
            ByRef listOfUserPanel As List(Of OnlineAndAllFriendsPanel), ByRef mainPanl As Panel, ByRef mForm As HomeForm)

        _Iy = iy
        _MainForm = mForm
        _OnlineFriendsForm = oForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanels = listOfUserPanel
    End Sub

    '*****///// ALL FRIENDS PANEL
    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef aForm As AllFriendsForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of OnlineAndAllFriendsPanel), ByRef mainPanl As Panel, ByRef mForm As HomeForm)

        _Iy = iy
        _MainForm = mForm
        _AllFriendsForm = aForm
        _Subject = subject
        _ControlBy = controlBy
        _MainPanel = mainPanl
        _ScrollBar = scrollBar
        _ListOfUserPanels = listOfUserPanel
    End Sub

    Sub New(ByRef subject As Subject, ByRef scrollBar As GunaVScrollBar, ByRef pForm As PendingForm, iy As Integer, controlBy As String,
            ByRef listOfUserPanel As List(Of PendingRequestPanel), ByRef mainPanl As Panel)

        _Iy = iy
        _Y = listOfUserPanel.Count * 61
        _PendingForm = pForm
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

        _ListOfsbjFriends = Subject_Friends.Get_SubjectFriends_ByID(_Subject.SUBJECT_ID, _ControlBy)

        If _ListOfsbjFriends IsNot Nothing Then
            For i As Integer = 0 To _ListOfsbjFriends.Count - 1
                _LocationOfUserPanel = New Point(_X, _Y)

                '*****///// DIFFERENT PANELS TO CREATE
                Select Case _ControlBy
                    Case "All"
                        _UserPanel_Class = New OnlineAndAllFriendsPanel(_AllFriendsForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE, _ListOfsbjFriends.Item(i).USER_ID, _MainForm)

                        Create_Panel(_UserPanel_Class)

                    Case "Chat"
                        _UserPanel_Class = New ChatFriendsPanel(_MainForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE, _ListOfsbjFriends.Item(i).USER_ID)

                        Create_Panel(_UserPanel_Class)

                    Case "Online"
                        If _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE.Equals("Online") Then
                            _UserPanel_Class = New OnlineAndAllFriendsPanel(_OnlineFriendsForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE, _ListOfsbjFriends.Item(i).USER_ID, _MainForm)

                            Create_Panel(_UserPanel_Class)
                        End If

                    Case "Blocked"
                        _UserPanel_Class = New BlockedFriendsPanel(_BlockedFriendsForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME,
                                              _ListOfsbjFriends.Item(i).USER_ID)

                        Create_Panel(_UserPanel_Class)

                    Case "DM"
                        _UserPanel_Class = New DmFriendsPanel(_DmForm, _LocationOfUserPanel, _ScrollBar, (_Count).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE, _ListOfsbjFriends.Item(i).USER_ID)

                        Create_Panel(_UserPanel_Class)

                    Case "Friend Request", "Outgoing Friend Request"
                        _UserPanel_Class = New PendingRequestPanel(_PendingForm, _LocationOfUserPanel, _ScrollBar, (_ListOfUserPanels.Count() + 1).ToString _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_PICTURE, _ListOfsbjFriends.Item(i).FRIENDS_USERNAME _
                                            , _ListOfsbjFriends.Item(i).FRIENDS_STATE_ONLINE, _ListOfsbjFriends.Item(i).USER_ID, _ControlBy)

                        Create_Panel(_UserPanel_Class)
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
            For i As Integer = 0 To _ListOfUserPanels.Count - 1
                _MainPanel.Controls.Add(_ListOfUserPanels.Item(i)._UserPanel)
            Next
        Else
            For Each pnl In _ListOfUserPanels
                _MainPanelG.Controls.Add(pnl._UserPanel)
            Next
        End If
    End Sub
End Class
