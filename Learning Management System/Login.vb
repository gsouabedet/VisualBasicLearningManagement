

Public Class Login
    Private Sub btnStudentLogin_Click(sender As Object, e As EventArgs) Handles btnStudentLogin.Click
        Select Case txtUsername.Text
            Case "gilchrist1", "Gilchrist1", "GILCHRIST1", "anh1", "Anh1", "ANH1"
                If txtPassword.Text = "gilchrist123" Or txtPassword.Text = "anh123" Then
                    Me.Hide()
                    Student.Show()
                Else
                    statusBar.Text = "Wrong Password"
                End If
            Case Else
                statusBar.Text = "Please enter a username"
        End Select
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Select Case txtUsername.Text
            Case "admin", "Admin", "ADMIN"
                If txtPassword.Text = "admin123" Then
                    Me.Hide()
                    Admin.Show()
                Else
                    statusBar.Text = "Wrong Password"
                End If
            Case "gilchrist1", "Gilchrist1", "GILCHRIST!", "anh1", "Anh1", "ANH1"
                statusBar.Text = "The username entered is a Student Username"
            Case Else
                statusBar.Text = "Wrong Username or Password"
        End Select
    End Sub
End Class
