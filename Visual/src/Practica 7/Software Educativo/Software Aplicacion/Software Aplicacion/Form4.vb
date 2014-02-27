Public Class Form4
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


    Private Property puntuaje As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        puntuaje = 0
        If RadioButton1.Checked = True Then
            Label1.Text = puntuaje
        End If

        If RadioButton2.Checked = True Then
            Label1.Text = puntuaje
        End If

        If RadioButton3.Checked = True Then puntuaje = puntuaje + 1
        Label1.Text = puntuaje
        MsgBox("Final " + Str(puntuaje))
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class