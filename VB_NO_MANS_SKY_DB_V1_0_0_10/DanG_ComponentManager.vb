Module ComponentManager
    Public myControl As Control
    Public dic_Controls As Object

    Sub Initialise()
        Dim Type1 As String
        Dim Type2 As String
        Dim Type3 As String
        Dim Type4 As String
        Dim Type5 As String
        Dim ErrMessage As String

        dic_Controls = CreateObject("Scripting.Dictionary")
        dic_Controls.CompareMode = vbTextCompare

    End Sub

    Sub AddFormControls(myForm As Form, ControlType As String, ControlName As String, InitialValue As String, TagNumber As String,
                        xx As Integer, yy As Integer, Width As Integer, Height As Integer,
                        Optional theImage As Image = Nothing)
        'Dim tempControl As clsControls 'replaces mycontrol = OR tempControl = myControl

        If UCase(ControlType) = "TEXTBOX" Then
            myControl = New TextBox
            myControl.Name = ControlName
            myControl.Tag = TagNumber
            myControl.Left = xx
            myControl.Top = yy
            myControl.Width = Width
            myControl.Height = Height
            myControl.Text = InitialValue
            'AddHandler myControl.TextChanged, AddressOf myControl_textchanged
            myForm.Controls.Add(myControl)

        End If
        If UCase(ControlType) = "BUTTON" Then
            myControl = New Button
            myControl.Name = ControlName
            myControl.Tag = TagNumber
            myControl.Left = xx
            myControl.Top = yy
            myControl.Width = Width
            myControl.Height = Height
            myControl.Text = InitialValue
            'AddHandler myControl.Click, AddressOf myControl_Click
            myForm.Controls.Add(myControl)

        End If
        If UCase(ControlType) = "COMBOBOX" Then
            myControl = New ComboBox
            myControl.Name = ControlName
            myControl.Tag = TagNumber
            myControl.Left = xx
            myControl.Top = yy
            myControl.Width = Width
            myControl.Height = Height
            myControl.Text = InitialValue

            'AddHandler myControl.TextChanged, AddressOf myControl_textchanged
            myForm.Controls.Add(myControl)

        End If
        'NewOBJ = DirectCast(NewCombo, System.Windows.Forms.ComboBox)
        If UCase(ControlType) = "PICTUREBOX" Then
            myControl = New PictureBox
            myControl.Name = ControlName
            myControl.Tag = TagNumber
            myControl.Left = xx
            myControl.Top = yy
            myControl.Width = Width
            myControl.Height = Height
            'myControl.image = theImage
            myForm.Controls.Add(myControl)
        End If


    End Sub

    Function AddNewControl(CollectionKey As String, IsNewControl As Boolean, ScrollControlFrame As ScrollableControl, ControlDBTable As String,
                           ControlLeft As Integer, ControlTop As Integer, ControlWidth As Integer, ControlHeight As Integer,
                           ControlName As String, ControlType As String, TheControl As Control,
                           Optional MakeVisible As Boolean = True,
                           Optional ControlBACKCOLOURasRGBString As String = "AliceBlue",
                           Optional ControlForecolourasRGBString As String = "1,1,1",
                           Optional ByRef ListArray() As Object = Nothing,
                           Optional ControlText As String = "",
                           Optional ControlTAG As String = "",
                           Optional ControlFontName As String = "TAHOMA",
                           Optional ControlFontSize As Integer = 10,
                           Optional Fontstyle As String = "",
                           Optional TextAlign As String = "LEFT",
                           Optional LabelAlign As String = "TOP LEFT",
                           Optional MakeReadOnly As Boolean = False,
                           Optional AddComboList As Boolean = False,
                           Optional ControlFieldname As String = "",
                           Optional IDPrefix As String = "",
                           Optional ControlTABIndex As Long = 0,
                           Optional ControlDate As Date = #1970-01-01#,
                           Optional ControlUpdatedbyName As String = "",
                           Optional ControlOBJCount As Long = 0,
                           Optional ControlStartTAG As String = "",
                           Optional ControlEndTAG As String = "",
                           Optional ControlRowNumber As Long = 0,
                           Optional ControlTotalRows As Long = 0,
                           Optional ControlAddLeftMargin As Boolean = True,
                           Optional ByVal ControlStartDateTime As Date = #1970-01-01#,
                           Optional ByVal ControlEndDateTime As Date = #1970-01-01#,
                           Optional ControlPrimaryKey As Long = 0) As Long

        Dim ControlBACKCOLOUR As Color
        Dim ControlForeColour As Color
        Dim tempControl As New clsDG_NMS_Controls
        Dim NewControl As Control = Nothing
        Dim NewOBJ As Control
        Dim NewCombo As ComboBox
        Dim NewButton As Button
        Dim NewTextBox As TextBox
        Dim NewLabel As Label
        Dim IDX As Long
        Dim ControlFrameName As String
        'Dim font = New Font(tb_remark.Font, FontStyle.Italic)
        Dim NewFont As Font

        'On Error GoTo Err_AddNewControl
        If ScrollControlFrame IsNot Nothing Then
            ControlFrameName = ScrollControlFrame.Name
        Else
            ControlFrameName = "NA"
        End If
        'Set Dic_Collection = CreateObject("Scripting.Dictionary")
        'Dic_Collection.RemoveAll
        NewOBJ = Nothing
        If IsNewControl Then

            If UCase(ControlType) = "COMBOBOX" Then
                NewCombo = New ComboBox

                'NewOBJ = New ComboBox
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.ComboBox.1", ControlName, MakeVisible)
                NewCombo.Name = ControlName
                NewCombo.Top = ControlTop
                NewCombo.Left = ControlLeft
                NewCombo.Width = ControlWidth
                NewCombo.AutoSize = False
                NewCombo.TabIndex = ControlTABIndex
                Select Case UCase(Fontstyle)
                    Case "BOLD"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewCombo.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Regular)
                End Select
                NewCombo.Tag = ControlTAG
                NewCombo.Text = ControlText
                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewCombo.ForeColor = ControlForeColour
                'NewCombo.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBACKCOLOUR = DirectCast(New ColorConverter().ConvertFromString(ControlBACKCOLOURasRGBString), Color)
                NewCombo.BackColor = ControlBACKCOLOUR

                'NewCtrl.ControlAddLeftMargin does NOT exist in VB.NET - but padding does.
                If ControlHeight > 0 Then
                    NewCombo.Height = ControlHeight
                End If
                NewCombo.Items.Clear()

                If Not IsNothing(ListArray) Then
                    For IDX = 0 To UBound(ListArray)
                        If Len(ListArray(IDX)) > 0 Then
                            NewCombo.Items.Add(ListArray(IDX))
                        End If
                    Next
                End If
                'NewControl = DirectCast(NewOBJ, ComboBox)
                'NewControl = NewOBJ
                'AddHandler NewCombo.TextChanged, AddressOf NewCombo_textchanged

                tempControl.comboAfterUpdate = NewCombo
                tempControl.comboAfterUpdate2 = NewCombo
                tempControl.ControlBackColor = ControlBACKCOLOUR
                tempControl.ControlForeColor = ControlForeColour

                NewOBJ = DirectCast(NewCombo, System.Windows.Forms.ComboBox)
            End If


            If UCase(ControlType) = "BTN" Then
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.CommandButton.1", ControlName, MakeVisible)
                NewButton = New Button
                NewButton.Name = ControlName
                NewButton.Top = ControlTop
                NewButton.Left = ControlLeft
                NewButton.Width = ControlWidth
                NewButton.Tag = ControlTAG

                NewButton.Text = ControlText
                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewButton.ForeColor = ControlForeColour
                'NewButton.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBACKCOLOUR = DirectCast(New ColorConverter().ConvertFromString(ControlBACKCOLOURasRGBString), Color)
                NewButton.BackColor = ControlBACKCOLOUR

                NewButton.TabIndex = ControlTABIndex

                'can also use .FromName()
                'NewOBJ.BackColor = ControlBACKCOLOUR
                Select Case UCase(Fontstyle)
                    Case "BOLD"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewButton.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Regular)

                End Select
                'NewOBJ.Font = New Font(ControlFontName, ControlFontSize)
                'NewCtrl.SelectionMargin = ControlAddLeftMargin 'NOT applicable to BUttons !

                If ControlHeight > 0 Then
                    NewButton.Height = ControlHeight
                End If
                If MakeReadOnly Then
                    NewButton.Enabled = False
                End If
                'AddHandler NewButton.Click, AddressOf Newbutton_click
                If InStr(1, UCase(NewButton.Name), UCase("StartTime"), vbTextCompare) > 0 Then
                    'tempControl.cbTimeStartEvent = NewButton
                End If
                If InStr(1, UCase(NewButton.Name), UCase("FinishTime"), vbTextCompare) > 0 Then
                    'tempControl.cbTimeEndEvent = NewButton
                End If
                'If InStr(1, UCase(NewButton.Name), UCase("btnOperativeStartTime"), vbTextCompare) > 0 Then
                'tempControl.cbTimeStartEvent = NewButton
                'End If
                'If InStr(1, UCase(NewButton.Name), UCase("btnOperativeFinishTime"), vbTextCompare) > 0 Then
                'tempControl.cbTimeEndEvent = NewButton
                'End If
                tempControl.ControlBackColor = ControlBACKCOLOUR
                tempControl.ControlForeColor = ControlForeColour
                NewOBJ = DirectCast(NewButton, System.Windows.Forms.Button)
                'ScrollControlFrame.Controls.Add(NewButton)
                'If InStr(1, UCase(NewOBJ.Name), "START", vbTextCompare) > 0 Then
                'AddHandler NewOBJ.Click, AddressOf NewOBJ_click
                'tempControl.cbTimeStartEvent = NewOBJ
                'End If

                'If InStr(1, UCase(NewOBJ.Name), "END", vbTextCompare) > 0 Then
                'AddHandler NewOBJ.Click, AddressOf NewOBJ_click
                'tempControl.cbTimeEndEvent = NewOBJ
                'End If
            End If

            If UCase(ControlType) = "LABEL" Then
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.Textbox.1", ControlName, MakeVisible)
                NewLabel = New Label

                NewLabel.Name = ControlName
                NewLabel.Top = ControlTop
                NewLabel.Left = ControlLeft
                NewLabel.Width = ControlWidth
                NewLabel.AutoSize = True
                'NewTextBox.TextAlign = HorizontalAlignment.Center/.left/.right
                Select Case UCase(Fontstyle)
                    Case "BOLD"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewLabel.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Regular)
                End Select
                Select Case UCase(TextAlign)
                    Case "LEFT"

                End Select
                'NewOBJ.Font = New Font(ControlFontName, ControlFontSize)
                NewLabel.Tag = ControlTAG
                NewLabel.Text = ControlText

                If UCase(LabelAlign) = "BOTTOM LEFT" Then
                    NewLabel.TextAlign = ContentAlignment.BottomLeft
                ElseIf UCase(LabelAlign) = "BOTTOM CENTER" Then
                    NewLabel.TextAlign = ContentAlignment.BottomCenter
                ElseIf UCase(LabelAlign) = "BOTTOM RIGHT" Then
                    NewLabel.TextAlign = ContentAlignment.BottomRight
                ElseIf UCase(LabelAlign) = "MIDDLE LEFT" Then
                    NewLabel.TextAlign = ContentAlignment.MiddleLeft
                ElseIf UCase(LabelAlign) = "MIDDLE CENTER" Then
                    NewLabel.TextAlign = ContentAlignment.MiddleCenter
                ElseIf UCase(LabelAlign) = "MIDDLE RIGHT" Then
                    NewLabel.TextAlign = ContentAlignment.MiddleRight
                ElseIf UCase(LabelAlign) = "TOP LEFT" Then
                    NewLabel.TextAlign = ContentAlignment.TopLeft
                ElseIf UCase(LabelAlign) = "TOP CENTER" Then
                    NewLabel.TextAlign = ContentAlignment.TopCenter
                ElseIf UCase(LabelAlign) = "TOP RIGHT" Then
                    NewLabel.TextAlign = ContentAlignment.TopRight
                Else
                    NewLabel.TextAlign = ContentAlignment.MiddleCenter
                End If

                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewLabel.ForeColor = ControlForeColour
                'NewLabel.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBACKCOLOUR = DirectCast(New ColorConverter().ConvertFromString(ControlBACKCOLOURasRGBString), Color)
                NewLabel.BackColor = ControlBACKCOLOUR

                'NewCtrl.ControlAddLeftMargin does NOT exist in VB.NET - but padding does.
                If ControlHeight > 0 Then
                    NewLabel.Height = ControlHeight
                End If
                'txtBoxAfterUpdate_change in clsControls
                'tempControl.txtBoxAfterUpdate = NewTextBox
                'AddHandler NewTextBox.TextChanged, AddressOf NewTextBox_textchanged

                tempControl.ControlBackColor = ControlBACKCOLOUR
                tempControl.ControlForeColor = ControlForeColour

                NewOBJ = DirectCast(NewLabel, System.Windows.Forms.Label)
            End If

            If UCase(ControlType) = "TEXTBOX" Then
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.Textbox.1", ControlName, MakeVisible)
                NewTextBox = New TextBox

                NewTextBox.Name = ControlName
                NewTextBox.Top = ControlTop
                NewTextBox.Left = ControlLeft
                NewTextBox.Width = ControlWidth
                NewTextBox.AutoSize = False
                NewTextBox.TabIndex = ControlTABIndex
                'NewTextBox.TextAlign = HorizontalAlignment.Center/.left/.right
                Select Case UCase(Fontstyle)
                    Case "BOLD"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewTextBox.Font = New Font(ControlFontName, ControlFontSize, Drawing.FontStyle.Regular)
                End Select
                'NewOBJ.Font = New Font(ControlFontName, ControlFontSize)
                NewTextBox.Tag = ControlTAG
                NewTextBox.Text = ControlText

                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewTextBox.ForeColor = ControlForeColour
                'NewTextBox.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBACKCOLOUR = DirectCast(New ColorConverter().ConvertFromString(ControlBACKCOLOURasRGBString), Color)
                NewTextBox.BackColor = ControlBACKCOLOUR

                If UCase(TextAlign) = "LEFT" Then
                    NewTextBox.TextAlign = HorizontalAlignment.Left
                ElseIf UCase(TextAlign) = "CENTER" Then
                    NewTextBox.TextAlign = HorizontalAlignment.Center
                ElseIf UCase(TextAlign) = "RIGHT" Then
                    NewTextBox.TextAlign = HorizontalAlignment.Right
                Else
                    NewTextBox.TextAlign = HorizontalAlignment.Left
                End If
                'NewCtrl.ControlAddLeftMargin does NOT exist in VB.NET - but padding does.
                If ControlHeight > 0 Then
                    NewTextBox.Height = ControlHeight
                End If
                'txtBoxAfterUpdate_change in clsControls
                tempControl.txtBoxAfterUpdate = NewTextBox
                'AddHandler NewTextBox.TextChanged, AddressOf NewTextBox_textchanged

                If MakeReadOnly Then
                    NewTextBox.ReadOnly = True
                Else
                    NewTextBox.ReadOnly = False
                End If

                tempControl.ControlBackColor = ControlBACKCOLOUR
                tempControl.ControlForeColor = ControlForeColour

                NewOBJ = DirectCast(NewTextBox, System.Windows.Forms.TextBox)

            End If
            ScrollControlFrame.Controls.Add(NewOBJ)
        Else
            'FIXED CONTROLS done at Design-time:
            'Use Found Textbox - control passed through
            If UCase(ControlType) = "TEXTBOX" Then
                NewTextBox = New TextBox
                If TypeName(TheControl) = "TextBox" Then
                    NewTextBox = TheControl
                    tempControl.txtBoxAfterUpdate = NewTextBox
                    NewOBJ = DirectCast(NewTextBox, System.Windows.Forms.TextBox)
                Else
                    frmMain.logger.LogError("CONTROL_ERRORS_1_0.log", Application.StartupPath, "Wrong Type - TEXTBOX being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            ElseIf UCase(ControlType) = "LABEL" Then
                NewLabel = New Label
                If TypeName(TheControl) = "Label" Then
                    NewLabel = TheControl
                    NewOBJ = DirectCast(NewLabel, System.Windows.Forms.Label)
                Else
                    frmMain.logger.LogError("CONTROL_ERRORS_1_0.log", Application.StartupPath, "Wrong Type - LABEL being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            ElseIf UCase(ControlType) = "BTN" Then
                NewButton = New Button
                If TypeName(TheControl) = "Button" Then
                    NewButton = TheControl
                    NewOBJ = DirectCast(NewButton, System.Windows.Forms.Button)
                    'Need a static button event in clsControls:
                Else
                    frmMain.logger.LogError("CONTROL_ERRORS_1_0.log", Application.StartupPath, "Wrong Type - BUTTON being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If

            ElseIf UCase(ControlType) = "COMBOBOX" Then
                NewCombo = New ComboBox
                If TypeName(TheControl) = "ComboBox" Then
                    NewCombo = TheControl
                    If AddComboList Then
                        NewCombo.Items.Clear()

                        If Not IsNothing(ListArray) Then
                            For IDX = 0 To UBound(ListArray)
                                If Len(ListArray(IDX)) > 0 Then
                                    NewCombo.Items.Add(ListArray(IDX))
                                End If
                            Next
                        End If
                    End If
                    'AddHandler NewCombo.TextChanged, AddressOf NewCombo_textchanged
                    tempControl.comboAfterUpdate = NewCombo
                    NewOBJ = DirectCast(NewCombo, System.Windows.Forms.ComboBox)
                Else
                    'Control of wrong type here:
                    frmMain.logger.LogError("CONTROL_ERRORS_1_0.log", Application.StartupPath, "Wrong Type - TEXTBOX being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            End If
        End If

        If TheControl Is Nothing Then
            tempControl.TheControl = NewOBJ
        Else
            tempControl.TheControl = TheControl
        End If
        tempControl.ControlName = ControlName
        tempControl.ControlFrameName = ControlFrameName
        tempControl.ControlDBTable = ControlDBTable
        tempControl.ControlFieldName = ControlFieldname
        tempControl.ControlID = CollectionKey
        tempControl.ControlValue = ControlText
        tempControl.ControlType = ControlType
        tempControl.ControlTAG = ControlTAG
        tempControl.ControlTabIndex = ControlTABIndex
        tempControl.ControlDate = ControlDate
        tempControl.ControlLeft = ControlLeft
        tempControl.ControlTop = ControlTop
        tempControl.ControlWidth = ControlWidth
        tempControl.ControlHeight = ControlHeight
        tempControl.ControlObjNumber = ControlOBJCount
        tempControl.ControlStartTAG = ControlStartTAG
        tempControl.ControlEndTAG = ControlEndTAG
        tempControl.ControlFrameRowNumber = ControlRowNumber
        tempControl.ControlTotalRows = ControlTotalRows
        tempControl.ControlBackColor = ControlBACKCOLOUR
        tempControl.ControlForeColor = ControlForeColour
        'tempControl.ControlLeftMargin = ControlAddLeftMargin
        tempControl.ControlFontName = ControlFontName
        tempControl.ControlFontSize = ControlFontSize
        'tempControl.ControlUpdatedByEmpNo = controlUpdatedByEmpNo
        'tempControl.ControlUpdatedByUsername = Controlupdatedbyusername
        'tempControl.ControlUpdatedByName = controlupdatedbyname
        If ControlPrimaryKey > 0 Then
            tempControl.ControlPrimaryKey = ControlPrimaryKey
        End If
        'ctrlCollection.Add tempControl, tempControl.ControlTag
        'If Not InCollection("MISSING", ctrlCollection, CollectionKey) Then
        'ctrlCollection.Add tempControl, CollectionKey
        'End If
        If Not dic_Controls.Exists(CollectionKey) Then
            dic_Controls(CollectionKey) = tempControl
        Else
            dic_Controls(CollectionKey) = tempControl
        End If

        'Write_Properties_To_File("Property Log.log", tempControl)

        AddNewControl = AddNewControl + 1

        'Call Error_Report("AddNewControl")

    End Function

    Function AddNewControls(CollectionKey As String, IsNewControl As Boolean, ScrollControlFrame As ScrollableControl, TheControl As Control,
                            ctrlProperty As clsDG_NMS_Controls,
        Optional ByVal MakeVisible As Boolean = True, Optional ByRef ListArray() As Object = Nothing, Optional TextAlign As String = "LEFT",
        Optional LabelAlign As String = "MIDDLE CENTER", Optional MakeReadOnly As Boolean = False, Optional AddComboList As Boolean = False,
        Optional ControlForecolourasRGBString As String = "BLACK",
        Optional ControlBACKcolourasRGBString As String = "AliceBlue",
        Optional ByVal ControlStartDateTime As Date = #1970-01-01#, Optional ByVal ControlEndDateTime As Date = #1970-01-01#) As Long

        Dim tempControl As New clsDG_NMS_Controls
        Dim NewControl As Control = Nothing
        Dim NewOBJ As Control
        Dim NewCombo As New ComboBox
        Dim NewButton As New Button
        Dim NewTextBox As New TextBox
        Dim NewLabel As New Label
        Dim NewPictureBox As New PictureBox
        Dim IDX As Long
        Dim ControlFrameName As String
        Dim ControlBackColour As Color
        Dim ControlForeColour As Color
        'Dim font = New Font(tb_remark.Font, FontStyle.Italic)
        Dim NewFont As Font

        tempControl = ctrlProperty
        'On Error GoTo Err_AddNewControl
        If ScrollControlFrame IsNot Nothing Then
            ControlFrameName = ScrollControlFrame.Name
        Else
            ControlFrameName = "NA"
        End If
        'Set Dic_Collection = CreateObject("Scripting.Dictionary")
        'Dic_Collection.RemoveAll
        NewOBJ = Nothing
        If IsNewControl Then

            If UCase(tempControl.ControlType) = "COMBOBOX" Then
                NewCombo = New ComboBox

                'NewOBJ = New ComboBox
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.ComboBox.1", ControlName, MakeVisible)
                NewCombo.Name = tempControl.ControlName
                NewCombo.Top = tempControl.ControlTop
                NewCombo.Left = tempControl.ControlLeft
                NewCombo.Width = tempControl.ControlWidth
                NewCombo.AutoSize = False

                Select Case UCase(tempControl.ControlFontStyle)
                    Case "BOLD"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewCombo.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Regular)
                End Select
                NewCombo.Tag = tempControl.ControlTAG
                NewCombo.Text = tempControl.ControlValue

                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewCombo.ForeColor = ControlForeColour
                'NewCombo.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBackColour = DirectCast(New ColorConverter().ConvertFromString(ControlBACKcolourasRGBString), Color)
                NewCombo.BackColor = ControlBackColour
                'NewCombo.ForeColor = ColorTranslator.FromWin32(tempControl.ControlForeColor)
                'NewCombo.BackColor = ColorTranslator.FromWin32(tempControl.ControlBackColor)
                'NewCtrl.ControlAddLeftMargin does NOT exist in VB.NET - but padding does.
                If tempControl.ControlHeight > 0 Then
                    NewCombo.Height = tempControl.ControlHeight
                End If
                NewCombo.Items.Clear()

                If Not IsNothing(ListArray) Then
                    For IDX = 0 To UBound(ListArray)
                        If Len(ListArray(IDX)) > 0 Then
                            NewCombo.Items.Add(ListArray(IDX))
                        End If
                    Next
                End If
                'NewControl = DirectCast(NewOBJ, ComboBox)
                'NewControl = NewOBJ
                'AddHandler NewCombo.TextChanged, AddressOf NewCombo_textchanged

                tempControl.comboAfterUpdate = NewCombo
                tempControl.ControlForeColor = ControlForeColour
                tempControl.ControlBackColor = ControlBackColour

                NewOBJ = DirectCast(NewCombo, System.Windows.Forms.ComboBox)
            End If


            If UCase(tempControl.ControlType) = "BTN" Then
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.CommandButton.1", ControlName, MakeVisible)
                'NewOBJ = New Button
                NewButton.Name = tempControl.ControlName
                NewButton.Top = tempControl.ControlTop
                NewButton.Left = tempControl.ControlLeft
                NewButton.Width = tempControl.ControlWidth
                NewButton.Tag = tempControl.ControlTAG

                NewButton.Text = tempControl.ControlValue
                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewButton.ForeColor = ControlForeColour
                'NewButton.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBackColour = DirectCast(New ColorConverter().ConvertFromString(ControlBACKcolourasRGBString), Color)
                NewButton.BackColor = ControlBackColour

                'can also use .FromName()
                'NewOBJ.BackColor = ControlBACKCOLOUR
                Select Case UCase(tempControl.ControlFontStyle)
                    Case "BOLD"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewButton.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Regular)

                End Select
                'NewOBJ.Font = New Font(ControlFontName, ControlFontSize)
                'NewCtrl.SelectionMargin = ControlAddLeftMargin 'NOT applicable to BUttons !

                If tempControl.ControlHeight > 0 Then
                    NewButton.Height = tempControl.ControlHeight
                End If
                'AddHandler NewButton.Click, AddressOf Newbutton_click
                If InStr(1, UCase(NewButton.Name), UCase("StartTime"), vbTextCompare) > 0 Then
                    'tempControl.cbTimeStartEvent = NewButton
                End If
                If InStr(1, UCase(NewButton.Name), UCase("FinishTime"), vbTextCompare) > 0 Then
                    'tempControl.cbTimeEndEvent = NewButton
                End If
                'If InStr(1, UCase(NewButton.Name), UCase("btnOperativeStartTime"), vbTextCompare) > 0 Then
                'tempControl.cbTimeStartEvent = NewButton
                'End If
                'If InStr(1, UCase(NewButton.Name), UCase("btnOperativeFinishTime"), vbTextCompare) > 0 Then
                'tempControl.cbTimeEndEvent = NewButton
                'End If
                tempControl.ControlBackColor = ControlBackColour
                tempControl.ControlForeColor = ControlForeColour

                NewOBJ = DirectCast(NewButton, System.Windows.Forms.Button)
                'ScrollControlFrame.Controls.Add(NewButton)
                'If InStr(1, UCase(NewOBJ.Name), "START", vbTextCompare) > 0 Then
                'AddHandler NewOBJ.Click, AddressOf NewOBJ_click
                'tempControl.cbTimeStartEvent = NewOBJ
                'End If

                'If InStr(1, UCase(NewOBJ.Name), "END", vbTextCompare) > 0 Then
                'AddHandler NewOBJ.Click, AddressOf NewOBJ_click
                'tempControl.cbTimeEndEvent = NewOBJ
                'End If
            End If

            If UCase(tempControl.ControlType) = "LABEL" Then
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.Textbox.1", ControlName, MakeVisible)
                'NewOBJ = New TextBox

                NewLabel.Name = tempControl.ControlName
                NewLabel.Top = tempControl.ControlTop
                NewLabel.Left = tempControl.ControlLeft
                NewLabel.Width = tempControl.ControlWidth
                NewLabel.AutoSize = False
                'NewTextBox.TextAlign = HorizontalAlignment.Center/.left/.right
                Select Case UCase(tempControl.ControlFontStyle)
                    Case "BOLD"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewLabel.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Regular)
                End Select
                'NewOBJ.Font = New Font(ControlFontName, ControlFontSize)
                NewLabel.Tag = tempControl.ControlTAG
                NewLabel.Text = tempControl.ControlValue

                If UCase(LabelAlign) = "BOTTOM LEFT" Then
                    NewLabel.TextAlign = ContentAlignment.BottomLeft
                ElseIf UCase(LabelAlign) = "BOTTOM CENTER" Then
                    NewLabel.TextAlign = ContentAlignment.BottomCenter
                ElseIf UCase(LabelAlign) = "BOTTOM RIGHT" Then
                    NewLabel.TextAlign = ContentAlignment.BottomRight
                ElseIf UCase(LabelAlign) = "MIDDLE LEFT" Then
                    NewLabel.TextAlign = ContentAlignment.MiddleLeft
                ElseIf UCase(LabelAlign) = "MIDDLE CENTER" Then
                    NewLabel.TextAlign = ContentAlignment.MiddleCenter
                ElseIf UCase(LabelAlign) = "MIDDLE RIGHT" Then
                    NewLabel.TextAlign = ContentAlignment.MiddleRight
                ElseIf UCase(LabelAlign) = "TOP LEFT" Then
                    NewLabel.TextAlign = ContentAlignment.TopLeft
                ElseIf UCase(LabelAlign) = "TOP CENTER" Then
                    NewLabel.TextAlign = ContentAlignment.TopCenter
                ElseIf UCase(LabelAlign) = "TOP RIGHT" Then
                    NewLabel.TextAlign = ContentAlignment.TopRight
                Else
                    NewLabel.TextAlign = ContentAlignment.MiddleCenter
                End If

                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewLabel.ForeColor = ControlForeColour
                'NewLabel.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBackColour = DirectCast(New ColorConverter().ConvertFromString(ControlBACKcolourasRGBString), Color)
                NewLabel.BackColor = ControlBackColour
                'NewCtrl.ControlAddLeftMargin does NOT exist in VB.NET - but padding does.
                If tempControl.ControlHeight > 0 Then
                    NewLabel.Height = tempControl.ControlHeight
                End If
                'txtBoxAfterUpdate_change in clsControls
                'tempControl.txtBoxAfterUpdate = NewTextBox
                'AddHandler NewTextBox.TextChanged, AddressOf NewTextBox_textchanged
                tempControl.ControlBackColor = ControlBackColour
                tempControl.ControlForeColor = ControlForeColour

                NewOBJ = DirectCast(NewLabel, System.Windows.Forms.Label)
            End If

            If UCase(tempControl.ControlType) = "TEXTBOX" Then
                'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.Textbox.1", ControlName, MakeVisible)
                'NewOBJ = New TextBox

                NewTextBox.Name = tempControl.ControlName
                NewTextBox.Top = tempControl.ControlTop
                NewTextBox.Left = tempControl.ControlLeft
                NewTextBox.Width = tempControl.ControlWidth
                NewTextBox.AutoSize = False
                'NewTextBox.TextAlign = HorizontalAlignment.Center/.left/.right
                Select Case UCase(tempControl.ControlFontStyle)
                    Case "BOLD"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Bold)
                    Case "ITALIC"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic)
                    Case "STRIKEOUT"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Strikeout)
                    Case "UNDERLINE"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline)
                    Case "BOLD,UNDERLINE"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "UNDERLINE,BOLD"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Underline Or Drawing.FontStyle.Bold)
                    Case "BOLD,ITALIC"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case "ITALIC,BOLD"
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Italic Or Drawing.FontStyle.Bold)
                    Case Else
                        NewTextBox.Font = New Font(tempControl.ControlFontName, tempControl.ControlFontSize, Drawing.FontStyle.Regular)
                End Select
                'NewOBJ.Font = New Font(ControlFontName, ControlFontSize)
                NewTextBox.Tag = tempControl.ControlTAG
                NewTextBox.Text = tempControl.ControlValue
                ControlForeColour = DirectCast(New ColorConverter().ConvertFromString(ControlForecolourasRGBString), Color)
                NewTextBox.ForeColor = ControlForeColour
                'NewTextBox.ForeColor = ColorTranslator.FromWin32(ControlForecolor)
                ControlBackColour = DirectCast(New ColorConverter().ConvertFromString(ControlBACKcolourasRGBString), Color)
                NewTextBox.BackColor = ControlBackColour

                If UCase(TextAlign) = "LEFT" Then
                    NewTextBox.TextAlign = HorizontalAlignment.Left
                ElseIf UCase(TextAlign) = "CENTER" Then
                    NewTextBox.TextAlign = HorizontalAlignment.Center
                ElseIf UCase(TextAlign) = "RIGHT" Then
                    NewTextBox.TextAlign = HorizontalAlignment.Right
                Else
                    NewTextBox.TextAlign = HorizontalAlignment.Left
                End If
                'NewCtrl.ControlAddLeftMargin does NOT exist in VB.NET - but padding does.
                If tempControl.ControlHeight > 0 Then
                    NewTextBox.Height = tempControl.ControlHeight
                End If
                'txtBoxAfterUpdate_change in clsControls
                tempControl.txtBoxAfterUpdate = NewTextBox
                'AddHandler NewTextBox.TextChanged, AddressOf NewTextBox_textchanged

                If MakeReadOnly Then
                    NewTextBox.ReadOnly = True
                Else
                    NewTextBox.ReadOnly = False
                End If

                tempControl.ControlForeColor = ControlForeColour
                tempControl.ControlBackColor = ControlBackColour

                NewOBJ = DirectCast(NewTextBox, System.Windows.Forms.TextBox)

            End If
            ScrollControlFrame.Controls.Add(NewOBJ)
        Else
            'FIXED CONTROLS done at Design-time:
            'Use Found Textbox - control passed through
            If UCase(tempControl.ControlType) = "TEXTBOX" Then
                NewTextBox = New TextBox
                If TypeName(TheControl) = "TextBox" Then
                    NewTextBox = TheControl
                    tempControl.txtBoxAfterUpdate = NewTextBox
                    NewOBJ = DirectCast(NewTextBox, System.Windows.Forms.TextBox)
                Else
                    frmMain.logger.LogError("AddNewControls.log", Application.StartupPath, "Wrong Type - TEXTBOX being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            ElseIf UCase(tempControl.ControlType) = "LABEL" Then
                NewLabel = New Label
                If TypeName(TheControl) = "Label" Then
                    NewLabel = TheControl
                    NewOBJ = DirectCast(NewLabel, System.Windows.Forms.Label)
                Else
                    frmMain.logger.LogError("AddNewControls.log", Application.StartupPath, "Wrong Type - LABEL being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            ElseIf UCase(tempControl.ControlType) = "BTN" Then
                NewButton = New Button
                If TypeName(TheControl) = "Button" Then
                    NewButton = TheControl
                    NewOBJ = DirectCast(NewButton, System.Windows.Forms.Button)
                    'Need a static button event in clsControls:
                Else
                    frmMain.logger.LogError("AddNewControls.log", Application.StartupPath, "Wrong Type - BUTTON being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            ElseIf UCase(tempControl.ControlType) = "PICTUREBOX" Then
                NewPictureBox = New PictureBox
                If TypeName(TheControl) = "PictureBox" Then
                    NewPictureBox = TheControl
                    NewOBJ = DirectCast(NewPictureBox, System.Windows.Forms.PictureBox)

                Else
                    frmMain.logger.LogError("AddNewControls.log", Application.StartupPath, "Wrong Type - PICTUREBOX being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            ElseIf UCase(tempControl.ControlType) = "COMBOBOX" Then
                NewCombo = New ComboBox
                If TypeName(TheControl) = "ComboBox" Then
                    NewCombo = TheControl
                    If AddComboList Then
                        NewCombo.Items.Clear()

                        If Not IsNothing(ListArray) Then
                            For IDX = 0 To UBound(ListArray)
                                If Len(ListArray(IDX)) > 0 Then
                                    NewCombo.Items.Add(ListArray(IDX))
                                End If
                            Next
                        End If
                    End If
                    'AddHandler NewCombo.TextChanged, AddressOf NewCombo_textchanged
                    tempControl.comboAfterUpdate = NewCombo
                    NewOBJ = DirectCast(NewCombo, System.Windows.Forms.ComboBox)
                Else
                    'Control of wrong type here:
                    frmMain.logger.LogError("AddNewControls.log", Application.StartupPath, "Wrong Type - TEXTBOX being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED OUT:" & frmMain.myUsername)
                End If
            End If
        End If

        tempControl.TheControl = NewOBJ
        tempControl.ControlFrameName = ControlFrameName
        tempControl.ControlID = CollectionKey

        'ctrlCollection.Add tempControl, tempControl.ControlTag
        'If Not InCollection("MISSING", ctrlCollection, CollectionKey) Then
        'ctrlCollection.Add tempControl, CollectionKey
        'End If
        If Not dic_Controls.Exists(CollectionKey) Then
            dic_Controls(CollectionKey) = tempControl
        Else
            dic_Controls(CollectionKey) = tempControl
        End If

        Return AddNewControls + 1

        'Call Error_Report("AddNewControls")

    End Function

    Function AddNewPictureBox(CollectionKey As String, IsNewControl As Boolean, TheImage As Image, TheControl As Control,
                              ControlName As String, ControlLeft As Integer, ControlTop As Integer, ControlWidth As Integer,
                              ControlHeight As Integer, ControlTag As String,
                              Optional ControlFrameName As ScrollableControl = Nothing,
                              Optional ControlImageLayout As String = "STRETCH",
                              Optional ControlBACKCOLOURasRGBString As String = "AliceBlue") As Long
        Dim NewOBJ As Control
        Dim tempControl As New clsDG_NMS_Controls
        Dim NewBox As PictureBox
        Dim ControlBACKCOLOUR As Color

        NewOBJ = Nothing
        If IsNewControl Then

            'Set NewCtrl = TheUserform.Frame_Operatives.Controls.Add("Forms.CommandButton.1", ControlName, MakeVisible)
            NewBox = New PictureBox
            NewBox.Name = ControlName
            NewBox.Top = ControlTop
            NewBox.Left = ControlLeft
            NewBox.Width = ControlWidth
            NewBox.Tag = ControlTag
            NewBox.AllowDrop = True

            If ControlHeight > 0 Then
                NewBox.Height = ControlHeight
            End If
            If TheImage Is Nothing Then
                NewBox.BackgroundImage = Nothing
            Else
                NewBox.BackgroundImage = TheImage
            End If
            If UCase(ControlImageLayout) = "TILE" Then
                NewBox.BackgroundImageLayout = ImageLayout.Tile
            ElseIf UCase(ControlImageLayout) = "STRETCH" Then
                NewBox.BackgroundImageLayout = ImageLayout.Stretch
            ElseIf UCase(ControlImageLayout) = "ZOOM" Then
                NewBox.BackgroundImageLayout = ImageLayout.Zoom
            ElseIf UCase(ControlImageLayout) = "CENTER" Then
                NewBox.BackgroundImageLayout = ImageLayout.Center
            Else
                NewBox.BackgroundImageLayout = ImageLayout.None
            End If

            tempControl.PictureBoxClick = NewBox
            tempControl.PictureBoxDragTarget = NewBox
            tempControl.ControlImage = TheImage
            'tempControl.PictureBoxTargetMouseDown = NewBox
            tempControl.PictureBoxTargetMouseOver = NewBox
            tempControl.PictureBoxTargetLeave = NewBox
            NewOBJ = DirectCast(NewBox, System.Windows.Forms.PictureBox)

            If ControlFrameName IsNot Nothing Then
                ControlFrameName.Controls.Add(NewOBJ)
            End If
        Else
            'FIXED CONTROLS done at Design-time:
            'Use Found Textbox - control passed through
            NewBox = New PictureBox
            If TypeName(TheControl) = "PictureBox" Then
                NewBox = TheControl
                If TheImage Is Nothing Then
                    NewBox.BackgroundImage = TheControl.BackgroundImage
                Else
                    NewBox.BackgroundImage = TheImage
                End If
                NewBox.BackgroundImageLayout = TheControl.BackgroundImageLayout
                NewBox.Left = TheControl.Left
                NewBox.Top = TheControl.Top
                NewBox.Width = TheControl.Width
                NewBox.Height = TheControl.Height
                NewBox.Tag = TheControl.Tag
                NewBox.AllowDrop = True
                If Len(ControlName) = 0 Then
                    NewBox.Name = TheControl.Name
                Else
                    NewBox.Name = ControlName
                End If
                ControlBACKCOLOUR = DirectCast(New ColorConverter().ConvertFromString(ControlBACKCOLOURasRGBString), Color)
                tempControl.PictureBoxClick = NewBox
                tempControl.PictureBoxDragTarget = NewBox
                'tempControl.PictureBoxTargetMouseDown = NewBox
                tempControl.PictureBoxTargetMouseOver = NewBox
                tempControl.PictureBoxTargetLeave = NewBox

                NewOBJ = DirectCast(NewBox, System.Windows.Forms.PictureBox)
            Else
                frmMain.logger.LogError("NMS_ERRORS_1_0.log", Application.StartupPath, "Wrong Type - PICTUREBOX being cast to:" & TypeName(TheControl), "AddNewControl()", frmMain.GetComputerName() & "," & frmMain.GetIPv4Address() & "," & frmMain.GetIPv6Address() & ", OPERATOR LOGGED IN:" & frmMain.myUsername)
                Exit Function
            End If
        End If

        tempControl.TheControl = NewOBJ
        tempControl.ControlName = NewOBJ.Name
        tempControl.ControlTop = NewOBJ.Top
        tempControl.ControlLeft = NewOBJ.Left
        tempControl.ControlWidth = NewOBJ.Width
        tempControl.ControlHeight = NewOBJ.Height
        tempControl.ControlTAG = NewOBJ.Tag
        tempControl.ControlFrameName = ControlFrameName.Name
        tempControl.ControlID = CollectionKey
        tempControl.ControlBackColor = ControlBACKCOLOUR

        If Not dic_Controls.Exists(CollectionKey) Then
            dic_Controls(CollectionKey) = tempControl
        Else
            dic_Controls(CollectionKey) = tempControl
        End If

        Return AddNewPictureBox + 1
    End Function

    Function UpdateCollection(ByRef coll As Object, NewKey As String, ValueToChange As Object,
                              Optional TAGNUMBER As String = "", Optional PropertyToChange As String = "VALUE") As Object
        Dim tempControl As New clsDG_NMS_Controls
        Dim myDateTime As DateTime

        UpdateCollection = Nothing

        tempControl = Nothing
        If Not coll.exists(NewKey) Then
            MsgBox("KEY NOT AVAILABLE: " & NewKey)
            Exit Function
        End If

        If Not coll Is Nothing Then
            If Len(NewKey) > 0 And ValueToChange IsNot Nothing Then
                tempControl = coll.Item(NewKey)
                'tempControl = coll(NewKey)
                'tempControl.ControlObject = Nothing
                If UCase(PropertyToChange) = "VALUE" Then
                    If IsNumeric(ValueToChange) Then
                        tempControl.ControlValue = ValueToChange.ToString
                    ElseIf IsDate(ValueToChange) Then
                        myDateTime = ValueToChange
                        tempControl.ControlValue = ValueToChange.ToString
                    Else
                        tempControl.ControlValue = ValueToChange.ToString
                    End If
                ElseIf UCase(PropertyToChange) = "FIELDNAME" Then
                    tempControl.ControlFieldName = ValueToChange
                ElseIf UCase(PropertyToChange) = "CONTROLNAME" Then
                    tempControl.ControlName = ValueToChange
                ElseIf UCase(PropertyToChange) = "FRAMENAME" Then
                    tempControl.ControlFrameName = ValueToChange
                ElseIf UCase(PropertyToChange) = "STARTTAG" Then
                    tempControl.ControlStartTAG = ValueToChange
                ElseIf UCase(PropertyToChange) = "ENDTAG" Then
                    tempControl.ControlEndTAG = ValueToChange
                ElseIf UCase(PropertyToChange) = "LASTSAVED" Then
                    tempControl.ControlLastSaved = ValueToChange
                ElseIf UCase(PropertyToChange) = "CONTROLLIST" Then
                    tempControl.ControlList = ValueToChange
                ElseIf UCase(PropertyToChange) = "BACKCOLOR" Then
                    tempControl.ControlBackColor = ValueToChange
                ElseIf UCase(PropertyToChange) = "FORECOLOR" Then
                    tempControl.ControlForeColor = ValueToChange
                ElseIf UCase(PropertyToChange) = "FONTNAME" Then
                    tempControl.ControlFontName = ValueToChange
                ElseIf UCase(PropertyToChange) = "FONTSIZE" Then
                    tempControl.ControlFontSize = ValueToChange
                ElseIf UCase(PropertyToChange) = "PRIMARYKEY" Then
                    tempControl.ControlPrimaryKey = ValueToChange
                ElseIf UCase(PropertyToChange) = "DBTABLE" Then
                    tempControl.ControlDBTable = ValueToChange
                ElseIf UCase(PropertyToChange) = "TAG" Then
                    tempControl.ControlTAG = ValueToChange
                ElseIf UCase(PropertyToChange) = "TOTALROWS" Then
                    tempControl.ControlTotalRows = ValueToChange
                ElseIf UCase(PropertyToChange) = "ROWNUMBER" Then
                    tempControl.ControlFrameRowNumber = ValueToChange
                ElseIf UCase(PropertyToChange) = "TOP" Then
                    tempControl.ControlTop = ValueToChange
                ElseIf UCase(PropertyToChange) = "LEFT" Then
                    tempControl.ControlLeft = ValueToChange
                ElseIf UCase(PropertyToChange) = "WIDTH" Then
                    tempControl.ControlWidth = ValueToChange
                ElseIf UCase(PropertyToChange) = "HEIGHT" Then
                    tempControl.ControlHeight = ValueToChange
                ElseIf UCase(PropertyToChange) = "THECONTROL" Then
                    If tempControl IsNot Nothing Then
                        tempControl.TheControl = ValueToChange
                    End If
                Else
                    tempControl.ControlValue = ValueToChange
                End If
                'coll.Remove(NewKey)
                'coll.Add(tempControl, NewKey)
                coll(NewKey) = tempControl
            Else
                MsgBox("Property Key is empty - cannot update Value: " & ValueToChange.ToString)
            End If
        End If

        UpdateCollection = coll
    End Function

End Module
