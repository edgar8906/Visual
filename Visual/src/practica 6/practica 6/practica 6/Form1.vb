Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox1.Checked = True Then
            Label4.Text = Single.Parse(TextBox1.Text) + Single.Parse(TextBox2.Text)


        ElseIf CheckBox2.Checked = True Then
            Label4.Text = Single.Parse(TextBox1.Text) - Single.Parse(TextBox2.Text)

        ElseIf CheckBox3.Checked = True Then
            Label4.Text = Single.Parse(TextBox1.Text) * Single.Parse(TextBox2.Text)

        ElseIf CheckBox4.Checked = True Then
            Label4.Text = Single.Parse(TextBox1.Text) / Single.Parse(TextBox2.Text)

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
        End If
        If CheckBox1.Checked = True Then
            CheckBox3.Checked = False
        End If
        If CheckBox1.Checked = True Then
            CheckBox4.Checked = False
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
        End If
        If CheckBox2.Checked = True Then
            CheckBox3.Checked = False
        End If
        If CheckBox2.Checked = True Then
            CheckBox4.Checked = False
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            CheckBox1.Checked = False
        End If
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
        End If
        If CheckBox3.Checked = True Then
            CheckBox4.Checked = False
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

        If CheckBox4.Checked = True Then
            CheckBox1.Checked = False
        End If
        If CheckBox4.Checked = True Then
            CheckBox2.Checked = False
        End If
        If CheckBox4.Checked = True Then
            CheckBox3.Checked = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        TextBox1.Clear()
        TextBox2.Clear()
        Label4.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        End

    End Sub
End Class
