<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKasir
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
        Label1 = New Label()
        Label2 = New Label()
        txtJumlah = New TextBox()
        cboLayanan = New ComboBox()
        lblJumlah = New Label()
        btnTambah = New Button()
        btnBaru = New Button()
        dgvPesanan = New DataGridView()
        lblTotal = New Label()
        errInput = New ErrorProvider(components)
        bsPesanan = New BindingSource(components)
        Label3 = New Label()
        CType(dgvPesanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsPesanan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 25)
        Label1.TabIndex = 0
        Label1.Text = "Kasir Fotokopi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "Layanan"
        ' 
        ' txtJumlah
        ' 
        txtJumlah.Location = New Point(169, 112)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(100, 23)
        txtJumlah.TabIndex = 2
        ' 
        ' cboLayanan
        ' 
        cboLayanan.FormattingEnabled = True
        cboLayanan.Location = New Point(169, 76)
        cboLayanan.Name = "cboLayanan"
        cboLayanan.Size = New Size(121, 23)
        cboLayanan.TabIndex = 3
        ' 
        ' lblJumlah
        ' 
        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(51, 115)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(96, 15)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Jumlah (Lembar)"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(332, 75)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBaru
        ' 
        btnBaru.Location = New Point(449, 76)
        btnBaru.Name = "btnBaru"
        btnBaru.Size = New Size(110, 23)
        btnBaru.TabIndex = 6
        btnBaru.Text = "Transaksi Baru"
        btnBaru.UseVisualStyleBackColor = True
        ' 
        ' dgvPesanan
        ' 
        dgvPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPesanan.Location = New Point(51, 158)
        dgvPesanan.Name = "dgvPesanan"
        dgvPesanan.Size = New Size(508, 150)
        dgvPesanan.TabIndex = 7
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(526, 336)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(33, 15)
        lblTotal.TabIndex = 8
        lblTotal.Text = "Rp 0 "
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 336)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 9
        Label3.Text = "Total Bayar"
        ' 
        ' FrmKasir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(lblTotal)
        Controls.Add(dgvPesanan)
        Controls.Add(btnBaru)
        Controls.Add(btnTambah)
        Controls.Add(lblJumlah)
        Controls.Add(cboLayanan)
        Controls.Add(txtJumlah)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmKasir"
        Text = "Form1"
        CType(dgvPesanan, ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        CType(bsPesanan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents cboLayanan As ComboBox
    Friend WithEvents lblJumlah As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents errInput As ErrorProvider
    Friend WithEvents bsPesanan As BindingSource
    Friend WithEvents Label3 As Label

End Class
