Public Class Form5
    Dim a As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Val(TextBox1.Text) 'Answer here
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "mouse" Then         'Correct answer
            MsgBox("Your answer is right")      'Show your answer is right
        ElseIf MsgBox("Your answer is wrong") Then    'Show your answer is wrong
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()  'Show next question
        Form6.Show()
    End Sub


End Class
