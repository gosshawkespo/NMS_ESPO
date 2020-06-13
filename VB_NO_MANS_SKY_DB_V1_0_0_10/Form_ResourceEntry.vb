Public Class frmResourceEntry

    Private _PlanetID As String
    Private _ResourceID As String
    Private _AccountID As String
    Private _TotalResources As Integer
    Private _IsDefault As Boolean

    Public Property Planet_ID() As String
        Get
            Return _PlanetID
        End Get
        Set(value As String)
            _PlanetID = value
        End Set
    End Property

    Public Property Resource_ID() As String
        Get
            Return _ResourceID
        End Get
        Set(value As String)
            _ResourceID = value
        End Set
    End Property

    Public Property TotalResources() As Integer
        Get
            Return _TotalResources
        End Get
        Set(value As Integer)
            _TotalResources = value
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

        Dim strResourceName As String
        Dim strResourceID As String
        Dim strAccountID As String
        Dim strResourceLongCoords As String
        Dim strResourceLatCoords As String
        Dim strPowerYield As String
        Dim strPowerLongCoords As String
        Dim strPowerLatCoords As String
        Dim strResourceYield As String
        Dim strResourceType As String
        Dim strDiscoveryDate As String
        Dim strLastUpdated As String
        Dim strNotes As String
        Dim strUserID As String
        Dim strPlanetID As String
        Dim strAmountExtracted As String
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
        strResourceID = Me.Resource_ID
        strAccountID = Me.Account_ID
        strSQL = "SELECT * FROM tblResources WHERE UserID=" & CInt(strUserID) & " AND ResourceID=" & CInt(strResourceID) & " AND AccountID=" & CInt(strAccountID)
        dt = DAL.GetDataTable(frmMain.myConnString, strSQL, intNumRows)

        If intNumRows > 0 Then
            'strResourceID = dt.Rows(0)("ResourceID")
            strAccountID = dt.Rows(0)("AccountID")
            strNumRows = CStr(intNumRows)
            strResourceName = dt.Rows(0)("ResourceName")
            strResourceLongCoords = dt.Rows(0)("ResourceLongCoords")
            strResourceLatCoords = dt.Rows(0)("ResourceLatCoords")
            strPowerLongCoords = dt.Rows(0)("PowerGridLongCoords")
            strPowerLatCoords = dt.Rows(0)("PowerGridLatCoords")
            strPowerYield = dt.Rows(0)("PowerYield")
            strResourceYield = dt.Rows(0)("AmountResourceYielded")
            strResourceType = dt.Rows(0)("ResourceType")
            strDiscoveryDate = dt.Rows(0)("DiscoveryDate")
            strNotes = dt.Rows(0)("Notes")
            strLastUpdated = dt.Rows(0)("LastUpdated")
            strAmountExtracted = dt.Rows(0)("AmountExtracted")
            strDefault = dt.Rows(0)("DefaultResource")
            strImageFilename = dt.Rows(0)("ResourceImageFilename")
            strResourceImageExt = dt.Rows(0)("ResourceImageExt")

            LoadOK = DAL.Get_Pic_From_DB(frmMain.myConnString, "tblResources", "ResourceImage", "ResourceID", strResourceID, ImageByte)
            If LoadOK And ImageByte IsNot Nothing Then
                memStream = New IO.MemoryStream(ImageByte)
                pbResourcePic.BackgroundImage = Image.FromStream(memStream)
                pbResourcePic.Tag = strImageFilename
                txtImageFilename.Text = strImageFilename
                txtImageEXT.Text = strResourceImageExt
            End If

            Me.txtPlanetID.Text = strPlanetID
            Me.txtResourceID.Text = strResourceID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = strNumRows
            Me.txtResourceName.Text = strResourceName
            Me.txtAmountExtracted.Text = strAmountExtracted
            Me.txtDiscoveryDate.Text = strDiscoveryDate
            Me.txtPowerYield.Text = strPowerYield
            Me.txtResourceLongitude.Text = strResourceLongCoords
            Me.txtResourceLatitude.Text = strResourceLatCoords
            Me.txtPowerGridLongitude.Text = strPowerLongCoords
            Me.txtPowerGridLatitude.Text = strPowerLatCoords
            Me.txtResourceType.Text = strResourceType
            Me.txtResourceYield.Text = strResourceYield
            Me.txtNotes.Text = strNotes
            Me.txtDefault.Text = strDefault
            Me.txtLastUpdated.Text = strLastUpdated
        Else
            Me.txtPlanetID.Text = strPlanetID
            Me.txtResourceID.Text = strResourceID
            Me.txtAccountID.Text = strAccountID
            Me.txtNumRows.Text = CStr(Me.TotalResources)
            Me.txtResourceName.Text = ""
            Me.txtAmountExtracted.Text = ""
            Me.txtDiscoveryDate.Text = ""
            Me.txtPowerYield.Text = ""
            Me.txtResourceLongitude.Text = ""
            Me.txtResourceType.Text = ""
            Me.txtResourceYield.Text = ""
            Me.txtNotes.Text = ""
            Me.txtDefault.Text = ""
        End If

    End Sub

    Public Sub SaveResource(Optional SetDefault As Boolean = False)
        Dim strResourceName As String
        Dim strResourceID As String
        Dim strAccountID As String
        Dim strPlanetID As String
        Dim strResourceLongCoords As String
        Dim strResourceLatCoords As String
        Dim strPowerGridLongCoords As String
        Dim strPowerGridLatCoords As String
        Dim strPowerYield As String
        Dim strResourceYield As String
        Dim strResourceType As String
        Dim strDiscoveryDate As String
        Dim strSubmitTime As String
        Dim strNotes As String
        Dim strUserID As String
        Dim strAmountExtracted As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblResources"
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
        Dim FoundResource As Boolean = False
        Dim AllValues() As Object
        Dim AllFields() As String
        Dim ErrMessage As String = ""
        Dim dtCurrentDate As DateTime
        Dim Answer As Integer
        Dim DefaultAccount As String
        Dim ResetOK As Boolean = False
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)
        Dim arrImage() As Byte
        Dim memStream As New System.IO.MemoryStream
        Dim NewIDValue As String
        Dim strImageFilename As String
        Dim strImageExtension As String
        Dim fi As IO.FileInfo
        Dim TotalResources As Integer
        Dim dt As DataTable
        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.
        'NEED TO SAVE THE EXTENSION of the IMAGE.

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
        strResourceID = txtResourceID.Text
        strSubmitTime = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        strResourceName = txtResourceName.Text
        strAccountID = txtAccountID.Text
        strPlanetID = txtPlanetID.Text
        strResourceLongCoords = Trim(Replace(txtResourceLongitude.Text, " ", ""))
        strResourceLatCoords = Trim(Replace(txtResourceLatitude.Text, " ", ""))
        strPowerGridLongCoords = Trim(Replace(txtPowerGridLongitude.Text, " ", ""))
        strPowerGridLatCoords = Trim(Replace(txtPowerGridLatitude.Text, " ", ""))
        strPowerYield = txtPowerYield.Text
        strResourceYield = txtResourceYield.Text
        strResourceType = txtResourceType.Text
        strNotes = txtNotes.Text
        DefaultAccount = txtDefault.Text
        strAmountExtracted = txtAmountExtracted.Text
        strImageFilename = pbResourcePic.Tag
        If Len(strImageFilename) > 0 Then
            fi = New IO.FileInfo(strImageFilename)
            strImageExtension = fi.Extension
        End If

        'Dim fi As New IO.FileInfo(dlg.FileName)
        'Dim extn As String = fi.Extension

        If SetDefault = True Or UCase(txtDefault.Text) = "DEFAULT" Then
            ResetOK = DAL.UpdateALL(frmMain.myConnString, DBTable, "DefaultResource")
            If ResetOK = False Then
                MsgBox("Could not reset Default field")
                Exit Sub
            End If
            DefaultAccount = "DEFAULT"
        Else
            'DefaultAccount = ""
        End If

        FieldNames = "UserID"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",PlanetID"
        FieldNames = FieldNames & ",ResourceName"
        FieldNames = FieldNames & ",ResourceLongCoords"
        FieldNames = FieldNames & ",ResourceLatCoords"
        FieldNames = FieldNames & ",PowerGridLongCoords"
        FieldNames = FieldNames & ",PowerGridLatCoords"
        FieldNames = FieldNames & ",PowerYield"
        FieldNames = FieldNames & ",AmountResourceYielded"
        FieldNames = FieldNames & ",ResourceType"
        FieldNames = FieldNames & ",DiscoveryDate"
        FieldNames = FieldNames & ",Notes"
        FieldNames = FieldNames & ",LastUpdated"
        FieldNames = FieldNames & ",DefaultResource"
        FieldNames = FieldNames & ",AmountExtracted"
        FieldNames = FieldNames & ",ResourceImageFilename"
        FieldNames = FieldNames & ",ResourceImageExt"

        FieldValues = strUserID
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strPlanetID
        FieldValues = FieldValues & "," & strResourceName
        FieldValues = FieldValues & "," & strResourceLongCoords
        FieldValues = FieldValues & "," & strResourceLatCoords
        FieldValues = FieldValues & "," & strPowerGridLongCoords
        FieldValues = FieldValues & "," & strPowerGridLatCoords
        FieldValues = FieldValues & "," & strPowerYield
        FieldValues = FieldValues & "," & strResourceYield
        FieldValues = FieldValues & "," & strResourceType
        FieldValues = FieldValues & "," & strDiscoveryDate
        FieldValues = FieldValues & "," & strNotes
        FieldValues = FieldValues & "," & strSubmitTime
        FieldValues = FieldValues & "," & DefaultAccount
        FieldValues = FieldValues & "," & strAmountExtracted
        FieldValues = FieldValues & "," & strImageFilename
        FieldValues = FieldValues & "," & strImageExtension

        SearchText = strResourceID
        SearchField = "ResourceID"
        ReturnField = "ResourceID"
        ReturnValue = ""
        FieldType = "INTEGER"
        Reversed = True
        SortFields = "ResourceName"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID)
        FoundResource = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundResource Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Resource Name Already EXISTS - Proceed with update?", vbYesNo, "RESOURCE ALREADY EXISTS")
            If Answer = vbYes Then
                If FieldType = "INTEGER" And IsNumeric(SearchText) Then
                    UpdateCriteria = SearchField & "=" & SearchText
                End If
                If FieldType = "STRING" Then
                    UpdateCriteria = SearchField & "=" & "'" & SearchText & "'"
                End If
                SavedOK = DAL.InsertUpdateRecords_Using_Parameters(frmMain.myConnString, True, "",
                    DBTable, FieldNames, FieldValues, UpdateCriteria, ExcludeFields, ErrMessages, False,
                            ",", ";")
                If SavedOK Then
                    frmPlanetEntry_v2.IsUpdated = 2
                    'Need total resources in query so far for this planet and account:
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
            NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblResources", "ResourceID")
        End If
        If SavedOK Then
            MsgBox("OK Resource Info Updated.")
            If Planet_ID <> "" And IsNumeric(Planet_ID) Then
                dt = DAL.GetDataTable(frmMain.myConnString, "SELECT * FROM tblResources WHERE PlanetID=" & CInt(Planet_ID), TotalResources)
                DAL.UpdateALL(frmMain.myConnString, "tblPlanets", "TotalResources", CStr(TotalResources), "PlanetID=" & CInt(Planet_ID))
            End If
        Else
            MsgBox("Resource Info NOT SAVE")
        End If

        If strImageExtension IsNot Nothing Then
            If UCase(strImageExtension) = ".BMP" Then
                pbResourcePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImageExtension) = ".JPG" Then
                pbResourcePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImageExtension) = ".PNG" Then
                pbResourcePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImageExtension) = ".GIF" Then
                pbResourcePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                MsgBox("UNKNOWN IMAGE FORMAT")
                Exit Sub
            End If
            arrImage = memStream.GetBuffer()
            'NEED TO PASS THE NEW RESOURCE ID HERE: Max(ResourceID) perhaps ???

            If DAL.UpdateTableWithImage(frmMain.myConnString, "tblResources", "ResourceID", NewIDValue, "ResourceImage", memStream, arrImage, "ImageSize") Then
                MsgBox("OK PICTURE SAVED")
            Else
                MsgBox("PICTURE NOT SAVED OK")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'SAVE
        SaveResource(Me.IsDefault)
        frmPlanetEntry_v2.PopulateGrids(frmPlanetEntry_v2.txtPlanetID.Text)
        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Unchecked Then
            txtAmountExtracted.Text = ""
        ElseIf Len(txtResourceYield.Text) > 0 Then
            txtAmountExtracted.Text = txtResourceYield.Text
        Else
            txtAmountExtracted.Text = "ALL"
        End If
    End Sub

    Private Sub frmResourceEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        KeyPreview = True
        If Me.IsDefault = True Then
            Me.txtDefault.Text = "DEFAULT"
        Else
            Me.txtDefault.Text = ""
        End If
        PopulateForm()

    End Sub

    Private Sub btnSAVE_Click_1(sender As Object, e As EventArgs)
        '
    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        txtDiscoveryDate.Text = CDate(Now()).ToString("dd/MM/yyyy HH:mm:ss")

    End Sub





    Private Sub txtResourceLongitude_KeyPress(sender As Object, e As KeyPressEventArgs)


        'If e.KeyChar = "." Then
        'txtResourceLongitude.Select(6, 1)
        'End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblResourceCoords.Click
        MsgBox("Resource North/South= " & Trim(Replace(txtResourceLongitude.Text, " ", "")) & " , Resource East/West= " & Trim(Replace(txtResourceLatitude.Text, " ", "")))

    End Sub

    Private Sub txtResourceLatitude_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = "." Then
            txtResourceLatitude.Select(6, 1)
        End If
    End Sub

    Private Sub txtPowerGridLongitude_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = "." Then
            txtPowerGridLongitude.Select(6, 1)
        End If
    End Sub

    Private Sub txtPowerGridLatitude_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = "." Then
            txtPowerGridLatitude.Select(6, 1)
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblPowerGridCoords.Click
        MsgBox("Power Grid North/South= " & txtPowerGridLongitude.Text & " , Power Grid East/West= " & txtPowerGridLatitude.Text)
    End Sub

    Private Sub rbExtracted_CheckedChanged(sender As Object, e As EventArgs) Handles rbExtracted.CheckedChanged
        txtResourceType.Text = "Extracted"
    End Sub

    Private Sub rbDeposit_CheckedChanged(sender As Object, e As EventArgs) Handles rbDeposit.CheckedChanged
        txtResourceType.Text = "Deposit"
    End Sub

    Private Sub btnImportPicture_Click(sender As Object, e As EventArgs) Handles btnImportPicture.Click
        Dim dlg As New OpenFileDialog

        dlg.Filter = "Choose Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
        If dlg.ShowDialog = DialogResult.OK Then
            pbResourcePic.BackgroundImage = Image.FromFile(dlg.FileName)
            txtImageFilename.Text = dlg.FileName
            pbResourcePic.Tag = dlg.FileName
        End If
    End Sub



    Private Sub frmResourceEntry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Form keypress

    End Sub


    Function MaskedtxtBoxFill(FullEntry As String) As String
        Dim StopPos As Integer
        Dim NewEntry As String
        Dim idx As Integer
        Dim Entry As Char

        'now entry can be anything !
        'e.g hello1
        'e.g nothing - just blank/empty
        'e.g abc123
        'e.g 6.3 or (+001.600) or (-54.67) or -9.7 or -27.98 or 45.06 or +56 or 

        StopPos = InStr(Entry, ".")
        NewEntry = ""
        If Len(FullEntry) > 0 Then

            If StopPos > 0 Then
                For idx = 1 To StopPos - 1
                    Entry = Mid(FullEntry, idx, 1)
                    If idx = 1 Then
                        NewEntry = "("
                        If Not IsNumeric(Entry) Then
                            Continue For
                        ElseIf Entry = "+" Or Entry = "-" Then
                            NewEntry += Entry
                        Else
                            Continue For
                        End If
                    ElseIf idx = 2 Then
                        If Entry = "+" Then
                            NewEntry += "+"
                        End If
                    End If
                    If idx = 2 Then

                    End If
                Next
                For idx = StopPos + 1 To Len(FullEntry) - 1

                Next
            Else
                'NO DECIMAL POINT in entry:

            End If

        Else
            'entry is blank:
            NewEntry = "(000.000)"
        End If


        If Mid(Entry, 2, 1) = " " Or Mid(Entry, 2, 1) = "0" Then
            NewEntry += "+"
        Else
            NewEntry += Mid(Entry, 2, 1)
        End If
        For idx = 3 To StopPos - 1
            If Mid(Entry, idx, 1) = " " Then
                NewEntry += "0"
            Else
                NewEntry += Mid(Entry, idx, 1)
            End If
        Next
        For idx = StopPos + 1 To Len(Entry) - 1
            If Mid(Entry, idx, 1) = " " Then
                NewEntry += "0"
            Else
                NewEntry += Mid(Entry, idx, 1)
            End If
        Next
        NewEntry += ")"
        MaskedtxtBoxFill = NewEntry
        'txtBox.Dispose()

    End Function

    Private Sub txtResourceLongitude_Leave(sender As Object, e As EventArgs) Handles txtResourceLongitude.Leave
        'User just tabbed out or control lost focus - fill control:
        'txtResourceLongitude.Text = MaskedtxtBoxFill(txtResourceLongitude)
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtResourceLongitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtResourceLongitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtResourceLongitude.Text = strNewValue
        End If
    End Sub

    Private Sub txtResourceLongitude_TextChanged(sender As Object, e As EventArgs) Handles txtResourceLongitude.TextChanged

    End Sub

    Private Sub txtResourceLatitude_Leave(sender As Object, e As EventArgs) Handles txtResourceLatitude.Leave
        'EAST / WEST COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtResourceLatitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtResourceLatitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtResourceLatitude.Text = strNewValue
        End If
    End Sub

    Private Sub txtPowerGridLongitude_Leave(sender As Object, e As EventArgs) Handles txtPowerGridLongitude.Leave
        'NORTH / SOUTH COORDINATES
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtPowerGridLongitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtPowerGridLongitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtPowerGridLongitude.Text = strNewValue
        End If
    End Sub

    Private Sub txtPowerGridLatitude_Leave(sender As Object, e As EventArgs) Handles txtPowerGridLatitude.Leave
        'EAST / WEST COORDINATES:
        Dim dblNewValue As Double
        Dim Entry As String
        Dim strNewValue As String
        Dim msg As String
        Dim DAL As New clsNMSdal(frmMain.myVersion, frmMain.myUsername)

        Entry = txtPowerGridLatitude.Text
        dblNewValue = DAL.CheckCoordEntry(Entry, msg)
        If Len(msg) > 0 Then
            MsgBox(msg)
            txtPowerGridLatitude.Text = "(0.0)"
        Else
            strNewValue = CStr(dblNewValue)
            strNewValue = DAL.ConvertEntryToCoords(dblNewValue)
            strNewValue = "(" & strNewValue & ")"
            strNewValue = DAL.AddZeros(strNewValue)
            txtPowerGridLatitude.Text = strNewValue
        End If
    End Sub
End Class