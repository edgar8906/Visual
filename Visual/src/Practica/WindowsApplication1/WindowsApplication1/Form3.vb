Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        'llenamos el list 1
        'incremental
        For i = 0 To 100 Step 5
            Me.ListBox1.Items.Add(i)
        Next i
        'llenamos el list 2
        'decremental
        For i = 100 To 0 Step -5
            Me.ListBox2.Items.Add(i)
        Next i
    End Sub
End Class