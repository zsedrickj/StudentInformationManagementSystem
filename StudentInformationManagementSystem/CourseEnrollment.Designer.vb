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
        btnPaymentManagement = New Button()
        btnExit = New Button()
        btnGradingForm = New Button()
        btnCourseEnrollment = New Button()
        btnStudentEnrollment = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        lbl_userName = New Label()
        Label9 = New Label()
        pnlNav = New Panel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        btnSubmit = New Button()
        DateTimePicker1 = New DateTimePicker()
        lblStatus = New Label()
        Label2 = New Label()
        cmbCourses = New ComboBox()
        txtStudentId = New TextBox()
        Panel4 = New Panel()
        Label8 = New Label()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        MySqlCommand2 = New MySql.Data.MySqlClient.MySqlCommand()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPaymentManagement
        ' 
        btnPaymentManagement.Cursor = Cursors.Hand
        btnPaymentManagement.Dock = DockStyle.Top
        btnPaymentManagement.FlatAppearance.BorderSize = 0
        btnPaymentManagement.FlatStyle = FlatStyle.Flat
        btnPaymentManagement.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPaymentManagement.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnPaymentManagement.Location = New Point(0, 256)
        btnPaymentManagement.Name = "btnPaymentManagement"
        btnPaymentManagement.Size = New Size(249, 37)
        btnPaymentManagement.TabIndex = 2
        btnPaymentManagement.Text = "Payment Management"
        btnPaymentManagement.TextImageRelation = TextImageRelation.TextBeforeImage
        btnPaymentManagement.UseVisualStyleBackColor = True
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
        ' btnGradingForm
        ' 
        btnGradingForm.Cursor = Cursors.Hand
        btnGradingForm.Dock = DockStyle.Top
        btnGradingForm.FlatAppearance.BorderSize = 0
        btnGradingForm.FlatStyle = FlatStyle.Flat
        btnGradingForm.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGradingForm.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnGradingForm.Location = New Point(0, 219)
        btnGradingForm.Name = "btnGradingForm"
        btnGradingForm.Size = New Size(249, 37)
        btnGradingForm.TabIndex = 1
        btnGradingForm.Text = "Grading Form"
        btnGradingForm.TextImageRelation = TextImageRelation.TextBeforeImage
        btnGradingForm.UseVisualStyleBackColor = True
        ' 
        ' btnCourseEnrollment
        ' 
        btnCourseEnrollment.Cursor = Cursors.Hand
        btnCourseEnrollment.Dock = DockStyle.Top
        btnCourseEnrollment.FlatAppearance.BorderSize = 0
        btnCourseEnrollment.FlatStyle = FlatStyle.Flat
        btnCourseEnrollment.Font = New Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCourseEnrollment.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        btnCourseEnrollment.Location = New Point(0, 182)
        btnCourseEnrollment.Name = "btnCourseEnrollment"
        btnCourseEnrollment.Size = New Size(249, 37)
        btnCourseEnrollment.TabIndex = 1
        btnCourseEnrollment.Text = "Course Enrollment"
        btnCourseEnrollment.TextImageRelation = TextImageRelation.TextBeforeImage
        btnCourseEnrollment.UseVisualStyleBackColor = True
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
        Panel1.Controls.Add(btnPaymentManagement)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnGradingForm)
        Panel1.Controls.Add(btnCourseEnrollment)
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
        Panel3.Controls.Add(btnSubmit)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(lblStatus)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(cmbCourses)
        Panel3.Controls.Add(txtStudentId)
        Panel3.Location = New Point(316, 126)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(772, 397)
        Panel3.TabIndex = 1
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(95, 242)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(95, 178)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(365, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        lblStatus.Location = New Point(677, 332)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(20, 29)
        lblStatus.TabIndex = 3
        lblStatus.Text = "."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label2.Location = New Point(95, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 29)
        Label2.TabIndex = 2
        Label2.Text = "Select Course "
        ' 
        ' cmbCourses
        ' 
        cmbCourses.FormattingEnabled = True
        cmbCourses.Location = New Point(95, 119)
        cmbCourses.Name = "cmbCourses"
        cmbCourses.Size = New Size(365, 28)
        cmbCourses.TabIndex = 1
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(703, 12)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(51, 27)
        txtStudentId.TabIndex = 0
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
        ' MySqlCommand2
        ' 
        MySqlCommand2.CacheAge = 0
        MySqlCommand2.Connection = Nothing
        MySqlCommand2.EnableCaching = False
        MySqlCommand2.Transaction = Nothing
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
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGradingForm As Button
    Friend WithEvents btnCourseEnrollment As Button
    Friend WithEvents btnStudentEnrollment As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPaymentManagement As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlNav As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_userName As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCourses As ComboBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents MySqlCommand2 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents btnSubmit As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblStatus As Label

End Class
