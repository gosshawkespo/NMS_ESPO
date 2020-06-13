Public Class frmAccounts
    Private Sub rbPC_CheckedChanged(sender As Object, e As EventArgs) Handles rbPC.CheckedChanged
        Me.txtPlatform.Text = "PC"
    End Sub

    Private Sub rbPS4_CheckedChanged(sender As Object, e As EventArgs) Handles rbPS4.CheckedChanged
        Me.txtPlatform.Text = "PS4"
    End Sub

    Private Sub rXBOX_CheckedChanged(sender As Object, e As EventArgs) Handles rXBOX.CheckedChanged
        Me.txtPlatform.Text = "XBOX"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'SAVE DETAILS:
        SaveDetails()

    End Sub

    Sub SaveDetails(Optional SetDefault As Boolean = False)
        Dim strAccountName As String
        Dim strPlatform As String
        Dim strVersion As String
        Dim strSubmitTime As String
        Dim strComments As String
        Dim strUserID As String
        Dim strGamerHandle As String
        Dim strAccountID As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblAccounts"
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
        Dim FoundAccount As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim DefaultAccount As String
        Dim ResetOK As Boolean = False
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim REsult As Integer

        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.
        dtCurrentDate = Now()
        ErrMessages = ""
        strSubmitTime = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strAccountName = Me.txtAccountName.Text
        strPlatform = Me.txtPlatform.Text
        strVersion = Me.txtVersion.Text
        strComments = Me.txtComment.Text
        strUserID = frmMain.myUserID
        strAccountID = Me.txtAccountID.Text
        strGamerHandle = Me.txtGameHandle.Text
        DefaultAccount = Me.txtDefault.Text

        If SetDefault = True Then
            ResetOK = myDAL.UpdateALL(frmMain.myConnString, DBTable, "DefaultAccount")
            If ResetOK = False Then
                MsgBox("Could not reset Default field")
                Exit Sub
            End If
            DefaultAccount = "DEFAULT"
        Else
            'DefaultAccount = ""
        End If
        UpdateCriteria = ""
        REsult = myDAL.UpdateAccount(frmMain.myConnString, strAccountID, strAccountName, strPlatform, strVersion, strSubmitTime, strComments, DefaultAccount, strUserID,
                                strGamerHandle, UpdateCriteria)

        If REsult = 1 Then
            MsgBox("OK Account Info UPDATED")
            RefreshGrid()
        ElseIf REsult = 2 Then
            MsgBox("Account Info INSERTED")
            RefreshGrid()
        Else
            MsgBox("Problem : UPDATE FAILED")

        End If
        myDAL = Nothing
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close form
        Me.Close()
    End Sub

    Sub RefreshGrid()
        Dim Tablename As String
        Dim SQLstr As String
        Dim NumRows As Long
        Dim Messages As String
        Dim dt As New DataTable
        Dim dal As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Tablename = "tblAccounts"
        SQLstr = "SELECT * FROM " & Tablename & " WHERE UserID=" & CInt(frmMain.myUserID)
        dt = dal.GetDataTable(frmMain.myConnString, SQLstr, NumRows)
        dt.Select()
        dgvAccounts.DataSource = dt
        'Module_DanG_MySQL_Tools.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, SQLstr, NumRows, Messages)
        dgvAccounts.DataSource = dt
        Me.txtNumRows.Text = CStr(NumRows)
        dal = Nothing
        dt = Nothing
    End Sub

    Private Sub frmAccounts_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Load dgvAccounts:
        RefreshGrid()
        Me.txtUserID.Text = frmMain.myUserID
        Me.txtPlatform.Focus()


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
        Dim ErrMessage As String
        Dim strAccountID As String
        Dim AccountName As String
        Dim rowIDX As Integer
        Dim strComments As String
        Dim strGameVersion As String
        Dim strPlatform As String
        Dim strDefault As String
        Dim strUserID As String
        Dim strGamerHandle As String
        Dim strAccountCreated As String
        Dim strLastUpdated As String
        Dim strSQL As String
        Dim dt As DataTable
        Dim NumRows As Integer = 0
        Dim TotalRows As Integer = 0
        Dim ErrMessages As String = ""
        Dim myDAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        If CellSelected.RowIndex > -1 Then
            rowIDX = CellSelected.RowIndex
        Else
            rowIDX = 0
        End If
        DBTable = "tblAccounts"
        strSQL = "SELECT * FROM " & DBTable & " WHERE UserID=" & CInt(frmMain.myUserID)
        myDAL.PopulateMyDataSource(dgvAccounts.DataSource, frmMain.myConnString, strSQL, NumRows, ErrMessages, dt)
        Me.txtNumRows.Text = CStr(NumRows)
        TotalRows = dt.Rows.Count
        If rowIDX > TotalRows Then
            MsgBox("Out of range, select different row")
            Exit Sub
        End If
        'strRegisterID = Me.dgvAssetRegistry.Item(0, Me.dgvAssetRegistry.CurrentCell.RowIndex).Value.ToString
        'strAccountID = Me.dgvAccounts.Item(1, rowIDX).Value.ToString
        strAccountID = dt.Rows(rowIDX)("AccountID").ToString
        AccountName = dt.Rows(rowIDX)("AccountName").ToString
        strPlatform = dt.Rows(rowIDX)("GamePlatform").ToString
        strGameVersion = dt.Rows(rowIDX)("GameVersion").ToString
        strComments = dt.Rows(rowIDX)("Comments").ToString
        strUserID = dt.Rows(rowIDX)("UserID").ToString
        strDefault = dt.Rows(rowIDX)("DefaultAccount").ToString
        strGamerHandle = dt.Rows(rowIDX)("GamerHandle").ToString
        strAccountCreated = dt.Rows(rowIDX)("DateCreated").ToString
        strLastUpdated = dt.Rows(rowIDX)("DateSubmitted").ToString
        If Len(strAccountID) = 0 Then
            strAccountID = "0"
        End If
        'AccountName = dgvAccounts.Item(2, rowIDX).Value.ToString

        SearchText = strAccountID
        SearchField = "AccountID"
        ReturnField = "AccountID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "AccountName"
        ExcludeFields = ""
        DBTable = "tblAccounts"
        'FoundAccount = Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, ReturnField, ReturnValue, AllValues,
        'AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        'If FoundAccount Then
        ''Populate text boxes:
        'strPlatform = GetValuebyFieldname(AllValues, AllFields, "GameVersion")
        'strGameVersion = GetValuebyFieldname(AllValues, AllFields, "GamePlatform")
        'strComments = GetValuebyFieldname(AllValues, AllFields, "Comments")
        'strDefault = GetValuebyFieldname(AllValues, AllFields, "DefaultAccount")
        'strUserID = GetValuebyFieldname(AllValues, AllFields, "UserID")
        Me.txtAccountName.Text = AccountName
        Me.txtPlatform.Text = strPlatform
        Me.txtVersion.Text = strGameVersion
        Me.txtComment.Text = strComments
        Me.txtDefault.Text = strDefault
        Me.txtUserID.Text = strUserID
        Me.txtAccountID.Text = strAccountID
        Me.txtGameHandle.Text = strGamerHandle
        Me.txtAccountCreated.Text = strAccountCreated
        Me.txtLastUpdated.Text = strLastUpdated
        dgvAccounts.Rows(rowIDX).Selected = True

    End Sub

    Private Sub dgvAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellClick
        'User selected a cell or row:
        'GET some unique field and find the corresponding record:
        SelectedCell(e)

        'End If
    End Sub

    Private Sub btnSetDefault_Click(sender As Object, e As EventArgs) Handles btnSetDefault.Click
        'Initialise all records - by blanking out the DEFAULT field for all records.
        'Set current record with "Default" in the DEFAULT field.
        SaveDetails(True)
        RefreshGrid()

    End Sub

    Private Sub frmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        If clsDG_NMS_Controls.ThemeSelection = 0 Then
            Me.BackColor = Color.LightGray
            dgvAccounts.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(245, 255, 245))
            dgvAccounts.DefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(235, 255, 235)) 'LIGHT GREEN
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Else
            Me.BackColor = Color.Gray
            dgvAccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray
            dgvAccounts.DefaultCellStyle.BackColor = ColorTranslator.FromWin32(RGB(235, 255, 235)) 'LIGHT GREEN
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If
    End Sub

    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellContentClick
        SelectedCell(e)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.txtAccountID.Text = ""
        Me.txtAccountName.Text = ""
        Me.txtPlatform.Text = ""
        Me.txtVersion.Text = ""
        Me.txtDefault.Text = ""
        'Me.txtNumRows.Text = ""
        Me.txtComment.Text = ""
        Me.txtUserID.Text = frmMain.myUserID
        Me.txtAccountCreated.Text = Now().ToString("dd/MM/yyyy HH:mm:ss")
        Me.txtPlatform.Focus()

    End Sub
End Class