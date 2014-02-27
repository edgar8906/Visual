Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Usuario1 As String = "Edgar"
        Dim Password1 As Integer = 123
        Dim Usuario2 As String = "Edwin"
        Dim Password2 As Integer = 987
        Dim counter As Integer = 0

        'Do While counter < 3

        If Usuario1.Equals(TextBox1.Text) And Password1 = Val(TextBox2.Text) Then
            MsgBox("Los Datos Son Correctos")
            Me.Hide()
            Form3.Show()
            Form3.Label1.Text = Usuario1
        ElseIf Usuario2.Equals(TextBox1.Text) And Password2 = Val(TextBox2.Text) Then
            MsgBox("Los Datos Son Correctos")
            Me.Hide()
            Form3.Show()
            Form3.Label1.Text = Usuario2
        Else
            MsgBox("Datos Incorrectos")

        End If

        'Loop

        If counter = 3 Then
            MsgBox("A ingresado la contraseña erronea " & CStr(counter) & " veces ")

            Me.Hide()
            Form1.Show()
        End If


    End Sub
End Class
