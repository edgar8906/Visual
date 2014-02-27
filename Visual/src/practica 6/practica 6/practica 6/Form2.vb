Public Class Form2

    Dim sueldo, bonificacion, descuento, neto As Single

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sueldo = 0
        bonificacion = 0
        descuento = 0
        neto = 0

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            sueldo = 1500
            TextBox1.Text = sueldo
        Else

            sueldo = 0
            TextBox1.Text = sueldo

        End If




    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            bonificacion = 500
            TextBox2.Text = bonificacion
        Else

            bonificacion = 0
            TextBox2.Text = bonificacion

        End If


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            descuento = 345
            TextBox3.Text = descuento
        Else

            descuento = 0
            TextBox3.Text = descuento

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        neto = sueldo + bonificacion - descuento

        TextBox4.Text = neto.ToString("##.00")


    End Sub
End Class