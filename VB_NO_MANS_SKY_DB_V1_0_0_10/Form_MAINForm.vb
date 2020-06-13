Public Class frmMain
    '*  Program Title:                                            No Mans Sky Database
    '*
    '*
    '*  Language:                                                 VB.NET - Visual Studio 2015 - © 2017 Microsoft
    '*
    '*  AUTHOR:                                                   Daniel Goss
    '*
    '*  Copyright:                                                Copyright © 2019
    '*
    '*  Module Code:                                              Form: frmMain
    '*
    '*  External Name:                                            Form_MainForm.vb
    '*
    '*  Previous Amendment:                                       03-FEB-2019 04:30
    '*
    '*  Module last amended:                                      
    '*
    '*  Just Starting first version. Needs the MySQL login form.
    '*
    '*  
    '*  
    '*
    '****************************************************************************************************************************************************************
    Public Const myVersion As String = "1.0"

    Public ProgramData As String = ""
    Public myConnString As String
    Public myLOCALConnString As String = ""
    Public MyLocalMessage As String = ""
    Public myComputerName As String = ""
    Public myPort As String = "3306"
    Public myUsername As String = ""
    Public myName As String = ""
    Public myUserID As String = ""
    Public myPassword As String = ""
    Public myServer As String = "localhost"
    Public myAccessRights As String = ""
    Public myDatabase As String = "nms_v1_0"
    Public myEmpNo As String = ""
    Public myFirstname As String = ""
    Public myLastname As String = ""
    Public myScreenWidth As Integer = 0
    Public myScreenHeight As Integer = 0
    Public SYSTEMUsername As String = "NMSuser"
    Public SYSTEMPassword As String = "nmsuser"
    Public DisplayRegistryFields As String = ""
    Public DisplayHistoryFields As String = ""
    Public DisplayAssetFields As String = ""
    Public DisplayUserFields As String = ""
    Public DisplayOperatorFields As String = ""
    Public AltDisplayOperatorFields As String = ""
    Public NewUserBarCode As String = ""
    Public myLoggedIn As Boolean = False
    Public UpdatedOK As Boolean = False
    Public DebugMode As Boolean = True
    Public Initialised As Boolean = False
    Public mySessionID As String = ""
    Public EXITProcess As Boolean = False
    Public myUsernameSuffix As String
    Public logger = New clsErrorLog
    Public DatabaseType As String = "MYSQL"
    Public dbsource As String
    Public DBName As String
    Public ControlPanelFormName As String
    Public CPFormName As String
    Public ControlPanelIdx As String
    Public FormID As String
    Public DEBUG_MODE As Boolean = False
    Public mySystemID As String
    Public myPlanetID As String
    Public myArea As String
    Public myAccountID As String
    Public comManager As clsDGComponentManager


    Function Get_GUID() As String
        Dim strGUID As String

        strGUID = System.Guid.NewGuid.ToString
        Get_GUID = strGUID
    End Function

    Function GetComputerName() As String
        Dim ComputerName As String

        ComputerName = My.Computer.Name

        GetComputerName = ComputerName
    End Function

    Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim myIP4HostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each IPAddr As System.Net.IPAddress In myIP4HostEntry.AddressList
            If IPAddr.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = IPAddr.ToString()
            End If
        Next

    End Function

    Function GetIPv6Address() As String
        GetIPv6Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim myIP6HostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each IPAddr As System.Net.IPAddress In myIP6HostEntry.AddressList
            'address = hostEntry.AddressList().Where(Function(a) a.AddressFamily = Sockets.AddressFamily.InterNetworkV6).First().ToString()
            If IPAddr.AddressFamily = System.Net.Sockets.AddressFamily.InterNetworkV6 Then
                GetIPv6Address = IPAddr.ToString()
            End If
        Next

    End Function

    Function GetScreenResolution_Actual(ByVal ScreenNumber As Integer, ByRef ScreenWidth As Integer, ByRef ScreenHeight As Integer,
                                            Optional ByRef Message As String = "") As Integer
        Dim NumberOfScreens As Integer

        NumberOfScreens = Screen.AllScreens.Count
        If ScreenNumber < 2 Then
            ScreenWidth = Screen.PrimaryScreen.Bounds.Width
            ScreenHeight = Screen.PrimaryScreen.Bounds.Height
        Else
            If ScreenNumber <= NumberOfScreens Then
                ScreenWidth = Screen.AllScreens(ScreenNumber).Bounds.Width
                ScreenHeight = Screen.AllScreens(ScreenNumber).Bounds.Height
            Else
                Message = "Error: Passed Parameter Exceeds Number of Screens Available"
                logger.LogError("NMS_Error_" & myVersion & ".log", Application.StartupPath, Message, "GetScreenResolution_Actual()",
                                GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & myUsername,
                                myUsernameSuffix)
            End If
        End If
        GetScreenResolution_Actual = NumberOfScreens

    End Function

    Sub Initialize(TheDatabaseType As String)
        Dim NumRows As Long = 0
        Dim conString As String = "" 'not used here.
        Dim Messages As String = ""
        Dim cf As New frmMysqlLogin

        If UCase(DatabaseType) = "ACCDB" Then
            'PopulateDataSource(dgvRegister, DBName, DBProvider, "SELECT " & DisplayRegistryFields & " From tblRegister ORDER BY DateOut DESC", Messages, NumRows)
            Startup(DatabaseType)
        Else
            For xxx = 1 To 3000
                'wait
            Next
            Application.DoEvents()

            If myLoggedIn Then
                Initialised = True
                Startup(DatabaseType)

            Else
                'Now its an MDI app - so create MDI child form:
                'cf.MdiParent = Me
                'cf.StartPosition = FormStartPosition.CenterParent
                'cf.Text = "Goods In LOGIN" & CStr(MdiChildren.Count)
                'cf.Name = "GI_LOGIN"
                'cf.Show)
                frmMysqlLogin.ShowDialog()

                'frmMysqlLogin.txtUsername.Focus()
                Initialised = True
                Startup(DatabaseType)
            End If
        End If

    End Sub

    Sub Startup(TheDatabaseType As String)
        Dim NumRows As Long = 0
        Dim NumOperators As Long = 0
        Dim conString As String = ""
        Dim Messages As String = ""
        Dim MyOpsMessages As String = ""
        Dim OpMessages As String = ""
        Dim ColWidths As String = ""
        Dim UserId As String = ""
        Dim Username As String = ""
        Dim ComputerName As String = ""
        Dim IPv4Addr As String = ""
        Dim IPv6Addr As String = ""
        Dim EmpNo As String = ""
        Dim Firstname As String = ""
        Dim Lastname As String = ""
        Dim Location As String = ""
        Dim Comments As String = "" 'The Computer Workstation number - usually.
        Dim OnlineMsg As String = ""
        Dim strWorkstationID As String = ""
        Dim OpsOnlineCriteria As String = ""
        Dim myDAL As New clsNMSdal(myVersion, myUsername)
        'Dim cf As New frmGI_RP_Userform

        Me.WindowState = FormWindowState.Maximized
        Me.ShowIcon = True

        Me.ShowInTaskbar = True
        If TheDatabaseType = "MYSQL" Then
            If myLoggedIn Then
                KeyPreview = True
                Me.DatabaseType = "MYSQL"
                UserId = myUserID
                Username = myUsername

                If Get_NumericPartOfString(Username) > 0 Then
                    myUsernameSuffix = CStr(Get_NumericPartOfString(Username)) 'eg dgoss_2 , dgoss_3 and dgoss_4
                Else
                    myUsernameSuffix = ""
                End If

                ComputerName = GetComputerName()
                IPv4Addr = GetIPv4Address()
                IPv6Addr = GetIPv6Address()
                mySessionID = Get_GUID()
                Location = ""
                EmpNo = myEmpNo
                Firstname = myFirstname
                Lastname = myLastname
                myDAL.GetDetails(myConnString, "tblOperatorComputers", "ComputerName", ComputerName, "Location", Location, OnlineMsg)
                strWorkstationID = ""
                myDAL.GetDetails(myConnString, "tblOperatorComputers", "ComputerName", ComputerName, "WorkstationName", strWorkstationID, OnlineMsg)
                'Find the EmpNo logged in now.
                'Remove from the online Operators table first - before adding a new one.
                'so set the criteria: No - use the UserID - only reliable bit of data - as same Operator could log into a diffent machine.
                OpsOnlineCriteria = "ComputerName = " & Chr(39) & ComputerName & Chr(39)
                myDAL.DeleteMyRecord("tblOperatorsOnline", myConnString, OpsOnlineCriteria, Messages)
                myDAL.saveSession(myConnString, UserId, Username, ComputerName, IPv4Addr, IPv6Addr, mySessionID, myAccessRights,
                                Messages, EmpNo, Firstname, Lastname, Comments, Location, strWorkstationID, myVersion, MyOpsMessages)
                If myServer! = "localhost" Then
                    'WHAT DOES THIS DO ?
                    'saveSession(myLOCALConnString, UserId, Username, ComputerName, IPv4Addr, IPv6Addr, mySessionID, myAccessRights,
                    'Messages, EmpNo, Firstname, Lastname, Comments, Location, strWorkstationID, MyOpsMessages)
                End If
                If Len(Messages) > 0 Or Len(MyLocalMessage) > 0 Then
                    Me.txtMessages.Text = "Error from Save Session: " & Messages & vbCrLf & " " & MyLocalMessage
                End If

                'Need to adjust the column widths:
                ColWidths = ""
                If Initialised Then
                    'If logged in remotely - does this need to be done twice ?
                    'If logged in locally - myConnString should contain the local connection.
                    'Operators need a criteria - only view those that are logged in now !
                    'CHECK THIS OUT - GIVING ERROR ?????
                    'PopulateMyDataSource(dgvRegister.DataSource, myConnString, "SELECT " & DisplayRegistryFields & " From tblRegister ORDER BY DateOut DESC", NumRows, Messages)
                    'Select Case OPS.username,ops.firstname,ops.lastname,ops.empno,ops.isloggedin,ses.computername,ses.ipv4addr,ses.logindatetime,ses.logoffdatetime
                    'From tblOperators ops
                    'Left Join tblSessions ses on ops.sessionid = ses.sessionid
                    '-- Where ops.username = ses.username
                    '-- And ops.isloggedin = 1
                    'WHERE ops.isloggedin = 1
                    'PopulateMyDataSource(dgvOperators.DataSource, myConnString, DisplayOperatorFields, NumOperators, OpMessages)
                    Application.DoEvents()
                    Beep()
                    Me.myName = Me.myFirstname & " " & Me.myLastname
                    'ControlsManager.Initialise()
                    Me.txtMessages.Text = "WELCOME " & Me.myName & " to the No Mans Sky Database " & myVersion

                    'PopulateTreeView(25000,30000)
                    'CheckAssetTree()
                    'Me.CreateNewUsersToolStripMenuItem.Visible = False
                    'Me.ShowAltControlToolStripMenuItem.Visible = False
                    'Me.SendMessageToolStripMenuItem.Visible = False
                    If UCase(myAccessRights) = "ADMIN" Then
                        'Me.CreateNewUsersToolStripMenuItem.Visible = True
                        'Me.AddUserToolStripMenuItem.Enabled = True
                        'Me.AddUserToDB.Visible = True
                        'Me.rbIgnoreNotCheckedOut.Visible = False
                    End If
                    If UCase(myAccessRights) = "SUPER" Then
                        'Me.CreateNewUsersToolStripMenuItem.Visible = True
                        'Me.ShowAltControlToolStripMenuItem.Visible = True
                        'Me.SendMessageToolStripMenuItem.Visible = True
                        'Me.AddUserToolStripMenuItem.Enabled = True
                        'Me.AddUserToDB.Visible = True
                        'Me.rbIgnoreNotCheckedOut.Visible = False

                    End If

                    Me.IsMdiContainer = True

                    ControlPanelFormName = ""
                    CPFormName = ""
                    ControlPanelIdx = Get_GUID()
                    FormID = ControlPanelIdx

                    'cf.MdiParent = Me
                    'cf.StartPosition = FormStartPosition.Manual
                    'cf.Text = "Control Panel " & Now().ToString("dd/MM/yyyy HH:mm:ss")
                    'cf.Name = CPFormName & FormID
                    'cf.Tag = FormID
                    'Clear_Entry_Controls(CPFormName & FormID, 1, 40)
                    'Clear_Entry_Controls(CPFormName & FormID, 801, 807)
                    'cf.Show()
                    'cf.ShowDialog() - gives error
                    comManager = New clsDGComponentManager

                End If
            Else
                MsgBox("Need to LOGIN")
                Application.Exit()
            End If
        End If
        If DEBUG_MODE = False Then
            Timer1.Interval = 1000
            Timer1.Start()

            Me.txtMainClock.Visible = True
        End If
        KeyPreview = True
        Me.TopMost = False
        'Me.ClearBoxes()
        'Me.txtAssetEntry.Focus()
        Beep()
        If Len(Messages) > 0 Then
            'Me.txtStatusMessage.AppendText(CStr(Now() & Messages))
            logger.LogError("NMS_ERRORS_" & myVersion & ".log", Application.StartupPath, Messages, "Startup()",
                            GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR LOGGED OUT:" & myUsername,
                            myUsernameSuffix)
            Exit Sub
        End If
        'Me.txtTotalRegisterEntries.Text = CStr(NumRows)
    End Sub

    Function Get_MDIChildForm(TheFormName As String) As Form
        Dim frmName As String

        Get_MDIChildForm = Nothing
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(TheFormName) Then
                Get_MDIChildForm = frm
                Exit For
            End If
        Next


    End Function


    Private Sub LOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGToolStripMenuItem.Click
        'SHOW LOG FORM:
        Dim LOGForm As frmLogView
        Dim frmName As String
        Dim SearchName As String = "LOGForm_VIEW"
        Dim TagCode As String

        'Test if child window not already open ?
        'cf.MdiParent = Me

        'cf.StartPosition = FormStartPosition.CenterParent
        'cf.Text = "REFERENCE PROGRESS " & CStr(MdiChildren.Count)
        'cf.Name = "ReferenceProgress"
        'cf.Show()

        LOGForm = Get_MDIChildForm(SearchName)

        If Not IsNothing(LOGForm) Then
            frmName = LOGForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            LOGForm = New frmLogView

            LOGForm.Name = SearchName
            LOGForm.Text = "LOG FORM VIEW"
            LOGForm.MdiParent = Me
            LOGForm.StartPosition = FormStartPosition.Manual
            TagCode = Get_GUID()
            LOGForm.Tag = TagCode
            'LOGForm.PopulateLOGGrid()
            LOGForm.Show()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMessages.TextChanged

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Record Account Details:
        Dim ACCOUNTForm As Form
        Dim frmName As String
        Dim SearchName As String = "Account_Entry"
        Dim TagCode As String

        'Test if child window not already open ?
        'cf.MdiParent = Me

        'cf.StartPosition = FormStartPosition.CenterParent
        'cf.Text = "REFERENCE PROGRESS " & CStr(MdiChildren.Count)
        'cf.Name = "ReferenceProgress"
        'cf.Show()

        ACCOUNTForm = Get_MDIChildForm(SearchName)

        If Not IsNothing(ACCOUNTForm) Then
            frmName = ACCOUNTForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            ACCOUNTForm = New frmAccounts
            ACCOUNTForm.Name = SearchName
            ACCOUNTForm.Text = "Enter Account Information"
            ACCOUNTForm.MdiParent = Me
            ACCOUNTForm.StartPosition = FormStartPosition.CenterParent
            TagCode = Get_GUID()
            ACCOUNTForm.Tag = TagCode
            ACCOUNTForm.Show()
        End If
    End Sub

    Private Sub SETCURRENTVERSIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SETCURRENTVERSIONToolStripMenuItem.Click
        'SET CURRENT GAME VERSION:
        'One of several ways to save current details so that they do not have to be typed in again during LOG ENTRY.
        'Save current: system, planet and area , credits and nanites and quicksilver as well as area.

    End Sub

    Private Sub PRODUCTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTSToolStripMenuItem.Click
        'ENTER PRODUCTS:

    End Sub

    Private Sub SHIPSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHIPSToolStripMenuItem.Click
        'ENTER SHIPS:

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txtMainClock.Text = CStr(Now())
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LOAD EVENT:
        Initialize("MYSQL")
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim criteria As String
        Dim MyMessage As String = ""
        Dim AreYouSure As Integer
        Dim OpsOnlineCriteria As String
        Dim Messages As String = ""
        Dim myDAL As New clsNMSdal(myVersion, myUsername)

        'MsgBox("CLOSE MAIN FORM")
        'Needs to check if any changes have been made since LAST SAVE ??? check AnyChanges(ControlPanelIDX) global flag.
        'WELL - in this case will have to be a DICTIONARY variable where the key will be ControlPanelIDX and value is YES/NO
        'So set to TRUE if ANY character typed into either TEXT BOX or COMBO BOX (or start or end button clicked) - see clsControls.
        'set to FALSE after a SUCCESSFULL save.
        criteria = "SessionID = " & Chr(39) & mySessionID & Chr(39)

        If myDAL.Check_myLoggedIN() Then
            AreYouSure = MsgBox("Are You Sure ?", vbYesNo, "QUIT APPLICATION")
            If AreYouSure = vbYes Then
                If UCase(DatabaseType) = "MYSQL" Then
                    myDAL.UpdateMySession(myConnString, "", "", "", "", "", mySessionID, "", CStr(Now()), "NO", "", criteria, MyMessage)
                    OpsOnlineCriteria = "ComputerName = " & Chr(39) & GetComputerName() & Chr(39)
                    myDAL.DeleteMyRecord("tblOperatorsOnline", myConnString, OpsOnlineCriteria, Messages)
                    If Len(Messages) > 0 Then
                        MsgBox("Error during removal of online username: " & Messages)
                    End If
                End If
            Else
                'NO - but user has now closed the main window !
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '*************************************************** SHOWN EVENT PROCEDURE *********************************************

        'Me.WindowState = FormWindowState.Maximized
        Me.StartPosition = FormStartPosition.CenterScreen

        Me.pbarMain.Style = ProgressBarStyle.Blocks
        Me.pbarMain.Value = 0
    End Sub

    Private Sub SaveSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSystemToolStripMenuItem.Click
        'SAVE CURRENT SYSTEM TO SEP TABLE / GLOBAL VARIABLE:

    End Sub


    Sub InsertValueIntoForm(FormName As String, ControlName As String, value As String,
                            Optional ByRef comArray As Object = Nothing,
                            Optional NewFormTitle As String = "")
        Dim ctrl As Object
        Dim ctrls() As Control
        Dim comboCtrl As ComboBox
        Dim comboArr() As String
        Dim IDX As Long
        Dim FoundForm As Boolean = False
        Dim ErrMessage As String

        ReDim ctrls(1)
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(FormName) Then
                FoundForm = True
                If Len(NewFormTitle) > 0 Then
                    'frm.Text = NewFormTitle
                    Application.OpenForms.Item(FormName).Text = NewFormTitle
                End If
                ctrls = frm.Controls.Find(ControlName, True)
                Exit For
            End If
        Next
        If ctrls IsNot Nothing And UBound(ctrls) > -1 Then
            If ctrls(0) Is Nothing Then
                If FoundForm = False Then
                    ErrMessage = "Error: Cannot Find Form Passed"
                    logger.LogError("InsertValueIntoForm_Error_" & myVersion & ".log", Application.StartupPath, ErrMessage, "InsertValueIntoForm()",
                                    GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & myUsername,
                                    myUsernameSuffix)
                    Exit Sub
                Else
                    ErrMessage = "Error: Cannot Find CONTROL Passed"
                    logger.LogError("InsertValueIntoForm_Error_" & myVersion & ".log", Application.StartupPath, ErrMessage, "InsertValueIntoForm()",
                                    GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & myUsername,
                                    myUsernameSuffix)
                    Exit Sub
                End If
            End If
            ctrl = ctrls(0)
            If InStr(ctrl.Name, "com") > 0 Then
                'the control is a combobox. Needs to be filled:
                If Not comArray Is Nothing Then
                    comboCtrl = CType(ctrl, System.Windows.Forms.ComboBox)
                    'comboCtrl = CType(ctrl, comarray)
                    comboCtrl.Items.Clear()

                    For IDX = 0 To UBound(comArray)
                        If comArray(IDX) IsNot Nothing Then
                            comboCtrl.Items.Add(comArray(IDX))
                        End If
                    Next

                Else

                End If
                ctrl.text = value
            ElseIf InStr(ctrl.name, "btn") > 0 Then

            Else
                ctrl.Text = value
            End If
            Application.DoEvents()
        Else
            MsgBox("Could not find Control: " & ControlName)
        End If
    End Sub

    Function FindFrameControls(FormName As String, ControlName As String, Optional ByVal TAGNumber As String = "") As Control
        Dim ctrl As Control
        Dim ctrls() As Control
        Dim comboCtrl As ComboBox
        Dim comboArr() As String
        Dim IDX As Long

        ReDim ctrls(1)
        ctrl = Nothing
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(FormName) Then
                If Len(TAGNumber) > 0 Then
                    ControlName = FindControls(FormName, "", TAGNumber).Name
                End If
                If Len(ControlName) > 0 Then
                    ctrls = frm.Controls.Find(ControlName, True)
                    Exit For
                End If
            End If
        Next

        If ctrls IsNot Nothing And UBound(ctrls) > -1 Then
            ctrl = ctrls(0)
            Return ctrl
        End If
        Return ctrl
    End Function

    Function FindControls(Formname As String, ControlName As String, TagNumber As String, Optional ByRef childCtrl As Control = Nothing) As Control
        Dim ctrl As Control
        Dim FinalCtrl As Control
        Dim ctrls() As Control
        Dim comboCtrl As ComboBox
        Dim comboArr() As String
        Dim IDX As Long
        Dim FoundForm As Form = Nothing

        ReDim ctrls(1)
        FinalCtrl = Nothing
        'ctrl = Nothing
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(Formname) Then
                FoundForm = frm
            End If
        Next
        If FoundForm IsNot Nothing Then
            For Each ctrl In FoundForm.Controls
                If ctrl.HasChildren Then
                    If Len(ControlName) > 0 Then
                        childCtrl = FindControl_Recursive(ctrl, ControlName, "")
                    Else
                        childCtrl = FindControl_Recursive(ctrl, "", TagNumber)
                    End If
                    FinalCtrl = childCtrl
                    'Return childCtrl
                    'Exit For
                Else

                    If TypeOf (ctrl) Is ComboBox Or TypeOf (ctrl) Is TextBox Or TypeOf (ctrl) Is PictureBox Then
                        If UCase(ctrl.Name) = UCase(ControlName) Then
                            FinalCtrl = ctrl
                            Exit For
                        End If
                        If UCase(ctrl.Tag) = UCase(TagNumber) Then
                            'Return ctrl
                            FinalCtrl = ctrl
                            Exit For
                        End If

                    End If

                End If
                If TypeOf (childCtrl) Is ComboBox Or TypeOf (childCtrl) Is TextBox Or TypeOf (childCtrl) Is PictureBox Then
                    FinalCtrl = childCtrl
                    Exit For
                End If
            Next
        End If

        FindControls = FinalCtrl


    End Function

    Public Function FindControl_Recursive(ByVal parent As Control, ByVal ControlName As String, Optional ByVal ControlTAG As String = "") As Control
        Dim ControlIDX As Integer
        Dim tmpctrl As Control
        Dim tmpctrl2 As Control
        For ControlIDX = 0 To parent.Controls.Count - 1
            tmpctrl = parent.Controls(ControlIDX)
            If Len(ControlName) > 0 Then
                If UCase(tmpctrl.Name) = UCase(ControlName) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = FindControl_Recursive(tmpctrl, ControlName, "")
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
            If Len(ControlTAG) > 0 Then
                If UCase(tmpctrl.Tag) = UCase(ControlTAG) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = FindControl_Recursive(tmpctrl, "", ControlTAG)
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
        Next
        ' Not found
        Return Nothing
    End Function

    Private Sub PLANETSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLANETSToolStripMenuItem.Click
        Dim PLANETSForm As Form
        Dim frmName As String
        Dim SearchName As String = "Planet_Entry_v2"

        PLANETSForm = Get_MDIChildForm(SearchName)

        If Not IsNothing(PLANETSForm) Then
            frmName = PLANETSForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            PLANETSForm = New frmPlanetEntry_v2
            PLANETSForm.Name = SearchName
            PLANETSForm.Text = "Enter Planet Information"
            PLANETSForm.MdiParent = Me
            PLANETSForm.StartPosition = FormStartPosition.Manual
            PLANETSForm.Top = 20
            PLANETSForm.Left = 5
            PLANETSForm.Width = 1500
            PLANETSForm.Height = 960
            PLANETSForm.Show()
        End If
    End Sub

    Private Sub SYSTEMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SYSTEMSToolStripMenuItem.Click
        Dim SYSTEMForm As Form
        Dim frmName As String
        Dim SearchName As String = "System_Entry"

        SYSTEMForm = Get_MDIChildForm(SearchName)

        If Not IsNothing(SYSTEMForm) Then
            frmName = SYSTEMForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            SYSTEMForm = New frmSystemEntry
            SYSTEMForm.Name = SearchName
            SYSTEMForm.Text = "Enter System Information"
            SYSTEMForm.MdiParent = Me
            SYSTEMForm.StartPosition = FormStartPosition.CenterParent
            SYSTEMForm.Tag = Get_GUID()
            'PLANETSForm.StartPosition.CenterParent
            SYSTEMForm.Show()
        End If
    End Sub

    Private Sub GantChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantChartToolStripMenuItem.Click
        Dim GantForm As Form
        Dim frmName As String
        Dim SearchName As String = "Gant_Form"

        GantForm = Get_MDIChildForm(SearchName)

        If Not IsNothing(GantForm) Then
            frmName = GantForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            GantForm = New Form
            GantForm.Name = SearchName
            GantForm.Text = "Gant Form"
            GantForm.MdiParent = Me
            GantForm.StartPosition = FormStartPosition.CenterParent
            GantForm.Tag = Get_GUID()
            comManager.AddFormControls(GantForm, "Panel", "pnlGant", "", GantForm.Tag, 1, 1, 500, 500)
            'comManager.AddNewControls("txt1", True, Nothing, Nothing,)
            'PLANETSForm.StartPosition.CenterParent
            GantForm.Show()
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        clsDG_NMS_Controls.ThemeSelection = 0
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        clsDG_NMS_Controls.ThemeSelection = 1
    End Sub

    Private Sub SimpleCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpleCalculatorToolStripMenuItem.Click
        Dim SYSTEMForm As Form
        Dim frmName As String
        Dim SearchName As String = "Calculator"

        SYSTEMForm = Get_MDIChildForm(SearchName)

        If Not IsNothing(SYSTEMForm) Then
            frmName = SYSTEMForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            SYSTEMForm = New Calculator
            SYSTEMForm.Name = SearchName
            SYSTEMForm.Text = "Simple Calculator"
            SYSTEMForm.MdiParent = Me
            SYSTEMForm.StartPosition = FormStartPosition.CenterParent
            SYSTEMForm.Tag = Get_GUID()
            'PLANETSForm.StartPosition.CenterParent
            SYSTEMForm.Show()
        End If
    End Sub

    Private Sub TransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionsToolStripMenuItem.Click
        'ENTER TRANSACTIONS - ANY:
        Dim SYSTEMForm As frmTransactions
        Dim frmName As String
        Dim SearchName As String = "Transactions"

        Cursor = Cursors.Default
        SYSTEMForm = Get_MDIChildForm(SearchName)
        Cursor = Cursors.WaitCursor
        Refresh()
        If Not IsNothing(SYSTEMForm) Then
            frmName = SYSTEMForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            SYSTEMForm = New frmTransactions
            SYSTEMForm.Name = SearchName
            SYSTEMForm.Text = "TRANSACTIONS"
            SYSTEMForm.MdiParent = Me
            SYSTEMForm.StartPosition = FormStartPosition.CenterParent
            SYSTEMForm.Tag = Get_GUID()
            SYSTEMForm.PopulateForm("", "", "", "", "")
            SYSTEMForm.Show()
        End If
        Cursor = Cursors.Default
    End Sub





End Class