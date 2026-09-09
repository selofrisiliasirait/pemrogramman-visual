<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(189, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(285, 21)
        Label1.TabIndex = 0
        Label1.Text = "Pendapatan Lebih dari 5 juta, 10% Pajak"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(186, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 21)
        Label2.TabIndex = 1
        Label2.Text = "Pendapatan Lebih dari 30 juta, 20% Pajak"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(180, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(303, 21)
        Label3.TabIndex = 2
        Label3.Text = "Pendapatan Lebih dari 100 juta, 30% Pajak"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(243, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 15)
        Label4.TabIndex = 3
        Label4.Text = "Masukkan Pendapatanmu"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(243, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 15)
        Label5.TabIndex = 4
        Label5.Text = "Rp. "
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(276, 210)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(100, 23)
        txtPendapatan.TabIndex = 5
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(281, 259)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 23)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(281, 304)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class
