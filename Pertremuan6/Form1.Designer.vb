<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        button1 = New Button()
        dgvMahasiswa = New DataGridView()
        lblNama = New Label()
        lblNim = New Label()
        lblJurusan = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        txtJurusan = New TextBox()
        btnTambah = New Button()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' button1
        ' 
        button1.Location = New Point(275, 195)
        button1.Name = "button1"
        button1.Size = New Size(75, 23)
        button1.TabIndex = 0
        button1.Text = "Tampilkan"
        button1.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(88, 25)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.Size = New Size(383, 150)
        dgvMahasiswa.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(536, 39)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(536, 84)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(30, 15)
        lblNim.TabIndex = 3
        lblNim.Text = "NIM"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(535, 124)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(47, 15)
        lblJurusan.TabIndex = 4
        lblJurusan.Text = "Jurusan"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(611, 36)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(611, 86)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(100, 23)
        txtNim.TabIndex = 6
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(610, 128)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(100, 23)
        txtJurusan.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(581, 195)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTambah)
        Controls.Add(txtJurusan)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblJurusan)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(dgvMahasiswa)
        Controls.Add(button1)
        Name = "Form1"
        Text = "Tampilkan"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents button1 As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents btnTambah As Button

End Class
