Imports System.Data.OleDb

Module ControladorUsuarios
    Private row As String
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\GoxoDenda.accdb;Persist Security Info=False"

    Private Function Connection() As OleDbConnection
        Return New OleDbConnection(connectionString)
    End Function
    Public Function getConnection() As OleDbConnection
        Dim connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\GoxoDenda.accdb;Persist Security Info=False"
        getConnection = New OleDbConnection(connString)
    End Function

    Private Function DataAdapter() As OleDbDataAdapter 'SqlDataAdapter
        'Return New SqlClient.SqlDataAdapter(DirectCast(cmd, SqlCommand))
        Return New OleDbDataAdapter()
    End Function

    Private Function Command(queryString As String, connection As Object) As OleDbCommand
        Return New OleDbCommand(queryString, connection)
    End Function

    Sub insertTrabajador(nombre As String, contrasena As String, dni As String)

        Dim ventaTotal As Integer = 0
        Dim id = Guid.NewGuid()
        Dim conn = Connection()
        conn.Open()
        Dim cmd = conn.CreateCommand()
        cmd.CommandText = "INSERT INTO TRABAJADORES (NOMBRE, CONTRASEÑA, DNI, VENTATOTAL) 
                            VALUES (@nombre, @contrasena, @dni, @ventaTotal)"
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@contrasena", contrasena)
        cmd.Parameters.AddWithValue("@dni", dni)
        cmd.Parameters.AddWithValue("@ventaTotal", ventaTotal)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Function login(nombre As String, contrasena As String)

        Dim query = "SELECT NOMBRE, CONTRASEÑA FROM TRABAJADORES WHERE NOMBRE = @nombre AND CONTRASEÑA = @contrasena"
        Dim id = Guid.NewGuid()
        Dim conn = Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)

        Dim cmd = conn.CreateCommand()
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@contrasena", contrasena)
        Dim tabla = New DataTable
        Dim executeReader = oledbCommand.ExecuteReader()
        tabla.Load(executeReader)
        conn.Close()
        Return tabla.Rows.Count
    End Function

    'IGNORAR ESTO
    Public Sub CreateReader(ByVal connectionString As String,
    ByVal query As String)

        Using connection As New OleDbConnection(connectionString)
            Dim command As New OleDbCommand(query, connection)

            connection.Open()

            Dim reader As OleDbDataReader = command.ExecuteReader()
            While reader.Read()
                Console.WriteLine(reader(0).ToString())
            End While
            reader.Close()
        End Using
    End Sub

End Module
