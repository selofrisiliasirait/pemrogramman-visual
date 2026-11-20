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
        lblJudul = New Label()
        lblSubjudul = New Label()
        pnlTimer = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        lblSisa = New Label()
        btnMulai = New Button()
        btnUlangi = New Button()
        btnRingkas = New Button()
        chkTeratas = New CheckBox()
        lblDurasiPresentasi = New Label()
        lblMenit = New Label()
        lblDetik = New Label()
        nudMenit = New NumericUpDown()
        nudDetik = New NumericUpDown()
        chkBunyi = New CheckBox()
        pnlTimer.SuspendLayout()
        CType(nudMenit, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudDetik, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(63, 38)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(183, 30)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Asisten Presentas"
        ' 
        ' lblSubjudul
        ' 
        lblSubjudul.AutoSize = True
        lblSubjudul.Location = New Point(63, 71)
        lblSubjudul.Name = "lblSubjudul"
        lblSubjudul.Size = New Size(227, 15)
        lblSubjudul.TabIndex = 1
        lblSubjudul.Text = "Jaga durasi tanpa meningglkan slide anda"
        ' 
        ' pnlTimer
        ' 
        pnlTimer.BackColor = SystemColors.ActiveCaptionText
        pnlTimer.Controls.Add(Label2)
        pnlTimer.Controls.Add(Label1)
        pnlTimer.Controls.Add(lblSisa)
        pnlTimer.Location = New Point(68, 110)
        pnlTimer.Name = "pnlTimer"
        pnlTimer.Size = New Size(672, 203)
        pnlTimer.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.GradientInactiveCaption
        Label2.Location = New Point(237, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 15)
        Label2.TabIndex = 2
        Label2.Text = "Atur durasi, lalu mulai ketika anda siap"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.GradientInactiveCaption
        Label1.Location = New Point(309, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 1
        Label1.Text = "Siap Presentasi"
        ' 
        ' lblSisa
        ' 
        lblSisa.AutoSize = True
        lblSisa.BackColor = Color.Transparent
        lblSisa.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSisa.ForeColor = SystemColors.GradientInactiveCaption
        lblSisa.Location = New Point(207, 35)
        lblSisa.Name = "lblSisa"
        lblSisa.Size = New Size(300, 128)
        lblSisa.TabIndex = 0
        lblSisa.Text = "05:00"
        ' 
        ' btnMulai
        ' 
        btnMulai.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMulai.Location = New Point(68, 331)
        btnMulai.Name = "btnMulai"
        btnMulai.Size = New Size(447, 41)
        btnMulai.TabIndex = 3
        btnMulai.Text = "Mulai Presentasi"
        btnMulai.UseVisualStyleBackColor = True
        ' 
        ' btnUlangi
        ' 
        btnUlangi.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUlangi.Location = New Point(533, 331)
        btnUlangi.Name = "btnUlangi"
        btnUlangi.Size = New Size(207, 41)
        btnUlangi.TabIndex = 4
        btnUlangi.Text = "Ulangi"
        btnUlangi.UseVisualStyleBackColor = True
        ' 
        ' btnRingkas
        ' 
        btnRingkas.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRingkas.Location = New Point(533, 389)
        btnRingkas.Name = "btnRingkas"
        btnRingkas.Size = New Size(207, 39)
        btnRingkas.TabIndex = 5
        btnRingkas.Text = "Mode Ringkas"
        btnRingkas.UseVisualStyleBackColor = True
        ' 
        ' chkTeratas
        ' 
        chkTeratas.AutoSize = True
        chkTeratas.Location = New Point(68, 389)
        chkTeratas.Name = "chkTeratas"
        chkTeratas.Size = New Size(155, 19)
        chkTeratas.TabIndex = 6
        chkTeratas.Text = "Tetap di atas aplikasi lain"
        chkTeratas.UseVisualStyleBackColor = True
        ' 
        ' lblDurasiPresentasi
        ' 
        lblDurasiPresentasi.AutoSize = True
        lblDurasiPresentasi.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDurasiPresentasi.Location = New Point(68, 473)
        lblDurasiPresentasi.Name = "lblDurasiPresentasi"
        lblDurasiPresentasi.Size = New Size(164, 25)
        lblDurasiPresentasi.TabIndex = 7
        lblDurasiPresentasi.Text = "Durasi Presentasi"
        ' 
        ' lblMenit
        ' 
        lblMenit.AutoSize = True
        lblMenit.Location = New Point(68, 512)
        lblMenit.Name = "lblMenit"
        lblMenit.Size = New Size(38, 15)
        lblMenit.TabIndex = 8
        lblMenit.Text = "Menit"
        ' 
        ' lblDetik
        ' 
        lblDetik.AutoSize = True
        lblDetik.Location = New Point(286, 512)
        lblDetik.Name = "lblDetik"
        lblDetik.Size = New Size(34, 15)
        lblDetik.TabIndex = 9
        lblDetik.Text = "Detik"
        ' 
        ' nudMenit
        ' 
        nudMenit.Location = New Point(118, 506)
        nudMenit.Name = "nudMenit"
        nudMenit.Size = New Size(120, 23)
        nudMenit.TabIndex = 10
        ' 
        ' nudDetik
        ' 
        nudDetik.Location = New Point(333, 506)
        nudDetik.Name = "nudDetik"
        nudDetik.Size = New Size(120, 23)
        nudDetik.TabIndex = 11
        ' 
        ' chkBunyi
        ' 
        chkBunyi.AutoSize = True
        chkBunyi.Location = New Point(492, 508)
        chkBunyi.Name = "chkBunyi"
        chkBunyi.Size = New Size(117, 19)
        chkBunyi.TabIndex = 12
        chkBunyi.Text = "Bunyi saat selesai"
        chkBunyi.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 637)
        Controls.Add(chkBunyi)
        Controls.Add(nudDetik)
        Controls.Add(nudMenit)
        Controls.Add(lblDetik)
        Controls.Add(lblMenit)
        Controls.Add(lblDurasiPresentasi)
        Controls.Add(chkTeratas)
        Controls.Add(btnRingkas)
        Controls.Add(btnUlangi)
        Controls.Add(btnMulai)
        Controls.Add(pnlTimer)
        Controls.Add(lblSubjudul)
        Controls.Add(lblJudul)
        Name = "Form1"
        Text = "Form1"
        pnlTimer.ResumeLayout(False)
        pnlTimer.PerformLayout()
        CType(nudMenit, ComponentModel.ISupportInitialize).EndInit()
        CType(nudDetik, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubjudul As Label
    Friend WithEvents pnlTimer As Panel
    Friend WithEvents lblSisa As Label
    Friend WithEvents btnMulai As Button
    Friend WithEvents btnUlangi As Button
    Friend WithEvents btnRingkas As Button
    Friend WithEvents chkTeratas As CheckBox
    Friend WithEvents lblDurasiPresentasi As Label
    Friend WithEvents lblMenit As Label
    Friend WithEvents lblDetik As Label
    Friend WithEvents nudMenit As NumericUpDown
    Friend WithEvents nudDetik As NumericUpDown
    Friend WithEvents chkBunyi As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
