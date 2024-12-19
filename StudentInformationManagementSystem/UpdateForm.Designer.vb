<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateForm

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
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1 = New Panel()
        btnBack = New Button()
        cmbGender = New ComboBox()
        btnUpdate = New Button()
        cmbCourse = New ComboBox()
        cmbProgram = New ComboBox()
        cmbDepartment = New ComboBox()
        dtpEnrollmentDate = New DateTimePicker()
        dtpBirthday = New DateTimePicker()
        txtAddress = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtLastName = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label13 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtFirstName = New TextBox()
        Label2 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
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
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(cmbGender)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(cmbCourse)
        Panel1.Controls.Add(cmbProgram)
        Panel1.Controls.Add(cmbDepartment)
        Panel1.Controls.Add(dtpEnrollmentDate)
        Panel1.Controls.Add(dtpBirthday)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(txtPhoneNumber)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtLastName)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtFirstName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(54, 57)
        Panel1.Margin = New Padding(10)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(1017, 488)
        Panel1.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(757, 423)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 37
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Location = New Point(587, 123)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(267, 28)
        cmbGender.TabIndex = 36
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(657, 423)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 35
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' cmbCourse
        ' 
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(163, 389)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(691, 28)
        cmbCourse.TabIndex = 34
        ' 
        ' cmbProgram
        ' 
        cmbProgram.FormattingEnabled = True
        cmbProgram.Location = New Point(587, 336)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(267, 28)
        cmbProgram.TabIndex = 33
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(587, 283)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(267, 28)
        cmbDepartment.TabIndex = 32
        ' 
        ' dtpEnrollmentDate
        ' 
        dtpEnrollmentDate.Location = New Point(587, 228)
        dtpEnrollmentDate.Name = "dtpEnrollmentDate"
        dtpEnrollmentDate.Size = New Size(267, 27)
        dtpEnrollmentDate.TabIndex = 31
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Location = New Point(163, 334)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(267, 27)
        dtpBirthday.TabIndex = 30
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(587, 177)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(267, 27)
        txtAddress.TabIndex = 26
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(163, 283)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(267, 27)
        txtPhoneNumber.TabIndex = 22
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(162, 230)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(267, 27)
        txtEmail.TabIndex = 21
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(163, 177)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(267, 27)
        txtLastName.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label12.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label12.Location = New Point(163, 260)
        Label12.Name = "Label12"
        Label12.Size = New Size(120, 20)
        Label12.TabIndex = 19
        Label12.Text = "Phone Number"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label11.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label11.Location = New Point(162, 366)
        Label11.Name = "Label11"
        Label11.Size = New Size(63, 20)
        Label11.TabIndex = 18
        Label11.Text = "Course"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label10.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label10.Location = New Point(587, 260)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 20)
        Label10.TabIndex = 17
        Label10.Text = "Department"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label9.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label9.Location = New Point(587, 207)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 20)
        Label9.TabIndex = 16
        Label9.Text = "Enrollment Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label7.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label7.Location = New Point(587, 154)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 15
        Label7.Text = "Address"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label13.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label13.Location = New Point(587, 101)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 20)
        Label13.TabIndex = 14
        Label13.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label5.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label5.Location = New Point(163, 313)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 20)
        Label5.TabIndex = 13
        Label5.Text = "Birthday"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label4.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label4.Location = New Point(587, 313)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 12
        Label4.Text = "Program"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label3.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label3.Location = New Point(162, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 20)
        Label3.TabIndex = 11
        Label3.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label1.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label1.Location = New Point(163, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 10
        Label1.Text = "Last Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(163, 124)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(267, 27)
        txtFirstName.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F)
        Label2.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label2.Location = New Point(163, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 8
        Label2.Text = "First Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(244), CByte(245), CByte(252))
        Label8.Location = New Point(62, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(193, 29)
        Label8.TabIndex = 1
        Label8.Text = "Update Student"
        ' 
        ' UpdateForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(41), CByte(62))
        ClientSize = New Size(1126, 610)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 10.2F)
        FormBorderStyle = FormBorderStyle.None
        Name = "UpdateForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Information Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents dtpEnrollmentDate As DateTimePicker
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbGender As ComboBox

End Class
