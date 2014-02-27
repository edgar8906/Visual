Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Debes de ingresar tus datos", MsgBoxStyle.Critical)
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("Tus datos se han almacenado correctamente", MsgBoxStyle.Information)
            Form3.Label1.Text = TextBox1.Text
            Me.Hide()
            Form3.Show()
        End If

        Form3.Label1.Text = TextBox1.Text
        Me.Hide()
        Form3.Show()

        Form3.Label2.Text = ComboBox1.Text
        Me.Hide()
        Form3.Show()

        Form3.Label3.Text = ComboBox2.Text
        Me.Hide()
        Form3.Show()



        Form7.Label2.Text = TextBox1.Text
        Me.Hide()
        Form3.Show()

        Form7.Label3.Text = ComboBox1.Text
        Me.Hide()
        Form3.Show()

        Form7.Label4.Text = ComboBox2.Text
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.ForeColor = Color.Blue
    End Sub

End Class