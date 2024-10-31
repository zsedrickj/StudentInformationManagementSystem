Imports DAL
Imports BEL
Imports MySql.Data.MySqlClient
Imports System.Data ' Import the MySQL namespace

Namespace BAL
    Public Class StudentDataAccess
        ' Create a new database connection
        Private db As New DbConnection()

        ' Insert a new student record into the Students table
        Public Function InsertStudent(student As Students) As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Students (FirstName, LastName, DateOfBirth, ContactInfo, GPA) VALUES (@FirstName, @LastName, @DateOfBirth, @ContactInfo, @GPA)"

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName)
            cmd.Parameters.AddWithValue("@LastName", student.LastName)
            cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth)
            cmd.Parameters.AddWithValue("@ContactInfo", student.ContactInfo)
            cmd.Parameters.AddWithValue("@GPA", student.GPA)

            ' Execute the command and return the number of affected rows
            Return db.ExeNonQuery(cmd)
        End Function

        ' View all student records from the Students table
        Public Function ViewStudents() As DataTable
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Students"

            ' Execute the command and return the result as a DataTable
            Return db.ExeReader(cmd)
        End Function

        ' Update an existing student record in the Students table
        Public Function UpdateStudent(student As Students) As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Students SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, ContactInfo = @ContactInfo, GPA = @GPA WHERE StudentID = @StudentID"

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName)
            cmd.Parameters.AddWithValue("@LastName", student.LastName)
            cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth)
            cmd.Parameters.AddWithValue("@ContactInfo", student.ContactInfo)
            cmd.Parameters.AddWithValue("@GPA", student.GPA)
            cmd.Parameters.AddWithValue("@StudentID", student.StudentID)

            ' Execute the command and return the number of affected rows
            Return db.ExeNonQuery(cmd)
        End Function

        ' Delete a student record from the Students table
        Public Function DeleteStudent(studentID As Integer) As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Students WHERE StudentID = @StudentID"

            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@StudentID", studentID)

            ' Execute the command and return the number of affected rows
            Return db.ExeNonQuery(cmd)
        End Function
    End Class
End Namespace
