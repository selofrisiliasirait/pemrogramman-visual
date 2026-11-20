<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPeminjaman
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
        lblJudulForm = New Label()
        lblKodeBuku = New Label()
        lblJudul = New Label()
        lblKategori = New Label()
        lblNamaPeminjam = New Label()
        lblLamaPinjam = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        cboKategori = New ComboBox()
        txtNamaPeminjam = New TextBox()
        txtLamaPinjam = New TextBox()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        btnEkspor = New Button()
        lblDaftar = New Label()
        lstPeminjaman = New ListBox()
        lblStatus = New Label()
        errPinjam = New ErrorProvider(components)
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulForm.Location = New Point(35, 25)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(173, 25)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Peminjaman Buku"
        ' 
        ' lblKodeBuku
        ' 
        lblKodeBuku.AutoSize = True
        lblKodeBuku.Location = New Point(47, 79)
        lblKodeBuku.Name = "lblKodeBuku"
        lblKodeBuku.Size = New Size(64, 15)
        lblKodeBuku.TabIndex = 1
        lblKodeBuku.Text = "Kode Buku"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(46, 119)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(65, 15)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Judul Buku"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(48, 160)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(50, 15)
        lblKategori.TabIndex = 3
        lblKategori.Text = "kategori"
        ' 
        ' lblNamaPeminjam
        ' 
        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Location = New Point(48, 200)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New Size(96, 15)
        lblNamaPeminjam.TabIndex = 4
        lblNamaPeminjam.Text = "Nama Peminjam"
        ' 
        ' lblLamaPinjam
        ' 
        lblLamaPinjam.AutoSize = True
        lblLamaPinjam.Location = New Point(48, 241)
        lblLamaPinjam.Name = "lblLamaPinjam"
        lblLamaPinjam.Size = New Size(109, 15)
        lblLamaPinjam.TabIndex = 5
        lblLamaPinjam.Text = "Lama Pinjam (Hari)"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(165, 76)
        txtKodeBuku.MaxLength = 6
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(100, 23)
        txtKodeBuku.TabIndex = 6
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(165, 116)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(100, 23)
        txtJudul.TabIndex = 7
        ' 
        ' cboKategori
        ' 
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(165, 157)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(121, 23)
        cboKategori.TabIndex = 8
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(165, 197)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(100, 23)
        txtNamaPeminjam.TabIndex = 9
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(165, 235)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(100, 23)
        txtLamaPinjam.TabIndex = 10
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(47, 298)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(75, 23)
        btnPinjam.TabIndex = 11
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(165, 298)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(75, 23)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' btnEkspor
        ' 
        btnEkspor.Location = New Point(283, 298)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(75, 23)
        btnEkspor.TabIndex = 13
        btnEkspor.Text = "Ekspor Ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Location = New Point(434, 62)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(109, 15)
        lblDaftar.TabIndex = 14
        lblDaftar.Text = "Daftar Peminjaman"
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.Location = New Point(434, 86)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(210, 169)
        lstPeminjaman.TabIndex = 15
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(433, 275)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(100, 23)
        lblStatus.TabIndex = 16
        lblStatus.Text = "Jumlah Peminjaman: 0"
        ' 
        ' errPinjam
        ' 
        errPinjam.ContainerControl = Me
        ' 
        ' FrmPeminjaman
        ' 
        AcceptButton = btnPinjam
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(lstPeminjaman)
        Controls.Add(lblDaftar)
        Controls.Add(btnEkspor)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(txtLamaPinjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(cboKategori)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblLamaPinjam)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(lblKategori)
        Controls.Add(lblJudul)
        Controls.Add(lblKodeBuku)
        Controls.Add(lblJudulForm)
        Name = "FrmPeminjaman"
        Text = "Peminjaman Buku"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents lblKodeBuku As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblNamaPeminjam As Label
    Friend WithEvents lblLamaPinjam As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblDaftar As Label
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents errPinjam As ErrorProvider

End Class
