Public Class frmPlanetEntry
    Private _ResourceID As String
    Private _WaypointID As String
    Private _StructureID As String
    Private _BaseID As String
    Private _IsUpdated As Integer
    Public Property GetResourceID() As String
        Get
            Return _ResourceID
        End Get
        Set(value As String)
            _ResourceID = value
        End Set
    End Property

    Public Property GetWaypointID() As String
        Get
            Return _WaypointID
        End Get
        Set(value As String)
            _WaypointID = value
        End Set
    End Property

    Public Property GetStructureID() As String
        Get
            Return _StructureID
        End Get
        Set(value As String)
            _StructureID = value
        End Set
    End Property

    Public Property GetBaseID() As String
        Get
            Return _BaseID
        End Get
        Set(value As String)
            _BaseID = value
        End Set
    End Property

    Public Property IsUpdated() As Integer
        Get
            Return _IsUpdated
        End Get
        Set(value As Integer)
            _IsUpdated = value
        End Set
    End Property

    Dim CurrentSelectedIndex As Char
    Dim CurrentPosition As Integer
    Dim GlyphSelectionFrame As ScrollableControl
    Dim strAccountID As Integer = 1
    Dim strSystemID As Integer = 1
    Dim strPlanetID As Integer = 1
    Sub Save_The_Planet()
        'SAVE THE PLANET - ha ha
        'check if already saved. INSERT or UPDATE ?

        'CREATE TABLE IF Not EXISTS `tblplanets` (
        ' `ID` int(11) Not NULL AUTO_INCREMENT,
        '`OriginalPlanetName` varchar(50) Not NULL,
        '`RenamedPlanetName` varchar(50) Not NULL,
        '`AccountID` int(11) Not NULL DEFAULT '0',
        '`SystemID` int(11) Not NULL DEFAULT '0',
        '`Weather` varchar(100) Not NULL,
        '`Resources` varchar(255) Not NULL,
        '`TotalFauna` int(11) Not NULL DEFAULT '0',
        '`TotalFlora` int(11) Not NULL DEFAULT '0',
        '`TotalWaypointsDiscovered` int(11) Not NULL DEFAULT '0',
        '`Sentinals` varchar(50) Not NULL DEFAULT '',
        '`PortalGlyphCode` varchar(20) Not NULL,
        '`GalacticAddress` varchar(20) Not NULL,
        '`TotalBases` int(11) Not NULL DEFAULT '0',
        '`DiscoveredBy` varchar(50) Not NULL DEFAULT '0',
        '`PersonalDiscoveryDate` datetime DEFAULT '1970-01-01 00:00:00',
        '`Comments` text,
        '`ExtremeWeather` int(11) DEFAULT '0',
        '`Updated` datetime DEFAULT '1970-01-01 00:00:00',
        'PRIMARY KEY(`ID`)
        ') ENGINE=InnoDB DEFAULT CHARSET=utf32;


        Dim strPlanetName As String
        Dim strRenamedPlanet As String
        Dim strPlanetGlyphCode As String
        Dim strGalacticAddress As String
        Dim strTotalResources As String
        Dim strTotalFauna As String
        Dim strTotalFlora As String
        Dim strTotalWaypointsDiscovered As String
        Dim strTotalBases As String
        Dim strTotalStructures As String
        Dim strSentinalInfo As String
        Dim dtDiscoveryDate As DateTime
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strWeather As String
        Dim strExtremeWeather As String 'YES/NO
        Dim strSubmitTime As String
        Dim strComments As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblPlanets"
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
        Dim FoundPlanet As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim strResourceNotes As String
        Dim Answer As Integer
        Dim NULLDATE As String = "1970-01-01 01:00"
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.
        dtCurrentDate = Now()
        ErrMessages = ""
        If IsNumeric(Me.txtPlanetID.Text) Then
            strPlanetID = CInt(Me.txtPlanetID.Text)
        Else
            strPlanetID = 1
        End If
        If IsNumeric(Me.txtAccountID.Text) Then
            strAccountID = CInt(Me.txtAccountID.Text)
        Else
            strAccountID = 1
        End If
        If IsNumeric(Me.txtSystemID.Text) Then
            strSystemID = CInt(Me.txtSystemID.Text)
        Else
            strSystemID = 1
        End If

        strPlanetName = Me.txtPlanetName.Text
        strRenamedPlanet = Me.txtRenamedPlanet.Text
        strResourceNotes = Me.txtResourceNotes.Text
        strPlanetGlyphCode = Me.txtPlanetGlyphCode.Text
        strTotalFauna = Me.txtTotalFauna.Text
        strTotalFlora = Me.txtTotalFlora.Text
        strTotalBases = Me.txtTotalBases.Text
        strTotalResources = Me.txtTotalResources.Text
        strTotalStructures = Me.txtTotalStructures.Text
        strTotalWaypointsDiscovered = Me.txtTotalWaypoints.Text
        strSentinalInfo = Me.txtSentinalInfo.Text
        strGalacticAddress = Me.txtGalacticAddress.Text
        If IsDate(Me.txtDiscoveryDate.Text) Then
            strDiscoveryDate = Me.txtDiscoveryDate.Text
            dtDiscoveryDate = CDate(strDiscoveryDate)
            strDiscoveryDate = dtDiscoveryDate.ToString("yyyy-MM-dd HH:MM:ss")
        Else
            strDiscoveryDate = NULLDATE
            dtDiscoveryDate = CDate(strDiscoveryDate)
            strDiscoveryDate = dtDiscoveryDate.ToString("yyyy-MM-dd HH:MM:ss")
        End If
        strDiscoveredBy = Me.txtDiscoveredBy.Text
        strExtremeWeather = Me.txtExtremeWeather.Text
        strWeather = Me.txtWeather.Text
        strComments = Me.txtComments.Text
        strSubmitTime = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")

        FieldNames = "OriginalPlanetName"
        FieldNames = FieldNames & ",RenamedPlanetName"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",SystemID"
        FieldNames = FieldNames & ",Weather"
        FieldNames = FieldNames & ",Resources"
        FieldNames = FieldNames & ",TotalFauna"
        FieldNames = FieldNames & ",TotalFlora"
        FieldNames = FieldNames & ",TotalWaypointsDiscovered"
        FieldNames = FieldNames & ",TotalStructures"
        FieldNames = FieldNames & ",TotalResources"
        FieldNames = FieldNames & ",TotalBases"
        FieldNames = FieldNames & ",Sentinals"
        FieldNames = FieldNames & ",PortalGlyphCode"
        FieldNames = FieldNames & ",GalacticAddress"
        FieldNames = FieldNames & ",DiscoveredBy"
        FieldNames = FieldNames & ",PersonalDiscoveryDate"
        FieldNames = FieldNames & ",Comments"
        FieldNames = FieldNames & ",ExtremeWeather"
        FieldNames = FieldNames & ",Updated"

        FieldValues = strPlanetName
        FieldValues = FieldValues & "," & strRenamedPlanet
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strSystemID
        FieldValues = FieldValues & "," & strWeather
        FieldValues = FieldValues & "," & strResourceNotes
        FieldValues = FieldValues & "," & strTotalFauna
        FieldValues = FieldValues & "," & strTotalFlora
        FieldValues = FieldValues & "," & strTotalWaypointsDiscovered
        FieldValues = FieldValues & "," & strTotalStructures
        FieldValues = FieldValues & "," & strTotalResources
        FieldValues = FieldValues & "," & strTotalBases
        FieldValues = FieldValues & "," & strSentinalInfo
        FieldValues = FieldValues & "," & strPlanetGlyphCode
        FieldValues = FieldValues & "," & strGalacticAddress
        FieldValues = FieldValues & "," & strDiscoveredBy
        FieldValues = FieldValues & "," & strDiscoveryDate
        FieldValues = FieldValues & "," & strComments
        FieldValues = FieldValues & "," & strExtremeWeather
        FieldValues = FieldValues & "," & strSubmitTime

        SearchText = strPlanetID
        SearchField = "PlanetID"
        ReturnField = "PlanetID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "PlanetID"
        ExcludeFields = ""
        FoundPlanet = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundPlanet Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Planet Already EXISTS - Proceed with update?", vbYesNo, "PLANET ALREADY EXISTS")
            If Answer = vbYes Then
                UpdateCriteria = "PlanetID = " & ReturnValue
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
            MsgBox("OK Planet Info Entered")
        Else
            MsgBox("Problem: Planet Info NOT SAVE")
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'SAVE PLANET DETAILS:
        Call Save_The_Planet()

    End Sub

    Private Sub frmPlanetEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LOAD PROCEDURE:
        ComponentManager.Initialise()
        KeyPreview = True
        CurrentPosition = 1
        CurrentSelectedIndex = "1"
        Me.IsUpdated = 0
        Me.AllowDrop = True
    End Sub

    Public Sub SetupAccountCombo()
        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        strSQL = "SELECT * FROM tblAccounts WHERE UserID=" & CInt(frmMain.myUserID)
        myDAL.PopulateMyDataSource(Nothing, frmMain.myConnString, strSQL, NumRows, ErrMessage, dt)

        'Dim DAL as new DataLayer
        'dt = dal.GetComboItems(ConnString)
        comAccounts.DataSource = dt
        comAccounts.ValueMember = "AccountID"
        comAccounts.DisplayMember = "AccountName"
        comAccounts.SelectedText = ""
        comAccounts.Text = ""
    End Sub

    Public Sub SetupSystemsCombo()
        Dim dt As DataTable
        Dim NumRows As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim userID As Integer
        Dim AccountID As Integer
        Dim ErrMessage As String
        Dim strSQL As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        If Len(txtAccountID.Text) = 0 Then
            Exit Sub
        End If
        strSQL = "SELECT * FROM tblSystems WHERE AccountID=" & CInt(txtAccountID.Text) & " AND UserID=" & CInt(frmMain.myUserID)
        myDAL.PopulateMyDataSource(Nothing, frmMain.myConnString, strSQL, NumRows, ErrMessage, dt)
        txtTotalSystems.Text = CStr(NumRows)
        'Dim DAL as new DataLayer
        'dt = dal.GetComboItems(ConnString)
        comSystems.DataSource = dt
        comSystems.ValueMember = "SystemID"
        comSystems.DisplayMember = "OriginalSystemName"
        comSystems.SelectedText = ""
        comSystems.Text = ""
        'dtSystems = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblSystems WHERE AccountID=" & AccountID, NumRows)

    End Sub

    Private Sub frmPlanetEntry_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'SHOWN PROCEDURE:
        'LOAD UP PICTURE BOXES WITH CORRECT GLYPHS - SELECTPB0 ETC.
        'LOOP AROUND EACH FILE AND ATTACH TO EACH CONTROL. 
        Dim FoundControl As Control
        Dim tempControl As clsDG_NMS_Controls
        Dim Prefix As String
        Dim Suffix As String = "0"
        Dim GlyphIDX As Integer = 0
        Dim GlyphCharIDX As Integer = 48
        Dim ControlName As String
        Dim LabelName As String
        Dim ControlTag As String
        Dim ItemIDX As Integer = 0
        Dim glyphControlLeft As Integer
        Dim glyphControlTop As Integer
        Dim glyphControlWidth As Integer
        Dim glyphControlHeight As Integer
        Dim lblControlLeft As Integer
        Dim lblControlTop As Integer
        Dim lblControlWidth As Integer
        Dim lblControlHeight As Integer
        Dim GlyphCode As String
        Dim NumRows As Integer = 0
        Dim DsourceErrMessage As String = ""
        Dim AccountSource As New DataTable
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim dtPlanets As DataTable
        Dim dtResources As DataTable
        Dim dtWaypoints As DataTable
        Dim dtBases As DataTable
        Dim dtStructures As DataTable

        'SETUP COMBOS:
        'comAccounts
        'comSystems
        'comResources
        'comWaypoints
        'comStructures
        'comBases
        ItemIDX = 0
        Prefix = "GLYPH"
        GlyphIDX = 0
        Do While ItemIDX < 16
            If ItemIDX = 10 Then
                GlyphIDX = 0
            End If
            If ItemIDX < 10 Then
                GlyphCode = Chr(48 + GlyphIDX)
            Else
                GlyphCode = Chr(65 + GlyphIDX)
            End If

            'GlyphCode = Chr(48 + GlyphIDX)
            ControlName = Prefix & GlyphCode
            LabelName = "lbl" & Prefix & GlyphCode
            ControlTag = GlyphCode
            glyphControlWidth = 50
            glyphControlHeight = 50
            lblControlWidth = 10
            lblControlHeight = 17
            glyphControlTop = 5
            lblControlTop = 59
            glyphControlLeft = 5 + (ItemIDX * 55)
            lblControlLeft = 24 + (ItemIDX * 55)
            Call AddNewPictureBox(ControlName, True, glyphList.Images.Item(ItemIDX), Nothing, ControlName,
                                  glyphControlLeft, glyphControlTop, glyphControlWidth, glyphControlHeight,
                                  ControlTag, Frame_PlanetGlyphPallet, "STRETCH", "RoyalBlue")
            Call AddNewControl(LabelName, True, Frame_PlanetGlyphPallet, "",
                                    lblControlLeft, lblControlTop, lblControlWidth, 0, LabelName, "LABEL", Nothing, True, "DeepSkyBlue", "0,0,0",
                                    Nothing, GlyphCode, LabelName, "CAMBRIA", 11, "")
            GlyphIDX += 1
            ItemIDX += 1
        Loop

        'Place the 12  blank picture boxes on the PlanetGlyphSet frame:
        ItemIDX = 1
        Prefix = "PB"
        Do While ItemIDX < 13
            GlyphCode = CStr(ItemIDX)
            ControlName = Prefix & GlyphCode
            ControlTag = Prefix & GlyphCode 'Deliberate as GLYPH is NOT set yet. So TAG will be PB1 to PB12.
            glyphControlWidth = 40
            glyphControlHeight = 40
            glyphControlTop = 5
            glyphControlLeft = 5 + ((ItemIDX - 1) * 45)
            Call AddNewPictureBox(ControlName, True, glyphList.Images.Item(16), Nothing, ControlName,
                                  glyphControlLeft, glyphControlTop, glyphControlWidth, glyphControlHeight,
                                  ControlName, Frame_PlanetGlyphSet, "STRETCH", "AliceBlue")
            ItemIDX += 1
        Loop

        Me.txtPlanetGlyphCode.Text = "............"
        dtPlanets = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblPlanets WHERE UserID=" & CInt(frmMain.myUserID), NumRows)
        dgvPlanets.DataSource = dtPlanets
        txtTotalPlanets.Text = CStr(NumRows)
        'PopulateMyDataSource(dgvPlanets.DataSource, frmMain.myConnString, "SELECT * FROM tblAccounts order by AccountName", NumRows, DsourceErrMessage, AccountSource)
        If NumRows > 0 Then
            dgvPlanets.ClearSelection()
            dgvPlanets.CurrentCell = dgvPlanets.Rows(0).Cells(0)
            dgvPlanets.Rows(0).Selected = True
            Call ViewSelectedAcount(0)
            'Me.comAccounts.DataSource = AccountSource
            'comAccounts.DisplayMember = AccountSource.Columns("AccountName").ToString
            'comAccounts.ValueMember = AccountSource.Columns("AccountID").ToString
            'comAccounts.Text = AccountSource.Rows(0)("AccountName").ToString
            'comAccounts.ValueMember = AccountSource.Columns("AccountID").ToString
        End If

        'Find Control to put image into:
        'FoundControl = frmMain.FindControls("Planet_Entry", "PB12", "")
        SetupAccountCombo()
        SetupSystemsCombo()


    End Sub

    Public Sub PopulateGrids(strPlanetID As String)
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim dtPlanets As DataTable
        Dim dtResources As DataTable
        Dim dtWaypoints As DataTable
        Dim dtBases As DataTable
        Dim dtStructures As DataTable
        Dim NumRows As Integer
        Dim ResourceFields As String
        Dim WaypointFields As String
        Dim StructureFields As String
        Dim BaseFields As String
        Dim ResourceSQL As String
        Dim WaypointSQL As String
        Dim BaseSQL As String
        Dim StructureSQL As String
        Dim strAccountID As String

        ResourceFields = DAL.GetColumnNames_From_Prefs(frmMain.myConnString, frmMain.myUserID, "tblResources")
        If Len(ResourceFields) = 0 Then
            ResourceFields = "ResourceName as 'Resource Name',ResourceLongCoords as 'N/S Coords',ResourceLatCoords as 'E/W Coords'"
            ResourceFields = ResourceFields & ",PowerGridLongCoords as 'N/S Power Coords',PowerGridLatCoords as 'E/W Power Coords'"
            ResourceFields = ResourceFields & ",PowerYield as 'Power Yield',AmountResourceYielded as 'Yield',ResourceType as 'Type'"
            ResourceFields = ResourceFields & ",DiscoveryDate as 'Discovery Date',AmountExtracted as 'Amount Extracted'"
            ResourceFields = ResourceFields & ",LastUpdated,ResourceID as 'ID'"
        End If

        'ResourceFields = "ResourceName as 'Resource Name',ResourceLongCoords as 'N/S Coords',ResourceLatCoords as 'E/W Coords'"
        'ResourceFields = ResourceFields & ",PowerGridLongCoords as 'N/S Power Coords',PowerGridLatCoords as 'E/W Power Coords'"
        'ResourceFields = ResourceFields & ",PowerYield as 'Power Yield',AmountResourceYielded as 'Yield',ResourceType as 'Type'"
        'ResourceFields = ResourceFields & ",DiscoveryDate as 'Discovery Date',AmountExtracted as 'Amount Extracted'"
        'ResourceFields = ResourceFields & ",LastUpdated,ResourceID as 'ID'"

        WaypointFields = "WaypointName as 'Name',WaypointLongCoords as 'N/S Coords',WaypointLatCoords as 'E/W Coords'"
        WaypointFields += ",DiscoveryDate as 'Discovery Date',DiscoveredBy as 'Discovered By'"
        WaypointFields += ",LastUpdated,WeypointID as 'ID'"

        StructureFields = "StructureName as 'Name',StructureLongCoords as 'N/S',StructureLatCoords as 'E/W',DiscoveryDate as 'Discovery Date'"
        StructureFields += ",DiscoveredBy as 'Discovered By',Notes"
        StructureFields += ",LastUpdated,StructureID as 'ID'"

        BaseFields = "OriginalBaseName as 'Original Name',RenamedBaseName as 'Renamed',LastUpdated as 'Last Update',MaterialsUsed as 'Materials Used'"
        BaseFields += ",BaseSize as 'Base Size',BaseLongitude as 'N/S Coords',BaseLatitude as 'E/W Coords'"
        BaseFields += ",DiscoveryDate as 'Discovery Date',DiscoveredBy as 'Discovered By',BaseDescription as 'Description',Comments,DefaultBase as 'DEFAULT'"
        strAccountID = txtAccountID.Text
        If IsNumeric(strPlanetID) Then
            If CInt(strPlanetID) > 0 Then
                ResourceSQL = "SELECT " & ResourceFields & " FROM tblResources WHERE UserID=" & CInt(frmMain.myUserID)
                ResourceSQL += " AND PlanetID=" & CInt(strPlanetID) & " AND AccountID=" & CInt(strAccountID)
                dtResources = DAL.GetDataTable(frmMain.myConnString, ResourceSQL, NumRows)
                dgvResources.DataSource = dtResources
                txtTotalResources.Text = CStr(NumRows)
                If NumRows > 0 Then
                    dgvResources.ClearSelection()
                    dgvResources.CurrentCell = dgvResources.Rows(0).Cells(0)
                    dgvResources.Rows(0).Selected = True
                    'Enable Right-Click MENU:
                    'SET dgvResources GRID PROPERTIES:
                    dgvResources.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvResources.AllowUserToOrderColumns = True
                    dgvResources.AllowUserToResizeColumns = True
                    dgvResources.AllowUserToResizeRows = True
                    dgvResources.AllowUserToAddRows = False
                    dgvResources.AllowUserToDeleteRows = False
                    Me.IsUpdated = 0
                    Me.ResourceContextMenu.Items(0).Enabled = True
                    Me.ResourceContextMenu.Items(1).Enabled = True
                    Me.ResourceContextMenu.Items(2).Enabled = True
                Else
                    Me.ResourceContextMenu.Items(0).Enabled = True
                    Me.ResourceContextMenu.Items(1).Enabled = False
                    Me.ResourceContextMenu.Items(2).Enabled = False
                End If

                WaypointSQL = "SELECT " & WaypointFields & " FROM tblWaypoints WHERE UserID=" & CInt(frmMain.myUserID)
                WaypointSQL += " AND PlanetID=" & CInt(strPlanetID) & " AND AccountID=" & CInt(strAccountID)
                dtWaypoints = DAL.GetDataTable(frmMain.myConnString, WaypointSQL, NumRows)
                dgvWaypoints.DataSource = dtWaypoints
                txtTotalWaypoints.Text = CStr(NumRows)
                If NumRows > 0 Then
                    dgvWaypoints.ClearSelection()
                    dgvWaypoints.CurrentCell = dgvWaypoints.Rows(0).Cells(0)
                    dgvWaypoints.Rows(0).Selected = True
                    'SET dgvWaypoints GRID PROPERTIES:
                    dgvWaypoints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvWaypoints.AllowUserToOrderColumns = True
                    dgvWaypoints.AllowUserToResizeColumns = True
                    dgvWaypoints.AllowUserToResizeRows = True
                    dgvWaypoints.AllowUserToAddRows = False
                    dgvWaypoints.AllowUserToDeleteRows = False
                    Me.IsUpdated = 0
                    Me.WaypointContextMenu.Items(0).Enabled = True
                    Me.WaypointContextMenu.Items(1).Enabled = True
                    Me.WaypointContextMenu.Items(2).Enabled = True
                Else
                    Me.WaypointContextMenu.Items(0).Enabled = True
                    Me.WaypointContextMenu.Items(1).Enabled = False
                    Me.WaypointContextMenu.Items(2).Enabled = False
                End If

                StructureSQL = "SELECT " & StructureFields & " FROM tblStructures WHERE UserID=" & CInt(frmMain.myUserID)
                StructureSQL += " AND PlanetID=" & CInt(strPlanetID) & " AND AccountID=" & CInt(strAccountID)
                dtStructures = DAL.GetDataTable(frmMain.myConnString, StructureSQL, NumRows)
                dgvStructures.DataSource = dtStructures
                txtTotalStructures.Text = CStr(NumRows)
                If NumRows > 0 Then
                    dgvStructures.ClearSelection()
                    dgvStructures.CurrentCell = dgvStructures.Rows(0).Cells(0)
                    dgvStructures.Rows(0).Selected = True
                    'SET dgvStructures GRID PROPERTIES:
                    dgvStructures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvStructures.AllowUserToOrderColumns = True
                    dgvStructures.AllowUserToResizeColumns = True
                    dgvStructures.AllowUserToResizeRows = True
                    dgvStructures.AllowUserToAddRows = False
                    dgvStructures.AllowUserToDeleteRows = False
                    Me.IsUpdated = 0
                    Me.StructureContextMenu.Items(0).Enabled = True
                    Me.StructureContextMenu.Items(1).Enabled = True
                    Me.StructureContextMenu.Items(2).Enabled = True
                Else
                    Me.StructureContextMenu.Items(0).Enabled = True
                    Me.StructureContextMenu.Items(1).Enabled = False
                    Me.StructureContextMenu.Items(2).Enabled = False
                End If

                BaseSQL = "SELECT " & BaseFields & " FROM tblBases WHERE UserID=" & CInt(frmMain.myUserID)
                BaseSQL += " AND PlanetID=" & CInt(strPlanetID) & " AND AccountID=" & CInt(strAccountID)
                dtBases = DAL.GetDataTable(frmMain.myConnString, BaseSQL, NumRows)
                dgvBases.DataSource = dtBases
                txtTotalBases.Text = CStr(NumRows)
                If NumRows > 0 Then
                    dgvBases.ClearSelection()
                    dgvBases.CurrentCell = dgvBases.Rows(0).Cells(0)
                    dgvBases.Rows(0).Selected = True
                    'SET dgvBases GRID PROPERTIES:
                    dgvBases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    dgvBases.AllowUserToOrderColumns = True
                    dgvBases.AllowUserToResizeColumns = True
                    dgvBases.AllowUserToResizeRows = True
                    dgvBases.AllowUserToAddRows = False
                    dgvBases.AllowUserToDeleteRows = False
                    Me.IsUpdated = 0
                    Me.BaseContextMenu.Items(0).Enabled = True
                    Me.BaseContextMenu.Items(1).Enabled = True
                    Me.BaseContextMenu.Items(2).Enabled = True
                Else
                    Me.BaseContextMenu.Items(0).Enabled = True
                    Me.BaseContextMenu.Items(1).Enabled = False
                    Me.BaseContextMenu.Items(2).Enabled = False
                End If
            End If
        End If
    End Sub

    Public Sub PopulateForm(PlanetID As Integer)
        Dim SearchText As String = CStr(PlanetID)
        Dim SearchField As String = "PlanetID"
        Dim ReturnField As String = "PlanetName"
        Dim ReturnValue As Object = Nothing
        Dim FieldType As String = "INTEGER"
        Dim Reversed As Boolean = True
        Dim SortFields As String = "PlanetID"
        Dim ExcludeFields As String = ""
        Dim FoundPlanet As Boolean = False
        Dim FoundAccount As Boolean = False
        Dim FoundSystem As Boolean = False
        Dim AllValues As Object() = Nothing
        Dim AllFields As String() = Nothing
        Dim SearchCriteria As String
        Dim DBTable As String = "tblPlanets"
        Dim ErrMessage As String = ""
        Dim strPlanetID As String
        Dim strPlanetNAme As String
        Dim strRenamedPlanetName As String
        Dim strAccountID As String
        Dim strPlatform As String
        Dim strVersion As String
        Dim strAccountName As String
        Dim strSystemID As String
        Dim strSystemName As String
        Dim strDefaultSystem As String
        Dim strGalacticRegion As String
        Dim strWeather As String
        Dim strResources As String
        Dim strTotalFauna As String
        Dim strTotalFlora As String
        Dim strTotalWaypointsDiscovered As String
        Dim strTotalSTructures As String
        Dim strTotalREsources As String
        Dim strTotalBases As String
        Dim strSentinals As String
        Dim strPortalGlyphCode As String
        Dim strGalacticAddress As String
        Dim strDiscoveredBy As String
        Dim strPersonalDiscoveryDate As String
        Dim strComments As String
        Dim strExtremeWeather As String
        Dim AccountSource As New DataTable
        Dim NumRows As Long
        Dim DsourceErrMessage As String = ""
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        SearchText = CStr(PlanetID)
        SearchField = "PlanetID"
        ReturnField = "PlanetID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "PlanetID"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        DBTable = "tblPlanets"
        FoundPlanet = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundPlanet Then
            'MsgBox("FOUND PLANET ID")
            strPlanetID = GetValuebyFieldname(AllValues, AllFields, "PlanetID")
            Me.txtPlanetID.Text = strPlanetID
            strPlanetNAme = GetValuebyFieldname(AllValues, AllFields, "OriginalPlanetName")
            Me.txtPlanetName.Text = strPlanetNAme
            strRenamedPlanetName = GetValuebyFieldname(AllValues, AllFields, "RenamedPlanetName")
            Me.txtRenamedPlanet.Text = strRenamedPlanetName
            strPortalGlyphCode = GetValuebyFieldname(AllValues, AllFields, "PortalGlyphCode")
            Me.txtPlanetGlyphCode.Text = strPortalGlyphCode
            strAccountID = GetValuebyFieldname(AllValues, AllFields, "AccountID")
            Me.txtAccountID.Text = strAccountID
            strSystemID = GetValuebyFieldname(AllValues, AllFields, "SystemID")
            Me.txtSystemID.Text = strSystemID
            strGalacticAddress = GetValuebyFieldname(AllValues, AllFields, "GalacticAddress")
            Me.txtGalacticAddress.Text = strGalacticAddress
            strTotalREsources = GetValuebyFieldname(AllValues, AllFields, "TotalResources")
            Me.txtTotalResources.Text = strTotalREsources
            strResources = GetValuebyFieldname(AllValues, AllFields, "Resources")
            Me.txtResourceNotes.Text = strResources
            strTotalFauna = GetValuebyFieldname(AllValues, AllFields, "TotalFauna")
            Me.txtTotalFauna.Text = strTotalFauna
            strTotalFlora = GetValuebyFieldname(AllValues, AllFields, "TotalFlora")
            Me.txtTotalFlora.Text = strTotalFlora
            strTotalWaypointsDiscovered = GetValuebyFieldname(AllValues, AllFields, "TotalWaypointsDiscovered")
            Me.txtTotalWaypoints.Text = strTotalWaypointsDiscovered
            strTotalSTructures = GetValuebyFieldname(AllValues, AllFields, "TotalStructures")
            Me.txtTotalStructures.Text = strTotalSTructures
            strTotalBases = GetValuebyFieldname(AllValues, AllFields, "TotalBases")
            Me.txtTotalBases.Text = strTotalBases
            strSentinals = GetValuebyFieldname(AllValues, AllFields, "Sentinals")
            Me.txtSentinalInfo.Text = strSentinals
            strDiscoveredBy = GetValuebyFieldname(AllValues, AllFields, "DiscoveredBy")
            Me.txtDiscoveredBy.Text = strDiscoveredBy
            strPersonalDiscoveryDate = GetValuebyFieldname(AllValues, AllFields, "PersonalDiscoveryDate")
            If IsDate(strPersonalDiscoveryDate) Then
                Me.txtDiscoveryDate.Text = CDate(strPersonalDiscoveryDate).ToString("dd/MM/yyyy HH:mm:ss")
            End If
            strExtremeWeather = GetValuebyFieldname(AllValues, AllFields, "ExtremeWeather")
            Me.txtExtremeWeather.Text = strExtremeWeather
            strComments = GetValuebyFieldname(AllValues, AllFields, "Comments")
            Me.txtComments.Text = strComments
            'Display rest of Account details - search strAccountID
            SearchText = strAccountID
            SearchField = "AccountID"
            ReturnField = "AccountID"
            ReturnValue = ""
            FieldType = "INTEGER"
            Reversed = True
            SortFields = "PlanetID"
            ExcludeFields = ""
            SearchCriteria = ""
            DBTable = "tblAccounts"
            FoundAccount = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
            If FoundAccount Then
                strAccountName = GetValuebyFieldname(AllValues, AllFields, "AccountName")
                Me.txtAccountName.Text = strAccountName
                strPlatform = GetValuebyFieldname(AllValues, AllFields, "GamePlatform")
                Me.txtPlatform.Text = strPlatform
                strVersion = GetValuebyFieldname(AllValues, AllFields, "GameVersion")
                Me.txtVersion.Text = strVersion
            End If
            SearchText = strSystemID
            SearchField = "AccountID"
            ReturnField = "AccountID"
            ReturnValue = ""
            FieldType = "INTEGER"
            Reversed = True
            SortFields = "PlanetID"
            ExcludeFields = ""
            SearchCriteria = ""
            DBTable = "tblSystems"
            FoundSystem = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
            If FoundSystem Then
                strSystemName = GetValuebyFieldname(AllValues, AllFields, "SystemName")
                Me.txtCurrentSystem.Text = strSystemName
                strGalacticRegion = GetValuebyFieldname(AllValues, AllFields, "GalacticRegion")
                Me.txtGalacticRegion.Text = strGalacticRegion
                strDefaultSystem = GetValuebyFieldname(AllValues, AllFields, "DefaultSystem")
            End If

            SearchText = "DEFAULT"
            SearchField = "DefaultSystem"
            ReturnField = "SystemName"
            ReturnValue = ""
            FieldType = "INTEGER"
            Reversed = True
            SortFields = "PlanetID"
            ExcludeFields = ""
            SearchCriteria = ""

            FoundSystem = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
            If FoundSystem Then
                strDefaultSystem = GetValuebyFieldname(AllValues, AllFields, "SystemName")
                Me.txtDefaultSystem.Text = strDefaultSystem

            End If


            GetGlyphsFromCode(strPortalGlyphCode)
        End If
    End Sub

    Public Sub CreatePlanetCode()
        'Cycle through each glyph in the collection and grab the tag name:
        Dim FinalCode As String
        Dim TagName As String
        Dim tempControl As clsDG_NMS_Controls
        Dim loopy As Integer
        Dim Prefix As String
        Dim GlyphKey As String

        tempControl = New clsDG_NMS_Controls
        Prefix = "PB"
        loopy = 1
        FinalCode = ""
        Do While loopy < 13
            GlyphKey = Prefix & CStr(loopy)
            tempControl = dic_Controls(GlyphKey)
            If tempControl IsNot Nothing Then
                TagName = tempControl.ControlTAG
            Else
                TagName = "."
            End If
            If Len(TagName) = 0 Then
                FinalCode += "."
            Else
                If InStr(TagName, "PB") > 0 Then
                    FinalCode += "."
                Else
                    FinalCode += TagName
                End If
            End If
            loopy += 1
        Loop
        txtPlanetGlyphCode.Text = FinalCode

    End Sub

    Public Sub GetGlyphsFromCode(PlanetCode As String)
        Dim FinalCode As String
        Dim tempControl As clsDG_NMS_Controls
        Dim loopy As Integer
        Dim PalletPrefix As String
        Dim PlanetGlyphPrefix As String
        Dim GlyphKey As String
        Dim ControlImage As Image
        Dim ControlTag As String
        Dim GlyphControl As Control
        Dim ControlName As String
        Dim glyphControlWidth As Integer
        Dim glyphControlHeight As Integer
        Dim glyphControlTop As Integer
        Dim glyphControlLeft As Integer
        Dim myPbox As PictureBox
        Dim FrameControl As Control
        Dim FoundGlyphControl As Control

        tempControl = New clsDG_NMS_Controls
        PlanetGlyphPrefix = "PB"
        PalletPrefix = "Glyph"

        If Len(PlanetCode) = 12 Then
            loopy = 1
            Do While loopy < 13
                GlyphKey = Mid(PlanetCode, loopy, 1)
                Select Case GlyphKey
                    Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"
                        tempControl = dic_Controls(PalletPrefix & GlyphKey)
                        If tempControl IsNot Nothing Then
                            If TypeOf (tempControl.TheControl) Is System.Windows.Forms.PictureBox Then
                                'ControlTag = PlanetGlyphPrefix & CStr(loopy)
                                ControlTag = GlyphKey
                                myPbox = CType(tempControl.TheControl, System.Windows.Forms.PictureBox)
                                ControlImage = myPbox.BackgroundImage
                                ControlName = PlanetGlyphPrefix & CStr(loopy)
                                'ControlImage = tempControl.ControlImage
                                'ControlImage = tempControl.TheControl.BackgroundImage
                                'ControlImage = glyphList.Images.Item(1)

                                'select glyph in planet panel:
                                FrameControl = tempControl.clsFindFormControl(myPbox.FindForm().Name, "Frame_PlanetGlyphSet")
                                FoundGlyphControl = tempControl.clsFindControl(FrameControl, ControlName, "")
                                If FoundGlyphControl IsNot Nothing Then
                                    FoundGlyphControl.BackgroundImage = ControlImage
                                    FoundGlyphControl.BackgroundImageLayout = ImageLayout.Stretch
                                    FoundGlyphControl.Tag = ControlTag

                                    glyphControlWidth = 40
                                    glyphControlHeight = 40
                                    glyphControlTop = 5
                                    glyphControlLeft = 5 + ((loopy - 1) * 45)
                                    Call AddNewPictureBox(ControlName, False, ControlImage, FoundGlyphControl, ControlName,
                                        FoundGlyphControl.Left, FoundGlyphControl.Top, FoundGlyphControl.Width, FoundGlyphControl.Height,
                                        ControlTag, Frame_PlanetGlyphSet, "STRETCH", "AliceBlue")
                                End If
                            Else
                                'tempControl.TheControl is not a picturebox
                            End If
                        End If

                    Case Else
                End Select

                loopy += 1
            Loop
        Else
            'NOT VALID:
            MsgBox("Planet Code NOT valid")
            Exit Sub
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'TEST Adding Form Controls:
        Dim Prefix As String = "Glyph"
        Dim Suffix As String = "0"
        Dim GlyphIDX As Integer = 0
        Dim GlyphCharIDX As Integer = 48
        Dim ControlName As String
        Dim LabelName As String
        Dim ControlTag As String
        Dim ItemIDX As Integer = 0
        Dim glyphControlLeft As Integer
        Dim glyphControlTop As Integer
        Dim glyphControlWidth As Integer
        Dim glyphControlHeight As Integer
        Dim lblControlLeft As Integer
        Dim lblControlTop As Integer
        Dim lblControlWidth As Integer
        Dim lblControlHeight As Integer
        Dim GlyphCode As String
        'Call AddFormControls(Me, "PICTUREBOX", "SelectPB0", "", "glyph1", 600, 150, 50, 50, glyphList.Images.Item(0))

        Do While ItemIDX < 16
            If ItemIDX = 10 Then
                GlyphIDX = 0
            End If
            If ItemIDX < 10 Then
                GlyphCode = Chr(48 + GlyphIDX)
            Else
                GlyphCode = Chr(65 + GlyphIDX)
            End If

            'GlyphCode = Chr(48 + GlyphIDX)
            ControlName = Prefix & GlyphCode
            LabelName = "lbl" & Prefix & GlyphCode
            ControlTag = GlyphCode
            glyphControlWidth = 50
            glyphControlHeight = 50
            lblControlWidth = 10
            lblControlHeight = 17
            glyphControlTop = 5
            lblControlTop = 59
            glyphControlLeft = 5 + (ItemIDX * 55)
            lblControlLeft = 24 + (ItemIDX * 55)
            Call AddNewPictureBox(ControlName, True, glyphList.Images.Item(ItemIDX), Nothing, ControlName,
                                  glyphControlLeft, glyphControlTop, glyphControlWidth, glyphControlHeight, ControlTag, Frame_PlanetGlyphPallet)
            Call AddNewControl(LabelName, True, Frame_PlanetGlyphPallet, "",
                                    lblControlLeft, lblControlTop, lblControlWidth, 0, LabelName, "LABEL", Nothing, True, "DeepSkyBlue", "0,0,0",
                                    Nothing, GlyphCode, LabelName, "CAMBRIA", 11, "")
            GlyphIDX += 1
            ItemIDX += 1
        Loop
        'Me.GlyphSelectionFrame.Left = 600
        'Me.GlyphSelectionFrame.Top = 300
        'Me.GlyphSelectionFrame.Width = 300
        'Me.GlyphSelectionFrame.Height = 70
        'Me.GlyphSelectionFrame.Parent = Me.pnlPlanetDetails
        'Me.GlyphSelectionFrame.Visible = True
        'Me.Controls.Add(Me.GlyphSelectionFrame)



    End Sub

    Private Sub SelectPB0_Click(sender As Object, e As EventArgs)
        'User has clicked this glyph 0:
        'Copy image to selection above:
        'INDEX for glyphlist = 0
        Me.txtSelectedGlyphIndex.Text = "0"

    End Sub

    Private Sub comAccounts_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Need to find the Account Name in the table to get the ID.
        Dim strReturnValue As String
        Dim strAccountID As String
        Dim idx As Integer
        Dim dt As New DataTable
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim SearchCriteria = ""
        Dim FieldType As String
        Dim Reversed As Boolean = True
        Dim SortFields As String
        Dim FoundAccount As Boolean = False
        Dim AllValues() As Object = Nothing
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim ExcludeFields As String = ""
        Dim DBTable As String = "tblAccounts"
        Dim strAccountName As String
        Dim strVersion As String
        Dim strPlatform As String

        'strAccountName = comAccounts
        'idx = comAccounts.SelectedIndex
        'dt = comAccounts.DataSource
        strAccountName = dt.Rows(idx)("AccountName").ToString
        strAccountID = dt.Rows(idx)("AccountID").ToString
        strVersion = dt.Rows(idx)("GameVersion").ToString
        strPlatform = dt.Rows(idx)("GamePlatform").ToString
        SearchText = strAccountName
        SearchField = "AccountName"
        ReturnField = "ID"
        ReturnValue = ""
        FieldType = "STRING"
        Reversed = True
        SortFields = "AccountName"
        ExcludeFields = ""
        'FoundAccount = Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, ReturnField, ReturnValue, AllValues,
        'AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        'If FoundAccount Then

        'strVersion = GetMYValuebyFieldname(AllValues, AllFields, "GameVersion")
        'strPlatform = GetMYValuebyFieldname(AllValues, AllFields, "GamePlatform")
        'strAccountID = GetMYValuebyFieldname(AllValues, AllFields, "AccountID")
        Me.txtAccountName.Text = strAccountName
        Me.txtVersion.Text = strVersion
        Me.txtPlatform.Text = strPlatform
        Me.txtAccountID.Text = strAccountID
        'Else
        'NOT FOUND:
        SetupSystemsCombo()

        'End If

        'dt = comAccounts.DataSource
        'strReturnValue = comAccounts.SelectedValue

        'strAccountID = dt.Columns("AccountID").ToString
        'strGamePlatform = dt.Columns("GamePlatform").ToString
        'strGameVersion = dt.Columns("GameVersion").ToString
        'MsgBox(strAccountID & " " & strReturnValue & " " & strGamePlatform & " " & strGameVersion)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub AddResource()
        'ADD RESOURCE to tblResources:
        'This is a prelim addition - there are more details that can be added with a separate form - activated
        ' by right-click of mouse to bring up a context menu.
        'comResources - does this need to be a combo-box ???
        'Well .... each element that is added can also be added to a base index - available to all accounts and planets to start with.
        'Main purpose is to store the resource and its location and quantity that was yielded when extracted / mined. 
        'Could also introduce another field - potential yield.
        'OPEN FORM TO ENTER DETAILS:
        Dim ResourceForm As New frmResourceEntry
        Dim frmName As String
        Dim SearchName As String = "Resource_Entry"
        Dim OpenForm As Form
        Dim ResourceID As String

        If Not IsNumeric(txtPlanetID.Text) Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            ResourceID = "0"
            ResourceForm.Name = SearchName
            ResourceForm.Text = "Enter Resource Information"
            ResourceForm.MdiParent = frmMain
            ResourceForm.StartPosition = FormStartPosition.Manual
            ResourceForm.Top = 20
            ResourceForm.Left = 5
            ResourceForm.Width = 1500
            ResourceForm.Height = 960
            ResourceForm.Planet_ID = txtPlanetID.Text
            ResourceForm.Resource_ID = ResourceID
            ResourceForm.Account_ID = txtAccountID.Text
            ResourceForm.Show()
        End If
    End Sub

    Public Sub EditResource()
        Dim ResourceForm As New frmResourceEntry
        Dim frmName As String
        Dim SearchName As String = "Resource_Entry"
        Dim OpenForm As Form
        Dim ResourceID As String

        If Not IsNumeric(txtPlanetID.Text) Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            ResourceID = dgvResources.CurrentRow.Cells("ID").Value

            ResourceForm.Name = SearchName
            ResourceForm.Text = "Enter Resource Information"
            ResourceForm.MdiParent = frmMain
            ResourceForm.StartPosition = FormStartPosition.Manual
            ResourceForm.Top = 20
            ResourceForm.Left = 5
            ResourceForm.Width = 1500
            ResourceForm.Height = 960
            ResourceForm.Planet_ID = txtPlanetID.Text
            ResourceForm.Resource_ID = ResourceID
            ResourceForm.Account_ID = txtAccountID.Text
            ResourceForm.Show()
        End If
    End Sub

    Sub RemoveResource()
        Dim ResourceID As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim Message As String

        If IsDBNull(dgvStructures.CurrentRow.Cells("ID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        ResourceID = dgvResources.CurrentRow.Cells("ID").Value
        If DAL.DeleteMyRecord("tblResources", frmMain.myConnString, "ResourceID=" & CInt(ResourceID), Message) Then
            If Len(Message) > 0 Then
                MsgBox(Message)
            End If
        End If
        DAL = Nothing

    End Sub

    Sub AddWaypoint()
        Dim EntryForm As New frmWaypointEntry
        Dim frmName As String
        Dim SearchName As String = "Waypoint_Entry"
        Dim OpenForm As Form
        Dim WaypointID As String

        If Not IsNumeric(txtPlanetID.Text) Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            WaypointID = "0"
            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Waypoint Information"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.Waypoint_ID = WaypointID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub EditWaypoint()
        Dim EntryForm As New frmWaypointEntry
        Dim frmName As String
        Dim SearchName As String = "Waypoint_Entry"
        Dim OpenForm As Form
        Dim WaypointID As String

        If Not IsNumeric(txtPlanetID.Text) Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            WaypointID = dgvWaypoints.CurrentRow.Cells("ID").Value

            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Waypoint Information"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.Waypoint_ID = WaypointID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub RemoveWaypoint()
        Dim WaypointID As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim Message As String

        If IsDBNull(dgvStructures.CurrentRow.Cells("ID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        WaypointID = dgvWaypoints.CurrentRow.Cells("ID").Value
        If DAL.DeleteMyRecord("tblResources", frmMain.myConnString, "ResourceID=" & CInt(WaypointID), Message) Then
            If Len(Message) > 0 Then
                MsgBox(Message)
            End If
        End If
        DAL = Nothing
    End Sub

    Sub AddStructure()
        Dim EntryForm As New frmStructureEntry
        Dim frmName As String
        Dim SearchName As String = "Structure_Entry"
        Dim OpenForm As Form
        Dim StructureID As String

        If Not IsNumeric(txtPlanetID.Text) Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            StructureID = "0"
            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Waypoint Information"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.Structure_ID = StructureID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub EditStructure()
        Dim EntryForm As New frmStructureEntry
        Dim frmName As String
        Dim SearchName As String = "Structure_Entry"
        Dim OpenForm As Form
        Dim StructureID As String

        If CInt(txtPlanetID.Text) = 0 Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            StructureID = dgvStructures.CurrentRow.Cells("ID").Value

            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Structure Information eg Knowledge Stone or Monument or anything with fixed coordinates incl buildings"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.Structure_ID = StructureID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub RemoveStructure()
        Dim StructureID As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim Message As String

        If IsDBNull(dgvStructures.CurrentRow.Cells("ID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        StructureID = dgvStructures.CurrentRow.Cells("ID").Value
        If DAL.DeleteMyRecord("tblResources", frmMain.myConnString, "ResourceID=" & CInt(StructureID), Message) Then
            If Len(Message) > 0 Then
                MsgBox(Message)
            End If
        End If
        DAL = Nothing
    End Sub

    Sub AddBase()
        Dim EntryForm As New frmBaseEntry
        Dim frmName As String
        Dim SearchName As String = "Base_Entry"
        Dim OpenForm As Form
        Dim BaseID As String

        If Not IsNumeric(txtPlanetID.Text) Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            BaseID = "0"
            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Waypoint Information"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.Base_ID = BaseID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub EditBase()
        Dim EntryForm As New frmBaseEntry
        Dim frmName As String
        Dim SearchName As String = "Base_Entry"
        Dim OpenForm As Form
        Dim BaseID As String

        If Not IsNumeric(txtPlanetID.Text) Then
            MsgBox("Please select a Planet First!")
            Exit Sub
        End If
        OpenForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(OpenForm) Then
            frmName = OpenForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            BaseID = dgvWaypoints.CurrentRow.Cells("ID").Value

            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Waypoint Information"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.Base_ID = BaseID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub RemoveBase()
        Dim BaseID As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim Message As String

        If IsDBNull(dgvStructures.CurrentRow.Cells("ID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        BaseID = dgvWaypoints.CurrentRow.Cells("ID").Value
        If DAL.DeleteMyRecord("tblBases", frmMain.myConnString, "BaseID=" & CInt(BaseID), Message) Then
            If Len(Message) > 0 Then
                MsgBox(Message)
            End If
        End If
        DAL = Nothing
    End Sub

    Private Sub btnAddResource_Click(sender As Object, e As EventArgs) Handles btnAddResource.Click
        AddResource()

    End Sub

    Private Sub ToolStripAddResource_Click(sender As Object, e As EventArgs) Handles ToolStripAddResource.Click
        'ADD RESOURCE MENU ITEM:
        'User has just selected ADD from the popup menu - call Add Resource popup entry form:
        AddResource()


    End Sub

    Private Sub ToolStripEditResource_Click(sender As Object, e As EventArgs) Handles ToolStripEditResource.Click
        'EDIT RESOURCE MENU ITEM:
        EditResource()

    End Sub

    Private Sub ToolStripDeleteResource_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteResource.Click
        'REMOVE RESOURCE MENU ITEM:
        RemoveResource()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripAddWaypoint.Click
        'ADD WAYPOINT MENU ITEM:
        AddWaypoint()

    End Sub

    Private Sub ToolStripEditWaypoint_Click(sender As Object, e As EventArgs) Handles ToolStripEditWaypoint.Click
        'EDIT WAYPOINT MENU ITEM:
        EditWaypoint()

    End Sub

    Private Sub ToolStripDeleteWaypoint_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteWaypoint.Click
        'REMOVE WAYPOINT MENU ITEM:
        RemoveWaypoint()

    End Sub

    Private Sub ToolStripAddStructure_Click(sender As Object, e As EventArgs) Handles ToolStripAddStructure.Click
        'ADD STRUCTURE MENU ITEM:
        AddStructure()

    End Sub

    Private Sub ToolStripEditStructure_Click(sender As Object, e As EventArgs) Handles ToolStripEditStructure.Click
        'EDIT STRUCTURE MENU ITEM:
        EditStructure()

    End Sub

    Private Sub ToolStripDeleteStructure_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteStructure.Click
        'REMOVE STRUCTURE MENU ITEM:
        RemoveStructure()

    End Sub

    Private Sub ToolStripAddNewBase_Click(sender As Object, e As EventArgs) Handles ToolStripAddNewBase.Click
        'ADD NEW BASE MENU ITEM:
        AddBase()

    End Sub

    Private Sub ToolStripEditBase_Click(sender As Object, e As EventArgs) Handles ToolStripEditBase.Click
        'EDIT BASE MENU ITEM:
        EditBase()

    End Sub

    Private Sub ToolStripDeleteBase_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteBase.Click
        'REMOVE BASE MENU ITEM:
        RemoveBase()

    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        'CALL PICK DATE routine - to select Delivery Date:
        'Just set todays date - easier !
        Me.txtDiscoveryDate.Text = Now().ToString("dd/MM/yyyy hh:mm")
    End Sub

    Private Sub btnCreatePlanetCode_Click(sender As Object, e As EventArgs) Handles btnCreatePlanetCode.Click
        Me.CreatePlanetCode()

    End Sub

    Public Sub ViewSelectedAcount(RowIndex As Integer)
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
        Dim ErrMessage As String
        Dim strAccountID As String
        Dim AccountName As String
        Dim rowIDX As Integer
        Dim strComments As String
        Dim strGameVersion As String
        Dim strPlatform As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        If RowIndex > -1 Then
            rowIDX = RowIndex
        Else
            rowIDX = 0
        End If
        'strRegisterID = Me.dgvAssetRegistry.Item(0, Me.dgvAssetRegistry.CurrentCell.RowIndex).Value.ToString
        strAccountID = Me.dgvPlanets.Item(1, rowIDX).Value.ToString
        strAccountID = dgvPlanets.Rows(rowIDX).Cells(1).Value.ToString
        If Len(strAccountID) = 0 Then
            strAccountID = "0"
        End If
        AccountName = dgvPlanets.Item(2, rowIDX).Value.ToString
        'SearchText = AccountName
        'SearchField = "AccountName"
        SearchText = strAccountID
        SearchField = "PlanetID"
        ReturnField = "ID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "AccountName"
        ExcludeFields = ""
        DBTable = "tblAccounts"
        FoundAccount = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundAccount Then
            'Populate text boxes:
            strPlatform = GetValuebyFieldname(AllValues, AllFields, "GameVersion")
            strGameVersion = GetValuebyFieldname(AllValues, AllFields, "GamePlatform")
            strAccountID = GetValuebyFieldname(AllValues, AllFields, "AccountID")
            Me.txtAccountID.Text = strAccountID
            Me.txtAccountName.Text = AccountName
            Me.txtPlatform.Text = strPlatform
            Me.txtVersion.Text = strGameVersion
        End If
        SetupSystemsCombo()

    End Sub

    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Call ViewSelectedAcount(e.RowIndex)
    End Sub

    Private Sub comAccounts_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles comAccounts.SelectedIndexChanged
        Dim dt As DataTable
        Dim AccountName As String
        Dim AccountID As String
        Dim GamePlatform As String
        Dim GameVersion As String

        dt = comAccounts.DataSource
        'AccountName = comAccounts.SelectedText
        If dt.Rows.Count > 0 Then
            AccountName = DirectCast(comAccounts.SelectedItem, DataRowView).Item("AccountName")
            AccountID = DirectCast(comAccounts.SelectedItem, DataRowView).Item("AccountID")
            GamePlatform = DirectCast(comAccounts.SelectedItem, DataRowView).Item("GamePlatform")
            GameVersion = DirectCast(comAccounts.SelectedItem, DataRowView).Item("GameVersion")
            Me.txtAccountID.Text = AccountID
            Me.txtAccountName.Text = AccountName
            Me.txtPlatform.Text = GamePlatform
            Me.txtVersion.Text = GameVersion
        End If
        SetupSystemsCombo()

    End Sub

    Private Sub comSystems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSystems.SelectedIndexChanged
        Dim dt As DataTable
        Dim strOriginalSystemName As String
        Dim strRenamedSystemName As String
        Dim strSystemID As String
        Dim strGalacticRegion As String
        Dim strGalaxyName As String

        dt = comSystems.DataSource
        'AccountName = comAccounts.SelectedText
        If dt.Rows.Count > 0 Then
            strGalaxyName = DirectCast(comSystems.SelectedItem, DataRowView).Item("GalacticNAme")
            strOriginalSystemName = DirectCast(comSystems.SelectedItem, DataRowView).Item("OriginalSystemName")
            strRenamedSystemName = DirectCast(comSystems.SelectedItem, DataRowView).Item("RenamedSystemName")
            strSystemID = DirectCast(comSystems.SelectedItem, DataRowView).Item("SystemID")
            strGalacticRegion = DirectCast(comSystems.SelectedItem, DataRowView).Item("GalacticRegion")
            Me.txtCurrentSystem.Text = strRenamedSystemName
            Me.txtSystemID.Text = strSystemID
            Me.txtGalacticRegion.Text = strGalacticRegion
        End If
    End Sub

    Private Sub dgvPlanets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanets.CellContentClick
        Dim RowIDX As Integer
        Dim strPlanetID As String
        Dim intPlanetID As Integer

        'Extract PlanetID from grid: not working
        RowIDX = e.RowIndex
        strPlanetID = dgvPlanets.Rows(RowIDX).Cells("PlanetID").Value
        strPlanetID = dgvPlanets.CurrentRow.Cells("PlanetID").Value
        intPlanetID = CInt(strPlanetID)
        PopulateForm(intPlanetID)
        PopulateGrids(strPlanetID)
    End Sub

    Private Sub dgvPlanets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanets.CellClick
        Dim RowIDX As Integer
        Dim strPlanetID As String
        Dim intPlanetID As Integer

        RowIDX = e.RowIndex
        If Not IsDBNull(dgvPlanets.Rows(RowIDX).Cells("PlanetID").Value) Then
            strPlanetID = dgvPlanets.Rows(RowIDX).Cells("PlanetID").Value
            'strPlanetID = dgvPlanets.CurrentRow.Cells("PlanetID").Value
            intPlanetID = CInt(strPlanetID)
            PopulateForm(intPlanetID)
            PopulateGrids(strPlanetID)
        End If

    End Sub

    Private Sub Frame_PlanetGlyphSet_MouseMove(sender As Object, e As MouseEventArgs) Handles Frame_PlanetGlyphSet.MouseMove

    End Sub

    Private Sub txtPlanetGlyphCode_Leave(sender As Object, e As EventArgs) Handles txtPlanetGlyphCode.Leave

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'NEW RECORD:
        'Clear form:
        Dim ControlIDX As Integer
        Dim tmpctrl As Control
        Dim tempBox As TextBox
        Dim childCtrl As Control

        txtAccountID.Text = ""
        txtAccountName.Text = ""
        txtComments.Text = ""
        txtCurrentSystem.Text = ""
        txtDefaultSystem.Text = ""
        txtDiscoveredBy.Text = ""
        txtDiscoveryDate.Text = ""
        txtExtremeWeather.Text = ""
        txtGalacticAddress.Text = ""
        txtGalacticRegion.Text = ""
        txtGlyphUnderMouse.Text = ""
        txtPlanetGlyphCode.Text = ""
        txtPlanetID.Text = ""
        txtPlanetName.Text = ""
        txtPlatform.Text = ""
        txtRenamedPlanet.Text = ""
        txtResourceNotes.Text = ""
        txtSelectedGlyphIndex.Text = ""
        txtSentinalInfo.Text = ""
        txtSystemID.Text = ""
        txtTotalBases.Text = "0"
        txtTotalFauna.Text = "0"
        txtTotalFlora.Text = "0"
        txtTotalPlanets.Text = "0"
        txtTotalResources.Text = "0"
        txtTotalStructures.Text = "0"
        txtTotalWaypoints.Text = "0"
        txtVersion.Text = ""
        txtWeather.Text = ""
        comAccounts.Focus()

    End Sub

    Private Sub dgvResources_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResources.CellContentClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Resources_SelectedCell(RowIDX)


    End Sub

    Public Sub Resources_SelectedCell(RowIDX As Integer)
        Dim ResourceID As String
        Dim strSQL As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim NumRows As Integer
        Dim dt As DataTable
        Dim DBTable As String

        If RowIDX < 0 Then
            Exit Sub
        End If
        DBTable = "tblResources"
        'strGalaxyName = DirectCast(comSystems.SelectedItem, DataRowView).Item("GalacticNAme")
        strSQL = "SELECT * FROM " & DBTable & " WHERE UserID=" & CInt(frmMain.myUserID)
        'DAL.PopulateMyDataSource(dgvResources.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        ResourceID = dt.Rows(RowIDX)("ResourceID").ToString
        'ResourceID = dgvResources.CurrentRow.Cells("ResourceID").ToString
        'ResourceID = DirectCast(dgvResources.Rows.Item, DataRowView).Item("ResourceID") - cannot be done ???
        Me.GetResourceID = ResourceID

    End Sub

    Private Sub dgvResources_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResources.CellClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Resources_SelectedCell(RowIDX)
    End Sub

    Private Sub btnSaveResourceColumns_Click(sender As Object, e As EventArgs) Handles btnSaveResourceColumns.Click
        Dim ColNames As String
        Dim ColWidths As String
        Dim idx As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        For idx = 0 To dgvResources.ColumnCount - 1
            If idx = 0 Then
                ColNames = dgvResources.Columns(idx).Name
                ColWidths = CStr(dgvResources.Columns(idx).Width)
            Else
                ColNames += "," & dgvResources.Columns(idx).Name
                ColWidths += "," & CStr(dgvResources.Columns(idx).Width)
            End If
        Next
        'call routine to save this comma-delim string to Database table tblPrefs:
        DAL.SaveColPrefs(frmMain.myConnString, frmMain.myUserID, "tblResources", ColNames, ColWidths)

    End Sub

    Public Sub Waypoints_SelectedCell(RowIDX As Integer)
        Dim WaypointID As String
        Dim strSQL As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim NumRows As Integer
        Dim dt As DataTable
        Dim DBTable As String

        If RowIDX < 0 Then
            Exit Sub
        End If
        DBTable = "tblWaypoints"
        'strGalaxyName = DirectCast(comSystems.SelectedItem, DataRowView).Item("GalacticNAme")
        strSQL = "SELECT * FROM " & DBTable & " WHERE UserID=" & CInt(frmMain.myUserID)
        'DAL.PopulateMyDataSource(dgvResources.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        WaypointID = dt.Rows(RowIDX)("WeypointID").ToString
        'ResourceID = dgvResources.CurrentRow.Cells("ResourceID").ToString
        'ResourceID = DirectCast(dgvResources.Rows.Item, DataRowView).Item("ResourceID") - cannot be done ???
        Me.GetWaypointID = WaypointID

    End Sub

    Private Sub btnAddWaypoint_Click(sender As Object, e As EventArgs) Handles btnAddWaypoint.Click
        AddWaypoint()

    End Sub

    Private Sub dgvWaypoints_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWaypoints.CellClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Waypoints_SelectedCell(RowIDX)
    End Sub

    Private Sub dgvWaypoints_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWaypoints.CellContentClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Waypoints_SelectedCell(RowIDX)
    End Sub

    Public Sub Structure_SelectedCell(RowIDX As Integer)
        Dim StructureID As String
        Dim strSQL As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim NumRows As Integer
        Dim dt As DataTable
        Dim DBTable As String

        If RowIDX < 0 Then
            Exit Sub
        End If
        DBTable = "tblStructures"
        'strGalaxyName = DirectCast(comSystems.SelectedItem, DataRowView).Item("GalacticNAme")
        strSQL = "SELECT * FROM " & DBTable & " WHERE UserID=" & CInt(frmMain.myUserID)
        'DAL.PopulateMyDataSource(dgvResources.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        StructureID = dt.Rows(RowIDX)("StructureID").ToString
        'ResourceID = dgvResources.CurrentRow.Cells("ResourceID").ToString
        'ResourceID = DirectCast(dgvResources.Rows.Item, DataRowView).Item("ResourceID") - cannot be done ???
        Me.GetStructureID = StructureID

    End Sub

    Private Sub frmPlanetEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.F5 Then
            'SEARCH CONTROL with FOCUS - will be a combo or TEXTBOX:
            'Need to know which control has the focus:
            'use the TAG to label the controls that can be searched - also add the fieldname of the corresponding table:
            'if cursor is in a control from tblPlanets - use the field from tblPlanets and
            'if cursor is on a grid cell - get the column name and search the corresponding table...
            'eg search for name of a planet. search for name of resource - which may return multiple records ?
            'hmmmm may need a separate form with an unbounded grid - return all the records that match.
            ' - allow the user to select which one to display ???
            ' - will be great for the log entry form too ! - searching for a range of dates - or a particular event or 
            ' - resource that was found a while back and cannot remember which planet it was - return the system too !!!!
            ' PLANET form will display the system and resource available.
            ' LOG form will display a particular event that occured at a particular time.
            ' REturn which base you were last at ? return ALL the bases on a particular planet with certain items ?
            ' - eg Which bio-domes contain star bulbs and where ??? (can show a picture !). Will need to number 
            ' - each bio-dome on the outside !!
            ' - OK here we go - WHICH CONTAINER HAS A PARTICULAR PRODUCT WITHIN IT ???? AND QUANTITY - AND RETURN VALUE !!!

            Dim ctrl As Control

            ctrl = Me.ActiveControl
            MsgBox("Active Control= " & ctrl.Name)
        End If
    End Sub

    Private Sub btnAddStructure_Click(sender As Object, e As EventArgs) Handles btnAddStructure.Click
        AddStructure()

    End Sub

    Private Sub dgvStructures_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStructures.CellClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Structure_SelectedCell(RowIDX)
    End Sub

    Private Sub dgvStructures_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStructures.CellContentClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Structure_SelectedCell(RowIDX)
    End Sub

    Private Sub frmPlanetEntry_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        If Me.IsUpdated > 0 Then
            'There has been an update to one of the sub-tables so update:
            PopulateGrids(strPlanetID)
            Me.IsUpdated = 0
            MsgBox("ENTER EVENT")
        End If
    End Sub

    Private Sub btnAddBase_Click(sender As Object, e As EventArgs) Handles btnAddBase.Click
        AddBase()

    End Sub

    Private Sub btnRemoveResource_Click(sender As Object, e As EventArgs) Handles btnRemoveResource.Click
        RemoveResource()

    End Sub

    Private Sub btnRemoveWaypoint_Click(sender As Object, e As EventArgs) Handles btnRemoveWaypoint.Click
        RemoveWaypoint()

    End Sub

    Private Sub btnRemoveStructure_Click(sender As Object, e As EventArgs) Handles btnRemoveStructure.Click
        RemoveStructure()

    End Sub

    Private Sub btnRemoveBase_Click(sender As Object, e As EventArgs) Handles btnRemoveBase.Click
        RemoveBase()

    End Sub
End Class