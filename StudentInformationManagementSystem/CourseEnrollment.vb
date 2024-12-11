Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Public Class CourseEnrollment
    Private student As Students

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
        LoadStudents()
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)



    End Sub

    Private Sub LoadStudents()
        Dim studentDataAccess As New StudentDataAccess()
        Dim studentsDataTable As DataTable = studentDataAccess.ViewStudents()

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnStudentEnrollment_Click(sender As Object, e As EventArgs) Handles btnStudentEnrollment.Click
        Dim studentEnrollment As New StudentEnrollment
        studentEnrollment.Show()
        Me.Hide()

    End Sub
End Class
