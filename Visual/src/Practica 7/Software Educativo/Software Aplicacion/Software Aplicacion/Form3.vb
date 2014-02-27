Public Class Form3

    Dim calif As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 20 Then

        End If

        If ProgressBar1.Value = 40 Then

        End If

        If ProgressBar1.Value = 60 Then

        End If

        If ProgressBar1.Value = 80 Then

        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            MsgBox("Tiempo agotado")

            Button1.Enabled = True
            Me.Hide()
            Form2.Show()
        Else
            ProgressBar1.PerformStep()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "0"
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "0"
        Button1.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Text = "2"
        Button1.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label6.Text = "0"
        Button5.Enabled = False
        Button6.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label6.Text = "2"
        Button4.Enabled = False
        Button6.Enabled = False
        calif = calif + 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label6.Text = "0"
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form7.Label5.Text = "Calificacion: " & calif
        Me.Hide()
        Form7.Show()
        

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calif = 0
        Timer1.Start()
    End Sub
End Class