

Option Strict On

Imports System.Data

Public Class FrmInventaris

    Private tabelBuku As DataTable

    ' Membuat DataTable dan mengisi 10 data buku awal.
    Private Function BuatTabelBuku() As DataTable

        Dim tabel As New DataTable("Buku")

        tabel.Columns.Add("KodeBuku", GetType(String))
        tabel.Columns.Add("Judul", GetType(String))
        tabel.Columns.Add("Penulis", GetType(String))
        tabel.Columns.Add("Kategori", GetType(String))
        tabel.Columns.Add("Tahun", GetType(Integer))
        tabel.Columns.Add("Stok", GetType(Integer))

        tabel.Rows.Add("BK0001", "Hujan", "Tere Liye", "Fiksi", 2016, 8)
        tabel.Rows.Add("BK0002", "Pulang", "Tere Liye", "Fiksi", 2015, 0)
        tabel.Rows.Add("BK0003", "Bumi", "Tere Liye", "Fiksi", 2014, 5)
        tabel.Rows.Add("BK0004", "Sapiens", "Yuval Noah Harari", "Nonfiksi", 2011, 4)
        tabel.Rows.Add("BK0005", "Atomic Habits", "James Clear", "Nonfiksi", 2018, 6)
        tabel.Rows.Add("BK0006", "Ensiklopedia Sains", "Tim Penerbit", "Referensi", 2020, 0)
        tabel.Rows.Add("BK0007", "Kamus Besar Bahasa Indonesia", "Badan Bahasa", "Referensi", 2016, 3)
        tabel.Rows.Add("BK0008", "National Geographic", "Redaksi", "Majalah", 2024, 2)
        tabel.Rows.Add("BK0009", "Tempo", "Redaksi", "Majalah", 2025, 4)
        tabel.Rows.Add("BK0010", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 7)

        Return tabel

    End Function

    ' Menyiapkan data dan tampilan ketika form dibuka.
    Private Sub FrmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tabelBuku = BuatTabelBuku()

        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku

        cboKategori.SelectedIndex = -1
        cboFilterKategori.SelectedIndex = 0

        AturKolom()
        PerbaruiRingkasan()

    End Sub

    ' Mengatur lebar, judul, dan posisi kolom tabel.
    Private Sub AturKolom()

        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"

        dgvBuku.Columns("Judul").FillWeight = 200

        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter

    End Sub

    ' Memeriksa seluruh isian dan kode buku yang sudah terdaftar.
    Private Function ValidasiInput() As Boolean

        errBuku.Clear()

        Dim valid As Boolean = True
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim tahun As Integer
        Dim stok As Integer

        ' Validasi kode buku: BK + 4 digit.
        If kode.Length <> 6 OrElse Not kode.StartsWith("BK") Then

            errBuku.SetError(txtKodeBuku, "Format harus BK dan 4 digit.")
            valid = False

        Else

            For i As Integer = 2 To 5

                If Not Char.IsDigit(kode(i)) Then
                    errBuku.SetError(txtKodeBuku, "Format harus BK dan 4 digit.")
                    valid = False
                    Exit For
                End If

            Next

            ' Memeriksa kode buku yang sudah ada.
            If valid Then

                For Each baris As DataRow In tabelBuku.Rows

                    If baris("KodeBuku").ToString() = kode Then

                        errBuku.SetError(txtKodeBuku, "Kode buku sudah terdaftar.")
                        valid = False
                        Exit For

                    End If

                Next

            End If

        End If

        ' Validasi judul.
        If String.IsNullOrWhiteSpace(txtJudul.Text) Then
            errBuku.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If

        ' Validasi penulis.
        If String.IsNullOrWhiteSpace(txtPenulis.Text) Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        ' Validasi kategori.
        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Pilih kategori.")
            valid = False
        End If

        ' Validasi tahun terbit.
        If Not Integer.TryParse(txtTahun.Text, tahun) OrElse
            tahun < 1900 OrElse tahun > Date.Today.Year Then

            errBuku.SetError(txtTahun, "Tahun harus antara 1900 dan tahun ini.")
            valid = False

        End If

        ' Validasi stok.
        If Not Integer.TryParse(txtStok.Text, stok) OrElse stok < 0 Then

            errBuku.SetError(txtStok, "Stok harus berupa angka 0 atau lebih.")
            valid = False

        End If

        Return valid

    End Function

    ' Menambahkan buku baru ke DataTable.
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If Not ValidasiInput() Then Return

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()

        tabelBuku.Rows.Add(
            kode,
            txtJudul.Text.Trim(),
            txtPenulis.Text.Trim(),
            cboKategori.Text,
            Integer.Parse(txtTahun.Text),
            Integer.Parse(txtStok.Text)
        )

        TerapkanFilter()
        BersihkanInput()

    End Sub

    ' Mengosongkan seluruh isian buku.
    Private Sub BersihkanInput()

        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()

        errBuku.Clear()
        txtKodeBuku.Focus()

    End Sub

    ' Menjalankan tombol Bersihkan.
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click

        BersihkanInput()

    End Sub

    ' Mengamankan karakter khusus dalam pencarian Filter.
    Private Function AmankanTeksFilter(teks As String) As String

        Dim hasil As String = ""

        For Each karakter As Char In teks

            Select Case karakter

                Case "'"c
                    hasil &= "''"

                Case "["c, "]"c, "*"c, "%"c
                    hasil &= "[" & karakter & "]"

                Case Else
                    hasil &= karakter

            End Select

        Next

        Return hasil

    End Function

    ' Menggabungkan pencarian judul/penulis dan kategori.
    Private Sub TerapkanFilter()

        Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())
        Dim syarat As New List(Of String)

        If kata <> "" Then

            syarat.Add(
                "(Judul LIKE '%" & kata & "%' OR Penulis LIKE '%" & kata & "%')"
            )

        End If

        If cboFilterKategori.Text <> "" AndAlso
            cboFilterKategori.Text <> "Semua" Then

            syarat.Add("Kategori = '" & cboFilterKategori.Text & "'")

        End If

        If syarat.Count = 0 Then

            bsBuku.RemoveFilter()

        Else

            bsBuku.Filter = String.Join(" AND ", syarat)

        End If

        PerbaruiRingkasan()

    End Sub

    ' Menjalankan pencarian ketika pengguna mengetik.
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        TerapkanFilter()

    End Sub

    ' Menjalankan filter ketika kategori berubah.
    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged

        If tabelBuku IsNot Nothing Then
            TerapkanFilter()
        End If

    End Sub

    ' Menghitung jumlah buku dan total stok yang sedang tampil.
    Private Sub PerbaruiRingkasan()

        Dim totalStok As Integer = 0

        For Each baris As DataGridViewRow In dgvBuku.Rows

            If Not baris.IsNewRow Then

                totalStok += CInt(baris.Cells("Stok").Value)

            End If

        Next

        lblJumlah.Text = "Menampilkan " & bsBuku.Count.ToString() &
                         " dari " & tabelBuku.Rows.Count.ToString() & " buku"

        lblTotalStok.Text = "Total stok: " & totalStok.ToString()

    End Sub

End Class

