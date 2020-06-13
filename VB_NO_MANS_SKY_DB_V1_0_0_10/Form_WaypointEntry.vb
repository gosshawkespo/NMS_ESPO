Public Class frmWaypointEntry

    Private _PlanetID As String
    Private _WaypointID As String
    Private _AccountID As String
    Private _TotalWaypoints As Integer
    Private _IsDefault As Boolean

    Public Property Planet_ID() As String
        Get
            Return _PlanetID
        End Get
        Set(value As String)
            _PlanetID = value
        End Set
    End Property

    Public Property Waypoint_ID() As String
        Get
            Return _WaypointID
        End Get
        Set(value As String)
            _WaypointID = value
        End Set
    End Property

    Public Property TotalWaypoints() As Integer
        Get
            Return _TotalWaypoints
        End Get
        Set(value As Integer)
            _TotalWaypoints = value
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

        Dim strWaypointName As String
        Dim strWaypointID As String
        Dim strAccountID As String
        Dim strWaypointLongCoords As String
        Dim strWaypointLatCoords As String
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
        strWaypointID = Me.Waypoint_ID
        strAccountID = Me.Account_ID
        strSQL = "SELECT * FROM tblWaypoints WHERE UserID=" & CInt(strUserID) & " AND WeypointID=" & CInt(strWaypointID) & " AND AccountID=" & CInt(strAccountID)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, intNumRows)

        If intNumRows > 0 Then
            'strResourceID = dt.Rows(0)("ResourceID")
            strAccountID = dt.Rows(0)("AccountID")
            strNumRows = CStr(intNumRows)
            strWaypointName = dt.Rows(0)("WaypointName")
            strWaypointLongCoords = dt.Rows(0)("WaypointLongCoords")
            strWaypointLatCoords = dt.Rows(0)("WaypointLatCoords")
            strDiscoveryDate = dt.Rows(0)("DiscoveryDate")
            strDiscoveredBy = dt.Rows(0)("DiscoveredBy")
            strNotes = dt.Rows(0)("Notes")
            strLastUpdated = dt.Rows(0)("LastUpdated")
            strDefault = dt.Rows(0)("DefaultWaypoint")
            strImageFilename = dt.Rows(0)("ImageFilename")
            strResourceImageExt = dt.Rows(0)("ImageExt")

            LoadOK = DAL.Get_Pic_From_DB(frmMain.myConnString, "tblWaypoints", "Image", "WeypointID", strWaypointID, ImageByte)
            If LoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pbWaypointPic.BackgroundImage = Image.FromStream(memStream)
                pbWaypointPic.Tag = strImageFilename
                txtImageFilename.Text = strImageFilename
                txtImageEXT.Text = strResourceImageExt
            End If

            Me.txtPlanetID.Text = strPlanetID
            Me.txtWaypointID.Text = strWaypointID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = strNumRows
            Me.txtWaypointName.Text = strWaypointName
            Me.txtWaypointLongitude.Text = strWaypointLongCoords
            Me.txtWaypointLatitude.Text = strWaypointLatCoords
            Me.txtDiscoveryDate.Text = strDiscoveryDate
            Me.txtDiscoveredBy.Text = strDiscoveredBy
            Me.txtNotes.Text = strNotes
            Me.txtDefault.Text = strDefault
            Me.txtLastUpdated.Text = strLastUpdated
        Else
            Me.txtPlanetID.Text = strPlanetID
            Me.txtWaypointID.Text = strWaypointID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = CStr(Me.TotalWaypoints)
            Me.txtWaypointName.Text = ""
            Me.txtDiscoveryDate.Text = ""
            Me.txtWaypointLongitude.Text = ""
            Me.txtWaypointLatitude.Text = ""
            Me.txtDiscoveredBy.Text = ""
            Me.txtNotes.Text = ""
            Me.txtDefault.Text = ""
        End If

    End Sub

    Public Sub SaveWaypoint(Optional SetDefault As Boolean = False)
        Dim strWaypointName As String
        Dim strWaypointID As String
        Dim strAccountID As String
        Dim strPlanetID As String
        Dim strWaypointLongCoords As String
        Dim strWaypointLatCoords As String
        Dim strDiscoveryDate As String
        Dim strDiscoveredBy As String
        Dim strLastUpdated As String
        Dim strNotes As String
        Dim strUserID As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblWaypoints"
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
        Dim FoundWaypoint As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim strDefaultWaypoint As String
        Dim ResetOK As Boolean = False
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim arrImage() As Byte
        Dim memStream As New System.IO.MemoryStream
        Dim NewIDValue As String
        Dim strImageFilename As String
        Dim strImageExtension As String
        Dim fi As IO.FileInfo
        Dim dt As DataTable
        Dim TotalWaypoints As Integer
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
        strWaypointID = txtWaypointID.Text
        strLastUpdated = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strWaypointName = txtWaypointName.Text
        strAccountID = txtAccountID.Text
        strPlanetID = txtPlanetID.Text
        strWaypointLongCoords = Trim(Replace(txtWaypointLongitude.Text, " ", ""))
        strWaypointLatCoords = Trim(Replace(txtWaypointLatitude.Text, " ", ""))
        strDiscoveredBy = txtDiscoveredBy.Text
        strNotes = txtNotes.Text
        strDefaultWaypoint = txtDefault.Text

        strImageFilename = pbWaypointPic.Tag
        If Len(strImageFilename) > 0 Then
            fi = New IO.FileInfo(strImageFilename)
            strImageExtension = fi.Extension
        End If

        If SetDefault = True Or UCase(txtDefault.Text) = "DEFAULT" Then
            ResetOK = DAL.UpdateALL(frmMain.myConnString, DBTable, "DefaultWaypoint")
            If ResetOK = False Then
                MsgBox("Could not reset Default field")
                Exit Sub
            End If
            strDefaultWaypoint = "DEFAULT"
        Else
            'DefaultAccount = ""
        End If

        FieldNames = "UserID"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",PlanetID"
        FieldNames = FieldNames & ",WaypointName"
        FieldNames = FieldNames & ",WaypointLongCoords"
        FieldNames = FieldNames & ",WaypointLatCoords"
        FieldNames = FieldNames & ",DiscoveryDate"
        FieldNames = FieldNames & ",DiscoveredBy"
        FieldNames = FieldNames & ",Notes"
        FieldNames = FieldNames & ",DefaultWaypoint"
        FieldNames = FieldNames & ",LastUpdated"
        FieldNames = FieldNames & ",ImageFilename"
        FieldNames = FieldNames & ",ImageExt"

        FieldValues = strUserID
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strPlanetID
        FieldValues = FieldValues & "," & strWaypointName
        FieldValues = FieldValues & "," & strWaypointLongCoords
        FieldValues = FieldValues & "," & strWaypointLatCoords
        FieldValues = FieldValues & "," & strDiscoveryDate
        FieldValues = FieldValues & "," & strDiscoveredBy
        FieldValues = FieldValues & "," & strNotes
        FieldValues = FieldValues & "," & strDefaultWaypoint
        FieldValues = FieldValues & "," & strLastUpdated
        FieldValues = FieldValues & "," & strImageFilename
        FieldValues = FieldValues & "," & strImageExtension

        SearchText = strWaypointName
        SearchField = "WaypointName"
        ReturnField = "WeypointID"
        ReturnValue = ""
        FieldType = "STRING"
        Reversed = True
        SortFields = "WaypointName"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundWaypoint = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundWaypoint Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Waypoint Already EXISTS - Proceed with update?", vbYesNo, "WAYPOINT ALREADY EXISTS")
            If Answer = vbYes Then
                If FieldType = "INTEGER" And IsNumeric(SearchText) Then
                    UpdateCriteria = SearchField & "=" & SearchText
                End If
                If FieldType = "STRING" Then
                    UpdateCriteria = SearchField & "=" & "'" & SearchText & "'"
                End If
                UpdateCriteria = "WeypointID=" & CInt(ReturnValue)
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
            NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblWaypoints", "WeypointID")
        End If
        If SavedOK Then
            MsgBox("OK Waypoint Info Updated.")
            If Planet_ID <> "" And IsNumeric(Planet_ID) Then
                dt = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblWaypoints WHERE PlanetID=" & CInt(Planet_ID), TotalWaypoints)
                DAL.UpdateALL(frmMain.myConnString, "tblPlanets", "TotalWaypointsDiscovered", CStr(TotalWaypoints), "PlanetID=" & CInt(Planet_ID))
            End If
        Else
            MsgBox("Problem: Waypoint Info NOT SAVE")
        End If

        If strImageExtension IsNot Nothing Then
            If UCase(strImageExtension) = ".BMP" Then
                pbWaypointPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImageExtension) = ".JPG" Then
                pbWaypointPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImageExtension) = ".PNG" Then
                pbWaypointPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImageExtension) = ".GIF" Then
                pbWaypointPic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                MsgBox("UNKNOWN IMAGE FORMAT")
                Exit Sub
            End If
            arrImage = memStream.GetBuffer()
            'NEED TO PASS THE NEW RESOURCE ID HERE: Max(ResourceID) perhaps ???

            If DAL.UpdateTableWithImage(frmMain.myConnString, "tblWaypoints", "WeypointID", NewIDValue, "Image", memStream, arrImage, "ImageSize") Then
                MsgBox("OK PICTURE SAVED")
            Else
                MsgBox("PICTURE NOT SAVED")
            End If
        End If
    End Sub


    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'Waypoint SAVE:
        SaveWaypoint(Me.IsDefault)
        Me.Close()

    End Sub

    Private Sub frmWaypointEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load last time this record was updated from DB field:
        If Me.IsDefault = True Then
            Me.txtDefault.Text = "DEFAULT"
        Else
            Me.txtDefault.Text = ""
        End If
        PopulateForm()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        txtDiscoveryDate.Text = CDate(Now()).ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub btnImportPicture_Click(sender As Object, e As EventArgs) Handles btnImportPicture.Click
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pbWaypointPic.BackgroundImage = Image.FromFile(dlg.FileName)
            txtImageFilename.Text = dlg.FileName
            pbWaypointPic.Tag = dlg.FileName
        End If
    End Sub

    Private Sub txtWaypointLongitude_Leave(sender As Object, e As EventArgs) Handles txtWaypointLongitude.Leave
        'NORTH / SOUTH COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtWaypointLongitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtWaypointLongitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtWaypointLongitude.Text = strNewValue
        End If
    End Sub

    Private Sub txtWaypointLatitude_Leave(sender As Object, e As EventArgs) Handles txtWaypointLatitude.Leave
        'EAST / WEST COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtWaypointLatitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtWaypointLatitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtWaypointLatitude.Text = strNewValue
        End If
    End Sub
End Class