<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1 = New Panel()
        btnBack = New Button()
        Label4 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnSignUp = New Button()
        txtPassword = New TextBox()
        txtUser = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        MySqlCommand2 = New MySql.Data.MySqlClient.MySqlCommand()
        Label5 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnSignUp)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtUser)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(46, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1090, 513)
        Panel1.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(689, 280)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 15
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label4.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label4.Location = New Point(559, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 13
        Label4.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label6.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label6.Location = New Point(559, 155)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 12
        Label6.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label3.Location = New Point(135, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(291, 36)
        Label3.TabIndex = 9
        Label3.Text = "Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label2.Location = New Point(135, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 36)
        Label2.TabIndex = 8
        Label2.Text = "Student Information"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(559, 280)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(94, 29)
        btnSignUp.TabIndex = 6
        btnSignUp.Text = "Sign up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(559, 231)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(271, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(559, 178)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(271, 27)
        txtUser.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label1.Location = New Point(559, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 29)
        Label1.TabIndex = 1
        Label1.Text = "Sign up"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(135, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 166)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' MySqlCommand2
        ' 
        MySqlCommand2.CacheAge = 0
        MySqlCommand2.Connection = Nothing
        MySqlCommand2.EnableCaching = False
        MySqlCommand2.Transaction = Nothing
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label5.Location = New Point(559, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 29)
        Label5.TabIndex = 16
        Label5.Text = "Student "
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        ClientSize = New Size(1181, 577)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 10.2F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Signup"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MySqlCommand2 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btnBack As Button
    Friend WithEvents Label5 As Label

End Class
