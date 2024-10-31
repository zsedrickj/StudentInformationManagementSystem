Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Public Class Form1
    Public opr As New StudentDataAccess()
    Public info As New Students()

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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25))
        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Dim studentDataAccess As New StudentDataAccess()
        Dim studentsDataTable As DataTable = studentDataAccess.ViewStudents()

        ' Bind the DataTable to the DataGridView
        DataGridViewStudents.DataSource = studentsDataTable
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim addStudent As New AddStudent()
        addStudent.Show()
        Me.Hide()
    End Sub
End Class
