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
        LblNama = New Label()
        TxtNama = New TextBox()
        LblNim = New Label()
        TxtNim = New TextBox()
        TxtKom = New TextBox()
        LblKom = New Label()
        BtnTampilkan = New Button()
        BtnHapus = New Button()
        BtnKeluar = New Button()
        SuspendLayout()
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.Location = New Point(66, 34)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(39, 15)
        LblNama.TabIndex = 0
        LblNama.Text = "Nama"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(139, 31)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(100, 23)
        TxtNama.TabIndex = 1
        ' 
        ' LblNim
        ' 
        LblNim.AutoSize = True
        LblNim.Location = New Point(66, 68)
        LblNim.Name = "LblNim"
        LblNim.Size = New Size(30, 15)
        LblNim.TabIndex = 2
        LblNim.Text = "NIM"
        ' 
        ' TxtNim
        ' 
        TxtNim.Location = New Point(139, 65)
        TxtNim.Name = "TxtNim"
        TxtNim.Size = New Size(100, 23)
        TxtNim.TabIndex = 3
        ' 
        ' TxtKom
        ' 
        TxtKom.Location = New Point(139, 98)
        TxtKom.Name = "TxtKom"
        TxtKom.Size = New Size(100, 23)
        TxtKom.TabIndex = 4
        ' 
        ' LblKom
        ' 
        LblKom.AutoSize = True
        LblKom.Location = New Point(66, 101)
        LblKom.Name = "LblKom"
        LblKom.Size = New Size(33, 15)
        LblKom.TabIndex = 5
        LblKom.Text = "KOM"
        ' 
        ' BtnTampilkan
        ' 
        BtnTampilkan.Location = New Point(107, 158)
        BtnTampilkan.Name = "BtnTampilkan"
        BtnTampilkan.Size = New Size(75, 23)
        BtnTampilkan.TabIndex = 6
        BtnTampilkan.Text = "Tampilkan"
        BtnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Location = New Point(223, 161)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(75, 23)
        BtnHapus.TabIndex = 7
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.Location = New Point(176, 207)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Size = New Size(75, 23)
        BtnKeluar.TabIndex = 8
        BtnKeluar.Text = "Keluar"
        BtnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 251)
        Controls.Add(BtnKeluar)
        Controls.Add(BtnHapus)
        Controls.Add(BtnTampilkan)
        Controls.Add(LblKom)
        Controls.Add(TxtKom)
        Controls.Add(TxtNim)
        Controls.Add(LblNim)
        Controls.Add(TxtNama)
        Controls.Add(LblNama)
        Name = "Form1"
        Text = "Profile Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNama As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents LblNim As Label
    Friend WithEvents TxtNim As TextBox
    Friend WithEvents TxtKom As TextBox
    Friend WithEvents LblKom As Label
    Friend WithEvents BtnTampilkan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKeluar As Button

End Class
