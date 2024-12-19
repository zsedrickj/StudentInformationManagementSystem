Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Mysqlx.XDevAPI.Common
Imports System.Drawing.Drawing2D
Imports Mysqlx.Crud
Imports System.ComponentModel

Public Class ProgramForm
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
        LoadPrograms()


    End Sub

    Private Sub LoadPrograms()
        Try
            ' Call the GetAllPrograms function to retrieve the program data
            Dim programTable As DataTable = studentAccess.GetAllPrograms()

            ' Bind the DataTable to the DataGridView
            dgvProgram.DataSource = programTable
            dgvProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dgvProgram.ReadOnly = True
            dgvProgram.AllowUserToAddRows = False
            dgvProgram.AllowUserToDeleteRows = False

            ' Set visibility and header text for columns
            dgvProgram.Columns("program_id").Visible = False
            dgvProgram.Columns("department_id").Visible = False
            dgvProgram.Columns("program_name").HeaderText = "Program Name"
            dgvProgram.Columns("duration").HeaderText = "Duration (Years)"
            dgvProgram.Columns("program_type").HeaderText = "Program Type"

        Catch ex As Exception
            ' Handle exceptions and show an error message
            MessageBox.Show("An error occurred while loading programs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New StudentDashboard
        dashboard.Show()
        Me.Hide()

    End Sub
End Class
