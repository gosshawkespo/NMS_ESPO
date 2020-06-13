Imports System.IO
Public Class Form_LogEntry3
    Private _SelectedArea As String
    Private _ButtonClicked As String
    Private _strLOGID As String
    Private _intLOGID As Integer
    Private _SelectedAccountID As Integer
    Public Property SelectedArea() As String
        Get
            Return _SelectedArea
        End Get
        Set(value As String)
            _SelectedArea = value
        End Set
    End Property

    Public Property ButtonClicked() As String
        Get
            Return _ButtonClicked
        End Get
        Set(value As String)
            _ButtonClicked = value
        End Set
    End Property

    Public Property strLOGID() As String
        Get
            Return _strLOGID
        End Get
        Set(value As String)
            _strLOGID = value
        End Set
    End Property

    Public Property intLOGID() As Integer
        Get
            Return _intLOGID
        End Get
        Set(value As Integer)
            _intLOGID = value
        End Set
    End Property

    Public Property SelectedAccountID() As Integer
        Get
            Return _SelectedAccountID
        End Get
        Set(value As Integer)
            _SelectedAccountID = value
        End Set
    End Property

    Sub Save_LOG(Optional ByVal IncludeVerboseInUpdateMessage As Boolean = True, Optional ByRef LastLogID As String = "")
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim Result As Integer
        Dim LogFields As New clsLogFields
        Dim strImageFilename As String
        Dim strImageExtension As String
        Dim strImageSize As String
        Dim fi As IO.FileInfo
        Dim memStream As New IO.MemoryStream
        Dim arrImage As Byte()
        Dim strUserID As String
        Dim intUserID As Integer

        'strUserID = frmMain.myUserID
        strUserID = txtUserID.Text
        LogFields.myUserID = strUserID
        LogFields.LogFile = ""
        LogFields.LogID = txtLogID.Text
        LogFields.AccountID = txtAccountID.Text
        LogFields.AccountName = txtAccountName.Text
        LogFields.Platform = txtPlatform.Text
        LogFields.Version = txtVersion.Text
        LogFields.GamerHandle = txtGamerHandle.Text
        If IsDate(txtEntryDate.Text) Then
            LogFields.EntryTime = CDate(txtEntryDate.Text).ToString("yyyy-MM-dd HH:mm:ss")
        Else
            LogFields.EntryTime = CDate("1900-01-01 01:00:00").ToString("yyyy-MM-dd HH:mm:ss")
        End If

        LogFields.SystemID = txtSystemID.Text
        LogFields.PlanetID = txtPlanetID.Text
        LogFields.SystemName = txtCurrentSystem.Text
        LogFields.OriginalSystemName = txtOriginalSystemName.Text
        LogFields.NewSystemName = txtCurrentSystem.Text
        LogFields.GalacticRegion = txtGalacticRegion.Text
        LogFields.PlanetName = txtCurrentPlanet.Text
        LogFields.OriginalPlanetName = txtOriginalPlanetName.Text
        LogFields.NewPlanetName = txtCurrentPlanet.Text
        LogFields.CurrentPosition = txtAreaLongitude.Text & " " & txtAreaLatitude.Text
        LogFields.CurrentArea = txtCurrentArea.Text
        LogFields.CurrentNanites = txtNanites.Text
        LogFields.CurrentNanites = Replace(LogFields.CurrentNanites, ",", "")
        LogFields.CurrentUnits = txtUnits.Text
        LogFields.CurrentUnits = Replace(LogFields.CurrentUnits, ",", "")
        LogFields.CurrentQS = txtQuicksilver.Text
        LogFields.CurrentQS = Replace(LogFields.CurrentQS, ",", "")
        LogFields.CurrentFrigateModules = txtFrigateModules.Text
        LogFields.CurrentFrigateModules = Replace(LogFields.CurrentFrigateModules, ",", "")
        LogFields.CurrentSalvagedData = txtSalvagedData.Text
        LogFields.CurrentSalvagedData = Replace(LogFields.CurrentSalvagedData, ",", "")
        LogFields.Brief = txtBrief.Text
        LogFields.Comment1 = rtbComment.Text
        LogFields.Comment2 = rtbFurtherComment.Text
        LogFields.RTFComment1 = rtbComment
        LogFields.RTFComment2 = rtbFurtherComment
        LogFields.LastSaved = Now().ToString("yyyy-MM-dd HH:mm:ss")
        LogFields.LogSavedBy = frmMain.myUsername

        Result = myDAL.UpdateLog(frmMain.myConnString, LogFields, LastLogID, True)
        If Result = 1 Then
            MsgBox("OK LOG ENTRY UPDATED")
        ElseIf Result = 2 Then
            MsgBox("OK LOG ENTRY INSERTED")
        Else
            MsgBox("Problem: Error During Save")
        End If
        txtLogID.Text = LastLogID
        strImageFilename = pb1.Tag
        If Len(strImageFilename) > 0 Then
            fi = New IO.FileInfo(strImageFilename)
            strImageExtension = fi.Extension
        End If

        If strImageExtension IsNot Nothing Then
            If UCase(strImageExtension) = ".BMP" Then
                pb1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImageExtension) = ".JPG" Then
                pb1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImageExtension) = ".PNG" Then
                pb1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImageExtension) = ".GIF" Then
                pb1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                MsgBox("UNKNOWN IMAGE FORMAT")
                Exit Sub
            End If
            arrImage = memStream.GetBuffer()
            'NEED TO PASS THE NEW RESOURCE ID HERE: Max(ResourceID) perhaps ???

            If myDAL.UpdateTableWithImage(frmMain.myConnString, "tblLog", "LogID", LogFields.LogID, "Image", memStream, arrImage, "ImageSize") Then
                MsgBox("OK PICTURE SAVED")
            Else
                MsgBox("PICTURE NOT SAVED")
            End If
        End If

    End Sub

    Sub SaveDefaults()
        Dim strDefaults As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim UpdatedOK As Boolean = False
        Dim strIDs As String
        Dim strAccountID As String
        Dim strSystemID As String
        Dim strSysNewName As String
        Dim strSysOldname As String
        Dim strPlanetID As String
        Dim strPlanetNewName As String
        Dim strPlanetoldname As String
        Dim strAreaID As String
        Dim strAreaName As String
        Dim strBaseID As String
        Dim strBaseName As String
        Dim strAreaLongitude As String
        Dim strAreaLatitude As String
        Dim strUserID As String

        strDefaults = ""
        strIDs = ""
        If txtAccountID.Text = "" Or txtAccountID.Text = "0" Then
            'MsgBox("Please Select Account First...")
            'Exit Sub
        End If
        strUserID = txtUserID.Text
        strAccountID = txtAccountID.Text
        strSystemID = txtSystemID.Text
        strPlanetID = txtPlanetID.Text
        strAreaID = txtAreaID.Text
        strBaseID = txtBaseID.Text
        strAreaLongitude = txtAreaLongitude.Text
        strAreaLatitude = txtAreaLatitude.Text
        If strUserID = "" Then
            strUserID = "0"
        End If
        If strAccountID = "" Then
            strAccountID = "0"
        End If
        If strSystemID = "" Then
            strSystemID = "0"
        End If
        If strPlanetID = "" Then
            strPlanetID = "0"
        End If
        If strAreaID = "" Then
            strAreaID = "0"
        End If
        If strBaseID = "" Then
            strBaseID = "0"
        End If
        strSysNewName = txtCurrentSystem.Text
        strSysOldname = txtOriginalSystemName.Text
        strPlanetNewName = txtCurrentPlanet.Text
        strPlanetoldname = txtOriginalPlanetName.Text
        strAreaName = txtCurrentArea.Text

        strDefaults += strSysNewName & "|" & strSysOldname & "|" & strPlanetNewName & "|" & strPlanetoldname
        strDefaults += "|" & strAreaName & "|" & strAreaLongitude & "|" & strAreaLatitude
        strIDs += strUserID & ";" & strAccountID & ";" & strSystemID & ";" & strPlanetID & ";" & strAreaID & ";" & strBaseID
        UpdatedOK = DAL.UpdateDefaults(frmMain.myConnString, "tblLog", strDefaults, strIDs)
        If UpdatedOK Then
            MsgBox("OK PREFERENCES UPDATED OK")
        Else
            MsgBox("SOMETHING WENT WRONG!")
        End If


    End Sub

    Sub LoadDefaults()
        Dim strDefaults As String
        Dim strIDs As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim LoadedOK As Boolean = False
        Dim strAccountID As String
        Dim arrDefaults As String()
        Dim arrIDs As String()
        Dim UserID As Integer
        Dim AccountID As Integer
        Dim SystemID As Integer
        Dim PlanetID As Integer
        Dim AreaID As Integer
        Dim BaseID As Integer
        Dim strSystemNewName As String
        Dim strSystemOldName As String
        Dim strPlanetNewName As String
        Dim strPlanetOldName As String
        Dim strAreaName As String
        Dim strAreaLongitude As String
        Dim strAreaLatitude As String
        Dim dt As DataTable

        'strAccountID = txtAccountID.Text


        dt = DAL.GetDefaults(frmMain.myConnString, "tblLog", strAccountID, strDefaults)
        'Set each combo box
        'AccountsCombo, SystemCombo , PlanetCombo
        If strDefaults = "" Then
            Exit Sub
        End If
        strIDs = dt.Rows(0)("SavedIDs")
        arrDefaults = Split(strDefaults, "|")
        arrIDs = Split(strIDs, ";")

        txtUserID.Text = arrIDs(0)
        txtAccountID.Text = arrIDs(1)
        txtSystemID.Text = arrIDs(2)
        txtPlanetID.Text = arrIDs(3)
        txtAreaID.Text = arrIDs(4)
        txtBaseID.Text = arrIDs(5)
        UserID = CInt(arrIDs(0))
        AccountID = CInt(arrIDs(1))
        SystemID = CInt(arrIDs(2))
        PlanetID = CInt(arrIDs(3))
        AreaID = CInt(arrIDs(4))
        BaseID = CInt(arrIDs(5))
        comSystems.SelectedValue = SystemID
        comPlanets.SelectedValue = PlanetID
        comAreas.SelectedValue = AreaID
        comBases.SelectedValue = BaseID
        comAccounts.SelectedValue = AccountID
        txtCurrentSystem.Text = arrDefaults(0)
        txtOriginalSystemName.Text = arrDefaults(1)
        txtCurrentPlanet.Text = arrDefaults(2)
        txtOriginalPlanetName.Text = arrDefaults(3)
        txtCurrentArea.Text = arrDefaults(4)
        txtAreaLongitude.Text = arrDefaults(5)
        txtAreaLatitude.Text = arrDefaults(6)
        'BuildAccountCombo()
        'BuildSystemCombo(cbSelectOriginalNames.Checked, False)
        'BuildPlanetCombo(cbSelectOriginalNames.Checked, False)
        'BuildWaypointCombo(False)
        'BuildBaseCombo(cbSelectOriginalNames.Checked, False)

        'comAccounts.SelectedItem = AccountID
        'SelectAccount(False, AccountID)
        'comSystems.SelectedItem = SystemID
        'SelectSystem(False, SystemID)
        'comPlanets.SelectedItem = SystemID
        'SelectPlanet(False, PlanetID)

    End Sub

    Public Sub BuildAccountCombo()

        Dim dt As New DataTable
        Dim strSQL As String
        Dim strUserIDs As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim Accounts As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)

        strUserIDs = dal.GetCollaboratedUserIDs(frmMain.myConnString, "tblLog", frmMain.myUserID, 0, Accounts)
        If strUserIDs = "" Then
            strUserIDs = frmMain.myUserID
        End If
        Tablename = "tblAccounts"
        strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & strUserIDs & ")"
        strSQL += " ORDER BY AccountName"
        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        'dt.Select()
        comAccounts.DataSource = dt
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        Me.txtTotalAccounts.Text = CStr(NumRows)

        comAccounts.DataSource = dt
        comAccounts.ValueMember = "AccountID"
        comAccounts.DisplayMember = "AccountName"
        comAccounts.SelectedText = ""
        comAccounts.Text = ""

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub BuildSystemCombo(ByVal Original As Boolean, ByVal UserIDs As String, ByVal ThisAccount As Boolean,
                                strAccountIDs As String)

        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim strUserID As String
        Dim strBuildField As String

        strUserID = frmMain.myUserID
        Tablename = "tblSystems"
        'If Not Integer.TryParse(strUserID, intUserID) Then
        'intUserID = 0
        'End If
        If Original = True Then
            strBuildField = "OriginalSystemName"
        Else
            strBuildField = "RenamedSystemName"
        End If
        If ThisAccount Then
            strSQL = "SELECT * FROM " & Tablename & " WHERE AccountID in (" & strAccountIDs & ") AND UserID in (" & UserIDs & ")"
        Else
            strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & UserIDs & ")"
        End If

        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        'dt.Select()
        If NumRows = 0 Then
            Exit Sub
        End If
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        Me.txtTotalSystems.Text = CStr(NumRows)

        comSystems.DataSource = dt
        comSystems.ValueMember = "SystemID"
        comSystems.DisplayMember = strBuildField
        comSystems.SelectedText = ""
        comSystems.Text = ""

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub BuildPlanetCombo(ByVal Original As Boolean, ByVal UserIDs As String, ByVal ThisSystem As Boolean, ByVal strSystems As String, strAccounts As String)

        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim SystemID As Integer
        Dim strUserID As String
        Dim intUserID As Integer
        Dim strBuildField As String


        Tablename = "tblPlanets"
        If Original = True Then
            strBuildField = "OriginalPlanetName"
        Else
            strBuildField = "RenamedPlanetName"
        End If
        If ThisSystem Then
            strSQL = "SELECT * FROM " & Tablename & " WHERE SystemID in (" & strSystems & ")"
        Else
            strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & UserIDs & ")"
            If strAccounts <> "" Then
                strSQL = " AND AccountID in (" & strAccounts & ")"
            End If
        End If


        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        If NumRows = 0 Then
            Exit Sub
        End If
        'dt.Select()
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        Me.txtTotalPlanets.Text = CStr(NumRows)

        comPlanets.DataSource = dt
        comPlanets.ValueMember = "PlanetID"
        comPlanets.DisplayMember = strBuildField
        comPlanets.SelectedText = ""
        comPlanets.Text = ""

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub BuildWaypointCombo(ThisPlanet As Boolean)

        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim PlanetID As Integer
        Dim UserIDs As String
        Dim Accounts As String

        Tablename = "tblWaypoints"
        If Not Integer.TryParse(txtPlanetID.Text, PlanetID) Then
            PlanetID = 0
        End If
        UserIDs = dal.GetCollaboratedUserIDs(frmMain.myConnString, "tblLog", CInt(frmMain.myUserID), 0, Accounts)
        If ThisPlanet Then
            strSQL = "SELECT * FROM " & Tablename & " WHERE PlanetID=" & PlanetID
        Else
            strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & UserIDs & ")"
        End If

        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        If NumRows = 0 Then
            Exit Sub
        End If
        'dt.Select()
        comAreas.DataSource = dt
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        Me.txtTotalAreas.Text = CStr(NumRows)

        comAreas.DataSource = dt
        comAreas.ValueMember = "WeypointID"
        comAreas.DisplayMember = "WaypointName"
        comAreas.SelectedText = ""
        comAreas.Text = ""

        dal = Nothing
        dt = Nothing
    End Sub

    Sub BuildBaseCombo(Optional ByVal Original As Boolean = True, Optional ByVal ThisPlanet As Boolean = False)
        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim PlanetID As Integer
        Dim strBuildField As String
        Dim UserIDs As String
        Dim Accounts As String

        Tablename = "tblBases"
        If Not Integer.TryParse(txtPlanetID.Text, PlanetID) Then
            PlanetID = 0
        End If
        If Original = True Then
            strBuildField = "OriginalBaseName"
        Else
            strBuildField = "RenamedBaseName"
        End If
        UserIDs = dal.GetCollaboratedUserIDs(frmMain.myConnString, "tblLog", CInt(frmMain.myUserID), 0, Accounts)
        If ThisPlanet Then
            strSQL = "SELECT * FROM " & Tablename & " WHERE PlanetID=" & PlanetID
        Else
            strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & UserIDs & ")"
        End If

        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        If NumRows = 0 Then
            Exit Sub
        End If
        'dt.Select()
        comBases.DataSource = dt
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        'Me.txtTotalAreas.Text = CStr(NumRows)

        comBases.DataSource = dt
        comBases.ValueMember = "BaseID"
        comBases.DisplayMember = strBuildField
        comBases.SelectedText = ""
        comBases.Text = ""

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub SelectAccount(DefaultAccount As Boolean, SelectedItem As Object)
        Dim dt As DataTable
        Dim AccountID As String
        Dim GamePlatform As String
        Dim AccountName As String
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
        Dim SortFields As String = ""
        Dim FoundDefault As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String = Nothing
        Dim ErrMessage As String = ""
        Dim DBTable As String = "tblAccounts"
        Dim NumRows As Integer = 0
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strUnitInfo As String
        Dim arrUnitInfo() As String

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        dt = comAccounts.DataSource

        'AccountName = comAccounts.SelectedText

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
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("GamePlatform")) Then
                    GamePlatform = DirectCast(SelectedItem, DataRowView).Item("GamePlatform")
                Else
                    GamePlatform = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("GameVersion")) Then
                    GameVersion = DirectCast(SelectedItem, DataRowView).Item("GameVersion")
                Else
                    GameVersion = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("GameVersion").ToString) Then
                    GamerHandle = DirectCast(SelectedItem, DataRowView).Item("GamerHandle").ToString
                Else
                    GamerHandle = "UNKNOWN"
                End If
            End If
            txtTotalAccounts.Text = CStr(dt.Rows.Count)
        End If

        If DefaultAccount Then
            'SET DEFAULT:
            SearchText = "DEFAULT"
            SearchField = "DefaultAccount"
            ReturnField = "AccountID"
            FieldType = "STRING"

            FoundDefault = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                            SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
            If FoundDefault And DefaultAccount Then
                AccountID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountID")
                GamerHandle = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamerHandle")
                AccountName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountName")
                GamePlatform = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamePlatform")
                GameVersion = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GameVersion")
            End If
        End If

        Me.txtAccountID.Text = AccountID
        Me.txtAccountName.Text = AccountName
        Me.txtPlatform.Text = GamePlatform
        Me.txtVersion.Text = GameVersion
        Me.txtGamerHandle.Text = GamerHandle
        Me.txtUserID.Text = frmMain.myUserID

        'Need to load in the UNITS from tblUnits:
        strUnitInfo = myDAL.GetUnits(frmMain.myConnString, AccountID)
        If strUnitInfo <> "" Then
            arrUnitInfo = Split(strUnitInfo, ";")
            If arrUnitInfo(0) = "" Then
                MsgBox("Problem getting Unit info")
                Exit Sub
            End If
            txtNanites.Text = arrUnitInfo(0)
            txtUnits.Text = arrUnitInfo(1)
            txtQuicksilver.Text = arrUnitInfo(2)
            txtFrigateModules.Text = arrUnitInfo(3)
            txtSalvagedData.Text = arrUnitInfo(4)
            txtLastSaved.Text = arrUnitInfo(5)
        End If

    End Sub

    Public Sub SelectSystem(DefaultSystem As Boolean, SelectedItem As Object)
        Dim dt As DataTable
        Dim SystemID As String
        Dim GamePlatform As String
        Dim SystemName As String
        Dim altSystemName As String
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
        Dim SortFields As String = ""
        Dim FoundDefault As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String = Nothing
        Dim ErrMessage As String = ""
        Dim DBTable As String = "tblSystems"
        Dim NumRows As Integer = 0
        Dim intSystemID As Integer
        Dim GalacticRegion As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSelectedField As String
        Dim UserIDs As String
        Dim Accounts As String

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        dt = comSystems.DataSource
        'AccountName = comAccounts.SelectedText
        If cbSelectOriginalNames.Checked = True Then
            strSelectedField = "OriginalSystemName"
        Else
            strSelectedField = "RenamedSystemName"
        End If
        If dt.Rows.Count > 0 Then
            If SelectedItem IsNot Nothing Then
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item(strSelectedField)) Then
                    SystemName = DirectCast(SelectedItem, DataRowView).Item(strSelectedField).ToString
                Else
                    SystemName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("RenamedSystemName")) Then
                    altSystemName = DirectCast(SelectedItem, DataRowView).Item("RenamedSystemName").ToString
                Else
                    altSystemName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("SystemID")) Then
                    SystemID = DirectCast(SelectedItem, DataRowView).Item("SystemID").ToString
                Else
                    SystemID = "0"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("GalacticRegion")) Then
                    GalacticRegion = DirectCast(SelectedItem, DataRowView).Item("GalacticRegion")
                Else
                    GalacticRegion = "UNKNOWN"
                End If

            End If

        End If

        If DefaultSystem Then
            SearchText = "DEFAULT"
            SearchField = "DefaultSystem"
            ReturnField = "SystemID"
            FieldType = "STRING"
            'SET DISCOVERED BY:
            FoundDefault = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                            SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
            If FoundDefault And DefaultSystem Then
                SystemID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "SystemID")
                SystemName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, strSelectedField)
                altSystemName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "RenamedSystemName")
                GalacticRegion = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GalacticRegion")
            Else
                'MsgBox("Default System NOT found")
            End If
        End If

        Me.txtSystemID.Text = SystemID
        Me.txtCurrentSystem.Text = SystemName
        Me.txtOriginalSystemName.Text = altSystemName
        Me.txtGalacticRegion.Text = GalacticRegion

        'Build the planet combo based on the system choice:
        UserIDs = myDAL.GetCollaboratedUserIDs(frmMain.myConnString, "tblLog", CInt(frmMain.myUserID), 0, Accounts)
        BuildPlanetCombo(cbSelectOriginalNames.Checked, UserIDs, cbThisSystemOnly.Checked, SystemID, Accounts)
    End Sub

    Public Sub SelectPlanet(DefaultPlanet As Boolean, SelectedItem As Object)
        Dim dt As DataTable
        Dim PlanetID As String
        Dim PlanetName As String
        Dim altPlanetName As String
        Dim SystemName As String
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
        Dim SortFields As String = ""
        Dim FoundDefault As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String = Nothing
        Dim ErrMessage As String = ""
        Dim DBTable As String = "tblPlanets"
        Dim NumRows As Integer = 0
        Dim intSystemID As Integer
        Dim GalacticRegion As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSelectedField As String
        Dim UserIDs As String
        Dim Accounts As String

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        dt = comPlanets.DataSource
        If cbSelectOriginalNames.Checked = True Then
            strSelectedField = "OriginalPlanetName"
        Else
            strSelectedField = "RenamedPlanetName"
        End If
        'AccountName = comAccounts.SelectedText

        If dt.Rows.Count > 0 Then
            If SelectedItem IsNot Nothing Then
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item(strSelectedField)) Then
                    PlanetName = DirectCast(SelectedItem, DataRowView).Item(strSelectedField).ToString
                Else
                    PlanetName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("RenamedPlanetName")) Then
                    altPlanetName = DirectCast(SelectedItem, DataRowView).Item("RenamedPlanetName").ToString
                Else
                    altPlanetName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("PlanetID")) Then
                    PlanetID = DirectCast(SelectedItem, DataRowView).Item("PlanetID").ToString
                Else
                    PlanetID = "0"
                End If

            End If

        End If
        If DefaultPlanet Then
            SearchText = "DEFAULT"
            SearchField = "DefaultPlanet"
            ReturnField = "PlanetID"
            FieldType = "STRING"
            'SET DISCOVERED BY:
            FoundDefault = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                            SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
            If FoundDefault And DefaultPlanet Then
                PlanetID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "PlanetID")
                PlanetName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, strSelectedField)
                altPlanetName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "RenamedPlanetName")
            Else
                'MsgBox("Default Planet NOT found")
            End If
        End If

        Me.txtPlanetID.Text = PlanetID
        Me.txtCurrentPlanet.Text = PlanetName
        Me.txtOriginalPlanetName.Text = altPlanetName

        'Build AREA / WAYPOINT and BASE combos on the choice of planet:
        UserIDs = myDAL.GetCollaboratedUserIDs(frmMain.myConnString, "tblLog", CInt(frmMain.myUserID), 0, Accounts)
        BuildWaypointCombo(cbThisPlanetOnly.Checked)
        BuildBaseCombo(cbSelectOriginalNames.Checked, cbThisPlanetOnly.Checked)

    End Sub

    Public Sub SelectArea(DefaultArea As Boolean, SelectedItem As Object)
        Dim dt As DataTable
        Dim WeypointID As String
        Dim WaypointName As String
        Dim AreaLat As String
        Dim AreaLong As String
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
        Dim SortFields As String = ""
        Dim FoundDefault As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String = Nothing
        Dim ErrMessage As String = ""
        Dim DBTable As String = "tblSystems"
        Dim NumRows As Integer = 0
        Dim GalacticRegion As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSelectedField As String

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        dt = comAreas.DataSource
        'AccountName = comAccounts.SelectedText
        If dt.Rows.Count > 0 Then
            If SelectedItem IsNot Nothing Then
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("WaypointName")) Then
                    WaypointName = DirectCast(SelectedItem, DataRowView).Item("WaypointName").ToString
                Else
                    WaypointName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("WeypointID")) Then
                    WeypointID = DirectCast(SelectedItem, DataRowView).Item("WeypointID").ToString
                Else
                    WeypointID = "0"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("WaypointLatCoords")) Then
                    AreaLat = DirectCast(SelectedItem, DataRowView).Item("WaypointLatCoords").ToString
                Else
                    AreaLat = "()"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("WaypointLongCoords")) Then
                    AreaLong = DirectCast(SelectedItem, DataRowView).Item("WaypointLongCoords").ToString
                Else
                    AreaLong = "()"
                End If
            End If

        End If

        If DefaultArea Then
            SearchText = "DEFAULT"
            SearchField = "DefaultSystem"
            ReturnField = "SystemID"
            FieldType = "STRING"
            'SET DISCOVERED BY:
            FoundDefault = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                            SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
            If FoundDefault And DefaultArea Then
                WeypointID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "WeypointID")
                WaypointName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "WaypointName")
                AreaLong = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "WaypointLongCoords")
                AreaLat = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "WaypointLatCoords")
            Else
                'MsgBox("Default System NOT found")
            End If
        End If

        Me.txtAreaID.Text = WeypointID
        Me.txtCurrentArea.Text = WaypointName
        Me.txtAreaLongitude.Text = AreaLong
        Me.txtAreaLatitude.Text = AreaLat
    End Sub

    Sub SelectBase(DefaultBase As Boolean, SelectedItem As Object)
        Dim dt As DataTable
        Dim BaseID As String
        Dim BAseName As String
        Dim altBaseName As String
        Dim BaseLong As String
        Dim BaseLat As String
        Dim ErrMessages As String = ""
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        Dim FieldType As String
        Dim Reversed As Boolean = True
        Dim SortFields As String = ""
        Dim FoundDefault As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String = Nothing
        Dim ErrMessage As String = ""
        Dim DBTable As String = "tblBases"
        Dim NumRows As Integer = 0
        Dim intSystemID As Integer
        Dim GalacticRegion As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSelectedField As String

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        dt = comBases.DataSource
        'AccountName = comAccounts.SelectedText
        If cbSelectOriginalNames.Checked = True Then
            strSelectedField = "OriginalBaseName"
        Else
            strSelectedField = "RenamedBaseName"
        End If
        If dt.Rows.Count > 0 Then
            If SelectedItem IsNot Nothing Then
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item(strSelectedField)) Then
                    BAseName = DirectCast(SelectedItem, DataRowView).Item(strSelectedField).ToString
                Else
                    BAseName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("RenamedBaseName")) Then
                    altBaseName = DirectCast(SelectedItem, DataRowView).Item("RenamedBaseName").ToString
                Else
                    altBaseName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("BaseID")) Then
                    BaseID = DirectCast(SelectedItem, DataRowView).Item("BaseID").ToString
                Else
                    BaseID = "0"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("BaseLongitude")) Then
                    BaseLong = DirectCast(SelectedItem, DataRowView).Item("BaseLongitude").ToString
                Else
                    BaseLong = "()"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("BaseLatitude")) Then
                    BaseLat = DirectCast(SelectedItem, DataRowView).Item("BaseLatitude").ToString
                Else
                    BaseLat = "()"
                End If
            End If

        End If

        If DefaultBase Then
            'SET DEFAULT:
            SearchText = "DEFAULT"
            SearchField = "DefaultBase"
            ReturnField = "BaseID"
            FieldType = "STRING"
            DBTable = "tblBases"
            FoundDefault = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                            SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
            If FoundDefault And DefaultBase Then
                BaseID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "BaseID")
                BAseName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, strSelectedField)
                BaseLong = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "BaseLongitude")
                BaseLat = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "BaseLatitude")
            Else
                'MsgBox("Default Base NOT found")
            End If
        End If

        Me.txtCurrentArea.Text = BAseName
        Me.txtAreaLatitude.Text = BaseLat
        Me.txtAreaLongitude.Text = BaseLong
        Me.txtBaseID.Text = BaseID
    End Sub

    Sub Save_Log_Entry()
        'SAVE LOG ENTRY
        Dim strCurrentDate As String
        Dim strLogID As String
        Dim strAccountID As String
        Dim strAccountName As String
        Dim strPlatform As String
        Dim strVersion As String
        Dim strEntryTime As String
        Dim strCurrentPosition As String
        Dim strSystemName As String
        Dim strSystemID As String
        Dim strPlanetName As String
        Dim strCurrentArea As String
        Dim strGalacticRegion As String
        Dim strCurrentNanites As String
        Dim strCurrentUnits As String
        Dim strCurrentQS As String
        Dim strCurrentFM As String
        Dim strCurrentSD As String
        Dim strBrief As String
        Dim strComment1 As String
        Dim strComment2 As String
        Dim strAccountLinkID As String
        Dim LogFile As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strNewSystemName As String
        Dim strNewPlanetName As String

        strAccountLinkID = frmMain.myUserID
        strLogID = Me.txtLogID.Text
        strAccountID = Me.txtAccountID.Text
        strAccountName = Me.txtAccountName.Text
        strPlatform = Me.txtPlatform.Text
        strVersion = Me.txtVersion.Text
        strEntryTime = Me.txtEntryDate.Text
        strCurrentPosition = Me.txtAreaLongitude.Text & " " & Me.txtAreaLatitude.Text
        strSystemName = Me.txtCurrentSystem.Text
        strNewSystemName = Me.txtOriginalSystemName.Text
        strSystemID = Me.txtSystemID.Text
        strPlanetName = Me.txtCurrentPlanet.Text
        strNewPlanetName = Me.txtOriginalPlanetName.Text
        strCurrentArea = Me.txtCurrentArea.Text
        strGalacticRegion = Me.txtGalacticRegion.Text
        strCurrentNanites = Me.txtNanites.Text
        strCurrentUnits = Me.txtUnits.Text
        strCurrentQS = Me.txtQuicksilver.Text
        strCurrentFM = Me.txtFrigateModules.Text
        strCurrentSD = Me.txtSalvagedData.Text
        strBrief = Me.txtBrief.Text
        strComment1 = Me.rtbComment.Rtf
        strComment2 = Me.rtbFurtherComment.Rtf
        LogFile = "NMS_LOG_UPDATE"

        Save_LOG(True, strLogID)
        myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strLogID, "RTFComment1", Me.rtbComment)
        myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strLogID, "RTFComment2", Me.rtbFurtherComment)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnInsertCurrentTime_Click(sender As Object, e As EventArgs)
        Dim dtNow As DateTime
        Dim strNow As String

        dtNow = Now()
        strNow = dtNow.ToString("dd/MMM/yyyy HH:mm:ss")
        Me.txtEntryDate.Text = strNow
    End Sub

    Sub Show_Log_entry()
        'SETUP FORM HERE as soon as it opens:
        'Populate Accounts Dropdown:
        'use MySQLToArray()
        Dim UseOriginal As Boolean

        UseOriginal = cbUseOriginalNames.Checked
        'User Selects an Account:
        BuildAccountCombo()
        'The User selects an account: builds the systems based on that account - and collaborated userids.
        'BuildSystemCombo(UseOriginal, cbThisAccountOnly.Checked)
        'After the user Chooses a system - then the planet combo can be built based upon that choice:
        'BuildPlanetCombo(UseOriginal, cbThisSystemOnly.Checked)
        'Finally after the planet has been chosen - BOTH Waypoint (AREA) and BASE Combos can be built....
        'BuildWaypointCombo(cbThisPlanetOnly.Checked)
        'BuildBaseCombo(UseOriginal, cbThisPlanetOnly.Checked)
        ClearTextboxAndCombos(False)
        PopulateLogEntry(Me.strLOGID, False, False)

        'Need to get length of 
    End Sub

    Private Sub comAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAccounts.SelectedIndexChanged
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strAccountID As String
        Dim UserIDs As String
        Dim CollabAccounts As String

        SelectAccount(False, comAccounts.SelectedItem)
        strAccountID = txtAccountID.Text
        UserIDs = myDAL.GetCollaboratedUserIDs(frmMain.myConnString, "tblLog", CInt(frmMain.myUserID), 0, CollabAccounts)
        If strAccountID <> "" Then
            BuildSystemCombo(cbUseOriginalNames.Checked, UserIDs, cbThisAccountOnly.Checked, strAccountID)
            'CAll the planet combo AFTER a system has been selected - perhaps ???
            'BuildPlanetCombo(cbUseOriginalNames.Checked, cbThisSystemOnly.Checked)

        End If
    End Sub

    Private Sub comAccounts_Click(sender As Object, e As EventArgs) Handles comAccounts.Click
        'SelectAccount(False, comAccounts.SelectedItem)
    End Sub

    Private Sub txtAccount_TextChanged(sender As Object, e As EventArgs)
        'TEST entry - SEARCH in tblAccounts for a match: if yes - fill in the other fields
        'SelectAccount(False, comAccounts.SelectedItem)

    End Sub

    Private Sub comAccounts_Click_1(sender As Object, e As EventArgs)
        'Me.txtAccountName.Text = Me.comAccounts.Text
    End Sub

    Private Sub comAccounts_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        'Me.txtAccount.Text = Me.comAccounts.Text


    End Sub

    Private Sub comSystems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSystems.SelectedIndexChanged
        SelectSystem(False, comSystems.SelectedItem)

    End Sub

    Public Sub PopulateLogEntry(LogID As String, SetDefaultSystem As Boolean, IsCopy As Boolean)
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim FieldType As String
        Dim Reversed As Boolean
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim SearchCriteria As String
        Dim DBTable As String
        Dim FoundAccount As Boolean = False
        Dim FoundLog As Boolean = False
        Dim FoundSystem As Boolean = False
        Dim AllFields As String()
        Dim AllValues As Object()
        Dim ErrMessage As String
        Dim strAccountName As String
        Dim strPlatform As String
        Dim strVersion As String
        Dim strGamerHandle As String
        Dim strCurrentSystem As String
        Dim strNewSystemName As String
        Dim strOriginalSystemName As String
        Dim strGalacticRegion As String
        Dim strDefaultSystem As String
        Dim strLogID As String
        Dim strUserID As String
        Dim strSystemID As String
        Dim strAccountID As String
        Dim strPlanetID As String
        Dim strTotalAccounts As String
        Dim strTotalSystems As String
        Dim strCurrentDatetime As String
        Dim strCurrentPosition As String
        Dim strTotalPlanets As String
        Dim strCurrentPlanet As String
        Dim strOriginalPlanetName As String
        Dim strNewPlanetName As String
        Dim strTotalAreas As String
        Dim strCurrentArea As String
        Dim strCoords As String
        Dim strEntryDate As String
        Dim strNanites As String
        Dim strUnits As String
        Dim strQuicksilver As String
        Dim strFrigateModules As String
        Dim strSalvagedData As String
        Dim strBrief As String
        Dim strComment1 As String
        Dim strComment2 As String
        Dim strRTBComment As String
        Dim strFurtherComment As String
        Dim strLastSaved As String
        Dim strImageFilename As String
        Dim ImageExt As String
        Dim ImageSize As String
        Dim dblImageSizeKilobytes As Double
        Dim ImageByte() As Byte
        Dim strLongitude As String
        Dim strLatitude As String
        Dim arrCoords() As String
        Dim PicLoadOK As Boolean = False
        Dim memStream As IO.MemoryStream
        Dim strLogLastSaved As String

        SearchText = LogID
        SearchField = "LogID"
        ReturnField = "LogID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = False
        SortFields = "LogID"
        ExcludeFields = ""
        strLogLastSaved = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        DBTable = "tblLog"
        FoundLog = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundLog Then
            strLogID = GetValuebyFieldname(AllValues, AllFields, "LogID")
            strUserID = GetValuebyFieldname(AllValues, AllFields, "UserID")
            strAccountID = GetValuebyFieldname(AllValues, AllFields, "AccountID")
            strAccountName = GetValuebyFieldname(AllValues, AllFields, "AccountName")
            strPlatform = GetValuebyFieldname(AllValues, AllFields, "Platform")
            strVersion = GetValuebyFieldname(AllValues, AllFields, "Version")
            strGamerHandle = GetValuebyFieldname(AllValues, AllFields, "GamerHandle")
            strSystemID = GetValuebyFieldname(AllValues, AllFields, "SystemID")
            strPlanetID = GetValuebyFieldname(AllValues, AllFields, "PlanetID")
            strCurrentDatetime = GetValuebyFieldname(AllValues, AllFields, "CurrentDateTime")
            strCoords = GetValuebyFieldname(AllValues, AllFields, "CurrentPosition")
            strGalacticRegion = GetValuebyFieldname(AllValues, AllFields, "CurrentGalacticRegion")
            strCurrentSystem = GetValuebyFieldname(AllValues, AllFields, "CurrentStarSystem")
            strOriginalSystemName = GetValuebyFieldname(AllValues, AllFields, "OriginalSystemName")
            strCurrentPlanet = GetValuebyFieldname(AllValues, AllFields, "CurrentPlanet")
            strOriginalPlanetName = GetValuebyFieldname(AllValues, AllFields, "OriginalPlanetName")
            strCurrentArea = GetValuebyFieldname(AllValues, AllFields, "CurrentPlanetArea")
            strNanites = GetValuebyFieldname(AllValues, AllFields, "CurrentNanites")
            strUnits = GetValuebyFieldname(AllValues, AllFields, "CurrentUnits")
            strQuicksilver = GetValuebyFieldname(AllValues, AllFields, "CurrentQuickSilver")
            strFrigateModules = GetValuebyFieldname(AllValues, AllFields, "CurrentFrigateModules")
            strSalvagedData = GetValuebyFieldname(AllValues, AllFields, "CurrentSalvagedData")
            strBrief = GetValuebyFieldname(AllValues, AllFields, "Brief")
            strComment1 = GetValuebyFieldname(AllValues, AllFields, "Comment1")
            strComment2 = GetValuebyFieldname(AllValues, AllFields, "Comment2")
            strLastSaved = GetValuebyFieldname(AllValues, AllFields, "LastSaved")
            ImageExt = GetValuebyFieldname(AllValues, AllFields, "ImageExt")
            ImageSize = GetValuebyFieldname(AllValues, AllFields, "ImageSize")
            strFurtherComment = ""
            myDAL.LoadRTFControl_memStream(frmMain.myConnString, "tblLog", "RTFComment1", "LogID", LogID, rtbComment, strComment1)
            myDAL.LoadRTFControl_memStream(frmMain.myConnString, "tblLog", "RTFComment2", "LogID", LogID, rtbFurtherComment, strFurtherComment)
            ImageByte = Nothing
            PicLoadOK = myDAL.Get_Pic_From_DB(frmMain.myConnString, "tblLog", "Image", "LogID", strLogID, ImageByte)
            If PicLoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pb1.BackgroundImage = Image.FromStream(memStream)
                strImageFilename = pb1.ImageLocation
                dblImageSizeKilobytes = memStream.Length / 1024
                pb1.Tag = strImageFilename
                txtImageFilename.Text = strImageFilename
                txtImageSize.Text = CStr(dblImageSizeKilobytes)

            End If

            txtUserID.Text = strUserID
            txtLogID.Text = strLogID
            txtAccountID.Text = strAccountID
            txtAccountName.Text = strAccountName
            txtPlatform.Text = strPlatform
            txtGamerHandle.Text = strGamerHandle
            txtVersion.Text = strVersion
            txtSystemID.Text = strSystemID
            txtCurrentSystem.Text = strCurrentSystem
            txtOriginalSystemName.Text = strOriginalSystemName
            txtCurrentPlanet.Text = strCurrentPlanet
            txtOriginalPlanetName.Text = strOriginalPlanetName
            txtPlanetID.Text = strPlanetID
            If IsDate(strCurrentDatetime) Then
                txtEntryDate.Text = CDate(strCurrentDatetime).ToString("dd/MM/yyyy HH:mm:ss")
            End If
            If IsDate(strLastSaved) Then
                txtLogLastSaved.Text = CDate(strLastSaved).ToString("dd/MM/yyyy HH:mm:ss")
            End If
            arrCoords = Split(strCoords, " ")
            If arrCoords.Length < 2 Then
                strLongitude = arrCoords(0)
                strLatitude = "(0.0)"
            Else
                strLongitude = arrCoords(0)
                strLatitude = arrCoords(1)
            End If
            txtAreaLongitude.Text = strLongitude
            txtAreaLatitude.Text = strLatitude
            Me.txtUnits.Text = Format(strUnits, "currency")
            Me.txtNanites.Text = Format(strNanites, "standard")
            Me.txtQuicksilver.Text = Format(strQuicksilver, "standard")
            Me.txtFrigateModules.Text = Format(strFrigateModules, "standard")
            Me.txtSalvagedData.Text = Format(strSalvagedData, "standard")
            Me.txtGalacticRegion.Text = strGalacticRegion
            Me.txtCurrentSystem.Text = strCurrentSystem
            Me.txtCurrentPlanet.Text = strCurrentPlanet
            Me.txtCurrentArea.Text = strCurrentArea
            Me.txtBrief.Text = strBrief
            Me.lblBrief.Text = "Brief: " & Len(strBrief) & "/" & "4096 Characters"
            Me.lblComment1.Text = "Comment1: " & Len(strComment1) & "/" & "4096 Characters"
            Me.lblComment2.Text = "Comment2: " & Len(strComment2) & "/" & "4096 Characters"
        Else
            btnClear.PerformClick()
            'Auto-select Account default if available:
            If Me.SelectedAccountID > 0 Then
                comAccounts.SelectedValue = Me.SelectedAccountID
            End If
        End If
        If IsCopy Then
            txtLogID.Text = "0"
            Me.strLOGID = "0"
        End If
        'comSystems.SelectedValue = CInt(strSystemID)
        'comPlanets.SelectedValue = CInt(strPlanetID)

    End Sub


    Private Sub btnSubtractNanites_Click(sender As Object, e As EventArgs) Handles btnSubtractNanites.Click
        'Subtract Nanites by the specified amount in the input box
        Dim ulngCurrentNanites As ULong
        Dim strCurrentNanites As String
        Dim strAmount As String
        Dim ulngAmount As ULong
        Dim FinalAmount As ULong

        ulngCurrentNanites = 0
        ulngAmount = 0
        strCurrentNanites = txtNanites.Text
        If IsNumeric(strCurrentNanites) Then
            ulngCurrentNanites = CULng(strCurrentNanites)
        Else
            MsgBox("Current Nanites Value NOT VALID")
            Exit Sub
        End If
        strAmount = InputBox("Reduce Nanites by specific amount:", "Reduce Nanites")
        If IsNumeric(strAmount) Then
            ulngAmount = CULng(strAmount)
        Else
            MsgBox("Invalid Amount: " & Len(strAmount))
            Exit Sub
        End If
        If ulngCurrentNanites > 0 And ulngAmount <= ulngCurrentNanites Then
            FinalAmount = ulngCurrentNanites - ulngAmount
        End If

        If FinalAmount > 0 Then
            txtNanites.Text = CStr(FinalAmount)
        End If
        'how to format the string again into commas ?


    End Sub

    Private Sub btnAddNanites_Click(sender As Object, e As EventArgs) Handles btnAddNanites.Click
        'ADD NANITES to current amount:
        Dim ulngCurrentNanites As ULong
        Dim strCurrentNanites As String
        Dim strAmount As String
        Dim ulngAmount As ULong
        Dim FinalAmount As ULong

        ulngCurrentNanites = 0
        ulngAmount = 0
        strCurrentNanites = txtNanites.Text
        If IsNumeric(strCurrentNanites) Then
            ulngCurrentNanites = CULng(strCurrentNanites)
        Else
            MsgBox("Current Nanites Value NOT VALID")
            Exit Sub
        End If
        strAmount = InputBox("Increase Nanites by specific amount:", "Increase Nanites")
        If IsNumeric(strAmount) Then
            ulngAmount = CULng(strAmount)
        Else
            MsgBox("Invalid Amount: " & Len(strAmount))
            Exit Sub
        End If
        FinalAmount = ulngCurrentNanites + ulngAmount

        txtNanites.Text = CStr(FinalAmount)
    End Sub

    Private Sub btnSubtractUnits_Click(sender As Object, e As EventArgs) Handles btnSubtractUnits.Click
        'Subtact specified amount from current units:
        Dim ulngCurrentUnits As ULong
        Dim strCurrentUnits As String
        Dim strAmount As String
        Dim ulngAmount As ULong
        Dim FinalAmount As ULong

        ulngCurrentUnits = 0
        ulngAmount = 0
        strCurrentUnits = txtUnits.Text
        If IsNumeric(strCurrentUnits) Then
            ulngCurrentUnits = CULng(strCurrentUnits)
        Else
            MsgBox("Current Units Value NOT VALID")
            Exit Sub
        End If
        strAmount = InputBox("Reduce Units by specific amount:", "50")
        If IsNumeric(strAmount) Then
            ulngAmount = CULng(strAmount)
        Else
            MsgBox("Invalid Amount: " & Len(strAmount))
            Exit Sub
        End If
        If ulngCurrentUnits > 0 And ulngAmount <= ulngCurrentUnits Then
            FinalAmount = ulngCurrentUnits - ulngAmount
        End If

        If FinalAmount > 0 Then
            txtUnits.Text = CStr(FinalAmount)
        End If

    End Sub

    Private Sub btnAddUnits_Click(sender As Object, e As EventArgs) Handles btnAddUnits.Click
        'ADD UNITS to current amount:
        Dim ulngCurrentUnits As ULong
        Dim strCurrentUnits As String
        Dim strAmount As String
        Dim ulngAmount As ULong
        Dim FinalAmount As ULong

        ulngCurrentUnits = 0
        ulngAmount = 0
        strCurrentUnits = txtUnits.Text
        If IsNumeric(strCurrentUnits) Then
            ulngCurrentUnits = CULng(strCurrentUnits)
        Else
            MsgBox("Current Units Value NOT VALID")
            Exit Sub
        End If
        strAmount = InputBox("Increase Units by specific amount:", "Increase Units")
        If IsNumeric(strAmount) Then
            ulngAmount = CULng(strAmount)
        Else
            MsgBox("Invalid Amount: " & Len(strAmount))
            Exit Sub
        End If
        FinalAmount = ulngCurrentUnits + ulngAmount
        txtUnits.Text = CStr(FinalAmount)
    End Sub

    Private Sub btnSubtractQuicksilver_Click(sender As Object, e As EventArgs) Handles btnSubtractQuicksilver.Click
        '
        Dim ulngCurrentQS As ULong
        Dim strCurrentQS As String
        Dim strAmount As String
        Dim ulngAmount As ULong
        Dim FinalAmount As ULong

        ulngCurrentQS = 0
        ulngAmount = 0
        strCurrentQS = txtQuicksilver.Text
        If IsNumeric(strCurrentQS) Then
            ulngCurrentQS = CInt(strCurrentQS)
        Else
            MsgBox("Current Quicksilver Value NOT VALID")
            Exit Sub
        End If
        strAmount = InputBox("Reduce Quicksilver by specific amount:", "Reduce Quicksilver")
        If IsNumeric(strAmount) Then
            ulngAmount = CInt(strAmount)
        Else
            MsgBox("Invalid Amount: " & Len(strAmount))
            Exit Sub
        End If
        If ulngCurrentQS > 0 And ulngAmount <= ulngCurrentQS Then
            FinalAmount = ulngCurrentQS - ulngAmount
        End If

        If FinalAmount > 0 Then
            txtQuicksilver.Text = CStr(FinalAmount)
        End If

    End Sub

    Private Sub btnAddQuicksilver_Click(sender As Object, e As EventArgs) Handles btnAddQuicksilver.Click
        '
        Dim ulngCurrentQS As ULong
        Dim strCurrentQS As String
        Dim strAmount As String
        Dim ulngAmount As ULong
        Dim FinalAmount As ULong

        ulngCurrentQS = 0
        ulngAmount = 0
        strCurrentQS = txtQuicksilver.Text
        If IsNumeric(strCurrentQS) Then
            ulngCurrentQS = CULng(strCurrentQS)
        Else
            MsgBox("Current Quicksilver Value NOT VALID")
            Exit Sub
        End If
        strAmount = InputBox("Increase Quicksilver by specific amount:", "Increase Quicksilver")
        If IsNumeric(strAmount) Then
            ulngAmount = CULng(strAmount)
        Else
            MsgBox("Invalid Amount: " & Len(strAmount))
            Exit Sub
        End If
        FinalAmount = ulngCurrentQS + ulngAmount
        txtQuicksilver.Text = CStr(FinalAmount)
    End Sub

    Public Function GetLOGRecsFromCSVFile(Optional ConfirmALL As Boolean = False,
                                          Optional ByVal IncludeVerboseInUpdateMessage As Boolean = True) As Long
        Dim csvDialog As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String
        Dim csvFileArr(,) As String
        Dim TotalFields As Long
        Dim NumRecs As Long
        Dim Message As String
        Dim TotalRecsImported As Long
        Dim TotalRecsUpdated As Long
        Dim RowNum As Long
        Dim strAccountID As String
        Dim strSystemID As String
        Dim strSystemLastUpdated As String
        Dim strPlanetID As String
        Dim strPlanetLastUpdated As String
        Dim strAccountName As String
        Dim strEntryDate As String
        Dim strSystemName As String
        Dim strPlanetName As String
        Dim strAreaName As String
        Dim strNanites As String
        Dim strUnits As String
        Dim strQS As String
        Dim strFM As String
        Dim strSD As String
        Dim strBrief As String
        Dim strComment1 As String
        Dim strComment2 As String
        Dim strAccountLinkID As String
        Dim strDBDateTime As String
        Dim dtDBDateTime As DateTime
        Dim dtEntryDate As DateTime
        Dim strDBLogID As String
        Dim strDBUserID As String
        Dim strDBAccountID As String
        Dim strDBAccountName As String
        Dim strDBPlatform As String
        Dim strDBVersion As String
        Dim strDBGamerHandle As String
        Dim strDBSystemID As String
        Dim strDBPlanetID As String
        Dim strDBGalacticRegion As String
        Dim strDBCurrentPlanet As String
        Dim strDBCurrentSystem As String
        Dim strDBArea As String
        Dim strDBNanites As String
        Dim strDBUnits As String
        Dim strDBQuickSilver As String
        Dim strDBFrigateModules As String
        Dim strDBSalvagedData As String
        Dim strDBBrief As String
        Dim strDBComment1 As String
        Dim strDBComment2 As String
        Dim strDBLastSaved As String
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
        Dim SortFields As String = ""
        Dim DBTable As String = "tblLog"
        Dim FoundLOGEntry As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim SystemAllValues() As Object
        Dim SystemAllFields() As String
        Dim PlanetAllValues() As Object
        Dim PlanetAllFields() As String
        Dim ANSwer As Integer
        Dim strCurrentDate As String
        Dim dtCurrentDate As DateTime
        Dim LogFieldNames As String
        Dim LogFieldValues As String
        Dim SystemFieldNames As String
        Dim SystemFieldValues As String
        Dim PlanetFieldNames As String
        Dim PlanetFieldValues As String
        Dim SAvedOK As Boolean = False
        Dim SystemSavedOK As Boolean
        Dim PlanetSavedOK As Boolean
        Dim ImportErrorLog As New clsErrorLog
        Dim InsertMessage As String
        Dim UpdateMessage As String
        Dim Verbose As String
        Dim LogFilename As String
        Dim strLAstSaved As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strUserID As String
        Dim strLogID As String
        Dim strDBInfo As String
        Dim strCSVInfo As String
        Dim FoundSystem As Boolean
        Dim FoundPlanet As Boolean
        Dim strBriefLength As Integer
        Dim strDBBriefLength As Integer
        Dim strComment1Length As Integer
        Dim strDBComment1Length As Integer
        Dim strComment2Length As Integer
        Dim strDBComment2Length As Integer
        Dim InsertNewRecord As Boolean = False
        Dim strDBRTFComment1 As String
        Dim strDBRTFComment2 As String
        Dim strRTFComment1 As String
        Dim strRTFComment2 As String

        strCurrentDate = Now().ToString("dd/MMM/yyyy HH:mm:ss")
        strUserID = frmMain.myUserID
        strAccountID = txtAccountID.Text
        If strUserID = "" Or strUserID = "0" Then
            MsgBox("Invalid UserID")
            Exit Function
        End If
        If strAccountID = "" Or strAccountID = "0" Then
            MsgBox("No Account Selected")
            Exit Function
        End If
        GetLOGRecsFromCSVFile = 0
        csvDialog.Title = "Select CSV NMS LOG FILE"
        csvDialog.InitialDirectory = Application.StartupPath
        csvDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        csvDialog.FilterIndex = 2
        csvDialog.RestoreDirectory = True
        TotalRecsImported = 0
        If csvDialog.ShowDialog() = DialogResult.OK Then
            strFileName = csvDialog.FileName
            NumRecs = myDAL.CSVFileToArray(csvFileArr, strFileName, TotalFields, Message)
            'Returns ALL rows from CSV file as csvFileArr(fields,rows)
            'Loop through array and compare date and time with existing records in NMS DB:
            'Col A) ACCOUNT NAME
            'Col B) ACTUAL DATE AND TIME
            'Col C) GAME TIME
            'Col D) SYSTEM
            'COL E) PLANET
            'COL F) AREA
            'COL G) NANITE CLUSTER
            'COL H) UNITS
            'COL I) QUICKSILVER
            'COL J) COMMENT
            'COL K) ADDITIONAL COMMENTS

            LogFieldNames = "UserID"
            LogFieldNames += ",AccountID"
            LogFieldNames += ",AccountName"
            LogFieldNames += ",Platform"
            LogFieldNames += ",Version"
            LogFieldNames += ",GamerHandle"
            LogFieldNames += ",SystemID"
            LogFieldNames += ",PlanetID"
            LogFieldNames += ",CurrentDateTime"
            LogFieldNames += ",CurrentGalacticRegion"
            LogFieldNames += ",CurrentStarSystem"
            LogFieldNames += ",CurrentPlanet"
            LogFieldNames += ",CurrentPlanetArea"
            LogFieldNames += ",CurrentNanites"
            LogFieldNames += ",CurrentUnits"
            LogFieldNames += ",CurrentQuickSilver"
            LogFieldNames += ",CurrentFrigateModules"
            LogFieldNames += ",CurrentSalvagedData"
            LogFieldNames += ",Brief"
            LogFieldNames += ",Comment1"
            LogFieldNames += ",RTFComment1"
            LogFieldNames += ",Comment2"
            LogFieldNames += ",RTFComment2"
            LogFieldNames += ",LastSaved"
            LogFieldNames += ",NewSystemName"
            LogFieldNames += ",NewPlanetName"

            For RowNum = 1 To NumRecs

                strAccountName = csvFileArr(0, RowNum)
                strEntryDate = csvFileArr(1, RowNum)
                strSystemName = csvFileArr(3, RowNum)
                strPlanetName = csvFileArr(4, RowNum)
                strAreaName = csvFileArr(5, RowNum)
                strNanites = Replace(csvFileArr(6, RowNum), ",", "")
                strUnits = Replace(csvFileArr(7, RowNum), ",", "")
                strQS = Replace(csvFileArr(8, RowNum), ",", "")
                strComment1 = csvFileArr(9, RowNum)
                strRTFComment1 = csvFileArr(9, RowNum)
                strBrief = csvFileArr(9, RowNum)
                strComment2 = csvFileArr(10, RowNum)
                strRTFComment2 = csvFileArr(10, RowNum)
                strFM = "0"
                strSD = "0"
                If IsDate(strEntryDate) Then
                    dtEntryDate = CDate(strEntryDate)
                Else
                    dtEntryDate = CDate("1900-01-01 01:00")
                End If
                strCSVInfo = "S/Sheet data:" & vbCrLf
                strCSVInfo += "Account Name: " & strAccountName & vbCrLf
                strCSVInfo += "Entry Date: " & strEntryDate & vbCrLf
                strCSVInfo += "System Name: " & strSystemName & vbCrLf
                strCSVInfo += "Planet Name: " & strPlanetName & vbCrLf
                strCSVInfo += "Area Name: " & strAreaName & vbCrLf
                strCSVInfo += "Nanites: " & strNanites & vbCrLf
                strCSVInfo += "Units: " & strUnits & vbCrLf
                strCSVInfo += "Quicksilver: " & strQS & vbCrLf
                strCSVInfo += "Frigate Modules: " & strFM & vbCrLf
                strCSVInfo += "Salvaged Data: " & strSD & vbCrLf
                strCSVInfo += "Comment1: " & strComment1 & vbCrLf
                strCSVInfo += "Comment2: " & strComment2 & vbCrLf

                'SEARCH for corresponding DATE in tblLOG: CurrentDateTime
                'FIRST UPDATE THE SYSTEM TABLE:

                SearchText = strSystemName
                DBTable = "tblSystems"
                LogFilename = "NMS_LOG_IMPORT_MESSAGES"
                SearchField = "RenamedSystemName"
                FieldType = "STRING"
                ReturnField = "SystemID"
                ReturnValue = ""

                SearchCriteria = "UserID=" & CInt(strUserID) & " AND AccountID=" & CInt(strAccountID)
                If strSystemName = "" Or strSystemName = " " Then
                    strSystemName = "UNKNOWN"
                End If
                FoundSystem = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, SystemAllValues,
                                            SystemAllFields, SearchCriteria, SortFields, Reversed, ErrMessages)
                If FoundSystem Then
                    strSystemID = GetValuebyFieldname(SystemAllValues, SystemAllFields, "SystemID")
                    strSystemLastUpdated = GetValuebyFieldname(SystemAllValues, SystemAllFields, "Updated")
                    UpdateCriteria = "SystemID=" & strSystemID

                    SystemFieldNames = "Updated"
                    SystemFieldValues = Now().ToString("yyyy-MM-dd HH:mm:ss")

                    ExcludeFields = ""
                    ErrMessages = ""
                    SystemSavedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                    DBTable, SystemFieldNames, SystemFieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)

                    If SystemSavedOK Then
                        Message += Chr(10) & Chr(13) & "SYSTEM Last Updated: " & strSystemLastUpdated & " From Row: " & RowNum
                        ImportErrorLog.LogMessage(LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Message, "", Verbose)
                    Else
                        Message += Chr(10) & Chr(13) & "Error: SYSTEM NOT Updated: " & strSystemLastUpdated & " From Row: " & RowNum
                        ImportErrorLog.LogError("Log Error_" & LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & Message & ", " & ErrMessages, "", Verbose)
                    End If
                Else
                    strSystemLastUpdated = Now().ToString("yyyy-MM-dd HH:mm:ss")
                    ANSwer = MsgBox("INSERT NEW SYSTEM ???", vbYesNoCancel, "NEW SYSTEM FOUND: " & strSystemName)
                    If ANSwer = vbYes Then
                        'UPDATE SYSTEM - REPLACE RECORD IN DATABASE WITH THIS NEW RECORD FROM
                        'THE CVF FILE:

                        DBTable = "tblSystems"
                        SystemFieldNames = "UserID"
                        SystemFieldNames += ",AccountID"
                        SystemFieldNames += ",RenamedSystemName"
                        SystemFieldNames += ",Updated"
                        SystemFieldValues = strUserID
                        SystemFieldValues += "," & strAccountID
                        SystemFieldValues += "," & strSystemName
                        SystemFieldValues += "," & strCurrentDate

                        UpdateCriteria = ""
                        ExcludeFields = ""
                        ErrMessages = ""
                        strSystemID = ""
                        Message = ""
                        SystemSavedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                        DBTable, SystemFieldNames, SystemFieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)

                        If SystemSavedOK Then
                            Message += Chr(10) & Chr(13) & "Row Inserted: " & strCurrentDate & " Row: " & RowNum
                            ImportErrorLog.LogMessage(LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Message, "", Verbose)
                            strSystemID = myDAL.GetLastID(frmMain.myConnString, "tblSystems", "SystemID")
                        Else
                            Message += Chr(10) & Chr(13) & "Error: Row NOT Inserted: " & strCurrentDate & " Row: " & RowNum
                            ImportErrorLog.LogError("Log Error_" & LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & Message & ", " & ErrMessages, "", Verbose)
                        End If
                    End If
                End If

                SearchText = strPlanetName
                DBTable = "tblPlanets"
                LogFilename = "NMS_LOG_IMPORT_MESSAGES"
                SearchField = "RenamedPlanetName"
                FieldType = "STRING"
                ReturnField = "PlanetID"
                ReturnValue = ""
                If strPlanetName = "" Or strPlanetName = " " Then
                    strPlanetName = "UNKNOWN"
                End If
                FoundPlanet = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, PlanetAllValues,
                                            PlanetAllFields, SearchCriteria, SortFields, Reversed, ErrMessages)

                If FoundPlanet Then
                    strPlanetID = GetValuebyFieldname(PlanetAllValues, PlanetAllFields, "PlanetID")
                    strPlanetLastUpdated = GetValuebyFieldname(PlanetAllValues, PlanetAllFields, "Updated")
                    UpdateCriteria = "PlanetID=" & strPlanetID

                    DBTable = "tblPlanets"
                    PlanetFieldNames = "Updated"
                    PlanetFieldValues = Now().ToString("yyyy-MM-dd HH:mm:ss")
                    ExcludeFields = ""
                    ErrMessages = ""
                    Message = ""
                    PlanetSavedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                    DBTable, PlanetFieldNames, PlanetFieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)

                    If PlanetSavedOK Then
                        Message += Chr(10) & Chr(13) & "PLANET Last Updated: " & strPlanetLastUpdated & " From Row: " & RowNum
                        ImportErrorLog.LogMessage(LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Message, "", Verbose)
                    Else
                        Message += Chr(10) & Chr(13) & "Error: PLANET NOT Updated: " & strPlanetLastUpdated & " From Row: " & RowNum
                        ImportErrorLog.LogError("Log Error_" & LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & Message & ", " & ErrMessages, "", Verbose)
                    End If
                Else
                    strPlanetLastUpdated = Now().ToString("yyyy-MM-dd HH:mm:ss")
                    ANSwer = MsgBox("INSERT NEW PLANET ???", vbYesNoCancel, "NEW PLANET FOUND: " & strPlanetName)
                    If ANSwer = vbYes Then
                        'UPDATE PLANET - REPLACE RECORD IN DATABASE WITH THIS NEW RECORD FROM
                        'THE CVF FILE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                        DBTable = "tblPlanets"
                        PlanetFieldNames = "UserID"
                        PlanetFieldNames += ",AccountID"
                        PlanetFieldNames += ",SystemID"
                        PlanetFieldNames += ",RenamedPlanetName"
                        PlanetFieldNames += ",Updated"
                        PlanetFieldValues = strUserID
                        PlanetFieldValues += "," & strAccountID
                        PlanetFieldValues += "," & strSystemID
                        PlanetFieldValues += "," & strPlanetName
                        PlanetFieldValues += "," & strCurrentDate
                        ErrMessages = ""
                        UpdateCriteria = ""
                        ExcludeFields = ""
                        Message = ""
                        strPlanetID = ""
                        PlanetSavedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                        DBTable, PlanetFieldNames, PlanetFieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)

                        If PlanetSavedOK Then
                            Message += Chr(10) & Chr(13) & "Planet Inserted: " & strCurrentDate & " From Row: " & RowNum
                            ImportErrorLog.LogMessage(LogFilename & frmMain.myVersion & ".log", Application.StartupPath, UpdateMessage, "", Verbose)
                            strPlanetID = myDAL.GetLastID(frmMain.myConnString, "tblPlanets", "PlanetID")
                        Else
                            Message += Chr(10) & Chr(13) & "Error: Planet NOT Inserted: " & strCurrentDate & " From Row: " & RowNum
                            ImportErrorLog.LogError("Log Error_" & LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & Message & ", " & ErrMessages, "", Verbose)
                        End If
                    End If
                End If

                'SETUP LOG SEARCH AND PERFORM SEARCH:
                DBTable = "tblLog"
                LogFilename = "NMS_LOG_IMPORT_MESSAGES"
                SearchField = "CurrentDateTime"
                FieldType = "DATE"
                ReturnField = "LogID"
                ReturnValue = ""
                If IsDate(strEntryDate) Then
                    SearchText = CDate(strEntryDate).ToString("yyyy-MM-dd HH:mm:ss")
                Else
                    SearchText = CDate("1900-01-01 01:00:00").ToString("yyyy-MM-dd HH:mm:ss")
                End If

                If IncludeVerboseInUpdateMessage Then
                    Verbose = frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR Logged in:" & frmMain.myUsername
                    LogFilename += "_VERBOSE"
                Else
                    LogFilename += "_SHORT"
                    Verbose = ""
                End If
                'WHAT IF THE DATE AND TIME IS EXACTLY THE SAME...
                'ask if THE BRIEF,COMMENT1 AND COMMENT2 IS ADDED  IF NOT GREATER THAN THE SUM OF 4092.

                FoundLOGEntry = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                            AllFields, SearchCriteria, SortFields, Reversed, ErrMessages)

                If Not IsDate(strEntryDate) Then
                    strEntryDate = "1900-01-01 01:00"
                End If
                dtCurrentDate = CDate(strEntryDate)
                strCurrentDate = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
                If FoundLOGEntry Then
                    ''Populate text boxes:
                    strDBDateTime = GetValuebyFieldname(AllValues, AllFields, "CurrentDateTime")
                    strDBLogID = GetValuebyFieldname(AllValues, AllFields, "LogID")
                    strDBUserID = GetValuebyFieldname(AllValues, AllFields, "UserID")
                    strDBAccountID = GetValuebyFieldname(AllValues, AllFields, "AccountID")
                    strDBAccountName = GetValuebyFieldname(AllValues, AllFields, "AccountName")
                    strDBPlatform = GetValuebyFieldname(AllValues, AllFields, "Platform")
                    strDBVersion = GetValuebyFieldname(AllValues, AllFields, "Version")
                    strDBGamerHandle = GetValuebyFieldname(AllValues, AllFields, "GamerHandle")
                    strDBSystemID = GetValuebyFieldname(AllValues, AllFields, "SystemID")
                    strDBPlanetID = GetValuebyFieldname(AllValues, AllFields, "PlanetID")
                    strDBGalacticRegion = GetValuebyFieldname(AllValues, AllFields, "CurrentGalacticRegion")
                    strDBCurrentSystem = GetValuebyFieldname(AllValues, AllFields, "CurrentStarSystem")
                    strDBCurrentPlanet = GetValuebyFieldname(AllValues, AllFields, "CurrentPlanet")
                    strDBArea = GetValuebyFieldname(AllValues, AllFields, "CurrentPlanetArea")
                    strDBNanites = GetValuebyFieldname(AllValues, AllFields, "CurrentNanites")
                    strDBUnits = GetValuebyFieldname(AllValues, AllFields, "CurrentUnits")
                    strDBQuickSilver = GetValuebyFieldname(AllValues, AllFields, "CurrentQuickSilver")
                    strDBFrigateModules = GetValuebyFieldname(AllValues, AllFields, "CurrentFrigateModules")
                    strDBSalvagedData = GetValuebyFieldname(AllValues, AllFields, "CurrentSalvagedData")
                    strDBBrief = GetValuebyFieldname(AllValues, AllFields, "Brief")
                    strDBComment1 = GetValuebyFieldname(AllValues, AllFields, "Comment1")
                    strDBRTFComment1 = GetValuebyFieldname(AllValues, AllFields, "RTFComment1")
                    strDBComment2 = GetValuebyFieldname(AllValues, AllFields, "Comment2")
                    strDBRTFComment2 = GetValuebyFieldname(AllValues, AllFields, "RTFComment2")
                    strDBLastSaved = GetValuebyFieldname(AllValues, AllFields, "LastSaved")
                    strDBInfo = "UserID=" & strDBUserID & ", DB LogID=" & strDBLogID & ", DB AccountID=" & strDBAccountID & ", LastSaved: " & strDBLastSaved

                    txtAccountName.Text = strDBAccountName
                    txtLogID.Text = strDBLogID
                    'txtUserID.Text = strDBUserID
                    'txtAccountID.Text = strDBAccountID
                    txtPlatform.Text = strDBPlatform
                    txtVersion.Text = strDBVersion
                    txtGamerHandle.Text = strDBGamerHandle
                    txtSystemID.Text = strDBSystemID
                    txtPlanetID.Text = strDBPlanetID
                    txtGalacticRegion.Text = strDBGalacticRegion
                    txtCurrentSystem.Text = strDBCurrentSystem
                    txtCurrentPlanet.Text = strDBCurrentPlanet
                    txtCurrentArea.Text = strDBArea
                    txtNanites.Text = strDBNanites
                    txtUnits.Text = strDBUnits
                    txtQuicksilver.Text = strDBQuickSilver
                    txtFrigateModules.Text = strDBFrigateModules
                    txtSalvagedData.Text = strDBSalvagedData
                    txtBrief.Text = strDBBrief
                    rtbComment.Text = strDBComment1
                    rtbFurtherComment.Text = strDBComment2
                    txtEntryDate.Text = strDBDateTime
                    txtLastSaved.Text = strDBLastSaved

                    UpdateCriteria = "LogID=" & CInt(strDBLogID)

                    If strAccountName <> strDBAccountName Then
                        ANSwer = MsgBox("Account Names are different - replace account name in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strAccountName = strDBAccountName
                        End If
                    End If

                    'To get the system ID = need to search tblSystems ?
                    If strSystemName <> strDBCurrentSystem Then
                        ANSwer = MsgBox("Systems are different - replace system name in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strSystemName = strDBCurrentSystem
                        End If
                    End If

                    If strPlanetName <> strDBCurrentPlanet Then
                        ANSwer = MsgBox("Planets are different - replace planet name in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strPlanetName = strDBCurrentPlanet
                        End If
                    End If

                    If strAreaName <> strDBArea Then
                        ANSwer = MsgBox("Areas are different - replace AREA name in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strAreaName = strDBArea
                        End If
                    End If

                    If strNanites <> strDBNanites Then
                        ANSwer = MsgBox("NANITES are different - replace NANITES in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strNanites = strDBNanites
                        End If
                    End If

                    If strUnits <> strDBUnits Then
                        ANSwer = MsgBox("UNITS are different - replace UNITS in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strUnits = strDBUnits
                        End If
                    End If

                    If strQS <> strDBQuickSilver Then
                        ANSwer = MsgBox("QUICKSILVER IS different - replace QUICKSILVER in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strQS = strDBQuickSilver
                        End If
                    End If

                    If strFM <> strDBFrigateModules Then
                        ANSwer = MsgBox("FRIGATE MODULES are different - replace FRIGATE MODULES in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strFM = strDBFrigateModules
                        End If
                    End If

                    If strSD <> strDBSalvagedData Then
                        ANSwer = MsgBox("SALVAGED DATA IS different - replace SALVAGED DATA in DB ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbNo Then
                            strSD = strDBSalvagedData
                        End If
                    End If
                    strBriefLength = Len(strBrief)
                    strDBBriefLength = Len(strDBBrief)
                    If strBriefLength + strDBBriefLength < 4092 Then
                        'OK THERE is space: add onto the end of BRIEF:
                        If strBriefLength > 0 Then
                            txtBrief.Text = strDBBrief
                            txtBrief.AppendText(vbCrLf & " " & strBrief)
                            strBrief = txtBrief.Text
                        End If
                    Else
                        'Add 1-10 seconds to the current date and save> greater than 4092 - no space.
                        InsertNewRecord = True
                        Dim Date2 As Date = CDate(strCurrentDate).AddSeconds(1)
                        strCurrentDate = Date2.ToString("yyyy-MM-dd HH:mm:ss")
                    End If

                    strComment1Length = Len(strComment1)
                    strDBComment1Length = Len(strDBComment1)
                    If strComment1Length + strDBComment1Length < 4092 Then
                        'OK THERE is space: add onto the end of COMMENT1:
                        If strComment1Length > 0 Then
                            rtbComment.Text = strDBComment1
                            rtbComment.AppendText(vbCrLf & " " & strRTFComment1)

                        End If
                        strRTFComment1 = rtbComment.Rtf
                        strComment1 = rtbComment.Text
                    Else
                        'Add 1-10 seconds to the current date and save> greater than 4092 - no space.
                        InsertNewRecord = True
                        Dim Date2 As Date = CDate(strCurrentDate).AddSeconds(1)
                        strCurrentDate = Date2.ToString("yyyy-MM-dd HH:mm:ss")
                    End If

                    strComment2Length = Len(strComment2)
                    strDBComment2Length = Len(strDBComment2)
                    If strComment2Length + strDBComment2Length < 4092 Then
                        'OK THERE is space: add onto the end of COMMENT2:
                        If strComment2Length > 0 Then
                            rtbFurtherComment.Text = strDBComment2
                            rtbFurtherComment.AppendText(vbCrLf & " " & strRTFComment2)

                        End If
                        strRTFComment2 = rtbFurtherComment.Rtf
                        strComment2 = rtbFurtherComment.Text
                    Else
                        'Add 1-10 seconds to the current date and save> greater than 4092 - no space.
                        InsertNewRecord = True
                        Dim Date2 As Date = CDate(strCurrentDate).AddSeconds(1)
                        strCurrentDate = Date2.ToString("yyyy-MM-dd HH:mm:ss")
                    End If

                    LogFieldValues = strUserID
                    LogFieldValues += "," & strAccountID
                    LogFieldValues += "," & Replace(strAccountName, ",", ";")
                    LogFieldValues += "," & Replace("PLATFORM", ",", ";")
                    LogFieldValues += "," & "VERSION"
                    LogFieldValues += "," & "GAMER HANDLE"
                    LogFieldValues += "," & strSystemID
                    LogFieldValues += "," & strPlanetID
                    LogFieldValues += "," & strCurrentDate
                    LogFieldValues += "," & "GALACTIC REGION"
                    LogFieldValues += "," & Replace(strSystemName, ",", ";")
                    LogFieldValues += "," & Replace(strPlanetName, ",", ";")
                    LogFieldValues += "," & Replace(strAreaName, ",", ";")
                    LogFieldValues += "," & Replace(strNanites, ",", ";")
                    LogFieldValues += "," & Replace(strUnits, ",", ";")
                    LogFieldValues += "," & Replace(strQS, ",", ";")
                    LogFieldValues += "," & Replace(strFM, ",", ";")
                    LogFieldValues += "," & Replace(strSD, ",", ";")
                    LogFieldValues += "," & Replace(strBrief, ",", ";")
                    LogFieldValues += "," & Replace(strComment1, ",", ";")
                    LogFieldValues += "," & Replace(strRTFComment1, ",", ";")
                    LogFieldValues += "," & Replace(strComment2, ",", ";")
                    LogFieldValues += "," & Replace(strRTFComment2, ",", ";")
                    LogFieldValues += "," & Now().ToString("yyyy-MM-dd HH:mm:ss")
                    LogFieldValues += "," & Replace(strSystemName, ",", ";")
                    LogFieldValues += "," & Replace(strPlanetName, ",", ";")
                    'What if :
                    'Date time matches but 
                    'system or planet or even account do not match ????

                    'OK LEAVE IT UP TO USER :
                    'DIALOGE :
                    'UPDATE RECORD ?????
                    'YES / NO  / CANCEL ?
                    If InsertNewRecord = False Then
                        ANSwer = MsgBox("UPDATE LOG ???" & vbCrLf & strCSVInfo, vbYesNoCancel, strDBInfo)
                        If ANSwer = vbYes Then
                            'UPDATE - REPLACE RECORD IN DATABASE WITH THIS NEW RECORD FROM
                            'THE CVF FILE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                            UpdateCriteria = "LogID=" & CInt(strLogID)
                            DBTable = "tblLog"
                            ExcludeFields = ""
                            ErrMessages = ""
                            Message = ""
                            strAccountLinkID = ""
                            SAvedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                            DBTable, LogFieldNames, LogFieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
                            'NewSystemName
                            'NewPlanetName
                            If SAvedOK Then
                                UpdateMessage = Now().ToString("dd/MMM/yyyy HH:mm:ss") & " Log Entry Imported OK: " & strLogID
                                UpdateMessage += LogFieldValues
                                strAccountLinkID = frmMain.myUserID
                                Message += Chr(10) & Chr(13) & "LOG " & strLogID & " Inserted: " & strCurrentDate & " from Row: " & RowNum
                                ImportErrorLog.LogMessage(LogFilename & frmMain.myVersion & ".log", Application.StartupPath, UpdateMessage, "", Verbose)
                                Me.rtbComment.Text = strComment1
                                Me.rtbFurtherComment.Text = strComment2
                                myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strDBLogID, "RTFComment1", Me.rtbComment)
                                myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strDBLogID, "RTFComment2", Me.rtbFurtherComment)
                            Else
                                Message += Chr(10) & Chr(13) & "Error: LOG NOT Inserted: " & strLogID & " " & strCurrentDate & " from Row: " & RowNum
                                ImportErrorLog.LogError("Log Error_" & LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & Message & ", " & ErrMessages, "", Verbose)
                            End If
                        End If
                        If ANSwer = vbCancel Then
                            Exit Function
                        End If
                    Else
                        'YES THIS IS A DUPLICATE OF THE INSERT CODE - ITS UGLY - BUT CANNOT THINK OTHERWISE - 
                        'ITS STILL PART OF THE UPDATE: WOULD NOT KNOW HOW MANY CHARS ARE AVAILABLE IN EXISTING RECORD
                        'IF THE FIELDS HAVE NOT ALREADY BEEN READ.
                        UpdateCriteria = ""
                        ExcludeFields = ""
                        DBTable = "tblLog"
                        InsertMessage = Now().ToString("dd/MMM/yyyy HH:mm:ss") & " Log IMPORT INSERTED OVERFLOW OK: " & ReturnValue
                        InsertMessage += LogFieldValues
                        ErrMessages = ""
                        SAvedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                            DBTable, LogFieldNames, LogFieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
                        If SAvedOK Then
                            ImportErrorLog.LogMessage(LogFilename & frmMain.myVersion & ".log", Application.StartupPath, InsertMessage, "", Verbose)
                            Me.rtbComment.Text = strComment1
                            Me.rtbFurtherComment.Text = strComment2
                            strLogID = myDAL.GetLastID(frmMain.myConnString, "tblLog", "LogID")
                            myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strLogID, "RTFComment1", Me.rtbComment)
                            myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strLogID, "RTFComment2", Me.rtbFurtherComment)
                        Else
                            ImportErrorLog.LogError("Log_Error_" & LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & " Error:" & ", " & ErrMessages, "", Verbose)
                        End If
                    End If

                Else
                    'Specific Date and Time NOT found - just INSERT into DB:

                    LogFieldValues = strUserID
                    LogFieldValues += "," & strAccountID
                    LogFieldValues += "," & Replace(strAccountName, ",", ";")
                    LogFieldValues += "," & Replace("PLATFORM", ",", ";")
                    LogFieldValues += "," & "VERSION"
                    LogFieldValues += "," & "GAMER HANDLE"
                    LogFieldValues += "," & strSystemID
                    LogFieldValues += "," & strPlanetID
                    LogFieldValues += "," & strCurrentDate
                    LogFieldValues += "," & "GALACTIC REGION"
                    LogFieldValues += "," & Replace(strSystemName, ",", ";")
                    LogFieldValues += "," & Replace(strPlanetName, ",", ";")
                    LogFieldValues += "," & Replace(strAreaName, ",", ";")
                    LogFieldValues += "," & Replace(strNanites, ",", ";")
                    LogFieldValues += "," & Replace(strUnits, ",", ";")
                    LogFieldValues += "," & Replace(strQS, ",", ";")
                    LogFieldValues += "," & Replace(strFM, ",", ";")
                    LogFieldValues += "," & Replace(strSD, ",", ";")
                    LogFieldValues += "," & Replace(strBrief, ",", ";")
                    LogFieldValues += "," & Replace(strComment1, ",", ";")
                    LogFieldValues += "," & Replace(strRTFComment1, ",", ";")
                    LogFieldValues += "," & Replace(strComment2, ",", ";")
                    LogFieldValues += "," & Replace(strRTFComment2, ",", ";")
                    LogFieldValues += "," & Now().ToString("yyyy-MM-dd HH:mm:ss")
                    LogFieldValues += "," & Replace(strSystemName, ",", ";")
                    LogFieldValues += "," & Replace(strPlanetName, ",", ";")

                    UpdateCriteria = ""
                    ExcludeFields = ""
                    DBTable = "tblLog"
                    InsertMessage = Now().ToString("dd/MMM/yyyy HH:mm:ss") & " Log IMPORT INSERTED OK: " & ReturnValue
                    InsertMessage += LogFieldValues
                    ErrMessages = ""
                    SAvedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                        DBTable, LogFieldNames, LogFieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
                    If SAvedOK Then
                        ImportErrorLog.LogMessage(LogFilename & frmMain.myVersion & ".log", Application.StartupPath, InsertMessage, "", Verbose)
                        Me.rtbComment.Text = strComment1
                        Me.rtbFurtherComment.Text = strComment2
                        strLogID = myDAL.GetLastID(frmMain.myConnString, "tblLog", "LogID")
                        myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strLogID, "RTFComment1", Me.rtbComment)
                        myDAL.SaveRTFControl_memStream(frmMain.myConnString, "tblLog", "LogID", strLogID, "RTFComment2", Me.rtbFurtherComment)
                    Else
                        ImportErrorLog.LogError("Log_Error_" & LogFilename & frmMain.myVersion & ".log", Application.StartupPath, Now().ToString("dd/MMM/yyyy HH:mm:ss") & "(" & ReturnValue & ")" & " Error:" & ", " & ErrMessages, "", Verbose)
                    End If
                End If
            Next
        End If
        GetLOGRecsFromCSVFile = NumRecs
    End Function

    Sub PopulateFields()

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        'READ IN data from NMSLOG.CSV file
        Dim TotalRows As Long

        TotalRows = GetLOGRecsFromCSVFile()
        MsgBox("OK Total Rows Imported: " & CStr(TotalRows))

    End Sub



    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click

    End Sub

    Private Sub btnItalic_Click(sender As Object, e As EventArgs) Handles btnItalic.Click

    End Sub

    Private Sub btnTextColor_Click(sender As Object, e As EventArgs) Handles btnTextColor.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtStyleCombo2.Text = ""

    End Sub

    Private Sub btnStrike_Click(sender As Object, e As EventArgs) Handles btnStrike.Click

    End Sub

    Private Sub btnImportPic_Click(sender As Object, e As EventArgs) Handles btnImportPic.Click
        Dim dlg As New OpenFileDialog
        Dim strExtension As String
        Dim info As FileInfo

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pb1.BackgroundImage = Image.FromFile(dlg.FileName)
            txtImageFilename.Text = dlg.FileName
            pb1.Tag = dlg.FileName
            strExtension = Path.GetExtension(dlg.FileName)
            txtImageExt.Text = strExtension
            info = New FileInfo(dlg.FileName)
            txtImageSize.Text = CStr(info.Length)
        End If
    End Sub

    Private Sub btnTextFont_Click(sender As Object, e As EventArgs) Handles btnTextFont.Click

        ActivateFontdialog(rtbComment, False)
        rtbComment.Focus()

    End Sub

    Sub ActivateFontdialog(ByRef RTB As RichTextBox, ApplyClicked As Boolean)
        Dim myFontFamily As FontFamily
        Dim myGraphicUnit As GraphicsUnit
        Dim myUnitSize As Single
        Dim myStyle As FontStyle
        Dim myColor As Color
        Dim myBackColor As Color
        Dim myNewFont As Font
        Dim Result As Integer
        Dim myFontDialog As FontDialog

        myFontFamily = myFontDialog.Font.FontFamily
        myGraphicUnit = myFontDialog.Font.Unit
        myUnitSize = myFontDialog.Font.Size
        myStyle = myFontDialog.Font.Style
        myColor = myFontDialog.Color
        myFontDialog.AllowScriptChange = True
        myFontDialog.AllowSimulations = True
        myFontDialog.AllowVectorFonts = True
        myFontDialog.AllowVerticalFonts = True
        myFontDialog.ShowApply = True
        myFontDialog.ShowColor = True
        myFontDialog.ShowEffects = True
        myFontDialog.ShowHelp = True

        Dim dlgResult = myFontDialog.ShowDialog()

        If dlgResult = DialogResult.OK Then
            myStyle = myFontDialog.Font.Style
            myFontFamily = myFontDialog.Font.FontFamily
            myNewFont = New Font(myFontDialog.Font, myStyle)
            RTB.SelectionFont = myNewFont
            RTB.SelectionColor = myColor
        End If

        If dlgResult = DialogResult.Cancel Then
            Exit Sub
        End If

        If ApplyClicked Then
            myStyle = myFontDialog.Font.Style
            myFontFamily = myFontDialog.Font.FontFamily
            myNewFont = New Font(myFontDialog.Font, myStyle)
            RTB.SelectionFont = myNewFont
            RTB.SelectionColor = myColor
        End If
    End Sub

    Sub FontDialog_Execute()
        Dim myFontDialog As FontDialog

        'If TypeOf (sender) Is FontDialog Then

        'End If
        'myStyle = myFontDialog.Font.Style
        'myFontFamily = myFontDialog.Font.FontFamily
        'myNewFont = New Font(myFontDialog.Font, myStyle)
        'RTB.SelectionFont = myNewFont
        'RTB.SelectionColor = myColor
    End Sub

    Private Sub btnTextFont2_Click(sender As Object, e As EventArgs) Handles btnTextFont2.Click

    End Sub

    Private Sub btnTextColor_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnTextColor2_Click(sender As Object, e As EventArgs) Handles btnTextColor2.Click

    End Sub

    Private Sub cbUseOriginalNames_CheckedChanged(sender As Object, e As EventArgs) Handles cbUseOriginalNames.CheckedChanged
        Dim UseOriginal As Boolean

        UseOriginal = cbUseOriginalNames.Checked
        BuildAccountCombo()
        'WELL - this checkbox is actually already used when the user selects a particualar system anyway...
        'BuildSystemCombo(UseOriginal, cbThisAccountOnly.Checked)
        'BuildPlanetCombo(UseOriginal, cbThisSystemOnly.Checked)
        BuildWaypointCombo(cbThisPlanetOnly.Checked)
        BuildBaseCombo(UseOriginal, cbThisPlanetOnly.Checked)
    End Sub

    Private Sub txtAreaLongitude_Leave(sender As Object, e As EventArgs) Handles txtAreaLongitude.Leave
        'NORTH / SOUTH COORDINATES
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtAreaLongitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtAreaLongitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtAreaLongitude.Text = strNewValue
        End If
    End Sub

    Private Sub txtAreaLatitude_Leave(sender As Object, e As EventArgs) Handles txtAreaLatitude.Leave
        '
        'EAST / WEST COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtAreaLatitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtAreaLatitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtAreaLatitude.Text = strNewValue
        End If
    End Sub

    Private Sub comPlanets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPlanets.SelectedIndexChanged
        SelectPlanet(False, comPlanets.SelectedItem)
    End Sub

    Private Sub comBases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comBases.SelectedIndexChanged
        SelectBase(False, comBases.SelectedItem)
    End Sub

    Private Sub comAreas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAreas.SelectedIndexChanged
        SelectArea(False, comAreas.SelectedItem)
    End Sub

    Private Sub cbThisSystemOnly_CheckedChanged(sender As Object, e As EventArgs) Handles cbThisSystemOnly.CheckedChanged
        'Build comPlanets - based on the account selection - or not ?
        Dim UseOriginal As Boolean

        UseOriginal = cbUseOriginalNames.Checked
        'BuildPlanetCombo(UseOriginal, cbThisSystemOnly.Checked)

    End Sub

    Private Sub cbThisPlanetOnly_CheckedChanged(sender As Object, e As EventArgs) Handles cbThisPlanetOnly.CheckedChanged
        Dim UseOriginal As Boolean

        UseOriginal = cbUseOriginalNames.Checked
        BuildBaseCombo(UseOriginal, cbThisPlanetOnly.Checked)

    End Sub

    Private Sub cbThisAccountOnly_CheckedChanged(sender As Object, e As EventArgs) Handles cbThisAccountOnly.CheckedChanged
        Dim UseOriginal As Boolean

        'ALready taken into consideration when system combo will be built after selecting an account:
        UseOriginal = cbUseOriginalNames.Checked
        'BuildSystemCombo(UseOriginal, cbThisAccountOnly.Checked)
    End Sub

    Private Sub btnSaveDefaults_Click(sender As Object, e As EventArgs) Handles btnSaveDefaults.Click
        'SAVE ALL 4 Selected items from the combo boxes to individual defaults fields in the relevant tables:
        'Gather the IDs of each table field selected:
        'AccountID, SystemID, PlanetID And WaypointID / BaseID
        SaveDefaults()

    End Sub

    Private Sub btnLoadDefaults_Click(sender As Object, e As EventArgs) Handles btnLoadDefaults.Click
        LoadDefaults()

    End Sub

    Sub ClearTextboxAndCombos(Optional IncludeAccounts As Boolean = False)
        comAccounts.Text = ""
        comSystems.Text = ""
        comPlanets.Text = ""
        comAreas.Text = ""
        comBases.Text = ""

        If IncludeAccounts Then
            For Each ctrl As Control In pnlAccount.Controls
                If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                    ctrl.Text = ""
                End If
            Next
        End If

        For Each ctrl As Control In pnlInfo.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
        For Each ctrl As Control In pnlLogDetails.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextboxAndCombos()
    End Sub

    Private Sub txtTITLE2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Sub GetUnits(strAccountID As String)
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim Nanites As String
        Dim Units As String
        Dim Quicksilver As String
        Dim FrigateModules As String
        Dim SalvagedData As String
        Dim LastSaved As String
        Dim UpdatedOK As Boolean
        Dim arrUnits As String()
        Dim AllUnits As String

        If strAccountID = "" Or strAccountID = "0" Then
            MsgBox("Problem Getting Units")
            Exit Sub
        End If
        AllUnits = myDAL.GetUnits(frmMain.myConnString, strAccountID)
        If AllUnits = "" Then
            Exit Sub
        End If
        arrUnits = Split(AllUnits, ";")
        If Not IsNothing(arrUnits(0)) Then
            Nanites = arrUnits(0)
        Else
            Nanites = "0"
        End If
        If Not IsNothing(arrUnits(1)) Then
            Units = arrUnits(1)
        Else
            Units = "0"
        End If
        If Not IsNothing(arrUnits(2)) Then
            Quicksilver = arrUnits(2)
        Else
            Quicksilver = "0"
        End If
        If Not IsNothing(arrUnits(3)) Then
            FrigateModules = arrUnits(3)
        Else
            FrigateModules = "0"
        End If
        If Not IsNothing(arrUnits(4)) Then
            SalvagedData = arrUnits(4)
        Else
            SalvagedData = "0"
        End If
        If Not IsNothing(arrUnits(5)) Then
            LastSaved = arrUnits(5)
        Else
            LastSaved = ""
        End If
        txtNanites.Text = Nanites
        txtUnits.Text = Units
        txtQuicksilver.Text = Quicksilver
        txtFrigateModules.Text = FrigateModules
        txtSalvagedData.Text = SalvagedData
        txtLastSaved.Text = LastSaved
    End Sub

    Private Sub btnSaveUnits_Click(sender As Object, e As EventArgs) Handles btnSaveUnits.Click
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim Nanites As String
        Dim Units As String
        Dim Quicksilver As String
        Dim FrigateModules As String
        Dim SalvagedData As String
        Dim UpdatedOK As Boolean
        Dim strAccountID As String

        If txtAccountID.Text = "" Then
            MsgBox("Please Select Account First")
            Exit Sub
        End If
        strAccountID = txtAccountID.Text
        Nanites = txtNanites.Text
        Units = txtUnits.Text
        Quicksilver = txtQuicksilver.Text
        FrigateModules = txtFrigateModules.Text
        SalvagedData = txtSalvagedData.Text
        UpdatedOK = myDAL.UpdateUnits(frmMain.myConnString, strAccountID, Nanites, Units, Quicksilver, FrigateModules, SalvagedData)
        If UpdatedOK Then
            MsgBox("OK UNITS SAVED")
        Else
            MsgBox("Problem Saving Units")
        End If

    End Sub

    Private Sub btnUnderline_Click(sender As Object, e As EventArgs) Handles btnUnderline.Click

    End Sub

    Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset2.Click

    End Sub

    Private Sub btnBold2_Click(sender As Object, e As EventArgs) Handles btnBold2.Click

    End Sub

    Private Sub btnItalic2_Click(sender As Object, e As EventArgs) Handles btnItalic2.Click

    End Sub

    Private Sub btnStrike2_Click(sender As Object, e As EventArgs) Handles btnStrike2.Click

    End Sub

    Private Sub btnUnderline2_Click(sender As Object, e As EventArgs) Handles btnUnderline2.Click

    End Sub

    Private Sub btnSave3_Click(sender As Object, e As EventArgs) Handles btnSave3.Click
        Save_Log_Entry()
    End Sub

    Private Sub Form_LogEntry3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Log_entry()
    End Sub

    Private Sub txtBrief_TextChanged(sender As Object, e As EventArgs) Handles txtBrief.TextChanged
        Dim TotalChars As String = "4096"
        Dim CurrentChars As String

        CurrentChars = Len(txtBrief.Text)
        lblBrief.Text = "Brief: " & CurrentChars & "/" & TotalChars
    End Sub

    Private Sub rtbComment_TextChanged(sender As Object, e As EventArgs) Handles rtbComment.TextChanged
        Dim TotalChars As String = "4096"
        Dim CurrentChars As String

        CurrentChars = Len(rtbComment.Text)
        lblComment1.Text = "Comment1: " & CurrentChars & "/" & TotalChars
    End Sub

    Private Sub rtbFurtherComment_TextChanged(sender As Object, e As EventArgs) Handles rtbFurtherComment.TextChanged
        Dim TotalChars As String = "4096"
        Dim CurrentChars As String

        CurrentChars = Len(rtbFurtherComment.Text)
        lblComment2.Text = "Comment2: " & CurrentChars & "/" & TotalChars
        Me.SelectedArea = rtbFurtherComment.SelectedRtf

    End Sub

    Private Sub imgCalendar_InsertEntryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_InsertEntryDate.Click
        Dim dtNow As DateTime
        Dim strNow As String

        dtNow = Now()
        strNow = dtNow.ToString("dd/MMM/yyyy HH:mm:ss")
        Me.txtEntryDate.Text = strNow
    End Sub
End Class