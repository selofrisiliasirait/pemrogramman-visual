Public Class Form1
    Private Sub BtnTampilkan_Click(sender As Object, e As EventArgs) Handles BtnTampilkan.Click
        MessageBox.Show("Halo Selamat Datang !" & vbCrLf &
                        "Nama   : " & TxtNama.Text & vbCrLf &
                        "Nim    : " & TxtNim.Text & vbCrLf &
                        "Kom    : " & TxtKom.Text
        )


    End Sub

    Private Sub TxtNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNama.TextChanged

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        TxtNama.Clear()
        TxtNim.Clear()
        TxtKom.Clear()

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
End Class

