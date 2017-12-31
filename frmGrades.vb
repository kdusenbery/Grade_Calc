Public Class frmGrades

    Private Sub frmGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblName.Text = frmMain.txtName.Text

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Dim frmGrades As New frmMain
        frmGrades.Show()

    End Sub

    Private Sub btnForums_Click(sender As Object, e As EventArgs) Handles btnForums.Click
        Me.Hide()
        Dim frmGrades As New frmForums
        frmGrades.Show()

    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Me.Hide()
        Dim frmGrades As New frmAssign
        frmGrades.Show()

    End Sub

    Private Sub btnFinal_Click(sender As Object, e As EventArgs) Handles btnFinal.Click
        Me.Hide()
        Dim frmGrades As New frmFinal
        frmGrades.Show()

    End Sub

End Class