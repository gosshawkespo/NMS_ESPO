Public Class frmLogView
    Private _SortField1 As String
    Private _SortField2 As String
    Private _SelectedAccountID As Integer
    Property SortField1 As String
        Get
            Return _SortField1
        End Get
        Set(value As String)
            _SortField1 = value
        End Set
    End Property

    Property SortField2 As String
        Get
            Return _SortField2
        End Get
        Set(value As String)
            _SortField2 = value
        End Set
    End Property

    Property SelectedAccountID As Integer
        Get
            Return _SelectedAccountID
        End Get
        Set(value As Integer)
            _SelectedAccountID = value
        End Set
    End Property

    Sub ChangeTextboxColor(ParentControl As Control, ChangeColor As Color)
        For Each ctrl As Control In ParentControl.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.BackColor = ChangeColor
            ElseIf TypeOf (ctrl) Is Panel Then
                ChangeTextboxColor(ctrl, ChangeColor)

            End If
        Next
    End Sub


    Private Sub frmLogView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myTextbox As New TextBox

        'LOAD
        If clsDG_NMS_Controls.ThemeSelection = 0 Then
            Me.BackColor = Color.LightGray
            'dgvLOG.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(245, 255, 245)) 'green/white
            dgvLOG.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
            dgvLOG.DefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(235, 255, 235)) 'LIGHT GREEN
            dgvLOG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            ChangeTextboxColor(Me, Color.AliceBlue)
        Else
            Me.BackColor = Color.Gray
            dgvLOG.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray
            dgvLOG.DefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(183, 255, 240)) 'LIGHT GREEN
            dgvLOG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            'NewOBJ = DirectCast(NewCombo, System.Windows.Forms.ComboBox)
            ChangeTextboxColor(Me, Color.SteelBlue)
        End If
        'dgvLOG.RowsDefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(215, 255, 247))
        'dgvLOG.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(183, 255, 240))
        'dgvLOG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        dgvLOG.AllowUserToAddRows = False
        dgvLOG.AllowUserToDeleteRows = False
        dgvLOG.AllowUserToOrderColumns = True
        dgvLOG.AllowUserToResizeColumns = True
        txtUserID.Text = frmMain.myUserID
        BuildAccountCombo()
        Me.SelectedAccountID = 0

    End Sub

    Public Sub BuildAccountCombo()

        Dim dt As New DataTable
        Dim strSQL As String
        Dim strUserIDs As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim Accounts As String

        strUserIDs = dal.GetCollaboratedUserIDs(frmMain.myConnString, "tblAccounts", frmMain.myUserID, 0, Accounts)
        If strUserIDs = "" Then
            strUserIDs = frmMain.myUserID
        End If
        dt = dal.GetMultiAccounts(frmMain.myConnString, frmMain.myUserID, Accounts, strUserIDs, NumRows)
        'dt.Select()
        comAccounts.DataSource = dt
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        Me.txtTotalAccounts.Text = CStr(NumRows)

        comAccounts.DataSource = dt
        comAccounts.ValueMember = "AccountID"
        comAccounts.DisplayMember = "AccountName"
        comAccounts.SelectedText = ""
        comAccounts.Text = ""
        PopulateSortCombo()
        dal = Nothing
        dt = Nothing
    End Sub

    Function GetSortFields() As String
        Dim SortFields As String

        GetSortFields = ""
        If Me.SortField1 = "" And Me.SortField2 = "" Then
            If cbReverseSort.CheckState = CheckState.Checked Then
                SortFields = "CurrentDateTime DESC"
            Else
                SortFields = "CurrentDateTime ASC"
            End If
        ElseIf Me.SortField1 <> "" And Me.SortField2 = "" Then
            If cbReverseSort1.CheckState = CheckState.Checked Then
                SortFields = Me.SortField1 & " DESC"
            Else
                SortFields = Me.SortField1 & " ASC"
            End If
        ElseIf Me.SortField1 = "" And Me.SortField2 <> "" Then
            If cbReverseSort2.CheckState = CheckState.Checked Then
                SortFields = Me.SortField2 & " DESC"
            Else
                SortFields = Me.SortField2 & " ASC"
            End If
        Else
            If cbReverseSort1.CheckState = CheckState.Checked Then
                SortFields = Me.SortField1 & " DESC"
            Else
                SortFields = Me.SortField1 & " ASC"
            End If
            If cbReverseSort2.CheckState = CheckState.Checked Then
                SortFields += "," & Me.SortField2 & " DESC"
            Else
                SortFields += "," & Me.SortField2 & " ASC"
            End If
        End If
        GetSortFields = SortFields
    End Function

    Sub PopulateSortCombo()
        Dim fIelds As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim arrFields() As String

        fIelds = myDAL.GetLogSortFields()
        arrFields = Split(fIelds, ",")
        comSortFields.Items.Clear()
        comSortFields2.Items.Clear()

        For i As Integer = 0 To arrFields.Length - 1
            comSortFields.Items.Add(arrFields(i))
            comSortFields2.Items.Add(arrFields(i))
        Next

    End Sub

    Public Sub PopulateLOGGrid(ConnString As String, Version As String, Username As String, UserIDs As String, AccountIDs As String, strLogIDs As String,
                                DateFrom As String, DateTo As String, System As String, Planet As String, Brief As String, Comment1 As String,
                                Optional ByVal SortFields As String = "",
                                Optional ByRef dt As DataTable = Nothing)
        Dim strRecID As String
        Dim RecID As Integer
        Dim NumRows As Integer
        Dim DAL As New clsNMSdal(Version, Username)
        Dim LoadOK As Boolean = False
        Dim ImageByte() As Byte
        Dim memStream As New IO.MemoryStream
        Dim dblImageSizeKilobytes As Double
        Dim strImageFilename As String
        Dim strRTF1 As String
        Dim strRTF2 As String
        Dim strSQL As String
        Dim ErrMessage As String

        strSQL = ""
        dt = DAL.GetLogTableDisplayValues(ConnString, UserIDs, AccountIDs, strLogIDs, True, DateFrom, DateTo, System, Planet, Brief, Comment1, strSQL, SortFields)
        If Not IsNothing(dt) Then
            NumRows = dt.Rows.Count
        Else
            NumRows = 0
        End If

        txtTotalEntries.Text = CStr(NumRows)

        If NumRows = 0 Then
            'Clear all fields
            txtEntryDate.Text = ""
            txtNanites.Text = ""
            txtUnits.Text = ""
            txtQuicksilver.Text = ""
            txtFrigateModules.Text = ""
            txtSalvagedData.Text = ""
            txtSystem.Text = ""
            txtPlanet.Text = ""
            txtCoords.Text = ""
            txtArea.Text = ""
            txtBrief.Text = ""
            rtbComment.Rtf = ""
            rtbFurtherComment.Rtf = ""
            txtLastSaved.Text = ""
        End If
        ErrMessage = ""
        Call DAL.PopulateMyDataSource(dgvLOG.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessage, dt)

    End Sub

    Public Sub SelectedCell2(CellSelected As DataGridViewCellEventArgs, SelectedCell As Integer)
        Dim SearchText As String
        Dim SearchField As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim FieldType As String
        Dim Reversed As Boolean
        Dim SortFields As String
        Dim strUserIDs As String
        Dim strAccounts As String
        Dim IDFieldvalue As String
        Dim intID As Integer
        Dim intUserID As Integer
        Dim strLogIDs As String
        Dim intLogID As Integer
        Dim ExcludeFields As String
        Dim FoundAccount As Boolean
        Dim AllFields() As String = Nothing
        Dim AllValues() As Object = Nothing
        Dim DBTable As String
        Dim SearchCriteria As String
        Dim ErrMessage As String = ""
        Dim strEntryDate As String
        Dim strUnits As String
        Dim rowIDX As Integer
        Dim strAccountName As String
        Dim strPlatform As String
        Dim strVersion As String
        Dim strGamerHandle As String
        Dim strCurrentSystem As String
        Dim strNewSystemName As String
        Dim strOriginalPlanetName As String
        Dim strOriginalSystemName As String
        Dim strGalacticRegion As String
        Dim strDefaultSystem As String
        Dim strAccount As String
        Dim strQuickSilver As String
        Dim strNanites As String
        Dim strFrigateModules As String
        Dim strSalvagedData As String
        Dim strBrief As String
        Dim strArea As String
        Dim strCoords As String
        Dim strPlanet As String
        Dim strSystem As String
        Dim strDefault As String
        Dim strSystemID As String
        Dim strPlanetID As String
        Dim strComment As String
        Dim strFurtherComment As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim RTF1Bytes() As Byte
        Dim RTF2Bytes() As Byte
        Dim strSQL As String
        Dim dt As DataTable
        Dim dt2 As DataTable
        Dim NumRows As Integer = 0
        Dim TotalRows As Integer = 0
        Dim ErrMessages As String = ""
        Dim ms As New IO.MemoryStream
        Dim ms2 As New IO.MemoryStream
        Dim ImageByte() As Byte
        Dim LoadOK As Boolean = False
        Dim memStream As IO.MemoryStream
        Dim strImageFilename As String
        Dim dblImageSizeKilobytes As Double
        Dim strLastSaved As String


        'Keeps resseting rows - going back to top after selection !!!!!!


        Me.txtUnits.Text = ""
        Me.txtNanites.Text = ""
        Me.txtQuicksilver.Text = ""
        Me.txtFrigateModules.Text = ""
        Me.txtSalvagedData.Text = ""
        Me.txtSystem.Text = ""
        Me.txtPlanet.Text = ""
        Me.txtArea.Text = ""
        Me.txtCoords.Text = ""
        Me.txtBrief.Text = ""
        Me.rtbComment.Rtf = ""
        Me.txtLastSaved.Text = ""
        Me.txtOriginalPlanetName.Text = ""
        Me.txtOriginalSystemName.Text = ""
        Me.rtbFurtherComment.Rtf = ""
        pb1.BackgroundImage = Nothing

        If Not IsNothing(CellSelected) Then
            If CellSelected.RowIndex > -1 Then
                rowIDX = CellSelected.RowIndex
            Else
                rowIDX = 0
            End If
        End If
        If SelectedCell >= 0 Then
            rowIDX = SelectedCell
        End If
        'End If
        dt = Nothing
        'These are ALLOWABLE UserIds that can view and edit the LOG records: comma delimited string:
        strUserIDs = DAL.GetCollaboratedUserIDs(frmMain.myConnString, "tblAccounts", frmMain.myUserID, 0, strAccounts)
        If strUserIDs = "" Then
            strUserIDs = frmMain.myUserID
        End If

        'Get LOGID from row selected in grid:
        strLogIDs = "" 'comma-delimited list
        'rowIDX = CellSelected.RowIndex
        'DAL.PopulateMyDataSource(dgvSystems.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        SortFields = GetSortFields()

        PopulateLOGGrid(frmMain.myConnString, frmMain.myVersion, frmMain.myUsername, strUserIDs, strAccounts,
                        strLogIDs, txtFilterDateFrom.Text, txtFilterDateTo.Text, txtFilterSystem.Text, txtFilterPlanet.Text,
                        txtFilterBrief.Text, txtFilterComment.Text, SortFields, dt)

        If IsNothing(dt) Then
            Exit Sub
        End If

        dgvLOG.DataSource = dt
        TotalRows = dt.Rows.Count
        Me.txtTotalEntries.Text = CStr(TotalRows)

        If rowIDX > TotalRows Then
            MsgBox("Out of range, select different row")
            Exit Sub
        End If
        'strRegisterID = Me.dgvAssetRegistry.Item(0, Me.dgvAssetRegistry.CurrentCell.RowIndex).Value.ToString
        'strAccountID = Me.dgvAccounts.Item(1, rowIDX).Value.ToString
        'pbWaypointPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
        'rtfByte = Convert.ToByte(myBytes) 'object value in brackets
        If TotalRows > 0 Then
            intLogID = dgvLOG.Rows(rowIDX).Cells("LogID").Value
            strAccount = dgvLOG.Rows(rowIDX).Cells("Account").Value
            strEntryDate = dgvLOG.Rows(rowIDX).Cells("Entry Date").Value
            strUnits = dgvLOG.Rows(rowIDX).Cells("Units").Value
            strNanites = dgvLOG.Rows(rowIDX).Cells("Nanites").Value
            strQuickSilver = dgvLOG.Rows(rowIDX).Cells("QS").Value
            strFrigateModules = dgvLOG.Rows(rowIDX).Cells("FM").Value
            strSalvagedData = dgvLOG.Rows(rowIDX).Cells("SD").Value
            strBrief = dgvLOG.Rows(rowIDX).Cells("Brief").Value
            strComment = dgvLOG.Rows(rowIDX).Cells("Comment1").Value
            strFurtherComment = dgvLOG.Rows(rowIDX).Cells("Comment2").Value
            If Not IsDBNull(dgvLOG.Rows(rowIDX).Cells("Position").Value) Then
                strCoords = dgvLOG.Rows(rowIDX).Cells("Position").Value
            Else
                strCoords = "()()"
            End If
            If Not IsDBNull(dgvLOG.Rows(rowIDX).Cells("System").Value) Then
                strSystem = dgvLOG.Rows(rowIDX).Cells("System").Value
            Else
                strSystem = "UNKNOWN"
            End If
            If Not IsDBNull(dgvLOG.Rows(rowIDX).Cells("Orig. System").Value) Then
                strOriginalSystemName = dgvLOG.Rows(rowIDX).Cells("Orig. System").Value
            Else
                strOriginalSystemName = "UNKNOWN"
            End If
            If Not IsDBNull(dgvLOG.Rows(rowIDX).Cells("Planet").Value) Then
                strPlanet = dgvLOG.Rows(rowIDX).Cells("Planet").Value
            Else
                strPlanet = "UNKNOWN"
            End If
            If Not IsDBNull(dgvLOG.Rows(rowIDX).Cells("Orig. Planet").Value) Then
                strOriginalPlanetName = dgvLOG.Rows(rowIDX).Cells("Orig. Planet").Value
            Else
                strOriginalPlanetName = "UNKNOWN"
            End If
            If Not IsDBNull(dgvLOG.Rows(rowIDX).Cells("Area").Value) Then
                strArea = dgvLOG.Rows(rowIDX).Cells("Area").Value
            Else
                strArea = ""
            End If

            strLastSaved = dgvLOG.Rows(rowIDX).Cells("Last Saved").Value
            txtLogID.Text = CStr(intLogID)
            'RTF1Bytes = System.Text.Encoding.ASCII.GetBytes(dt.Rows(rowIDX)("Comment1").ToString)
            'RTF2Bytes = System.Text.Encoding.ASCII.GetBytes(dt.Rows(rowIDX)("Comment2").ToString)
            'NEED CORRECT ROW for this LOGID. CAnnot use RowIDX here becuse it represents the row index in the grid and NOT the proper record ID for LOGID !!!

            strSQL = "SELECT * FROM tblLog WHERE LOGID=" & intLogID
            dt2 = DAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
            If Not IsDBNull(dt2.Rows(0)("RTFComment1")) Then
                RTF1Bytes = dt2.Rows(0)("RTFComment1")
                ms = New IO.MemoryStream(RTF1Bytes)
                rtbComment.LoadFile(ms, RichTextBoxStreamType.RichText)
            End If
            If Not IsDBNull(dt2.Rows(0)("RTFComment2")) Then
                RTF2Bytes = dt2.Rows(0)("RTFComment2")
                ms2 = New IO.MemoryStream(RTF2Bytes)
                rtbFurtherComment.LoadFile(ms2, RichTextBoxStreamType.RichText)
            End If
            'rtbComment.LoadFile(ms, RichTextBoxStreamType.RichText)

            'dt.Select()
            'SHOW PIC:
            ImageByte = Nothing
            LoadOK = DAL.Get_Pic_From_DB(frmMain.myConnString, "tblLog", "Image", "LogID", CStr(intLogID), ImageByte)
            If LoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pb1.BackgroundImage = Image.FromStream(memStream)
                pb1.BackgroundImageLayout = ImageLayout.Stretch
                strImageFilename = pb1.ImageLocation
                dblImageSizeKilobytes = memStream.Length / 1024
                pb1.Tag = strImageFilename
                txtFilename.Text = strImageFilename
                txtImageSize.Text = CStr(dblImageSizeKilobytes)
            End If
            dgvLOG.FirstDisplayedScrollingRowIndex = dgvLOG.Rows(rowIDX).Index
            dgvLOG.Refresh()
            dgvLOG.CurrentCell = dgvLOG.Rows(rowIDX).Cells(1)
            dgvLOG.Rows(rowIDX).Selected = True

            'Plot Field Values onto form:

            If IsDate(strEntryDate) Then
                Me.txtEntryDate.Text = CDate(strEntryDate).ToString("dd-MMM-yyyy HH:mm:ss")
            End If
            If IsDate(strLastSaved) Then
                Me.txtLastSaved.Text = CDate(strLastSaved).ToString("dd-MMM-yyyy HH:mm:ss")
            End If
            Me.txtLogID.Text = CStr(intLogID)
            Me.txtAccount.Text = strAccount
            Me.txtUnits.Text = Format(strUnits, "currency")
            Me.txtNanites.Text = Format(strNanites, "standard")
            Me.txtQuicksilver.Text = Format(strQuickSilver, "standard")
            Me.txtFrigateModules.Text = Format(strFrigateModules, "standard")
            Me.txtSalvagedData.Text = Format(strSalvagedData, "standard")
            Me.txtSystem.Text = strSystem
            Me.txtPlanet.Text = strPlanet
            Me.txtArea.Text = strArea
            Me.txtCoords.Text = strCoords
            Me.txtBrief.Text = strBrief
            Me.txtOriginalSystemName.Text = strOriginalSystemName
            Me.txtOriginalPlanetName.Text = strOriginalPlanetName

            If dgvLOG.RowCount > 0 Then
                '
                dgvLOG.Rows(rowIDX).Selected = True
            Else
                Me.txtLogID.Text = "0"
                Me.txtAccount.Text = ""
                Me.txtUnits.Text = "0"
                Me.txtNanites.Text = "0"
                Me.txtQuicksilver.Text = "0"
                Me.txtFrigateModules.Text = "0"
                Me.txtSalvagedData.Text = "0"
                Me.txtSystem.Text = ""
                Me.txtPlanet.Text = ""
                Me.txtArea.Text = ""
                Me.txtCoords.Text = ""
                Me.txtBrief.Text = ""
                Me.rtbComment.Rtf = ""
                Me.txtOriginalPlanetName.Text = ""
                Me.txtOriginalSystemName.Text = ""
                Me.rtbFurtherComment.Rtf = ""
            End If
        End If


    End Sub



    Public Sub SelectedCell(CellSelected As DataGridViewCellEventArgs)
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
        Dim strEntryDate As String
        Dim strUnits As String
        Dim rowIDX As Integer
        Dim strQuickSilver As String
        Dim strNanites As String
        Dim strBrief As String
        Dim strArea As String
        Dim strCoords As String
        Dim strPlanet As String
        Dim strSystem As String
        Dim strDefault As String
        Dim strUserID As String
        Dim strSystemID As String
        Dim strPlanetID As String
        Dim strComment As String
        Dim strFurtherComment As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Dim strSQL As String
        Dim dt As DataTable
        Dim NumRows As Integer = 0
        Dim TotalRows As Integer = 0
        Dim ErrMessages As String = ""

        If CellSelected.RowIndex > -1 Then
            rowIDX = CellSelected.RowIndex
        Else
            rowIDX = 0
        End If
        DBTable = "tblLog"
        'strSQL = "SELECT * FROM " & DBTable
        If Not IsNothing(CellSelected) Then
            If CellSelected.RowIndex > -1 Then
                rowIDX = CellSelected.RowIndex
            Else
                rowIDX = 0
            End If
        End If
        dt = Nothing

        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvSystems.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        dgvLOG.DataSource = dt
        Me.txtTotalEntries.Text = CStr(NumRows)
        TotalRows = dt.Rows.Count
        If rowIDX > TotalRows Then
            MsgBox("Out of range, select different row")
            Exit Sub
        End If
        'strRegisterID = Me.dgvAssetRegistry.Item(0, Me.dgvAssetRegistry.CurrentCell.RowIndex).Value.ToString
        'strAccountID = Me.dgvAccounts.Item(1, rowIDX).Value.ToString
        If dt IsNot Nothing Then
            strEntryDate = dt.Rows(rowIDX)("CurrentDateTime").ToString
            strUnits = dt.Rows(rowIDX)("CurrentUnits").ToString
            strNanites = dt.Rows(rowIDX)("CurrentNanites").ToString
            strQuickSilver = dt.Rows(rowIDX)("CurrentQuickSilver").ToString
            strBrief = dt.Rows(rowIDX)("Brief").ToString
            strComment = dt.Rows(rowIDX)("Comment1").ToString
            strFurtherComment = dt.Rows(rowIDX)("Comment2").ToString
            strCoords = dt.Rows(rowIDX)("CurrentPosition").ToString
            strSystem = dt.Rows(rowIDX)("CurrentStarSystem").ToString
            strPlanet = dt.Rows(rowIDX)("CurrentPlanet").ToString
            strArea = dt.Rows(rowIDX)("CurrentPlanetArea").ToString
            'dt.Select()

        End If

        If IsDate(strEntryDate) Then
            Me.txtEntryDate.Text = CDate(strEntryDate).ToString("dd-MMM-yyyy HH:mm:ss")
        End If
        Me.txtUnits.Text = Format(strUnits, "##,##0.0")
        Me.txtNanites.Text = Format(strNanites, "##,##0.0")
        Me.txtQuicksilver.Text = Format(strQuickSilver, "##,##0.0")
        Me.txtSystem.Text = strSystem
        Me.txtPlanet.Text = strPlanet
        Me.txtArea.Text = strArea
        Me.txtCoords.Text = strCoords
        Me.txtBrief.Text = strBrief
        Me.rtbComment.Rtf = strComment
        Me.rtbFurtherComment.Rtf = strFurtherComment
        If dgvLOG.RowCount > 0 Then
            '
            dgvLOG.Rows(rowIDX).Selected = True
        Else
            Me.txtUnits.Text = ""
            Me.txtNanites.Text = ""
            Me.txtQuicksilver.Text = ""
            Me.txtSystem.Text = ""
            Me.txtPlanet.Text = ""
            Me.txtArea.Text = ""
            Me.txtCoords.Text = ""
            Me.txtBrief.Text = ""
            Me.rtbComment.Rtf = ""
            Me.rtbFurtherComment.Rtf = ""
        End If

    End Sub

    Public Sub AddLogEntry()
        'Open Log Entry form and clear all fields:
        Dim LOGForm As Form_LogEntry3
        Dim frmName As String
        Dim SearchName As String = "LOGForm_ENTRY3"
        Dim TagCode As String

        LOGForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(LOGForm) Then
            frmName = LOGForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            LOGForm = New Form_LogEntry3
            LOGForm.Name = SearchName
            LOGForm.Text = "LOG FORM ENTRY v3"
            LOGForm.MdiParent = frmMain
            LOGForm.StartPosition = FormStartPosition.Manual
            TagCode = frmMain.Get_GUID()
            LOGForm.txtLogID.Text = "0"
            LOGForm.strLOGID = "0"
            LOGForm.Tag = TagCode
            LOGForm.PopulateLogEntry(LOGForm.strLOGID, False, False)
            LOGForm.Show()
        End If
    End Sub

    Public Sub EditLogEntry()
        'Open Log Entry form and clear all fields:
        Dim LOGForm As Form_LogEntry3
        Dim frmName As String
        Dim SearchName As String = "LOGForm_ENTRY3"
        Dim TagCode As String

        LOGForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(LOGForm) Then
            frmName = LOGForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()
            End If
        Else
            LOGForm = New Form_LogEntry3
            LOGForm.Name = SearchName
            LOGForm.Text = "LOG FORM ENTRY v3"
            LOGForm.MdiParent = frmMain
            LOGForm.StartPosition = FormStartPosition.Manual
            LOGForm.strLOGID = txtLogID.Text
            LOGForm.txtLogID.Text = txtLogID.Text
            TagCode = frmMain.Get_GUID()
            LOGForm.Tag = TagCode
            LOGForm.PopulateLogEntry(LOGForm.strLOGID, False, False)
            LOGForm.Show()
        End If
    End Sub

    Public Sub CopyLogEntry()
        'Open Log Entry form and clear all fields: then copy from EDIT but setting LogID to zero...
        Dim LOGForm As Form_LogEntry3
        Dim frmName As String
        Dim SearchName As String = "LOGForm_ENTRY3"
        Dim TagCode As String

        LOGForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(LOGForm) Then
            frmName = LOGForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            LOGForm = New Form_LogEntry3
            LOGForm.Name = SearchName
            LOGForm.Text = "LOG FORM ENTRY v3"
            LOGForm.MdiParent = frmMain
            LOGForm.StartPosition = FormStartPosition.Manual
            LOGForm.strLOGID = txtLogID.Text
            LOGForm.txtLogID.Text = txtLogID.Text
            TagCode = frmMain.Get_GUID()
            LOGForm.Tag = TagCode
            LOGForm.PopulateLogEntry(LOGForm.strLOGID, False, True)
            LOGForm.Show()
        End If
    End Sub

    Private Sub ToolStripADD_Click(sender As Object, e As EventArgs) Handles ToolStripADD.Click
        'NEW LOG ENTRY:
        'Open Log Entry form and clear all fields:
        Dim LOGForm As New Form_LogEntry3
        Dim frmName As String
        Dim SearchName As String = "LOGForm_ENTRY"
        Dim TagCode As String

        'Test if child window not already open ?
        'cf.MdiParent = Me

        'cf.StartPosition = FormStartPosition.CenterParent
        'cf.Text = "REFERENCE PROGRESS " & CStr(MdiChildren.Count)
        'cf.Name = "ReferenceProgress"
        'cf.Show()

        LOGForm = frmMain.Get_MDIChildForm(SearchName)

        If Not IsNothing(LOGForm) Then
            frmName = LOGForm.Name
            If UCase(frmName) = UCase(SearchName) Then
                'ALREADY OPEN:
                'Generic Form or Child Forms of the Generic ?
                Application.OpenForms.Item(SearchName).Activate()

            End If
        Else
            LOGForm = New Form_LogEntry3
            LOGForm.Name = SearchName
            LOGForm.Text = "LOG FORM ENTRY"
            LOGForm.MdiParent = frmMain
            LOGForm.StartPosition = FormStartPosition.Manual
            TagCode = frmMain.Get_GUID()
            LOGForm.Tag = TagCode
            'LOGForm.PopulateLOGGrid()
            LOGForm.Show()
        End If
    End Sub

    Private Sub ToolStripEDIT_Click(sender As Object, e As EventArgs) Handles ToolStripEDIT.Click
        'EDIT LOG ENTRY:
        'Open LOG Entry form and populate with current details from grid:
        EditLogEntry()


    End Sub

    Private Sub ToolStripDELETE_Click(sender As Object, e As EventArgs) Handles ToolStripDELETE.Click
        'DELETE LOG ENTRY:

    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs)
        'SAVE LOG:

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'SEARCH:
        Dim strSQL As String
        Dim DBTable As String = "tblLog"
        Dim SearchFields As String
        Dim strUserIDs As String
        Dim strLogIDs As String
        Dim dt As DataTable
        Dim SortFields As String

        strUserIDs = frmMain.myUserID
        'Provide a separate control for user to required logIDs to view.
        'strLogIDs = txtLogID.Text
        SortFields = GetSortFields()
        PopulateLOGGrid(frmMain.myConnString, frmMain.myVersion, frmMain.myUsername, strUserIDs, Me.SelectedAccountID,
                        strLogIDs, txtFilterDateFrom.Text, txtFilterDateTo.Text, txtFilterSystem.Text, txtFilterPlanet.Text,
                        txtFilterBrief.Text, txtFilterComment.Text, SortFields, dt)
    End Sub

    Private Sub dgvLOG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLOG.CellContentClick
        'select row:
        SelectedCell2(e, -1)
    End Sub

    Private Sub frmLogView_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim strUserIDs As String
        Dim strLogIDs As String
        Dim dt As DataTable
        Dim SortFields As String

        strUserIDs = frmMain.myUserID
        'strLogIDs = txtLogID.Text
        SortFields = GetSortFields()
        PopulateLOGGrid(frmMain.myConnString, frmMain.myVersion, frmMain.myUsername, strUserIDs, Me.SelectedAccountID,
                        strLogIDs, txtFilterDateFrom.Text, txtFilterDateTo.Text, txtFilterSystem.Text, txtFilterPlanet.Text,
                        txtFilterBrief.Text, txtFilterComment.Text, SortFields, dt)
        If txtLogID.Text = "" Or txtLogID.Text = "0" Then
            'SelectedCell2(Nothing, dgvLOG.RowCount - 1)
        End If
    End Sub

    Private Sub cbReverseSort_CheckedChanged(sender As Object, e As EventArgs) Handles cbReverseSort.CheckedChanged
        Dim strUserIDs As String
        Dim strLogIDs As String
        Dim dt As DataTable
        Dim SortFields As String

        strUserIDs = frmMain.myUserID
        'strLogIDs = txtLogID.Text
        SortFields = GetSortFields()
        PopulateLOGGrid(frmMain.myConnString, frmMain.myVersion, frmMain.myUsername, strUserIDs, Me.SelectedAccountID,
                        strLogIDs, txtFilterDateFrom.Text, txtFilterDateTo.Text, txtFilterSystem.Text, txtFilterPlanet.Text,
                        txtFilterBrief.Text, txtFilterComment.Text, SortFields, dt)
    End Sub

    Private Sub dgvLOG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLOG.CellClick
        SelectedCell2(e, -1)
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddLogEntry()


    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        'COPY Fields to memory. Pass to NEW form entry (yes it IS different to EDIT - use recID=0 but with selected data as a start)

        CopyLogEntry()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim strLogID As String

        EditLogEntry()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim strUserIDs As String
        Dim strLogIDs As String
        Dim dt As DataTable
        Dim SortFields As String

        strUserIDs = frmMain.myUserID
        'strLogIDs = txtLogID.Text
        SortFields = GetSortFields()
        PopulateLOGGrid(frmMain.myConnString, frmMain.myVersion, frmMain.myUsername, strUserIDs, Me.SelectedAccountID,
                        strLogIDs, txtFilterDateFrom.Text, txtFilterDateTo.Text, txtFilterSystem.Text, txtFilterPlanet.Text,
                        txtFilterBrief.Text, txtFilterComment.Text, SortFields, dt)
        If txtLogID.Text = "" Or txtLogID.Text = "0" Then
            SelectedCell2(Nothing, dgvLOG.RowCount - 1)
        End If

    End Sub

    Private Sub btnSortGrid_Click(sender As Object, e As EventArgs) Handles btnSortGrid.Click
        'SORT GRID:
        If Not comSortFields.Text = "" Then

            If cbReverseSort1.Checked Then
                Me.SortField1 = comSortFields.Text & " DESC"
            Else
                Me.SortField1 = comSortFields.Text & " ASC"
            End If
        Else
            Me.SortField1 = ""
        End If
        If Not comSortFields2.Text = "" Then
            If cbReverseSort2.Checked Then
                Me.SortField2 = comSortFields2.Text & " DESC"
            Else
                Me.SortField2 = comSortFields2.Text & " ASC"
            End If
        Else
            Me.SortField2 = ""
        End If

    End Sub

    Private Sub btnClearSorts_Click(sender As Object, e As EventArgs) Handles btnClearSorts.Click
        comSortFields.Text = ""
        comSortFields2.Text = ""
    End Sub

    Sub ClearAccounts()
        Me.txtAccountID.Text = ""
        Me.txtAccountName.Text = ""
        Me.txtPlatform.Text = ""
        Me.txtVersion.Text = ""
        Me.txtGamerHandle.Text = ""
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
        Dim strUserIDs As String
        Dim strLogIDs As String = ""
        Dim Accounts As String = ""
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        'Need to use FindQuery here as items in list re-arrange and indexes are then wrong !
        ClearAccounts()
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
        Me.SelectedAccountID = CInt(AccountID)
        ReturnField = "AccountID"
        FieldType = "STRING"

        Me.txtAccountID.Text = AccountID
        Me.txtAccountName.Text = AccountName
        Me.txtPlatform.Text = GamePlatform
        Me.txtVersion.Text = GameVersion
        Me.txtGamerHandle.Text = GamerHandle

        strUserIDs = myDAL.GetCollaboratedUserIDs(frmMain.myConnString, "tblAccounts", frmMain.myUserID, 0, Accounts)
        If strUserIDs = "" Then
            strUserIDs = frmMain.myUserID
        End If
        SortFields = GetSortFields()
        PopulateLOGGrid(frmMain.myConnString, frmMain.myVersion, frmMain.myUsername, strUserIDs, Me.SelectedAccountID,
                        strLogIDs, txtFilterDateFrom.Text, txtFilterDateTo.Text, txtFilterSystem.Text, txtFilterPlanet.Text,
                        txtFilterBrief.Text, txtFilterComment.Text, SortFields, Nothing)

    End Sub

    Sub SelectDefaultAccount(UserID As Integer)
        Dim SearchText As String
        Dim SearchField As String
        Dim SearchCriteria As String
        Dim FoundAccount As Boolean
        Dim AccountID As String
        Dim AccountName As String
        Dim GamerHandle As String
        Dim GamePlatform As String
        Dim GameVersion As String
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim DBTable As String = "tblAccounts"
        Dim FieldType As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim SortFields As String
        Dim Reversed As Boolean = False
        Dim NumRows As Integer
        Dim ErrMessage As String = ""

        SearchText = "DEFAULT"
        SearchField = "DefaultAccount"
        SearchCriteria = "UserID=" & UserID

        FoundAccount = myDAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues, AllFields,
                                        SearchCriteria, SortFields, Reversed, ErrMessage, "=", NumRows)
        If FoundAccount Then
            AccountID = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountID")
            GamerHandle = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamerHandle")
            AccountName = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "AccountName")
            GamePlatform = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GamePlatform")
            GameVersion = myDAL.GetMYValuebyFieldname(AllValues, AllFields, "GameVersion")

            Me.txtAccountID.Text = AccountID
            Me.txtAccountName.Text = AccountName
            Me.txtPlatform.Text = GamePlatform
            Me.txtVersion.Text = GameVersion
            Me.txtGamerHandle.Text = GamerHandle
        End If
    End Sub

    Private Sub comAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAccounts.SelectedIndexChanged
        'ACCOUNT HAS BEEN SELECTED:
        'SelectAccount(False, comAccounts.SelectedItem)

        SelectAccount(False, comAccounts.SelectedItem)

    End Sub
End Class