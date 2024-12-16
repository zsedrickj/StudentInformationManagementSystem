Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Public Class StudentEnrollment
    Public studentAccess As New StudentDataAccess()
    Private student As Students

    'STORED DATA
    Private Shared storedFirstName As String
    Private Shared storedLastName As String
    Private Shared storedEmail As String
    Private Shared storedPhoneNumber As String
    Private Shared storedAddress As String
    Private Shared storedDateOfBirth As DateTime
    Private Shared storedEnrollmentDate As DateTime
    Private Shared storedGender As String
    Private Shared storedProgramId As Integer


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
        IsNullOrEmpty()
        GetUserName()
        cmbGender.Items.Add("- Select Gender -")
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbGender.SelectedIndex = 0
        cmbDepartment.Enabled = True
        PopulateDepartmentComboBox(cmbDepartment)

        ' Disable Program ComboBox initially
        cmbProgram.Enabled = False
        cmbProgram.Items.Clear()
        cmbProgram.Items.Add("- Select Program -")
        cmbProgram.SelectedIndex = 0
    End Sub
    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

        If Validation() = True Then
            Dim newStudent As New Students() With {
       .FirstName = txtFirstName.Text, ' Assuming these are TextBox controls
       .LastName = txtLastName.Text,
       .Email = txtEmail.Text,
       .PhoneNumber = txtPhoneNumber.Text,
       .DateOfBirth = dtpBirthday.Value, ' Assuming this is a DateTimePicker control
       .Gender = cmbGender.SelectedItem.ToString(), ' Assuming this is a ComboBox control
       .Address = txtAddress.Text,
       .EnrollmentDate = Date.Now, ' Auto-set to current date
       .ProgramId = CInt(cmbProgram.SelectedIndex), ' Assuming ProgramId is bound to a ComboBox
       .DepartmentId = CInt(cmbDepartment.SelectedIndex) ' Assuming DepartmentId is bound to a ComboBox
   }

            ' Insert the student into the database
            Dim rowsAffected As Integer = studentAccess.InsertStudent(newStudent)

            ' Check if the insertion was successful
            If rowsAffected > 0 Then
                MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetForm()

            Else
                MessageBox.Show("An error occurred while enrolling the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Const message = "Are you sure that you would like to close the form?"
        Const caption = "Exit"
        Dim result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the No button was pressed, do nothing
        If result = DialogResult.No Then
            Return ' Exit the method to prevent closing
        End If

        ' Otherwise, close the application
        Application.Exit()
    End Sub
    Private Sub btnStudentEnrollment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrollment.Click


    End Sub
    Private Sub btnCourseEnrollment_Click(sender As Object, e As EventArgs) Handles btnCourseEnrollment.Click

        DataBinding()

        Dim courseEnrollment As New CourseEnrollment(student)
        courseEnrollment.Show()
        Me.Hide()

    End Sub
    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        ' Check if a valid item is selected
        If cmbDepartment.SelectedIndex = -1 OrElse cmbDepartment.SelectedItem.ToString() = "- Select Department -" Then
            ' Reset the Program ComboBox if no department is selected
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("- Select Program -")
            cmbProgram.SelectedIndex = 0
            cmbProgram.Enabled = False
            Return
        End If

        ' Get the selected department name
        Dim departmentName As String = cmbDepartment.SelectedItem.ToString()

        ' Fetch the department ID using the name
        Dim departmentID As Integer = studentAccess.GetDepartmentIDByName(departmentName)

        ' Validate the department ID
        If departmentID > 0 Then
            ' Fetch program names for the selected department
            Dim programNames As List(Of String) = studentAccess.GetProgramNamesByDepartment(departmentID)

            ' Populate the Program ComboBox
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("- Select Program -")
            cmbProgram.Items.AddRange(programNames.ToArray())
            cmbProgram.SelectedIndex = 0
            cmbProgram.Enabled = True
        Else
            ' Handle invalid department ID
            MessageBox.Show("Invalid department selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbProgram.Items.Clear()
            cmbProgram.Items.Add("- Select Program -")
            cmbProgram.SelectedIndex = 0
            cmbProgram.Enabled = False
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
    Private Sub SetDateTimePickerValue(dtp As DateTimePicker, dateValue As DateTime)
        ' Check if the DateTime value is valid (not DateTime.MinValue)
        If dateValue <> DateTime.MinValue Then
            dtp.Value = dateValue
        Else
            dtp.Value = DateTime.Now  ' Use a default value if invalid
        End If
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
    Private Sub PopulateProgramComboBox(cmbProgram As ComboBox, departmentID As Integer)
        Try
            ' Retrieve program names for the selected department
            Dim programNames As List(Of String) = studentAccess.GetProgramNamesByDepartment(departmentID)

            ' Clear existing items in the ComboBox
            cmbProgram.Items.Clear()

            ' Add each program name to the ComboBox
            For Each programName As String In programNames
                cmbProgram.Items.Add(programName)
            Next

            ' Set the first item as selected, if available
            If cmbProgram.Items.Count > 0 Then
                cmbProgram.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error populating Program ComboBox: " & ex.Message)
        End Try
    End Sub
    Private Sub IsNullOrEmpty()
        If Not String.IsNullOrEmpty(storedFirstName) Then
            txtFirstName.Text = storedFirstName
        End If
        If Not String.IsNullOrEmpty(storedLastName) Then
            txtLastName.Text = storedLastName
        End If
        If Not String.IsNullOrEmpty(storedEmail) Then
            txtEmail.Text = storedEmail
        End If
        If Not String.IsNullOrEmpty(storedPhoneNumber) Then
            txtPhoneNumber.Text = storedPhoneNumber
        End If
        If Not String.IsNullOrEmpty(storedAddress) Then
            txtAddress.Text = storedAddress
        End If
        If storedDateOfBirth <> DateTime.MinValue Then
            dtpBirthday.Value = storedDateOfBirth
        End If
        If storedEnrollmentDate <> DateTime.MinValue Then
            dtpEnrollmentDate.Value = storedEnrollmentDate
        End If
        If Not String.IsNullOrEmpty(storedGender) Then
            cmbGender.SelectedItem = storedGender
        End If
        If storedProgramId > 0 Then
            cmbProgram.SelectedValue = storedProgramId
        End If

    End Sub
    Private Sub DataBinding()
        StoredData()
        student = New Students()
        ' Clear existing bindings to avoid conflicts
        txtFirstName.DataBindings.Clear()
        txtLastName.DataBindings.Clear()
        txtEmail.DataBindings.Clear()
        txtPhoneNumber.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        cmbGender.DataBindings.Clear()
        cmbProgram.DataBindings.Clear()

        ' Bind new data
        txtFirstName.DataBindings.Add("Text", student, "FirstName")
        txtLastName.DataBindings.Add("Text", student, "LastName")
        txtEmail.DataBindings.Add("Text", student, "Email")
        txtPhoneNumber.DataBindings.Add("Text", student, "PhoneNumber")
        txtAddress.DataBindings.Add("Text", student, "Address")
        cmbGender.DataBindings.Add("SelectedItem", student, "Gender")
        cmbProgram.DataBindings.Add("SelectedValue", student, "ProgramId")
    End Sub
    Private Sub StoredData()
        storedFirstName = txtFirstName.Text
        storedLastName = txtLastName.Text
        storedEmail = txtEmail.Text
        storedPhoneNumber = txtPhoneNumber.Text
        storedAddress = txtAddress.Text
        storedDateOfBirth = dtpBirthday.Value
        storedEnrollmentDate = dtpEnrollmentDate.Value

        If cmbGender.SelectedItem IsNot Nothing Then
            storedGender = cmbGender.SelectedItem.ToString()
        Else
            storedGender = String.Empty ' Or set to a default value if necessary
        End If

        If cmbProgram.SelectedItem IsNot Nothing Then
            storedProgramId = cmbProgram.SelectedItem.ToString()
        Else
            storedProgramId = String.Empty ' Or set to a default value
        End If

    End Sub
    Public Sub GetUserName()
        ' Get the username input from the Login form
        Dim loggedInUserName As String = Login.UserNameInput.Trim() ' Assuming Login is the current instance

        ' Create an instance of UserDataAccess
        Dim userAccess As New UserDataAccess()

        ' Fetch user data based on the username
        Dim userTable As DataTable = userAccess.GetUser(loggedInUserName)

        ' Check if user data is retrieved
        If userTable IsNot Nothing AndAlso userTable.Rows.Count > 0 Then
            ' Update the label with the username
            lbl_userName.Text = "Welcome " & userTable.Rows(0)("username").ToString() & "!"
        Else
            ' Handle case where no user data is found
            lbl_userName.Text = "User not found!"
        End If
    End Sub

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
