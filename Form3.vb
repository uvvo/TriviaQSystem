Public Class Form3
    Dim a As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Val(TextBox1.Text) 'Enter your answer
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "charles babbage" Then   'Correct Answer
            MsgBox("Your answer is right")          'Show right answer
        ElseIf MsgBox("Your answer is wrong") Then  'Show  wrong 
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()      'show next qusetion
        Form4.Show()
    End Sub


End Class


'Show  wrong 