Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DbConnection
    Dim con As New MySqlConnection("SERVER=localhost; DATABASE=StudentManagement; UID=root; PASSWORD=allenjavier_03;")
    Public Function getcon() As MySqlConnection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Return con
    End Function


    Public Function ExeNonQuery(cmd As MySqlCommand) As Integer
        cmd.Connection = getcon()
        Dim rowsAffected As Integer = -1

        Try
            rowsAffected = cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Optional: I-handle ang exception dito
            Console.WriteLine("Error: " & ex.Message)
        Finally
            con.Close()
        End Try

        Return rowsAffected
    End Function

    Public Function ExeScalar(cmd As MySqlCommand) As Object
        cmd.Connection = getcon()
        Dim obj As Object = Nothing ' Mas magandang i-initialize ito sa Nothing

        Try
            obj = cmd.ExecuteScalar()
        Catch ex As Exception
            ' Optional: I-handle ang exception dito
            Console.WriteLine("Error: " & ex.Message)
        Finally
            If cmd.Connection IsNot Nothing AndAlso cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close() ' Isinasara ang koneksyon kung ito ay bukas
            End If
        End Try

        Return obj
    End Function

    Public Function ExeReader(cmd As MySqlCommand) As DataTable
        cmd.Connection = getcon()
        Dim dt As New DataTable()

        Try
            Using sdr As MySqlDataReader = cmd.ExecuteReader()
                dt.Load(sdr)
            End Using
        Catch ex As Exception
            ' Optional: I-handle ang exception dito
            Console.WriteLine("Error: " & ex.Message)
        Finally
            If cmd.Connection IsNot Nothing AndAlso cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close() ' Isinasara ang koneksyon kung ito ay bukas
            End If
        End Try

        Return dt
    End Function

End Class
