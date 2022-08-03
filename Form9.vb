Public Class Form9
    Dim a As String
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Val(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "operating system" Then
            MsgBox("Your answer is right")
        ElseIf MsgBox("Your answer is wrong") Then
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form10.Show()
    End Sub


End Class
