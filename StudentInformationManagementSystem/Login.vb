Imports System.Runtime.InteropServices
Imports BEL
Imports BAL
Imports BAL.BAL
Public Class Login




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
        ' Retrieve username and password from input fields
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Check if fields are empty
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Create an instance of UserDataAccess
        Dim userAccess As New UserDataAccess()

        ' Fetch user data based on the credentials
        Dim userTable As DataTable = userAccess.GetUserByCredentials(username, password)

        ' Validate user
        If userTable IsNot Nothing AndAlso userTable.Rows.Count > 0 Then
            ' Login successful
            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Redirect to the main form or perform the next action
            Dim mainForm As New StudentEnrollment() ' Replace with your main form
            mainForm.Show()
            Me.Hide()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
