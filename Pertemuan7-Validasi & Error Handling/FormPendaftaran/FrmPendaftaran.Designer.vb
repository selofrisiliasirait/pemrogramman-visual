<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendaftaran
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
        btnSimpan = New Button()
        btnBersihkan = New Button()
        lblDaftar = New Label()
        lstMahasiswa = New ListBox()
        btnEkspor = New Button()
        lblStatus = New Label()
        errinput = New ErrorProvider(components)
        CType(errinput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(39, 41)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(221, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Pendaftaran Mahasiswa"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(39, 93)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(30, 15)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(130, 90)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(100, 23)
        txtNim.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(39, 130)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(130, 127)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 4
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(39, 171)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(47, 15)
        lblJurusan.TabIndex = 5
        lblJurusan.Text = "Jurusan"
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Location = New Point(130, 168)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(121, 23)
        cboJurusan.TabIndex = 6
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New Point(39, 214)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(58, 15)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(130, 211)
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(100, 23)
        txtAngkatan.TabIndex = 8
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(39, 254)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(24, 15)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(130, 251)
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(100, 23)
        txtIpk.TabIndex = 10
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(39, 319)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.Location = New Point(155, 319)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(75, 23)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Location = New Point(351, 84)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(88, 15)
        lblDaftar.TabIndex = 13
        lblDaftar.Text = "Data Tersimpan"
        ' 
        ' lstMahasiswa
        ' 
        lstMahasiswa.FormattingEnabled = True
        lstMahasiswa.Location = New Point(351, 102)
        lstMahasiswa.Name = "lstMahasiswa"
        lstMahasiswa.Size = New Size(364, 169)
        lstMahasiswa.TabIndex = 14
        ' 
        ' btnEkspor
        ' 
        btnEkspor.Location = New Point(351, 289)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(106, 23)
        btnEkspor.TabIndex = 15
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(39, 369)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(29, 15)
        lblStatus.TabIndex = 16
        lblStatus.Text = "Siap"
        ' 
        ' errinput
        ' 
        errinput.ContainerControl = Me
        ' 
        ' FrmPendaftaran
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(btnEkspor)
        Controls.Add(lstMahasiswa)
        Controls.Add(lblDaftar)
        Controls.Add(btnBersihkan)
        Controls.Add(btnSimpan)
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
        MaximizeBox = False
        Name = "FrmPendaftaran"
        Text = "Pendaftaran Mahasiswa"
        CType(errinput, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblDaftar As Label
    Friend WithEvents lstMahasiswa As ListBox
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents errinput As ErrorProvider
End Class
