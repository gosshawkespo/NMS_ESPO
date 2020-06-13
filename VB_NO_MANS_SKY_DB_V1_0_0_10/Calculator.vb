Public Class Calculator
    Dim dblNum1 As Double
    Dim dblNum2 As Double
    Dim dblTotal As Double
    Dim Operation As Boolean = False
    Dim intTotal As Integer
    Dim strDisplay As String
    Dim strOp As String '+ OR - OR / OR * 
    Dim strDigit As String
    Dim strUserEntry As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        '+/- Operation

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        'Undef1
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'Undef2
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        'Undef3
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        'Division operation:
        strOp = "/"
        Operation = True
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        'Memory Cancel:

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        'DIGIT: 7
        strDigit = "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        'DIGIT: 8
        strDigit = "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        'DIGIT: 9
        strDigit = "9"
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        'MULTIPLY Operation:
        strOp = "*"
        Operation = True
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        'MEMORY Subtraction:

    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        'DIGIT: 4
        strDigit = "4"
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        'DIGIT: 5
        strDigit = "5"
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        'DIGIT: 6
        strDigit = "6"
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        'MINUS OPERATION
        strOp = "-"
        Operation = True
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        'MEMORY ADDITION:

    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        'DIGIT: 1
        strDigit = "1"
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        'DIGIT: 2
        strDigit = "2"
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        'DIGIT: 3
        strDigit = "3"
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        'ADD Operation:
        strOp = "+"
        Operation = True
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        'CANCEL / RESET Display:
        strOp = "CE"
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        'DIGIT: 0
        strDigit = "0"
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        'DECIMAL:
        strDigit = "."
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        'EQUALS:
        strDigit = "="
    End Sub

    Sub ShowTotal()
        txtDisplay.Text = CStr(dblTotal)
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intTotal = 0
        dblTotal = 0.0
        dblNum1 = 0
        dblNum2 = 0
        txtDisplay.Text = "0"
        KeyPreview = True
    End Sub

    Private Sub Calculator_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = 48 Then
            strDigit = "0"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            End If
        End If
        If e.KeyValue = 49 Then
            strDigit = "1"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 50 Then
            strDigit = "2"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 51 Then
            strDigit = "3"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 52 Then
            strDigit = "4"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 53 Then
            strDigit = "5"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 54 Then
            strDigit = "6"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 55 Then
            strDigit = "7"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 56 Then
            strDigit = "8"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 57 Then
            strDigit = "9"
            If txtDisplay.Text <> "0" Then
                txtDisplay.Text += strDigit
            Else
                txtDisplay.Text = strDigit
            End If
        End If
        If e.KeyValue = 42 Then
            strDigit = "."
            If Not (txtDisplay.Text.Contains(".")) Then
                txtDisplay.Text += strDigit
            End If
        End If
        If e.KeyValue = 100 Then
            txtDisplay.Text = "0"
        End If
        If e.KeyValue = 67 Then
            txtDisplay.Text = "0"
            dblNum1 = 0
            dblNum2 = 0
        End If
        If Chr(e.KeyValue) = "+" Or e.KeyValue = 107 Then
            strOp = "+"
            dblNum1 = txtDisplay.Text
            txtDisplay.Text = "0"
            Operation = True
        End If
        If Chr(e.KeyValue) = "-" Then
            strOp = "-"
            dblNum1 = txtDisplay.Text
            txtDisplay.Text = "0"
            Operation = True
        End If
        If Chr(e.KeyValue) = "*" Then
            strOp = "*"
            dblNum1 = txtDisplay.Text
            txtDisplay.Text = "0"
            Operation = True
        End If
        If Chr(e.KeyValue) = "/" Then
            strOp = "/"
            dblNum1 = txtDisplay.Text
            txtDisplay.Text = "0"
            Operation = True
        End If
        If e.KeyValue = 187 Then
            strDigit = "="
            If Operation = True Then
                dblNum2 = txtDisplay.Text
                If strOp = "+" Then
                    txtDisplay.Text = dblNum1 + dblNum2
                ElseIf strOp = "-" Then
                    txtDisplay.Text = dblNum1 - dblNum2
                ElseIf strOp = "*" Then
                    txtDisplay.Text = dblNum2 * dblNum2
                Else
                    If dblNum2 = 0 Then
                        txtDisplay.Text = "Error"
                    Else
                        txtDisplay.Text = dblNum1 / dblNum2
                    End If
                End If
                Operation = False
            End If
        End If
    End Sub

    Private Sub Calculator_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Dim btn As System.Windows.Forms.Button

        If TypeOf (sender) Is System.Windows.Forms.Button Then
            'btn = sender
            MsgBox(btn.Text)
        End If
    End Sub
End Class