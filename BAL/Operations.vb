Imports DAL
Imports BEL
Imports MySql.Data.MySqlClient ' Import the MySQL namespace

Namespace BAL
    Public Class Operations
        ' Use MySqlConnection instead of DbConnection
        Public db As New MySqlConnection("SERVER=localhost; DATABASE=StudentManagement; UID=root; PASSWORD=allenjavier_03;")
        Public info As New Informations()


    End Class
End Namespace
