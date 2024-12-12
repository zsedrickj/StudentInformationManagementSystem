Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Imports Org.BouncyCastle.Crypto.Generators

Public Class Signup





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
        DisplayRole()


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim userName As String = txtUser.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim roleId As Integer = Convert.ToInt32(cmbRole.SelectedValue) ' Get the role ID directly
        Dim userDataAccess As New UserDataAccess()

        ' Check if fields are empty
        If String.IsNullOrEmpty(userName) OrElse String.IsNullOrEmpty(password) OrElse roleId = 0 Then
            MessageBox.Show("Please enter username, password, and role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Create a new Accounts object
            Dim newUser As New Accounts With {
            .Username = userName,
            .Password = BCrypt.Net.BCrypt.HashPassword(password), ' Hash password for security
            .RoleId = roleId
        }

            ' Insert the user
            Dim rowsAffected As Integer = userDataAccess.InsertUser(newUser)

            If rowsAffected > 0 Then
                MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUser.Clear()
                txtPassword.Clear()
                cmbRole.SelectedIndex = -1
            Else
                MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub DisplayRole()
        Try
            Dim userDataAccess As New UserDataAccess
            Dim dt As DataTable = userDataAccess.GetAllRoles()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No roles found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Bind the ComboBox with role_name as the display and role_id as the value
            cmbRole.DataSource = dt
            cmbRole.DisplayMember = "role_name" ' Display role name in the ComboBox
            cmbRole.ValueMember = "role_id" ' Store the role_id as the value

            ' Optionally, set a default selected index
            cmbRole.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginForm As New Login
        loginForm.Show()
        Me.Hide()

    End Sub
End Class
