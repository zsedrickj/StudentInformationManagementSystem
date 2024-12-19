Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Public Class Login

    Public Property UserNameInput As String
        Get
            Return txtUser.Text
        End Get
        Set(value As String)
            txtUser.Text = value
        End Set
    End Property


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

    Private Sub lnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignUp.LinkClicked
        Dim signup As New Signup
        signup.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userName As String = txtUser.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Check if fields are empty
        If String.IsNullOrEmpty(userName) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Retrieve user data from the database (including the stored hashed password)
            Dim userDataAccess As New UserDataAccess
            Dim dt As DataTable = userDataAccess.GetUser(userName)
            If AdminLogin(userName, password) Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Proceed with login logic (e.g., redirect to dashboard)
                Dim dashboard As New Dashboard
                dashboard.Show()
                Me.Hide()
            Else
                If dt.Rows.Count > 0 Then
                    ' Retrieve the stored hashed password from the database
                    Dim storedHashedPassword As String = dt.Rows(0)("password").ToString()



                    ' Verify if the entered password matches the stored hashed password
                    If BCrypt.Net.BCrypt.Verify(password, storedHashedPassword) Then
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Proceed with login logic (e.g., redirect to dashboard)
                        Dim studentDashboard As New StudentDashboard
                        studentDashboard.Show()
                        Me.Hide()

                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function AdminLogin(username As String, password As String) As Boolean
        ' Check if the username is "admin" and the password matches the hashed version of "12345"
        If username.ToLower() = "admin" AndAlso HashPassword(password) = HashPassword("12345") Then
            Return True ' Login is successful
        End If

        Return False ' Login failed
    End Function
    Private Function HashPassword(password As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
            Dim builder As New System.Text.StringBuilder()
            For Each b As Byte In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using

    End Function

End Class
