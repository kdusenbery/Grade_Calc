Public Class frmFinal
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dim frmFinal As New frmGrades
        frmFinal.Show()

    End Sub
End Class