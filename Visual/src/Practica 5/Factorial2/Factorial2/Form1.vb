Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fact As Integer = 1
        Dim num As Integer

        num = Val(TextBox1.Text)

        For i As Integer = 1 To num - 1
            num = num * i

        Next
        Label2.Text = "El factorial es: " & num
        Button2.Enabled = True
        Button3.Enabled = True


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = True
        TextBox1.Clear()
        Label2.Text = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
