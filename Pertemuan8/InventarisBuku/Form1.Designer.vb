<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventaris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblKodeBuku = New Label()
        lblJudul = New Label()
        lblPenulis = New Label()
        lblKategori = New Label()
        lblTahun = New Label()
        lblStok = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        txtPenulis = New TextBox()
        txtTahun = New TextBox()
        txtStok = New TextBox()
        lblJudulForm = New Label()
        cboKategori = New ComboBox()
        btnTambah = New Button()
        btnBersihkan = New Button()
        lblCari = New Label()
        lblFilterkategori = New Label()
        txtCari = New TextBox()
        cboFilterKategori = New ComboBox()
        dgvBuku = New DataGridView()
        lblJumlah = New Label()
        lblTotalStok = New Label()
        bsBuku = New BindingSource(components)
        errBuku = New ErrorProvider(components)
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(errBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(33, 59)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(64, 15)
        lblKodeBuku.TabIndex = 0
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(33, 117)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(65, 15)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Judul Buku"
        ' 
        ' lblPenulis
        ' 
        lblPenulis.AutoSize = True
        lblPenulis.Location = New Point(33, 182)
        lblPenulis.Name = "lblPenulis"
        lblPenulis.Size = New Size(45, 15)
        lblPenulis.TabIndex = 2
        lblPenulis.Text = "Penulis"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(33, 249)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(51, 15)
        lblKategori.TabIndex = 3
        lblKategori.Text = "Kategori"
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(33, 308)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(71, 15)
        lblTahun.TabIndex = 4
        lblTahun.Text = "Tahun Terbit"
        ' 
        ' lblStok
        ' 
        lblStok.AutoSize = True
        lblStok.Location = New Point(33, 365)
        lblStok.Name = "lblStok"
        lblStok.Size = New Size(30, 15)
        lblStok.TabIndex = 5
        lblStok.Text = "Stok"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(33, 77)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(100, 23)
        txtKodeBuku.TabIndex = 6
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(33, 135)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(100, 23)
        txtJudul.TabIndex = 7
        ' 
        ' txtPenulis
        ' 
        txtPenulis.Location = New Point(33, 200)
        txtPenulis.Name = "txtPenulis"
        txtPenulis.Size = New Size(100, 23)
        txtPenulis.TabIndex = 8
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(33, 326)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(100, 23)
        txtTahun.TabIndex = 10
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(33, 383)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(100, 23)
        txtStok.TabIndex = 11
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(33, 22)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(278, 25)
        lblJudulForm.TabIndex = 12
        lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        ' 
        ' cboKategori
        ' 
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(33, 267)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(121, 23)
        cboKategori.TabIndex = 13
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(33, 428)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 14
        btnTambah.Text = "Tambah Buku"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(154, 428)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(75, 23)
        btnBersihkan.TabIndex = 15
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(317, 59)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(102, 15)
        lblCari.TabIndex = 16
        lblCari.Text = "Cari Judul/Penulis"
        ' 
        ' lblFilterkategori
        ' 
        lblFilterkategori.AutoSize = True
        lblFilterkategori.Location = New Point(321, 117)
        lblFilterkategori.Name = "lblFilterkategori"
        lblFilterkategori.Size = New Size(80, 15)
        lblFilterkategori.TabIndex = 17
        lblFilterkategori.Text = "Filter Kategori"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(322, 82)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(379, 23)
        txtCari.TabIndex = 18
        ' 
        ' cboFilterKategori
        ' 
        cboFilterKategori.FormattingEnabled = True
        cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboFilterKategori.Location = New Point(322, 135)
        cboFilterKategori.Name = "cboFilterKategori"
        cboFilterKategori.Size = New Size(121, 23)
        cboFilterKategori.TabIndex = 19
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(322, 182)
        dgvBuku.MultiSelect = False
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBuku.Size = New Size(379, 224)
        dgvBuku.TabIndex = 20
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(322, 428)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(151, 15)
        lblJumlah.TabIndex = 21
        lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        ' 
        ' lblTotalStok
        ' 
        lblTotalStok.AutoSize = True
        lblTotalStok.Location = New Point(545, 428)
        lblTotalStok.Name = "lblTotalStok"
        lblTotalStok.Size = New Size(70, 15)
        lblTotalStok.TabIndex = 22
        lblTotalStok.Text = "Total Stok: 0"
        ' 
        ' errBuku
        ' 
        errBuku.ContainerControl = Me
        ' 
        ' FrmInventaris
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 463)
        Controls.Add(lblTotalStok)
        Controls.Add(lblJumlah)
        Controls.Add(dgvBuku)
        Controls.Add(cboFilterKategori)
        Controls.Add(txtCari)
        Controls.Add(lblFilterkategori)
        Controls.Add(lblCari)
        Controls.Add(btnBersihkan)
        Controls.Add(btnTambah)
        Controls.Add(cboKategori)
        Controls.Add(lblJudulForm)
        Controls.Add(txtStok)
        Controls.Add(txtTahun)
        Controls.Add(txtPenulis)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblStok)
        Controls.Add(lblTahun)
        Controls.Add(lblKategori)
        Controls.Add(lblPenulis)
        Controls.Add(lblJudul)
        Controls.Add(lblKodeBuku)
        Name = "FrmInventaris"
        Text = "Inventaris Buku Perpustakaan"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(bsBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(errBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPenulis As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPenulis As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents lblJudulForm As Label
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblCari As Label
    Friend WithEvents lblFilterkategori As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cboFilterKategori As ComboBox
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents bsBuku As BindingSource
    Friend WithEvents errBuku As ErrorProvider

End Class
