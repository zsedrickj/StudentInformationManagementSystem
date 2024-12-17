Public Class StudentCourse
    Public Property StudentCourseId As Integer ' Primary key
    Public Property StudentId As Integer ' Foreign key to students table
    Public Property CourseId As Integer ' Foreign key to courses table
    Public Property EnrollmentDate As Date ' Date of enrollment
    Public Property Status As String ' Enrollment status (Pending, Enrolled, etc.)


End Class
