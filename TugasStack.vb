Public Class TugasStack
    Dim stk As Stack = New Stack()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        Dim jumAntrian As Integer
        jumAntrian = stk.Count + 1
        n = TextBox1.Text
        Console.WriteLine("Masuk Antrian : " + n)
        Label2.Text = "Terdapat " + jumAntrian.ToString + " antrian"
        Label3.Text = "Masuk Antrian : " + n
        stk.Push(n)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ch As String
        Dim jumAntrian As Integer
        jumAntrian = stk.Count

        If jumAntrian = 0 Then
            Label2.Text = "Belum Ada Antrian"
            Label3.Text = "Jumlah Atrian: " + jumAntrian.ToString
        Else
            ch = stk.Pop()
            Label2.Text = "Terdapat " + jumAntrian.ToString + " antrian"
            Label3.Text = "Keluar Antrian: " + ch
        End If
    End Sub
End Class