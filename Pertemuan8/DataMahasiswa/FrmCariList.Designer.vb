<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblNim = New Label()
        txtNim = New TextBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblJurusan = New Label()
        cboJurusan = New ComboBox()
        lblAngkatan = New Label()
        txtAngkatan = New TextBox()
        lblIpk = New Label()
        txtIpk = New TextBox()
        btnTambah = New Button()
        dgvMahasiswa = New DataGridView()
        lblJumlah = New Label()
        bsMahasiswa = New BindingSource(components)
        errInput = New ErrorProvider(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(249, 29)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(198, 15)
        lblJudul.TabIndex = 0
        lblJudul.Text = "List(Of Mahasiswa) + BindingSource"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(89, 91)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(30, 15)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(206, 85)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(100, 23)
        txtNim.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(88, 148)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(206, 140)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 4
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(88, 205)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(47, 15)
        lblJurusan.TabIndex = 5
        lblJurusan.Text = "Jurusan"
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New Point(207, 197)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(121, 23)
        cboJurusan.TabIndex = 6
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New Point(88, 252)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(58, 15)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(207, 249)
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(100, 23)
        txtAngkatan.TabIndex = 8
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(89, 306)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(24, 15)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(212, 304)
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(100, 23)
        txtIpk.TabIndex = 10
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(159, 376)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 11
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(417, 85)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.Size = New Size(371, 242)
        dgvMahasiswa.TabIndex = 12
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(430, 376)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(83, 15)
        lblJumlah.TabIndex = 13
        lblJumlah.Text = "Jumlah data: 0"
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmCariList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTambah)
        Controls.Add(txtIpk)
        Controls.Add(lblIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(lblAngkatan)
        Controls.Add(cboJurusan)
        Controls.Add(lblJurusan)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        Name = "FrmCariList"
        Text = "FrmDariList"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblJurusan As Label
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents lblIpk As Label
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents bsMahasiswa As BindingSource
    Friend WithEvents errInput As ErrorProvider
End Class
