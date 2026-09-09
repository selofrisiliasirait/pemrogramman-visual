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
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        txtNama = New TextBox()
        txtNim = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(215, 12)
        picImage.Name = "picImage"
        picImage.Size = New Size(161, 115)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(238, 145)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(121, 23)
        cmbRole.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(276, 193)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 2
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(276, 241)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(100, 23)
        txtNim.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(202, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 4
        Label1.Text = "Nama : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 5
        Label2.Text = "NIM: "
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(242, 290)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 6
        btnLogin.Text = "log in"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        Name = "Form1"
        Text = "Form1"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button

End Class
