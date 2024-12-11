Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Public Class StudentEnrollment
    Public opr As New StudentDataAccess()
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
        LoadStudents()
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        IsNullOrEmpty()
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbGender.SelectedIndex = 0
    End Sub

    Private Sub SetDateTimePickerValue(dtp As DateTimePicker, dateValue As DateTime)
        ' Check if the DateTime value is valid (not DateTime.MinValue)
        If dateValue <> DateTime.MinValue Then
            dtp.Value = dateValue
        Else
            dtp.Value = DateTime.Now  ' Use a default value if invalid
        End If
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
    Private Sub LoadStudents()
        Dim studentDataAccess As New StudentDataAccess()
        ' Bind the DataTable to the DataGridView

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Const message As String = "Are you sure that you would like to close the form?"
        Const caption As String = "Exit"
        Dim result As DialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

        StoredData()
        student = New Students()

        ' I-bind ang mga TextBox sa properties ng Student model
        txtFirstName.DataBindings.Add("Text", student, "FirstName")
        txtLastName.DataBindings.Add("Text", student, "LastName")
        txtEmail.DataBindings.Add("Text", student, "Email")
        txtPhoneNumber.DataBindings.Add("Text", student, "PhoneNumber")
        txtAddress.DataBindings.Add("Text", student, "Address")

        ' I-bind ang DateTimePicker sa Date properties
        SetDateTimePickerValue(dtpBirthday, student.DateOfBirth)
        SetDateTimePickerValue(dtpEnrollmentDate, student.EnrollmentDate)

        ' I-bind ang ComboBox sa properties
        cmbGender.DataBindings.Add("SelectedItem", student, "Gender")
        cmbProgram.DataBindings.Add("SelectedValue", student, "ProgramId")

        Dim courseEnrollment As New CourseEnrollment(student)
        courseEnrollment.Show()
        Me.Hide()

    End Sub
End Class
