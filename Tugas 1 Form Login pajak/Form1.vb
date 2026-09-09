Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text = "Staff" Then
            picImage.Image = Image.FromFile("Assets\Staff.png")
        ElseIf cmbRole.Text = "Manager" Then
            picImage.Image = Image.FromFile("Assets\Manager.jpg")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.SelectedIndex = 0
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cmbRole.Text = "Staff" AndAlso txtNama.Text.Trim().ToLower() = "selo" AndAlso txtNim.Text = "067" Then
            Form2.Show()
            Me.Hide()
            txtNama.Clear()
            txtNim.Clear()

        ElseIf cmbRole.Text = "Manager" AndAlso txtNama.Text.Trim().ToLower() = "harry" AndAlso txtNim.Text = "001" Then
            Form2.Show()
            Me.Hide()
            txtNama.Clear()
            txtNim.Clear()

        Else
            MessageBox.Show("Masukkan akun yang benar", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lblNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub txtNim_TextChanged(sender As Object, e As EventArgs) Handles txtNim.TextChanged

    End Sub
End Class

