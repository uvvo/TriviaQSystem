Public Class Form1
    Dim a As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Val(TextBox1.Text)  'Enter your answer
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "computer" Then         'Correct Answer
            MsgBox("Your answer is right")         'Show  Right answer
        ElseIf MsgBox("Your answer is wrong") Then 'Show  wrong answer
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()      'Show next question
        Form2.Show()
    End Sub


End Class
