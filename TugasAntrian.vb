Public Class TugasAntrian
    Dim q As Queue = New Queue()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        Dim jumAntrian As Integer
        jumAntrian = q.Count + 1
        n = TextBox1.Text
        Label2.Text = "Terdapat " + jumAntrian.ToString + " antrian"
        Label3.Text = "Masuk Antrian : " + n
        q.Enqueue(n)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ch As String
        Dim jumAntrian As Integer
        jumAntrian = q.Count

        If jumAntrian = 0 Then
            Label2.Text = "Belum Ada Antrian"
            Label3.Text = "Jumlah Atrian: " + jumAntrian.ToString
        Else
            ch = q.Dequeue()
            Label2.Text = "Terdapat " + jumAntrian.ToString + " antrian"
            Label3.Text = "Keluar Antrian: " + ch
        End If
    End Sub

    Private Sub TugasAntrian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class