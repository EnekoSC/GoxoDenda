Imports System.Data.OleDb

Module ControladorUsuarios
    Private row As String
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\GoxoDenda.accdb;Persist Security Info=False"
    Public permiso As Integer
    Public idTrabajador As Integer
    Sub insertTrabajador(nombre As String, contrasena As String, dni As String)

        nombre = nombre.ToLower
        Dim ventaTotal As Double = 0
        Dim conn = DAO.Connection()
        conn.Open()
        Dim cmd = conn.CreateCommand()
        cmd.CommandText = "INSERT INTO TRABAJADORES (NOMBRE, CONTRASENA, DNI, VENTATOTAL) 
                            VALUES (@nombre, @contrasena, @dni, @ventaTotal)"
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@contrasena", contrasena)
        cmd.Parameters.AddWithValue("@dni", dni)
        cmd.Parameters.AddWithValue("@ventaTotal", ventaTotal)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Function login(nombre As String, contrasena As String)

        Dim query = "SELECT * FROM TRABAJADORES WHERE Nombre = @nombre AND Contrasena = @contrasena"
        Dim conn = DAO.Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        oledbCommand.Parameters.AddWithValue("@nombre", nombre)
        oledbCommand.Parameters.AddWithValue("@contrasena", contrasena)
        Dim tabla = New DataTable
        Dim executeReader = oledbCommand.ExecuteReader()

        If executeReader.HasRows Then
            tabla.Load(executeReader)
            idTrabajador = tabla.Rows(0).Item(0)
            permiso = tabla.Rows(0).Item(5)
        End If

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

    Function obtenerVentaTotalTrabajador()
        Dim tabla = New DataTable
        Dim ventaTotal As Double
        Dim query = "SELECT VENTATOTAL FROM TRABAJADORES WHERE IDTRABAJADOR = @idTrabajador"
        Dim conn = DAO.Connection
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        oleDbCommand.Parameters.AddWithValue("idTrabajador", idTrabajador)
        Dim executeReader = oleDbCommand.ExecuteReader

        If executeReader.HasRows Then
            tabla.Load(executeReader)
            ventaTotal = tabla.Rows(0).Item(0)
        End If
        conn.Close()
        Return ventaTotal
    End Function

    Sub updateVentasTrabajador(precioTotal As Double)
        Dim totalVendido = obtenerVentaTotalTrabajador()
        precioTotal = precioTotal + totalVendido
        Dim query = "UPDATE TRABAJADORES SET VENTATOTAL = @precioTotal WHERE IDTRABAJADOR = @idTrabajador"
        Dim conn = DAO.Connection
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        With oleDbCommand
            .Parameters.AddWithValue("precioTotal", precioTotal)
            .Parameters.AddWithValue("idTrabajador", idTrabajador)
        End With

        oleDbCommand.ExecuteNonQuery()
        conn.Close()

    End Sub


End Module
