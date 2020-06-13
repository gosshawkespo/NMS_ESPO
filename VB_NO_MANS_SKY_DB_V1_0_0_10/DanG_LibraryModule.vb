﻿Module Module2

    'NEW MODULE TO STORE CODE THAT MAY BE USEFUL LATER.
    'WRITTEN BY DANIEL GOSS  OCTOBER 2019. MOST OF THE CODE FROM VBTIMESHEET V1.3

    'LIBRARY CODE THAT CAN BE COPIED AND PASTED INTO ANY APPLICATION IF FOUND USEFUL.
    'tHIS MODULE MUST REMAIN NOT PART OF A MAIN PROJECT.
    '
    Sub ShowForms(FormName As String, Optional Dropdowns() As Object = Nothing, Optional OwnerForm As Form = Nothing)

        If UCase(FormName) = UCase("frmSelectSheet") Then
            Dim newform As New frmSelectSheet

            If OwnerForm Is Nothing Then
                newform.MdiParent = Me
            Else
                newform.MdiParent = OwnerForm
            End If
            newform.StartPosition = FormStartPosition.CenterParent
            newform.Text = "SELECT WORKSHEET"
            newform.Name = "SelectWorksheet"
            'NewForm.DropdownItems.AddRange(ExcelSheets) 'Getting Object not referenced error here.
            If Dropdowns IsNot Nothing Then
                For Each SheetName In Dropdowns
                    If SheetName IsNot Nothing Then
                        newform.DropdownItems.Add(SheetName)
                    End If
                Next
            End If
            newform.Visible = True
            newform.txtWorkbook.Text = ""
            newform.Show()

        End If

        If UCase(FormName) = UCase(ControlPanelFormName & ControlPanelIdx) Then
            Dim newform As New frmGI_RP_Userform

            If OwnerForm Is Nothing Then
                newform.MdiParent = Me
            Else
                newform.MdiParent = OwnerForm
            End If

        End If

    End Sub

    Sub InsertValueIntoForm(FormName As String, ControlName As String, value As String,
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
                    logger.LogError("GI_Error_" & myVersion & ".log", Application.StartupPath, ErrMessage, "InsertValueIntoForm()",
                                    GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & myUsername,
                                    myUsernameSuffix)
                    Exit Sub
                Else
                    ErrMessage = "Error: Cannot Find CONTROL Passed"
                    logger.LogError("GI_Error_" & myVersion & ".log", Application.StartupPath, ErrMessage, "InsertValueIntoForm()",
                                    GetComputerName() & "," & GetIPv4Address() & "," & GetIPv6Address() & ", OPERATOR Logged in:" & myUsername,
                                    myUsernameSuffix)
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

    Function FindFrameControls(FormName As String, ControlName As String, Optional ByVal TAGNumber As String = "") As Control
        Dim ctrl As Control
        Dim ctrls() As Control
        Dim comboCtrl As ComboBox
        Dim comboArr() As String
        Dim IDX As Long

        ReDim ctrls(1)
        ctrl = Nothing
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(FormName) Then
                If Len(TAGNumber) > 0 Then
                    ControlName = FindControls(FormName, "", TAGNumber).Name
                End If
                If Len(ControlName) > 0 Then
                    ctrls = frm.Controls.Find(ControlName, True)
                    Exit For
                End If
            End If
        Next

        If ctrls IsNot Nothing And UBound(ctrls) > -1 Then
            ctrl = ctrls(0)
            Return ctrl
        End If
        Return ctrl
    End Function

    Function FindControls(Formname As String, ControlName As String, TagNumber As String, Optional ByRef childCtrl As Control = Nothing) As Control
        Dim ctrl As Control
        Dim FinalCtrl As Control
        Dim ctrls() As Control
        Dim comboCtrl As ComboBox
        Dim comboArr() As String
        Dim IDX As Long
        Dim FoundForm As Form = Nothing

        ReDim ctrls(1)
        FinalCtrl = Nothing
        'ctrl = Nothing
        For Each frm As Form In Application.OpenForms
            If UCase(frm.Name) = UCase(Formname) Then
                FoundForm = frm
            End If
        Next
        If FoundForm IsNot Nothing Then
            For Each ctrl In FoundForm.Controls
                If ctrl.HasChildren Then
                    If Len(ControlName) > 0 Then
                        childCtrl = FindControl_Recursive(ctrl, ControlName, "")
                    Else
                        childCtrl = FindControl_Recursive(ctrl, "", TagNumber)
                    End If
                    FinalCtrl = childCtrl
                    'Return childCtrl
                    'Exit For
                Else

                    If TypeOf (ctrl) Is ComboBox Or TypeOf (ctrl) Is TextBox Then
                        If UCase(ctrl.Name) = UCase(ControlName) Then
                            FinalCtrl = ctrl
                            Exit For
                        End If
                        If UCase(ctrl.Tag) = UCase(TagNumber) Then
                            'Return ctrl
                            FinalCtrl = ctrl
                            Exit For
                        End If

                    End If

                End If
                If TypeOf (childCtrl) Is ComboBox Or TypeOf (childCtrl) Is TextBox Then
                    FinalCtrl = childCtrl
                    Exit For
                End If
            Next
        End If

        FindControls = FinalCtrl


    End Function

    Public Function FindControl_Recursive(ByVal parent As Control, ByVal ControlName As String, Optional ByVal ControlTAG As String = "") As Control
        Dim ControlIDX As Integer
        Dim tmpctrl As Control
        Dim tmpctrl2 As Control
        For ControlIDX = 0 To parent.Controls.Count - 1
            tmpctrl = parent.Controls(ControlIDX)
            If Len(ControlName) > 0 Then
                If UCase(tmpctrl.Name) = UCase(ControlName) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = FindControl_Recursive(tmpctrl, ControlName, "")
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
            If Len(ControlTAG) > 0 Then
                If UCase(tmpctrl.Tag) = UCase(ControlTAG) Then
                    Return parent.Controls(ControlIDX)
                ElseIf tmpctrl.Controls.Count > 0 Then
                    tmpctrl2 = FindControl_Recursive(tmpctrl, "", ControlTAG)
                    If Not IsNothing(tmpctrl2) Then
                        Return tmpctrl2
                    End If
                End If
            End If
        Next
        ' Not found
        Return Nothing

    End Function
End Module
