Public Class Form6

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
        If CheckBox1.Checked = True Then
            Label1.Text = puntuaje
        End If

        If CheckBox2.Checked = True Then
            Label1.Text = puntuaje
        End If

        If CheckBox3.Checked = True Then puntuaje = puntuaje + 1
        Label1.Text = puntuaje
        MsgBox("Final " + Str(puntuaje))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form2.Show()
    End Sub



    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class