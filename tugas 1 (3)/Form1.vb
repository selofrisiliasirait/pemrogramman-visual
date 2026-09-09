Public Class Form1
    Private Sub txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_Username.TextChanged

    End Sub

    Private Sub btn_masuk_Click(sender As Object, e As EventArgs) Handles btn_masuk.Click

        Dim username As String = txt_Username.Text.Trim().ToLower()
        Dim password As String = txt_password.Text.Trim().ToLower()
        Dim role As String = Combo_role.Text.Trim().ToLower()

        If username = "harry" And password = "expelliarmus" And role = "staff" Then
            Form2.Show()

        ElseIf username = "hermione" And password = "leviosa" And role = "staff" Then
            Form2.Show()




        End If




    End Sub
End Class
