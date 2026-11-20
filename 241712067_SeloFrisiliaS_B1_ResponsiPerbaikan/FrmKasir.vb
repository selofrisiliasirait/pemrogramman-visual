Imports System.Globalization
Imports System.Linq

Public Class FrmKasir
    Private daftarPesanan As New List(Of Pesanan)


    Private Sub FrmKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLayanan.Items.Clear()
        cboLayanan.DropDownStyle = ComboBoxStyle.DropDownList
        For Each layanan As String In DaftarLayanan
            cboLayanan.Items.Add(layanan)
        Next
        cboLayanan.SelectedIndex = -1
        bsPesanan.DataSource = daftarPesanan
        dgvPesanan.DataSource = bsPesanan
        dgvPesanan.AllowUserToAddRows = False
        dgvPesanan.ReadOnly = True
        dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        FormatKolom()
        lblTotal.Text = "Rp 0"
        For Each layanan As String In DaftarLayanan
            cboLayanan.Items.Add(layanan)
        Next
    End Sub

    Private Sub FormatKolom()
        If dgvPesanan.Columns.Count = 0 Then Exit Sub
        dgvPesanan.Columns("Layanan").HeaderText = "Layanan"
        dgvPesanan.Columns("Jumlah").HeaderText = "Jumlah"
        dgvPesanan.Columns("Harga").HeaderText = "Harga Satuan"
        dgvPesanan.Columns("Diskon").HeaderText = "Diskon"
        dgvPesanan.Columns("Subtotal").HeaderText = "Subtotal"
        dgvPesanan.Columns("Harga").DefaultCellStyle.Format = "N0"
        dgvPesanan.Columns("Diskon").DefaultCellStyle.Format = "N0"
        dgvPesanan.Columns("Subtotal").DefaultCellStyle.Format = "N0"
        dgvPesanan.Columns("Harga").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight
        dgvPesanan.Columns("Diskon").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight
        dgvPesanan.Columns("Subtotal").DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight
    End Sub


    Private Sub HitungPesanan(p As Pesanan)
        Dim totalHarga As Decimal = p.Harga * p.Jumlah
        If p.Jumlah >= 100 Then
            p.Diskon = totalHarga * 0.1D
        Else
            p.Diskon = 0D
        End If
        p.Subtotal = totalHarga - p.Diskon
    End Sub

    Private Sub HitungTotal()
        Dim total As Decimal = 0
        For Each p As Pesanan In daftarPesanan
            total += p.Subtotal
        Next
        lblTotal.Text = "Rp " & total.ToString("N0",
                            New CultureInfo("id-ID"))

        For Each p As Pesanan In daftarPesanan
            total += p.Subtotal
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            errInput.Clear()
            Dim valid As Boolean = True
            Dim jumlah As Integer
            If cboLayanan.SelectedIndex = -1 Then
                errInput.SetError(cboLayanan, "Pilih layanan terlebih dahulu!")
                valid = False
            End If
            If txtJumlah.Text.Trim() = "" Then
                errInput.SetError(txtJumlah, "Jumlah tidak boleh kosong!")
                valid = False
            ElseIf Not Integer.TryParse(txtJumlah.Text, jumlah) Then
                errInput.SetError(txtJumlah, "Jumlah harus berupa bilangan bulat!")
                valid = False
            ElseIf jumlah < 1 OrElse jumlah > 1000 Then
                errInput.SetError(txtJumlah, "Jumlah harus antara 1 sampai 1000!")
                valid = False
            End If
            If Not valid Then Exit Sub

            Dim layanan As String = cboLayanan.SelectedItem.ToString()
            Dim harga As Decimal = HargaSatuan(layanan)
            Dim pesananLama As Pesanan =
                daftarPesanan.FirstOrDefault(
                    Function(p) p.Layanan = layanan
                )

            If pesananLama IsNot Nothing Then
                Dim jumlahGabungan As Integer =
                    pesananLama.Jumlah + jumlah

                If jumlahGabungan > 1000 Then
                    errInput.SetError(txtJumlah,
                        "Jumlah gabungan tidak boleh lebih dari 1000!")
                    Exit Sub
                End If

                pesananLama.Jumlah = jumlahGabungan
                HitungPesanan(pesananLama)
                bsPesanan.ResetBindings(False)
            Else

                Dim p As New Pesanan With {
                    .Layanan = layanan,
                    .Jumlah = jumlah,
                    .Harga = harga
                }

                HitungPesanan(p)
                daftarPesanan.Add(p)
                bsPesanan.ResetBindings(False)
            End If


            HitungTotal()
            cboLayanan.SelectedIndex = -1
            txtJumlah.Clear()
            errInput.Clear()
        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Terjadi Kesalahan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub



    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        Dim jawaban As DialogResult = MessageBox.Show(
            "Hapus semua pesanan dan mulai transaksi baru?",
            "Transaksi Baru",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If jawaban = DialogResult.Yes Then
            daftarPesanan.Clear()
            bsPesanan.ResetBindings(False)
            cboLayanan.SelectedIndex = -1
            txtJumlah.Clear()
            errInput.Clear()
            lblTotal.Text = "Rp 0"
        End If

    End Sub

End Class
