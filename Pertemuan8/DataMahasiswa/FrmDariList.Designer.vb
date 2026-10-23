<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDariList
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
        lblCari = New Label()
        dgvMahasiswa = New DataGridView()
        txtCari = New TextBox()
        lblJumlah = New Label()
        bsMahasiswa = New BindingSource(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(316, 57)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(166, 15)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Mencari di List(Of Mahasiswa)"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(205, 106)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(92, 15)
        lblCari.TabIndex = 1
        lblCari.Text = "Cari nama/NIM:"
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(205, 153)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.Size = New Size(396, 190)
        dgvMahasiswa.TabIndex = 3
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(463, 106)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(100, 23)
        txtCari.TabIndex = 4
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(205, 373)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(115, 15)
        lblJumlah.TabIndex = 5
        lblJumlah.Text = "Menampilkan 0 data"
        ' 
        ' FrmDariList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblJumlah)
        Controls.Add(txtCari)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblCari)
        Controls.Add(lblJudul)
        Name = "FrmDariList"
        Text = "FrmCariList"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents bsMahasiswa As BindingSource
End Class
