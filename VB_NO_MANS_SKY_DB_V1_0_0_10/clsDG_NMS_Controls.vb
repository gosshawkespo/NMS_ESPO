Public Class clsDG_NMS_Controls
    Public WithEvents comboAfterUpdate As ComboBox
    Public WithEvents comboAfterUpdate2 As ComboBox
    Public WithEvents txtBoxAfterUpdate As TextBox
    Public WithEvents PictureBoxClick As PictureBox
    Public WithEvents PictureBoxDragTarget As PictureBox
    Public WithEvents PictureBoxTargetMouseDown As PictureBox
    Public WithEvents PictureBoxTargetMouseOver As PictureBox
    Public WithEvents PictureBoxTargetLeave As PictureBox
    Private _CtrlID As String
    Private _CTRL As Control
    Private _CtrlOBJECT As Object
    Private _CtrlName As String
    Private _CtrlFrameName As String
    Private _CtrlFrameRowNumber As Long
    Private _CtrlTotalRows As Long
    Private _CtrlTag As String
    Private _CtrlDate As Date
    Private _CtrlLeft As Integer
    Private _CtrlTop As Integer
    Private _CtrlWidth As Integer
    Private _CtrlHeight As Integer
    Private _CtrlType As String
    Private _CtrlObjNumber As Long 'Count Number of Objects within one FRAME control = Number of CHILD RECORDS in Database
    Private _CtrlValue As String
    Private _CtrlList As Object
    Private _CtrlStartTag As String
    Private _CtrlEndTag As String
    Private _CtrlFieldName As String
    Private _CtrlLastSaved As Date
    Private _CtrlBackColour As Color
    Private _CtrlLeftMargin As Boolean
    Private _CtrlErrMessage As String
    Private _CtrlPrimaryKey As Long
    Private _CtrlFontName As String
    Private _CtrlFontSize As Integer
    Private _CtrlForeColour As Color
    Private _CtrlFontStyle As String
    Private _CtrlUpdatedByUsername As String
    Private _CtrlUpdatedByEmpNo As String
    Private _CtrlUpdatedByName As String
    Private _CtrlTabIndex As Long
    Private _CtrlEnableControl As Boolean
    Private _txtboxNameOfChangedValue As String
    Private _comboNameOfChangedValue As String
    Private _txtboxTagOfChangedValue As String
    Private _comboTagOfChangedValue As String
    Private _txtboxChangedValue As String
    Private _comboChangedValue As String
    Private _CtrlDBTable As String
    Private _CtrlImage As Image
    Private _CtrlGlyphSelected As String
    Private _CtrlGlyphImageSelected As Image
    Public Shared ThemeSelection As Integer = 1

    Private Sub PictureBoxTargetLeave_Leave(sender As Object, e As EventArgs) Handles PictureBoxTargetLeave.Leave
        PictureBoxTargetLeave.BorderStyle = BorderStyle.None
    End Sub

    Private Sub PictureBoxTargetMouseDown_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBoxTargetMouseDown.MouseDown
        'The following gives a null value:
        PictureBoxTargetMouseDown.DoDragDrop(PictureBoxTargetMouseDown.BackgroundImage, DragDropEffects.Copy)
    End Sub

    Private Sub PictureBoxTargetMouseOver_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBoxTargetMouseOver.MouseMove
        Dim ControlName As String
        Dim ControlTAG As String

        ControlName = PictureBoxTargetMouseOver.Name
        ControlTAG = PictureBoxTargetMouseOver.Tag
        clsInsertValueIntoForm(PictureBoxTargetMouseOver.FindForm().Name, "txtGlyphUnderMouse", ControlTAG)

    End Sub

    ' Unhighlight the control.
    Private Sub PictureBoxDragTarget_DragLeave(ByVal sender As _
    System.Object, ByVal e As System.EventArgs) Handles _
    PictureBoxDragTarget.DragLeave
        PictureBoxDragTarget.BorderStyle = BorderStyle.None
    End Sub

    'In the DragDrop event, get the dropped data And do whatever Is appropriate with it.

    ' Perform the drop.
    Private Sub PictureBoxDragTarget_DragDrop(ByVal sender As _
    System.Object, ByVal e As _
    System.Windows.Forms.DragEventArgs) Handles PictureBoxDragTarget.DragDrop
        Dim FoundControl As Control
        Dim FoundGlyphControl As Control
        Dim SelectedGlyph As String
        Dim tempControl As clsDG_NMS_Controls
        Dim FrameControl As Control
        Dim TxtboxGlyphSelected As Control
        Dim TagName As String
        Dim pbTemp As PictureBox = DirectCast(
        e.Data.GetData(GetType(PictureBox)), PictureBox)

        If pbTemp IsNot Nothing Then
            Me.ControlTAG = pbTemp.Tag
            If InStr(UCase(Me.ControlName), "GLYPH") Then
                'THIS controlkey in dic_Controls() collection being saved = Selected GLYPH
                'code needed to loop through all controls in dic_controls and UPDATE with the ControlGlyphSelected property in every one.
                'find the textbox on this form that will store the glyph code selected:
                'FoundControl = Me.clsFindControl(myPbox.Parent, "txtSelectedGlyphIndex")
                clsInsertValueIntoForm(pbTemp.FindForm().Name, "txtSelectedGlyphIndex", pbTemp.Tag)
                Me.ControlGlyphImageSelected = pbTemp.BackgroundImage
                Me.ControlGlyphSelected = pbTemp.Tag
            End If
            If InStr(UCase(Me.ControlName), "PB") Then
                FrameControl = Me.clsFindFormControl(pbTemp.FindForm().Name, "Frame_PlanetGlyphPallet")
                TxtboxGlyphSelected = Me.clsFindFormControl(pbTemp.FindForm().Name, "txtSelectedGlyphIndex")
                TagName = TxtboxGlyphSelected.Text
                FoundGlyphControl = Me.clsFindControl(FrameControl, "", TagName)
                If FoundGlyphControl IsNot Nothing Then
                    pbTemp.BackgroundImage = FoundGlyphControl.BackgroundImage
                    pbTemp.BackgroundImageLayout = ImageLayout.Stretch
                    pbTemp.Tag = TagName
                    Me.TheControl = pbTemp
                    Me.ControlTAG = TagName
                End If
            End If
        End If
        PictureBoxDragTarget.BackgroundImage = pbTemp.BackgroundImage
        PictureBoxDragTarget.BackColor = pbTemp.BackColor
        PictureBoxDragTarget.BorderStyle = BorderStyle.Fixed3D
    End Sub


    Private Sub PictureBoxClick_click(sender As Object, e As System.EventArgs) Handles PictureBoxClick.Click
        Dim myPbox As PictureBox
        Dim FoundControl As Control
        Dim FoundGlyphControl As Control
        Dim SelectedGlyph As String
        Dim tempControl As clsDG_NMS_Controls
        Dim FrameControl As Control
        Dim TxtboxGlyphSelected As Control
        Dim TagName As String

        'This event is activated when ANY PictureBox control is clicked.

        'MsgBox("In picture box control")
        If TypeOf (sender) Is System.Windows.Forms.PictureBox Then
            myPbox = CType(sender, System.Windows.Forms.PictureBox)
            'INSERT VALUE INTO FORM:
            If myPbox IsNot Nothing Then
                Me.ControlTAG = myPbox.Tag
                If myPbox.BorderStyle = BorderStyle.None Then
                    myPbox.BorderStyle = BorderStyle.Fixed3D
                    myPbox.Refresh()
                Else
                    myPbox.BorderStyle = BorderStyle.None
                    myPbox.Refresh()

                End If

                If InStr(UCase(Me.ControlName), "GLYPH") Then
                    'THIS controlkey in dic_Controls() collection being saved = Selected GLYPH
                    'code needed to loop through all controls in dic_controls and UPDATE with the ControlGlyphSelected property in every one.
                    'find the textbox on this form that will store the glyph code selected:
                    'FoundControl = Me.clsFindControl(myPbox.Parent, "txtSelectedGlyphIndex")
                    clsInsertValueIntoForm(myPbox.FindForm().Name, "txtSelectedGlyphIndex", myPbox.Tag)
                    Me.ControlGlyphImageSelected = myPbox.BackgroundImage
                    Me.ControlGlyphSelected = myPbox.Tag
                    myPbox.Focus()
                End If
                If InStr(UCase(Me.ControlName), "PB") Then
                    FrameControl = Me.clsFindFormControl(myPbox.FindForm().Name, "Frame_PlanetGlyphPallet")
                    TxtboxGlyphSelected = Me.clsFindFormControl(myPbox.FindForm().Name, "txtSelectedGlyphIndex")
                    TagName = TxtboxGlyphSelected.Text
                    FoundGlyphControl = Me.clsFindControl(FrameControl, "", TagName) 'Locate GLYPH within glyph pallet.
                    If FoundGlyphControl IsNot Nothing Then
                        myPbox.BackgroundImage = FoundGlyphControl.BackgroundImage
                        myPbox.BackgroundImageLayout = ImageLayout.Stretch
                        myPbox.Tag = TagName
                        Me.TheControl = myPbox
                        Me.ControlTAG = TagName
                        myPbox.Focus()

                    End If
                End If
            End If
        End If
    End Sub

    Public Sub CreatePlanetCode()
        Dim loopy As Integer
        Dim FrameControl As Control

        'FrameControl = Me.clsFindFormControl(myPbox.FindForm().Name, "Frame_PlanetGlyphPallet")

        loopy = 0

    End Sub

    Public Property ControlErrMessage() As String
        Get
            Return _CtrlErrMessage
        End Get
        Set(value As String)
            _CtrlErrMessage = value
        End Set
    End Property

    Public Property ControlGlyphSelected() As String
        Get
            Return _CtrlGlyphSelected
        End Get
        Set(value As String)
            _CtrlGlyphSelected = value
        End Set
    End Property

    Public Property ControlGlyphImageSelected() As Image
        Get
            Return _CtrlGlyphImageSelected
        End Get
        Set(value As Image)
            _CtrlGlyphImageSelected = value
        End Set
    End Property

    Public Property ControlTabIndex() As Long
        Get
            Return _CtrlTabIndex
        End Get
        Set(value As Long)
            _CtrlTabIndex = value
        End Set
    End Property

    Public Property ControlImage() As Image
        Get
            Return _CtrlImage
        End Get
        Set(value As Image)
            _CtrlImage = value
        End Set
    End Property

    Public Property TextboxName() As String
        Get
            Return _txtboxNameOfChangedValue
        End Get
        Set(value As String)
            _txtboxNameOfChangedValue = value
        End Set
    End Property

    Public Property ComboBoxName() As String
        Get
            Return _comboNameOfChangedValue
        End Get
        Set(value As String)
            _comboNameOfChangedValue = value
        End Set
    End Property

    Public Property TextBoxTAG() As String
        Get
            Return _txtboxTagOfChangedValue
        End Get
        Set(value As String)
            _txtboxTagOfChangedValue = value
        End Set
    End Property
    '_CtrlOBJECT

    Public Property ControlObject() As Object
        Get
            Return _CtrlOBJECT
        End Get
        Set(value As Object)
            _CtrlOBJECT = value
        End Set
    End Property

    Public Property ComboTAG() As String
        Get
            Return _comboTagOfChangedValue
        End Get
        Set(value As String)
            _comboTagOfChangedValue = value
        End Set
    End Property

    Public Property TextBoxValue() As String
        Get
            Return _txtboxChangedValue
        End Get
        Set(value As String)
            _txtboxChangedValue = value
        End Set
    End Property

    Public Property ComboValue() As String
        Get
            Return _comboChangedValue
        End Get
        Set(value As String)
            _comboChangedValue = value
        End Set
    End Property

    Public Property ControlID() As String
        Get
            Return _CtrlID
        End Get
        Set(value As String)
            _CtrlID = value
        End Set
    End Property

    Public Property TheControl() As Control
        Get
            Return _CTRL
        End Get
        Set(value As Control)
            _CTRL = value
        End Set
    End Property

    Public Property ControlName() As String
        Get
            Return _CtrlName
        End Get
        Set(value As String)
            _CtrlName = value
        End Set
    End Property

    Public Property ControlFrameName() As String
        Get
            Return _CtrlFrameName
        End Get
        Set(value As String)
            _CtrlFrameName = value
        End Set
    End Property

    Public Property ControlTAG() As String
        Get
            Return _CtrlTag
        End Get
        Set(value As String)
            _CtrlTag = value
        End Set
    End Property

    Public Property ControlDate() As Date
        Get
            Return _CtrlDate
        End Get
        Set(value As Date)
            _CtrlDate = value
        End Set
    End Property

    Public Property ControlLeft() As Integer
        Get
            Return _CtrlLeft
        End Get
        Set(value As Integer)
            _CtrlLeft = value
        End Set
    End Property

    Public Property ControlTop() As Integer
        Get
            Return _CtrlTop
        End Get
        Set(value As Integer)
            _CtrlTop = value
        End Set
    End Property

    Public Property ControlWidth() As Integer
        Get
            Return _CtrlWidth
        End Get
        Set(value As Integer)
            _CtrlWidth = value
        End Set
    End Property

    Public Property ControlHeight() As Integer
        Get
            Return _CtrlHeight
        End Get
        Set(value As Integer)
            _CtrlHeight = value
        End Set
    End Property

    Public Property ControlType() As String
        Get
            Return _CtrlType
        End Get
        Set(value As String)
            _CtrlType = value
        End Set
    End Property

    Public Property ControlObjNumber() As Long
        Get
            Return _CtrlObjNumber
        End Get
        Set(value As Long)
            _CtrlObjNumber = value
        End Set
    End Property

    Public Property ControlValue() As String
        Get
            Return _CtrlValue
        End Get
        Set(value As String)
            _CtrlValue = value
        End Set
    End Property

    Public Property ControlList() As Object
        Get
            Return _CtrlList
        End Get
        Set(value As Object)
            _CtrlList = value
        End Set
    End Property

    Public Property ControlStartTAG() As String
        Get
            Return _CtrlStartTag
        End Get
        Set(value As String)
            _CtrlStartTag = value
        End Set
    End Property

    Public Property ControlEndTAG() As String
        Get
            Return _CtrlEndTag
        End Get
        Set(value As String)
            _CtrlEndTag = value
        End Set
    End Property

    Public Property ControlFrameRowNumber() As Long
        Get
            Return _CtrlFrameRowNumber
        End Get
        Set(value As Long)
            _CtrlFrameRowNumber = value
        End Set
    End Property

    Public Property ControlTotalRows() As Long
        Get
            Return _CtrlTotalRows
        End Get
        Set(value As Long)
            _CtrlTotalRows = value
        End Set
    End Property

    Public Property ControlDBTable() As String
        Get
            Return _CtrlDBTable
        End Get
        Set(value As String)
            _CtrlDBTable = value
        End Set
    End Property

    Public Property ControlFieldName() As String
        Get
            Return _CtrlFieldName
        End Get
        Set(value As String)
            _CtrlFieldName = value
        End Set
    End Property

    Public Property ControlLastSaved() As Date
        Get
            Return _CtrlLastSaved
        End Get
        Set(value As Date)
            _CtrlLastSaved = value
        End Set
    End Property

    Public Property ControlBackColor() As Color
        Get
            Return _CtrlBackColour
        End Get
        Set(value As Color)
            _CtrlBackColour = value
        End Set
    End Property

    Public Property ControlForeColor() As Color
        Get
            Return _CtrlForeColour
        End Get
        Set(value As Color)
            _CtrlForeColour = value
        End Set
    End Property

    Public Property ControlFontStyle() As String
        Get
            Return _CtrlFontStyle
        End Get
        Set(value As String)
            _CtrlFontStyle = value
        End Set
    End Property

    Public Property ControlFontName() As String
        Get
            Return _CtrlFontName
        End Get
        Set(value As String)
            _CtrlFontName = value
        End Set
    End Property

    Public Property ControlFontSize() As Integer
        Get
            Return _CtrlFontSize
        End Get
        Set(value As Integer)
            _CtrlFontSize = value
        End Set
    End Property

    Public Property ControlPrimaryKey() As Long
        Get
            Return _CtrlPrimaryKey
        End Get
        Set(value As Long)
            _CtrlPrimaryKey = value
        End Set
    End Property

    Public Function clsFindControl(ByVal parent As Control, ByVal ControlName As String, Optional ByVal ControlTAG As String = "") As Control
        Dim ControlIDX As Integer
        Dim tmpctrl As Control
        Dim tmpctrl2 As Control
        For ControlIDX = 0 To parent.Controls.Count - 1
            tmpctrl = parent.Controls(ControlIDX)
            If Len(ControlName) > 0 Then
                If UCase(tmpctrl.Name) = UCase(ControlName) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = clsFindControl(tmpctrl, ControlName, "")
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
            If Len(ControlTAG) > 0 Then
                If UCase(tmpctrl.Tag) = UCase(ControlTAG) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = clsFindControl(tmpctrl, "", ControlTAG)
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
        Next
        ' Not found
        Return Nothing
    End Function

    Sub clsInsertValueIntoForm(FormName As String, ControlName As String, value As String,
                            Optional ByRef comArray As Object = Nothing,
                            Optional NewFormTitle As String = "")
        Dim ctrl As Object
        Dim ctrls() As Control
        Dim comboCtrl As ComboBox
        Dim comboArr() As String
        Dim IDX As Long
        Dim FoundForm As Boolean = False
        Dim ErrMessage As String

        ReDim ctrls(1)
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(FormName) Then
                FoundForm = True
                If Len(NewFormTitle) > 0 Then
                    'frm.Text = NewFormTitle
                    Application.OpenForms.Item(FormName).Text = NewFormTitle
                End If
                ctrls = frm.Controls.Find(ControlName, True)
                Exit For
            End If
        Next
        If ctrls IsNot Nothing And UBound(ctrls) > -1 Then
            If ctrls(0) Is Nothing Then
                If FoundForm = False Then
                    ErrMessage = "Error: Cannot Find Form Passed"
                    Exit Sub
                Else
                    ErrMessage = "Error: Cannot Find CONTROL Passed"
                    Exit Sub
                End If
            End If
            ctrl = ctrls(0)
            If InStr(ctrl.Name, "com") > 0 Then
                'the control is a combobox. Needs to be filled:
                If Not comArray Is Nothing Then
                    comboCtrl = CType(ctrl, System.Windows.Forms.ComboBox)
                    'comboCtrl = CType(ctrl, comarray)
                    comboCtrl.Items.Clear()

                    For IDX = 0 To UBound(comArray)
                        If comArray(IDX) IsNot Nothing Then
                            comboCtrl.Items.Add(comArray(IDX))
                        End If
                    Next

                Else

                End If
                ctrl.text = value
            ElseIf InStr(ctrl.name, "btn") > 0 Then

            Else
                ctrl.Text = value
            End If
            Application.DoEvents()
        Else
            MsgBox("Could not find Control: " & ControlName)
        End If
    End Sub

    Function clsFindFormControl(FormName As String, ControlName As String) As Control
        Dim ctrl As Control
        Dim ctrls() As Control
        Dim IDX As Long
        Dim FoundForm As Boolean = False
        Dim ErrMessage As String

        clsFindFormControl = Nothing
        ReDim ctrls(1)
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(FormName) Then
                FoundForm = True
                ctrls = frm.Controls.Find(ControlName, True)
                Exit For
            End If
        Next
        If ctrls IsNot Nothing And UBound(ctrls) > -1 Then
            If ctrls(0) Is Nothing Then
                If FoundForm = False Then
                    ErrMessage = "Error: Cannot Find Form Passed"
                    Me.ControlErrMessage = ErrMessage
                    Exit Function
                Else
                    ErrMessage = "Error: Cannot Find CONTROL Passed"
                    Me.ControlErrMessage = ErrMessage
                    Exit Function
                End If
            End If
            ctrl = ctrls(0)
            clsFindFormControl = ctrl
        End If

    End Function

    Public Function clsFindControl_Recursive(ByVal parent As Control, ByVal ControlName As String, Optional ByVal ControlTAG As String = "") As Control
        Dim ControlIDX As Integer
        Dim tmpctrl As Control
        Dim tmpctrl2 As Control
        For ControlIDX = 0 To parent.Controls.Count - 1
            tmpctrl = parent.Controls(ControlIDX)
            If Len(ControlName) > 0 Then
                If UCase(tmpctrl.Name) = UCase(ControlName) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = clsFindControl_Recursive(tmpctrl, ControlName, "")
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
            If Len(ControlTAG) > 0 Then
                If UCase(tmpctrl.Tag) = UCase(ControlTAG) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = clsFindControl_Recursive(tmpctrl, "", ControlTAG)
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
        Next
        ' Not found
        Return Nothing
    End Function

    Function FindFocussedControl(ByVal ctr As Control) As Control
        Dim container As ContainerControl = TryCast(ctr, ContainerControl)
        Do While (container IsNot Nothing)
            ctr = container.ActiveControl
            container = TryCast(ctr, ContainerControl)
        Loop
        Return ctr
    End Function
End Class
