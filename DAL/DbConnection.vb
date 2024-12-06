Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DbConnection
    Public con As New MySqlConnection("SERVER=localhost; DATABASE=studentinformationmanagementsystem; UID=root; PASSWORD=allenjavier_03;")

    Public Function getcon() As MySqlConnection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return con
    End Function

    Public Function ExeNonQuery(cmd As MySqlCommand) As Integer
        cmd.Connection = getcon()
        Dim rowsAffected As Integer = -1
        rowsAffected = cmd.ExecuteNonQuery()
        con.Close()
        Return rowsAffected
    End Function

    Public Function ExeScalar(cmd As MySqlCommand) As Object
        cmd.Connection = getcon()
        Dim obj As Object = -1
        obj = cmd.ExecuteScalar()
        con.Close()
        Return obj
    End Function

    Public Function ExeReader(cmd As MySqlCommand) As DataTable
        cmd.Connection = getcon()
        Dim sdr As MySqlDataReader
        Dim dt As New DataTable()

        sdr = cmd.ExecuteReader()
        dt.Load(sdr)
        con.Close()
        Return dt
    End Function

End Class
