Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jumlah As Integer
        jumlah = TextBox1.Text
        For i = 1 To jumlah
            ListBox1.Items.Add(i)
            i = i + 1
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jumlah As Integer
        jumlah = TextBox1.Text
        For i = 1 To jumlah
            i = i + 1
            ListBox1.Items.Add(i)
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim jumlah, j, k, hasil As Integer
        jumlah = TextBox1.Text
        For i = 1 To jumlah
            k = 0
            For j = 2 To i
                hasil = i Mod j
                If hasil = 0 Then
                    k = k + 1

                End If

            Next

            If k <= 1 Then
                ListBox1.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()

    End Sub


End Class
