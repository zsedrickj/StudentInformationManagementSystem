<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentEnrollment
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
        btnExit = New Button()
        btnCourseForm = New Button()
        btnStudentEnrollment = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label9 = New Label()
        pnlNav = New Panel()
        Panel1 = New Panel()
        btnDashboard = New Button()
        Panel3 = New Panel()
        cmbCourse = New ComboBox()
        Label14 = New Label()
        btnEnroll = New Button()
        cmbDepartment = New ComboBox()
        Label13 = New Label()
        cmbProgram = New ComboBox()
        Label12 = New Label()
        cmbGender = New ComboBox()
        dtpEnrollmentDate = New DateTimePicker()
        Label11 = New Label()
        Label10 = New Label()
        dtpBirthday = New DateTimePicker()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtAddress = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        Panel4 = New Panel()
        Label8 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel1.Controls.Add(btnDashboard)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnCourseForm)
        Panel1.Controls.Add(btnStudentEnrollment)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(31, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 501)
        Panel1.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Cursor = Cursors.Hand
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnDashboard.Location = New Point(3, 151)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(249, 37)
        btnDashboard.TabIndex = 3
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(44), CByte(53), CByte(79))
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(cmbCourse)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(btnEnroll)
        Panel3.Controls.Add(cmbDepartment)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(cmbProgram)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(cmbGender)
        Panel3.Controls.Add(dtpEnrollmentDate)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(dtpBirthday)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txtAddress)
        Panel3.Controls.Add(txtPhoneNumber)
        Panel3.Controls.Add(txtEmail)
        Panel3.Controls.Add(txtLastName)
        Panel3.Controls.Add(txtFirstName)
        Panel3.Location = New Point(316, 126)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(772, 397)
        Panel3.TabIndex = 1
        ' 
        ' cmbCourse
        ' 
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(82, 307)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(612, 28)
        cmbCourse.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label14.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label14.Location = New Point(82, 284)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 20)
        Label14.TabIndex = 23
        Label14.Text = "Course"
        ' 
        ' btnEnroll
        ' 
        btnEnroll.Dock = DockStyle.Bottom
        btnEnroll.FlatAppearance.BorderSize = 0
        btnEnroll.FlatStyle = FlatStyle.Flat
        btnEnroll.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEnroll.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnEnroll.Location = New Point(0, 356)
        btnEnroll.Name = "btnEnroll"
        btnEnroll.Size = New Size(768, 37)
        btnEnroll.TabIndex = 22
        btnEnroll.Text = "Enroll Student"
        btnEnroll.UseVisualStyleBackColor = True
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(427, 201)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(267, 28)
        cmbDepartment.TabIndex = 21
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label13.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label13.Location = New Point(427, 176)
        Label13.Name = "Label13"
        Label13.Size = New Size(97, 20)
        Label13.TabIndex = 20
        Label13.Text = "Department"
        ' 
        ' cmbProgram
        ' 
        cmbProgram.FormattingEnabled = True
        cmbProgram.Location = New Point(427, 253)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(267, 28)
        cmbProgram.TabIndex = 19
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label12.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label12.Location = New Point(427, 232)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 20)
        Label12.TabIndex = 18
        Label12.Text = "Program"
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Location = New Point(427, 39)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(267, 28)
        cmbGender.TabIndex = 17
        ' 
        ' dtpEnrollmentDate
        ' 
        dtpEnrollmentDate.Location = New Point(427, 146)
        dtpEnrollmentDate.Name = "dtpEnrollmentDate"
        dtpEnrollmentDate.Size = New Size(267, 27)
        dtpEnrollmentDate.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label11.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label11.Location = New Point(427, 125)
        Label11.Name = "Label11"
        Label11.Size = New Size(130, 20)
        Label11.TabIndex = 15
        Label11.Text = "Enrollment Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label10.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label10.Location = New Point(81, 231)
        Label10.Name = "Label10"
        Label10.Size = New Size(71, 20)
        Label10.TabIndex = 14
        Label10.Text = "Birthday"
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Location = New Point(82, 254)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(267, 27)
        dtpBirthday.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label7.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label7.Location = New Point(429, 72)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 12
        Label7.Text = "Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label6.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label6.Location = New Point(427, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 11
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label5.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label5.Location = New Point(81, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 20)
        Label5.TabIndex = 10
        Label5.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label4.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label4.Location = New Point(81, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 9
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label3.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label3.Location = New Point(81, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 20)
        Label3.TabIndex = 8
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label2.Location = New Point(81, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 7
        Label2.Text = "First Name"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(427, 95)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(267, 27)
        txtAddress.TabIndex = 6
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(81, 201)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(267, 27)
        txtPhoneNumber.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(82, 148)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(267, 27)
        txtEmail.TabIndex = 3
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(81, 95)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(267, 27)
        txtLastName.TabIndex = 2
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(81, 42)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(267, 27)
        txtFirstName.TabIndex = 0
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
        ' StudentEnrollment
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
        Name = "StudentEnrollment"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
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
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpEnrollmentDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents Label14 As Label

End Class
