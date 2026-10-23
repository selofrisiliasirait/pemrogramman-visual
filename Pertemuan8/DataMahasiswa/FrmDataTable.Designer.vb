<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataTable
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
        txtCari = New TextBox()
        btnRapikan = New Button()
        dgvMahasiswa = New DataGridView()
        lblJumlah = New Label()
        bsMahasiswa = New BindingSource(components)
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(307, 55)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(149, 15)
        lblJudul.TabIndex = 0
        lblJudul.Text = "DataTable + BindingSource"
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Location = New Point(124, 100)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(92, 15)
        lblCari.TabIndex = 1
        lblCari.Text = "Cari nama/NIM:"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(262, 97)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(100, 23)
        txtCari.TabIndex = 2
        ' 
        ' btnRapikan
        ' 
        btnRapikan.Location = New Point(510, 92)
        btnRapikan.Name = "btnRapikan"
        btnRapikan.Size = New Size(128, 23)
        btnRapikan.TabIndex = 3
        btnRapikan.Text = "Rapikan Kolom"
        btnRapikan.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(124, 146)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.Size = New Size(514, 182)
        dgvMahasiswa.TabIndex = 4
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(125, 356)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(147, 15)
        lblJumlah.TabIndex = 5
        lblJumlah.Text = "Menampilkan 0 dari 0 data"
        ' 
        ' FrmDataTable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblJumlah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnRapikan)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(lblJudul)
        Name = "FrmDataTable"
        Text = "FrmDataTable"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnRapikan As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents bsMahasiswa As BindingSource
End Class
