Public Class Student_Details
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click

    End Sub

    Private Sub btnDropCourse_Click(sender As Object, e As EventArgs) Handles btnDropCourse.Click

    End Sub

    Private Sub btnChangeGrade_Click(sender As Object, e As EventArgs) Handles btnChangeGrade.Click

    End Sub
End Class