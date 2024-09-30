Public Class Form1
    Public Property TextBoxGrade As Object
    Public Property TextBoxMarks As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim marks As Integer
        marks = CInt(txtMarks.Text)

        If marks > 100 Then
            MessageBox.Show("Wrong entry, please re-enter the mark")
            txtMarks.Clear()
        ElseIf marks >= 90 Then
            txtGrade.Text = "Excellent"
        ElseIf marks >= 80 Then
            txtGrade.Text = "Very Good"
        ElseIf marks >= 70 Then
            txtGrade.Text = "Good"
        ElseIf marks >= 60 Then
            txtGrade.Text = "Medium"
        ElseIf marks >= 50 Then
            txtGrade.Text = "Pass"
        Else
            txtGrade.Text = "Fail"
        End If
    End Sub

    Private Sub txtMarks_TextChanged(sender As Object, e As EventArgs) Handles txtMarks.TextChanged

    End Sub

    Private Sub txtGrade_TextChanged(sender As Object, e As EventArgs) Handles txtGrade.TextChanged

    End Sub
End Class
