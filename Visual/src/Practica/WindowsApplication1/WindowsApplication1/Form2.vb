Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Contador As Integer
        For Contador = 1 To 5
            CheckedListBox1.Items.Add(Contador)
        Next
    End Sub
End Class