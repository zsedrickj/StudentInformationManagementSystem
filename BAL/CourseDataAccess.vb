Imports DAL
Imports BEL
Imports MySql.Data.MySqlClient
Imports System.Data ' Import the MySQL namespace
Public Class CourseDataAccess
    Private db As New DbConnection()
    Public Function InsertStudentCourse(studentCourse As StudentCourse) As Integer
        ' Validate input fields
        If studentCourse.StudentId <= 0 OrElse studentCourse.CourseId <= 0 Then
            Throw New ArgumentException("Invalid StudentId or CourseId.")
        End If

        Dim cmd As New MySqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO StudentCourses (student_id, course_id, enrollment_date, status) " &
                          "VALUES (@StudentId, @CourseId, @EnrollmentDate, @Status)"

        ' Add parameters
        cmd.Parameters.AddWithValue("@StudentId", studentCourse.StudentId)
        cmd.Parameters.AddWithValue("@CourseId", studentCourse.CourseId)
        cmd.Parameters.AddWithValue("@EnrollmentDate", studentCourse.EnrollmentDate)
        cmd.Parameters.AddWithValue("@Status", studentCourse.Status)

        ' Execute the command
        Return db.ExeNonQuery(cmd)
    End Function

    ' View all student course records from the StudentCourses table
    Public Function ViewStudentCourses() As DataTable
        Dim cmd As New MySqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM StudentCourses"

        ' Execute the command and return the result as a DataTable
        Return db.ExeReader(cmd)
    End Function

    ' Update an existing student course record in the StudentCourses table
    Public Function UpdateStudentCourse(studentCourse As StudentCourse) As Integer
        Dim cmd As New MySqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "UPDATE StudentCourses SET student_id = @StudentId, course_id = @CourseId, " &
                          "enrollment_date = @EnrollmentDate, status = @Status WHERE student_course_id = @StudentCourseId"

        ' Add parameters
        cmd.Parameters.AddWithValue("@StudentId", studentCourse.StudentId)
        cmd.Parameters.AddWithValue("@CourseId", studentCourse.CourseId)
        cmd.Parameters.AddWithValue("@EnrollmentDate", studentCourse.EnrollmentDate)
        cmd.Parameters.AddWithValue("@Status", studentCourse.Status)
        cmd.Parameters.AddWithValue("@StudentCourseId", studentCourse.StudentCourseId)

        ' Execute the command and return the number of affected rows
        Return db.ExeNonQuery(cmd)
    End Function

    ' Delete a student course record from the StudentCourses table
    Public Function DeleteStudentCourse(studentCourseId As Integer) As Integer
        Dim cmd As New MySqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "DELETE FROM StudentCourses WHERE student_course_id = @StudentCourseId"

        ' Add parameter
        cmd.Parameters.AddWithValue("@StudentCourseId", studentCourseId)

        ' Execute the command and return the number of affected rows
        Return db.ExeNonQuery(cmd)
    End Function
    Public Function GetLoggedInStudentID() As Integer
        Dim cmd As New MySqlCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT student_id FROM Students WHERE is_logged_in = 1"

        ' Assuming `db.ExeScalar` executes the query and returns the result
        Dim result As Object = db.ExeScalar(cmd)

        ' Check if the result is not Nothing and is of a type that can be converted to an integer
        If result IsNot Nothing AndAlso TypeOf result Is Integer Then
            Return Convert.ToInt32(result)
        Else
            Return 0
        End If
    End Function



    Public Function GetAvailableCourses() As DataTable
        ' Create a new MySQL command object
        Dim cmd As New MySqlCommand()

        ' Specify the SQL query to get the available courses
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT course_id, course_name FROM courses WHERE is_available = TRUE"

        ' Return the result as a DataTable by executing the reader
        Return db.ExeReader(cmd)
    End Function
End Class
