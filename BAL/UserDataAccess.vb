Imports BEL
Imports DAL
Imports MySql.Data.MySqlClient
Imports System.Data

Namespace BAL
    Public Class UserDataAccess
        ' Create a new database connection
        Private db As New DbConnection()

        ' Insert a new user record into the Users table
        Public Function InsertUser(user As Accounts) As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Users (username, password, role_id) " &
                              "VALUES (@Username, @Password, @RoleId)"

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@Username", user.Username)
            cmd.Parameters.AddWithValue("@Password", user.Password)
            cmd.Parameters.AddWithValue("@RoleId", user.RoleId)

            ' Execute the command and return the number of affected rows
            Return db.ExeNonQuery(cmd)
        End Function

        ' View all user records from the Users table
        Public Function ViewUsers() As DataTable
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Users"

            ' Execute the command and return the result as a DataTable
            Return db.ExeReader(cmd)
        End Function

        ' Update an existing user record in the Users table
        Public Function UpdateUser(user As Accounts) As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Users SET username = @Username, password = @Password, role_id = @RoleId " &
                              "WHERE userid = @UserId"

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@Username", user.Username)
            cmd.Parameters.AddWithValue("@Password", user.Password)
            cmd.Parameters.AddWithValue("@RoleId", user.RoleId)
            cmd.Parameters.AddWithValue("@UserId", user.UserId)

            ' Execute the command and return the number of affected rows
            Return db.ExeNonQuery(cmd)
        End Function

        ' Delete a user record from the Users table
        Public Function DeleteUser(userId As Integer) As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Users WHERE userid = @UserId"

            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@UserId", userId)

            ' Execute the command and return the number of affected rows
            Return db.ExeNonQuery(cmd)
        End Function

        ' Retrieve a user by username and password
        Public Function GetUserByCredentials(username As String, password As String) As DataTable
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Users WHERE username = @Username AND password = @Password"

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            ' Execute the command and return the result as a DataTable
            Return db.ExeReader(cmd)
        End Function
    End Class
End Namespace


