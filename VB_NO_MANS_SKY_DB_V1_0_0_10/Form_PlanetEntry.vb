Public Class frmPlanetEntry_v2
    Private _ResourceID As String
    Private _WaypointID As String
    Private _StructureID As String
    Private _BaseID As String
    Private _IsUpdated As Integer
    Private _ResourceGridCell As Point
    Private _WaypointGridCell As Point
    Private _StructureGridCell As Point
    Private _BaseGridCell As Point
    Private _DisplayMember As String
    Private _ValueMember As String

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

    Public Property ResourceGridCell() As Point
        Get
            Return _ResourceGridCell
        End Get
        Set(value As Point)
            _ResourceGridCell = value
        End Set
    End Property

    Public Property WaypointGridCell() As Point
        Get
            Return _WaypointGridCell
        End Get
        Set(value As Point)
            _WaypointGridCell = value
        End Set
    End Property

    Public Property StructureGridCell() As Point
        Get
            Return _StructureGridCell
        End Get
        Set(value As Point)
            _StructureGridCell = value
        End Set
    End Property

    Public Property BaseGridCell() As Point
        Get
            Return _BaseGridCell
        End Get
        Set(value As Point)
            _BaseGridCell = value
        End Set
    End Property

    'DisplayMember

    Public Property GetDisplayMember() As String
        Get
            Return _DisplayMember
        End Get
        Set(value As String)
            _DisplayMember = value
        End Set
    End Property

    Public Property GetValueMember() As String
        Get
            Return _ValueMember
        End Get
        Set(value As String)
            _ValueMember = value
        End Set
    End Property

    Dim CurrentSelectedIndex As Char
    Dim CurrentPosition As Integer
    Dim GlyphSelectionFrame As ScrollableControl
    Dim strAccountID As String = "0"
    Dim strSystemID As String = "0"
    Dim strPlanetID As String = "0"

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

        Dim strOriginalPlanetName As String
        Dim strRenamedPlanet As String
        Dim strPlanetGlyphCode As String
        Dim strGalacticAddress As String
        Dim strTotalResources As String
        Dim strTotalFauna As String
        Dim strTotalFlora As String
        Dim strTotalMinerals As String
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
        Dim strUserID As String
        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.
        dtCurrentDate = Now()
        ErrMessages = ""
        If IsNumeric(Me.txtPlanetID.Text) Then
            strPlanetID = Me.txtPlanetID.Text
        Else
            strPlanetID = "0"
        End If
        If IsNumeric(Me.txtAccountID.Text) Then
            strAccountID = Me.txtAccountID.Text
        Else
            MsgBox("Account ID not valid")
            Exit Sub
        End If
        If IsNumeric(Me.txtSystemID.Text) Then
            strSystemID = Me.txtSystemID.Text
        Else
            MsgBox("System ID not valid")
            Exit Sub
        End If
        strUserID = frmMain.myUserID
        strRenamedPlanet = Me.txtRenamedPlanet.Text
        strOriginalPlanetName = Me.txtOriginalPlanetName.Text
        strResourceNotes = Me.txtResourceNotes.Text
        strPlanetGlyphCode = Me.txtPlanetGlyphCode.Text
        strTotalFauna = Me.txtTotalFauna.Text
        strTotalFlora = Me.txtTotalFlora.Text
        strTotalMinerals = Me.txtTotalMinerals.Text
        strTotalBases = Me.txtTotalBases.Text
        strTotalResources = Me.txtTotalResources.Text
        strTotalStructures = Me.txtTotalStructures.Text
        strTotalWaypointsDiscovered = Me.txtTotalWaypoints.Text
        strSentinalInfo = Me.txtSentinalInfo.Text
        strGalacticAddress = Me.txtGalacticAddress.Text
        If IsDate(Me.txtDiscoveryDate.Text) Then
            strDiscoveryDate = Me.txtDiscoveryDate.Text
            dtDiscoveryDate = CDate(strDiscoveryDate)
            strDiscoveryDate = dtDiscoveryDate.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            strDiscoveryDate = NULLDATE
            dtDiscoveryDate = CDate(strDiscoveryDate)
            strDiscoveryDate = dtDiscoveryDate.ToString("yyyy-MM-dd HH:mm:ss")
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
        FieldNames = FieldNames & ",UserID"

        FieldValues = strOriginalPlanetName
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
        FieldValues = FieldValues & "," & strUserID

        If strPlanetID <> "" And strPlanetID <> "0" Then
            SearchField = "PlanetID"
            SearchText = strPlanetID
        Else
            If cbOriginalPlanetName.Checked = True Then
                SearchField = "OriginalPlanetName"
                SearchText = strOriginalPlanetName
            Else
                SearchField = "RenamedPlanetName"
                SearchText = strRenamedPlanet
            End If
        End If

        ReturnField = "PlanetID"
        ReturnValue = ""
        FieldType = "STRING"
        Reversed = True
        SortFields = "PlanetID"
        ExcludeFields = ""
        SearchCriteria = "AccountID=" & CInt(strAccountID)
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
            Answer = MsgBox("Planet NOT EXIST - Proceed with INSERT?", vbYesNo, "PLANET IS NEW ?")
            If Answer = vbYes Then
                SavedOK = myDAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False)
            End If

        End If
        If SavedOK Then
            MsgBox("OK Planet Info Entered")
        Else
            MsgBox("Problem: Planet Info NOT SAVE")
        End If

    End Sub

    Private Sub frmPlanetEntry_v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LOAD EVENT:
        ComponentManager.Initialise()
        KeyPreview = True
        CurrentPosition = 1
        CurrentSelectedIndex = "1"
        Me.IsUpdated = 0
        Me.AllowDrop = True
        PopulateForm(2)
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Save_The_Planet()

    End Sub

    Sub ClearAll()
        'Clear form:
        Dim ControlIDX As Integer
        Dim tmpctrl As Control
        Dim tempBox As TextBox
        Dim childCtrl As Control

        txtAccountID.Text = ""
        txtAccountName.Text = ""
        txtComments.Text = ""
        txtCurrentSystem.Text = ""
        txtOriginalSystemName.Text = ""
        txtDiscoveredBy.Text = ""
        txtDiscoveryDate.Text = ""
        txtExtremeWeather.Text = ""
        txtGalacticAddress.Text = ""
        txtGalacticRegion.Text = ""
        txtGlyphUnderMouse.Text = ""
        txtPlanetGlyphCode.Text = ""
        txtPlanetID.Text = ""
        txtRenamedPlanet.Text = ""
        txtPlatform.Text = ""
        txtOriginalPlanetName.Text = ""
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
        PlaceALLSelectedGlyphs(False)
        'GetGlyphsFromCode("............")
        comAccounts.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '
        ClearAll()
    End Sub

    Public Sub SetupAccountCombo()
        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim ItemName As String

        strSQL = "SELECT * FROM tblAccounts WHERE UserID=" & CInt(frmMain.myUserID)
        dt = myDAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        dt.Select()
        comAccounts.DataSource = dt
        'myDAL.PopulateMyDataSource(Nothing, frmMain.myConnString, strSQL, NumRows, ErrMessage, dt)
        'dt = myDAL.GetAccounts(frmMain.myConnString, 0, frmMain.myUserID, NumRows)
        GetValueMember = "AccountID"
        GetDisplayMember = "AccountName"
        'Dim DAL as new DataLayer
        'dt = dal.GetComboItems(ConnString)

        comAccounts.DisplayMember = GetDisplayMember
        comAccounts.ValueMember = "AccountID"
        comAccounts.DataSource = dt
        'comAccounts.Items.Clear()

        'For i As Integer = 0 To NumRows - 1
        'ItemName = dt.Rows(i)("AccountName").ToString
        'comAccounts.Items.Add(ItemName)
        'Next

        comAccounts.SelectedText = ""
        comAccounts.Text = ""

        dt = Nothing
        myDAL = Nothing
    End Sub

    Public Sub SetupSystemsCombo(AccountID As Integer)
        Dim dt As New DataTable
        Dim NumRows As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim userID As Integer
        Dim ErrMessage As String = ""
        Dim strSQL As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Try
            If Len(txtAccountID.Text) = 0 Then
                'Exit Sub
            End If
            strSQL = "SELECT * FROM tblSystems WHERE AccountID=" & AccountID & " AND UserID=" & CInt(frmMain.myUserID)
            'myDAL.PopulateMyDataSource(Nothing, frmMain.myConnString, strSQL, NumRows, ErrMessage, dt)
            dt = myDAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
            dt.Select()
            comSystems.DataSource = dt
            txtTotalSystems.Text = CStr(NumRows)
            GetValueMember = "SystemID"
            GetDisplayMember = "OriginalSystemName"

            comSystems.DisplayMember = GetDisplayMember
            comSystems.ValueMember = "SystemID"
            '
            comSystems.DataSource = dt
            comSystems.SelectedText = ""
            comSystems.Text = ""
            'dtSystems = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblSystems WHERE AccountID=" & AccountID, NumRows)
        Catch ex As Exception
            MsgBox(ex.Message, vbOK, "NMS " & frmMain.myVersion & " Exception Error")
        End Try

    End Sub

    Public Sub PlaceALLSelectedGlyphs(NewPB As Boolean)
        Dim ItemIDX As Integer = 0

        'Place the 12  blank picture boxes on the PlanetGlyphSet frame:
        ItemIDX = 1
        Do While ItemIDX < 13
            PlacePBGlyph(NewPB, ItemIDX)
            ItemIDX += 1
        Loop
    End Sub

    Sub PlacePBGlyph(NewPB As Boolean, ItemIDX As Integer)
        Dim Prefix As String
        Dim GlyphCode As String
        Dim ControlName As String
        Dim ControlTag As String
        Dim glyphControlLeft As Integer
        Dim glyphControlTop As Integer
        Dim glyphControlWidth As Integer
        Dim glyphControlHeight As Integer
        Dim FoundControl As Control

        Prefix = "PB"
        GlyphCode = CStr(ItemIDX)
        ControlName = Prefix & GlyphCode
        ControlTag = Prefix & GlyphCode 'Deliberate as GLYPH is NOT set yet. So TAG will be PB1 to PB12.
        FoundControl = frmMain.FindControls(Me.Name, ControlName, "")
        glyphControlWidth = 40
        glyphControlHeight = 40
        glyphControlTop = 5
        glyphControlLeft = 5 + ((ItemIDX - 1) * 45)
        'IF THIS PROCEDURE IS BEING CALLED AGAIN - needs to set the CONTROL to a PICTUREBOX:
        Call AddNewPictureBox(ControlName, NewPB, glyphList.Images.Item(16), FoundControl, ControlName,
                              glyphControlLeft, glyphControlTop, glyphControlWidth, glyphControlHeight,
                              ControlName, Frame_PlanetGlyphSet, "STRETCH", "AliceBlue")
    End Sub

    Public Sub SetupGlyphs(NewPB As Boolean)
        'SHOWN PROCEDURE:
        'LOAD UP PICTURE BOXES WITH CORRECT GLYPHS - SELECTPB0 ETC.
        'LOOP AROUND EACH FILE AND ATTACH TO EACH CONTROL. 
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
            'CHECK if BLANK GLYPH is part of dic_controls() collection ?
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
            Call AddNewPictureBox(ControlName, NewPB, glyphList.Images.Item(ItemIDX), Nothing, ControlName,
                                  glyphControlLeft, glyphControlTop, glyphControlWidth, glyphControlHeight,
                                  ControlTag, Frame_PlanetGlyphPallet, "STRETCH", "RoyalBlue")
            Call AddNewControl(LabelName, NewPB, Frame_PlanetGlyphPallet, "",
                                    lblControlLeft, lblControlTop, lblControlWidth, 0, LabelName, "LABEL", Nothing, True, "DeepSkyBlue", "0,0,0",
                                    Nothing, GlyphCode, LabelName, "CAMBRIA", 11, "")
            GlyphIDX += 1
            ItemIDX += 1
        Loop
        PlaceALLSelectedGlyphs(NewPB)

        Me.txtPlanetGlyphCode.Text = "............"
    End Sub

    Sub PopulateForm(AccountID As Integer)
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
        Dim strSQL As String

        'SETUP COMBOS:
        'comAccounts
        'comSystems
        'comResources
        'comWaypoints
        'comStructures
        'comBases
        SetupGlyphs(True)

        SetupAccountCombo()


        'Find Control to put image into:
        'FoundControl = frmMain.FindControls("Planet_Entry", "PB12", "")
        'Pass the fixed account ID from the dgvPlanets grid into here to select correct item in combo.
    End Sub

    Sub PopulatePlanets(AccountID As Integer)
        Dim strSQL As String
        Dim dtPlanets As DataTable
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim NumRows As Integer

        strSQL = "SELECT * FROM tblPlanets WHERE UserID=" & CInt(frmMain.myUserID) & " AND AccountID=" & AccountID
        dtPlanets = DAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        dgvPlanets.DataSource = dtPlanets
        txtTotalPlanets.Text = CStr(NumRows)
        If NumRows > 0 Then
            dgvPlanets.ClearSelection()
            dgvPlanets.CurrentCell = dgvPlanets.Rows(0).Cells(0)
            dgvPlanets.Rows(0).Selected = True
            dgvPlanets.CurrentCell.Selected = True
            'Call ViewSelectedAcount(0)
            'Me.comAccounts.DataSource = AccountSource
            'comAccounts.DisplayMember = AccountSource.Columns("AccountName").ToString
            'comAccounts.ValueMember = AccountSource.Columns("AccountID").ToString
            'comAccounts.Text = AccountSource.Rows(0)("AccountName").ToString
            'comAccounts.ValueMember = dtPlanets.Rows(0)("AccountID").ToString
        End If
    End Sub

    Private Sub frmPlanetEntry_v2_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'SHOWN PROCEDURE:


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
            ResourceFields = "ResourceID,ResourceName as 'Resource Name',ResourceLongCoords as 'N/S Coords',ResourceLatCoords as 'E/W Coords'"
            ResourceFields = ResourceFields & ",PowerGridLongCoords as 'N/S Power Coords',PowerGridLatCoords as 'E/W Power Coords'"
            ResourceFields = ResourceFields & ",PowerYield as 'Power Yield',AmountResourceYielded as 'Yield',ResourceType as 'Type'"
            ResourceFields = ResourceFields & ",DiscoveryDate as 'Discovery Date',AmountExtracted as 'Amount Extracted'"
            ResourceFields = ResourceFields & ",LastUpdated,DefaultResource as 'DEFAULT'"
        End If

        'ResourceFields = "ResourceName as 'Resource Name',ResourceLongCoords as 'N/S Coords',ResourceLatCoords as 'E/W Coords'"
        'ResourceFields = ResourceFields & ",PowerGridLongCoords as 'N/S Power Coords',PowerGridLatCoords as 'E/W Power Coords'"
        'ResourceFields = ResourceFields & ",PowerYield as 'Power Yield',AmountResourceYielded as 'Yield',ResourceType as 'Type'"
        'ResourceFields = ResourceFields & ",DiscoveryDate as 'Discovery Date',AmountExtracted as 'Amount Extracted'"
        'ResourceFields = ResourceFields & ",LastUpdated,ResourceID as 'ID'"

        WaypointFields = "WeypointID,WaypointName as 'Name',WaypointLongCoords as 'N/S Coords',WaypointLatCoords as 'E/W Coords'"
        WaypointFields += ",DiscoveryDate as 'Discovery Date',DiscoveredBy as 'Discovered By'"
        WaypointFields += ",LastUpdated,DefaultWaypoint as 'DEFAULT'"

        StructureFields = "StructureID,StructureName as 'Name',StructureLongCoords as 'N/S',StructureLatCoords as 'E/W',DiscoveryDate as 'Discovery Date'"
        StructureFields += ",DiscoveredBy as 'Discovered By',Notes"
        StructureFields += ",LastUpdated,DefaultStructure as 'DEFAULT'"

        BaseFields = "BaseID,OriginalBaseName as 'Original Name',RenamedBaseName as 'Renamed',LastUpdated as 'Last Update',MaterialsUsed as 'Materials Used'"
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
                DAL.UpdateALL(frmMain.myConnString, "tblResources", "TotalResources", CStr(NumRows))
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
                DAL.UpdateALL(frmMain.myConnString, "tblWaypoints", "TotalWaypointsDiscovered", CStr(NumRows))
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
                DAL.UpdateALL(frmMain.myConnString, "tblStructures", "TotalStructures", CStr(NumRows))
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
                DAL.UpdateALL(frmMain.myConnString, "tblBases", "TotalBases", CStr(NumRows))
            End If
        End If
    End Sub

    Public Sub ShowPlanet(PlanetID As Integer)
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
        Dim strOriginalSystemName As String
        Dim strRenamedSystemName As String
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
            Me.txtRenamedPlanet.Text = strPlanetNAme
            strRenamedPlanetName = GetValuebyFieldname(AllValues, AllFields, "RenamedPlanetName")
            Me.txtOriginalPlanetName.Text = strRenamedPlanetName
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
            strWeather = GetValuebyFieldname(AllValues, AllFields, "Weather")
            Me.txtWeather.Text = strWeather
            strExtremeWeather = GetValuebyFieldname(AllValues, AllFields, "ExtremeWeather")
            Me.txtExtremeWeather.Text = strExtremeWeather
            strComments = GetValuebyFieldname(AllValues, AllFields, "Comments")
            Me.txtComments.Text = strComments
            'Display rest of Account details - search strAccountID
            SearchText = strAccountID
            SearchField = "AccountID"
            ReturnField = "AccountID"
            ReturnValue = ""
            FieldType = "STRING"
            Reversed = True
            SortFields = "AccountID"
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
            SearchField = "SystemID"
            ReturnField = "AccountID"
            ReturnValue = ""
            FieldType = "INTEGER"
            Reversed = True
            SortFields = "SystemID"
            ExcludeFields = ""
            SearchCriteria = ""
            DBTable = "tblSystems"
            FoundSystem = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
            If FoundSystem Then
                strOriginalSystemName = GetValuebyFieldname(AllValues, AllFields, "OriginalSystemName")
                Me.txtOriginalSystemName.Text = strOriginalSystemName
                strRenamedSystemName = GetValuebyFieldname(AllValues, AllFields, "RenamedSystemName")
                Me.txtCurrentSystem.Text = strRenamedSystemName
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
            SortFields = "SystemID"
            ExcludeFields = ""
            SearchCriteria = ""

            FoundSystem = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
            If FoundSystem Then
                strDefaultSystem = GetValuebyFieldname(AllValues, AllFields, "RenamedSystemName")
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
                                    If GlyphKey = "." Then
                                        FoundGlyphControl.BackgroundImage = glyphList.Images.Item(16)
                                    Else
                                        FoundGlyphControl.BackgroundImage = ControlImage
                                    End If

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
                        PlacePBGlyph(False, loopy)
                End Select

                loopy += 1
            Loop
        Else
            'NOT VALID:
            MsgBox("Planet Code NOT valid")
            Exit Sub
        End If

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

        End If
        SearchText = "DEFAULT"
        SearchField = "DefaultAccount"
        ReturnField = "AccountID"
        FieldType = "STRING"
        'SET DEFAULT:
        FoundDefault = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                        SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
        If FoundDefault And DefaultAccount Then
            AccountID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountID")
            GamerHandle = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamerHandle")
            AccountName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountName")
            GamePlatform = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamePlatform")
            GameVersion = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GameVersion")
        End If

        Me.txtAccountID.Text = AccountID
        Me.txtAccountName.Text = AccountName
        Me.txtPlatform.Text = GamePlatform
        Me.txtVersion.Text = GameVersion
        Me.TextBox1.Text = GamerHandle

        'Use the AccountID to select the correct group of planet records under that Account in the GRID:
        If AccountID <> "" And IsNumeric(AccountID) Then
            SetupSystemsCombo(CInt(AccountID))
            PopulatePlanets(CInt(AccountID))
        End If


    End Sub

    Public Sub SelectSystem(DefaultSystem As Boolean, SelectedItem As Object)
        Dim dt As DataTable
        Dim SystemID As String
        Dim GamePlatform As String
        Dim RenamedSystemName As String
        Dim OriginalSystemName As String
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

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        dt = comSystems.DataSource
        'AccountName = comAccounts.SelectedText
        If dt.Rows.Count > 0 Then
            If SelectedItem IsNot Nothing Then
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("OriginalSystemName")) Then
                    OriginalSystemName = DirectCast(SelectedItem, DataRowView).Item("OriginalSystemName").ToString
                Else
                    OriginalSystemName = "UNKNOWN"
                End If
                If Not IsDBNull(DirectCast(SelectedItem, DataRowView).Item("RenamedSystemName")) Then
                    RenamedSystemName = DirectCast(SelectedItem, DataRowView).Item("RenamedSystemName").ToString
                Else
                    RenamedSystemName = "UNKNOWN"
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
        SearchText = "DEFAULT"
        SearchField = "DefaultSystem"
        ReturnField = "SystemID"
        FieldType = "STRING"
        'SET DISCOVERED BY:
        FoundDefault = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                        SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
        If FoundDefault And DefaultSystem Then
            SystemID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "SystemID")
            OriginalSystemName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "OriginalSystemName")
            RenamedSystemName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "RenamedSystemName")
            GalacticRegion = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GalacticRegion")
        Else
            'MsgBox("Default System NOT found")
        End If

        Me.txtSystemID.Text = SystemID
        Me.txtCurrentSystem.Text = RenamedSystemName
        Me.txtOriginalSystemName.Text = OriginalSystemName
        Me.txtGalacticRegion.Text = GalacticRegion
    End Sub

    Private Sub comAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAccounts.SelectedIndexChanged
        SelectAccount(False, comAccounts.SelectedItem)
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
            ResourceID = dgvResources.CurrentRow.Cells("ResourceID").Value

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

        If IsDBNull(dgvResources.CurrentRow.Cells("ResourceID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        ResourceID = dgvResources.CurrentRow.Cells("ResourceID").Value
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
            WaypointID = dgvWaypoints.CurrentRow.Cells("WeypointID").Value

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

        If IsDBNull(dgvWaypoints.CurrentRow.Cells("WeypointID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        WaypointID = dgvWaypoints.CurrentRow.Cells("WeypointID").Value
        If DAL.DeleteMyRecord("tblwaypoints", frmMain.myConnString, "WeypointID=" & CInt(WaypointID), Message) Then
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
            EntryForm.Text = "Enter Structure Information"
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
            StructureID = dgvStructures.CurrentRow.Cells("StructureID").Value

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

        If IsDBNull(dgvStructures.CurrentRow.Cells("StructureID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        StructureID = dgvStructures.CurrentRow.Cells("StructureID").Value
        If DAL.DeleteMyRecord("tblstructures", frmMain.myConnString, "StructureID=" & CInt(StructureID), Message) Then
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
            EntryForm.Text = "Enter Base Information"
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
            If Not IsNothing(dgvBases.CurrentRow.Cells("BaseID").Value) Then
                BaseID = dgvBases.CurrentRow.Cells("BaseID").Value
            End If
            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Base Information"
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

        If IsDBNull(dgvBases.CurrentRow.Cells("BaseID")) Then
            MsgBox("Please select a populated row")
            Exit Sub
        End If
        BaseID = dgvBases.CurrentRow.Cells("BaseID").Value
        If DAL.DeleteMyRecord("tblBases", frmMain.myConnString, "BaseID=" & CInt(BaseID), Message) Then
            If Len(Message) > 0 Then
                MsgBox(Message)
            End If
        End If
        DAL = Nothing
    End Sub


    Sub AddFauna()
        Dim EntryForm As New Form_EnterFauna
        Dim frmName As String
        Dim SearchName As String = "Fauna_Entry"
        Dim OpenForm As Form
        Dim FaunaID As String

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
            FaunaID = "0"
            EntryForm.Name = SearchName
            EntryForm.Text = "Enter Fauna Information"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.FaunaID = FaunaID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub EditFauna()
        Dim EntryForm As New Form_EnterFauna
        Dim frmName As String
        Dim SearchName As String = "Fauna_Entry"
        Dim OpenForm As Form
        Dim FaunaID As String

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
            'WHERE IS FaunaID value comming from ???

            'WHAT ABOUT the Unique Form TAG ???
            'ResourceForm = New frmResourceEntry
            'ResourceForm = CType(ResourceForm, frmResourceEntry)
            'If Not IsNothing(dgvBases.CurrentRow.Cells("FaunaID").Value) Then
            'FaunaID = dgvBases.CurrentRow.Cells("FaunaID").Value
            'End If
            EntryForm.Name = SearchName
            EntryForm.Text = "Enter FAUNA Information"
            EntryForm.MdiParent = frmMain
            EntryForm.StartPosition = FormStartPosition.Manual
            EntryForm.Top = 20
            EntryForm.Left = 5
            EntryForm.Width = 1500
            EntryForm.Height = 960
            EntryForm.Planet_ID = txtPlanetID.Text
            EntryForm.FaunaID = FaunaID
            EntryForm.Account_ID = txtAccountID.Text
            EntryForm.Show()
        End If
    End Sub

    Sub RemoveFauna()
        Dim FaunaID As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim Message As String

        'If IsDBNull(dgvFauna.CurrentRow.Cells("FaunaID")) Then
        'MsgBox("Please select a populated row")
        'Exit Sub
        'End If
        'FaunaID = dgvFauna.CurrentRow.Cells("FaunaID").Value
        If DAL.DeleteMyRecord("tblFauna", frmMain.myConnString, "FaunaID=" & CInt(FaunaID), Message) Then
            If Len(Message) > 0 Then
                MsgBox(Message)
            End If
        End If
        DAL = Nothing
    End Sub

    Private Sub ToolStripAddResource_Click(sender As Object, e As EventArgs) Handles ToolStripAddResource.Click
        AddResource()

    End Sub

    Private Sub btnAddResource_Click(sender As Object, e As EventArgs) Handles btnAddResource.Click
        AddResource()

    End Sub

    Private Sub ToolStripEditResource_Click(sender As Object, e As EventArgs) Handles ToolStripEditResource.Click
        EditResource()

    End Sub

    Private Sub ToolStripDeleteResource_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteResource.Click
        RemoveResource()

    End Sub

    Private Sub btnRemoveResource_Click(sender As Object, e As EventArgs) Handles btnRemoveResource.Click
        RemoveResource()

    End Sub

    Private Sub btnAddWaypoint_Click(sender As Object, e As EventArgs) Handles btnAddWaypoint.Click
        AddWaypoint()

    End Sub

    Private Sub ToolStripAddWaypoint_Click(sender As Object, e As EventArgs) Handles ToolStripAddWaypoint.Click
        AddWaypoint()

    End Sub

    Private Sub ToolStripEditWaypoint_Click(sender As Object, e As EventArgs) Handles ToolStripEditWaypoint.Click
        EditWaypoint()

    End Sub

    Private Sub ToolStripDeleteWaypoint_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteWaypoint.Click
        RemoveWaypoint()

    End Sub

    Private Sub btnRemoveWaypoint_Click(sender As Object, e As EventArgs) Handles btnRemoveWaypoint.Click
        RemoveWaypoint()

    End Sub

    Private Sub btnAddStructure_Click(sender As Object, e As EventArgs) Handles btnAddStructure.Click
        AddStructure()

    End Sub

    Private Sub ToolStripAddStructure_Click(sender As Object, e As EventArgs) Handles ToolStripAddStructure.Click
        AddStructure()

    End Sub

    Private Sub ToolStripEditStructure_Click(sender As Object, e As EventArgs) Handles ToolStripEditStructure.Click
        EditStructure()

    End Sub

    Private Sub ToolStripDeleteStructure_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteStructure.Click
        RemoveStructure()

    End Sub

    Private Sub btnRemoveStructure_Click(sender As Object, e As EventArgs) Handles btnRemoveStructure.Click
        RemoveStructure()

    End Sub

    Private Sub btnAddBase_Click(sender As Object, e As EventArgs) Handles btnAddBase.Click
        AddBase()

    End Sub

    Private Sub ToolStripAddNewBase_Click(sender As Object, e As EventArgs) Handles ToolStripAddNewBase.Click
        AddBase()

    End Sub

    Private Sub ToolStripEditBase_Click(sender As Object, e As EventArgs) Handles ToolStripEditBase.Click
        EditBase()

    End Sub

    Private Sub ToolStripDeleteBase_Click(sender As Object, e As EventArgs) Handles ToolStripDeleteBase.Click
        RemoveBase()

    End Sub

    Private Sub btnRemoveBase_Click(sender As Object, e As EventArgs) Handles btnRemoveBase.Click
        RemoveBase()

    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        Me.txtDiscoveryDate.Text = Now().ToString("dd/MM/yyyy HH:mm:ss")
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
        Dim strAccountName As String
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
        strAccountID = Me.dgvPlanets.Item(4, rowIDX).Value.ToString
        strAccountID = Me.dgvPlanets.Rows(rowIDX).Cells("AccountID").Value
        If Len(strAccountID) = 0 Then
            strAccountID = "0"
        End If
        SearchText = strAccountID
        SearchField = "AccountID"
        ReturnField = "AccountID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "AccountID"
        ExcludeFields = ""
        DBTable = "tblAccounts"
        FoundAccount = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundAccount Then
            'Populate text boxes:
            strAccountName = GetValuebyFieldname(AllValues, AllFields, "AccountName")
            strPlatform = GetValuebyFieldname(AllValues, AllFields, "GameVersion")
            strGameVersion = GetValuebyFieldname(AllValues, AllFields, "GamePlatform")
            strAccountID = GetValuebyFieldname(AllValues, AllFields, "AccountID")
            Me.txtAccountID.Text = strAccountID
            Me.txtAccountName.Text = strAccountName
            Me.txtPlatform.Text = strPlatform
            Me.txtVersion.Text = strGameVersion
        End If
        If strAccountID <> "" And IsNumeric(strAccountID) Then
            SetupSystemsCombo(CInt(strAccountID))
        End If


    End Sub

    Private Sub comSystems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSystems.SelectedIndexChanged
        SelectSystem(False, comSystems.SelectedItem)
    End Sub

    Private Sub dgvPlanets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanets.CellClick
        Dim RowIDX As Integer
        Dim strPlanetID As String
        Dim intPlanetID As Integer

        RowIDX = e.RowIndex
        If RowIDX < 0 Then Exit Sub
        If Not IsDBNull(dgvPlanets.Rows(RowIDX).Cells("PlanetID").Value) Then
            strPlanetID = dgvPlanets.Rows(RowIDX).Cells("PlanetID").Value
            'strPlanetID = dgvPlanets.CurrentRow.Cells("PlanetID").Value
            intPlanetID = CInt(strPlanetID)
            ShowPlanet(intPlanetID)
            PopulateGrids(strPlanetID)
        End If
    End Sub

    Private Sub dgvPlanets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanets.CellContentClick
        Dim RowIDX As Integer
        Dim strPlanetID As String
        Dim intPlanetID As Integer

        RowIDX = e.RowIndex
        If RowIDX < 0 Then Exit Sub
        If Not IsDBNull(dgvPlanets.Rows(RowIDX).Cells("PlanetID").Value) Then
            strPlanetID = dgvPlanets.Rows(RowIDX).Cells("PlanetID").Value
            'strPlanetID = dgvPlanets.CurrentRow.Cells("PlanetID").Value
            intPlanetID = CInt(strPlanetID)
            ShowPlanet(intPlanetID)
            PopulateGrids(strPlanetID)
        End If
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
        'OK so the RowIDX is being used... what if there are more records in other accounts for the SAME userID ???

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

    Private Sub dgvResources_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResources.CellContentClick
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

    Private Sub btnSaveWaypointColumns_Click(sender As Object, e As EventArgs) Handles btnSaveWaypointColumns.Click
        Dim ColNames As String
        Dim ColWidths As String
        Dim idx As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        For idx = 0 To dgvWaypoints.ColumnCount - 1
            If idx = 0 Then
                ColNames = dgvWaypoints.Columns(idx).Name
                ColWidths = CStr(dgvWaypoints.Columns(idx).Width)
            Else
                ColNames += "," & dgvWaypoints.Columns(idx).Name
                ColWidths += "," & CStr(dgvWaypoints.Columns(idx).Width)
            End If
        Next
        'call routine to save this comma-delim string to Database table tblPrefs:
        DAL.SaveColPrefs(frmMain.myConnString, frmMain.myUserID, "tblWaypoints", ColNames, ColWidths)
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

    Private Sub btnSaveStructureColumns_Click(sender As Object, e As EventArgs) Handles btnSaveStructureColumns.Click
        Dim ColNames As String
        Dim ColWidths As String
        Dim idx As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        For idx = 0 To dgvStructures.ColumnCount - 1
            If idx = 0 Then
                ColNames = dgvStructures.Columns(idx).Name
                ColWidths = CStr(dgvStructures.Columns(idx).Width)
            Else
                ColNames += "," & dgvStructures.Columns(idx).Name
                ColWidths += "," & CStr(dgvStructures.Columns(idx).Width)
            End If
        Next
        'call routine to save this comma-delim string to Database table tblPrefs:
        DAL.SaveColPrefs(frmMain.myConnString, frmMain.myUserID, "tblStructures", ColNames, ColWidths)
    End Sub

    Public Sub Base_SelectedCell(RowIDX As Integer)
        Dim BaseID As String
        Dim strSQL As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim NumRows As Integer
        Dim dt As DataTable
        Dim DBTable As String

        If RowIDX < 0 Then
            Exit Sub
        End If
        'OK so we are getting the BASE ID here ???? but the SQL currently will get the first record from tblbases ???
        DBTable = "tblBases"
        'strGalaxyName = DirectCast(comSystems.SelectedItem, DataRowView).Item("GalacticNAme")
        strSQL = "SELECT * FROM " & DBTable & " WHERE UserID=" & CInt(frmMain.myUserID)
        'DAL.PopulateMyDataSource(dgvResources.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        BaseID = dt.Rows(RowIDX)("BaseID").ToString
        'ResourceID = dgvResources.CurrentRow.Cells("ResourceID").ToString
        'ResourceID = DirectCast(dgvResources.Rows.Item, DataRowView).Item("ResourceID") - cannot be done ???
        Me.GetBaseID = BaseID

    End Sub

    Private Sub dgvBases_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBases.CellClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Base_SelectedCell(RowIDX)
    End Sub

    Private Sub dgvBases_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBases.CellContentClick
        Dim RowIDX As Integer

        RowIDX = e.RowIndex
        Base_SelectedCell(RowIDX)
    End Sub

    Private Sub btnSaveBaseColumns_Click(sender As Object, e As EventArgs) Handles btnSaveBaseColumns.Click
        Dim ColNames As String
        Dim ColWidths As String
        Dim idx As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        For idx = 0 To dgvBases.ColumnCount - 1
            If idx = 0 Then
                ColNames = dgvBases.Columns(idx).Name
                ColWidths = CStr(dgvBases.Columns(idx).Width)
            Else
                ColNames += "," & dgvBases.Columns(idx).Name
                ColWidths += "," & CStr(dgvBases.Columns(idx).Width)
            End If
        Next
        'call routine to save this comma-delim string to Database table tblPrefs:
        DAL.SaveColPrefs(frmMain.myConnString, frmMain.myUserID, "tblBases", ColNames, ColWidths)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim AccountID As Integer

        If txtAccountID.Text <> "" Then
            AccountID = CInt(txtAccountID.Text)
            PopulatePlanets(AccountID)
        End If
        If txtPlanetID.Text <> "" Then
            PopulateGrids(txtPlanetID.Text)
        End If

    End Sub

    Private Sub btnFauna_Click(sender As Object, e As EventArgs) Handles btnFauna.Click
        'Display Selection grid in new form tab for Fauna (Animals):

    End Sub

    Private Sub btnFlora_Click(sender As Object, e As EventArgs) Handles btnFlora.Click
        'Display Selection grid in new form tab for Flora (Plants):

    End Sub

    Private Sub btnMinerals_Click(sender As Object, e As EventArgs) Handles btnMinerals.Click
        'Display Selection Grid for Minerals tab in new form:

    End Sub
End Class