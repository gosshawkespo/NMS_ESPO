Public Class frmTransactions
    Private Sub txtPlanet_TextChanged(sender As Object, e As EventArgs) Handles txtPlanet.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Function IsInList(lstBox As ListBox, FindItem As String) As Boolean
        IsInList = False
        For IDX As Integer = 0 To lstBox.Items.Count - 1
            If lstBox.Items.Item(IDX) = FindItem Then
                IsInList = True
                Exit For
            End If
        Next

    End Function


    Sub GetUnits(strAccountID As String)
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim Nanites As String
        Dim Units As String
        Dim Quicksilver As String
        Dim FrigateModules As String
        Dim LastSaved As String
        Dim UpdatedOK As Boolean
        Dim arrUnits As String()
        Dim AllUnits As String

        If strAccountID = "" Or strAccountID = "0" Then
            'MsgBox("Problem Getting Units")
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
            LastSaved = arrUnits(4)
        Else
            LastSaved = ""
        End If
        txtTotalNanites.Text = Nanites
        txtTotalUnits.Text = Units
        txtTotalQS.Text = Quicksilver
        txtTotalFrigateModules.Text = FrigateModules
    End Sub

    Public Sub BuildAccountCombo(strUserIDs As String)

        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim Accounts As String
        Dim ItemName As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)

        'strUserIDs = dal.GetCollaboratedUserIDs(frmMain.myConnString, "tblLog", frmMain.myUserID, 0, Accounts)
        If strUserIDs = "" Or strUserIDs = "0" Then
            strUserIDs = frmMain.myUserID
        End If
        Tablename = "tblAccounts"
        strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & strUserIDs & ")"
        strSQL += " ORDER BY AccountName"
        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        'dt.Select()
        lstAccounts.Items.Clear()

        If Not IsNothing(dt) Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If Not IsNothing(dt.Rows(i)("AccountName")) Then
                    ItemName = dt.Rows(i)("AccountName")
                    If Not IsInList(lstAccounts, ItemName) And ItemName <> "" Then
                        lstAccounts.Items.Add(ItemName)
                    End If
                End If
            Next
        End If
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub BuildSystemCombo(strUserIDs As String, ByVal strAccountID As String, BuildIfEmpty As Boolean)

        Dim dt As New DataTable
        Dim strSQL As String
        Dim ErrMessage As String = ""
        Dim NumRows As Integer
        Dim Tablename As String
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUserID)
        Dim strBuildField As String
        Dim ItemName As String
        Dim strAccountIDs As String

        If strUserIDs = "" Or strUserIDs = "0" Then
            strUserIDs = frmMain.myUserID
        End If

        Tablename = "tblSystems"
        'If Not Integer.TryParse(strUserID, intUserID) Then
        'intUserID = 0
        'End If
        If strAccountID = "" Or strAccountID = "0" Then
            If BuildIfEmpty = False Then
                lstSystems.Items.Clear()
                Exit Sub
            End If
            strAccountIDs = txtAccountID.Text
        Else
            strAccountIDs = strAccountID
        End If
        If rbOriginalNames.Checked = True Then
            strBuildField = "OriginalSystemName"
        Else
            strBuildField = "RenamedSystemName"
        End If
        'strAccountIDs
        strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & strUserIDs & ") "
        If strAccountIDs <> "" And strAccountIDs <> "0" Then
            strSQL += " AND AccountID in (" & strAccountIDs & ")"
        End If

        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        'dt.Select()
        If NumRows = 0 Then
            Exit Sub
        End If
        lstSystems.Items.Clear()

        If Not IsNothing(dt) Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If Not IsNothing(dt.Rows(i)(strBuildField)) Then
                    ItemName = dt.Rows(i)(strBuildField)
                    If Not IsInList(lstSystems, ItemName) And ItemName <> "" Then
                        lstSystems.Items.Add(ItemName)
                    End If
                End If
            Next
        End If

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub BuildPlanetCombo(strUserIDs As String, strAccountID As String, ByVal strSystemID As String, BuildIfEmpty As Boolean)

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
        Dim strAccountIDs As String
        Dim ItemName As String
        Dim strSystemIDs As String

        If strUserIDs = "" Then
            strUserIDs = frmMain.myUserID
        End If
        If strAccountID = "" Or strAccountID = "0" Then
            If BuildIfEmpty = False Then
                lstPlanets.Items.Clear()
                Exit Sub
            End If
            strAccountIDs = txtAccountID.Text
        Else
            strAccountIDs = strAccountID
        End If
        If strSystemID = "" Or strSystemID = "0" Then
            If BuildIfEmpty = False Then
                lstPlanets.Items.Clear()
                Exit Sub
            End If
            strSystemIDs = txtSystemID.Text
        Else
            strSystemIDs = strSystemID
        End If

        Tablename = "tblPlanets"
        If rbOriginalNames.Checked = True Then
            strBuildField = "OriginalPlanetName"
        Else
            strBuildField = "RenamedPlanetName"
        End If
        strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & strUserIDs & ")"
        If strAccountIDs <> "" Then
            strSQL += " AND AccountID in (" & strAccountIDs & ")"
        End If
        If strSystemIDs <> "" Then
            strSQL += " AND SystemID in (" & strSystemIDs & ")"
        End If

        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        If NumRows = 0 Then
            Exit Sub
        End If
        lstPlanets.Items.Clear()

        If Not IsNothing(dt) Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If Not IsNothing(dt.Rows(i)(strBuildField)) Then
                    ItemName = dt.Rows(i)(strBuildField)
                    If Not IsInList(lstPlanets, ItemName) And ItemName <> "" Then
                        lstPlanets.Items.Add(ItemName)
                    End If
                End If
            Next
        End If

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub BuildLocations(strUserIDs As String, strAccountID As String, ByVal strSystemID As String, ByVal strPlanetID As String, BuildIfEmpty As Boolean)
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
        Dim strAccountIDs As String
        Dim ItemName As String
        Dim strSystemIDs As String
        Dim strPlanetIDs As String

        If strUserIDs = "" Then
            strUserIDs = frmMain.myUserID
        End If
        If strAccountID = "" Or strAccountID = "0" Then
            If BuildIfEmpty = False Then
                lstLocations.Items.Clear()
                Exit Sub
            End If
            strAccountIDs = txtAccountID.Text
        Else
            strAccountIDs = strAccountID
        End If
        If strSystemID = "" Or strSystemID = "0" Then
            If BuildIfEmpty = False Then
                lstLocations.Items.Clear()
                Exit Sub
            End If
            strSystemIDs = txtSystemID.Text
        Else
            strSystemIDs = strSystemID
        End If
        If strPlanetID = "" Or strPlanetID = "0" Then
            If BuildIfEmpty = False Then
                lstLocations.Items.Clear()
                Exit Sub
            End If
            strPlanetIDs = txtPlanetID.Text
        Else
            strPlanetIDs = strPlanetID
        End If
        Tablename = "tblTransactions"
        strSQL = "SELECT * FROM " & Tablename & " WHERE UserID in (" & strUserIDs & ")"
        If strAccountIDs <> "" Then
            strSQL += " AND AccountID in (" & strAccountIDs & ")"
        End If
        If strSystemIDs <> "" Then
            strSQL += " AND SystemID in (" & strSystemIDs & ")"
        End If
        If strPlanetIDs <> "" Then
            strSQL += " AND PlanetID in (" & strPlanetIDs & ")"
        End If

        dt = dal.GetDataTable(frmMain.myConnString, strSQL, NumRows)
        If NumRows = 0 Then
            Exit Sub
        End If
        lstPlanets.Items.Clear()

        If Not IsNothing(dt) Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If Not IsNothing(dt.Rows(i)("Location")) Then
                    ItemName = dt.Rows(i)("Location")
                    If Not IsInList(lstLocations, ItemName) And ItemName <> "" Then
                        lstLocations.Items.Add(ItemName)
                    End If
                End If
            Next
        End If

        dal = Nothing
        dt = Nothing
    End Sub

    Public Sub PopulateForm(strUserID As String, strAccountID As String, strSystemID As String, strPlanetID As String, strLocation As String)
        'Need to build 3 lists: Accounts,Systems and Planets oh and locations.
        'When the items are selected from the first 3 lists - ID is put into appropriate textbox.
        'Location list - the NAME is put into the Location textbox.
        'Each list depends on the previous....
        Dim strUserIDs As String
        Dim strAccountIDs As String
        Dim strSystemIDs As String
        Dim strPlanetIDs As String

        If strUserID = "" Then
            strUserIDs = frmMain.myUserID
        Else
            strUserIDs = strUserID
        End If
        txtUserID.Text = strUserIDs
        txtLocation.Text = strLocation
        BuildAccountCombo(strUserIDs)
        'Build ALL systems combo for this user if NO account chosen !
        'BuildSystemCombo(strUserIDs, strAccountID)
        'BuildPlanetCombo(strUserIDs, strAccountID, strSystemID)
        'BuildLocations(strUserIDs, strAccountID, strSystemID, strPlanetID)
        GetUnits(strAccountID)
    End Sub

    Sub SaveTransaction(Optional SaveMode As String = "DATE")
        Dim strTransactionID As String
        Dim strUserID As String
        Dim strAccountID As String
        Dim strSystemID As String
        Dim strPlanetID As String
        Dim strLocation As String
        Dim strProductName As String
        Dim strQSProductName As String
        Dim strUpgradeBlueprintName As String
        Dim strConstructionBlueprintName As String
        Dim strTradeType As String
        Dim strUnitsExchanged As String
        Dim strNanitesExchanged As String
        Dim strQuickSilverExchanged As String
        Dim strSalvagedDataExchanged As String
        Dim strFrigateUpgradeModulesExchanged As String
        Dim strBlueprintReceived As String
        Dim strDemandPercent As String
        Dim strQuantity As String
        Dim strUnitCost As String
        Dim strResourceExchanged As String
        Dim strResourceBartered As String
        Dim strTransactionDate As String
        Dim strLastSaved As String
        Dim strNotes As String
        Dim strTotalUnits As String
        Dim strTotalNanites As String
        Dim strTotalQuicksilver As String
        Dim strTotalFrigateModules As String
        Dim strTotalSalvagedDataModules As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblTransactions"
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
        Dim FoundTransaction As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim ResetOK As Boolean = False
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim NewIDValue As String
        Dim dt As DataTable
        Dim TotalTransactions As Integer
        Dim DateFormat As String = "yyyy-MM-dd HH:mm:ss"
        Dim SearchFormat As String = ""
        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.

        'PUT INTO DAL

        dtCurrentDate = Now()
        strTransactionDate = CDate("01/01/1970 01:00")
        If Len(txtTransactionDate.Text) = 0 Then
            txtTransactionDate.Text = dtCurrentDate.ToString("dd/MM/yyyy HH:mm:ss")
            strTransactionDate = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            If IsDate(txtTransactionDate.Text) Then
                strTransactionDate = CDate(txtTransactionDate.Text).ToString("yyyy-MM-dd HH:mm:ss")
            End If
        End If
        ErrMessages = ""
        strUserID = frmMain.myUserID
        strTransactionID = txtTransactionID.Text
        strLastSaved = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strAccountID = txtAccountID.Text
        strSystemID = txtSystemID.Text
        strPlanetID = txtPlanetID.Text
        strLocation = txtLocation.Text
        strProductName = txtProductName.Text
        strQSProductName = txtQuickSilverProduct.Text
        strUpgradeBlueprintName = txtBlueprintName.Text
        strConstructionBlueprintName = txtSalvageBlueprint.Text
        strBlueprintReceived = txtOtherBlueprintName.Text
        If strBlueprintReceived = "" Then
            If strUpgradeBlueprintName <> "" Then
                strBlueprintReceived = strUpgradeBlueprintName
            ElseIf strConstructionBlueprintName <> "" Then
                strBlueprintReceived = strConstructionBlueprintName
            End If
        End If
        strTradeType = txtTradeType.Text
        strUnitsExchanged = txtUnitsExchanged.Text
        strNanitesExchanged = txtNanitesRequired.Text
        strQuickSilverExchanged = txtQSRequired.Text
        strSalvagedDataExchanged = txtModulesRequired.Text
        strFrigateUpgradeModulesExchanged = txtFrigateModulesRequired.Text
        strDemandPercent = txtDemand.Text
        strQuantity = txtQuantity.Text
        strUnitCost = txtUnitCost.Text
        If strUnitsExchanged <> "" Then
            strResourceBartered = "UNITS"
            strResourceExchanged = "PRODUCT"
        ElseIf strNanitesExchanged <> "" Then
            strResourceBartered = "NANITES"
            strResourceExchanged = "UPGRADE BLUEPRINT"
        ElseIf strQuickSilverExchanged <> "" Then
            strResourceBartered = "QUICKSILVER"
            strResourceExchanged = "QS PRODUCT"
        ElseIf strSalvagedDataExchanged <> "" Then
            strResourceBartered = "DATA MODULES"
            strResourceExchanged = "CONSTRUCTION BLUEPRINT"
        ElseIf strFrigateUpgradeModulesExchanged <> "" Then
            strResourceBartered = "FRIGATE MODULES"
            strResourceExchanged = "FRIGATE BLUEPRINT"
        Else
            strResourceBartered = "NONE"
            strResourceExchanged = "NONE"
        End If
        strNotes = txtNotes.Text
        strTotalUnits = txtTotalUnits.Text
        strTotalNanites = txtTotalNanites.Text
        strTotalQuicksilver = txtTotalQS.Text
        strTotalFrigateModules = txtTotalFrigateModules.Text
        strTotalSalvagedDataModules = txtTotalSalvagedDataModules.Text

        FieldNames = "UserID"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",SystemID"
        FieldNames = FieldNames & ",PlanetID"
        FieldNames = FieldNames & ",Location"
        FieldNames = FieldNames & ",ProductName"
        FieldNames = FieldNames & ",QSProductName"
        FieldNames = FieldNames & ",UpgradeBlueprintName"
        FieldNames = FieldNames & ",ConstructionBlueprintName"
        FieldNames = FieldNames & ",TradeType"
        FieldNames = FieldNames & ",UnitsExchanged"
        FieldNames = FieldNames & ",NanitesExchanged"
        FieldNames = FieldNames & ",QuickSilverExchanged"
        FieldNames = FieldNames & ",SalvagedDataExchanged"
        FieldNames = FieldNames & ",FrigateUpgradeModulesExchanged"
        FieldNames = FieldNames & ",DemandPercent"
        FieldNames = FieldNames & ",Quantity"
        FieldNames = FieldNames & ",UnitCost"
        FieldNames = FieldNames & ",ResourceExchanged"
        FieldNames = FieldNames & ",ResourceBartered"
        FieldNames = FieldNames & ",TransactionDate"
        FieldNames = FieldNames & ",LastSaved"
        FieldNames = FieldNames & ",Notes"
        FieldNames = FieldNames & ",TotalUnits"
        FieldNames = FieldNames & ",TotalNanites"
        FieldNames = FieldNames & ",TotalQuicksilver"
        FieldNames = FieldNames & ",TotalFrigateModules"
        FieldNames = FieldNames & ",BlueprintReceived"

        FieldValues = strUserID
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strSystemID
        FieldValues = FieldValues & "," & strPlanetID
        FieldValues = FieldValues & "," & strLocation
        FieldValues = FieldValues & "," & strProductName
        FieldValues = FieldValues & "," & strQSProductName
        FieldValues = FieldValues & "," & strUpgradeBlueprintName
        FieldValues = FieldValues & "," & strConstructionBlueprintName
        FieldValues = FieldValues & "," & strTradeType
        FieldValues = FieldValues & "," & strUnitsExchanged
        FieldValues = FieldValues & "," & strNanitesExchanged
        FieldValues = FieldValues & "," & strQuickSilverExchanged
        FieldValues = FieldValues & "," & strSalvagedDataExchanged
        FieldValues = FieldValues & "," & strFrigateUpgradeModulesExchanged
        FieldValues = FieldValues & "," & strDemandPercent
        FieldValues = FieldValues & "," & strQuantity
        FieldValues = FieldValues & "," & strUnitCost
        FieldValues = FieldValues & "," & strResourceExchanged
        FieldValues = FieldValues & "," & strResourceBartered
        FieldValues = FieldValues & "," & strTransactionDate
        FieldValues = FieldValues & "," & strLastSaved
        FieldValues = FieldValues & "," & strNotes
        FieldValues = FieldValues & "," & strTotalUnits
        FieldValues = FieldValues & "," & strTotalNanites
        FieldValues = FieldValues & "," & strTotalQuicksilver
        FieldValues = FieldValues & "," & strTotalFrigateModules
        FieldValues = FieldValues & "," & strBlueprintReceived

        If SaveMode.ToUpper = "DATE" Then
            SearchText = strTransactionDate
            SearchField = "TransactionDate"
            FieldType = "DATE"
            SearchFormat = DateFormat
        Else
            If strProductName <> "" Then
                SearchText = strProductName
                SearchField = "ProductName"
                FieldType = "STRING"
                SearchFormat = ""
            ElseIf strUpgradeBlueprintName <> "" Then
                SearchText = strUpgradeBlueprintName
                SearchField = "UpgradeBlueprintName"
                FieldType = "STRING"
                SearchFormat = ""
            ElseIf strQSProductName <> "" Then
                SearchText = strQSProductName
                SearchField = "QSProductName"
                FieldType = "STRING"
                SearchFormat = ""
            ElseIf strConstructionBlueprintName <> "" Then
                SearchText = strConstructionBlueprintName
                SearchField = "ConstructionBlueprintName"
                FieldType = "STRING"
                SearchFormat = ""
            End If
        End If

        ReturnField = "TransactionID"
        ReturnValue = ""
        Reversed = True
        SortFields = "TransactionID"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundTransaction = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, SearchFormat, ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundTransaction Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Item Already EXISTS - Proceed with update?", vbYesNoCancel, "ITEM ALREADY EXISTS")
            If Answer = vbCancel Then
                Exit Sub
            ElseIf Answer = vbYes Then
                If FieldType = "INTEGER" And IsNumeric(SearchText) Then
                    'UpdateCriteria = SearchField & "=" & SearchText
                End If
                If FieldType = "STRING" Then
                    'UpdateCriteria = SearchField & "=" & "'" & SearchText & "'"
                End If
                UpdateCriteria = "TransactionID=" & CInt(ReturnValue)
                SavedOK = DAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                            ",", ";")
                NewIDValue = ReturnValue
            Else
                'Create NEW ENTRY:
                UpdateCriteria = ""
                SavedOK = DAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                    DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                                ",", ";")
                NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblTransactions", "TransactionID")
            End If
        Else
            'Create NEW ENTRY:
            UpdateCriteria = ""
            SavedOK = DAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                            ",", ";")
            NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblTransactions", "TransactionID")
        End If
        If SavedOK Then
            MsgBox("OK Transaction Info Updated.")
            txtTransactionID.Text = NewIDValue
            'UPDATE tblUnits:
            Answer = MsgBox("Update UNITS table ?", vbYesNo, "UPDATE UNITS?")
            If Answer = vbYes Then
                If DAL.UpdateUnits(frmMain.myConnString, txtAccountID.Text, txtTotalNanites.Text, txtTotalUnits.Text, txtTotalQS.Text, txtTotalFrigateModules.Text, txtTotalSalvagedDataModules.Text) Then
                    MsgBox("UNITS UPDATED OK")
                Else
                    MsgBox("UNITS DID NOT UPDATE")
                End If
            End If

        Else
            MsgBox("Problem: Transation Info NOT SAVE")
        End If

    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'SAVE TRANSACTION:
        SaveTransaction()
    End Sub

    Private Sub rbBUY_CheckedChanged(sender As Object, e As EventArgs) Handles rbBUY.CheckedChanged
        txtTradeType.Text = "BUY PRODUCT"
        rbSELL.Checked = False
    End Sub

    Private Sub rbSELL_CheckedChanged(sender As Object, e As EventArgs) Handles rbSELL.CheckedChanged
        txtTradeType.Text = "SELL PRODUCT"
        rbBUY.Checked = False
    End Sub

    Private Sub TabTransactionControl_Selected(sender As Object, e As TabControlEventArgs) Handles TabTransactionControl.Selected
        Dim TabPageItem As TabPage

        TabPageItem = Me.TabTransactionControl.SelectedTab
        If TabPageItem.Text.ToUpper = "UNIT TRANSACTION" Then
            If rbBUY.Checked Then
                txtTradeType.Text = "BUY PRODUCT"
            Else
                txtTradeType.Text = "SELL PRODUCT"
            End If
        ElseIf TabPageItem.Text.ToUpper = "BLUEPRINT TRANSACTION" Then
            If rbBUY.Checked Then
                txtTradeType.Text = "BUY BLUEPRINT"
            Else
                txtTradeType.Text = "SELL UPGRADE" 'RECEIVE NANITES BACK
            End If
        ElseIf TabPageItem.Text.ToUpper = "QUICKSILVER TRANSACTION" Then
            If rbBUY.Checked Then
                txtTradeType.Text = "BUY QS PRODUCT"
            Else
                txtTradeType.Text = "SELL QS PRODUCT" 'NO FUNCTION IN GAME ??? - UNLESS TRADING WITH ANOTHER PLAYER = but thats giving ???
            End If
        ElseIf TabPageItem.Text.ToUpper = "SALVAGED DATA TRANSACTION" Then
            If rbBUY.Checked Then
                txtTradeType.Text = "UNLOCK SD BLUEPRINT"
            Else
                txtTradeType.Text = "LOCK/SELL SD BLUEPRINT ?"
            End If
        ElseIf TabPageItem.Text.ToUpper = "OTHER BLUEPRINT RECEIVED" Then
            If rbBUY.Checked Then
                txtTradeType.Text = "UNLOCK BLUEPRINT"
            Else
                txtTradeType.Text = "LOCK/SELL BLUEPRINT ?"
            End If
        End If
    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        txtTransactionDate.Text = Now().ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Sub CalculateTotalCost()
        Dim strTotal As String
        Dim intTotal As Integer
        Dim intTotalProfit As Integer
        Dim intNewUnitTotal As Integer
        Dim intUnitsLeft As Integer
        Dim intTotalUnitsAvailable As Integer

        If IsNumeric(txtTotalUnits.Text) Then
            intTotalUnitsAvailable = CInt(txtTotalUnits.Text)
            intUnitsLeft = CInt(txtTotalUnits.Text)
            txtUnitsLeft.Text = CStr(intUnitsLeft)
        Else
            MsgBox("TOTAL UNITS AVAILABLE IS INVALID")
            Exit Sub
        End If
        If IsNumeric(txtQuantity.Text) Then
            If IsNumeric(txtUnitCost.Text) Then
                intTotal = CInt(txtQuantity.Text) * CInt(txtUnitCost.Text)
                strTotal = CStr(intTotal)
                txtUnitsExchanged.Text = strTotal
            Else
                MsgBox("Unit Cost Invalid")
                Exit Sub
            End If
        Else
            MsgBox("Quantity Invalid")
            Exit Sub
        End If
        'UPDATE UNITS:
        If txtTradeType.Text = "SELL PRODUCT" Then
            intUnitsLeft += intTotal
            txtUnitsLeft.Text = CStr(intUnitsLeft)
            txtTotalUnits.Text = CStr(intUnitsLeft)
        ElseIf txtTradeType.Text = "BUY PRODUCT" Then
            intUnitsLeft = intUnitsLeft - intTotal
            txtUnitsLeft.Text = CStr(intUnitsLeft)
            txtTotalUnits.Text = CStr(intUnitsLeft)
        Else
            MsgBox("INVALID TRANSACTION TYPE INITIATED")
            Exit Sub
        End If
    End Sub

    Private Sub txtUnitCost_Leave(sender As Object, e As EventArgs) Handles txtUnitCost.Leave
        CalculateTotalCost()
    End Sub

    Private Sub txtQuantity_Leave(sender As Object, e As EventArgs) Handles txtQuantity.Leave
        CalculateTotalCost()
    End Sub

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAccounts.SelectedIndexChanged
        Dim IDX As Integer
        Dim ItemName As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim FoundAccount As Boolean
        Dim SearchText As String
        Dim SearchField As String
        Dim FieldType As String
        Dim SearchFormat As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim Reversed As Boolean
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim SearchCriteria As String
        Dim DBTable As String = "tblAccounts"
        Dim AllFields() As String
        Dim AllValues() As Object
        Dim ErrMessage As String
        Dim FoundSystem As Boolean

        IDX = lstAccounts.SelectedIndex
        ItemName = lstAccounts.Items.Item(IDX)
        lstSystems.Items.Clear()
        lstPlanets.Items.Clear()
        lstLocations.Items.Clear()
        txtTotalUnits.Text = ""
        txtTotalNanites.Text = ""
        txtTotalQS.Text = ""
        txtTotalFrigateModules.Text = ""
        txtTotalSalvagedDataModules.Text = ""
        SearchText = ItemName
        SearchField = "AccountName"
        FieldType = "STRING"
        SearchFormat = ""
        ReturnField = "AccountID"
        ReturnValue = ""
        Reversed = False
        SortFields = "AccountID"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundAccount = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, SearchFormat, ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)

        If FoundAccount Then
            txtAccountID.Text = ReturnValue
            BuildSystemCombo("", txtAccountID.Text, False)
            GetUnits(txtAccountID.Text)
            txtAccount.Text = ItemName
        Else
            txtAccountID.Text = "0"
            lstAccounts.Items.Clear()
            lstSystems.Items.Clear()
            lstPlanets.Items.Clear()
            lstLocations.Items.Clear()
            txtAccount.Text = ""
        End If


    End Sub

    Private Sub lstSystems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSystems.SelectedIndexChanged
        Dim IDX As Integer
        Dim ItemName As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim FoundSystem As Boolean
        Dim SearchText As String
        Dim SearchField As String
        Dim FieldType As String
        Dim SearchFormat As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim Reversed As Boolean
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim SearchCriteria As String
        Dim DBTable As String = "tblSystems"
        Dim AllFields() As String
        Dim AllValues() As Object
        Dim ErrMessage As String

        IDX = lstSystems.SelectedIndex
        ItemName = lstSystems.Items.Item(IDX)
        lstPlanets.Items.Clear()
        lstLocations.Items.Clear()
        SearchText = ItemName
        If rbOriginalNames.Checked = True Then
            SearchField = "OriginalSystemName"
        ElseIf rbNewNames.Checked = True Then
            SearchField = "RenamedSystemName"
        Else
            MsgBox("SELECT SYSTEM Radiobutton Option")
            Exit Sub
        End If

        FieldType = "STRING"
        SearchFormat = ""
        ReturnField = "SystemID"
        ReturnValue = ""
        Reversed = False
        SortFields = "SystemID"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundSystem = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, SearchFormat, ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)

        If FoundSystem Then
            txtSystemID.Text = ReturnValue
            BuildPlanetCombo("", txtAccountID.Text, txtSystemID.Text, False)
            txtSystem.Text = ItemName
        Else
            txtSystemID.Text = "0"
            lstSystems.Items.Clear()
            lstPlanets.Items.Clear()
            lstLocations.Items.Clear()
            txtSystem.Text = ""
        End If
    End Sub

    Private Sub lstPlanets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPlanets.SelectedIndexChanged
        Dim IDX As Integer
        Dim ItemName As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim FoundPlanet As Boolean
        Dim SearchText As String
        Dim SearchField As String
        Dim FieldType As String
        Dim SearchFormat As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim Reversed As Boolean
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim SearchCriteria As String
        Dim DBTable As String = "tblPlanets"
        Dim AllFields() As String
        Dim AllValues() As Object
        Dim ErrMessage As String

        IDX = lstPlanets.SelectedIndex
        ItemName = lstPlanets.Items.Item(IDX)
        lstLocations.Items.Clear()
        SearchText = ItemName
        If rbOriginalNames.Checked = True Then
            SearchField = "OriginalPlanetName"
        ElseIf rbNewNames.Checked = True Then
            SearchField = "RenamedPlanetName"
        Else
            MsgBox("SELECT Radiobutton Option")
            Exit Sub
        End If

        FieldType = "STRING"
        SearchFormat = ""
        ReturnField = "PlanetID"
        ReturnValue = ""
        Reversed = False
        SortFields = "PlanetID"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundPlanet = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, SearchFormat, ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)

        If FoundPlanet Then
            txtPlanetID.Text = ReturnValue
            BuildLocations("", txtAccountID.Text, txtSystemID.Text, txtPlanetID.Text, False)
            txtPlanet.Text = ItemName
        Else
            txtPlanetID.Text = "0"
            lstPlanets.Items.Clear()
            lstLocations.Items.Clear()
            txtPlanet.Text = ""
        End If
    End Sub

    Private Sub lstLocations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLocations.SelectedIndexChanged
        Dim IDX As Integer
        Dim ItemName As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim FoundPlanet As Boolean
        Dim SearchText As String
        Dim SearchField As String
        Dim FieldType As String
        Dim SearchFormat As String
        Dim ReturnField As String
        Dim ReturnValue As String
        Dim Reversed As Boolean
        Dim SortFields As String
        Dim ExcludeFields As String
        Dim SearchCriteria As String
        Dim DBTable As String = "tblTransactions"
        Dim AllFields() As String
        Dim AllValues() As Object
        Dim ErrMessage As String
        Dim strUnitCost As String

        IDX = lstLocations.SelectedIndex
        ItemName = lstLocations.Items.Item(IDX)
        txtLocation.Text = ItemName
        'Load in UnitCost for terminal if available:
        strUnitCost = DAL.GetUnitCost(frmMain.myConnString, txtUserID.Text, txtAccountID.Text, txtSystemID.Text, txtPlanetID.Text, txtLocation.Text)
        txtUnitCost.Text = strUnitCost
    End Sub

    Private Sub txtNanitesRequired_Leave(sender As Object, e As EventArgs) Handles txtNanitesRequired.Leave
        Dim intTotalNanites As Integer
        Dim intNanitesReq As Integer
        Dim intNanitesLeft As Integer

        If IsNumeric(txtTotalNanites.Text) Then
            intTotalNanites = CInt(txtTotalNanites.Text)
        Else
            intTotalNanites = 0
            MsgBox("INVALID NANITE TOTAL")
            Exit Sub
        End If
        If IsNumeric(txtNanitesAvailable.Text) Then
            intNanitesLeft = CInt(txtNanitesAvailable.Text)
        Else
            intNanitesLeft = 0
            MsgBox("INVALID NANITE AVAILABLE VALUE")
            Exit Sub
        End If
        If IsNumeric(txtNanitesRequired.Text) Then
            intNanitesReq = CInt(txtNanitesRequired.Text)
        Else
            intNanitesReq = 0
            MsgBox("INVALID NANITE REQUIRED VALUE")
            Exit Sub
        End If
        If intTotalNanites >= intTotalNanites - intNanitesReq Then
            intNanitesLeft = intTotalNanites - intNanitesReq
            txtNanitesAvailable.Text = CStr(intNanitesLeft)
            txtTotalNanites.Text = CStr(intNanitesLeft)
            MsgBox("OK TRANSACTION ACCEPTED")
        Else
            MsgBox("NOT ENOUGH NANITES FOR TRANSACTION")
            Exit Sub
        End If

    End Sub

    Private Sub txtQSRequired_Leave(sender As Object, e As EventArgs) Handles txtQSRequired.Leave
        Dim intTotalQuicksilver As Integer
        Dim intQSReq As Integer
        Dim intQSLeft As Integer

        If IsNumeric(txtTotalQS.Text) Then
            intTotalQuicksilver = CInt(txtTotalQS.Text)
        Else
            intTotalQuicksilver = 0
            MsgBox("INVALID QUICKSILVER TOTAL")
            Exit Sub
        End If
        If IsNumeric(txtQSAvailable.Text) Then
            intQSLeft = CInt(txtQSAvailable.Text)
        Else
            intQSLeft = 0
            MsgBox("INVALID QUICKSILVER AVAILABLE VALUE")
            Exit Sub
        End If
        If IsNumeric(txtQSRequired.Text) Then
            intQSReq = CInt(txtQSRequired.Text)
        Else
            intQSReq = 0
            MsgBox("INVALID QUICKSILVER REQUIRED VALUE")
            Exit Sub
        End If
        If intTotalQuicksilver >= intTotalQuicksilver - intQSReq Then
            intQSLeft = intTotalQuicksilver - intQSReq
            txtQSAvailable.Text = CStr(intQSLeft)
            txtTotalQS.Text = CStr(intQSLeft)
            MsgBox("OK TRANSACTION ACCEPTED")
        Else
            MsgBox("NOT ENOUGH QUICKSILVER FOR TRANSACTION")
            Exit Sub
        End If
    End Sub

    Private Sub txtModulesRequired_Leave(sender As Object, e As EventArgs) Handles txtModulesRequired.Leave
        '
    End Sub

    Private Sub txtFrigateModulesRequired_Leave(sender As Object, e As EventArgs) Handles txtFrigateModulesRequired.Leave
        '
    End Sub
End Class