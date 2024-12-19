Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Imports System.Drawing.Drawing2D
Imports Mysqlx.Crud
Imports System.ComponentModel

Public Class DepartmentForm
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
        LoadDepartment()


    End Sub

    Private Sub LoadDepartment()
        Try
            ' Call the GetAllDepartments function to retrieve the department data
            Dim departmentTable As DataTable = studentAccess.GetAllDepartments()

            ' Bind the DataTable to the DataGridView
            dgvDepartment.DataSource = departmentTable
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvDepartment.ReadOnly = True
            dgvDepartment.AllowUserToAddRows = False
            dgvDepartment.AllowUserToDeleteRows = False

            dgvDepartment.Columns("department_id").Visible = False
            dgvDepartment.Columns("department_name").HeaderText = "Department Name"
            dgvDepartment.Columns("faculty_name").HeaderText = "Faculty Name"
            dgvDepartment.Columns("building").HeaderText = "Building"

        Catch ex As Exception
            ' Handle exceptions and show an error message
            MessageBox.Show("An error occurred while loading departments: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New StudentDashboard
        dashboard.Show()
        Me.Hide()

    End Sub
End Class
