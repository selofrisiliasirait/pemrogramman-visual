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
        PictureBox1 = New PictureBox()
        lbl_nama = New Label()
        lbl_role = New Label()
        btn_logout = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(340, 106)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lbl_nama
        ' 
        lbl_nama.AutoSize = True
        lbl_nama.Location = New Point(343, 188)
        lbl_nama.Name = "lbl_nama"
        lbl_nama.Size = New Size(39, 15)
        lbl_nama.TabIndex = 1
        lbl_nama.Text = "Nama"
        ' 
        ' lbl_role
        ' 
        lbl_role.AutoSize = True
        lbl_role.Location = New Point(344, 221)
        lbl_role.Name = "lbl_role"
        lbl_role.Size = New Size(30, 15)
        lbl_role.TabIndex = 2
        lbl_role.Text = "Role"
        ' 
        ' btn_logout
        ' 
        btn_logout.Location = New Point(354, 277)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(75, 23)
        btn_logout.TabIndex = 3
        btn_logout.Text = "Log out"
        btn_logout.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_logout)
        Controls.Add(lbl_role)
        Controls.Add(lbl_nama)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_nama As Label
    Friend WithEvents lbl_role As Label
    Friend WithEvents btn_logout As Button
End Class
