Imports System.Data.OleDb

Module ControladorUsuarios
    Private row As String
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\GoxoDenda.accdb;Persist Security Info=False"
    Public permiso As Integer
    Sub insertTrabajador(nombre As String, contrasena As String, dni As String)

        nombre = nombre.ToLower
        Dim ventaTotal As Double = 0
        Dim conn = DAO.Connection()
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

        Dim query = "SELECT * FROM TRABAJADORES WHERE Nombre = @nombre AND Contraseña = @contrasena"
        Dim conn = DAO.Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        oledbCommand.Parameters.AddWithValue("@nombre", nombre)
        oledbCommand.Parameters.AddWithValue("@contrasena", contrasena)
        Dim tabla = New DataTable
        Dim executeReader = oledbCommand.ExecuteReader()

        While executeReader.Read()
            permiso = executeReader.GetInt32(5)
            MsgBox($"{permiso}")
        End While
        tabla.Load(executeReader)

        conn.Close()
        Return tabla
    End Function

    Sub modificarTrabajador(id As Integer, nombre As String, contraseña As String, dni As String)
        Dim query = "UPDATE TRABAJADORES SET NOMBRE = @nombre, CONTRASEÑA = @contraseña, DNI = @dni WHERE IDTRABAJADOR = @id"
        Dim conn = DAO.Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        oledbCommand.Parameters.AddWithValue("@nombre", nombre)
        oledbCommand.Parameters.AddWithValue("@contraseña", contraseña)
        oledbCommand.Parameters.AddWithValue("@dni", dni)
        oledbCommand.Parameters.AddWithValue("@id", id)

        Dim executeReader = oledbCommand.ExecuteNonQuery()
        conn.Close()

    End Sub

End Module
