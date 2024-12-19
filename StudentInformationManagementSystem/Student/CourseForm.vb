Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Imports System.Drawing.Drawing2D
Imports Mysqlx.Crud
Imports System.ComponentModel

Public Class CourseForm
    Private studentAccess As New StudentDataAccess


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
        LoadCourse()


    End Sub

    Private Sub LoadCourse()
        Try
            ' Call the GetAllCourses function to retrieve the course data
            Dim courseTable As DataTable = studentAccess.GetAllCourses()

            ' Bind the DataTable to the DataGridView
            dgvCourse.DataSource = courseTable
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Remove unnecessary columns
            dgvCourse.Columns("course_id").Visible = False
            dgvCourse.Columns("department_id").Visible = False

            dgvCourse.ReadOnly = True
            dgvCourse.AllowUserToAddRows = False
            dgvCourse.AllowUserToDeleteRows = False

            ' Set header text for the visible columns
            dgvCourse.Columns("course_name").HeaderText = "Course Name"
            dgvCourse.Columns("credits").HeaderText = "Credits"
            dgvCourse.Columns("semester").HeaderText = "Semester"
            dgvCourse.Columns("course_type").HeaderText = "Course Type"
            dgvCourse.Columns("is_available").HeaderText = "Available"

            ' Format the "is_available" column to display "Yes" or "No"
            If dgvCourse.Rows.Count > 0 Then
                For Each row As DataGridViewRow In dgvCourse.Rows
                    If row.Cells("is_available").Value IsNot Nothing Then
                        Dim isAvailable As String = row.Cells("is_available").Value.ToString().ToLower()
                        row.Cells("is_available").Value = If(isAvailable = "true" Or isAvailable = "false", "True", "False")
                    End If
                Next
            End If

        Catch ex As Exception
            ' Handle exceptions and show an error message
            MessageBox.Show("An error occurred while loading courses: " & ex.Message & Environment.NewLine & "Stack Trace: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New StudentDashboard
        dashboard.Show()
        Me.Hide()

    End Sub
End Class
