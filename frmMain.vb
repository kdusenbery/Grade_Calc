Public Class frmMain

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Me.Hide()
        Dim frmMain As New frmGrades
        frmMain.Show()

        'When the Nexr button is clicked, the user is directed to the Grades form

        frmGrades.Show()

        'Displays students name on the Grades form

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

End Class

