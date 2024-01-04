Public Class TugasFungsi

    Private Function akarkuadrat()
        Dim a, c As Double
        a = TextBox1.Text
        c = Math.Sqrt(a)
        TextBox3.Text = c
        Return c
    End Function

    Private Function pangkat()
        Dim a, b, c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = a ^ b
        TextBox3.Text = c
        Return c
    End Function

    Private Function bagi()
        Dim a, b, c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = a / b
        TextBox3.Text = c
        Return c
    End Function

    Private Function tambah()
        Dim a, b, c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c
        Return c
    End Function

    Private Function kurang()
        Dim a, b, c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = a - b
        TextBox3.Text = c
        Return c
    End Function

    Private Function kali()
        Dim a, b, c As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        TextBox3.Text = c
        Return c
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbakar.Checked = True Then

            Call akarkuadrat()

        ElseIf rbpangkat.Checked = True Then

            Call pangkat()

        ElseIf rbbagi.Checked = True Then

            Call bagi()

        ElseIf rbtambah.Checked = True Then

            Call tambah()

        ElseIf rbkurang.Checked = True Then

            Call kurang()

        ElseIf rbkali.Checked = True Then

            Call kali()
        End If
    End Sub

    Private Sub rbakar_CheckedChanged(sender As Object, e As EventArgs) Handles rbakar.CheckedChanged
        TextBox2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class