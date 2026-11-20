Option Strict On

Imports System.ComponentModel
Imports System.IO

Public Class FrmPeminjaman

    ' Menyimpan kode buku yang sedang dipinjam.
    Private ReadOnly daftarKodeBuku As New List(Of String)

    ' Menentukan lokasi file CSV di folder Documents.
    Private ReadOnly lokasiEkspor As String =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                     "peminjaman.csv")
    ' Memeriksa seluruh input sebelum peminjaman dicatat.
    Private Function ValidasiInput() As Boolean

        errPinjam.Clear()
        Dim valid As Boolean = True

        ' Validasi kode buku.
        txtKodeBuku.Text = txtKodeBuku.Text.Trim().ToUpperInvariant()

        If Not KodeBukuValid(txtKodeBuku.Text) Then
            errPinjam.SetError(txtKodeBuku, "Kode harus BK diikuti 4 digit.")
            valid = False
        ElseIf daftarKodeBuku.Contains(txtKodeBuku.Text) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If

        ' Validasi judul buku.
        If txtJudul.Text.Trim() = "" Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
            valid = False
        End If

        ' Validasi kategori.
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Pilih kategori buku.")
            valid = False
        End If

        ' Validasi nama peminjam.
        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama minimal 3 karakter.")
            valid = False
        End If

        ' Validasi lama pinjam.
        Dim lamaPinjam As Integer

        If Not Integer.TryParse(txtLamaPinjam.Text, lamaPinjam) OrElse
           lamaPinjam < 1 OrElse lamaPinjam > 14 Then

            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus 1 sampai 14 hari.")
            valid = False
        End If

        Return valid



    End Function

    ' Mencatat peminjaman jika seluruh input valid.
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click

        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa kembali isian yang salah."
            Return
        End If

        Dim lamaPinjam As Integer
        Integer.TryParse(txtLamaPinjam.Text, lamaPinjam)

        Dim tanggalKembali As String =
            Date.Today.AddDays(lamaPinjam).ToString("dd/MM/yyyy")

        Dim baris As String =
            txtKodeBuku.Text & " | " &
            txtJudul.Text.Trim() & " | " &
            cboKategori.Text & " | " &
            txtNamaPeminjam.Text.Trim() & " | " &
            lamaPinjam.ToString() & " hari | kembali " &
            tanggalKembali

        lstPeminjaman.Items.Add(baris)
        daftarKodeBuku.Add(txtKodeBuku.Text)

        lblStatus.Text = "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()

        BersihkanForm()

    End Sub



    ' Mengosongkan seluruh input dan menghapus tanda error.
    Private Sub BersihkanForm()

        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()

        errPinjam.Clear()
        txtKodeBuku.Focus()

    End Sub

    ' Menjalankan proses pembersihan form.
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click

        BersihkanForm()
        lblStatus.Text = "Form berhasil dibersihkan."

    End Sub

    ' Memeriksa format kode buku saat fokus berpindah.
    Private Sub txtKodeBuku_Validating(sender As Object, e As CancelEventArgs) Handles txtKodeBuku.Validating

        txtKodeBuku.Text = txtKodeBuku.Text.Trim().ToUpperInvariant()

        If txtKodeBuku.Text = "" Then
            errPinjam.SetError(txtKodeBuku, "")
        ElseIf Not KodeBukuValid(txtKodeBuku.Text) Then
            errPinjam.SetError(txtKodeBuku, "Kode harus BK diikuti 4 digit.")
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If

    End Sub

    ' Mengekspor daftar peminjaman ke file CSV.
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click

        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada data peminjaman untuk diekspor.",
                            "Ekspor CSV",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Return
        End If

        Dim penulis As StreamWriter = Nothing

        Try
            penulis = New StreamWriter(lokasiEkspor)

            ' Menulis judul kolom.
            penulis.WriteLine("Kode Buku;Judul Buku;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")

            ' Menulis seluruh data peminjaman.
            For Each item As Object In lstPeminjaman.Items
                penulis.WriteLine(item.ToString().Replace(" | ", ";"))
            Next

            lblStatus.Text = "Data berhasil diekspor ke: " & lokasiEkspor

        Catch ex As IOException
            MessageBox.Show("Ekspor gagal. Tutup file peminjaman.csv jika sedang dibuka di Excel, lalu coba lagi." &
                            vbCrLf & ex.Message,
                            "Ekspor Gagal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Ekspor gagal karena tidak memiliki izin akses. Periksa izin folder Documents." &
                            vbCrLf & ex.Message,
                            "Akses Ditolak",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        Finally
            If penulis IsNot Nothing Then
                penulis.Close()
            End If
        End Try

    End Sub

End Class