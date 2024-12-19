Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Imports System.Runtime.Intrinsics.X86

Public Class CourseEnrollment
    Private studentAccess As New StudentDataAccess()
    Private student As Students
    Private gradeDataAccess As New GradeDataAccess

    'STORED DATA



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
        txtCourses.Enabled = False
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
        Dim studentEnrollment As New StudentEnrollment
        studentEnrollment.Show()
        Me.Hide()



    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchStudent()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            ' Validate inputs before proceeding
            If String.IsNullOrWhiteSpace(txtStudentName.Text) OrElse String.IsNullOrWhiteSpace(txtCourses.Text) OrElse String.IsNullOrWhiteSpace(txtGrade.Text) Then
                MessageBox.Show("All fields are required. Please fill in all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Parse input values
            Dim studentId As Integer = gradeDataAccess.GetStudentIdByStudentName(txtStudentName.Text) ' Ensure txtStudentId contains a valid student ID
            Dim gradeValue As Decimal = Decimal.Parse(txtGrade.Text) ' Ensure txtGrade contains a valid numeric grade
            If gradeDataAccess.IsStudentIdUnique(studentId) Then
                ' Create a new Grades object
                Dim grade As New Grades With {
        .StudentId = studentId,
        .Grade = gradeValue
    }

                ' Call InsertGrade to insert the grade into the database
                Dim rowsAffected As Integer = gradeDataAccess.InsertGrade(grade)

                If rowsAffected > 0 Then
                    MessageBox.Show("Grade has been successfully recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Optional: Reset fields after successful submission
                    ResetStudentInfo()
                Else
                    MessageBox.Show("Failed to record the grade. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ' If student_id is not unique, update the grade
                Dim grade As New Grades With {
        .StudentId = studentId,
        .Grade = gradeValue
    }

                ' Call UpdateGrade to update the grade in the database
                Dim rowsAffected As Integer = gradeDataAccess.UpdateGrade(grade)

                If rowsAffected > 0 Then
                    MessageBox.Show("Grade has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Optional: Reset fields after successful update
                    ResetStudentInfo()
                Else
                    MessageBox.Show("Failed to update the grade. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            ' Handle exceptions (e.g., invalid input, database errors)
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SearchStudent()
        Dim studentName As String = txtStudentName.Text.Trim()
        Dim studentId As Integer = gradeDataAccess.GetCourseIdByStudentName(studentName)
        Dim isEnrolled As Boolean = gradeDataAccess.IsStudentExist(studentName)
        Dim courseId As Integer = gradeDataAccess.GetCourseIdByStudentName(studentName)


        If isEnrolled Then
            MessageBox.Show("Student found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtStudentName.Text = studentName
            txtCourses.Text = gradeDataAccess.GetCourseNameByCourseId(courseId)

        Else
            MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub ResetStudentInfo()
        ' Clear all TextBoxes related to student information
        txtStudentName.Text = String.Empty
        txtCourses.Text = String.Empty
        txtGrade.Text = String.Empty


        ' Disable any editable fields if needed
        txtCourses.Enabled = False

        ' Reset focus to the student name TextBox for a new search
        txtStudentName.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dashboard As New Dashboard
        dashboard.Show()
        Me.Hide()

    End Sub
End Class
