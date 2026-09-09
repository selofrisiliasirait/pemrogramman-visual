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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Combo_role = New ComboBox()
        txt_Username = New TextBox()
        txt_password = New TextBox()
        btn_masuk = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(342, 79)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(338, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 15)
        Label1.TabIndex = 1
        Label1.Text = "Masukkan data diri"
        ' 
        ' Combo_role
        ' 
        Combo_role.FormattingEnabled = True
        Combo_role.Items.AddRange(New Object() {"Staff", "Manajer"})
        Combo_role.Location = New Point(330, 204)
        Combo_role.Name = "Combo_role"
        Combo_role.Size = New Size(121, 23)
        Combo_role.TabIndex = 2
        ' 
        ' txt_Username
        ' 
        txt_Username.Location = New Point(342, 253)
        txt_Username.Name = "txt_Username"
        txt_Username.Size = New Size(100, 23)
        txt_Username.TabIndex = 3
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(342, 304)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(100, 23)
        txt_password.TabIndex = 4
        ' 
        ' btn_masuk
        ' 
        btn_masuk.Location = New Point(356, 357)
        btn_masuk.Name = "btn_masuk"
        btn_masuk.Size = New Size(75, 23)
        btn_masuk.TabIndex = 5
        btn_masuk.Text = "Masuk"
        btn_masuk.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_masuk)
        Controls.Add(txt_password)
        Controls.Add(txt_Username)
        Controls.Add(Combo_role)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Combo_role As ComboBox
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_masuk As Button

End Class
