Public Class frmStructureEntry
    Private _PlanetID As String
    Private _StructureID As String
    Private _AccountID As String
    Private _TotalStructures As Integer
    Private _IsDefault As Boolean

    Public Property Planet_ID() As String
        Get
            Return _PlanetID
        End Get
        Set(value As String)
            _PlanetID = value
        End Set
    End Property

    Public Property Structure_ID() As String
        Get
            Return _StructureID
        End Get
        Set(value As String)
            _StructureID = value
        End Set
    End Property

    Public Property TotalStructures() As Integer
        Get
            Return _TotalStructures
        End Get
        Set(value As Integer)
            _TotalStructures = value
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

        Dim strStructureName As String
        Dim strStructureID As String
        Dim strAccountID As String
        Dim strStructureLongCoords As String
        Dim strStructureLatCoords As String
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
        Dim strImageExt As String
        Dim strImageSize As String
        Dim dblImageSizeKilobytes As Double
        Dim Say As String

        strUserID = frmMain.myUserID
        strPlanetID = Me.Planet_ID
        strStructureID = Me.Structure_ID
        strAccountID = Me.Account_ID
        strSQL = "SELECT * FROM tblStructures WHERE UserID=" & CInt(strUserID) & " AND StructureID=" & CInt(strStructureID) & " AND AccountID=" & CInt(strAccountID)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, intNumRows)

        If intNumRows > 0 Then
            'strResourceID = dt.Rows(0)("ResourceID")
            strAccountID = dt.Rows(0)("AccountID")
            strNumRows = CStr(intNumRows)
            strStructureName = dt.Rows(0)("StructureName")
            strStructureLongCoords = dt.Rows(0)("StructureLongCoords")
            strStructureLatCoords = dt.Rows(0)("StructureLatCoords")
            strDiscoveryDate = dt.Rows(0)("DiscoveryDate")
            strDiscoveredBy = dt.Rows(0)("DiscoveredBy")
            strNotes = dt.Rows(0)("Notes")
            strLastUpdated = dt.Rows(0)("LastUpdated")
            strDefault = dt.Rows(0)("DefaultWaypoint")
            strImageFilename = dt.Rows(0)("ImageFilename")
            strImageExt = dt.Rows(0)("ImageExt")
            strImageSize = dt.Rows(0)("ImageSize")

            LoadOK = DAL.Get_Pic_From_DB(frmMain.myConnString, "tblStructures", "Image", "StructureID", strStructureID, ImageByte)
            If LoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pbStructurePic.BackgroundImage = Image.FromStream(memStream)
                dblImageSizeKilobytes = memStream.Length / 1024
                txtImageSizeKilobytes.Text = CStr(dblImageSizeKilobytes)
                txtImageSizeBytes.Text = strImageSize
                pbStructurePic.Tag = strImageFilename
                txtImageFilename.Text = strImageFilename
                txtImageEXT.Text = strImageExt
            End If

            Me.txtPlanetID.Text = strPlanetID
            Me.txtStructureID.Text = strStructureID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = strNumRows
            Me.txtStructureName.Text = strStructureName
            Me.txtStructureLongitude.Text = strStructureLongCoords
            Me.txtStructureLatitude.Text = strStructureLatCoords
            Me.txtDiscoveryDate.Text = strDiscoveryDate
            Me.txtDiscoveredBy.Text = strDiscoveredBy
            Me.txtNotes.Text = strNotes
            Me.txtDefault.Text = strDefault
            Me.txtLastUpdated.Text = strLastUpdated
        Else
            Me.txtPlanetID.Text = strPlanetID
            Me.txtStructureID.Text = strStructureID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = CStr(Me.TotalStructures)
            Me.txtStructureName.Text = ""
            Me.txtDiscoveryDate.Text = ""
            Me.txtStructureLongitude.Text = ""
            Me.txtStructureLatitude.Text = ""
            Me.txtDiscoveredBy.Text = ""
            Me.txtNotes.Text = ""
            Me.txtDefault.Text = ""
            Me.txtImageFilename.Text = ""
            Me.txtImageEXT.Text = ""
            Me.txtImageSizeBytes.Text = ""
            Me.txtImageSizeKilobytes.Text = ""
        End If

    End Sub

    Public Sub SaveStructure(Optional SetDefault As Boolean = False)
        Dim strStructureName As String
        Dim strStructureID As String
        Dim strAccountID As String
        Dim strPlanetID As String
        Dim strStructureLongCoords As String
        Dim strStructureLatCoords As String
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strLastUpdated As String
        Dim strNotes As String
        Dim strUserID As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblStructures"
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
        Dim FoundStructure As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim strDefaultStructure As String
        Dim ResetOK As Boolean = False
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim arrImage() As Byte
        Dim memStream As New System.IO.MemoryStream
        Dim NewIDValue As String
        Dim strImageFilename As String
        Dim strImageExtension As String
        Dim strImageSize As String
        Dim fi As IO.FileInfo
        Dim dt As DataTable
        Dim TotalStructures As Integer
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
        strStructureID = txtStructureID.Text
        strLastUpdated = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strStructureName = txtStructureName.Text
        strAccountID = txtAccountID.Text
        strPlanetID = txtPlanetID.Text
        strStructureLongCoords = Trim(Replace(txtStructureLongitude.Text, " ", ""))
        strStructureLatCoords = Trim(Replace(txtStructureLatitude.Text, " ", ""))
        strDiscoveredBy = txtDiscoveredBy.Text
        strNotes = txtNotes.Text
        strDefaultStructure = txtDefault.Text

        strImageFilename = pbStructurePic.Tag
        If Len(strImageFilename) > 0 Then
            fi = New IO.FileInfo(strImageFilename)
            strImageExtension = fi.Extension
        End If

        If SetDefault = True Or UCase(txtDefault.Text) = "DEFAULT" Then
            ResetOK = DAL.UpdateALL(frmMain.myConnString, DBTable, "DefaultStructure")
            If ResetOK = False Then
                MsgBox("Could not reset Default field")
                Exit Sub
            End If
            strDefaultStructure = "DEFAULT"
        Else
            'DefaultAccount = ""
        End If

        FieldNames = "UserID"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",PlanetID"
        FieldNames = FieldNames & ",StructureName"
        FieldNames = FieldNames & ",StructureLongCoords"
        FieldNames = FieldNames & ",StructureLatCoords"
        FieldNames = FieldNames & ",DiscoveryDate"
        FieldNames = FieldNames & ",DiscoveredBy"
        FieldNames = FieldNames & ",Notes"
        FieldNames = FieldNames & ",DefaultStructure"
        FieldNames = FieldNames & ",LastUpdated"
        FieldNames = FieldNames & ",ImageFilename"
        FieldNames = FieldNames & ",ImageExt"

        FieldValues = strUserID
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strPlanetID
        FieldValues = FieldValues & "," & strStructureName
        FieldValues = FieldValues & "," & strStructureLongCoords
        FieldValues = FieldValues & "," & strStructureLatCoords
        FieldValues = FieldValues & "," & strDiscoveryDate
        FieldValues = FieldValues & "," & strDiscoveredBy
        FieldValues = FieldValues & "," & strNotes
        FieldValues = FieldValues & "," & strDefaultStructure
        FieldValues = FieldValues & "," & strLastUpdated
        FieldValues = FieldValues & "," & strImageFilename
        FieldValues = FieldValues & "," & strImageExtension


        SearchText = strStructureID
        SearchField = "WeypointID"
        ReturnField = "WeypointID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "StructureName"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundStructure = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundStructure Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Structure Already EXISTS - Proceed with update?", vbYesNo, "STRUCTURE ALREADY EXISTS")
            If Answer = vbYes Then
                If FieldType = "INTEGER" And IsNumeric(SearchText) Then
                    UpdateCriteria = SearchField & "=" & SearchText
                End If
                If FieldType = "STRING" Then
                    UpdateCriteria = SearchField & "=" & "'" & SearchText & "'"
                End If
                UpdateCriteria = "StructureID=" & CInt(ReturnValue)
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
            NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblStructures", "StructureID")
        End If
        If SavedOK Then
            MsgBox("OK Structure Info Updated.")
            If Planet_ID <> "" And IsNumeric(Planet_ID) Then
                dt = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblStructures WHERE PlanetID=" & CInt(Planet_ID), TotalStructures)
                DAL.UpdateALL(frmMain.myConnString, "tblPlanets", "TotalStructures", CStr(TotalStructures), "PlanetID=" & CInt(Planet_ID))
            End If
        Else
            MsgBox("Problem: Structure Info NOT SAVE")
        End If

        If strImageExtension IsNot Nothing Then
            If UCase(strImageExtension) = ".BMP" Then
                pbStructurePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImageExtension) = ".JPG" Then
                pbStructurePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImageExtension) = ".PNG" Then
                pbStructurePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImageExtension) = ".GIF" Then
                pbStructurePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                MsgBox("UNKNOWN IMAGE FORMAT")
                Exit Sub
            End If
            arrImage = memStream.GetBuffer()
            'NEED TO PASS THE NEW RESOURCE ID HERE: Max(ResourceID) perhaps ???

            If DAL.UpdateTableWithImage(frmMain.myConnString, "tblStructures", "StructureID", NewIDValue, "Image", memStream, arrImage, "ImageSize") Then
                MsgBox("OK PICTURE SAVED")
            Else
                MsgBox("PICTURE NOT SAVED")
            End If
        End If
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        '
        SaveStructure()
        Me.Close()

    End Sub

    Private Sub frmStructureEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        If Me.IsDefault = True Then
            Me.txtDefault.Text = "DEFAULT"
        Else
            Me.txtDefault.Text = ""
        End If
        PopulateForm()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        '
        Me.Close()
    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        '
        txtDiscoveryDate.Text = CDate(Now()).ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub btnImportPicture_Click(sender As Object, e As EventArgs) Handles btnImportPicture.Click
        '
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pbStructurePic.BackgroundImage = Image.FromFile(dlg.FileName)
            txtImageFilename.Text = dlg.FileName
            pbStructurePic.Tag = dlg.FileName
        End If
    End Sub

    Private Sub txtStructureLongitude_Leave(sender As Object, e As EventArgs) Handles txtStructureLongitude.Leave
        'NORTH / SOUTH COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtStructureLongitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtStructureLongitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtStructureLongitude.Text = strNewValue
        End If
    End Sub

    Private Sub txtStructureLatitude_Leave(sender As Object, e As EventArgs) Handles txtStructureLatitude.Leave
        'EAST / WEST COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtStructureLatitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtStructureLatitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtStructureLatitude.Text = strNewValue
        End If
    End Sub
End Class