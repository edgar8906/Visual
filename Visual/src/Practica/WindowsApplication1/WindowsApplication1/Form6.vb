Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim i, a As Integer

        num = Val(InputBox("digite un numero de un digito"))

        For i = 1 To 10 Step 1
            a = num * i

            MsgBox("Tabla de Multiplicar " & num & " * " & i & " = " & a)
        Next i
    End Sub
End Class