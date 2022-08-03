Public Class Form2
    Dim a As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Val(TextBox1.Text)   'Enter your answer
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1943" Then           'Correct Answer                
            MsgBox("Your answer is right")       'Show  Right answer
        ElseIf MsgBox("Your answer is wrong") Then  'Show  wrong 
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()     'Show next question
        Form3.Show()
    End Sub


End Class

