Public Class Student
    Dim fileReader As String
    fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Students data.txt")
    MsgBox(fileReader)


    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Hide()
        Login.Show()
    End Sub



End Class