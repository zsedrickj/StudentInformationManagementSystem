Public Class Students
    Public Property StudentId As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property DateOfBirth As Date
    Public Property Gender As String
    Public Property Address As String
    Public Property EnrollmentDate As Date
    Public Property ProgramId As Integer
    Public Property DepartmentId As Integer
    Public Property CourseId As Integer


    Public Sub New(studentId As Integer, firstName As String, lastName As String, email As String, phoneNumber As String, dateOfBirth As Date, gender As String, address As String, enrollmentDate As Date)
        Me.StudentId = studentId
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.Email = email
        Me.PhoneNumber = phoneNumber
        Me.DateOfBirth = dateOfBirth
        Me.Gender = gender
        Me.Address = address
        Me.EnrollmentDate = enrollmentDate
    End Sub

    Public Sub New()
        ' Empty constructor for creating an instance without initialization
    End Sub

    Public Sub New(students As Students)
        Me.StudentId = students.StudentId
        Me.FirstName = students.FirstName
        Me.LastName = students.LastName
        Me.Email = students.Email
        Me.PhoneNumber = students.PhoneNumber
        Me.DateOfBirth = students.DateOfBirth
        Me.Gender = students.Gender
        Me.Address = students.Address
        Me.EnrollmentDate = students.EnrollmentDate
    End Sub
End Class
