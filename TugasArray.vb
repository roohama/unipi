Public Class TugasArray
    Private Sub TugasArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(9) As String
        arr(0) = "1"
        arr(1) = "2"
        arr(2) = "3"
        arr(3) = "4"
        arr(4) = "5"
        arr(5) = "6"
        arr(6) = "7"
        arr(7) = "8"
        arr(8) = "9"
        arr(9) = "10"


        For i = 0 To 9
            ComboBox1.Items.Add(arr(i))
        Next i

    End Sub
End Class