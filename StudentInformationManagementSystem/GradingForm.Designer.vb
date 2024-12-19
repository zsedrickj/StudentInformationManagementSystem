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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseEnrollment))
        btnExit = New Button()
        btnDelete = New Button()
        btnStudentEnrollment = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label9 = New Label()
        pnlNav = New Panel()
        Panel1 = New Panel()
        Button2 = New Button()
        Panel4 = New Panel()
        Label8 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel3 = New Panel()
        Label5 = New Label()
        btnSubmit = New Button()
        txtCourses = New TextBox()
        btnSearch = New Button()
        txtStudentName = New TextBox()
        txtGrade = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
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
        ' btnDelete
        ' 
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnDelete.Location = New Point(0, 237)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(249, 37)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Grading Form"
        btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnStudentEnrollment
        ' 
        btnStudentEnrollment.BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        btnStudentEnrollment.Cursor = Cursors.Hand
        btnStudentEnrollment.FlatAppearance.BorderSize = 0
        btnStudentEnrollment.FlatStyle = FlatStyle.Flat
        btnStudentEnrollment.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudentEnrollment.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnStudentEnrollment.Location = New Point(0, 194)
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
        Panel1.Controls.Add(btnDelete)
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
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Button2.Location = New Point(0, 151)
        Button2.Name = "Button2"
        Button2.Size = New Size(249, 37)
        Button2.TabIndex = 3
        Button2.Text = "Dashboard"
        Button2.TextImageRelation = TextImageRelation.TextBeforeImage
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(316, 22)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(793, 92)
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(btnSubmit)
        Panel3.Controls.Add(txtCourses)
        Panel3.Controls.Add(btnSearch)
        Panel3.Controls.Add(txtStudentName)
        Panel3.Controls.Add(txtGrade)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(316, 126)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(793, 414)
        Panel3.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label5.Location = New Point(54, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 29)
        Label5.TabIndex = 11
        Label5.Text = "Add Grade"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(535, 210)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtCourses
        ' 
        txtCourses.Location = New Point(306, 125)
        txtCourses.Name = "txtCourses"
        txtCourses.Size = New Size(323, 27)
        txtCourses.TabIndex = 9
        ' 
        ' btnSearch
        ' 
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.Location = New Point(600, 85)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(29, 29)
        btnSearch.TabIndex = 8
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Location = New Point(306, 86)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(288, 27)
        txtStudentName.TabIndex = 7
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(306, 156)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(323, 27)
        txtGrade.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(218, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 4
        Label3.Text = "Grade:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(208, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 25)
        Label4.TabIndex = 2
        Label4.Text = "Course:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(147, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 25)
        Label2.TabIndex = 0
        Label2.Text = "Student Name:"
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
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnStudentEnrollment As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlNav As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCourses As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label5 As Label

End Class
