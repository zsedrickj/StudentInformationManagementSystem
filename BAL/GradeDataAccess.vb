Imports DAL
Imports BEL
Imports MySql.Data.MySqlClient
Imports System.Data ' Import the MySQL namespace

Public Class GradeDataAccess
    Private db As New DbConnection()

    ' CREATE: Insert a new grade record
    Public Function InsertGrade(grade As Grades) As Integer
        Dim query As String = "INSERT INTO grading (student_id, grade) VALUES (@StudentId, @Grade)"
        Using cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@StudentId", grade.StudentId)
            cmd.Parameters.AddWithValue("@Grade", grade.Grade)

            Return db.ExeNonQuery(cmd) ' Use ExeNonQuery to execute the command
        End Using
    End Function

    ' UPDATE: Update the grade for a student in a specific course
    Public Function UpdateGrade(grade As Grades) As Integer
        Dim query As String = "UPDATE grading SET grade = @Grade WHERE student_id = @StudentId "
        Using cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@StudentId", grade.StudentId)
            cmd.Parameters.AddWithValue("@Grade", grade.Grade)

            Return db.ExeNonQuery(cmd) ' Executes the query and returns the number of rows affected
        End Using
    End Function

    ' DELETE: Delete a grade record by grading_id
    Public Function DeleteGrade(gradingId As Integer) As Integer
        Dim query As String = "DELETE FROM grading WHERE grading_id = @GradingId"
        Using cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@GradingId", gradingId)

            Return db.ExeNonQuery(cmd) ' Execute delete query
        End Using
    End Function

    Public Function SearchStudentByName(studentName As String) As DataRow
        ' SQL query to search for a student by name (first_name or last_name)
        Dim query As String = "SELECT student_id, first_name, last_name, email, phone_number, address FROM Students WHERE CONCAT(first_name, ' ', last_name) LIKE @StudentName"

        ' Create a new MySqlCommand object with the query
        Using cmd As New MySqlCommand(query)
            ' Add the parameter to the query (use wildcards for partial matching)
            cmd.Parameters.AddWithValue("@StudentName", "%" & studentName & "%")

            ' Use ExeReader to get the data from the query
            Dim dt As DataTable = db.ExeReader(cmd)

            ' Check if any student with the provided name exists
            If dt.Rows.Count > 0 Then
                ' Return the first matching row
                Return dt.Rows(0)
            End If
        End Using

        ' Return Nothing if no student is found
        Return Nothing
    End Function
    Public Function GetCoursesByStudentId(studentId As Integer) As DataTable
        ' SQL query to get the courses associated with the given student_id
        Dim query As String = "SELECT c.course_id, c.course_name FROM Courses c " &
                          "JOIN student_courses sc ON c.course_id = sc.course_id " &
                          "WHERE sc.student_id = @StudentId"

        ' Create a new MySqlCommand object with the query
        Using cmd As New MySqlCommand(query)
            ' Add the parameter to the query
            cmd.Parameters.AddWithValue("@StudentId", studentId)

            ' Use ExeReader to get the data from the query
            Return db.ExeReader(cmd) ' Returns DataTable with course information
        End Using
    End Function

    Public Function GetCourseIdsByStudentId(studentId As Integer) As DataTable
        ' SQL query to get the course_ids associated with the given student_id
        Dim query As String = "SELECT course_id FROM students WHERE student_id = @StudentId"

        ' Create a new MySqlCommand object with the query
        Using cmd As New MySqlCommand(query)
            ' Add the parameter to the query
            cmd.Parameters.AddWithValue("@StudentId", studentId)

            ' Use ExeReader to get the data from the query
            Return db.ExeReader(cmd) ' Returns DataTable with course_id information
        End Using
    End Function


    Public Function GetCourseIdByCourseName(courseName As String) As Integer
        Dim query As String = "SELECT course_id FROM courses WHERE course_name = @CourseName"
        Using cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@CourseName", courseName)
            Dim result As Object = db.ExeScalar(cmd)
            Return If(result IsNot Nothing, CInt(result), -1)
        End Using
    End Function

    Public Function GetStudentIdByStudentName(studentName As String) As Integer
        Dim query As String = "SELECT student_id FROM students WHERE first_name = @StudentName"
        Using cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@StudentName", studentName)
            Dim result As Object = db.ExeScalar(cmd)
            Return If(result IsNot Nothing, CInt(result), -1) ' Return the student_id or -1 if not found
        End Using
    End Function

    Public Function IsStudentIdUnique(studentId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM grading WHERE student_id = @StudentId"
        Using cmd As New MySqlCommand(query)
            cmd.Parameters.AddWithValue("@StudentId", studentId)
            Dim result As Object = db.ExeScalar(cmd)
            Return If(CInt(result) > 0, False, True) ' Return False if student_id exists, True otherwise
        End Using
    End Function

    Public Function GetCourseNameByCourseId(courseId As Integer) As String
        ' Query to get the course name based on course_id
        Dim query As String = "SELECT course_name FROM courses WHERE course_id = @CourseId"

        ' Using the MySqlCommand object to execute the query
        Using cmd As New MySqlCommand(query)
            ' Adding the course_id as parameter to the query
            cmd.Parameters.AddWithValue("@CourseId", courseId)

            ' Executing the scalar command to retrieve the course_name
            Dim result As Object = db.ExeScalar(cmd)

            ' Return the course_name or an empty string if not found
            Return If(result IsNot Nothing, CStr(result), String.Empty)
        End Using
    End Function

    Public Function GetCourseIdByStudentName(studentName As String) As Integer
        ' Query to get the course_id from the students table based on the student's first name
        Dim query As String = "SELECT course_id FROM students WHERE first_name = @StudentName"

        ' Using the MySqlCommand object to execute the query
        Using cmd As New MySqlCommand(query)
            ' Adding the studentName as parameter to the query
            cmd.Parameters.AddWithValue("@StudentName", studentName)

            ' Executing the scalar command to retrieve the course_id
            Dim result As Object = db.ExeScalar(cmd)

            ' Return the course_id or -1 if not found
            Return If(result IsNot Nothing, CInt(result), -1)
        End Using
    End Function

    Public Function IsStudentExist(studentName As String) As Boolean
        ' Query to check if the student exists based on the first name
        Dim query As String = "SELECT COUNT(*) FROM students WHERE first_name = @StudentName"

        ' Using the MySqlCommand object to execute the query
        Using cmd As New MySqlCommand(query)
            ' Adding the studentName as parameter to the query
            cmd.Parameters.AddWithValue("@StudentName", studentName)

            ' Executing the scalar command to get the count of matching names
            Dim result As Object = db.ExeScalar(cmd)

            ' Return True if student exists, False otherwise
            Return If(CInt(result) > 0, True, False)
        End Using
    End Function

End Class
