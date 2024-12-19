Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Imports System.Drawing.Drawing2D
Imports Mysqlx.Crud
Imports System.ComponentModel

Public Class StudentDashboard

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

    Private Sub pnlDepartment_Click(sender As Object, e As EventArgs) Handles pnlDepartment.Click
        Dim department As New DepartmentForm
        department.Show()
        Me.Hide()

    End Sub

    Private Sub pnlPrograms_Click(sender As Object, e As EventArgs) Handles pnlPrograms.Click
        Dim program As New ProgramForm
        program.Show()
        Me.Hide()

    End Sub

    Private Sub pnlCourses_Click(sender As Object, e As EventArgs) Handles pnlCourses.Click
        Dim course As New CourseForm
        course.Show()
        Me.Hide()

    End Sub
End Class
