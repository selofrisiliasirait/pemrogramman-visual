Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Metadata.Ecma335

Public Class FrmArray
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click

        'MessageBox.Show(Hitung(txtPanjang.text, txtLebar.text))
        'lstNilai.Items.Add(nilai(0))
        For i As Integer = 0 To nilai.Length - 1
            lstNilai.Items.Add(i)
        Next
    End Sub

    Private Sub btnTampil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnTampil.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
