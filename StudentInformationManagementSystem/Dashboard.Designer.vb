<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartmentForm))
        btnExit = New Button()
        btnCourseForm = New Button()
        btnStudentEnrollment = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label9 = New Label()
        pnlNav = New Panel()
        Panel1 = New Panel()
        Button2 = New Button()
        Panel3 = New Panel()
        btnDelete = New Button()
        btnUpdate = New Button()
        dgvStudentList = New DataGridView()
        Panel7 = New Panel()
        lblCourses = New Label()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        Panel6 = New Panel()
        lblDepartments = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Panel5 = New Panel()
        lblStudents = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Panel4 = New Panel()
        Label8 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvStudentList, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
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
        ' btnCourseForm
        ' 
        btnCourseForm.Cursor = Cursors.Hand
        btnCourseForm.FlatAppearance.BorderSize = 0
        btnCourseForm.FlatStyle = FlatStyle.Flat
        btnCourseForm.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCourseForm.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnCourseForm.Location = New Point(0, 237)
        btnCourseForm.Name = "btnCourseForm"
        btnCourseForm.Size = New Size(249, 37)
        btnCourseForm.TabIndex = 1
        btnCourseForm.Text = "Grading Form"
        btnCourseForm.TextImageRelation = TextImageRelation.TextBeforeImage
        btnCourseForm.UseVisualStyleBackColor = True
        ' 
        ' btnStudentEnrollment
        ' 
        btnStudentEnrollment.BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        btnStudentEnrollment.Cursor = Cursors.Hand
        btnStudentEnrollment.FlatAppearance.BorderSize = 0
        btnStudentEnrollment.FlatStyle = FlatStyle.Flat
        btnStudentEnrollment.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudentEnrollment.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnStudentEnrollment.Location = New Point(3, 194)
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
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnCourseForm)
        Panel1.Controls.Add(btnStudentEnrollment)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(31, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 501)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.DialogResult = DialogResult.OK
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Button2.Location = New Point(3, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(249, 37)
        Button2.TabIndex = 3
        Button2.Text = "Dashboard"
        Button2.TextImageRelation = TextImageRelation.TextBeforeImage
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(dgvStudentList)
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Location = New Point(316, 126)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(772, 397)
        Panel3.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(630, 358)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(83, 29)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(540, 358)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(83, 29)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' dgvStudentList
        ' 
        dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudentList.Location = New Point(26, 179)
        dgvStudentList.Name = "dgvStudentList"
        dgvStudentList.RowHeadersWidth = 51
        dgvStudentList.Size = New Size(687, 170)
        dgvStudentList.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(71), CByte(73), CByte(115))
        Panel7.Controls.Add(lblCourses)
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(PictureBox4)
        Panel7.Location = New Point(540, 25)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(173, 125)
        Panel7.TabIndex = 1
        ' 
        ' lblCourses
        ' 
        lblCourses.AutoSize = True
        lblCourses.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCourses.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        lblCourses.Location = New Point(13, 14)
        lblCourses.Name = "lblCourses"
        lblCourses.Size = New Size(20, 29)
        lblCourses.TabIndex = 5
        lblCourses.Text = "."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label4.Location = New Point(13, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 3
        Label4.Text = "Courses"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(115, 77)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(45, 45)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(71), CByte(73), CByte(115))
        Panel6.Controls.Add(lblDepartments)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(PictureBox3)
        Panel6.Location = New Point(288, 25)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(173, 125)
        Panel6.TabIndex = 1
        ' 
        ' lblDepartments
        ' 
        lblDepartments.AutoSize = True
        lblDepartments.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDepartments.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        lblDepartments.Location = New Point(15, 14)
        lblDepartments.Name = "lblDepartments"
        lblDepartments.Size = New Size(20, 29)
        lblDepartments.TabIndex = 4
        lblDepartments.Text = "."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label3.Location = New Point(3, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 20)
        Label3.TabIndex = 3
        Label3.Text = "Departments"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(125, 77)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 45)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(71), CByte(73), CByte(115))
        Panel5.Controls.Add(lblStudents)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(PictureBox2)
        Panel5.Location = New Point(26, 24)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(173, 125)
        Panel5.TabIndex = 0
        ' 
        ' lblStudents
        ' 
        lblStudents.AutoSize = True
        lblStudents.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudents.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        lblStudents.Location = New Point(12, 15)
        lblStudents.Name = "lblStudents"
        lblStudents.Size = New Size(20, 29)
        lblStudents.TabIndex = 3
        lblStudents.Text = "."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label2.Location = New Point(12, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 2
        Label2.Text = "Students"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(116, 77)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 45)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
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
        Label8.Size = New Size(209, 29)
        Label8.TabIndex = 0
        Label8.Text = "Welcome Admin!"
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        ClientSize = New Size(1181, 577)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Font = New Font("Microsoft Sans Serif", 10.2F)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(dgvStudentList, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCourseForm As Button
    Friend WithEvents btnStudentEnrollment As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlNav As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvStudentList As DataGridView
    Friend WithEvents lblCourses As Label
    Friend WithEvents lblDepartments As Label
    Friend WithEvents lblStudents As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button

End Class
