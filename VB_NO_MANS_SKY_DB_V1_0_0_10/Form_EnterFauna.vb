Public Class Form_EnterFauna
    Private _PlanetID As String
    Private _FaunaID As String
    Private _AccountID As String
    Private _TotalFauna As Integer
    Private _IsDefault As Boolean

    Public Property Planet_ID() As String
        Get
            Return _PlanetID
        End Get
        Set(value As String)
            _PlanetID = value
        End Set
    End Property

    Public Property FaunaID() As String
        Get
            Return _FaunaID
        End Get
        Set(value As String)
            _FaunaID = value
        End Set
    End Property

    Public Property TotalFauna() As Integer
        Get
            Return _TotalFauna
        End Get
        Set(value As Integer)
            _TotalFauna = value
        End Set
    End Property

    Public Property Account_ID() As String
        Get
            Return _AccountID
        End Get
        Set(value As String)
            _AccountID = value
        End Set
    End Property

    Public Property IsDefault() As Boolean
        Get
            Return _IsDefault
        End Get
        Set(value As Boolean)
            _IsDefault = value
        End Set
    End Property

    Public Sub PopulateForm()

        Dim strFaunaOriginalName As String
        Dim strFaunaNewName As String
        Dim strFaunaID As String
        Dim strAccountID As String
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strLastUpdated As String
        Dim strNotes As String
        Dim strUserID As String
        Dim strPlanetID As String
        Dim strDefault As String
        Dim strNumRows As String
        Dim intNumRows As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSQL As String
        Dim dt As DataTable
        Dim ImageByte() As Byte
        Dim memStream As System.IO.MemoryStream
        Dim LoadOK As Boolean
        Dim fi As IO.FileInfo
        Dim strImageFilename As String
        Dim strResourceImageExt As String
        Dim Say As String

        strUserID = frmMain.myUserID
        strPlanetID = Me.Planet_ID
        strFaunaID = Me.FaunaID
        strAccountID = Me.Account_ID
        strSQL = "SELECT * FROM tblWaypoints WHERE UserID=" & CInt(strUserID) & " AND WeypointID=" & CInt(strFaunaID) & " AND AccountID=" & CInt(strAccountID)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, intNumRows)

        If intNumRows > 0 Then
            'strResourceID = dt.Rows(0)("ResourceID")
            strAccountID = dt.Rows(0)("AccountID")
            strNumRows = CStr(intNumRows)
            strFaunaOriginalName = dt.Rows(0)("OriginalName")
            strFaunaNewName = dt.Rows(0)("Renamed")
            strDiscoveryDate = dt.Rows(0)("DiscoveryDate")
            strDiscoveredBy = dt.Rows(0)("DiscoveredBy")
            strNotes = dt.Rows(0)("Notes")
            strLastUpdated = dt.Rows(0)("LastUpdated")
            strDefault = dt.Rows(0)("DefaultFauna")
            strImageFilename = dt.Rows(0)("ImageFilename")
            strResourceImageExt = dt.Rows(0)("ImageExt")

            LoadOK = DAL.Get_Pic_From_DB(frmMain.myConnString, "tblFauna", "Image", "FaunaID", strFaunaID, ImageByte)
            If LoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pbFaunaPic.BackgroundImage = Image.FromStream(memStream)
                pbFaunaPic.Tag = strImageFilename
                txtImageFilename.Text = strImageFilename
                txtImageEXT.Text = strResourceImageExt
            End If

            Me.txtPlanetID.Text = strPlanetID
            Me.txtFaunaID.Text = strFaunaID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = strNumRows
            Me.txtFaunaOriginalName.Text = strFaunaOriginalName
            Me.txtFaunaNewName.Text = strFaunaNewName
            Me.txtDiscoveryDate.Text = strDiscoveryDate
            Me.txtDiscoveredBy.Text = strDiscoveredBy
            Me.txtNotes.Text = strNotes
            Me.txtDefault.Text = strDefault
            Me.txtLastUpdated.Text = strLastUpdated
        Else
            Me.txtPlanetID.Text = strPlanetID
            Me.txtFaunaID.Text = strFaunaID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = CStr(Me.TotalFauna)
            Me.txtFaunaOriginalName.Text = ""
            Me.txtFaunaNewName.Text = ""
            Me.txtDiscoveryDate.Text = ""
            Me.txtDiscoveredBy.Text = ""
            Me.txtNotes.Text = ""
            Me.txtDefault.Text = ""
        End If

    End Sub

    Public Sub SaveFauna(Optional SetDefault As Boolean = False)
        Dim strFaunaOriginalName As String
        Dim strFaunaNewName As String
        Dim strFaunaID As String
        Dim strAccountID As String
        Dim strPlanetID As String
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strLastUpdated As String
        Dim strNotes As String
        Dim strUserID As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblFauna"
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
        Dim FoundFauna As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim strDefaultFauna As String
        Dim ResetOK As Boolean = False
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim arrImage() As Byte
        Dim memStream As New System.IO.MemoryStream
        Dim NewIDValue As String
        Dim strImageFilename As String
        Dim strImageExtension As String
        Dim fi As IO.FileInfo
        Dim dt As DataTable
        Dim TotalFauna As Integer
        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.

        'PUT INTO DAL

        dtCurrentDate = Now()
        strDiscoveryDate = CDate("01/01/1970 01:00")
        If Len(txtDiscoveryDate.Text) = 0 Then
            txtDiscoveryDate.Text = dtCurrentDate.ToString("dd/MM/yyyy HH:mm:ss")
            strDiscoveryDate = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            If IsDate(txtDiscoveryDate.Text) Then
                strDiscoveryDate = CDate(txtDiscoveryDate.Text).ToString("yyyy-MM-dd HH:mm:ss")
            End If
        End If
        ErrMessages = ""
        strUserID = frmMain.myUserID
        strFaunaID = txtFaunaID.Text
        strLastUpdated = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strFaunaNewName = txtFaunaNewName.Text
        strFaunaOriginalName = txtFaunaOriginalName.Text
        strAccountID = txtAccountID.Text
        strPlanetID = txtPlanetID.Text
        strDiscoveredBy = txtDiscoveredBy.Text
        strNotes = txtNotes.Text
        strDefaultFauna = txtDefault.Text

        strImageFilename = pbFaunaPic.Tag
        If Len(strImageFilename) > 0 Then
            fi = New IO.FileInfo(strImageFilename)
            strImageExtension = fi.Extension
        End If

        If SetDefault = True Or UCase(txtDefault.Text) = "DEFAULT" Then
            ResetOK = DAL.UpdateALL(frmMain.myConnString, DBTable, "DefaultFauna")
            If ResetOK = False Then
                MsgBox("Could not reset Default field")
                Exit Sub
            End If
            strDefaultFauna = "DEFAULT"
        Else
            'DefaultAccount = ""
        End If

        FieldNames = "UserID"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",PlanetID"
        FieldNames = FieldNames & ",OriginalName"
        FieldNames = FieldNames & ",Renamed"
        FieldNames = FieldNames & ",DiscoveryDate"
        FieldNames = FieldNames & ",DiscoveredBy"
        FieldNames = FieldNames & ",Notes"
        FieldNames = FieldNames & ",DefaultFauna"
        FieldNames = FieldNames & ",LastUpdated"
        FieldNames = FieldNames & ",ImageFilename"
        FieldNames = FieldNames & ",ImageExt"

        FieldValues = strUserID
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strPlanetID
        FieldValues = FieldValues & "," & strFaunaOriginalName
        FieldValues = FieldValues & "," & strFaunaNewName
        FieldValues = FieldValues & "," & strDiscoveryDate
        FieldValues = FieldValues & "," & strDiscoveredBy
        FieldValues = FieldValues & "," & strNotes
        FieldValues = FieldValues & "," & strDefaultFauna
        FieldValues = FieldValues & "," & strLastUpdated
        FieldValues = FieldValues & "," & strImageFilename
        FieldValues = FieldValues & "," & strImageExtension

        SearchText = strFaunaNewName
        SearchField = "Renamed"
        ReturnField = "FaunaID"
        ReturnValue = ""
        FieldType = "STRING"
        Reversed = True
        SortFields = "FaunaID"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundFauna = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundFauna Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("FAUNA Already EXISTS - Proceed with update?", vbYesNo, "FAUNA ALREADY EXISTS")
            If Answer = vbYes Then
                If FieldType = "INTEGER" And IsNumeric(SearchText) Then
                    UpdateCriteria = SearchField & "=" & SearchText
                End If
                If FieldType = "STRING" Then
                    UpdateCriteria = SearchField & "=" & "'" & SearchText & "'"
                End If
                UpdateCriteria = "FaunaID=" & CInt(ReturnValue)
                SavedOK = DAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                            ",", ";")
                If SavedOK Then
                    frmPlanetEntry_v2.IsUpdated = 2
                End If
                NewIDValue = ReturnValue
            End If
        Else
            'Create NEW ENTRY:
            UpdateCriteria = ""
            SavedOK = DAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, False, "",
                DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                            ",", ";")
            If SavedOK Then
                frmPlanetEntry_v2.IsUpdated = 1
            End If
            NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblFauna", "FaunaID")
        End If
        If SavedOK Then
            MsgBox("OK FAUNA Info Updated.")
            If strFaunaID <> "" And IsNumeric(strFaunaID) Then
                dt = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblFauna WHERE PlanetID=" & CInt(strPlanetID), TotalFauna)
                DAL.UpdateALL(frmMain.myConnString, "tblPlanets", "TotalFauna", CStr(TotalFauna), "PlanetID=" & CInt(strPlanetID))
            End If
        Else
            MsgBox("Problem: FAUNA Info NOT SAVE")
        End If

        If strImageExtension IsNot Nothing Then
            If UCase(strImageExtension) = ".BMP" Then
                pbFaunaPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImageExtension) = ".JPG" Then
                pbFaunaPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImageExtension) = ".PNG" Then
                pbFaunaPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImageExtension) = ".GIF" Then
                pbFaunaPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                MsgBox("UNKNOWN IMAGE FORMAT")
                Exit Sub
            End If
            arrImage = memStream.GetBuffer()
            'NEED TO PASS THE NEW RESOURCE ID HERE: Max(ResourceID) perhaps ???

            If DAL.UpdateTableWithImage(frmMain.myConnString, "tblFauna", "FaunaID", NewIDValue, "Image", memStream, arrImage, "ImageSize") Then
                MsgBox("OK PICTURE SAVED")
            Else
                MsgBox("PICTURE NOT SAVED")
            End If
        End If
    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        txtDiscoveryDate.Text = Now().ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        SaveFauna(IsDefault)
    End Sub

    Private Sub Form_EnterFauna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load last time this record was updated from DB field:
        If Me.IsDefault = True Then
            Me.txtDefault.Text = "DEFAULT"
        Else
            Me.txtDefault.Text = ""
        End If
        PopulateForm()
    End Sub

    Private Sub btnImportPicture_Click(sender As Object, e As EventArgs) Handles btnImportPicture.Click
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pbFaunaPic.BackgroundImage = Image.FromFile(dlg.FileName)
            txtImageFilename.Text = dlg.FileName
            pbFaunaPic.Tag = dlg.FileName
        End If
    End Sub
End Class