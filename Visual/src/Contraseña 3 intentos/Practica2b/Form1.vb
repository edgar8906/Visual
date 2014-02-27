Public Class Form1
    Dim contador As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Usuario1 As String = "carlos"
        Dim Password1 As Integer = 123
        Dim Usuario2 As String = "juan"
        Dim Password2 As Integer = 354

        contador = contador + 1
        If Usuario1.Equals(TextBox1.Text) And Password1 = Val(TextBox2.Text) Then
            Form3.Nombre.Text = Usuario1
            Form3.Show()
            Me.Hide()

        ElseIf Usuario2.Equals(TextBox1.Text) And Password2 = Val(TextBox2.Text) Then
            Form3.Nombre.Text = Usuario1
            Form3.Show()
            Me.Hide()

        Else
            MsgBox("Incorrectos")
        End If

        If contador > 2 Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
