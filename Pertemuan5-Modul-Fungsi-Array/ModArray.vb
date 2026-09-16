Module ModArray
    Public Sub TampilkanPesan(nama As String)
        MessageBox.Show("Halo " & nama)
    End Sub

    Function Hitung(txtPanjang, txtLebar)

        Dim Hasil As Integer
        If txtPanjang <= 50 Then
            Hasil = 2 * txtPanjang + 2 * txtLebar

        Else
            Hasil = txtPanjang * txtLebar
        End If

        Return Hasil
    End Function

    Public nilai() As Integer = {50, 60, 70, 80, 90}
    Public nilai2D(,) As Integer = {
        {55, 35, 62},
        {62, 77, 15},
        {62, 72, 15}
    }

End Module
