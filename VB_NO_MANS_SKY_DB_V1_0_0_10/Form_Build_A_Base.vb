Public Class frmBuildBase
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Sub Save_Base_Entry()


    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        'SAVE to BASE BUILD TABLE:
        Save_Base_Entry()
    End Sub


End Class