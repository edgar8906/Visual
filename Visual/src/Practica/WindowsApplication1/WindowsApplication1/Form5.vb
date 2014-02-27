Public Class Form5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dato As Integer
        Dim resultado As Integer
        dato = TextBox1.Text
        For i = 1 To 10
            resultado = dato * i
        Next
        
    End Sub
End Class