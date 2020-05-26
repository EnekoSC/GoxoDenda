Imports System.Data.OleDb
Imports GoxoDenda.DAO

Public Class FormTpv

    Dim articulos As DataTable
    Dim idArticulo As String
    Dim nombreArticulo As String
    Dim precioArticulo As Double
    Dim totalCompra As Double
    Dim idPedido As Integer
    Dim cantidadArticulo As Integer
    Dim i = 0
    Dim fecha As Date
    Dim fechaActual As Date = Date.Now

    Public Property Hoy As DateTime

    Function getArticulos(nombre As String, id As String)

        Dim query = "SELECT NOMBRE, IDARTICULO FROM ARTICULOS WHERE NOMBRE = @nombre AND IDARTICULO = @id"

        Dim conn = DB.Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        oledbCommand.Parameters.AddWithValue("@nombre", nombre)
        'oledbCommand.Parameters.AddWithValue("@contrasena", contrasena)
        Dim tabla = New DataTable
        Dim executeReader = oledbCommand.ExecuteReader()
        tabla.Load(executeReader)
        conn.Close()
        Return tabla.Rows.Count
    End Function

    Function buscarArticuloPorId(id As String)
        Dim query = "SELECT NOMBRE, PRECIO FROM ARTICULOS WHERE IDARTICULO = @id"
        Dim conn = DAO.Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        oledbCommand.Parameters.AddWithValue("@id", id)
        Dim tablaArticulos = New DataTable
        Dim executeReader = oledbCommand.ExecuteReader()
        If executeReader.HasRows Then
            Do While executeReader.Read()
                nombreArticulo = executeReader.GetString(0)
                precioArticulo = executeReader.GetDouble(1)
            Loop
        End If
        'Dim reader As OleDbDataReader = oledbCommand.ExecuteReader()
        tablaArticulos.Load(executeReader)
        conn.Close()
        Return tablaArticulos
    End Function

    Function buscarPedido(idPedido As Integer)
        Dim query = "SELECT * FROM PEDIDOS WHERE IDPEDIDO = @idPedido"
        Dim conn = DAO.Connection()
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        oleDbCommand.Parameters.AddWithValue("@idPedido", idPedido)
        Dim tablaPedidos = New DataTable
        Dim executeReader = oleDbCommand.ExecuteReader()
        Dim fecha

        If executeReader.HasRows Then
            fecha = executeReader.GetDataTypeName(2)
            tablaPedidos.Load(executeReader)
            MsgBox(tablaPedidos.Rows(0).Item(2))

            MsgBox($"{fecha}")
        End If

        conn.Close()
        Return tablaPedidos

    End Function

    Function buscarArticulosPorCategoria(categoria As String)

        Dim query = "SELECT NOMBRE, IDARTICULO, PRECIO FROM ARTICULOS WHERE IDCATEGORIA = @categoria"
        Dim conn = Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        oledbCommand.Parameters.AddWithValue("@categoria", categoria)

        Dim tablaArticulos = New DataTable
        Dim executeReader = oledbCommand.ExecuteReader()
        tablaArticulos.Load(executeReader)
        conn.Close()
        Return tablaArticulos
    End Function

    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnBebidas.Click
        'articulos.Clear()
        pnlTPV.Controls.Clear()
        articulos = buscarArticulosPorCategoria("BEB")

        For Each row In articulos.Rows
            pnlTPV.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO"), row("Precio")))
        Next

    End Sub

    Function CreateButton(nombre As String, id As String, precio As Double) As Button
        Dim myCtrl As New Button
        With myCtrl
            .Size = New Size(75, 75)
            .Text = nombre
            .TextAlign = ContentAlignment.BottomCenter
            .Font = lblTamano.Font
            .ForeColor = Color.Blue
            .Tag = id
            '.Image = Access.WinForm.My.Resources.Resources.pnglogo2
            '.ImageAlign = ContentAlignment.BottomCenter
            '.BackgroundImageLayout = ImageLayout.Zoom
            '.BackgroundImage = PresentacionUI.My.Resources.Resources.pnglogo2
        End With
        AddHandler myCtrl.Click, AddressOf Me.theButton_Click
        Dim myToolTip As New ToolTip
        myToolTip.SetToolTip(myCtrl, $"{nombre}")

        Return myCtrl
    End Function

    Private Sub theButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '       sender.Text + vbCrLf +
        idArticulo = sender.tag
        Dim datosArticulo = buscarArticuloPorId(idArticulo)
        Dim precio = datosArticulo
        totalCompra = totalCompra + precioArticulo
        lblCuentaTotal.Text = $"{totalCompra}" + "€"
        'SetForm(sender.tag)
    End Sub

    Private Sub btnBolleria_Click(sender As Object, e As EventArgs) Handles btnBolleria.Click
        'articulos.Clear()
        pnlTPV.Controls.Clear()
        articulos = buscarArticulosPorCategoria("BOL")
        Console.WriteLine(articulos.Rows.Count)
        insertTrabajador("aurelio", "1234", "41233124L")
        For Each row In articulos.Rows
            pnlTPV.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO"), row("Precio")))
        Next
        fecha = Hoy
        MsgBox($"{fecha}")
    End Sub

    Private Sub crearPedido(idTrabajador As Integer)
        Dim query = "INSERT INTO PEDIDOS (IDTRABAJADOR, FECHA, PRECIOTOTAL) VALUES (@idTrabajador, @fecha,
                        @precioTotal)"
        fecha = Date.Now
        Dim conn = DAO.Connection()
        conn.Open()

        Dim oledbCommand = New OleDbCommand(query, conn)
        With oledbCommand
            .Parameters.AddWithValue("@idTrabajador", idTrabajador)
            .Parameters.AddWithValue("@fecha", fecha.ToString)
            .Parameters.AddWithValue("@precioTotal", 0)
        End With

        oledbCommand.ExecuteNonQuery()
        conn.Close()

    End Sub

    Private Sub buscarIdPedido(fechaActual As Date)
        Dim fechaLocal As String
        fechaLocal = fechaActual.ToString

        Dim query = "SELECT * FROM PEDIDOS WHERE Fecha = @fecha"
        Dim conn = Connection()
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        With oleDbCommand
            .Parameters.AddWithValue("@fecha", fechaLocal)
        End With
        Dim tablaLocal As DataTable
        Dim executeReader = oleDbCommand.ExecuteReader()

        If executeReader.HasRows Then
            tablaLocal.Load(executeReader)
            idPedido = tablaLocal.Rows(0).Item(1)
        End If
        conn.Close()
    End Sub

    Private Sub insertarLinea(idArticulo As String, idPedido As Integer, cantidadArticulo As Integer, precio As String)
        Dim query = "INSERT INTO LINEASDEPEDIDO (IDARTICULO, IDPEDIDO, CANTIDAD, PRECIO) VALUES (@idArticulo, @idPedido, 
                        @cantidadArticulo, @precio)"
        Dim conn = DB.Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        With oledbCommand
            .Parameters.AddWithValue("@idArticulo", idArticulo)
            .Parameters.AddWithValue("@idPedido", idPedido)
            .Parameters.AddWithValue("@cantidadArticulo", cantidadArticulo)
            .Parameters.AddWithValue("@precio", precio)
        End With


        oledbCommand.ExecuteNonQuery()

        'Try
        'conn.Open()
        'oledbCommand.ExecuteNonQuery()

        'Catch ex As Exception
        'MessageBox.Show(ex.Message.ToString(), "Error")
        'End Try
        conn.Close()


    End Sub

#Region "BOTONES CANTIDAD"
    Private Sub btnTpv1_Click(sender As Object, e As EventArgs) Handles btnTpv1.Click
        cantidadArticulo = cantidadArticulo * 10 + 1
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv2_Click(sender As Object, e As EventArgs) Handles btnTpv2.Click
        cantidadArticulo = cantidadArticulo * 10 + 2
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv3_Click(sender As Object, e As EventArgs) Handles btnTpv3.Click
        cantidadArticulo = cantidadArticulo * 10 + 3
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv4_Click(sender As Object, e As EventArgs) Handles btnTpv4.Click
        cantidadArticulo = cantidadArticulo * 10 + 4
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv5_Click(sender As Object, e As EventArgs) Handles btnTpv5.Click
        cantidadArticulo = cantidadArticulo * 10 + 5
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv6_Click(sender As Object, e As EventArgs) Handles btnTpv6.Click
        cantidadArticulo = cantidadArticulo * 10 + 6
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv7_Click(sender As Object, e As EventArgs) Handles btnTpv7.Click
        cantidadArticulo = cantidadArticulo * 10 + 7
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv8_Click(sender As Object, e As EventArgs) Handles btnTpv8.Click
        cantidadArticulo = cantidadArticulo * 10 + 8
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv9_Click(sender As Object, e As EventArgs) Handles btnTpv9.Click
        cantidadArticulo = cantidadArticulo * 10 + 9
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnTpv0_Click(sender As Object, e As EventArgs) Handles btnTpv0.Click
        cantidadArticulo = cantidadArticulo * 10
        i += 1
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

    Private Sub btnCantidadEliminar_Click(sender As Object, e As EventArgs) Handles btnCantidadEliminar.Click
        cantidadArticulo = 0
        lblCantidadProd.Text = "Cantidad: " + $"{cantidadArticulo}"
    End Sub

#End Region

    Private Sub btnCantidadOK_Click(sender As Object, e As EventArgs) Handles btnCantidadOK.Click
        If idArticulo = "" Then
            MsgBox("Debes seleccionar un artículo antes de meter la cantidad.")
        Else

            crearPedido(ControladorUsuarios.idTrabajador)
            buscarIdPedido(fecha)
            MsgBox($"{idPedido}")
            'insertarLinea(idArticulo, idPedido, cantidadArticulo, precioArticulo)
            cantidadArticulo = 0
            idArticulo = ""
        End If

    End Sub
End Class