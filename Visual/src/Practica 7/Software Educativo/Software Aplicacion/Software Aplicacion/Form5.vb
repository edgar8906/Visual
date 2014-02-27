Public Class Form5

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 20 Then
            Label2.Text = "Accediendo...."
        End If

        If ProgressBar1.Value = 40 Then
            Label2.Text = "....Accediendo...."
        End If

        If ProgressBar1.Value = 60 Then
            Label2.Text = "....Accedi"
        End If

        If ProgressBar1.Value = 80 Then
            Label2.Text = "........"
        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MsgBox("Tu carga fue exitosa.!!")
            Label2.Text = "Completado"
            Button1.Enabled = True
            Me.Hide()
            Form2.Show()

        End If
    End Sub
End Class