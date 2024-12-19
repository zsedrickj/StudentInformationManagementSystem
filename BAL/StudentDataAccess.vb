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
            If student.ProgramId <= 0 OrElse student.DepartmentId <= 0 OrElse student.CourseId <= 0 Then
                Throw New ArgumentException("Invalid ProgramId, DepartmentId, or CourseId.")
            End If

            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Students (first_name, last_name, email, phone_number, dob, gender, address, enrollment_date, department_id, program_id, course_id) " &
                      "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @DateOfBirth, @Gender, @Address, @EnrollmentDate, @DepartmentId, @ProgramId, @CourseId)"

            ' Add parameters
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName)
            cmd.Parameters.AddWithValue("@LastName", student.LastName)
            cmd.Parameters.AddWithValue("@Email", student.Email)
            cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber)
            cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth)
            cmd.Parameters.AddWithValue("@Gender", student.Gender)
            cmd.Parameters.AddWithValue("@Address", student.Address)
            cmd.Parameters.AddWithValue("@EnrollmentDate", student.EnrollmentDate)
            cmd.Parameters.AddWithValue("@DepartmentId", student.DepartmentId)
            cmd.Parameters.AddWithValue("@ProgramId", student.ProgramId)
            cmd.Parameters.AddWithValue("@CourseId", student.CourseId)

            ' Execute the command
            Return db.ExeNonQuery(cmd)
        End Function

        ' Update an existing student record in the Students table
        Public Function UpdateStudent(student As Students) As Integer
            If student.ProgramId <= 0 OrElse student.DepartmentId <= 0 OrElse student.CourseId <= 0 Then
                Throw New ArgumentException("Invalid ProgramId, DepartmentId, or CourseId.")
            End If
            If student.StudentId <= 0 Then
                Throw New ArgumentException("Invalid StudentId.")
            End If
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE Students SET first_name = @FirstName, last_name = @LastName, email = @Email, phone_number = @PhoneNumber, " &
                      "dob = @DateOfBirth, gender = @Gender, address = @Address, enrollment_date = @EnrollmentDate, " &
                      "department_id = @DepartmentId, program_id = @ProgramId, course_id = @CourseId " &
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
            cmd.Parameters.AddWithValue("@DepartmentId", student.DepartmentId)
            cmd.Parameters.AddWithValue("@ProgramId", student.ProgramId)
            cmd.Parameters.AddWithValue("@CourseId", student.CourseId)
            cmd.Parameters.AddWithValue("@StudentID", student.StudentId)

            ' Execute the command and return the number of affected rows
            Return db.ExeNonQuery(cmd)
        End Function

        ' Delete a student record from the Students table
        Public Function DeleteStudent(studentID As Integer) As Integer
            If studentID <= 0 Then
                Throw New ArgumentException("Invalid StudentId.")
            End If
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM Students WHERE student_id = @StudentID"

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
        Public Function GetCourseNamesByDepartment(departmentID As Integer) As List(Of String)
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT course_name FROM courses WHERE department_id = @department_id"

            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@department_id", departmentID)

            ' Execute the query and retrieve the results
            Dim result As DataTable = db.ExeReader(cmd)

            ' Create a list to hold the course names
            Dim courseNames As New List(Of String)()

            ' Loop through the DataTable rows and add each CourseName to the list
            For Each row As DataRow In result.Rows
                courseNames.Add(row("course_name").ToString())
            Next

            Return courseNames
        End Function

        Public Function GetCourseIdByCourseName(courseName As String) As Integer
            Dim courseId As Integer = 0

            ' Create the SQL query to get the course_id based on the course_name
            Dim query As String = "SELECT course_id FROM Courses WHERE course_name = @courseName"

            ' Create a MySQL command object
            Dim cmd As New MySqlCommand(query)

            ' Add the courseName parameter to avoid SQL injection
            cmd.Parameters.AddWithValue("@courseName", courseName)

            ' Execute the query using the ExeScalar method to get the course_id
            courseId = Convert.ToInt32((New DbConnection).ExeScalar(cmd))

            Return courseId
        End Function
        Public Function GetTotalEnrolledStudents() As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT COUNT(*) AS TotalStudents FROM Students"

            ' Execute the query and retrieve the result
            Dim result As DataTable = db.ExeReader(cmd)

            ' Return the total count from the result
            If result.Rows.Count > 0 Then
                Return Convert.ToInt32(result.Rows(0)("TotalStudents"))
            Else
                Return 0 ' Return 0 if no data is retrieved
            End If
        End Function
        Public Function GetTotalDepartment() As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT COUNT(*) AS TotalDepartment FROM departments"

            ' Execute the query and retrieve the result
            Dim result As DataTable = db.ExeReader(cmd)

            ' Return the total count from the result
            If result.Rows.Count > 0 Then
                Return Convert.ToInt32(result.Rows(0)("TotalDepartment"))
            Else
                Return 0 ' Return 0 if no data is retrieved
            End If
        End Function
        Public Function GetTotalCourses() As Integer
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT COUNT(*) AS TotalCourse FROM courses"

            ' Execute the query and retrieve the result
            Dim result As DataTable = db.ExeReader(cmd)

            ' Return the total count from the result
            If result.Rows.Count > 0 Then
                Return Convert.ToInt32(result.Rows(0)("TotalCourse"))
            Else
                Return 0 ' Return 0 if no data is retrieved
            End If
        End Function

        Public Function GetAllStudents() As DataTable
            Dim studentTable As New DataTable()

            Try
                ' SQL query to retrieve all students
                Dim query As String = "SELECT * FROM Students"

                ' Create a MySqlCommand object
                Dim cmd As New MySqlCommand(query)

                ' Use the DbConnection class to execute the query and fill the DataTable
                Dim dbConnection As New DbConnection()
                studentTable = dbConnection.ExeReader(cmd)
            Catch ex As Exception
                ' Handle any exceptions

            End Try

            Return studentTable
        End Function


        Public Function GetStudentDetailsById(studentId As Integer) As Students
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT first_name, last_name, email, phone_number, dob, gender, address, enrollment_date FROM Students WHERE student_id = @studentId"

            ' Add the studentId parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@studentId", studentId)

            ' Execute the query and retrieve the result
            Dim result As DataTable = db.ExeReader(cmd)

            ' Check if the result contains any rows
            If result.Rows.Count > 0 Then
                ' Create a new StudentDetails object and populate it with data
                Dim studentDetails As New Students() With {
                    .FirstName = result.Rows(0)("first_name").ToString(),
                    .LastName = result.Rows(0)("last_name").ToString(),
                    .Email = result.Rows(0)("email").ToString(),
                    .PhoneNumber = result.Rows(0)("phone_number").ToString(),
                    .DateOfBirth = Convert.ToDateTime(result.Rows(0)("dob")),
                    .Gender = result.Rows(0)("gender").ToString(),
                    .Address = result.Rows(0)("address").ToString(),
                    .EnrollmentDate = Convert.ToDateTime(result.Rows(0)("enrollment_date"))
                }

                Return studentDetails
            Else
                ' If no student found, return Nothing or handle accordingly
                Return Nothing
            End If
        End Function
        Public Function GetAllDepartments() As DataTable
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Departments"

            ' Execute the query and retrieve all fields from the Departments table
            Dim result As DataTable = db.ExeReader(cmd)

            ' Return the entire DataTable
            Return result
        End Function

        Public Function GetAllPrograms() As DataTable
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Programs"

            ' Execute the query and retrieve all fields from the Programs table
            Dim result As DataTable = db.ExeReader(cmd)

            ' Return the entire DataTable
            Return result
        End Function
        Public Function GetAllCourses() As DataTable
            Dim cmd As New MySqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT * FROM Courses"

            ' Execute the query and retrieve all fields from the Courses table
            Dim result As DataTable = db.ExeReader(cmd)

            ' Return the entire DataTable
            Return result
        End Function
    End Class
End Namespace
