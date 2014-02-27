Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 1 To 10
            TextBox2.Text += TextBox1.Text & " * " & i & " = " & CInt(TextBox1.Text) * i & Microsoft.VisualBasic.vbCrLf
        Next
    End Sub
End Class