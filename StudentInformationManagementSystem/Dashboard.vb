Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Imports System.Drawing.Drawing2D
Imports Mysqlx.Crud
Imports System.ComponentModel

Public Class Dashboard


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
        PopulateEnrolledStudents()
        PopulateDepartment()
        PopulateCourses()
        LoadStudent()

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





    Private Sub btnCourseForm_Click(sender As Object, e As EventArgs) Handles btnCourseForm.Click
        Dim courseForm As New CourseEnrollment
        courseForm.Show()
        Me.Hide()

    End Sub


    Private Sub PopulateEnrolledStudents()
        Dim totalEnrolled As Integer = studentAccess.GetTotalEnrolledStudents

        lblStudents.Text = totalEnrolled.ToString

    End Sub
    Private Sub PopulateDepartment()
        Dim totalDepartment As Integer = studentAccess.GetTotalDepartment


        lblDepartments.Text = totalDepartment.ToString

    End Sub
    Private Sub PopulateCourses()
        Dim totalCourse As Integer = studentAccess.GetTotalCourses

        lblCourses.Text = totalCourse.ToString

    End Sub

    Private Sub LoadStudent()
        CustomizeDataTable()
        dgvStudentList.Columns("program_id").Visible = False
        dgvStudentList.Columns("department_id").Visible = False
        dgvStudentList.Columns("is_logged_in").Visible = False
        dgvStudentList.Columns("course_id").Visible = False
        Try
            ' Call the GetAllStudents function to retrieve the data
            Dim studentTable As DataTable = studentAccess.GetAllStudents()

            ' Check if there are records
            If studentTable.Rows.Count > 0 Then
                ' Bind the DataTable to the DataGridView
                dgvStudentList.DataSource = studentTable
            Else
                MessageBox.Show("No students found in the database.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Handle exceptions and show error message
            MessageBox.Show("Error loading students into DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CustomizeDataTable()
        Dim students As DataTable = studentAccess.GetAllStudents
        dgvStudentList.DataSource = students

        dgvStudentList.Columns("student_id").HeaderText = "Student ID"
        dgvStudentList.Columns("first_name").HeaderText = "First Name"
        dgvStudentList.Columns("last_name").HeaderText = "Last Name"
        dgvStudentList.Columns("email").HeaderText = "Email Address"
        dgvStudentList.Columns("phone_number").HeaderText = "Phone Number"
        dgvStudentList.Columns("dob").HeaderText = "Date of Birth"
        dgvStudentList.Columns("gender").HeaderText = "Gender"
        dgvStudentList.Columns("address").HeaderText = "Home Address"
        dgvStudentList.Columns("enrollment_date").HeaderText = "Enrollment Date"


        ' Disable clicking of column headers
        dgvStudentList.EnableHeadersVisualStyles = False

    End Function



    Private Sub btnStudentEnrollment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrollment.Click
        Dim studentEnrollment As New StudentEnrollment
        studentEnrollment.Show()
        Me.Hide()

    End Sub

    Private Sub dgvStudentList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentList.CellClick

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Ensure a row is selected
        If dgvStudentList.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvStudentList.SelectedRows(0)

            ' Extract data from the row
            Dim student As New Students With {
                .StudentId = Convert.ToInt32(selectedRow.Cells("student_id").Value),
                .FirstName = selectedRow.Cells("first_name").Value.ToString(),
                .LastName = selectedRow.Cells("last_name").Value.ToString(),
                .Email = selectedRow.Cells("email").Value.ToString(),
                .PhoneNumber = selectedRow.Cells("phone_number").Value.ToString(),
                .DateOfBirth = Convert.ToDateTime(selectedRow.Cells("dob").Value),
                .Gender = selectedRow.Cells("gender").Value.ToString(),
                .Address = selectedRow.Cells("address").Value.ToString(),
                .EnrollmentDate = Convert.ToDateTime(selectedRow.Cells("enrollment_date").Value)
            }

            ' Open the Update Form and pass the data
            Dim updateForm As New UpdateForm(student)
            updateForm.Show()
            Me.Hide()

        Else
            MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvStudentList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentId As Integer = Convert.ToInt32(dgvStudentList.SelectedRows(0).Cells("student_id").Value)
        ' Confirm delete action
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the student with ID {studentId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Try
            ' Call the DeleteStudent function to delete the record
            Dim rowsAffected As Integer = studentAccess.DeleteStudent(studentId)
            If rowsAffected > 0 Then
                MessageBox.Show("Student record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh the DataGridView to reflect changes
                LoadStudent() ' Replace LoadStudents() with your method to reload data
            Else
                MessageBox.Show("Failed to delete the student record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
