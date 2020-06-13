Public Class frmStorageEntry
    Private _IsUpdated As Integer

    Public Property IsUpdated As Integer
        Get
            Return _IsUpdated
        End Get
        Set(value As Integer)
            _IsUpdated = value
        End Set
    End Property


    Public Sub SaveStorageConfig(Optional SetDefault As Boolean = False)
        Dim strStorageName As String
        Dim strStorageCategory As String
        Dim strStorageID As String
        Dim strAccountID As String
        Dim strSubmitTime As String
        Dim strNotes As String
        Dim strMaxCols As String
        Dim strMaxRows As String
        Dim strMaxSlots As String
        Dim strUserID As String
        Dim FieldNames As String
        Dim FieldValues As String
        Dim SavedOK As Boolean = False
        Dim DBTable As String = "tblPreferences"
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
        Dim FoundStorageName As Boolean = False
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
        Dim strStorageUpdate As String
        'Need to search table - if same date and time already exists ?
        ' - to determin if its an update or a NEW LOG ENTRY ?
        ' - since this form can be called up to edit a current log entry etc. when the user selects an item in the grid.
        'NEED TO SAVE THE EXTENSION of the IMAGE.

        'PUT INTO DAL

        dtCurrentDate = Now()
        If Len(txtUpdated.Text) = 0 Then
            txtUpdated.Text = dtCurrentDate.ToString("dd/MM/yyyy HH:mm:ss")
            strStorageUpdate = dtCurrentDate.ToString("yyyy-MM-dd HH:mm:ss")
        Else
            If IsDate(txtUpdated.Text) Then
                strStorageUpdate = CDate(txtUpdated.Text).ToString("yyyy-MM-dd HH:mm:ss")
            End If
        End If
        ErrMessages = ""
        strUserID = frmMain.myUserID
        strStorageID = txtPrefID.Text
        strSubmitTime = strStorageUpdate
        strStorageName = txtStorageName.Text
        strStorageCategory = comCategories.Text
        strAccountID = txtAccountID.Text
        strUserID = txtUserID.Text
        strNotes = txtNotes.Text
        strMaxCols = txtColumns.Text
        strMaxRows = txtRows.Text
        strMaxSlots = txtMAXSlots.Text
        strImageFilename = pbStoragePic.Tag
        If Len(strImageFilename) > 0 Then
            fi = New IO.FileInfo(strImageFilename)
            strImageExtension = fi.Extension
        End If

        'Dim fi As New IO.FileInfo(dlg.FileName)
        'Dim extn As String = fi.Extension

        FieldNames = "UserID"
        FieldNames = FieldNames & ",AccountID"
        FieldNames = FieldNames & ",StorageCategory"
        FieldNames = FieldNames & ",StorageName"
        FieldNames = FieldNames & ",StorageLayoutColumns"
        FieldNames = FieldNames & ",StorageLayoutRows"
        FieldNames = FieldNames & ",StorageTotalSlots"
        FieldNames = FieldNames & ",StorageNotes"
        FieldNames = FieldNames & ",LastUpdated"

        FieldValues = strUserID
        FieldValues = FieldValues & "," & strAccountID
        FieldValues = FieldValues & "," & strStorageCategory
        FieldValues = FieldValues & "," & strStorageName
        FieldValues = FieldValues & "," & strMaxCols
        FieldValues = FieldValues & "," & strMaxRows
        FieldValues = FieldValues & "," & strMaxSlots
        FieldValues = FieldValues & "," & strNotes
        FieldValues = FieldValues & "," & strSubmitTime
        FieldValues = FieldValues & "," & strImageFilename
        FieldValues = FieldValues & "," & strImageExtension

        SearchText = strStorageName
        SearchField = "StorageName"
        ReturnField = "PrefID"
        ReturnValue = ""
        FieldType = "STRING"
        Reversed = True
        SortFields = "StorageName"
        ExcludeFields = ""
        SearchCriteria = "UserID=" & CInt(frmMain.myUserID) & " AND StorageCategory = '" & strStorageCategory & "'"
        FoundStorageName = DAL.Find_myQuery(frmMain.myConnString, DBTable, SearchField, SearchText, FieldType, "", ReturnField, ReturnValue, AllValues,
                                   AllFields, SearchCriteria, SortFields, Reversed, ErrMessage)
        If FoundStorageName Then

            'strDeliveryDate = GetMYValuebyFieldname(AllValues, AllFields, "DeliveryDate")
            Answer = MsgBox("Storage Name Already EXISTS - Proceed with update?", vbYesNo, "STORAGE ALREADY EXISTS")
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
                    Me.IsUpdated = 2
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
                Me.IsUpdated = 1
            End If
            NewIDValue = DAL.GetLastID(frmMain.myConnString, "tblResources", "ResourceID")
        End If
        If SavedOK Then
            MsgBox("OK Storage Info Updated.")
        Else
            MsgBox("Storage Info NOT SAVED")
        End If

        If strImageExtension IsNot Nothing Then
            If UCase(strImageExtension) = ".BMP" Then
                pbStoragePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Bmp)
            ElseIf UCase(strImageExtension) = ".JPG" Then
                pbStoragePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf UCase(strImageExtension) = ".PNG" Then
                pbStoragePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf UCase(strImageExtension) = ".GIF" Then
                pbStoragePic.BackgroundImage.Save(memStream, System.Drawing.Imaging.ImageFormat.Gif)
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

    Private Sub btnImportPicture_Click(sender As Object, e As EventArgs) Handles btnImportPicture.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click

    End Sub

    Private Sub imgCalendar_SelectDiscoveryDate_Click(sender As Object, e As EventArgs) Handles imgCalendar_SelectDiscoveryDate.Click
        txtUpdated.Text = Now().ToString("dd-MM-yyyy HH:mm:ss")
    End Sub

    Private Sub frmStorageEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub comAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comAccounts.SelectedIndexChanged
        txtAccountID.Text = CStr(comAccounts.SelectedValue)
    End Sub
End Class