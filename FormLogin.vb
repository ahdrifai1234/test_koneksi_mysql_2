Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2)
    End Sub


End Class