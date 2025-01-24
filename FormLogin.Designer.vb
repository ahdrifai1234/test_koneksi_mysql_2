<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        GroupBox1 = New GroupBox()
        txt_lihat_pass = New CheckBox()
        btn_register = New Button()
        btn_login = New Button()
        txt_password = New TextBox()
        txt_username = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(txt_lihat_pass)
        GroupBox1.Controls.Add(btn_register)
        GroupBox1.Controls.Add(btn_login)
        GroupBox1.Controls.Add(txt_password)
        GroupBox1.Controls.Add(txt_username)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(141, 157)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(503, 478)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' txt_lihat_pass
        ' 
        txt_lihat_pass.AutoSize = True
        txt_lihat_pass.Location = New Point(154, 350)
        txt_lihat_pass.Name = "txt_lihat_pass"
        txt_lihat_pass.Size = New Size(128, 24)
        txt_lihat_pass.TabIndex = 5
        txt_lihat_pass.Text = "Lihat Password"
        txt_lihat_pass.UseVisualStyleBackColor = True
        ' 
        ' btn_register
        ' 
        btn_register.Location = New Point(336, 391)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(96, 40)
        btn_register.TabIndex = 4
        btn_register.Text = "Register"
        btn_register.UseVisualStyleBackColor = True
        ' 
        ' btn_login
        ' 
        btn_login.Location = New Point(154, 391)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(167, 40)
        btn_login.TabIndex = 3
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(154, 317)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(278, 27)
        txt_password.TabIndex = 2
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(154, 272)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(278, 27)
        txt_username.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 1
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(121, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 31)
        Label1.TabIndex = 0
        Label1.Text = "Selamat Datang Kembali"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 698)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents txt_lihat_pass As CheckBox
End Class
