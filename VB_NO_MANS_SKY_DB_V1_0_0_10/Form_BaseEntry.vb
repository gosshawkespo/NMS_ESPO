Public Class frmBaseEntry
    Private _PlanetID As String
    Private _BaseID As String
    Private _AccountID As String
    Private _TotalBases As Integer
    Private _IsDefault As Boolean

    Public Property Planet_ID() As String
        Get
            Return _PlanetID
        End Get
        Set(value As String)
            _PlanetID = value
        End Set
    End Property

    Public Property Base_ID() As String
        Get
            Return _BaseID
        End Get
        Set(value As String)
            _BaseID = value
        End Set
    End Property

    Public Property TotalBases() As Integer
        Get
            Return _TotalBases
        End Get
        Set(value As Integer)
            _TotalBases = value
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

        Dim strBaseID As String
        Dim strAccountID As String
        Dim strUserID As String
        Dim strPlanetID As String
        Dim strOriginalBaseName As String
        Dim strNewBaseName As String
        Dim strMaterialsUsed As String
        Dim strBaseSize As String
        Dim strPowerSupply As String
        Dim strPowerUsage As String
        Dim strBaseLongCoords As String
        Dim strBaseLatCoords As String
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strLastUpdated As String
        Dim strBaseDescription As String
        Dim strNotes As String
        Dim strDefault As String
        Dim strNumRows As String
        Dim intNumRows As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSQL As String
        Dim dt As DataTable
        Dim ImageByte() As Byte
        Dim memStream As System.IO.MemoryStream
        Dim LoadOK As Boolean
        Dim LoadOK2 As Boolean
        Dim fi As IO.FileInfo
        Dim strImageFilename As String
        Dim strImageExt As String
        Dim strImageSize As String
        Dim dblImageSizeKilobytes As Double
        Dim strImage2Filename As String
        Dim strImage2Ext As String
        Dim strImage2Size As String
        Dim dblImage2SizeKilobytes As Double
        Dim Say As String

        strUserID = frmMain.myUserID
        strPlanetID = Me.Planet_ID
        strBaseID = Me.Base_ID
        strAccountID = Me.Account_ID
        strSQL = "SELECT * FROM tblBases WHERE UserID=" & CInt(strUserID) & " AND BaseID=" & CInt(strBaseID) & " AND AccountID=" & CInt(strAccountID)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, intNumRows)

        If intNumRows > 0 Then
            'strResourceID = dt.Rows(0)("ResourceID")
            strAccountID = dt.Rows(0)("AccountID")
            strNumRows = CStr(intNumRows)
            strOriginalBaseName = dt.Rows(0)("OriginalBaseName")
            strNewBaseName = dt.Rows(0)("RenamedBaseName")
            strMaterialsUsed = dt.Rows(0)("MaterialsUsed")
            strBaseSize = dt.Rows(0)("BaseSize")
            strPowerSupply = dt.Rows(0)("BasePowerSupply")
            strPowerUsage = dt.Rows(0)("BasePowerUsage")
            strBaseLongCoords = dt.Rows(0)("BaseLongitude")
            strBaseLatCoords = dt.Rows(0)("BaseLatitude")
            strDiscoveryDate = dt.Rows(0)("DiscoveryDate")
            strDiscoveredBy = dt.Rows(0)("DiscoveredBy")
            strBaseDescription = dt.Rows(0)("BaseDescription")
            strNotes = dt.Rows(0)("Comments")
            strLastUpdated = dt.Rows(0)("LastUpdated")
            strDefault = dt.Rows(0)("DefaultBase")
            strImageFilename = dt.Rows(0)("ImageFilename")
            strImageExt = dt.Rows(0)("ImageExt")
            strImageSize = dt.Rows(0)("ImageSize")
            strImage2Filename = dt.Rows(0)("Image2Filename")
            strImage2Ext = dt.Rows(0)("Image2Ext")
            strImage2Size = dt.Rows(0)("Image2Size")

            LoadOK = DAL.Get_Pic_From_DB(frmMain.myConnString, "tblBases", "Image", "BaseID", strBaseID, ImageByte)
            If LoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pbBasePic1.BackgroundImage = Image.FromStream(memStream)
                dblImageSizeKilobytes = memStream.Length / 1024
                pbBasePic1.Tag = strImageFilename
                txtImageFilename.Text = strImageFilename
                txtImageEXT.Text = strImageExt
                txtImageSizeKilobytes.Text = CStr(dblImageSizeKilobytes)
                txtImageSizeBytes.Text = strImageSize

            End If
            LoadOK2 = DAL.Get_Pic_From_DB(frmMain.myConnString, "tblBases", "Image2", "BaseID", strBaseID, ImageByte)
            If LoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pbBasePic2.BackgroundImage = Image.FromStream(memStream)
                dblImage2SizeKilobytes = memStream.Length / 1024
                pbBasePic2.Tag = strImage2Filename
                txtImage2Filename.Text = strImage2Filename
                txtImage2Ext.Text = strImage2Ext
                txtImage2SizeKilobytes.Text = CStr(dblImage2SizeKilobytes)
                txtImage2SizeBytes.Text = strImage2Size
            End If
            Me.txtBaseID.Text = strBaseID
            Me.txtPlanetID.Text = strPlanetID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = strNumRows
            Me.txtLastUpdated.Text = strLastUpdated
            Me.txtOriginalBaseName.Text = strOriginalBaseName
            Me.txtNewBaseName.Text = strNewBaseName
            Me.txtBaseLongitude.Text = strBaseLongCoords
            Me.txtBaseLatitude.Text = strBaseLatCoords
            Me.txtDiscoveryDate.Text = strDiscoveryDate
            Me.txtDiscoveredBy.Text = strDiscoveredBy
            Me.txtDefault.Text = strDefault
            Me.txtPowerToBase.Text = strPowerSupply
            Me.txtPowerUsed.Text = strPowerUsage
            Me.txtBaseSize.Text = strBaseSize
            Me.txtBaseDescription.Text = strBaseDescription
            Me.txtNotes.Text = strNotes
        Else
            Me.txtBaseID.Text = strBaseID
            Me.txtPlanetID.Text = strPlanetID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = CStr(Me.TotalBases)
            Me.txtLastUpdated.Text = Now().ToString("dd/MM/yyyy hh:mm:ss")
            Me.txtOriginalBaseName.Text = ""
            Me.txtNewBaseName.Text = ""
            Me.txtBaseLongitude.Text = ""
            Me.txtBaseLatitude.Text = ""
            Me.txtDiscoveryDate.Text = ""
            Me.txtDiscoveredBy.Text = ""
            Me.txtDefault.Text = ""
            Me.txtPowerToBase.Text = "0"
            Me.txtPowerUsed.Text = "0"
            Me.txtBaseSize.Text = ""
            Me.txtBaseDescription.Text = ""
            Me.txtNotes.Text = ""
            Me.txtImageFilename.Text = ""
            Me.txtImageEXT.Text = ""
            Me.txtImageSizeBytes.Text = ""
            Me.txtImageSizeKilobytes.Text = ""
            Me.txtImage2Filename.Text = ""
            Me.txtImage2Ext.Text = ""
            Me.txtImage2SizeBytes.Text = ""
            Me.txtImage2SizeKilobytes.Text = ""
        End If

    End Sub

    Public Sub SaveBase(Optional SetDefault As Boolean = False)
        Dim strBaseID As String
        Dim strAccountID As String
        Dim strUserID As String
        Dim strPlanetID As String
        Dim strOriginalBaseName As String
        Dim strNewBaseName As String
        Dim strMaterialsUsed As String
        Dim strBaseSize As String
        Dim strPowerSupply As String
        Dim strPowerUsage As String
        Dim strBaseLongCoords As String
        Dim strBaseLatCoords As String
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strLastUpdated As String
        Dim strBaseDescription As String
        Dim strNotes As String
        Dim strNumRows As String
        Dim intNumRows As Integer
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim strSQL As String
        Dim dt As DataTable
        Dim arrImage() As Byte
        Dim memStream As System.IO.MemoryStream
        Dim SavedOK As Boolean
        Dim SavedOK2 As Boolean
        Dim fi As IO.FileInfo
        Dim strImageFilename As String
        Dim strImageExt As String
        Dim strImageSize As String
        Dim dblImageSizeKilobytes As Double
        Dim strImage2Filename As String
        Dim strImage2Ext As String
        Dim strImage2Size As String
        Dim dblImage2SizeKilobytes As Double

        Dim FieldNames As String
        Dim FieldValues As String
        Dim DBTable As String = "tblBases"
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
        Dim FoundBase As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim strDefaultBase As String
        Dim ResetOK As Boolean = False
        Dim NewIDValue As String
        Dim dtBases As DataTable
        Dim TotalBases As Integer
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
        strBaseID = txtBaseID.Text
        strLastUpdated = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strOriginalBaseName = txtOriginalBaseName.Text
        strNewBaseName = txtNewBaseName.Text
        strAccountID = txtAccountID.Text
        strPlanetID = txtPlanetID.Text
        strBaseLongCoords = Trim(Replace(txtBaseLongitude.Text, " ", ""))
        strBaseLatCoords = Trim(Replace(txtBaseLatitude.Text, " ", ""))
        strDiscoveredBy = txtDiscoveredBy.Text
        strMaterialsUsed = ""
        strBaseSize = txtBaseSize.Text
        strPowerSupply = txtPowerToBase.Text
        strPowerUsage = txtPowerUsed.Text
        strBaseDescription = txtBaseDescription.Text
        strNotes = txtNotes.Text
        strImageFilename = pbBasePic1.Tag
        If Len(strImageFilename) > 0 Then
            fi = New IO.FileInfo(strImageFilename)
            strImageExt = fi.Extension
            strImageSize = txtImageSizeBytes.Text
        End If
        strImage2Filename = pbBasePic1.Tag
        If Len(strImage2Filename) > 0 Then
            fi = New IO.FileInfo(strImage2Filename)
            strImage2Ext = fi.Extension
            strImage2Size = txtImage2SizeBytes.Text
        End If

        If SetDefault = True Or UCase(txtDefault.Text) = "DEFAULT" Then
            ResetOK = DAL.UpdateALL(frmMain.myConnString, DBTable, "DefaultBase")
            If ResetOK = False Then
                MsgBox("Could not reset Default field")
                Exit Sub
            End If
            strDefaultBase = "DEFAULT"
        Else
            'DefaultAccount = ""
        End If

        FieldNames = "UserID"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",PlanetID"
        FieldNames = FieldNames & ",OriginalBaseName"
        FieldNames = FieldNames & ",RenamedBaseName"
        FieldNames = FieldNames & ",MaterialsUsed"
        FieldNames = FieldNames & ",BaseSize"
        FieldNames = FieldNames & ",BasePowerSupply"
        FieldNames = FieldNames & ",BasePowerUsage"
        FieldNames = FieldNames & ",BaseLongitude"
        FieldNames = FieldNames & ",BaseLatitude"
        FieldNames = FieldNames & ",DiscoveryDate"
        FieldNames = FieldNames & ",DiscoveredBy"
        FieldNames = FieldNames & ",BaseDescription"
        FieldNames = FieldNames & ",Comments"
        FieldNames = FieldNames & ",DefaultBase"
        FieldNames = FieldNames & ",LastUpdated"
        FieldNames = FieldNames & ",ImageFilename"
        FieldNames = FieldNames & ",ImageExt"
        FieldNames = FieldNames & ",ImageSize"
        FieldNames = FieldNames & ",Image2Filename"
        FieldNames = FieldNames & ",Image2Ext"
        FieldNames = FieldNames & ",Image2Size"

        FieldValues = strUserID
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strPlanetID
        FieldValues = FieldValues & "," & strOriginalBaseName
        FieldValues = FieldValues & "," & strNewBaseName
        FieldValues = FieldValues & "," & strMaterialsUsed
        FieldValues = FieldValues & "," & strBaseSize
        FieldValues = FieldValues & "," & strPowerSupply
        FieldValues = FieldValues & "," & strPowerUsage
        FieldValues = FieldValues & "," & strBaseLongCoords
        FieldValues = FieldValues & "," & strBaseLatCoords
        FieldValues = FieldValues & "," & strDiscoveryDate
        FieldValues = FieldValues & "," & strDiscoveredBy
        FieldValues = FieldValues & "," & strBaseDescription
        FieldValues = FieldValues & "," & strNotes
        FieldValues = FieldValues & "," & strDefaultBase
        FieldValues = FieldValues & "," & strLastUpdated
        FieldValues = FieldValues & "," & strImageFilename
        FieldValues = FieldValues & "," & strImageExt
        FieldValues = FieldValues & "," & strImageSize
        FieldValues = FieldValues & "," & strImage2Filename
        FieldValues = FieldValues & "," & strImage2Ext
        FieldValues = FieldValues & "," & strImage2Size

        SearchText = strOriginalBaseName
        SearchField = "OriginalBaseName"
        ReturnField = "BaseID"
        ReturnValue = ""
        FieldType = "STRING"
        Reversed = True
        SortFields = "OriginalBaseName"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundBase = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundBase Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Base Already EXISTS - Proceed with update?", vbYesNo, "BASE ALREADY EXISTS")
            If Answer = vbYes Then
                If FieldType = "INTEGER" And IsNumeric(SearchText) Then
                    UpdateCriteria = SearchField & "=" & SearchText
                End If
                If FieldType = "STRING" Then
                    UpdateCriteria = SearchField & "=" & "'" & SearchText & "'"
                End If
                UpdateCriteria = "BaseID=" & CInt(ReturnValue)
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
            NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblBases", "BaseID")
        End If
        If SavedOK Then
            MsgBox("OK BASE Info Updated.")
            If Planet_ID <> "" And IsNumeric(Planet_ID) Then
                dtBases = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblBases WHERE PlanetID=" & CInt(Planet_ID), TotalBases)
                DAL.UpdateALL(frmMain.myConnString, "tblPlanets", "TotalBases", CStr(TotalBases), "PlanetID=" & CInt(Planet_ID))
            End If
        Else
            MsgBox("Problem: BASE Info NOT SAVE")
        End If

        If strImageExt IsNot Nothing Then
            If UCase(strImageExt) = ".BMP" Then
                pbBasePic1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImageExt) = ".JPG" Then
                pbBasePic1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImageExt) = ".PNG" Then
                pbBasePic1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImageExt) = ".GIF" Then
                pbBasePic1.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                MsgBox("UNKNOWN IMAGE 1 FORMAT")
                Exit Sub
            End If
            arrImage = memStream.GetBuffer()
            'NEED TO PASS THE NEW RESOURCE ID HERE: Max(ResourceID) perhaps ???

            If DAL.UpdateTableWithImage(frmMain.myConnString, "tblBases", "BaseID", NewIDValue, "Image", memStream, arrImage, "ImageSize") Then
                MsgBox("OK PICTURE 1 SAVED")
            Else
                MsgBox("PICTURE 1 NOT SAVED")
            End If
        End If

        If strImage2Ext IsNot Nothing Then
            If UCase(strImage2Ext) = ".BMP" Then
                pbBasePic2.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImage2Ext) = ".JPG" Then
                pbBasePic2.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImage2Ext) = ".PNG" Then
                pbBasePic2.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImage2Ext) = ".GIF" Then
                pbBasePic2.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                MsgBox("UNKNOWN IMAGE 2 FORMAT")
                Exit Sub
            End If
            arrImage = memStream.GetBuffer()
            'NEED TO PASS THE NEW RESOURCE ID HERE: Max(ResourceID) perhaps ???

            If DAL.UpdateTableWithImage(frmMain.myConnString, "tblBases", "BaseID", NewIDValue, "Image2", memStream, arrImage, "Image2Size") Then
                MsgBox("OK PICTURE 2 SAVED")
            Else
                MsgBox("PICTURE 2 NOT SAVED")
            End If
        End If
    End Sub

    Private Sub btnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click
        'ADD PART - save to tblSavedBaseParts

    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        '
        SaveBase()

    End Sub

    Private Sub btnImportPicture_Click(sender As Object, e As EventArgs) Handles btnImportPicture.Click
        '
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pbBasePic1.BackgroundImage = Image.FromFile(dlg.FileName)
            txtImageFilename.Text = dlg.FileName
            pbBasePic1.Tag = dlg.FileName
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '
        Me.Close()

    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        txtDiscoveryDate.Text = Now().ToString("dd/MM/yyyy HH:mm:ss")

    End Sub

    Private Sub btnRemovePart_Click(sender As Object, e As EventArgs) Handles btnRemovePart.Click
        '
    End Sub

    Private Sub btnImportPicture2_Click(sender As Object, e As EventArgs) Handles btnImportPicture2.Click
        '
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pbBasePic2.BackgroundImage = Image.FromFile(dlg.FileName)
            txtImageFilename.Text = dlg.FileName
            pbBasePic2.Tag = dlg.FileName
        End If
    End Sub

    Private Sub frmBaseEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.IsDefault = True Then
            Me.txtDefault.Text = "DEFAULT"
        Else
            Me.txtDefault.Text = ""
        End If
        PopulateForm()
    End Sub

    Private Sub txtBaseLongitude_Leave(sender As Object, e As EventArgs) Handles txtBaseLongitude.Leave
        'NORTH / SOUTH COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtBaseLongitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtBaseLongitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtBaseLongitude.Text = strNewValue
        End If
    End Sub

    Private Sub txtBaseLatitude_Leave(sender As Object, e As EventArgs) Handles txtBaseLatitude.Leave
        'EAST / WEST COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtBaseLatitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtBaseLatitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtBaseLatitude.Text = strNewValue
        End If
    End Sub
End Class