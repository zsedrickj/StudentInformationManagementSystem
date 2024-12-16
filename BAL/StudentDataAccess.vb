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
            cmd.CommandText = "INSERT INTO Students (first_name, last_name, email, phone_number, dob, gender, address, enrollment_date, program_id) " &
                      "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @DateOfBirth, @Gender, @Address, @EnrollmentDate, @ProgramId)"

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName)
            cmd.Parameters.AddWithValue("@LastName", student.LastName)
            cmd.Parameters.AddWithValue("@Email", student.Email)
            cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber)
            cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth)
            cmd.Parameters.AddWithValue("@Gender", student.Gender)
            cmd.Parameters.AddWithValue("@Address", student.Address)
            cmd.Parameters.AddWithValue("@EnrollmentDate", student.EnrollmentDate)
            cmd.Parameters.AddWithValue("@ProgramId", student.ProgramId)

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
            cmd.CommandText = "UPDATE Students SET first_name = @FirstName, last_name = @LastName, email = @Email, phone_number = @PhoneNumber, " &
                      "dob = @DateOfBirth, gender = @Gender, address = @Address, enrollment_date = @EnrollmentDate, program_id = @ProgramId " &
                      "WHERE student_id = @StudentID"

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName)
            cmd.Parameters.AddWithValue("@LastName", student.LastName)
            cmd.Parameters.AddWithValue("@Email", student.Email)
            cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber)
            cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth)
            cmd.Parameters.AddWithValue("@Gender", student.Gender)
            cmd.Parameters.AddWithValue("@Address", student.Address)
            cmd.Parameters.AddWithValue("@EnrollmentDate", student.EnrollmentDate)
            cmd.Parameters.AddWithValue("@ProgramId", student.ProgramId)
            cmd.Parameters.AddWithValue("@StudentID", student.StudentId)

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

        Public Function GetProgramNamesByDepartment(departmentID As Integer) As List(Of String)
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT program_name FROM Programs WHERE department_id = @department_id"

            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@department_id", departmentID)

            ' Execute the query and retrieve the results
            Dim result As DataTable = db.ExeReader(cmd)

            ' Create a list to hold the program names
            Dim programNames As New List(Of String)()

            ' Loop through the DataTable rows and add each ProgramName to the list
            For Each row As DataRow In result.Rows
                programNames.Add(row("program_name").ToString())
            Next

            Return programNames
        End Function
        Public Function GetDepartmentIDByName(departmentName As String) As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT department_id FROM Departments WHERE department_name = @department_name"

            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@department_name", departmentName)

            ' Execute the query and retrieve the result
            Dim result As Object = db.ExeScalar(cmd)

            ' Return the DepartmentID if found, otherwise return -1
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            Else
                Return -1
            End If
        End Function

        Public Function GetAllDepartmentNames() As List(Of String)
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT department_name FROM Departments"

            ' Execute the query and retrieve the results
            Dim result As DataTable = db.ExeReader(cmd)

            ' Create a list to hold the department names
            Dim departmentNames As New List(Of String)()

            ' Loop through the DataTable rows and add each DepartmentName to the list
            For Each row As DataRow In result.Rows
                departmentNames.Add(row("department_name").ToString())
            Next

            Return departmentNames
        End Function

    End Class
End Namespace
