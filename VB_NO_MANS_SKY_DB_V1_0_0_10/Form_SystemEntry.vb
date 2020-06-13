Public Class frmSystemEntry

    Private Sub frmSystemEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSystems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strAccountID As String
        Dim strSystemID As String
        Dim strOriginalSystemName As String
        Dim strRenamedSystemName As String
        Dim strGalacticName As String
        Dim strDominatedBy As String
        Dim strDiscoveredBy As String
        Dim strDiscoveryDate As String
        Dim strGalacticRegion As String
        Dim strSystemType As String
        Dim strSystemLocation As String
        Dim strDistanceFromCore As String
        Dim strPlanetsInSystem As String
        Dim strMoonsInSystem As String
        Dim strComments As String
        Dim strNextSystem As String
        Dim strDefaultSystem As String

        strAccountID = txtAccountID.Text
        strSystemID = txtSystemID.Text
        strOriginalSystemName = txtSystemName.Text
        strRenamedSystemName = txtRenamedSystem.Text
        strGalacticName = txtGalaxyName.Text
        strDominatedBy = txtDominatedBy.Text
        strDiscoveredBy = txtDiscoveredBy.Text
        strDiscoveryDate = CDate(txtDiscoveryDate.Text).ToString("yyyy-MM-dd HH:mm:ss")
        strGalacticRegion = txtGalacticRegion.Text
        strSystemType = txtSystemType.Text
        strSystemLocation = txtLocation.Text
        strDistanceFromCore = txtDistanceFromCore.Text
        strPlanetsInSystem = txtPlanetsInSystem.Text
        strMoonsInSystem = txtMoonsInSystem.Text
        strComments = txtComments.Text
        strNextSystem = txtNextSystem.Text
        strDefaultSystem = txtDefault.Text

        Call Save_System(strAccountID, strSystemID, strOriginalSystemName,
                            strRenamedSystemName, strGalacticName, strDominatedBy, strDiscoveredBy, strDiscoveryDate,
                            strGalacticRegion, strSystemType, strSystemLocation,
                            strDistanceFromCore, strPlanetsInSystem, strMoonsInSystem, strComments, strNextSystem, False, strDefaultSystem)

    End Sub

    Sub Save_System(strAccountID As String, strSystemID As String, strOriginalSystemName As String,
                    strRenamedSystemName As String, strGalacticName As String,
                    strDominatedBy As String, strDiscoveredBy As String, strDiscoveryDate As String, strGalacticRegion As String, strSystemType As String,
                    strSystemLocation As String, strDistanceFromCore As String,
                    strPlanetsInSystem As String, strMoonsInSystem As String, strComments As String, strNextSystem As String,
                    Optional SetDefault As Boolean = False,
                    Optional strDefaultSystem As String = "")
        Dim dtDiscoveryDate As DateTime
        Dim strSubmitTime As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblSystems"
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
        Dim FoundSystem As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String = Nothing
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim ResetOK As Boolean = False
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.
        dtCurrentDate = Now()
        ErrMessages = ""
        strSubmitTime = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strAccountID = Me.txtAccountID.Text
        strComments = Me.txtComments.Text
        If SetDefault = True Then
            ResetOK = myDAL.UpdateALL(frmMain.myConnString, DBTable, "DefaultSystem")
            If ResetOK = False Then
                MsgBox("Could not reset Default field")
                Exit Sub
            End If
            strDefaultSystem = "DEFAULT"
            Me.txtDefault.Text = strDefaultSystem
        Else
            'strDefaultSystem = Me.txtDefault.Text
        End If

        'CREATE TABLE IF Not EXISTS `tblsystems` (
        '  `SystemID` int(11) Not NULL AUTO_INCREMENT,
        '  `OriginalSystemName` varchar(100) Not NULL DEFAULT 'Unknown',
        '  `RenamedSystemName` varchar(100) Not NULL DEFAULT 'Unknown',
        '  `AccountID` int(11) DEFAULT NULL,
        '  `AliasName` varchar(100) Not NULL DEFAULT 'Unknown',
        '  `DominatedBy` varchar(50) Not NULL DEFAULT 'Unknown',
        '  `DiscoveredBy` varchar(50) Not NULL DEFAULT 'Unknown',
        '  `DiscoveryDate` datetime DEFAULT '1900-01-01 00:00:00',
        '  `GalacticRegion` varchar(50) DEFAULT 'Unknown',
        '  `SystemType` varchar(50) DEFAULT 'Unknown',
        '  `SystemLocation` varchar(50) DEFAULT 'Unknown',
        '  `DistanceFromCore` int(11) DEFAULT '0',
        '  `PlanetsInSystem` int(11) DEFAULT '0',
        '  `MoonsInSystem` varchar(50) DEFAULT 'Unknown',
        '  `Comments` varchar(1024) DEFAULT '',
        '  `DefaultSystem` varchar(10) DEFAULT '',
        ' PRIMARY KEY(`SystemID`)
        ') ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf32 COMMENT='

        FieldNames = "UserID"
        FieldNames = FieldNames & ",OriginalSystemName"
        FieldNames = FieldNames & ",GalacticName"
        FieldNames = FieldNames & ",RenamedSystemName"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",DominatedBy"
        FieldNames = FieldNames & ",DiscoveredBy"
        FieldNames = FieldNames & ",DiscoveryDate"
        FieldNames = FieldNames & ",GalacticRegion"
        FieldNames = FieldNames & ",SystemType"
        FieldNames = FieldNames & ",SystemLocation"
        FieldNames = FieldNames & ",DistanceFromCore"
        FieldNames = FieldNames & ",PlanetsInSystem"
        FieldNames = FieldNames & ",MoonsInSystem"
        FieldNames = FieldNames & ",Comments"
        FieldNames = FieldNames & ",DefaultSystem"
        FieldNames = FieldNames & ",Updated"
        FieldNames = FieldNames & ",NextSystem"

        FieldValues = frmMain.myUserID
        FieldValues = FieldValues & "," & strOriginalSystemName
        FieldValues = FieldValues & "," & strGalacticName
        FieldValues = FieldValues & "," & strRenamedSystemName
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strDominatedBy
        FieldValues = FieldValues & "," & strDiscoveredBy
        FieldValues = FieldValues & "," & strDiscoveryDate
        FieldValues = FieldValues & "," & strGalacticRegion
        FieldValues = FieldValues & "," & strSystemType
        FieldValues = FieldValues & "," & strSystemLocation
        FieldValues = FieldValues & "," & strDistanceFromCore
        FieldValues = FieldValues & "," & strPlanetsInSystem
        FieldValues = FieldValues & "," & strMoonsInSystem
        FieldValues = FieldValues & "," & strComments
        FieldValues = FieldValues & "," & strDefaultSystem
        FieldValues = FieldValues & "," & strSubmitTime
        FieldValues = FieldValues & "," & strNextSystem

        SearchText = strOriginalSystemName
        SearchField = "OriginalSystemName"
        ReturnField = "SystemID"
        ReturnValue = ""
        FieldType = "STRING"
        Reversed = True
        SortFields = "OriginalSystemName"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundSystem = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundSystem Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Account Already EXISTS - Proceed with update?", vbYesNo, "ACCOUNT ALREADY EXISTS")
            If Answer = vbYes Then
                UpdateCriteria = "SystemID = " & ReturnValue
                SavedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
            End If
        Else
            'Create NEW ENTRY:
            UpdateCriteria = ""
            SavedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
        End If
        If SavedOK Then
            MsgBox("OK Account Info Updated.")
            PopulateSystemGrid()

        Else
            MsgBox("Problem: Account Info NOT SAVE")
        End If
    End Sub

    Private Sub btnSetDefault_Click(sender As Object, e As EventArgs) Handles btnSetDefault.Click
        'SET DEFAULT SYSTEM:
        Dim strAccountID As String
        Dim strSystemID As String
        Dim strOriginalSystemName As String
        Dim strRenamedSystemName As String
        Dim strGalacticName As String
        Dim strDominatedBy As String
        Dim strDiscoveredBy As String
        Dim strDiscoveryDate As String
        Dim strGalacticRegion As String
        Dim strSystemType As String
        Dim strSystemLocation As String
        Dim strDistanceFromCore As String
        Dim strPlanetsInSystem As String
        Dim strMoonsInSystem As String
        Dim strComments As String
        Dim strNextSystem As String
        Dim strDefaultSystem As String

        strAccountID = txtAccountID.Text
        strSystemID = txtSystemID.Text
        strOriginalSystemName = txtSystemName.Text
        strRenamedSystemName = txtRenamedSystem.Text
        strGalacticName = txtGalaxyName.Text
        strDominatedBy = txtDominatedBy.Text
        strDiscoveredBy = txtDiscoveredBy.Text
        strDiscoveryDate = CDate(txtDiscoveryDate.Text).ToString("yyyy-MM-dd HH:mm:ss")
        strGalacticRegion = txtGalacticRegion.Text
        strSystemType = txtSystemType.Text
        strSystemLocation = txtLocation.Text
        strDistanceFromCore = txtDistanceFromCore.Text
        strPlanetsInSystem = txtPlanetsInSystem.Text
        strMoonsInSystem = txtMoonsInSystem.Text
        strComments = txtComments.Text
        strNextSystem = txtNextSystem.Text
        strDefaultSystem = txtDefault.Text

        Call Save_System(strAccountID, strSystemID, strOriginalSystemName,
                            strRenamedSystemName, strGalacticName, strDominatedBy, strDiscoveredBy, strDiscoveryDate,
                            strGalacticRegion, strSystemType, strSystemLocation,
                            strDistanceFromCore, strPlanetsInSystem, strMoonsInSystem, strComments, strNextSystem, True, strDefaultSystem)
    End Sub

    Private Sub comAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAccounts.SelectedIndexChanged
        '
        SelectAccount(False, comAccounts.SelectedItem)

        'MsgBox("GamePlatform=" & GamePlatform)
        'End If
    End Sub

    Public Sub SelectAccount(DefaultAccount As Boolean, SelectedItem As Object)
        Dim dt As DataTable
        Dim AccountID As String
        Dim GamePlatform As String
        Dim AccountName As String
        Dim AccountSubmitted As String
        Dim GameVersion As String
        Dim GamerHandle As String
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
        Dim SortFields As String = "AccountName"
        Dim FoundAccount As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String = Nothing
        Dim ErrMessage As String = ""
        Dim DBTable As String = "tblAccounts"
        Dim NumRows As Integer = 0
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        ClearAll()
        dt = comAccounts.DataSource
        'AccountName = comAccounts.SelectedText
        SearchText = "DEFAULT"
        SearchField = "DefaultAccount"
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        If dt.Rows.Count > 0 Then
            If SelectedItem IsNot Nothing Then
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("AccountName")) Then
                    AccountName = DirectCast(SelectedItem, DataRowView).Item("AccountName").ToString
                Else
                    AccountName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("AccountID")) Then
                    AccountID = DirectCast(SelectedItem, DataRowView).Item("AccountID").ToString
                Else
                    AccountID = "0"
                End If

                GamePlatform = DirectCast(SelectedItem, DataRowView).Item("GamePlatform")
                GameVersion = DirectCast(SelectedItem, DataRowView).Item("GameVersion")
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("GameVersion").ToString) Then
                    GamerHandle = DirectCast(SelectedItem, DataRowView).Item("GamerHandle").ToString
                Else
                    GamerHandle = "UNKNOWN"
                End If

                SearchText = AccountName
                SearchField = "AccountName"
            End If

        End If

        ReturnField = "AccountID"
        FieldType = "STRING"
        'SET DISCOVERED BY:
        FoundAccount = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                        SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
        If FoundAccount Then
            AccountID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountID")
            GamerHandle = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamerHandle")
            AccountName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountName")
            GamePlatform = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamePlatform")
            GameVersion = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GameVersion")
            AccountSubmitted = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "DateSubmitted")

            Me.txtAccountID.Text = AccountID
            Me.txtAccountName.Text = AccountName
            Me.txtPlatform.Text = GamePlatform
            Me.txtVersion.Text = GameVersion
            Me.txtDiscoveredBy.Text = GamerHandle
            Me.txtAccountCreated.Text = AccountSubmitted
        End If

        PopulateSystemGrid(Nothing)

    End Sub

    Public Sub BuildCombo()

        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)

        Tablename = "tblAccounts"
        strSQL = "SELECT * FROM " & Tablename & " WHERE UserID=" & CInt(frmMain.myUserID)
        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        dt.Select()
        comAccounts.DataSource = dt
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        Me.txtTotalAccounts.Text = CStr(NumRows)

        comAccounts.ValueMember = "AccountID"
        comAccounts.DisplayMember = "AccountName"
        comAccounts.DataSource = dt

        comAccounts.SelectedText = ""
        comAccounts.Text = ""

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub PopulateAccountFields(RowIDX As Integer)
        Dim dt As DataTable
        Dim AccountName As String



    End Sub

    Private Sub comAccounts_ValueMemberChanged(sender As Object, e As EventArgs) Handles comAccounts.ValueMemberChanged
        'Value Member Changed:
        Dim dt As DataTable
        Dim AccountID As String
        Dim GamePlatform As String
        Dim AccountName As String
        Dim GameVersion As String

        'dt = comAccounts.DataSource
        'If dt.Rows.Count > 0 Then
        'AccountID = dt.Rows(comAccounts.SelectedIndex)("AccountID").ToString
        'GamePlatform = dt.Rows(comAccounts.SelectedIndex)("GamePlatform").ToString
        'GameVersion = dt.Rows(comAccounts.SelectedIndex)("GameVersion").ToString
        'AccountName = dt.Rows(comAccounts.SelectedIndex)("AccountName").ToString
        'Me.txtAccountID.Text = AccountID
        'Me.txtAccountName.Text = AccountName
        'Me.txtPlatform.Text = GamePlatform
        'Me.txtVersion.Text = GameVersion
        '

        'MsgBox("GamePlatform=" & GamePlatform)
        'End If
    End Sub

    Private Sub frmSystemEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        BuildCombo()
        'PopulateSystemGrid()
        'SelectAccount(True, comAccounts.SelectedItem)
    End Sub

    Public Sub SelectedCell(CellSelected As DataGridViewCellEventArgs, Optional ByVal SelectRow As Integer = -1)
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim FieldType As String
        Dim Reversed As Boolean
        Dim SortFields As String
        Dim IDFieldvalue As String
        Dim intID As Integer
        Dim ExcludeFields As String
        Dim FoundAccount As Boolean
        Dim AllFields() As String = Nothing
        Dim AllValues() As Object = Nothing
        Dim DBTable As String
        Dim SearchCriteria As String
        Dim ErrMessage As String = ""
        Dim strAccountID As String
        Dim strAccountName As String
        Dim rowIDX As Integer
        Dim strSystemComments As String
        Dim strGameVersion As String
        Dim strPlatform As String
        Dim strDefault As String
        Dim strUserID As String
        Dim strSystemID As String
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strSystemName As String
        Dim strSystemLocation As String
        Dim strNewSystemName As String
        Dim strGalacticName As String
        Dim strGalacticRegion As String
        Dim strPlanetsInSystem As String
        Dim strMoonsInSystem As String
        Dim strSystemType As String
        Dim strDominatedBy As String
        Dim strDistanceFromGalacticCore As String
        Dim strNextSystem As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSQL As String
        Dim intAccountID As Integer
        Dim dt As DataTable
        Dim NumRows As Integer = 0
        Dim TotalRows As Integer = 0
        Dim ErrMessages As String = ""

        If Not IsNothing(CellSelected) Then
            If CellSelected.RowIndex > -1 Then
                rowIDX = CellSelected.RowIndex
            Else
                rowIDX = 0
            End If
        End If
        If SelectRow >= 0 Then
            rowIDX = SelectRow
        End If
        DBTable = "tblSystems"
        If cbAccountFilter.Checked Then
            If txtAccountID.Text <> "" Then
                intAccountID = CInt(txtAccountID.Text)
            Else
                intAccountID = 0
            End If
            strSQL = "SELECT * FROM " & DBTable & " WHERE UserID=" & CInt(frmMain.myUserID) & " AND AccountID=" & intAccountID & " ORDER BY RenamedSystemName"
        Else
            strSQL = "SELECT * FROM " & DBTable & " WHERE UserID=" & CInt(frmMain.myUserID) & " ORDER BY RenamedSystemName"
        End If

        dt = Nothing
        myDAL.PopulateMyDataSource(dgvSystems.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        Me.txtTotalSystems.Text = CStr(NumRows)
        TotalRows = dt.Rows.Count
        If rowIDX >= TotalRows Then
            MsgBox("Out of range, select different row")
            Exit Sub
        End If
        'strRegisterID = Me.dgvAssetRegistry.Item(0, Me.dgvAssetRegistry.CurrentCell.RowIndex).Value.ToString
        'strAccountID = Me.dgvAccounts.Item(1, rowIDX).Value.ToString
        If dt IsNot Nothing Then
            strAccountID = dt.Rows(rowIDX)("AccountID").ToString
            strSystemName = dt.Rows(rowIDX)("OriginalSystemName").ToString
            strSystemID = dt.Rows(rowIDX)("SystemID").ToString
            strGalacticName = dt.Rows(rowIDX)("GalacticName").ToString
            strNewSystemName = dt.Rows(rowIDX)("RenamedSystemName").ToString
            strDominatedBy = dt.Rows(rowIDX)("DominatedBy").ToString
            strDiscoveredBy = dt.Rows(rowIDX)("DiscoveredBy").ToString
            strDiscoveryDate = dt.Rows(rowIDX)("DiscoveryDate").ToString
            strGalacticRegion = dt.Rows(rowIDX)("GalacticRegion").ToString
            strSystemType = dt.Rows(rowIDX)("SystemType").ToString
            strSystemLocation = dt.Rows(rowIDX)("SystemLocation").ToString
            strDistanceFromGalacticCore = dt.Rows(rowIDX)("DistanceFromCore").ToString
            strPlanetsInSystem = dt.Rows(rowIDX)("PlanetsInSystem").ToString
            strMoonsInSystem = dt.Rows(rowIDX)("MoonsInSystem").ToString
            strNextSystem = dt.Rows(rowIDX)("NextSystem").ToString
            strSystemComments = dt.Rows(rowIDX)("Comments").ToString
            strDefault = dt.Rows(rowIDX)("DefaultSystem").ToString 'will return Default or just blank
        End If

        If Len(strAccountID) = 0 Then
            strAccountID = "0"
        End If

        SearchText = strAccountID
        SearchField = "AccountID"
        ReturnField = "AccountID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "AccountName"
        ExcludeFields = ""
        DBTable = "tblAccounts"
        FoundAccount = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                    AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundAccount Then
            ''Populate text boxes:
            strGameVersion = GetValuebyFieldname(AllValues, AllFields, "GameVersion")
            strPlatform = GetValuebyFieldname(AllValues, AllFields, "GamePlatform")
            strAccountName = GetValuebyFieldname(AllValues, AllFields, "AccountName")
            strUserID = GetValuebyFieldname(AllValues, AllFields, "UserID")
        End If
        Me.txtUserID.Text = frmMain.myUserID
        Me.txtSystemID.Text = strSystemID
        Me.txtAccountName.Text = strAccountName
        Me.txtPlatform.Text = strPlatform
        Me.txtVersion.Text = strGameVersion
        Me.txtAccountID.Text = strAccountID
        Me.txtSystemName.Text = strSystemName
        Me.txtGalaxyName.Text = strGalacticName
        Me.txtGalacticRegion.Text = strGalacticRegion
        Me.txtRenamedSystem.Text = strNewSystemName
        Me.txtDominatedBy.Text = strDominatedBy
        Me.txtDiscoveredBy.Text = strDiscoveredBy
        If IsDate(strDiscoveryDate) Then
            Me.txtDiscoveryDate.Text = CDate(strDiscoveryDate).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        Me.txtSystemType.Text = strSystemType
        Me.txtLocation.Text = strSystemLocation
        Me.txtDistanceFromCore.Text = strDistanceFromGalacticCore
        Me.txtPlanetsInSystem.Text = strPlanetsInSystem
        Me.txtMoonsInSystem.Text = strMoonsInSystem
        Me.txtNextSystem.Text = strNextSystem
        Me.txtComments.Text = strSystemComments
        Me.txtDefault.Text = strDefault

        dgvSystems.Rows(rowIDX).Selected = True
    End Sub

    Private Sub dgvSystems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystems.CellContentClick
        'SELECT FROM GRID:
        SelectedCell(e)
    End Sub



    Public Sub PopulateSystemGrid(Optional ByRef dt As DataTable = Nothing)
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Fields As String
        Dim concat As String
        Dim Normal As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Normal = "OriginalSystemName,RenamedSystemName"

        concat = "concat_ws(' - ',RenamedSystemName,OriginalSystemName) as 'System Name (New-Old)'"
        Fields = "GalacticNAme," & concat & ",GalacticRegion,DistanceFromCore,DominatedBy,PlanetsInSystem"
        Fields = Fields & ",MoonsInSystem,DiscoveredBy,DiscoveryDate,Updated,DefaultSystem,AccountID,SystemID,UserID"
        If txtAccountID.Text <> "" Then
            strSQL = "SELECT " & Fields & " FROM tblSystems WHERE UserID=" & CInt(frmMain.myUserID) & " AND AccountID=" & CInt(txtAccountID.Text) & " ORDER BY RenamedSystemName"
        Else
            strSQL = "SELECT " & Fields & " FROM tblSystems WHERE UserID=" & CInt(frmMain.myUserID) & " ORDER BY RenamedSystemName"
        End If
        Call myDAL.PopulateMyDataSource(dgvSystems.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessage, dt)
        ssSystemStripLabel1.Text = "Records: " & CStr(NumRows)
        If dt IsNot Nothing Then
            dgvSystems.DataSource = dt
        End If
        If txtSystemID.Text = "" Or txtSystemID.Text = "0" Then
            'SelectedCell(Nothing, 0)
        End If
    End Sub

    Private Sub btnGetDefaultAccount_Click(sender As Object, e As EventArgs) Handles btnGetDefaultAccount.Click
        'SELECT DEFAULT ACCOUNT:
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Fields As String
        Dim concat As String
        Dim Normal As String
        Dim dt As DataTable = Nothing
        Dim idx As DataGridViewCellEventArgs
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        concat = "concat_ws(' - ',RenamedSystemName,OriginalSystemName) as 'System Name'"
        Fields = "GalacticNAme," & concat & ",GalacticRegion,DistanceFromCore,DominatedBy,PlanetsInSystem"
        Fields = Fields & ",MoonsInSystem,DiscoveredBy,DiscoveryDate,Updated,DefaultSystem,AccountID,SystemID"
        strSQL = "SELECT " & Fields & " FROM tblSystems " & " WHERE UserID=" & CInt(frmMain.myUserID) & " AND DefaultSystem='" & "DEFAULT" & "'"
        Call myDAL.PopulateMyDataSource(dgvSystems.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessage, dt)
        dgvSystems.Rows(0).Selected = True
        SelectedCell(Nothing, 0)

    End Sub

    Private Sub btnResetSystems_Click(sender As Object, e As EventArgs) Handles btnResetSystems.Click
        PopulateSystemGrid()

    End Sub

    Private Sub dgvSystems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystems.CellClick
        SelectedCell(e)
    End Sub

    Sub ClearAll()
        txtAccountID.Text = ""
        txtAccountName.Text = ""
        txtComments.Text = ""
        txtDefault.Text = ""
        txtDiscoveredBy.Text = ""
        txtDiscoveryDate.Text = ""
        txtDistanceFromCore.Text = ""
        txtDominatedBy.Text = ""
        txtGalacticRegion.Text = ""
        txtGalaxyName.Text = ""
        txtLocation.Text = ""
        txtMoonsInSystem.Text = ""
        txtNextSystem.Text = ""
        txtPlanetsInSystem.Text = ""
        txtPlatform.Text = ""
        txtRenamedSystem.Text = ""
        txtSystemID.Text = ""
        txtSystemName.Text = ""
        txtSystemType.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()

    End Sub
End Class