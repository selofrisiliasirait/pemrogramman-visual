<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUjiKonversi
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
        lblJudul = New Label()
        lblPetunjuk = New Label()
        lblInput = New Label()
        txtInput = New TextBox()
        btnCInt = New Button()
        btnVal = New Button()
        btnTryParse = New Button()
        btnTryCatch = New Button()
        btnCatchBertingkat = New Button()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(33, 52)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(172, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Uji Konversi Input"
        ' 
        ' lblPetunjuk
        ' 
        lblPetunjuk.Location = New Point(25, 95)
        lblPetunjuk.Name = "lblPetunjuk"
        lblPetunjuk.Size = New Size(304, 49)
        lblPetunjuk.TabIndex = 1
        lblPetunjuk.Text = "Ketik sebuah nilai lalu coba setiap tombol. Coba: 25, abc, 12abc, 3,5, 99999999999, atau kosong."
        ' 
        ' lblInput
        ' 
        lblInput.AutoSize = True
        lblInput.Location = New Point(38, 163)
        lblInput.Name = "lblInput"
        lblInput.Size = New Size(38, 15)
        lblInput.TabIndex = 2
        lblInput.Text = "Input:"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(105, 163)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(100, 23)
        txtInput.TabIndex = 3
        ' 
        ' btnCInt
        ' 
        btnCInt.Location = New Point(30, 211)
        btnCInt.Name = "btnCInt"
        btnCInt.Size = New Size(75, 23)
        btnCInt.TabIndex = 4
        btnCInt.Text = "CInt (tanpa Try)"
        btnCInt.UseVisualStyleBackColor = True
        ' 
        ' btnVal
        ' 
        btnVal.Location = New Point(146, 211)
        btnVal.Name = "btnVal"
        btnVal.Size = New Size(75, 23)
        btnVal.TabIndex = 5
        btnVal.Text = "Val"
        btnVal.UseVisualStyleBackColor = True
        ' 
        ' btnTryParse
        ' 
        btnTryParse.Location = New Point(266, 211)
        btnTryParse.Name = "btnTryParse"
        btnTryParse.Size = New Size(75, 23)
        btnTryParse.TabIndex = 6
        btnTryParse.Text = "TryParse"
        btnTryParse.UseVisualStyleBackColor = True
        ' 
        ' btnTryCatch
        ' 
        btnTryCatch.Location = New Point(388, 211)
        btnTryCatch.Name = "btnTryCatch"
        btnTryCatch.Size = New Size(75, 23)
        btnTryCatch.TabIndex = 7
        btnTryCatch.Text = "Try... Catch"
        btnTryCatch.UseVisualStyleBackColor = True
        ' 
        ' btnCatchBertingkat
        ' 
        btnCatchBertingkat.Location = New Point(523, 211)
        btnCatchBertingkat.Name = "btnCatchBertingkat"
        btnCatchBertingkat.Size = New Size(118, 23)
        btnCatchBertingkat.TabIndex = 8
        btnCatchBertingkat.Text = "Catch Bertingkat"
        btnCatchBertingkat.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(38, 305)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(135, 15)
        lblHasil.TabIndex = 9
        lblHasil.Text = vbTab & "Hasil akan tampil di sini."
        ' 
        ' FrmUjiKonversi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHasil)
        Controls.Add(btnCatchBertingkat)
        Controls.Add(btnTryCatch)
        Controls.Add(btnTryParse)
        Controls.Add(btnVal)
        Controls.Add(btnCInt)
        Controls.Add(txtInput)
        Controls.Add(lblInput)
        Controls.Add(lblPetunjuk)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmUjiKonversi"
        Padding = New Padding(8)
        Text = "Uji Konversi Input"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPetunjuk As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCInt As Button
    Friend WithEvents btnVal As Button
    Friend WithEvents btnTryParse As Button
    Friend WithEvents btnTryCatch As Button
    Friend WithEvents btnCatchBertingkat As Button
    Friend WithEvents lblHasil As Label
End Class
