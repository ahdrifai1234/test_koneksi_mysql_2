Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2)

        txt_username.Focus()
        txt_lihat_pass.Checked = False
        txt_password.UseSystemPasswordChar = True
    End Sub

    Sub clearForm()
        txt_password.Clear()
        txt_lihat_pass.Checked = False
        txt_username.Focus()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            MsgBox("Isi Data Username dan Password dahulu", MsgBoxStyle.Exclamation, "Login")
        Else
            Dim username As String = txt_username.Text
            Dim password As String = txt_password.Text
            If txt_username.Text = "admin" And txt_password.Text = "admin" Then
                MessageBox.Show("Login Berhasil", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
            Else
                MsgBox("Username atau password salah!", MsgBoxStyle.Exclamation, "Login")
                clearForm()
            End If
        End If
    End Sub

    Private Sub txt_username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_username.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_password.Focus()
        End If
    End Sub

    Private Sub txt_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_password.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_login.PerformClick()
        End If
    End Sub

    Private Sub txt_lihat_pass_CheckedChanged(sender As Object, e As EventArgs) Handles txt_lihat_pass.CheckedChanged
        If txt_lihat_pass.Checked Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
        txt_password.Focus()
    End Sub
End Class