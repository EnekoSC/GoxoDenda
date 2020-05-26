
Imports System.Data.OleDb

Namespace DAO

    Public Module DB

        Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\GoxoDenda.accdb;Persist Security Info=False"

        Public Function Connection() As OleDbConnection
            Return New OleDbConnection(connectionString)
        End Function

        Public Function getConnection() As OleDbConnection
            Dim connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\database.accdb;Persist Security Info=False"
            getConnection = New OleDbConnection(connString)
        End Function

        Private Function DataAdapter() As OleDbDataAdapter 'SqlDataAdapter
            'Return New SqlClient.SqlDataAdapter(DirectCast(cmd, SqlCommand))
            Return New OleDbDataAdapter()
        End Function

        Private Function Command(queryString As String, connection As Object) As OleDbCommand
            Return New OleDbCommand(queryString, connection)
        End Function

    End Module

End Namespace

