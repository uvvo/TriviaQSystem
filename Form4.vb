Public Class Form4
    Dim a As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Val(TextBox1.Text)   'Enter answer
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "5" Then                 'Correct asnswer
            MsgBox("Your answer is right")          'Show Answer is correct
        ElseIf MsgBox("Your answer is wrong") Then  'show your answer is wrong 
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()       'Show next question
        Form5.Show()
    End Sub


End Class
