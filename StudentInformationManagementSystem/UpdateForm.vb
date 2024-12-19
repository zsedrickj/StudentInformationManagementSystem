Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Imports System.Drawing.Drawing2D

Public Class UpdateForm


    Public studentAccess As New StudentDataAccess()
    Private student As Students
    Private studentData As Students
    'STORED DATA
    Public Sub New(student As Students)
        InitializeComponent()
        studentData = student
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
    ByVal nLeftRect As Integer,
    ByVal nTopRect As Integer,
    ByVal nRightRect As Integer,
    ByVal nBottomRect As Integer,
    ByVal nWidthEllipse As Integer,
    ByVal nHeightEllipse As Integer
) As IntPtr
    End Function

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25))
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        cmbGender.Items.Add("- Select Gender -")
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        PopulateForm()
        PopulateDepartmentComboBox(cmbDepartment)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New DepartmentForm
        dashboard.Show()
        Me.Hide()

    End Sub
    Private Sub PopulateForm()
        txtFirstName.Text = studentData.FirstName
        txtLastName.Text = studentData.LastName
        txtEmail.Text = studentData.Email
        txtPhoneNumber.Text = studentData.PhoneNumber
        dtpBirthday.Value = studentData.DateOfBirth
        cmbGender.SelectedItem = studentData.Gender
        txtAddress.Text = studentData.Address
        dtpEnrollmentDate.Value = studentData.EnrollmentDate


    End Sub
    Public Sub PopulateDepartmentComboBox(cmbDepartment As ComboBox)
        Try
            ' Retrieve all department names
            Dim departmentNames As List(Of String) = studentAccess.GetAllDepartmentNames()

            ' Clear existing items in the ComboBox
            cmbDepartment.Items.Clear()

            ' Add a placeholder item
            cmbDepartment.Items.Add("- Select Department -")

            ' Add each department name to the ComboBox
            For Each departmentName As String In departmentNames
                cmbDepartment.Items.Add(departmentName)
            Next

            ' Set the placeholder as the default selected item
            cmbDepartment.SelectedIndex = 0
        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error populating Department ComboBox: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        ' Check if a valid item is selected
        If cmbDepartment.SelectedIndex = -1 OrElse cmbDepartment.SelectedItem.ToString() = "- Select Department -" Then
            ' Reset the Program ComboBox if no department is selected
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("- Select Program -")
            cmbProgram.SelectedIndex = 0
            cmbProgram.Enabled = False

            ' Reset the Course ComboBox
            cmbCourse.Items.Clear()
            cmbCourse.Items.Add("- Select Course -")
            cmbCourse.SelectedIndex = 0
            cmbCourse.Enabled = False
            Return
        End If

        ' Get the selected department name
        Dim departmentName As String = cmbDepartment.SelectedItem.ToString()

        ' Fetch the department ID using the name
        Dim departmentID As Integer = studentAccess.GetDepartmentIDByName(departmentName)

        ' Validate the department ID
        If departmentID > 0 Then
            ' --- Populate Program ComboBox ---
            Dim programNames As List(Of String) = studentAccess.GetProgramNamesByDepartment(departmentID)

            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("- Select Program -")
            cmbProgram.Items.AddRange(programNames.ToArray())
            cmbProgram.SelectedIndex = 0
            cmbProgram.Enabled = True

            ' --- Populate Course ComboBox ---
            Dim courseNames As List(Of String) = studentAccess.GetCourseNamesByDepartment(departmentID)

            cmbCourse.Items.Clear()
            cmbCourse.Items.Add("- Select Course -")
            cmbCourse.Items.AddRange(courseNames.ToArray())
            cmbCourse.SelectedIndex = 0
            cmbCourse.Enabled = True
        Else
            ' Handle invalid department ID
            MessageBox.Show("Invalid department selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Reset the Program ComboBox
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("- Select Program -")
            cmbProgram.SelectedIndex = 0
            cmbProgram.Enabled = False

            ' Reset the Course ComboBox
            cmbCourse.Items.Clear()
            cmbCourse.Items.Add("- Select Course -")
            cmbCourse.SelectedIndex = 0
            cmbCourse.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validate the input fields
        If Validation() = True Then
            ' Create a new student object with updated values from the form controls
            Dim updatedStudent As New Students() With { ' Assuming StudentId is in a TextBox for identification
                .StudentId = studentData.StudentId,
                .FirstName = txtFirstName.Text, ' Assuming these are TextBox controls
                .LastName = txtLastName.Text,
                .Email = txtEmail.Text,
                .PhoneNumber = txtPhoneNumber.Text,
                .DateOfBirth = dtpBirthday.Value, ' Assuming this is a DateTimePicker control
                .Gender = cmbGender.SelectedItem.ToString(), ' Assuming this is a ComboBox control
                .Address = txtAddress.Text,
                .EnrollmentDate = Date.Now, ' Auto-set to current date or leave as is if no change
                .ProgramId = CInt(cmbProgram.SelectedIndex), ' Assuming ProgramId is bound to a ComboBox
                .DepartmentId = CInt(cmbDepartment.SelectedIndex), ' Assuming DepartmentId is bound to a ComboBox
                .CourseId = studentAccess.GetCourseIdByCourseName(cmbCourse.SelectedItem) ' Assuming CourseId is bound to a ComboBox for course selection
            }

            ' Update the student in the database
            Dim rowsAffected As Integer = studentAccess.UpdateStudent(updatedStudent)

            ' Check if the update was successful
            If rowsAffected > 0 Then
                MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetForm()
                Dim dashboard As New Dashboard
                dashboard.Show()
                Me.Hide()

            Else
                MessageBox.Show("An error occurred while updating the student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function Validation() As Boolean

        ' Check if ALL fields are at their default state or empty
        If String.IsNullOrWhiteSpace(txtFirstName.Text) AndAlso
       String.IsNullOrWhiteSpace(txtLastName.Text) AndAlso
       String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso
       String.IsNullOrWhiteSpace(txtPhoneNumber.Text) AndAlso
       (cmbGender.SelectedIndex = 0 OrElse cmbGender.SelectedItem.ToString() = "- Select Gender -") AndAlso
       String.IsNullOrWhiteSpace(txtAddress.Text) AndAlso
       (cmbDepartment.SelectedIndex = 0 OrElse cmbDepartment.SelectedItem.ToString() = "- Select Department -") AndAlso
       (cmbProgram.SelectedIndex = 0 OrElse cmbProgram.SelectedItem.ToString() = "- Select Program -") Then

            MessageBox.Show("All fields are required. Please fill them out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus() ' Focus on the first field
            Return False
        End If


        ' Check individual fields
        If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
            MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Focus()
            Return False

        ElseIf String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Focus()
            Return False

        ElseIf String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False

        ElseIf String.IsNullOrWhiteSpace(txtPhoneNumber.Text) Then
            MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhoneNumber.Focus()
            Return False

        ElseIf cmbGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbGender.Focus()
            Return False

        ElseIf String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return False

        ElseIf cmbDepartment.SelectedIndex = -1 OrElse cmbDepartment.SelectedItem.ToString() = "- Select Department -" Then
            MessageBox.Show("Please select a valid Department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbDepartment.Focus()
            Return False

        ElseIf cmbProgram.SelectedIndex = -1 OrElse cmbProgram.SelectedItem.ToString() = "- Select Program -" Then
            MessageBox.Show("Please select a valid Program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbProgram.Focus()
            Return False

        ElseIf dtpBirthday.Value > Date.Now Then
            MessageBox.Show("Date of Birth cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpBirthday.Focus()
            Return False
        End If

        ' If all validations pass
        Return True
    End Function
    Private Sub ResetForm()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtAddress.Clear()
        cmbGender.SelectedIndex = 0
        cmbDepartment.SelectedIndex = 0
        cmbProgram.SelectedIndex = 0
        dtpBirthday.Value = Date.Now
    End Sub
End Class
