


Option Strict On

Public Class FrmCariList

    Private ReadOnly daftarMahasiswa As New List(Of Mahasiswa)

    Private Sub FrmDariList_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        daftarMahasiswa.Add(New Mahasiswa("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D))
        daftarMahasiswa.Add(New Mahasiswa("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D))
        daftarMahasiswa.Add(New Mahasiswa("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D))
        daftarMahasiswa.Add(New Mahasiswa("241712007", "Dimas Siregar", "Teknik Komputer", 2024, 2.95D))

        bsMahasiswa.DataSource = daftarMahasiswa
        dgvMahasiswa.DataSource = bsMahasiswa

        lblJumlah.Text = "Jumlah data: " &
                         bsMahasiswa.Count.ToString()

    End Sub

    Private Sub btnTambah_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnTambah.Click

        If Not ValidasiInput() Then Return

        Dim ipk As Decimal
        Decimal.TryParse(txtIpk.Text, ipk)

        Dim mahasiswaBaru As New Mahasiswa(
            txtNim.Text,
            txtNama.Text.Trim(),
            cboJurusan.Text,
            Integer.Parse(txtAngkatan.Text),
            ipk
        )

        daftarMahasiswa.Add(mahasiswaBaru)

        bsMahasiswa.ResetBindings(False)

        lblJumlah.Text = "Jumlah data: " &
                         bsMahasiswa.Count.ToString()

        BersihkanInput()

    End Sub

    Private Function ValidasiInput() As Boolean

        errInput.Clear()

        Dim valid As Boolean = True
        Dim angkatan As Integer
        Dim ipk As Decimal

        If txtNim.Text.Length <> 9 OrElse
           Not IsNumeric(txtNim.Text) Then

            errInput.SetError(txtNim, "NIM harus terdiri dari 9 digit.")
            valid = False

        Else

            For Each mhs As Mahasiswa In daftarMahasiswa

                If mhs.Nim = txtNim.Text Then
                    errInput.SetError(txtNim, "NIM sudah terdaftar.")
                    valid = False
                    Exit For
                End If

            Next

        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            errInput.SetError(txtNama, "Nama wajib diisi.")
            valid = False
        End If

        If cboJurusan.SelectedIndex = -1 Then
            errInput.SetError(cboJurusan, "Pilih jurusan terlebih dahulu.")
            valid = False
        End If

        If Not Integer.TryParse(txtAngkatan.Text, angkatan) OrElse
           angkatan < 2015 OrElse angkatan > Date.Today.Year Then

            errInput.SetError(txtAngkatan, "Angkatan tidak valid.")
            valid = False

        End If

        If Not Decimal.TryParse(txtIpk.Text, ipk) OrElse
           ipk < 0D OrElse ipk > 4D Then

            errInput.SetError(txtIpk, "IPK harus antara 0 dan 4.")
            valid = False

        End If

        Return valid

    End Function

    Private Sub BersihkanInput()

        txtNim.Clear()
        txtNama.Clear()
        cboJurusan.SelectedIndex = -1
        txtAngkatan.Clear()
        txtIpk.Clear()

        errInput.Clear()
        txtNim.Focus()

    End Sub

End Class
