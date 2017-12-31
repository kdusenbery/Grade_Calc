Public Class frmForums
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dim frmForums As New frmGrades
        frmForums.Show()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Forum1 As Integer
        Dim Forum2 As Integer
        Dim Forum3 As Integer
        Dim Forum4 As Integer
        Dim Forum5 As Integer
        Dim Forum6 As Integer
        Dim Forum7 As Integer
        Dim Forum8 As Integer
        Dim Total As Integer

        If IsNumeric(txtForum1.Text) And IsNumeric(txtForum2.Text) And
            IsNumeric(txtForum3.Text) And IsNumeric(txtForum4.Text) And
            IsNumeric(txtForum5.Text) And IsNumeric(txtForum6.Text) And
            IsNumeric(txtForum7.Text) And IsNumeric(txtForum8.Text) Then

            Forum1 = Convert.ToInt32(txtForum1.Text)
            Forum2 = Convert.ToInt32(txtForum2.Text)
            Forum3 = Convert.ToInt32(txtForum3.Text)
            Forum4 = Convert.ToInt32(txtForum4.Text)
            Forum5 = Convert.ToInt32(txtForum5.Text)
            Forum6 = Convert.ToInt32(txtForum6.Text)
            Forum7 = Convert.ToInt32(txtForum7.Text)
            Forum8 = Convert.ToInt32(txtForum8.Text)
            Total = Convert.ToInt32(txtTotal.Text)

            Total = Forum1 + Forum2 + Forum3 + Forum4 + Forum5 + Forum6 + Forum7 + Forum8 / 8

        End If

    End Sub
End Class