Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports Microsoft.VisualBasic.Devices
Public Class CourseEnrollment
    Private student As Students
    Private courseAccess As New CourseDataAccess
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
    Public Sub New(existingStudent As Students)
        InitializeComponent()
        student = existingStudent
        ' Initialize with existing student data
    End Sub
    Private Sub CourseEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25))
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        txtStudentId.Visible = False

        LoadCourseData()

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnGradingForm.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnCourseEnrollment.Click

    End Sub

    Private Sub btnStudentEnrollment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrollment.Click
        Dim studentEnrollment As New StudentEnrollment
        studentEnrollment.Show()
        Me.Hide()

    End Sub

    Private Sub LoadCourseData()
        ' Get the logged-in student ID
        Dim studentID As Integer = courseAccess.GetLoggedInStudentID()

        ' Hide the student ID text box (assuming txtStudentId is a TextBox)
        txtStudentId.Visible = False

        ' Get the available courses (assuming GetAvailableCourses() returns a DataTable)
        Dim courses As DataTable = courseAccess.GetAvailableCourses()

        ' Bind the DataTable to the ComboBox
        cmbCourses.DataSource = courses
        cmbCourses.DisplayMember = "course_name" ' The column to display in ComboBox
        cmbCourses.ValueMember = "course_id"    ' The value behind each item in the ComboBox
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Step 1: Get the logged-in student ID
        Dim studentId As Integer = courseAccess.GetLoggedInStudentID()

        ' Check if a student is logged in
        If studentId <= 0 Then
            MessageBox.Show("No student is logged in.")
            Return
        End If

        ' Step 2: Get the selected course ID from the ComboBox
        Dim courseId As Integer = Convert.ToInt32(cmbCourses.SelectedValue)

        ' Check if a course is selected
        If courseId <= 0 Then
            MessageBox.Show("Please select a course.")
            Return
        End If

        ' Step 3: Get the current date as the enrollment date
        Dim enrollmentDate As Date = Date.Now

        ' Step 4: Set the status (you can customize this based on your requirements, e.g., "Enrolled")
        Dim status As String = "Pending"

        ' Step 5: Create a new StudentCourse object
        Dim studentCourse As New StudentCourse() With {
            .StudentId = studentId,
            .CourseId = courseId,
            .EnrollmentDate = enrollmentDate,
            .Status = status
        }

        ' Step 6: Insert the student course record into the database
        Dim rowsAffected As Integer = courseAccess.InsertStudentCourse(studentCourse)

        ' Step 7: Check if the insertion was successful
        If rowsAffected > 0 Then
            MessageBox.Show("Course successfully enrolled!")
        Else
            MessageBox.Show("An error occurred while enrolling the course.")
        End If
    End Sub
End Class
