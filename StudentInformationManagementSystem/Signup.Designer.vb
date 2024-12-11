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
        Label2 = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUser = New TextBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(txtUser)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(46, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1090, 513)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label2.Location = New Point(135, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 36)
        Label2.TabIndex = 8
        Label2.Text = "Student Information"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(629, 271)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Sign up"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(629, 196)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(271, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(629, 136)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(271, 27)
        txtUser.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(559, 196)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(41, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(559, 136)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(41, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label1.Location = New Point(559, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 36)
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label3.Location = New Point(135, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(291, 36)
        Label3.TabIndex = 9
        Label3.Text = "Management System"
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 20.0F)
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
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
