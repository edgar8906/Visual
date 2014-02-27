Public Class Form7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = Val(TextBox1.Text)

        For i As Integer = 1 To num - 1
            num = num * i
        Next

        TextBox2.Text = num

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class