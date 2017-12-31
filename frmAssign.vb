Public Class frmAssign
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dim frmAssign As New frmGrades
        frmAssign.Show()

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Assign1 As Integer
        Dim Assign2 As Integer
        Dim Assign3 As Integer
        Dim Assign4 As Integer
        Dim Assign5 As Integer
        Dim Assign6 As Integer
        Dim Assign7 As Integer
        Dim Assign8 As Integer
        Dim Total As Integer

        If IsNumeric(txtAssign1.Text) And IsNumeric(txtAssign2.Text) And
            IsNumeric(txtAssign3.Text) And IsNumeric(txtAssign4.Text) And
            IsNumeric(txtAssign5.Text) And IsNumeric(txtAssign6.Text) And
            IsNumeric(txtAssign7.Text) And IsNumeric(txtAssign8.Text) Then

            Assign1 = Convert.ToInt32(txtAssign1.Text)
            Assign2 = Convert.ToInt32(txtAssign2.Text)
            Assign3 = Convert.ToInt32(txtAssign3.Text)
            Assign4 = Convert.ToInt32(txtAssign4.Text)
            Assign5 = Convert.ToInt32(txtAssign5.Text)
            Assign6 = Convert.ToInt32(txtAssign6.Text)
            Assign7 = Convert.ToInt32(txtAssign7.Text)
            Assign8 = Convert.ToInt32(txtAssign8.Text)
            Total = Convert.ToInt32(txtTotal.Text)

            Total = Assign1 + Assign2 + Assign3 + Assign4 + Assign5 + Assign6 + Assign7 + Assign8 / 8

        End If

    End Sub
End Class