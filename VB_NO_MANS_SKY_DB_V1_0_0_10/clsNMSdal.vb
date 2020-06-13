Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic

Public Class clsNMSdal

    Private _myVersion As String
    Private _myUserID As Integer
    Private _username As String
    Private _DALID As String
    Public myConnection As String = ""
    Public mylogged_in As Boolean = False
    Public myChecked As Boolean = False
    Public logERR = New clsErrorLog
    Dim Message As String = ""
    Public Property GetVersion() As String
        Get
            GetVersion = _myVersion
        End Get
        Set(value As String)
            _myVersion = value
        End Set
    End Property

    Public Property GetUserID() As Integer
        Get
            GetUserID = _myUserID
        End Get
        Set(value As Integer)
            _myUserID = value
        End Set
    End Property

    Public Property GetUsername() As String
        Get
            GetUsername = _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property DALID() As String
        Get
            DALID = _DALID
        End Get
        Set(value As String)
            _DALID = value
        End Set
    End Property

    Public Sub New(Version As String, username As String)
        Me.GetVersion = Version
        Me.GetUsername = username
        Me.DALID = Me.Get_GUID
    End Sub

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
                logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetScreenResolution_Actual()",
                                GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & GetUsername,
                                "")
            End If
        End If
        GetScreenResolution_Actual = NumberOfScreens

    End Function

    Function setupMySQLconnection(ByVal Server As String, ByVal DbaseName As String, ByVal USERNAME As String,
                                    ByVal password As String, ByVal port As String, ByRef Message As String) As String
        'Dim DatabaseName As String = "assetregister"
        'Dim server As String = "localhost"
        'Dim Port As String = "6080"
        'Dim User as String = "root"
        'Dim Values(,) As String
        Dim conn As MySqlConnection
        Dim myCMD As MySqlCommand
        Dim myDR As MySqlDataReader
        Dim Output As String
        Dim ZeroDatetime As Boolean

        Output = ""
        conn = New MySqlConnection()
        If Not conn Is Nothing Then conn.Close()
        ZeroDatetime = True
        'Output = String.Format("server={0}; user id={1}; password={2}; database={3}; port={4}; pooling=false; Convert Zero Datetime=True; Allow Zero Datetime=True;", Server, USERNAME, password, DbaseName, port)
        'Output = String.Format("server={0}; user id={1}; password={2}; database={3}; port={4}; pooling=false; convert zero datetime=True", Server, USERNAME, password, DbaseName, port)
        Output = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)
        conn.ConnectionString = Output
        Try
            conn.Open()
            'myCMD = New MySqlCommand(SQLstr, conn)
            'myDR = myCMD.ExecuteReader()
            'While myDR.Read
            'values() = myDR(fieldname).ToString()
            'End While
            'MsgBox("Connected")
        Catch ex As Exception
            'MsgBox("Error in setupMySQLconnection: " & ex.Message)
            Message = "Error in setupMySQLconnection: " & ex.Message
            logERR.logerror("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "setupMySQLConnection()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            logERR.logmessage("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "setupMySQLConnection()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try
        conn.Close()

        setupMySQLconnection = Output

    End Function

    Function TestLogin(ByVal Server As String, ByVal DbaseName As String, ByVal USERNAME As String,
                       ByVal password As String, ByVal port As String, TestDBName As String, ByVal TestTable As String,
                       ByVal RealTableName As String, ByRef Message As String, MessageLogin As String) As Boolean
        Dim IsChecked As Boolean = False
        Dim IsConnectedToTestDB = False
        Dim IsConnectedToMainDB = False
        Dim conn As MySqlConnection = Nothing
        Dim myCMD As MySqlCommand = Nothing
        Dim myDR As MySqlDataReader = Nothing
        Dim connString As String = ""
        Dim SQLstr As String = ""
        Dim ConnMessage As String = ""

        'Dim Output As String

        Message = ""
        MessageLogin = ""
        If Len(TestDBName) = 0 Then
            'MsgBox("No Test TableName passed", vbOK, "Error ")
            Message = Message & vbCrLf & "No Test Database passed"
        End If
        If Len(Server) = 0 Then
            'MsgBox("No server passed", vbOK, "Error ")
            Message = Message & vbCrLf & "No server passed"
        End If
        If Len(DbaseName) = 0 Then
            'MsgBox("No database name passed", vbOK, "Error ")
            Message = Message & vbCrLf & "No database name passed"
        End If
        If Len(USERNAME) = 0 Then
            'MsgBox("No username passed", vbOK, "Error  ")
            Message = Message & vbCrLf & "No username passed"
        End If
        If Len(port) = 0 Then
            'MsgBox("No port passed", vbOK, "Error ")
            Message = Message & vbCrLf & "No port passed"
        End If
        If Len(Message) > 0 Then
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "TestLogin()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End If
        SQLstr = "Select * FROM " & TestTable
        connString = setupMySQLconnection(Server, TestDBName, USERNAME, password, port, ConnMessage)
        If Len(ConnMessage) > 0 Then
            Message = Message & vbCrLf & " Connection Error: " & ConnMessage
            logERR.LogError("NMS_Error_v" & Me.GetVersion & ".log", Application.StartupPath, Message, "TestLogin()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End If
        'Output = String.Format("server={0}; user id={1}; password={2}; database={3}; port={4}; pooling=False", Server, USERNAME, password, DbaseName, port)
        Try
            conn = New MySqlConnection(connString)
            conn.Open()
            myCMD = New MySqlCommand(SQLstr, conn)
            myDR = myCMD.ExecuteReader()
            'While myDR.Read
            'values() = myDR(fieldname).ToString()
            'End While
            'MsgBox("Connected")
        Catch ex As Exception
            'MsgBox("Error In setupMySQLconnection: " & ex.Message)
            Message = "Error In Test Table with DB Login: " & ex.Message
            TestLogin = False
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "TestLogin()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End Try
        conn.Close()
        MessageLogin = MessageLogin & vbCrLf & " OK - Test DB Connected OK."
        SQLstr = "Select * FROM " & RealTableName
        Message = "DB LOGIN SUCCESSFUL"
        'logERR.logmessage("NMS_MESSAGE_" & Me.GetVersion & ".log", Application.StartupPath, Message, "TestLogin()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & GetUsername)
        connString = setupMySQLconnection(Server, DbaseName, USERNAME, password, port, ConnMessage)
        Try
            conn = New MySqlConnection(connString)
            conn.Open()
            myCMD = New MySqlCommand(SQLstr, conn)
            myDR = myCMD.ExecuteReader()
            'While myDR.Read
            'values() = myDR(fieldname).ToString()
            'End While
            'MsgBox("Connected")
        Catch ex As Exception
            'MsgBox("Error In setupMySQLconnection: " & ex.Message)
            Message = "Exception Error In Test DB Login: " & ex.Message
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "TestLogin()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            logERR.logmessage("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "TestLogin()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            TestLogin = False
            Exit Function
        End Try
        IsChecked = True
        conn.Close()
        myDR.Close()
        TestLogin = IsChecked


    End Function

    Function Get_Total_Rows_From_CSVFile(CSVFilename As String, Optional ByRef TotalFields As Long = 0) As Long
        Dim rownum As Long
        Dim TotalRows As Long
        Dim wholeRows As String()

        Using csvReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(CSVFilename)
            csvReader.TextFieldType = FileIO.FieldType.Delimited
            csvReader.SetDelimiters(",")
            TotalRows = 0
            rownum = 0
            While Not csvReader.EndOfData
                Try
                    wholeRows = csvReader.ReadFields()

                    TotalFields = wholeRows.Length
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is NOT valid and will be skipped.")
                End Try
                rownum = rownum + 1
            End While

        End Using
        TotalRows = rownum
        Get_Total_Rows_From_CSVFile = TotalRows
    End Function

    Function CSVFileToArray(ByRef NewstrArray As String(,), ByVal CSVFilename As String, Optional ByRef TotalFields As Long = 0,
                                Optional ByRef Message As String = "") As Long
        Dim wholeRows As String()
        Dim numRowsRead As Long
        Dim colnum As Long
        Dim RowNum As Long
        Dim currentFields As String
        Dim Percentage As Long
        Dim TotalRows As Long
        Dim RowMessage As String
        Dim messages As String

        ReDim NewstrArray(1, 1)
        CSVFileToArray = 0
        numRowsRead = 0
        colnum = 0
        RowNum = 0
        messages = ""
        ReDim wholeRows(1)
        wholeRows(0) = ""
        'ProgressBarControl.Maximum = 100
        'ProgressBarControl.Value = 0
        'ProgressLabel.Text = "0%"
        'Import from CSV File TEXT field and check validity:
        Try
            Using csvReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(CSVFilename)
                csvReader.TextFieldType = FileIO.FieldType.Delimited
                csvReader.SetDelimiters(",")
                TotalRows = Get_Total_Rows_From_CSVFile(CSVFilename, TotalFields)
                ReDim NewstrArray(TotalFields, TotalRows)
                'frmProgressBar.Show()
                While Not csvReader.EndOfData
                    Try
                        wholeRows = csvReader.ReadFields()
                        colnum = 0
                        For Each currentFields In wholeRows
                            'Me.rtbOutput.Text = currentFields
                            'MsgBox(CStr(RowNum) & ": Field " & CStr(colnum) & " = " & currentFields)
                            '
                            '****************************************************
                            '
                            'AUTHOR : DANIEL GOSS . COPYRIGHT 24-FEB-2017. V1.2
                            'MODIFIED: DANIEL GOSS . COPYRIGHT 01-SEP-2017. v1.3
                            ' - added extra parameter - Messages
                            'MODIFIED: DANIEL GOSS . COPYRIGHT 03-SEP-2017. v1.4 now.
                            ' - removed extra parameter - Messages
                            ' - removed reference to GetFieldValue_From_Index below.
                            ' - added error logging and message logging 12-09-2017 01:50
                            '*****************************************************

                            If TotalRows > 0 Then
                                Percentage = CLng((RowNum / TotalRows) * 100)
                            Else
                                Percentage = 0
                            End If
                            RowMessage = "Read " & CStr(RowNum) & " ROW / " & CStr(TotalRows) & " ROWS"
                            'RichTextBoxMessageControl.Text = "Reading from CSV file ..."
                            'RichTextBoxMessageControl.Text = vbCrLf & RowMessage
                            'ProgressBarControl.Value = Percentage
                            'ProgressLabel.Text = CStr(ProgressBarControl.Value) & "%"
                            NewstrArray(colnum, RowNum) = currentFields

                            Application.DoEvents()

                            colnum = colnum + 1
                        Next
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        If Len(messages) > 0 Then
                            messages = messages & ","
                        End If
                        messages = messages & " Line " & ex.Message & "is NOT valid and will be skipped."
                        Message = messages
                        logERR.LogMessage("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "CSVFileToArray()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
                    End Try
                    RowNum = RowNum + 1
                End While
            End Using
        Catch ex As Exception
            Message = "Error In CSVFileToArray: " & ex.Message.ToString
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "CSVFileToArray()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try
        numRowsRead = RowNum
        'currentRow is an array containing all the data now.
        'Me.rtbOutput.Text = ""
        'frmProgressBar.Hide()
        CSVFileToArray = numRowsRead
    End Function

    Function GetFieldValue_From_Fieldname(ByVal AllRows As Object, ByVal RowIDX As Long, ByVal FieldName As String, Optional ByRef FieldPos As Long = 0) As String
        Dim ReturnValue As String
        Dim colIDX As Long
        Dim ArrayValues As String

        'AllRows(Fields,0) - row 0 contains all the fieldnames
        GetFieldValue_From_Fieldname = ""
        ReturnValue = ""
        If IsNothing(AllRows) Then
            GetFieldValue_From_Fieldname = ReturnValue
            Exit Function
        End If
        For colIDX = 0 To UBound(AllRows, 1)
            ArrayValues = AllRows(colIDX, RowIDX)
            If UCase(FieldName) = UCase(AllRows(colIDX, 0)) Then
                ReturnValue = ArrayValues
                FieldPos = colIDX
                Exit For
            End If
            'colIDX = colIDX + 1
        Next
        GetFieldValue_From_Fieldname = ReturnValue
    End Function

    Function GetMYValuebyFieldname(ByVal SearchObjects As Object(), ByVal FieldnamesArr_IN As String(), ByVal ReturnField As String,
                                    Optional ByRef Message As String = "") As String
        Dim fieldidx As Int32
        Dim ReturnValue As String
        Dim NumFields As Integer

        'Need to cycle through the Fieldnames and find the correct index.
        'THEN apply it to the SearchObjects to get the value.
        'NumFields = GetNumFields("", "SELECT * FROM " & dbTable, "AssetRegister.accdb", Fieldnames)
        ReturnValue = ""
        GetMYValuebyFieldname = ""

        If IsNothing(SearchObjects) Then
            Exit Function
        End If
        If IsNothing(FieldnamesArr_IN) Then
            Exit Function
        End If
        NumFields = UBound(FieldnamesArr_IN)
        Try
            For fieldidx = 0 To NumFields
                If UCase(ReturnField) = UCase(FieldnamesArr_IN(fieldidx)) Then
                    ReturnValue = SearchObjects(fieldidx).ToString
                    Return ReturnValue
                    Exit For
                End If
            Next
        Catch ex As Exception
            Message = "Exception Error in GetMyValuebyFieldname: " & ex.ToString
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetMYValuebyFieldname()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try
        GetMYValuebyFieldname = ReturnValue

    End Function

    Function GetMyMultiValuebyFieldname(ByVal SearchObjects As Object(,), ByVal Fieldnames As String(), ByVal ReturnField As String,
                                    Optional ByRef Message As String = "", Optional ByVal RowIndex As Long = 0) As String
        Dim fieldidx As Int32
        Dim ReturnValue As String
        Dim NumFields As Integer

        'Need to cycle through the Fieldnames and find the correct index.
        'THEN apply it to the SearchObjects to get the value.
        'NumFields = GetNumFields("", "SELECT * FROM " & dbTable, "AssetRegister.accdb", Fieldnames)
        ReturnValue = ""
        GetMyMultiValuebyFieldname = ""

        If IsNothing(SearchObjects) Then
            Exit Function
        End If
        NumFields = UBound(Fieldnames)
        Try
            For fieldidx = 0 To NumFields
                If UCase(ReturnField) = UCase(Fieldnames(fieldidx)) Then
                    ReturnValue = SearchObjects(RowIndex, fieldidx).ToString
                    Return ReturnValue
                    Exit For
                End If
            Next
        Catch ex As Exception
            Message = "Exception Error in GetValuebyFieldname: " & ex.ToString
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetMyMultiValuebyFieldname()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try
        GetMyMultiValuebyFieldname = ReturnValue
    End Function

    Function GetDetails(ByVal conString As String, ByVal SearchTable As String,
                            ByVal SearchField As String, ByVal SearchValue As String, ByVal ReturnField As String,
                            ByRef ReturnValue As String, ByRef Message As String, Optional ByVal Criteria As String = "") As Boolean
        Dim FoundDetail As Boolean = False

        GetDetails = False
        FoundDetail = Find_myQuery(conString, SearchTable, SearchField, SearchValue, "STRING", "", ReturnField, ReturnValue, Nothing, Nothing, Criteria, "", False, Message)
        If FoundDetail Then
            GetDetails = True
        End If

    End Function

    Public Function GetDataTable(ConnString As String, strSQL As String,
                                  Optional ByRef NumRows As Integer = 0) As DataTable
        Dim myConn As New MySqlConnection
        Dim myds As New DataSet

        GetDataTable = Nothing
        If Len(strSQL) = 0 Then
            'MsgBox("Error in mySQLToArray: QUERY (strSQL) is blank.", vbOK, "Error in Asset-Register v")
            Message = "Error in mySQLToArray: QUERY (strSQL) is blank."
            '"NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetMyMultiValuebyFieldname()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetDataTable()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End If
        If Len(ConnString) = 0 Then
            'MsgBox("Error in mySQLToArray: Connection String is blank.", vbOK, "Error in Asset-Register v")
            Message = "Error in mySQLToArray: CONNECTION STRING is BLANK."
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetDataTable()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End If
        Try
            myConn = New MySqlConnection(ConnString)
            myConn.Open()
            Dim mycmd As New MySqlCommand(strSQL, myConn)
            Dim myda As New MySqlDataAdapter(mycmd)

            myda.Fill(myds)
            NumRows = myds.Tables(0).Rows.Count
            If NumRows = 0 Then
                Exit Function
            Else
                Return myds.Tables(0)
            End If
            'NumFields = GetMyNumFields(ConnString, SQLstr, FieldList, FieldTypes, ColWidths)
        Catch ex As Exception
            'MsgBox("Exception Error: " & ex.ToString, vbOK, "Exception Error in Asset Register")
            Message = "GetDataTable() Exception Error: " & ex.ToString & ", SQL= " & strSQL
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetDataTable()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try


    End Function

    Public Function GetUnitCost(myConnstring As String, strUserID As String, strAccountID As String, strSystemID As String, strPlanetID As String, strLocation As String) As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SearchText As String
        Dim SearchCriteria As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim FieldType As String
        Dim Reversed As Boolean = False
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim FoundTransaction As Boolean = False
        Dim DBTable As String = "tblTransactions"
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String
        Dim ErrMessages As String
        Dim Answer As Integer
        Dim UpdateCriteria As String
        Dim SavedOK As Boolean
        Dim Result As Integer

        GetUnitCost = ""
        SearchText = strUserID
        SearchField = "UserID"
        ReturnField = "UnitCost"
        ReturnValue = ""
        AllValues = Nothing
        AllFields = Nothing
        DBTable = "tblTransactions"
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "TransactionDate"
        ExcludeFields = ""
        ErrMessage = ""
        ErrMessages = ""

        If Not IsNumeric(strUserID) Then
            strUserID = "0"
        End If
        If Not IsNumeric(strAccountID) Then
            strAccountID = "0"
        End If
        If Not IsNumeric(strSystemID) Then
            strSystemID = "0"
        End If
        If Not IsNumeric(strPlanetID) Then
            strPlanetID = "0"
        End If

        SearchCriteria = "AccountID=" & CInt(strAccountID) & " AND SystemID=" & CInt(strSystemID) & " AND PlanetID=" & CInt(strPlanetID) & " AND Location = '" & strLocation & "'"
        FoundTransaction = Me.Find_myQuery(myConnstring, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundTransaction Then
            GetUnitCost = ReturnValue
        End If

    End Function
    Public Function UpdateAccount(myConnstring As String, strAccountID As String, strAccountName As String, strPlatform As String, strVersion As String, strSubmitTime As String,
                                  strComments As String, DefaultAccount As String, strUserID As String, strGamerHandle As String,
                                  Optional SearchCriteria As String = "") As Integer
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim FieldType As String
        Dim Reversed As Boolean = False
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim FoundAccount As Boolean = False
        Dim DBTable As String
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String
        Dim ErrMessages As String
        Dim Answer As Integer
        Dim UpdateCriteria As String
        Dim SavedOK As Boolean
        Dim Result As Integer
        Dim strDateCreated As String

        'Return 0=NOTHING HAPPEND, 1=UPDATED OK, 2=INSERTED OK, 3=ERROR
        UpdateAccount = 0
        Result = 0
        FieldNames = "AccountName"
        FieldNames = FieldNames & ",GamePlatform"
        FieldNames = FieldNames & ",GameVersion"
        FieldNames = FieldNames & ",DateSubmitted"
        FieldNames = FieldNames & ",Comments"
        FieldNames = FieldNames & ",DefaultAccount"
        FieldNames = FieldNames & ",UserID"
        FieldNames = FieldNames & ",GamerHandle"

        FieldValues = strAccountName
        FieldValues = FieldValues & "," & strPlatform
        FieldValues = FieldValues & "," & strVersion
        FieldValues = FieldValues & "," & strSubmitTime
        FieldValues = FieldValues & "," & strComments
        FieldValues = FieldValues & "," & DefaultAccount
        FieldValues = FieldValues & "," & strUserID
        FieldValues = FieldValues & "," & strGamerHandle

        SearchText = strAccountID
        SearchField = "AccountID"
        ReturnField = "AccountID"
        ReturnValue = ""
        AllValues = Nothing
        AllFields = Nothing
        DBTable = "tblAccounts"
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "AccountName"
        ExcludeFields = ""
        ErrMessage = ""
        ErrMessages = ""
        FoundAccount = Me.Find_myQuery(myConnstring, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundAccount Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Account Already EXISTS - Proceed with update?", vbYesNo, "ACCOUNT ALREADY EXISTS")
            If Answer = vbYes Then
                UpdateCriteria = "AccountID = " & ReturnValue
                SavedOK = Me.InsertUpdateRecords_Using_Parameters(myConnstring, True, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                            ",", ";")
                If SavedOK Then
                    Result = 1
                Else
                    Result = 3
                End If
            End If
        Else
            'Create NEW ENTRY:
            UpdateCriteria = ""
            strDateCreated = strSubmitTime
            FieldNames = FieldNames & ",DateCreated"
            FieldValues = FieldValues & "," & strDateCreated
            SavedOK = Me.InsertUpdateRecords_Using_Parameters(myConnstring, False, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                            ",", ";")
            If SavedOK Then
                Result = 2
            Else
                Result = 3
            End If
        End If
        Return Result
    End Function

    Public Function UpdateLog(myConnstring As String, LogFields As clsLogFields, ByRef strLastLogID As String,
                              Optional IncludeVerboseInUpdateMessage As Boolean = True) As Integer
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblLog"
        Dim UpdateCriteria As String
        Dim ExcludeFields As String
        Dim ErrMessages As String = ""
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim SearchCriteria = ""
        Dim FieldType As String
        Dim Reversed As Boolean = True
        Dim SortFields As String
        Dim FoundLOG As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim ImportErrorLog As New clsErrorLog
        Dim InsertMessage As String
        Dim UpdateMessage As String
        Dim Verbose As String
        Dim strLastSaved As String
        Dim Result As Integer
        Dim strComment1 As String
        Dim strComment2 As String

        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.
        UpdateLog = 0
        Result = 0
        dtCurrentDate = Now()
        ErrMessages = ""
        strLastSaved = Now().ToString("yyyy-MM-dd HH:mm:ss")

        FieldNames = "UserID"
        FieldNames += ",AccountID"
        FieldNames += ",AccountName"
        FieldNames += ",Platform"
        FieldNames += ",Version"
        FieldNames += ",GamerHandle"
        FieldNames += ",SystemID"
        FieldNames += ",PlanetID"
        FieldNames += ",CurrentDateTime"
        FieldNames += ",CurrentPosition"
        FieldNames += ",CurrentGalacticRegion"
        FieldNames += ",CurrentStarSystem"
        FieldNames += ",CurrentPlanet"
        FieldNames += ",CurrentPlanetArea"
        FieldNames += ",CurrentNanites"
        FieldNames += ",CurrentUnits"
        FieldNames += ",CurrentQuickSilver"
        FieldNames += ",CurrentFrigateModules"
        FieldNames += ",CurrentSalvagedData"
        FieldNames += ",Brief"
        FieldNames += ",Comment1"
        FieldNames += ",Comment2"
        FieldNames += ",LastSaved"
        FieldNames += ",NewSystemName"
        FieldNames += ",NewPlanetName"
        FieldNames += ",OriginalSystemName"
        FieldNames += ",OriginalPlanetName"
        FieldNames += ",LogEntryByUsername"
        'FieldNames += ",RTFComment1"
        'FieldNames += ",RTFComment2"

        FieldValues = LogFields.myUserID
        FieldValues += "," & LogFields.AccountID
        FieldValues += "," & LogFields.AccountName
        FieldValues += "," & LogFields.Platform
        FieldValues += "," & LogFields.Version
        FieldValues += "," & LogFields.GamerHandle
        FieldValues += "," & LogFields.SystemID
        FieldValues += "," & LogFields.PlanetID
        FieldValues += "," & LogFields.EntryTime
        FieldValues += "," & LogFields.CurrentPosition
        FieldValues += "," & LogFields.GalacticRegion
        FieldValues += "," & LogFields.SystemName
        FieldValues += "," & LogFields.PlanetName
        FieldValues += "," & LogFields.CurrentArea
        FieldValues += "," & LogFields.CurrentNanites
        FieldValues += "," & LogFields.CurrentUnits
        FieldValues += "," & LogFields.CurrentQS
        FieldValues += "," & LogFields.CurrentFrigateModules
        FieldValues += "," & LogFields.CurrentSalvagedData
        FieldValues += "," & LogFields.Brief
        FieldValues += "," & LogFields.Comment1
        FieldValues += "," & LogFields.Comment2
        FieldValues += "," & LogFields.LastSaved
        FieldValues += "," & LogFields.NewSystemName
        FieldValues += "," & LogFields.NewPlanetName
        FieldValues += "," & LogFields.OriginalSystemName
        FieldValues += "," & LogFields.OriginalPlanetName
        FieldValues += "," & LogFields.LogSavedBy

        SearchText = LogFields.EntryTime
        SearchField = "CurrentDateTime"
        ReturnField = "LogID"
        ReturnValue = ""
        FieldType = "DATE"
        Reversed = True
        SortFields = ""
        ExcludeFields = ""
        FoundLOG = Find_myQuery(myConnstring, DBTable, SearchField, SearchText, FieldType, "yyyy-MM-dd HH:mm:ss", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)

        'LogFilename = "NMS_LOG_ENTRIES"
        If IncludeVerboseInUpdateMessage Then
            Verbose = GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & GetUsername
            LogFields.LogFile += "_VERBOSE_"
        Else
            LogFields.LogFile += "_SHORT_"
            Verbose = ""
        End If
        If FoundLOG Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")

            UpdateCriteria = "LogID = " & ReturnValue

            UpdateMessage = Now().ToString("dd/MMM/yyyy HH:mm:ss") & " Log Entry Updated OK: " & ReturnValue
            UpdateMessage += FieldValues

            SavedOK = Me.InsertUpdateRecords_Using_Parameters(myConnstring, True, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
            If SavedOK Then
                ImportErrorLog.LogMessage(LogFields.LogFile & GetVersion & ".log", Application.StartupPath, UpdateMessage, "", Verbose)
                strLastLogID = ReturnValue
                Result = 1
            Else
                ImportErrorLog.LogError("Log_Error_" & LogFields.LogFile & GetVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & " Error:" & ", " & ErrMessages, "", Verbose)
                Result = 3
            End If
        Else
            'Create NEW ENTRY:
            UpdateCriteria = ""
            InsertMessage = Now().ToString("dd/MMM/yyyy HH:mm:ss") & " Log Entry INSERTED OK: " & ReturnValue
            InsertMessage += FieldValues

            SavedOK = Me.InsertUpdateRecords_Using_Parameters(myConnstring, False, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
            If SavedOK Then
                ImportErrorLog.LogMessage(LogFields.LogFile & GetVersion & ".log", Application.StartupPath, InsertMessage, "", Verbose)
                Result = 2
                'NEED THE NEW LOGID !!!!
                strLastLogID = Me.GetLastID(myConnstring, "tblLog", "LogID")
            Else
                ImportErrorLog.LogError("Log_Error_" & LogFields.LogFile & GetVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & " Error:" & ", " & ErrMessages, "", Verbose)
                Result = 3
            End If
        End If

        'SAVE RichTextBox
        'SAVE IMAGE



        UpdateLog = Result
    End Function

    Public Function Find_myQuery(ByVal connString As String, ByVal DBTable As String, ByVal SearchField As String,
                            ByVal SearchText As String, ByVal SearchType As String, ByVal SearchFormat As String, ByVal ReturnField As String,
                            ByRef ReturnValue As String, Optional ByRef AllFieldValues As Object() = Nothing,
                            Optional ByRef AllFieldNames As String() = Nothing, Optional ByVal Criteria As String = "",
                            Optional SortField As String = "", Optional ByVal Reversed As Boolean = False,
                            Optional ByRef Message As String = "", Optional ByVal Operation As String = "=",
                            Optional ByRef numRows As Long = 0,
                            Optional ByVal MatchCase As Boolean = False) As Boolean
        Dim QryStr As String
        Dim cmd As MySqlCommand
        Dim con As MySqlConnection
        Dim WholeRow As Object()
        Dim Fieldnames As String()
        Dim FieldTypes As Type()
        Dim Fieldindex As Integer = 0
        Dim IDX As Integer
        Dim Rows As Long = 0
        Dim numFields As Integer
        Dim dr1 As MySqlDataReader
        Dim myReader As MySqlDataReader
        Dim SearchFieldType As Type = Nothing
        Dim CurValue As String = ""

        '**********************************************************************************************************************************
        '*************************** SEARCH CRITERIA MAY BE DIFFERENT TO UPDATE CRITERIA !!!!!!!! *****************************************
        '**********************************************************************************************************************************
        '17/03/2020 21:50 - ADDED NEW PARAMETER = byval SearchFormat - specifically to search for dates.
        Find_myQuery = False
        'ReDim WholeRow(1)
        Message = ""
        If Len(DBTable) = 0 Then
            'MsgBox("Error In FIND_ME: No DB Table specified")
            Message = "Error in Find_myQuery: No DB Table specified"
            Find_myQuery = False
            Exit Function
        End If
        ReturnValue = ""
        Try
            con = New MySqlConnection(connString)
            con.Open()
            If UCase(SearchType) = "STRING" Then
                QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & " " & Operation & " '" & SearchText & "') "
                'QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & Operation & "'" & SearchText & "')"
            ElseIf UCase(SearchType) = "INTEGER" Then
                QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & Operation & SearchText & ") "
            ElseIf UCase(SearchType) = "DATE" Then
                QryStr = "SELECT * FROM " & DBTable & " WHERE ((" & SearchField & ") " & Operation & Chr(39) & SearchText & Chr(39) & ") "

            Else
                QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & Operation & SearchText & "f" & ") "
            End If
            If Len(Criteria) > 0 Then
                'QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & " = '" & SearchText & "')"
                QryStr = QryStr & " AND " & Criteria
            End If
            If Len(SortField) > 0 Then
                QryStr = QryStr + " ORDER BY " + SortField
                If Reversed = False Then
                    QryStr = QryStr + " ASC"
                Else
                    QryStr = QryStr + " DESC"
                End If
            End If
            '
            cmd = New MySqlCommand(QryStr, con)
            dr1 = cmd.ExecuteReader()

            numFields = dr1.FieldCount - 1
            ReDim Fieldnames(numFields + 1)
            ReDim FieldTypes(numFields + 1)
            IDX = 0
            While IDX <= numFields
                Fieldnames(IDX) = dr1.GetName(IDX)
                FieldTypes(IDX) = dr1.GetFieldType(IDX)
                If UCase(Fieldnames(IDX)) = UCase(SearchField) Then
                    SearchFieldType = dr1.GetFieldType(IDX)
                    'Exit While - need to loop completely to get all of the FIELDNAMES. else use dr1.Fields.ColumnName(index)
                    'Could use FieldnameExists = dr1.GetSchemaTable.Columns.Contains(Fieldname)
                End If
                IDX = IDX + 1
            End While
            AllFieldNames = Fieldnames
            dr1.Close()
            ReDim WholeRow(numFields + 1)
            myReader = cmd.ExecuteReader()
            If IsNothing(myReader) Then
                Exit Function
            End If
            If myReader.HasRows Then
                'myReader.GetValues(WholeRow)
                'AllFieldValues = WholeRow
                While myReader.Read()
                    'DescriptionText.Text = dr("Description").ToString
                    'CostText.Text = dr("Cost").ToString
                    'PriceText.Text = dr("Price").ToString

                    'WHAT IF THE SEARCH TYPE is not STRING here ??????
                    If InStr(Operation, ">") > 0 Then
                        CurValue = myReader(ReturnField).ToString
                        Find_myQuery = True
                        myReader.GetValues(WholeRow)
                        AllFieldValues = WholeRow
                        'myReader.Close()
                        'The following should only be executed if ONE value - the FIRST value found is required.
                        'Otherwise - store in a 2-dim array and return that in the array passed.
                        Exit While
                    Else
                        CurValue = myReader(SearchField).ToString
                        If MatchCase = False Then
                            SearchText = UCase(SearchText)
                            CurValue = UCase(CurValue)
                        End If

                        If UCase(myReader.GetFieldType(SearchField).ToString) = "SYSTEM.DATETIME" Then
                            If IsDate(SearchText) Then
                                CurValue = CDate(myReader(SearchField).ToString).ToString(SearchFormat)
                                SearchText = CDate(SearchText).ToString(SearchFormat)
                                'ReturnValue = CurValue
                            Else
                                MsgBox("Search Text is not in DATE FORMAT")
                                Exit Function
                            End If
                        Else
                            ReturnValue = myReader.GetString(ReturnField)
                        End If
                        If CurValue = SearchText Then
                            If Len(ReturnField) > 0 Then
                                Find_myQuery = True
                            End If
                            'Got to extract the whole row:
                            myReader.GetValues(WholeRow)
                            ReturnValue = GetMYValuebyFieldname(WholeRow, Fieldnames, ReturnField, "")
                            'myReader.FieldCount

                            AllFieldValues = WholeRow
                            Find_myQuery = True
                            'myReader.Close()
                            Exit While
                        End If
                    End If
                    numRows = numRows + 1
                End While

            Else
                'No Rows
                Find_myQuery = False
                numRows = 0
            End If
            If (Not myReader Is Nothing) Then
                myReader.Close()
            End If
            con.Close()

        Catch ex As Exception
            Message = "Exception Error in Find_myQuery : " & ex.ToString
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "Find_myQuery()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try


    End Function

    Public Function Find_myMultiQuery(ByVal connString As String, ByVal DBTable As String, ByVal SearchField As String,
                            ByVal SearchText As String, ByVal SearchType As String, ByVal ReturnField As String,
                            ByRef ReturnValue As String, Optional ByRef AllFieldValues As Object() = Nothing,
                            Optional ByRef AllFieldNames As String() = Nothing, Optional ByVal Criteria As String = "",
                            Optional SortField As String = "", Optional ByVal Reversed As Boolean = False,
                            Optional ByRef Message As String = "", Optional ByVal Operation As String = " = ",
                            Optional ByVal ReturnSingleValue As Boolean = True, Optional ByRef Return_2Dim_Array As Object(,) = Nothing,
                                 Optional ByRef numRows As Long = 0, Optional ByRef LastReturnRow As Long = -1) As Boolean

        Dim QryStr As String
        Dim cmd As MySqlCommand
        Dim con As MySqlConnection
        Dim WholeRow As Object()
        Dim Fieldnames As String()
        Dim Fieldindex As Integer = 0
        Dim IDX As Integer
        Dim TotalRows As Long = 0
        Dim numFields As Integer
        Dim dr1 As MySqlDataReader
        Dim myReader As MySqlDataReader
        Dim SearchFieldType As Type = Nothing
        Dim CurValue As String = ""
        Dim ReturnRowIdx As Long = -1

        Find_myMultiQuery = False
        numRows = -1
        'ReDim WholeRow(1)
        Message = ""
        If Len(DBTable) = 0 Then
            'MsgBox("Error In FIND_ME: No DB Table specified")
            Message = "Error in Find_myQuery: No DB Table specified"
            Find_myMultiQuery = False
            Exit Function
        End If
        ReturnValue = ""
        Find_myMultiQuery = False
        Try

            If UCase(SearchType) = "STRING" Then
                'QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & " " & Operation & " '" & SearchText & "')"
                QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & Operation & "'" & SearchText & "')"
            ElseIf UCase(SearchType) = "INTEGER" Then
                QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & Operation & SearchText & ")"
            ElseIf UCase(SearchType) = "DATE" Then
                QryStr = "SELECT * FROM " & DBTable & " WHERE (DATE(" & SearchField & ") " & Operation & Chr(39) & SearchText & Chr(39) & ")"
            Else
                QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & Operation & SearchText & "f" & ")"
            End If
            If Len(Criteria) > 0 Then
                'QryStr = "SELECT * FROM " & DBTable & " WHERE (" & SearchField & " = '" & SearchText & "')"
                QryStr = QryStr & " AND " & Criteria
            End If
            If Len(SortField) > 0 Then
                QryStr = QryStr + " ORDER BY " + SortField
                If Reversed = False Then
                    QryStr = QryStr + " ASC"
                Else
                    QryStr = QryStr + " DESC"
                End If
            End If
            '
            con = New MySqlConnection(connString)
            con.Open()
            cmd = New MySqlCommand(QryStr, con)
            dr1 = cmd.ExecuteReader()
            While dr1.Read()
                TotalRows = TotalRows + 1
            End While
            numFields = dr1.FieldCount - 1
            ReDim Fieldnames(numFields)
            IDX = 0
            LastReturnRow = -1
            While IDX <= numFields
                Fieldnames(IDX) = dr1.GetName(IDX)
                If UCase(Fieldnames(IDX)) = UCase(SearchField) Then
                    SearchFieldType = dr1.GetFieldType(IDX)
                    'Exit While
                End If
                IDX = IDX + 1
            End While
            AllFieldNames = Fieldnames
            dr1.Close()
            ReDim WholeRow(numFields + 1)
            ReDim Return_2Dim_Array(TotalRows + 1, numFields + 1)
            myReader = cmd.ExecuteReader()
            If myReader.HasRows Then
                ReturnRowIdx = 0
                numRows = 0
                'myReader.GetValues(WholeRow)
                'AllFieldValues = WholeRow
                While myReader.Read()
                    'DescriptionText.Text = dr("Description").ToString
                    'CostText.Text = dr("Cost").ToString
                    'PriceText.Text = dr("Price").ToString

                    'WHAT IF THE SEARCH TYPE is not STRING here ??????
                    If InStr(Operation, ">") > 0 Then 'Return the details of the last record found.
                        ReturnValue = myReader(ReturnField).ToString
                        Find_myMultiQuery = True
                        myReader.GetValues(WholeRow)
                        AllFieldValues = WholeRow
                        'myReader.Close()
                        'The following should only be executed if ONE value - the FIRST value found is required.
                        'Otherwise - store in a 2-dim array and return that in the array passed.
                        For Fieldindex = 0 To numFields - 1
                            Return_2Dim_Array(ReturnRowIdx, Fieldindex) = myReader.GetString(Fieldindex)
                        Next
                        If Len(ReturnField) > 0 Then
                            ReturnValue = myReader(ReturnField).ToString
                            LastReturnRow = numRows
                            Find_myMultiQuery = True
                        End If
                        If ReturnSingleValue = True Then
                            Exit While
                        End If
                    Else
                        If UCase(myReader(SearchField).ToString) = UCase(SearchText) Then
                            myReader.GetValues(WholeRow)
                            For Fieldindex = 0 To numFields - 1
                                Return_2Dim_Array(ReturnRowIdx, Fieldindex) = myReader.GetString(Fieldindex)
                            Next
                            If Len(ReturnField) > 0 Then
                                ReturnValue = myReader(ReturnField).ToString
                                LastReturnRow = numRows
                                Find_myMultiQuery = True
                            End If
                            AllFieldValues = WholeRow
                            Find_myMultiQuery = True
                            'myReader.Close()
                            If ReturnSingleValue = True Then
                                Exit While
                            End If
                        End If
                    End If
                    numRows = numRows + 1
                    ReturnRowIdx = ReturnRowIdx + 1
                End While

            Else
                'No Rows
                Find_myMultiQuery = False
                numRows = 0
            End If
            If (Not myReader Is Nothing) Then
                myReader.Close()
            End If
            con.Close()

        Catch ex As Exception
            Message = "Exception Error in Find_mymultiQuery : " & ex.ToString
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "Find_myMultiQuery()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try

    End Function

    Sub PopulateMyDataSource(ByRef DSource As Object, ByVal connString As String, ByRef SQLStr As String,
                             Optional ByRef NumRows As Integer = 0,
                             Optional ByRef Message As String = "",
                             Optional ByRef DSetTable As DataTable = Nothing)
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim dt As New DataTable
        Dim IDX As Integer = 0
        Dim tblName As String = ""
        Dim PosFrom As Integer = 0
        Dim PosSpace As Integer = 0
        Dim IdxCol As DataColumn

        PosFrom = InStr(UCase(SQLStr), "FROM")
        PosSpace = InStr(PosFrom + 5, SQLStr, " ")
        If (PosSpace - PosFrom) - 5 > 0 Then
            tblName = Mid(SQLStr, PosFrom + 5, (PosSpace - PosFrom) - 5)
        Else
            tblName = "PosFrom= " & CStr(PosFrom) & ", PosSpace= " & CStr(PosSpace)
        End If

        Try
            con = New MySqlConnection(connString)
            cmd = New MySqlCommand(SQLStr, con)
            con.Open()
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet()

            da.Fill(ds, "srcTable") 'MYSQL DATE CONVERSION PROBLEM HERE !
            If IsDBNull(ds.Tables("srcTable")) Then
                Message = "Problem: Empty Rows"
                logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "PopulateMyDataSource()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
                NumRows = 0
            Else
                NumRows = ds.Tables("srcTable").Rows.Count

                If NumRows > 0 Then
                    'If Not IsNothing(DSetTable) Then
                    da.Fill(dt)
                    DSetTable = dt
                    'End If
                    DSource = ds.Tables("srcTable") 'THIS DOES NOT REFER TO THE DATAGRIDVIEW PROPERTIES. THIS IS JUST THE DATA SOURCE.

                    'DSet = ds
                    If Not IsNothing(DSource) Then
                        IdxCol = ds.Tables("srcTable").Columns.Add 'yea this does add a blank column to each grid.
                        IdxCol.SetOrdinal(0) 'Yep this puts the new blank column as the first column in the data grid.
                        IdxCol.ColumnName = "#"
                        'IdxCol.width = 10
                        For RowIDX = 0 To NumRows - 1
                            'not valid:
                            ds.Tables("srcTable").Rows(RowIDX)(0) = CStr(RowIDX + 1)
                        Next
                    End If
                    dt = ds.Tables("srctable")

                Else
                    Message = "NOTHING FOUND"
                End If
                DSetTable = dt
            End If
            con.Close()
        Catch ex As Exception
            'MsgBox("Exception Error: " & ex.ToString, vbOK, "Exception Error in Asset Register")
            Message = Message & vbCrLf & "Exception Error in PopulateMyDataSource: " & ex.ToString & ", SQL= " & SQLStr
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "PopulateMyDataSource()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try


    End Sub

    Function IsFieldExcluded(Fieldname As String, ExcludedList As String) As Boolean
        Dim IDX As Integer
        Dim ExcludedListArr As String()

        ExcludedListArr = Split(ExcludedList, ",")
        IsFieldExcluded = False
        For IDX = 0 To UBound(ExcludedListArr) 'DOES THIS LIST ALL THE FIELDS IN THE PASSED LIST ?????
            If UCase(Fieldname) = UCase(ExcludedListArr(IDX)) Then
                IsFieldExcluded = True
            End If
        Next

        Return IsFieldExcluded

    End Function

    Function UpdateALL(connString As String, DBTable As String, FieldName As String,
                       Optional FieldValue As String = Chr(39) & Chr(39),
                       Optional FurtherUpdateCriteria As String = "") As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim DataSource As String
        Dim strSQL As String
        Dim ExcludedFields As String
        Dim NumRows As Integer
        Dim NumFields As Integer
        Dim NumBlankFields As Integer
        Dim MyMessage As String = ""
        Dim AlreadyExists As Boolean
        Dim AllFieldNames As String()
        Dim AllFieldValues As Object()
        Dim Criteria As String
        Dim ReturnValue As String

        UpdateALL = False
        Criteria = "UserID=" & CInt(frmMain.myUserID)
        AlreadyExists = Find_myQuery(connString, DBTable, FieldName, FieldValue, "STRING", "", FieldName, ReturnValue, AllFieldValues,
                                        AllFieldNames, Criteria)
        If AlreadyExists Then
            'Update
            strSQL = "UPDATE " & DBTable & " SET " & FieldName & " = " & FieldValue
            strSQL += " WHERE UserID=" & CInt(frmMain.myUserID)
            If FurtherUpdateCriteria <> "" Then
                strSQL += " AND " & FurtherUpdateCriteria
            End If
        Else
            'INSERT
            strSQL = "INSERT INTO " & DBTable & " (" & "UserID," & FieldName & ") VALUES (" & frmMain.myUserID & "," & FieldValue & ")"
        End If
        Try
            con = New MySqlConnection(connString)
            cmd = New MySqlCommand(strSQL, con)
            da = New MySqlDataAdapter(cmd.CommandText, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MyMessage = "Exception Error in UpdateALL function: " & ex.ToString
            UpdateALL = False
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "UpdateALL()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End Try
        UpdateALL = True

    End Function

    Function UpdateDefaults(connString As String, TargetTable As String, strDefaults As String, strIDs As String) As Boolean
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SearchField As String
        Dim SearchText As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim Criteria As String
        Dim PrefCategory As String = "DEFAULTS"
        Dim AlreadyExists As Boolean
        Dim DBTable As String
        Dim AllFieldNames As String()
        Dim AllFieldValues As Object()
        Dim SavedOK As Boolean
        Dim UpdateCriteria As String
        Dim strAccountID As String
        Dim semicolonPos As Integer
        Dim intAccountID As Integer
        Dim intUserID As Integer
        Dim strUserID As String
        Dim strSystemID As String
        Dim strPlanetID As String
        Dim strAreaID As String
        Dim strBaseID As String
        Dim arrIDs As String()

        DBTable = "tblPreferences"
        SearchField = "Category"
        SearchText = PrefCategory
        ReturnField = "PrefID"
        ReturnValue = ""
        AllFieldValues = Nothing
        AllFieldNames = Nothing
        AlreadyExists = False
        SavedOK = False
        semicolonPos = InStr(strIDs, ";")
        If semicolonPos < 2 Then
            MsgBox("User ID not exist")
            Return False
            Exit Function
        End If
        arrIDs = Split(strIDs, ";")
        'arrIDs(0) = UserID
        'arrIDs(1) = AccountID
        'arrIDs(2) = SystemID
        'arrIDs(3) = PlanetID
        'arrIDs(4) = AreaID
        'arrIDs(5) = BaseID

        'strAccountID = Mid(strDefaults, 1, semicolonPos - 1)
        strUserID = arrIDs(0)
        intUserID = CInt(strUserID)
        intAccountID = 0

        Criteria = "UserID=" & intUserID
        AlreadyExists = Find_myQuery(connString, DBTable, SearchField, SearchText, "STRING", "",
                                     ReturnField, ReturnValue, AllFieldValues, AllFieldNames, Criteria)
        If AlreadyExists Then
            FieldNames = "UserID,AccountID,DBTable,DEFAULTS,SavedIDs"
            FieldValues = intUserID & "," & intAccountID & "," & TargetTable & "," & strDefaults & "," & strIDs
            UpdateCriteria = Criteria & " AND Category= " & Chr(34) & PrefCategory & Chr(34)
            SavedOK = InsertUpdateRecords_Using_Parameters(connString, True, "", DBTable, FieldNames, FieldValues,
                        UpdateCriteria)
            If SavedOK Then
                MsgBox("OK DEFAULTS UPDATED OK")
                Return True
            Else
                MsgBox("DEFAULTS did NOT UPDATE")
                Return False
            End If
        Else
            'INSERT NEW DEFAULTS record:
            FieldNames = "UserID,AccountID,Category,DBTable,Defaults,SavedIDs"
            FieldValues = intUserID & "," & intAccountID & "," & PrefCategory & "," & TargetTable & "," & strDefaults & "," & strIDs
            SavedOK = InsertUpdateRecords_Using_Parameters(connString, False, "", DBTable, FieldNames, FieldValues)
            If SavedOK Then
                MsgBox("OK DEFAULTS INSERTED OK")
                Return True
            Else
                MsgBox("DEFAULTS did NOT INSERT")
                Return False
            End If
        End If


    End Function

    Function GetDefaults(ConnString As String, DefaultsTable As String, strAccountID As String, ByRef strDefaults As String) As DataTable
        Dim dt As DataTable
        Dim Criteria As String
        Dim strSQL As String
        Dim intAccountID As Integer
        Dim strIDs As String

        'arrIDs(0) = AccountID
        'arrIDs(1) = SystemID
        'arrIDs(2) = PlanetID
        'arrIDs(3) = AreaID
        'arrIDs(4) = BaseID
        GetDefaults = Nothing

        If strAccountID = "" Or strAccountID = "0" Then
            'MsgBox("No AccountID specified")
            'Return ""
            'Exit Function
            intAccountID = 0
            Criteria = "UserID=" & CInt(frmMain.myUserID) & " AND AccountID=" & intAccountID & " AND Category= " & Chr(34) & "DEFAULTS" & Chr(34)
        Else
            intAccountID = CInt(strAccountID)
            Criteria = "UserID=" & CInt(frmMain.myUserID) & " AND AccountID=" & intAccountID & " AND Category= " & Chr(34) & "DEFAULTS" & Chr(34)
        End If

        strSQL = "SELECT AccountID,UserID,Category,DBTable,Defaults,SavedIds FROM tblPreferences "
        strSQL += " WHERE " & Criteria
        dt = GetDataTable(ConnString, strSQL)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                strDefaults = dt.Rows(0)("DEFAULTS").ToString
                GetDefaults = dt
            End If
        Else
            MsgBox("Could not find DEFAULTS")
            Exit Function
        End If


    End Function

    Function GetUnits(ConnString As String, strAccountID As String) As String
        Dim dt As DataTable
        Dim Criteria As String
        Dim strSQL As String
        Dim intAccountID As Integer
        Dim strDefaults As String
        Dim strUnits As String
        Dim strNanites As String
        Dim strQuicksilver As String
        Dim strFrigateModules As String
        Dim strSalvagedData As String
        Dim LastSaved As String

        GetUnits = ""

        If strAccountID = "" Or strAccountID = "0" Then
            'MsgBox("No AccountID specified")
            Return ""
            Exit Function
        Else
            intAccountID = CInt(strAccountID)
            Criteria = "UserID=" & CInt(frmMain.myUserID) & " AND AccountID=" & intAccountID
        End If

        strSQL = "SELECT AccountID,UserID,TotalNanites,TotalUnits,TotalQuicksilver,TotalFrigateModules,TotalSalvagedData,LastSaved FROM tblUnits "
        strSQL += " WHERE " & Criteria
        dt = GetDataTable(ConnString, strSQL)
        If dt IsNot Nothing Then
            If dt.Rows.Count > 0 Then
                strNanites = dt.Rows(0)("TotalNanites").ToString
                strUnits = dt.Rows(0)("TotalUnits").ToString
                strQuicksilver = dt.Rows(0)("TotalQuicksilver").ToString
                LastSaved = dt.Rows(0)("LastSaved").ToString
                strFrigateModules = dt.Rows(0)("TotalFrigateModules").ToString
                strSalvagedData = dt.Rows(0)("TotalSalvagedData").ToString
                GetUnits = strNanites & ";" & strUnits & ";" & strQuicksilver & ";" & strFrigateModules & ";" & strSalvagedData & ";" & LastSaved
            End If
        Else
            'MsgBox("Could not find UNITS for THIS ACCOUNT")
            Return ""
            Exit Function
        End If
    End Function

    Function UpdateUnits(ConnString As String, strAccountID As String, strNanites As String, strUnits As String,
                         strQuickSilver As String, strFrigateModules As String, strSalvagedData As String) As Boolean
        Dim DBTable As String
        Dim SearchField As String
        Dim SearchText As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim AllFieldValues As Object()
        Dim AllFieldNames As String()
        Dim AlreadyExists As Boolean
        Dim SavedOK As Boolean
        Dim intAccountID As Integer
        Dim Criteria As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim UpdateCriteria As String
        Dim LastSaved As String

        UpdateUnits = False
        If strAccountID = "" Then
            MsgBox("No Account ID Passed")
            Exit Function
        End If
        strNanites = Replace(strNanites, ",", "")
        strUnits = Replace(strUnits, ",", "")
        strUnits = Replace(strUnits, "£", "")
        strQuickSilver = Replace(strQuickSilver, ",", "")
        strFrigateModules = Replace(strFrigateModules, ",", "")
        strSalvagedData = Replace(strSalvagedData, ",", "")
        DBTable = "tblUnits"
        SearchField = "AccountID"
        SearchText = strAccountID
        ReturnField = "UnitsID"
        ReturnValue = ""
        AllFieldValues = Nothing
        AllFieldNames = Nothing
        AlreadyExists = False
        SavedOK = False
        intAccountID = CInt(strAccountID)
        Criteria = "UserID=" & CInt(frmMain.myUserID) & " AND AccountID=" & intAccountID
        AlreadyExists = Find_myQuery(ConnString, DBTable, SearchField, SearchText, "STRING", "",
                                     ReturnField, ReturnValue, AllFieldValues, AllFieldNames, Criteria)
        If AlreadyExists Then
            FieldNames = "AccountID,TotalNanites,TotalUnits,TotalQuicksilver,TotalFrigateModules,TotalSalvagedData,LastSaved"
            FieldValues = intAccountID & "," & strNanites & "," & strUnits & "," & strQuickSilver
            FieldValues = FieldValues & "," & strFrigateModules & "," & strSalvagedData & "," & Now().ToString("yyy-MM-dd HH:mm:ss")
            UpdateCriteria = Criteria
            SavedOK = InsertUpdateRecords_Using_Parameters(ConnString, True, "", DBTable, FieldNames, FieldValues,
                        UpdateCriteria)
            If SavedOK Then
                MsgBox("OK UNITS UPDATED OK")
                Return True
            Else
                MsgBox("UNITS did NOT UPDATE")
                Return False
            End If
        Else
            'INSERT NEW DEFAULTS record:
            FieldNames = "UserID,AccountID,TotalNanites,TotalUnits,TotalQuicksilver,TotalFrigateModules,TotalSalvagedData,LastSaved"
            FieldValues = frmMain.myUserID & "," & intAccountID & "," & strNanites & "," & strUnits & "," & strQuickSilver
            FieldValues += "," & strFrigateModules & "," & strSalvagedData & "," & Now().ToString("yyy-MM-dd HH:mm:ss")
            SavedOK = InsertUpdateRecords_Using_Parameters(ConnString, False, "", DBTable, FieldNames, FieldValues)
            If SavedOK Then
                MsgBox("OK UNITS INSERTED OK")
                Return True
            Else
                MsgBox("UNITS did NOT INSERT")
                Return False
            End If
        End If
    End Function

    Function GetMyFields(DBTable As String, ByVal myconnString As String, ByRef Message As String,
                         Optional ExcludeFields As String = "",
                         Optional ByRef MyTypes As String = "",
                         Optional ByVal StartTypeIDX As Long = 0,
                         Optional ByRef Dic_Types As Object = Nothing,
                         Optional ByVal Fieldnames As String = "") As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim dt As DataTable
        Dim DataSource As String
        Dim strSQL As String
        Dim NumRows As Integer
        Dim NumFields As Integer
        Dim NumBlankFields As Integer
        Dim Provider As String = ""
        Dim colIDX As Integer = 0
        Dim dr1 As MySqlDataReader
        'Dim FieldType As Type
        Dim FieldType As String
        Dim TypeIDX As Long
        Dim Fieldname As String
        Dim NewFieldnames As String

        GetMyFields = ""
        NewFieldnames = ""
        NumBlankFields = 0
        NumFields = 0
        Message = ""
        NumRows = 0
        strSQL = ""
        DataSource = ""
        TypeIDX = StartTypeIDX

        Dic_Types = CreateObject("Scripting.Dictionary")
        Dic_Types.comparemode = vbTextCompare

        If Len(DBTable) = 0 Then
            Message = "Error in Insert Record: Database Table not provided"
            Exit Function
        End If
        Try
            con = New MySqlConnection(myconnString)

            con.Open()
            If Len(Fieldnames) > 0 Then
                strSQL = "SELECT " & Fieldnames & " FROM " & DBTable
            Else
                strSQL = "SELECT * FROM " & DBTable
            End If
            cmd = New MySqlCommand(strSQL, con)
            dr1 = cmd.ExecuteReader()

            NumFields = dr1.FieldCount - 1
            If Len(ExcludeFields) = 0 Then
                While colIDX <= NumFields
                    Fieldname = dr1.GetName(colIDX)
                    FieldType = dr1.GetDataTypeName(colIDX)
                    If Not Dic_Types.exists(Fieldname) Then
                        Dic_Types(Fieldname) = FieldType
                    End If
                    If Len(NewFieldnames) = 0 Then
                        NewFieldnames = Fieldname
                        MyTypes = FieldType.ToString
                    Else
                        NewFieldnames = NewFieldnames & "," & Fieldname
                        MyTypes = MyTypes & "," & FieldType.ToString
                    End If
                    colIDX = colIDX + 1
                End While
            Else
                While colIDX <= NumFields
                    If Me.IsFieldExcluded(dr1.GetName(colIDX), ExcludeFields) Then
                        'ignore
                    Else
                        If Len(NewFieldnames) = 0 Then
                            NewFieldnames = dr1.GetName(colIDX)
                        Else
                            NewFieldnames = NewFieldnames & "," & dr1.GetName(colIDX)
                        End If
                    End If
                    colIDX = colIDX + 1
                End While
            End If

            con.Close()
            dr1.Close()
            GetMyFields = NewFieldnames

        Catch ex As Exception
            Message = "Exception Error In GetMyFields: " & ex.Message.ToString
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, Message, "GetMyFields()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End Try

    End Function

    Function GetColumnNames_From_Prefs(connString As String, UserID As Integer, DBTable As String) As String
        'Get Column prefs:
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim dt As DataTable
        Dim ColNames As String
        Dim DataSource As String
        Dim strSQL As String
        Dim ExcludedFields As String
        Dim NumRows As Integer
        Dim NumFields As Integer
        Dim NumBlankFields As Integer
        Dim MyMessage As String = ""
        Dim tblPrefs As String = "tblPreferences"

        GetColumnNames_From_Prefs = ""
        strSQL = "SELECT * FROM " & tblPrefs
        strSQL += " WHERE UserID=" & UserID & " AND DBTable= '" & DBTable & "'"
        'SEARCH AND Extract field values:

        Try
            dt = Me.GetDataTable(frmMain.myConnString, strSQL, NumRows)
            ColNames = dt.Rows(0)("ColNames").ToString
            GetColumnNames_From_Prefs = ColNames
        Catch ex As Exception
            MyMessage = "Exception Error in GetColumnNames_From_Prefs: " & ex.ToString
            GetColumnNames_From_Prefs = ""
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "GetColumnNames_From_Prefs()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End Try
    End Function

    Public Sub SaveColPrefs(ByVal connString As String, ByVal UserID As String, DBTable As String, ColNames As String, ColWidths As String)
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim FieldType As String
        Dim Reversed As Boolean = False
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim FoundUserID As Boolean = False
        Dim PrefTable As String = "tblPreferences"
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim SearchCriteria As String = ""
        Dim ErrMessage As String = ""
        Dim SavedOK As Boolean = False
        Dim UpdateCriteria As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim ErrMessages As String

        FieldNames = "UserID"
        FieldNames += ",DBTable"
        FieldNames += ",ColNames"
        FieldNames += ",ColWidths"

        FieldValues = UserID
        FieldValues += "," & DBTable
        FieldValues += "," & ColNames
        FieldValues += "," & ColWidths

        SearchText = CInt(UserID)
        SearchField = "UserID"
        ReturnField = "PlanetID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = ""
        ExcludeFields = ""
        FoundUserID = Me.Find_myQuery(frmMain.myConnString, PrefTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundUserID Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            UpdateCriteria = "UserID=" & CInt(UserID)
            SavedOK = Me.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                PrefTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
        Else
            'Create NEW ENTRY:
            UpdateCriteria = ""
            SavedOK = Me.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                PrefTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
        End If
        If SavedOK Then
            MsgBox("OK Planet Info Entered")
        Else
            MsgBox("Problem: Planet Info NOT SAVE")
        End If
    End Sub

    Function InsertUpdateRecords_Using_Parameters(ByVal connString As String, ByVal UpdateRecords As Boolean, ByVal REcordID As String,
                    ByVal DBTable As String, ByVal Fieldnames As String, ByVal FieldValues As String,
                    Optional ByVal UpdateCriteria As String = "", Optional ByVal ExcludeFields As String = "", Optional ByRef ErrMessages As String = "",
                    Optional EncaseFields As Boolean = False, Optional FieldValueDelim As String = ",",
                    Optional ByVal DelimChar As String = "_") As Boolean

        Dim cn As Object
        Dim rs As Object
        Dim cmd As MySqlCommand
        Dim con As MySqlConnection
        Dim myConn As String
        Dim provider As String
        'Dim cmd As oledbcommand
        'Dim da As oledbdataadapter
        Dim strSQL As String
        Dim strDeliveryRef As String
        Dim dtDeliveryDate As Date
        Dim strDeliveryDate As String
        Dim ExcludedFields As String
        Dim FieldTypeArr() As String
        Dim FieldType As String
        Dim ParamInfo As String
        Dim ParamLength As Long
        Dim Dic_FieldTypes As Object
        Dim Dic_ParamInfo As Object
        Dim ParamInfoArr() As String
        Dim FieldIDX As Integer
        Dim ParamArr() As Object
        Dim Param As Object
        Dim ParamKey As String
        Dim ParamName As String
        Dim ParamValue As Object
        Dim FieldLength As Integer
        Dim FieldValue As String
        Dim FieldTypes As String
        Dim ErrMessage As String
        Dim cmdResult As Integer
        Dim myMessage As String
        Dim Fieldname As String
        Dim DontSave As Boolean = False
        Dim myGUID As Guid

        InsertUpdateRecords_Using_Parameters = False

        'myConn = "G:\MIS\Goodsin Timesheet Data\GoodsInTimesheetRecords.accdb"

        If Len(DBTable) > 0 Then
            'strSQL = "INSERT INTO " & DBTable & " (" & Fieldnames & ") "
            'strSQL = strSQL & " VALUES (""" & Fieldvalues & """);"
        Else
            MsgBox("DATABASE TABLE NOT SPECIFIED")
            'cn.Close
            'cn = Nothing
            Exit Function
        End If

        'Set cn = ADODB.Connection
        Dic_ParamInfo = CreateObject("Scripting.Dictionary")
        Dic_ParamInfo.comparemode = vbTextCompare
        Dic_ParamInfo.RemoveAll
        Dic_FieldTypes = CreateObject("Scripting.Dictionary")
        Dic_FieldTypes.comparemode = vbTextCompare
        Dic_FieldTypes.RemoveAll
        'Set TargetRange = ThisWorkbook.Sheets("Prefs").Range("A10")
        con = New MySqlConnection(connString)


        'Set cn = CreateObject("ADODB.Connection")

        ExcludedFields = ExcludeFields

        'Set Dic = CreateObject("Scripting.Dictionary")
        ReDim FieldTypeArr(1)
        ReDim ParamArr(1)
        ErrMessage = ""
        FieldTypes = ""
        Call GetMyFields(DBTable, connString, ErrMessage, "", FieldTypes, 0, Dic_FieldTypes)

        'SHOULD BE FieldTypes() as OBJECT - 03-SEP-2018
        'GETTING AUTHENTICATION ERROR when the above function is run. seems ok now.

        'FieldValueDelim is passed into this procedure - it is semi-colon by default.

        'NO WHERE CLAUSE !

        If UpdateRecords = True Then
            strSQL = PrepareUpdate_With_Parameters(REcordID, connString, DBTable, Fieldnames, FieldValues, Dic_FieldTypes, Dic_ParamInfo,
                                                   UpdateCriteria, ErrMessage, ExcludedFields, False, ",", FieldValueDelim,
                                                    0, False, False, False, DelimChar)
        Else
            strSQL = PrepareInsert_With_Parameters(REcordID, connString, DBTable, Fieldnames, FieldValues, Dic_FieldTypes, Dic_ParamInfo,
                                                   ErrMessage, ExcludedFields, False, ",", FieldValueDelim, 0, False, False,
                                                    False, DelimChar)
        End If
        'strSQL = "UPDATE " & DBTable & " SET [DeliveryDate] = ?"
        'strDeliveryRef = "TEST-DAN-YES"
        'Fieldnames = "DeliveryDate,DeliveryReference"
        'dtDeliveryDate = CDate("21/05/2018")
        'strDeliveryDate = Format(dtDeliveryDate, "dd/MM/yyyy")
        'FieldValues = Chr(34) & strDeliveryDate & Chr(34) & "," & Chr(34) & strDeliveryRef & Chr(34)
        'strSQL = "INSERT INTO " & DBTable & " (" & Fieldnames & ") "
        'strSQL = strSQL & " VALUES (" & FieldValues & ")"
        'MsgBox ("SQL= " & strSQL)
        'cmd.Parameters.Clear
        FieldIDX = 1
        Try
            con.Open()
            cmd = New MySqlCommand(strSQL, con)
            cmd.Connection = con
            cmd.CommandText = strSQL
            cmd.Prepare()
            For Each ParamKey In Dic_ParamInfo
                'ParamKey = "@" & fieldname
                Param = Nothing
                If Len(ParamKey) = 0 Then
                    Continue For
                End If
                'where does dic_fieldtypes come in ?????????????
                ParamName = ParamKey
                ParamInfo = Dic_ParamInfo(ParamKey)
                Fieldname = Mid(ParamKey, 2, Len(ParamKey))
                If InStr(ParamInfo, DelimChar) > 0 Then
                    ParamInfoArr = Split(ParamInfo, DelimChar)
                    ParamLength = Len(ParamInfoArr(2))
                    FieldType = ParamInfoArr(0)
                    ParamValue = ParamInfoArr(2)

                    If IsNumeric(ParamInfoArr(1)) Then
                        FieldLength = CLng(ParamInfoArr(1))
                        If ParamInfoArr(0) = "VARCHAR" Then
                            If FieldLength = 0 Then
                                FieldLength = 1
                            End If
                        End If
                    Else
                        'bugger
                        FieldLength = CInt(ParamLength)
                    End If
                    If Len(ParamInfoArr(2)) > 0 Then
                        'cmd.Parameters.Add("@Baz", SqlDbType.VarChar, 50).Value = Baz
                        'Return cmd.ExecuteScalar().ToString()
                        'End Using
                        If UCase(FieldType) = "VARCHAR" Then
                            cmd.Parameters.Add(ParamName, MySqlDbType.VarChar, FieldLength).Value = ParamValue
                        ElseIf UCase(FieldType) = "INT" Then
                            cmd.Parameters.Add(ParamName, MySqlDbType.Int32, FieldLength).Value = CInt(ParamValue)
                        ElseIf UCase(FieldType) = "BIGINT" Then
                            cmd.Parameters.Add(ParamName, MySqlDbType.UInt64, FieldLength).Value = CDec(ParamValue)
                        ElseIf UCase(FieldType) = "DOUBLE" Then
                            cmd.Parameters.Add(ParamName, MySqlDbType.Double, FieldLength).Value = CDbl(ParamValue)
                        ElseIf UCase(FieldType) = "DATE" Then
                            cmd.Parameters.Add(ParamName, MySqlDbType.Date, FieldLength).Value = CDate(ParamValue)
                        ElseIf UCase(FieldType) = "DATETIME" Then
                            cmd.Parameters.Add(ParamName, MySqlDbType.DateTime, FieldLength).Value = CDate(ParamValue)
                        ElseIf UCase(FieldType) = "TEXT" Then
                            cmd.Parameters.Add(ParamName, MySqlDbType.Text, FieldLength).Value = ParamValue
                        ElseIf UCase(FieldType) = "GUID" Then
                            myGUID = DirectCast(ParamValue, System.Guid)
                            cmd.Parameters.Add(ParamName, MySqlDbType.Guid, FieldLength).Value = myGUID
                        Else
                            myMessage = "Field Type Unknown: " & FieldType
                            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, myMessage, "InsertUpdateRecords_Using_Parameters()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
                            DontSave = True
                            Continue For
                        End If

                    End If
                    'TREAT DATES as STRINGS before Insertion?:
                End If
                FieldIDX = FieldIDX + 1
            Next
            If DontSave = False Then

                cmdResult = cmd.ExecuteNonQuery
            End If
        Catch ex As Exception
            myMessage = "Exception Error in InsertUpdateRecords_Using_Parameters Record: " & ex.ToString
            InsertUpdateRecords_Using_Parameters = False
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, myMessage, "InsertUpdateRecords_Using_Parameters()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function

        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
        Dic_FieldTypes = Nothing
        Dic_ParamInfo = Nothing
        'Set ParamArr = Nothing
        InsertUpdateRecords_Using_Parameters = True


    End Function

    Function PrepareParameters(ByVal REcordID As String, ByRef InsertSQL As String, ByRef UpdateSQL As String, ByRef Dic_ParameterInfo As Object,
    ByVal DBTable As String, ByRef ParamFieldnames As String, ByRef ParamValues As String, dic_FieldTypes As Object,
    ByVal Dic_FieldsAndValues As Object, Optional Encase_Fields As Boolean = False, Optional UpdateCriteria As String = "",
                               Optional ForAccess As Boolean = False,
                               Optional ByVal DelimChar As String = "_") As Long
        'Dim FieldArr() As String
        Dim ValueArr As Object
        Dim Fieldname As String
        Dim fldValue As Object
        Dim ParamKey As String
        Dim ParamItem As String
        Dim TheFieldType As String
        Dim FieldTypesArr() As String
        Dim varKey As String
        Dim fldLength As Long
        Dim ParamFldLength As Long
        Dim DontSave As Boolean
        Dim IncludeComma As Boolean
        Dim IncludeQuotes As Boolean
        Dim IncludeSpaces As Boolean
        Dim IncludeSingleQuote As Boolean
        Dim DeliveryComments As String
        Dim FieldCount As Long
        Dim AllFieldnames As String
        Dim AllFieldTypes As String
        Dim dtDateTime As DateTime

        'THIS FUNCTION ONLY SAVES 1 RECORD.

        PrepareParameters = 0
        If Dic_FieldsAndValues.Count = 0 Then
            Exit Function
        End If
        DontSave = False
        'ReDim FieldArr(1)
        ReDim FieldTypesArr(1)

        fldLength = 0
        TheFieldType = ""
        FieldCount = 0

        DeliveryComments = "ISSUES: "
        ParamFldLength = 0
        ParamFieldnames = ""
        ParamValues = ""

        'Dic_FieldTypes = New Scripting.Dictionary
        Dic_ParameterInfo = CreateObject("Scripting.Dictionary")
        Dic_ParameterInfo.comparemode = vbTextCompare
        'Dic_FieldTypes(fieldname) = FieldType()
        InsertSQL = ""
        UpdateSQL = "UPDATE " & DBTable & " SET "
        For Each varKey In Dic_FieldsAndValues
            FieldCount = FieldCount + 1
            If varKey Is Nothing Or Len(varKey) = 0 Then
                Continue For
            End If
            'VarKey = UCase(VarKey)

            Fieldname = UCase(varKey)
            fldValue = Dic_FieldsAndValues(varKey)
            TheFieldType = dic_FieldTypes(Fieldname)
            DontSave = False 'for EACH field.
            fldLength = Len(fldValue)
            ParamFldLength = 0
            If TheFieldType = "VARCHAR" Then '202
                'SHORT TEXT
                ParamFldLength = Len(fldValue)
                If fldLength > 0 Then
                    If Encase_Fields Then
                        fldValue = Chr(34) & fldValue & Chr(34)
                    End If
                    IncludeComma = True
                    IncludeQuotes = True
                    IncludeSpaces = False
                    fldValue = ConvertBadChars(CStr(fldValue), "", IncludeComma, IncludeQuotes, IncludeSpaces)
                Else
                    'BLANK / EMPTY field value:
                    'dontsave = True ??????????????????????????????? what if user wants to blank out a field ??
                    fldValue = " "
                    ParamFldLength = 1
                    DeliveryComments = DeliveryComments & " Field: " & Fieldname & " =EMPTY,"
                End If
            ElseIf TheFieldType = "INT" Then '3
                'INTEGER or LONG - NUMERIC.
                ParamFldLength = 0
                IncludeComma = True
                IncludeQuotes = True
                IncludeSpaces = True
                If fldLength > 0 Then
                    fldValue = ConvertBadChars(CStr(fldValue), "", IncludeComma, IncludeQuotes, IncludeSpaces)
                    If IsNumeric(fldValue) Then
                        'OK SAVE PARAMETER
                        fldValue = CInt(fldValue)
                    Else
                        'TEXT appears in this numeric field:
                        DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": " & CStr(fldValue) & ","
                        fldValue = 0

                    End If
                Else
                    DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": EMPTY,"
                    fldValue = 0
                End If
            ElseIf TheFieldType = "BIGINT" Then
                'BIGINT TYPE
                ParamFldLength = 0
                IncludeComma = True
                IncludeQuotes = True
                IncludeSpaces = True
                If fldLength > 0 Then
                    fldValue = ConvertBadChars(CStr(fldValue), "", IncludeComma, IncludeQuotes, IncludeSpaces)
                    If IsNumeric(fldValue) Then
                        'OK SAVE PARAMETER
                        fldValue = CDec(fldValue) 'maybe need to convert to DECIMAL TYPE here ?
                    Else
                        'TEXT appears in this numeric field:
                        DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": " & CStr(fldValue) & ","
                        fldValue = 0

                    End If
                Else
                    DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": EMPTY,"
                    fldValue = 0
                End If
            ElseIf TheFieldType = "DOUBLE" Then '5
                'DOUBLE - will have PRECISION and NUMBER of DECIMAL PLACES
                ParamFldLength = 0
                IncludeComma = True
                IncludeQuotes = True
                IncludeSpaces = True
                If fldLength > 0 Then
                    fldValue = ConvertBadChars(CStr(fldValue), "", IncludeComma, IncludeQuotes, IncludeSpaces)
                    If IsNumeric(fldValue) Then
                        'OK SAVE PARAMETER
                        fldValue = CDbl(fldValue)
                    Else
                        'TEXT appears in this numeric field:
                        DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": " & CStr(fldValue) & ","
                        fldValue = 0

                    End If
                Else
                    DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": EMPTY,"
                    fldValue = 0 'Could put 0.00f instead ????
                End If

                'Convert fldValue (OBJECT TYPE) to CURRENCY TYPE
            ElseIf TheFieldType = "CURRENCY" Then '6
                'CURRENCY
                ParamFldLength = 0
                IncludeComma = True
                IncludeQuotes = True
                IncludeSpaces = True
                If fldLength > 0 Then
                    fldValue = ConvertBadChars(CStr(fldValue), "", IncludeComma, IncludeQuotes, IncludeSpaces)
                    If IsNumeric(fldValue) Then
                        'OK SAVE PARAMETER
                        fldValue = CDbl(fldValue)
                    Else
                        'TEXT appears in this numeric field:
                        DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": " & CStr(fldValue) & ","
                        fldValue = 0

                    End If
                Else
                    DeliveryComments = DeliveryComments & " Field: " & Fieldname & ": EMPTY,"
                    fldValue = 0 'Could put 0.00f instead ????
                End If

            ElseIf TheFieldType = "DATETIME" Then '7
                'DATEs
                ParamFldLength = 0
                IncludeComma = True
                IncludeQuotes = False
                IncludeSpaces = False
                IncludeSingleQuote = False
                If fldLength < 8 Then
                    fldValue = "01/01/1970"
                    DeliveryComments = DeliveryComments & " Field:" & Fieldname & " Invalid Date,"
                Else
                    fldValue = ConvertBadChars(CStr(fldValue), "", IncludeComma, IncludeQuotes, IncludeSpaces, IncludeSingleQuote)
                    If IsDate(fldValue) Then
                        dtDateTime = CDate(fldValue)
                        fldValue = dtDateTime
                    Else
                        DeliveryComments = DeliveryComments & " Field:" & Fieldname & " Invalid Date,"
                    End If
                End If

            ElseIf TheFieldType = "" Then
                'Field Type is Unrecognised or some error here ? = 0
                ParamFldLength = 0
                IncludeComma = True
                IncludeQuotes = True
                IncludeSpaces = True
                If fldLength < 2 Then
                    DontSave = True
                Else
                    DontSave = True
                End If
                DeliveryComments = DeliveryComments & " Field:" & Fieldname & ": Type0= " & fldValue
            Else
                'UNKNOWN FIELD TYPE:
                ParamFldLength = 0
                IncludeComma = True
                IncludeQuotes = True
                IncludeSpaces = True
                If fldLength < 2 Then
                    DontSave = True
                Else
                    DontSave = True
                End If
                DeliveryComments = DeliveryComments & " Field:" & Fieldname & ": Unknown Type= " & fldValue

            End If


            If DontSave = False Then
                'Create Parameter for this field:
                ParamKey = "@" & Fieldname
                If FieldCount < 2 Then
                    ParamFieldnames = Fieldname
                    ParamValues = ParamKey
                    If ForAccess Then
                        UpdateSQL = UpdateSQL & "[" & Fieldname & "]" & " = " & ParamKey
                    Else
                        UpdateSQL = UpdateSQL & Fieldname & " = " & ParamKey
                    End If
                Else
                    ParamFieldnames = ParamFieldnames & "," & Fieldname
                    ParamValues = ParamValues & "," & ParamKey
                    If ForAccess Then
                        UpdateSQL = UpdateSQL & ",[" & Fieldname & "]" & " = " & ParamKey
                    Else
                        UpdateSQL = UpdateSQL & "," & Fieldname & " = " & ParamKey
                    End If
                End If
                ParamItem = TheFieldType & DelimChar & CStr(ParamFldLength) & DelimChar & fldValue & DelimChar & DeliveryComments
                If Not Dic_ParameterInfo.Exists(ParamKey) Then
                    Dic_ParameterInfo(ParamKey) = ParamItem
                End If

            Else
                'DONT CREATE PARAMETER - INVALID value:
                'BUT still save / update the DeliveryComments:
                DeliveryComments = DeliveryComments & " Field:" & Fieldname & ": Not Saved= " & fldValue
            End If
        Next
        If Len(REcordID) > 0 Then
            If CLng(REcordID) > 0 Then
                UpdateSQL = UpdateSQL & " WHERE ID = " & CLng(REcordID)
            End If
        Else
            If Len(UpdateCriteria) > 0 Then
                UpdateSQL = UpdateSQL & " WHERE " & UpdateCriteria
            End If
        End If
        InsertSQL = "INSERT INTO " & DBTable & " (" & ParamFieldnames & ")" & " VALUES " & "(" & ParamValues & ")"
        PrepareParameters = Dic_ParameterInfo.Count


    End Function

    Function PrepareUpdate_With_Parameters(ByRef REcordID As String, ByVal ConnString As String, ByVal DBTable As String, ByRef Fieldnames As String,
                                           ByVal FieldValues As String, ByRef dic_FieldTypes As Object, ByRef Dic_ParameterInfo As Object, ByVal UpdateCriteria As String,
                                           Optional ErrMessage As String = "",
                                           Optional ByRef ExcludeFields As String = "", Optional Encase_Fields As Boolean = False,
                                           Optional FieldDelim As String = ",", Optional ValueDelim As String = ";",
                                           Optional TypeStartIDX As Long = 0,
                                           Optional RemoveBadChars As Boolean = False,
                                           Optional IncludeCommaInBadChars As Boolean = False,
                                           Optional IncludeSpeechMarksInBadChars As Boolean = False,
                                           Optional REplaceWith As String = "_") As String
        'PrepareUpdate_With_Parameters(DBPath, DBTable, Fieldnames, FieldValues, Dic_ParamInfo, UpdateCriteria, ExcludedFields, False, FieldValueDelim, FieldValueDelim)
        Dim FieldNameArray() As String
        Dim IgnoreFieldsArray() As String
        Dim ValueArray() As String
        Dim FinalCMD As String
        Dim IDX As Integer
        Dim fldName As String
        Dim fldValue As String
        Dim NumFields As Integer
        Dim UpdateCmd As String
        Dim IncludeComma As Boolean
        Dim Operation As String
        Dim ParamKey As String
        Dim ParamItem As Object
        Dim FieldType As Integer
        Dim FieldTypes As String
        Dim FieldTypesArr() As String
        Dim varKey As String
        Dim Dic_FieldsAndValues As Object
        Dim InsertSQL As String
        Dim UpdateSQL As String
        Dim ParamFieldnames As String
        Dim ParamValues As String
        Dim TotalParameters As Long
        Dim AllFieldnames As String

        FinalCMD = ""
        ReDim FieldNameArray(1)
        ReDim IgnoreFieldsArray(1)
        ReDim ValueArray(1)

        Dic_ParameterInfo = CreateObject("Scripting.Dictionary")
        Dic_ParameterInfo.RemoveAll
        Dic_ParameterInfo.CompareMode = vbTextCompare
        Dic_FieldsAndValues = CreateObject("Scripting.Dictionary")
        Dic_FieldsAndValues.RemoveAll
        Dic_FieldsAndValues.CompareMode = vbTextCompare

        FieldTypes = ""
        AllFieldnames = GetMyFields(DBTable, ConnString, ErrMessage, ExcludeFields, FieldTypes, TypeStartIDX)
        FieldTypesArr = strToStringArray(FieldTypes, ",", TypeStartIDX, Encase_Fields, RemoveBadChars, IncludeCommaInBadChars, REplaceWith, IncludeSpeechMarksInBadChars)


        PrepareUpdate_With_Parameters = ""
        If Len(ExcludeFields) > 0 Then
            IgnoreFieldsArray = strToStringArray(ExcludeFields, ",")
        End If
        If Len(DBTable) = 0 Then
            MsgBox("Error in PrepareUpdate_With_Parameters: No Database Table specified")
            PrepareUpdate_With_Parameters = ""
            Exit Function
        End If
        If Len(Fieldnames) = 0 Then
            'NumFields = GetNumFields(connString, "SELECT * FROM " & TableName, DBName, Fieldnames)
            Fieldnames = AllFieldnames
        End If

        FieldNameArray = strToStringArray(Fieldnames, FieldDelim, 0, False, True, False, "_", False)
        If Len(FieldValues) > 0 Then
            ValueArray = strToStringArray(FieldValues, ValueDelim, 0, False, True, IncludeComma, REplaceWith, IncludeSpeechMarksInBadChars)
        Else
            MsgBox("Error in PrepareUpdate_With_Parameters: No values specified")
            PrepareUpdate_With_Parameters = ""
            Exit Function
        End If
        'BUT check that the values are removed too if they corresponded with those fields removed ????
        Fieldnames = RemoveExtractedFields(FieldNameArray, IgnoreFieldsArray, ",", FieldNameArray, 0, 0) 'rebuilds whole list without the extracted fields

        If UBound(FieldNameArray) > 0 And UBound(ValueArray) > 0 Then
            If UBound(FieldNameArray) < UBound(ValueArray) Then
                MsgBox("Error in PrepareUpdate_With_Parameters: Number of Fields Passed are LESS than Number of VALUES passed.")
                PrepareUpdate_With_Parameters = ""
                Exit Function
            End If
            If UBound(FieldNameArray) > UBound(ValueArray) Then
                MsgBox("Error in PrepareUpdate_With_Parameters: Number of Fields Passed are GREATER than Number of VALUES passed.")
                PrepareUpdate_With_Parameters = ""
                Exit Function
            End If
        End If
        'Prepare and insert parameter INFO for the script dictionary


        'IDX = 1
        'UpdateCmd = "UPDATE " & DBTable & " SET "

        Dic_FieldsAndValues.RemoveAll
        For IDX = 0 To UBound(FieldNameArray)
            fldName = UCase(FieldNameArray(IDX))

            If Not Dic_FieldsAndValues.Exists(fldName) Then
                Dic_FieldsAndValues(fldName) = ValueArray(IDX)
            End If
        Next
        'Prepare and insert parameter INFO for the script dictionary
        'Problem could be here:
        TotalParameters = PrepareParameters(REcordID, InsertSQL, UpdateSQL, Dic_ParameterInfo, DBTable, ParamFieldnames,
                                            ParamValues, dic_FieldTypes, Dic_FieldsAndValues, False, UpdateCriteria,
                                            False, REplaceWith)

        FinalCMD = UpdateSQL

        If Len(UpdateCriteria) > 0 And InStr(UCase(UpdateSQL), "WHERE") = 0 Then
            FinalCMD = FinalCMD & " WHERE " & UpdateCriteria
        End If

        PrepareUpdate_With_Parameters = FinalCMD


    End Function

    Function UpdateTableWithImage(connString As String,
                                  strDBTable As String,
                                  strIDField As String,
                                  strIDValue As String,
                                  strImageField As String,
                                  memstream As IO.MemoryStream,
                                  ArrImage() As Byte,
                                  Optional ImageSizeField As String = "",
                                  Optional ImageByteLimit As Long = 10000000,
                                  Optional ByRef ErrMessage As String = "") As Boolean
        Dim tempStream As New System.IO.MemoryStream()
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim strSQL As String
        Dim Result As Integer
        Dim ImageSize As Long
        Dim IDValue As Integer

        UpdateTableWithImage = False
        tempStream = memstream
        ImageSize = tempStream.Length
        If ImageSize > ImageByteLimit Then
            MsgBox("File Size is too large")
            UpdateTableWithImage = False
            Exit Function
        End If
        If Len(strIDValue) > 0 And IsNumeric(strIDValue) Then
            IDValue = CInt(strIDValue)
        Else
            MsgBox("ID VAlue passed is NOT ok")
            Exit Function
        End If
        con = New MySqlConnection(connString)
        cmd = New MySqlCommand
        Try
            con.Open()
            strSQL = "UPDATE " & strDBTable & " SET " & strImageField & "= @image"
            If Len(ImageSizeField) > 0 Then
                strSQL += "," & ImageSizeField & "= @imagesize"
                cmd.Parameters.AddWithValue("@imagesize", ImageSize)
            End If
            strSQL += " WHERE " & strIDField & "=" & IDValue
            With cmd
                .Connection = con
                .CommandText = strSQL
                .Parameters.AddWithValue("@image", ArrImage)
                Result = .ExecuteNonQuery()
            End With
            If Result > 0 Then
                UpdateTableWithImage = True
            Else
                UpdateTableWithImage = False
                ErrMessage = "UPDATE IMAGE FAILED"
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("Error during Update Image: " & ex.Message)
            UpdateTableWithImage = False
        End Try
    End Function

    Sub SaveRTFControl_varBinary(connString As String, RTFControl As RichTextBox, ByRef RTFByte As Byte, RecID As Integer)
        Dim strSQL As String
        Dim con As MySqlConnection

        con = New MySqlConnection(connString)
        Try
            con.Open()
            strSQL = "UPDATE tblLog SET RTFComment1 = @RTF WHERE LogID=" & RecID
            Dim cmd As MySqlCommand = New MySqlCommand(strSQL, con)
            cmd.Parameters.Add(New MySqlParameter("@RTF", MySqlDbType.VarBinary)).Value = System.Text.Encoding.ASCII.GetBytes(RTFControl.Rtf)
            'pbWaypointPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)

            RTFByte = Convert.ToByte(cmd.ExecuteScalar)
            MsgBox("SAVED OK")
        Catch ex As Exception
            MsgBox("Error: NOT SAVED")
        End Try
    End Sub

    Sub SaveRTFControl_memStream(connString As String, DBTable As String, IDField As String, IDValue As String, RTBField As String,
                                 RTFControl As RichTextBox)
        Dim strSQL As String
        Dim con As MySqlConnection
        Dim ms As New IO.MemoryStream
        Dim arrImage As Byte()

        con = New MySqlConnection(connString)
        Try
            'con.Open()
            'strSQL = "UPDATE tblLog SET RTFComment2 = @RTF WHERE LogID=" & RecID
            'Dim cmd As MySqlCommand = New MySqlCommand(strSQL, con)

            RTFControl.SaveFile(ms, RichTextBoxStreamType.RichText)
            arrImage = ms.GetBuffer()

            'cmd.Parameters.Add(New MySqlParameter("@RTF", MySqlDbType.VarBinary)).Value = System.Text.Encoding.ASCII.GetBytes(RTFControl.Rtf)
            'pbWaypointPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            'RTFControl.SaveFile(ms, RichTextBoxStreamType.RichText)

            'RTFByte = Convert.ToByte(cmd.ExecuteScalar)
            If UpdateTableWithImage(connString, DBTable, IDField, IDValue, RTBField, ms, arrImage, "ImageSize") Then
                'MsgBox(RTBField & " SAVED OK")
            Else
                MsgBox(RTBField & " Not Saved OK")
            End If
        Catch ex As Exception
            MsgBox("Error: NOT SAVED")
        End Try
    End Sub

    Sub LoadRTFControl_memStream(connString As String,
                                 DBTable As String,
                                 RTFDBField As String,
                                 IDDBField As String,
                                 RecIDValue As String,
                                 ByRef RTFControl As RichTextBox,
                                 ByRef strRTFChars As String)
        Dim ms As New IO.MemoryStream
        Dim arrImage As Byte()
        Dim LoadOK As Boolean

        strRTFChars = ""
        LoadOK = Get_Pic_From_DB(frmMain.myConnString, DBTable, RTFDBField, IDDBField, RecIDValue, arrImage)
        If LoadOK And arrImage IsNot Nothing Then
            ms = New IO.MemoryStream(arrImage)

            RTFControl.LoadFile(ms, RichTextBoxStreamType.RichText)
            strRTFChars = RTFControl.Rtf
        End If

    End Sub

    Function LoadRTFControl(connString As String, ByRef RTFControl As RichTextBox, ByRef RTFByte As String, RecID As Integer) As Boolean
        Dim strSQL As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim RTFBytes As Byte()
        Dim Extract As String
        Dim ms As New System.IO.MemoryStream

        LoadRTFControl = False
        con = New MySqlConnection(connString)
        cmd = New MySqlCommand
        Try
            con.Open()
            strSQL = "SELECT * FROM tblLog WHERE LogID=" & RecID
            With cmd
                .Connection = con
                .CommandText = strSQL
            End With
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            ms.Seek(0, IO.SeekOrigin.Begin)
            'RTFControl.LoadDocument(ms, DocumentFormat.Rtf)
            'ms.Close()
            Extract = Convert.ToBase64String(dt(0)("RTFComment1"))
            'Extract = dt(0)(23)
        Catch ex As Exception
            MsgBox("Error: NOT RETRIEVED")
            LoadRTFControl = False
            Exit Function
        End Try
        RTFControl.Rtf = RTFByte
    End Function

    Function GetLastID(connString As String, DBTable As String, IDField As String) As String
        Dim strSQL As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim Result As Integer
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim LastID As String

        GetLastID = ""
        LastID = ""
        con = New MySqlConnection(connString)
        cmd = New MySqlCommand
        Try
            con.Open()
            strSQL = "SELECT MAX(" & IDField & ") FROM " & DBTable
            With cmd
                .Connection = con
                .CommandText = strSQL
            End With
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 And Not IsDBNull(dt(0)(0)) Then
                LastID = dt(0)(0)

            End If
            GetLastID = LastID
        Catch ex As Exception
            MsgBox("Error during fetch MAX ID: " & ex.Message)
            GetLastID = ""
        End Try
    End Function

    Function Get_Pic_From_DB(connString As String, DBTable As String, ImageField As String, IDField As String, strIDValue As String, ByRef arrImage() As Byte) As Boolean
        Dim strSQL As String
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim Result As Integer
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable

        Get_Pic_From_DB = False
        con = New MySqlConnection(connString)
        cmd = New MySqlCommand
        If Len(IDField) = 0 Then
            MsgBox("ID FIELD is BLANK")
            Get_Pic_From_DB = False
            Exit Function
        End If
        If Len(strIDValue) = 0 Then
            MsgBox("ID VALUE is BLANK")
            Get_Pic_From_DB = False
            Exit Function
        End If
        If Not IsNumeric(strIDValue) Then
            MsgBox("ID Value is not numeric")
            Get_Pic_From_DB = False
            Exit Function
        End If
        Try
            con.Open()
            strSQL = "SELECT " & ImageField & " FROM " & DBTable & " WHERE " & IDField & "=" & CInt(strIDValue)
            With cmd
                .Connection = con
                .CommandText = strSQL
            End With
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            If dt.Rows.Count > 0 And Not IsDBNull(dt(0)(ImageField)) Then
                arrImage = dt(0)(ImageField)
            Else
                'MsgBox("Problem with Image load")
                Get_Pic_From_DB = False
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("Error during fetch picture: " & ex.Message)
            Get_Pic_From_DB = False
        End Try
        Get_Pic_From_DB = True
    End Function

    Function PrepareInsert_With_Parameters(ByVal REcordID As String, ByVal connString As String, ByVal DBTable As String, ByRef Fieldnames As String,
                                           ByVal FieldValues As String, dic_FieldTypes As Object, ByRef Dic_ParameterInfo As Object,
                                           Optional ErrMessage As String = "",
                                           Optional ByRef ExcludeFields As String = "",
                                           Optional Encase_Fields As Boolean = False,
                                           Optional FieldDelim As String = ",",
                                           Optional ValueDelim As String = ",",
                                           Optional TypeStartIDX As Long = 0,
                                           Optional RemoveBadChars As Boolean = False,
                                           Optional IncludeCommaInBadChars As Boolean = False,
                                           Optional IncludeSpeechMarksInBadChars As Boolean = False,
                                           Optional REplaceWith As String = "_") As String
        'PrepareInsert_With_Parameters(DBPath, DBTable, Fieldnames, FieldValues, Dic_ParamInfo, ExcludedFields, False, FieldValueDelim, FieldValueDelim)
        Dim FieldNameArray() As String
        Dim IgnoreFieldsArray() As String
        Dim ValueArray() As String
        Dim FinalCMD As String
        Dim IDX As Integer
        Dim fldName As String
        Dim fldValue As String
        Dim fldValues As String
        Dim NumFields As Integer
        Dim UpdateCmd As String
        Dim IncludeComma As Boolean
        Dim Operation As String
        Dim ParamKey As String
        Dim ParamItem As String
        Dim FieldType As Integer
        Dim FieldTypes As String
        Dim FieldTypesArr() As String
        Dim varKey As String
        Dim fldLength As Long
        Dim TotalParameters As Long
        Dim InsertSQL As String
        Dim UpdateSQL As String
        Dim ParamFieldnames As String
        Dim ParamValues As String
        Dim Dic_FieldsAndValues As Object
        Dim AllFieldnames As String


        FinalCMD = ""
        fldValues = ""
        ReDim FieldNameArray(1)
        ReDim IgnoreFieldsArray(1)
        ReDim ValueArray(1)

        Dic_ParameterInfo = CreateObject("Scripting.Dictionary")
        Dic_ParameterInfo.CompareMode = vbTextCompare
        Dic_FieldsAndValues = New Scripting.Dictionary
        Dic_FieldsAndValues.RemoveAll
        Dic_FieldsAndValues.CompareMode = vbTextCompare
        'Dic_ParameterInfo.RemoveAll

        FieldTypes = ""
        AllFieldnames = GetMyFields(DBTable, connString, ErrMessage, ExcludeFields, FieldTypes, TypeStartIDX, Nothing, Fieldnames)
        FieldTypesArr = strToStringArray(FieldTypes, ",", TypeStartIDX, Encase_Fields, RemoveBadChars, IncludeCommaInBadChars, REplaceWith, IncludeSpeechMarksInBadChars)

        PrepareInsert_With_Parameters = ""

        If Len(ExcludeFields) > 0 Then
            IgnoreFieldsArray = strToStringArray(ExcludeFields, FieldDelim, 0, False, True, False, REplaceWith, False)
        End If
        If Len(DBTable) = 0 Then
            MsgBox("Error in PrepareInsert_With_Parameters: No Database Table specified")
            PrepareInsert_With_Parameters = ""
            Exit Function
        End If

        If Len(Fieldnames) = 0 Then
            Fieldnames = AllFieldnames
        End If
        'SO what if Dic_ParameterInfo.count > 0 then ????????????
        'This means that its been passed back in - after evaluation from the parameters section - before the EXECUTE SQL.
        ' - means that number of fields do not match number of parameter @ values passed.
        ' so we need to resolve this. maybe instead of @P1 .... we need to use the actual fieldname - @DeliveryDate etc.
        ' This way we can remove the @ symbol and know which fields have been passed and which ARE MISSING !
        If Dic_ParameterInfo.Count > 0 Then
            'OK so we can get all of the fields from the table to start with.
            'Then we need to eliminate the fields that are NOT in the Dictionary:
            ' - this will form the fields that are left to put into the final SQL query.

        End If
        '
        'FieldNameArray = strToStringArray(Fieldnames, FieldDelim, 0, False, True) 'EACH fieldname passed must have square brackets around it.
        FieldNameArray = strToStringArray(Fieldnames, FieldDelim, 0, False, True, False, "_", False)
        If Len(FieldValues) > 0 Then
            ValueArray = strToStringArray(FieldValues, ValueDelim, 0, False, True, IncludeComma, REplaceWith, IncludeSpeechMarksInBadChars)
        Else
            MsgBox("Error in PrepareInsert_With_Parameters: No values specified")
            PrepareInsert_With_Parameters = ""
            Exit Function
        End If
        Fieldnames = RemoveExtractedFields(FieldNameArray, IgnoreFieldsArray, FieldDelim, FieldNameArray, 0, 0)
        If UBound(FieldNameArray) > 0 And UBound(ValueArray) > 0 Then
            If UBound(FieldNameArray) < UBound(ValueArray) Then
                MsgBox("Error in PrepareInsert_With_Parameters: Number of Fields Passed are LESS than Number of VALUES passed.")
                PrepareInsert_With_Parameters = ""
                Exit Function
            End If
            If UBound(FieldNameArray) > UBound(ValueArray) Then
                MsgBox("Error in PrepareInsert_With_Parameters: Number of Fields Passed are GREATER than Number of VALUES passed.")
                PrepareInsert_With_Parameters = ""
                Exit Function
            End If
        End If
        Dic_FieldsAndValues.RemoveAll
        For IDX = 0 To UBound(FieldNameArray)
            fldName = UCase(FieldNameArray(IDX))
            If Not Dic_FieldsAndValues.Exists(fldName) Then
                Dic_FieldsAndValues(fldName) = ValueArray(IDX)
            End If
        Next
        'Prepare and insert parameter INFO for the script dictionary

        TotalParameters = PrepareParameters(REcordID, InsertSQL, UpdateSQL, Dic_ParameterInfo, DBTable, ParamFieldnames,
                                            ParamValues, dic_FieldTypes, Dic_FieldsAndValues, False, "", False, REplaceWith)

        FinalCMD = InsertSQL
        PrepareInsert_With_Parameters = FinalCMD

    End Function

    Function DeleteMyRecord(ByVal DBTable As String, ByVal connString As String, ByVal Criteria As String, ByRef MyMessage As String) As Boolean
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim DataSource As String
        Dim strSQL As String
        Dim ExcludedFields As String
        Dim NumRows As Integer
        Dim NumFields As Integer
        Dim NumBlankFields As Integer
        Dim EqualPos As Integer

        NumBlankFields = 0
        NumFields = 0
        NumRows = 0
        strSQL = ""
        DataSource = ""
        'connString = ""
        ExcludedFields = ""
        DeleteMyRecord = False
        If Len(DBTable) = 0 Then
            MyMessage = "Error in Delete Record: Database Table not provided"
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "DeleteMyRecord()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            DeleteMyRecord = False
            Exit Function
        End If
        strSQL = "DELETE FROM " & DBTable

        EqualPos = InStr(Criteria, "=")
        If Len(Criteria) > 0 And EqualPos > 0 Then
            If EqualPos < Len(Criteria) Then
                strSQL = strSQL & " WHERE " & Criteria
            End If
        End If
        Try
            con = New MySqlConnection(connString)
            cmd = New MySqlCommand(strSQL, con)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MyMessage = "Exception Error in DeleteMyRecord: " & ex.Message.ToString
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "DeleteMyRecord()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            Exit Function
        End Try
        DeleteMyRecord = True 'needs a test to make sure the record HAS been Deleted. Use the OleDbDataReader.RecordsAffected property

    End Function

    Function Check_myLoggedIN(Optional ByRef Message As String = "") As Boolean
        Dim Processed As Boolean = False

        If mylogged_in = True Then
            Processed = True
            Message = "Successfully Logged In"
        Else
            Message = "Cannot show form until successfully logged in."
        End If


        Check_myLoggedIN = Processed
    End Function

    Function saveSession(ByVal connString As String, ByVal UserID As String, ByVal Username As String,
                            ByVal ComputerName As String, ByVal IPv4Addr As String, ByVal IPv6Addr As String,
                            ByVal SessionID As String, ByVal AccessRights As String, ByRef MyMessage As String,
                            ByVal EmpNo As String, ByVal Firstname As String, ByVal Lastname As String,
                            ByVal Comments As String, ByVal Location As String, ByVal WorkstationName As String,
                            ByVal ProgramVersion As String,
                            Optional ByRef MyOpsMessage As String = "") As Boolean
        Dim SessionUpdatedOK As Boolean = False
        Dim IsOpsUpdatedOK As Boolean = False
        Dim IsOpsOnlineUpdatedOK As Boolean = False
        Dim ConnMessage As String = ""
        Dim DBTable As String = ""
        Dim FieldValues As String = ""
        Dim OpsOnlineFieldValues As String = ""
        Dim FieldNames As String = ""
        Dim OpsOnlineFieldNames As String = ""
        Dim ExcludeFields As String = ""
        Dim OpsOnlineExcludeFields As String = ""
        Dim Criteria As String = ""
        Dim OpsOnlineCriteria As String = ""
        Dim strComputerName As String = ""
        Dim strIP4Addr As String = ""
        Dim strIP6Addr As String = ""
        Dim strGUID As String = ""
        Dim strSessionID As String = ""
        Dim strAccessRights As String = ""
        Dim strUsername As String = ""
        Dim strDateLoggedIn As String = ""
        Dim strDateLoggedOut As String = ""
        Dim strUserID As String = ""
        Dim strIsLoggedIn As String = ""
        Dim strLoggedInDuration As String = ""
        Dim dtMinutesDiff As Long = 0
        Dim dtDateLoggedIn As DateTime
        Dim dtDateLoggedOut As DateTime
        Dim strHours As String = ""
        Dim strMins As String = ""
        Dim OnlineTable As String = ""
        Dim strEmpNo As String = ""
        Dim strFirstname As String = ""
        Dim strLastname As String = ""
        Dim strComments As String = ""
        Dim strLocation As String = ""
        Dim strWorkstationName As String = ""
        Dim strProgramVersion As String

        saveSession = False
        DBTable = "tblSessions"
        OnlineTable = "tblOperatorsOnline"
        strUserID = UserID
        'Need to get the Login Username INDEX from login global var - not the value from the table.
        strUsername = Username
        strEmpNo = EmpNo
        strFirstname = Firstname
        strLastname = Lastname
        strComments = Comments
        strLocation = Location
        strComputerName = ComputerName
        strWorkstationName = WorkstationName
        strIP4Addr = IPv4Addr
        strIP6Addr = IPv6Addr
        strSessionID = SessionID
        strAccessRights = AccessRights
        strIsLoggedIn = "YES"
        strDateLoggedIn = Now().ToString("yyyy-MM-dd HH:mm:ss")
        strDateLoggedOut = "1970-01-01 01:00:00"
        strProgramVersion = ProgramVersion
        'dtDateLoggedIn = CDate(strDateLoggedIn)
        'dtDateLoggedOut = CDate(strDateLoggedOut)
        'dtMinutesDiff = DateDiff(DateInterval.Minute, dtDateLoggedIn, dtDateLoggedOut)
        'strHours = CStr(Math.Abs(dtMinutesDiff) / 60)
        'strMins = CStr(Math.Abs(dtMinutesDiff) Mod 60)

        strLoggedInDuration = strHours & " Hours " & strMins & " Mins"
        FieldNames = "ID,UserID,Username,ComputerName,IPv4Addr,IPv6Addr,SessionID,AccessRights,LogInDateTime,LogOffDateTime,IsLoggedIn"
        FieldNames = FieldNames & ",LoggedInDuration,ProgramVersion"
        ExcludeFields = "ID"
        FieldValues = strUserID
        FieldValues = FieldValues & "," & strUsername
        FieldValues = FieldValues & "," & strComputerName
        FieldValues = FieldValues & "," & strIP4Addr
        FieldValues = FieldValues & "," & strIP6Addr
        FieldValues = FieldValues & "," & strSessionID
        FieldValues = FieldValues & "," & strAccessRights
        FieldValues = FieldValues & "," & strDateLoggedIn
        FieldValues = FieldValues & "," & strDateLoggedOut
        FieldValues = FieldValues & "," & strIsLoggedIn
        FieldValues = FieldValues & "," & strLoggedInDuration
        FieldValues = FieldValues & "," & strProgramVersion

        SessionUpdatedOK = InsertUpdateRecords_Using_Parameters(connString, False, "", DBTable, FieldNames, FieldValues, Criteria,
                                                                ExcludeFields)
        'SessionUpdatedOK = InsertUpdateMyRecord(False, connString, DBTable, FieldNames, FieldValues, MyMessage, Criteria, ExcludeFields)
        If Not SessionUpdatedOK Then
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "saveSession()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End If
        saveSession = SessionUpdatedOK

    End Function

    Sub UpdateMySession(ByVal connString As String, ByVal UserID As String, ByVal Username As String,
                    ByVal ComputerName As String, ByVal IPv4Addr As String, ByVal IPv6Addr As String,
                    ByVal SessionID As String, ByVal AccessRights As String, ByVal LogOutDate As String,
                    ByVal IsLoggedIn As String, ByVal LoggedInDuration As String, ByVal Criteria As String, ByRef MyMessage As String,
                      Optional ByRef MyOpsMessage As String = "")


        Dim ConnMessage As String = ""
        Dim DBTable As String = ""
        Dim FieldValues As String = ""
        Dim FieldNames As String = ""
        Dim ExcludeFields As String = ""
        Dim strComputerName As String = ""
        Dim strIP4Addr As String = ""
        Dim strIP6Addr As String = ""
        Dim strGUID As String = ""
        Dim strSessionID As String = ""
        Dim strAccessRights As String = ""
        Dim strUsername As String = ""
        Dim strDateLoggedIn As String = ""
        Dim strDateLoggedOut As String = ""
        Dim strUserID As String = ""
        Dim strIsLoggedIn As String = ""
        Dim strLoggedInDuration As String = ""
        Dim OpsDBTable As String = ""
        Dim OpsFieldnames As String = ""
        Dim OpsExcludeFields As String = ""
        Dim OpsFieldValues As String = ""
        Dim OpsCriteria As String = ""
        Dim dtMinutesDiff As Long = 0
        Dim dtDateLoggedIn As DateTime
        Dim dtDateLoggedOut As DateTime
        Dim strHours As String = ""
        Dim strMins As String = ""
        Dim SearchField As String = ""
        Dim SearchText As String = ""
        Dim ReturnField As String = ""
        Dim ReturnValue As String = ""
        Dim OpSearchCriteria As String = ""
        Dim OpMessage As String = ""
        Dim OnlineTable As String = ""
        Dim strConnectionString As String = ""
        Dim OpDeleteCriteria As String = ""
        Dim IsUpdatedOK As Boolean = False
        Dim IsOpsUpdatedOK As Boolean = False
        Dim FoundSessionID As Boolean = False
        Dim DeletedOK As Boolean = False
        Dim AllFieldNames As String() = Nothing
        Dim AllFieldValues As Object() = Nothing
        Dim DecMinutes As Decimal = 0.0
        Dim DecHours As Decimal = 0.0
        Dim dblTotalTime As Double
        Dim intHours As Integer
        Dim SPAN As TimeSpan

        DBTable = "tblSessions"
        OpsDBTable = "tblOperators"
        OnlineTable = "tblOperatorsOnline"
        strUserID = UserID
        strUsername = Username
        strComputerName = ComputerName
        strIP4Addr = IPv4Addr
        strIP6Addr = IPv6Addr
        strSessionID = SessionID
        strAccessRights = AccessRights
        strIsLoggedIn = IsLoggedIn
        strDateLoggedOut = LogOutDate

        OpDeleteCriteria = "SessionID = " & Chr(39) & strSessionID & Chr(39)
        If Len(connString) > 0 Then
            strConnectionString = connString
        Else
            MsgBox("No Connection String specified")
            Exit Sub
        End If
        strHours = "0"
        strMins = "0"
        strLoggedInDuration = "0 mins"
        strDateLoggedOut = CStr(Now())
        SearchField = "SessionID"
        SearchText = strSessionID
        ReturnField = "LogInDateTime"
        'Find logindate from tblSessions
        FoundSessionID = Find_myQuery(strConnectionString, DBTable, SearchField, SearchText, "STRING", "", ReturnField, ReturnValue, AllFieldValues, AllFieldNames, OpSearchCriteria, "", False, OpMessage)
        If Len(OpMessage) > 0 Then
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "saveSession()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End If
        If FoundSessionID Then
            strDateLoggedIn = ReturnValue
            dtDateLoggedIn = CDate(strDateLoggedIn)
            dtDateLoggedOut = CDate(strDateLoggedOut)
            SPAN = dtDateLoggedOut.Subtract(dtDateLoggedIn)
            dtMinutesDiff = DateDiff(DateInterval.Minute, dtDateLoggedIn, dtDateLoggedOut)
            DecHours = Math.Abs(dtMinutesDiff) / 60
            DecMinutes = Math.Abs(dtMinutesDiff) Mod 60
            If DecHours < 1 Then
                strHours = "0"
            Else
                Dim theRounded = Math.Sign(DecHours) * Math.Floor(Math.Abs(DecHours) * 100) / 100.0
                intHours = CInt(theRounded)
                strHours = CStr(intHours)
                'hmmm hours still ending up as 1.34 and 5.6 etc.
            End If
            strMins = CStr(DecMinutes)

            strLoggedInDuration = SPAN.Hours & "h " & SPAN.Minutes & "m " & SPAN.Seconds & "s "

        End If

        'OpsCriteria = "Username = " & Chr(39) & strUsername & Chr(39)
        OpsCriteria = "SessionID = " & Chr(39) & strSessionID & Chr(39)
        FieldNames = "LogOffDateTime,LogInDateTime,IsLoggedIn,LoggedInDuration"
        OpsFieldnames = "IsLoggedIn,SessionID"
        ExcludeFields = ""
        OpsExcludeFields = "ID,UserID,Username,Firstname,Lastname,EmpNo,DateCreated,Comments,AccessRights"
        FieldValues = dtDateLoggedOut & "," & dtDateLoggedIn & "," & strIsLoggedIn & "," & strLoggedInDuration

        IsUpdatedOK = InsertUpdateRecords_Using_Parameters(strConnectionString, True, "", DBTable, FieldNames, FieldValues, OpsCriteria,
                                                           ExcludeFields, MyMessage, False, ",")
        If Not IsUpdatedOK Then
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "saveSession()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End If
        'UPDATE tblOperators with Logged In info:
        OpsFieldValues = strIsLoggedIn & "," & strSessionID
        IsOpsUpdatedOK = InsertUpdateRecords_Using_Parameters(strConnectionString, True, "", OpsDBTable, OpsFieldnames, OpsFieldValues, OpsCriteria,
                                                              OpsExcludeFields, MyOpsMessage, False, ",")
        If Not IsOpsUpdatedOK Then
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "saveSession()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End If

        'REMOVE THE OPERATOR FROM THE OperatorsOnline table:
        DeletedOK = DeleteMyRecord(OnlineTable, strConnectionString, OpDeleteCriteria, MyMessage)
        If DeletedOK = True Then
            'Me.txtMessages.AppendText(vbCrLf & " *Entry moved to History: " & strAssetName)
            logERR.LogMessage("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "saveSession()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "saveSession()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        Else
            logERR.LogError("NMS_Error_" & Me.GetVersion & ".log", Application.StartupPath, MyMessage, "saveSession()", GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & Me.GetUsername)
        End If

    End Sub

    Function CheckCoordEntry(ByVal Entry As String, ByRef msg As String) As Double
        Dim NewValue As Double

        msg = ""
        NewValue = 0
        CheckCoordEntry = 0
        If Len(Entry) > 0 Then
            If Mid(Entry, 1, 1) = "(" And Mid(Entry, Len(Entry), 1) = ")" Then
                Entry = Mid(Entry, 2, Len(Entry) - 2)
            End If
            If IsNumeric(Entry) Then
                NewValue = CDbl(Entry)
            Else
                msg = "Invalid Entry"
            End If
        End If

        CheckCoordEntry = NewValue
    End Function

    Function ConvertEntryToCoords(dblEntry As Double) As String
        Dim StopPos As Integer
        Dim NewEntry As String
        Dim Entry As String
        Dim idx As Integer
        Dim ch As Char

        ConvertEntryToCoords = ""
        NewEntry = ""
        '-4.5, 9.6, 90.56, -34.56
        Entry = CStr(dblEntry)
        StopPos = InStr(Entry, ".")
        If StopPos > 0 Then
            ch = Mid(Entry, 1, 1)
            If ch = "-" Then
                NewEntry += "-"
            Else
                NewEntry += "+" & ch
            End If
            For idx = 2 To StopPos - 1
                ch = Mid(Entry, idx, 1)
                If IsNumeric(ch) Then
                    NewEntry += ch
                Else
                    NewEntry += "0"
                End If
            Next
            NewEntry += "."
            For idx = StopPos + 1 To Len(Entry)
                ch = Mid(Entry, idx, 1)
                If IsNumeric(ch) Then
                    NewEntry += ch
                Else
                    NewEntry += "0"
                End If
            Next

        Else
            'NO DECIMAL
            ch = Mid(Entry, 1, 1)
            If ch = "-" Then
                NewEntry += "-"
            Else
                NewEntry += "+" & ch
            End If
            For idx = 2 To Len(Entry)
                ch = Mid(Entry, idx, 1)
                If IsNumeric(ch) Then
                    NewEntry += ch
                End If
            Next
            NewEntry += ".0"
        End If
        ConvertEntryToCoords = NewEntry
    End Function

    Function AddZeros(Entry As String) As String
        Dim idx As Integer
        Dim ch As Char
        Dim StopPos As Integer
        Dim NewEntry As String
        Dim zeros As String
        Dim intBeforeStop As Integer
        Dim intAfterStop As Integer
        Dim intNumBeforeStop As Integer
        Dim intNumAfterStop As Integer

        StopPos = InStr(Entry, ".")
        If Mid(Entry, 1, 1) = "(" And Mid(Entry, Len(Entry), 1) = ")" And StopPos > 0 Then
            '(+0.0) or (+5.6) or (-45.34) or (+123.456) or (+000.000) or (+034.453) or (-23.4)
            NewEntry = Mid(Entry, 2, 1)
            intBeforeStop = StopPos - 2
            intAfterStop = (Len(Entry) - 1) - StopPos
            If intBeforeStop = 2 Then
                NewEntry += "00"
                intNumBeforeStop = 1
            ElseIf intBeforeStop = 3 Then
                NewEntry += "0"
                intNumBeforeStop = 2
            Else
                intNumBeforeStop = 3
            End If
            NewEntry += Mid(Entry, 3, intNumBeforeStop)
            NewEntry += "."

            If intAfterStop = 1 Then
                zeros = "00"
                intNumAfterStop = 1
            ElseIf intAfterStop = 2 Then
                zeros = "0"
                intNumAfterStop = 2
            Else
                zeros = ""
                intNumAfterStop = 3
            End If
            NewEntry += Mid(Entry, StopPos + 1, intNumAfterStop)
            NewEntry += zeros
        End If
        AddZeros = "(" & NewEntry & ")"
    End Function

    Sub ImportPicture(ByRef pbBox As PictureBox, ByRef ImageFilename As String)
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pbBox.BackgroundImage = Image.FromFile(dlg.FileName)
            ImageFilename = dlg.FileName
            pbBox.Tag = dlg.FileName
        End If
    End Sub

    Function GetLogTableDisplayValues(ConString As String, UserIDs As String, AccountIDs As String, strLogIDs As String, UseFields As Boolean,
                                      DateFrom As String, DateTo As String, System As String, Planet As String, Brief As String, Comment As String,
                                      ByRef strSQL As String, Optional ByVal SortFields As String = "") As DataTable
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Fields As String
        Dim concat As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim sqlWhere As String
        Dim dt As DataTable

        GetLogTableDisplayValues = Nothing
        If UseFields Then
            concat = "concat_ws(' - ',RenamedSystemName,OriginalSystemName) as 'System Name'" 'from system table
            Fields = "AccountName as 'Account',CurrentDateTime as 'Entry Date',LastSaved as 'Last Saved',CurrentStarSystem as 'System'"
            Fields = Fields & ",OriginalSystemName as 'Orig. System',CurrentPlanet as 'Planet',OriginalPlanetName as 'Orig. Planet'"
            Fields = Fields & ",CurrentPlanetArea as 'Area',CurrentPosition as 'Position',CurrentNanites as 'Nanites',CurrentUnits as 'Units',CurrentQuickSilver as 'QS',CurrentFrigateModules as 'FM',CurrentSalvagedData as 'SD'"
            Fields = Fields & ",Brief,Comment1,Comment2,PlanetID,SystemID,AccountID,LogID"
            'Fields = Fields & ",RTFComment1 as 'Comment1',RTFComment2 as 'Comment2',Image"
        Else
            Fields = "*"
        End If
        strSQL = "SELECT " & Fields & " FROM tblLog "
        sqlWhere = "WHERE UserID in (" & UserIDs & ")"
        If AccountIDs <> "" Then
            sqlWhere += " AND AccountID in (" & AccountIDs & ")"
        End If
        If strLogIDs <> "" Then
            sqlWhere += " AND LogID IN (" & strLogIDs & ")"
        End If
        If DateFrom <> "" Then
            sqlWhere += " AND CurrentDateTime>='" & CDate(DateFrom).ToString("yyyy-MM-dd HH:mm:ss") & "'"
        End If
        If DateTo <> "" Then
            sqlWhere += " AND CurrentDateTime<='" & CDate(DateTo).ToString("yyyy-MM-dd HH:mm:ss") & "'"
        End If
        If System <> "" Then
            sqlWhere += " AND CurrentStarSystem like '%" & System & "%'"
        End If
        If Planet <> "" Then
            sqlWhere += " AND CurrentPlanet like '%" & Planet & "%'"
        End If
        If Brief <> "" Then
            sqlWhere += " AND Brief like '%" & Brief & "%'"
        End If
        If Comment <> "" Then
            sqlWhere += " AND Comment1 like '%" & Comment & "%'"
        End If
        strSQL += sqlWhere
        If Len(SortFields) > 0 Then
            strSQL = strSQL & " ORDER BY " & SortFields
        End If

        dt = DAL.GetDataTable(ConString, strSQL, NumRows)
        GetLogTableDisplayValues = dt
    End Function

    Function GetLogSortFields() As String
        Dim Fields As String

        Fields = "AccountName,CurrentDateTime,LastSaved,CurrentStarSystem"
        Fields = Fields & ",OriginalSystemName,CurrentPlanet,OriginalPlanetName"
        Fields = Fields & ",CurrentPlanetArea,CurrentPosition,CurrentNanites,CurrentUnits,CurrentQuickSilver,CurrentFrigateModules,CurrentSalvagedData"
        Fields = Fields & ",Brief,Comment1,Comment2,PlanetID,SystemID,AccountID,LogID"
        Return Fields
    End Function

    Function GetCollaboratedUserIDs(ConnString As String, DBTable As String, CurrentUserID As Integer, CurrentAccount As Integer, ByRef GetAccounts As String) As String
        'Given Current UserID and AccountID - lookup users who can collaborate with this user - 
        'Return the UserIDs.
        Dim dt As DataTable
        Dim strSQL As String
        Dim NumRows As Integer
        Dim UserIDs As String

        strSQL = "SELECT * FROM tblPreferences WHERE UserID=" & CurrentUserID
        If CurrentAccount > 0 Then
            strSQL += " AND AccountID=" & CurrentAccount
        End If
        strSQL += " AND Category= '" & "COLLABORATE:USERID" & "'"
        dt = Me.GetDataTable(ConnString, strSQL, NumRows)
        If Not IsNothing(dt) Then
            'CollaborateIUserIDs
            'CollaborateAccountIDs
            UserIDs = dt.Rows(0)("CollaborateIUserIDs")
            GetAccounts = dt.Rows(0)("CollaborateAccountIDs")
        End If
        Return UserIDs
    End Function

    Function GetAccounts(ConnString As String, AccountID As Integer, UserID As Integer, ByRef NumRows As Integer) As DataTable
        Dim myDR As MySqlDataReader = Nothing
        Dim SQLStatement As String
        Dim ZeroDatetime As Boolean = True
        Dim Server As String = "localhost"
        Dim DbaseName As String = "simplequerybuilder"
        Dim USERNAME As String = "root"
        Dim password As String = "root"
        Dim port As String = "3306"

        GetAccounts = Nothing
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            'ConnString = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            SQLStatement = "SELECT " &
            "AccountID," &
            "UserID," &
            "AccountName," &
            "trim(GamePlatform) as ""GamePlatform"", " &
            "trim(GameVersion) as ""GameVersion"", " &
            "DateSubmitted as ""DateSubmitted"", " &
            "trim(Comments) as ""Comments"", " &
            "trim(DefaultAccount) as ""DefaultAccount"", " &
            "trim(GamerHandle) as ""GamerHandle"", " &
            "DateCreated as ""DateCreated"" " &
            "FROM tblAccounts "
            If AccountID > 0 Then
                SQLStatement += "Where AccountID= " & AccountID & " " & "ORDER BY AccountName"
            End If
            If UserID > 0 Then
                SQLStatement += "Where UserID= " & UserID & " " & "ORDER BY AccountName"
            End If
            '"trim(AccountName) as ""AccountName"", " &
            Return GetDataTable(ConnString, SQLStatement, NumRows)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try
    End Function

    Function GetMultiAccounts(ConnString As String, CurrentUser As Integer, AccountIDs As String, UserIDs As String, ByRef NumRows As Integer) As DataTable
        Dim myDR As MySqlDataReader = Nothing
        Dim SQLStatement As String
        Dim ZeroDatetime As Boolean = True
        Dim Server As String = "localhost"
        Dim DbaseName As String = "simplequerybuilder"
        Dim USERNAME As String = "root"
        Dim password As String = "root"
        Dim port As String = "3306"

        GetMultiAccounts = Nothing
        If UserIDs = "" Then
            MsgBox("User IDs not specified")
            Exit Function
        End If
        If AccountIDs = "" Then
            'MsgBox("Account IDs not specified")
            'Exit Function
        End If
        Try
            'ConnString = setupMySQLconnection("localhost", "simplequerybuilder", "root", "root", "3306", ErrMessage)
            'ConnString = String.Format("server={0}; user id={1}; password={2}; database={3}; Convert Zero Datetime={4}; port={5}; pooling=false", Server, USERNAME, password, DbaseName, ZeroDatetime, port)
            Dim cn As New MySqlConnection(ConnString)
            cn.Open()
            SQLStatement = "SELECT " &
            "AccountID," &
            "UserID," &
            "AccountName," &
            "trim(GamePlatform) as ""GamePlatform"", " &
            "trim(GameVersion) as ""GameVersion"", " &
            "DateSubmitted as ""DateSubmitted"", " &
            "trim(Comments) as ""Comments"", " &
            "trim(DefaultAccount) as ""DefaultAccount"", " &
            "trim(GamerHandle) as ""GamerHandle"", " &
            "DateCreated as ""DateCreated"" " &
            "FROM tblAccounts "
            SQLStatement += "Where UserID in (" & UserIDs & ") "
            If AccountIDs <> "" Then
                SQLStatement += " AND AccountID in (" & AccountIDs & ") "
            End If
            SQLStatement += " OR UserID=" & CurrentUser & " ORDER BY AccountName"

            '"trim(AccountName) as ""AccountName"", " &
            Return GetDataTable(ConnString, SQLStatement, NumRows)
        Catch ex As Exception
            MsgBox("DB ERROR: " & ex.Message)
        End Try
    End Function

End Class
