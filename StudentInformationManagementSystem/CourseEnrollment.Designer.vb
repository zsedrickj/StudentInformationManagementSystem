<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseEnrollment
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
        Button1 = New Button()
        btnExit = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnStudentEnrollment = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lbl_userName = New Label()
        Label9 = New Label()
        pnlNav = New Panel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label8 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Button1.Location = New Point(0, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(249, 37)
        Button1.TabIndex = 2
        Button1.Text = "Payment Management"
        Button1.TextImageRelation = TextImageRelation.TextBeforeImage
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Dock = DockStyle.Bottom
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnExit.Location = New Point(0, 464)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(249, 37)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Dock = DockStyle.Top
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnDelete.Location = New Point(0, 219)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(249, 37)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Grading Form"
        btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Dock = DockStyle.Top
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnUpdate.Location = New Point(0, 182)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(249, 37)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "Course Enrollment"
        btnUpdate.TextImageRelation = TextImageRelation.TextBeforeImage
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnStudentEnrollment
        ' 
        btnStudentEnrollment.BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        btnStudentEnrollment.Cursor = Cursors.Hand
        btnStudentEnrollment.Dock = DockStyle.Top
        btnStudentEnrollment.FlatAppearance.BorderSize = 0
        btnStudentEnrollment.FlatStyle = FlatStyle.Flat
        btnStudentEnrollment.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudentEnrollment.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnStudentEnrollment.Location = New Point(0, 145)
        btnStudentEnrollment.Name = "btnStudentEnrollment"
        btnStudentEnrollment.Size = New Size(249, 37)
        btnStudentEnrollment.TabIndex = 1
        btnStudentEnrollment.Text = "Student Enrollment"
        btnStudentEnrollment.TextImageRelation = TextImageRelation.TextBeforeImage
        btnStudentEnrollment.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label1.Location = New Point(101, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 1
        Label1.Text = "Student"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.output_onlinegiftools__3_
        PictureBox1.Location = New Point(20, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(88, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbl_userName)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(pnlNav)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(249, 145)
        Panel2.TabIndex = 0
        ' 
        ' lbl_userName
        ' 
        lbl_userName.AutoSize = True
        lbl_userName.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_userName.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        lbl_userName.Location = New Point(70, 104)
        lbl_userName.Name = "lbl_userName"
        lbl_userName.Size = New Size(57, 20)
        lbl_userName.TabIndex = 3
        lbl_userName.Text = "Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label9.Location = New Point(101, 51)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 20)
        Label9.TabIndex = 2
        Label9.Text = "Management"
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.FromArgb(CByte(0), CByte(126), CByte(249))
        pnlNav.Location = New Point(0, 168)
        pnlNav.Name = "pnlNav"
        pnlNav.Size = New Size(3, 87)
        pnlNav.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnStudentEnrollment)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(31, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 501)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Location = New Point(316, 126)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(772, 397)
        Panel3.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(316, 22)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(772, 92)
        Panel4.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label8.Location = New Point(54, 31)
        Label8.Name = "Label8"
        Label8.Size = New Size(225, 29)
        Label8.TabIndex = 0
        Label8.Text = "Welcome Student!"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' CourseEnrollment
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        ClientSize = New Size(1181, 577)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Font = New Font("Microsoft Sans Serif", 10.2F)
        FormBorderStyle = FormBorderStyle.None
        Name = "CourseEnrollment"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnStudentEnrollment As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlNav As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_userName As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand

End Class
