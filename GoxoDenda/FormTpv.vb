Imports System.Data.OleDb
Imports GoxoDenda.DAO

Public Class FormTpv

    Dim articulos As DataTable
    Dim idArticulo As String
    Dim nombreArticulo As String
    Dim precioArticulo As Double
    Dim precioLinea As Double
    Dim totalCompra As Double
    Dim idPedido As Integer
    Dim idLinea As Integer
    Dim cantidadArticulo As Integer
    Dim i = 0
    Dim fecha As Date
    Dim fechaActual As DateTime = DateTime.Now
    Dim dr As DataRow
    Dim value As Object

    Dim LineasDePedidoDt As DataTable
    Dim reader As OleDbDataReader

    Public Property Hoy As DateTime
    Dim formatoFecha As String = "dd/MM/yyyy"

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
        Dim conn = DAO.Connection()
        conn.Open()
        Dim oledbCommand = New OleDbCommand(query, conn)
        oledbCommand.Parameters.AddWithValue("@categoria", categoria)

        Dim tablaArticulos = New DataTable
        Dim executeReader = oledbCommand.ExecuteReader()
        tablaArticulos.Load(executeReader)
        conn.Close()
        Return tablaArticulos
    End Function

    Private Function obtenerFecha()
        fecha = Date.Now
        Dim fechaDias As String
        fechaDias = fecha.ToString(formatoFecha)
        Return fechaDias
    End Function


    Private Sub updatePedido()

        Dim fecha As String
        fecha = obtenerFecha()

        Dim query = "UPDATE PEDIDOS SET PrecioTotal = @precioTotal, FECHA = @fecha WHERE IDPEDIDO = @idPedido"
        Dim conn = DAO.Connection()
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        oleDbCommand.Parameters.AddWithValue("@precioTotal", totalCompra)
        oleDbCommand.Parameters.AddWithValue("@idPedido", idPedido)
        oleDbCommand.Parameters.AddWithValue("@fecha", fecha)
        Dim executeReader = oleDbCommand.ExecuteNonQuery()

        conn.Close()

    End Sub

    Function CreateButton(nombre As String, id As String) As Button
        Dim myCtrl As New Button
        With myCtrl
            .Size = New Size(75, 75)
            .Text = nombre
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = lblTamano.Font
            .ForeColor = Color.Black
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
        lblTpvPrecio.Text = "Precio: " + $"{precioArticulo}" + "€"
        cantidadArticulo = 0
        'SetForm(sender.tag)
    End Sub
#Region "===== BOTONES DE CATEGORIA ====="
    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnBebidas.Click
        'articulos.Clear()
        pnlTpv.Controls.Clear()
        articulos = buscarArticulosPorCategoria("BEB")

        For Each row In articulos.Rows
            pnlTpv.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO")))
        Next

    End Sub

    Private Sub btnBolleria_Click(sender As Object, e As EventArgs) Handles btnBolleria.Click
        'articulos.Clear()
        pnlTPV.Controls.Clear()
        articulos = buscarArticulosPorCategoria("BOL")
        Console.WriteLine(articulos.Rows.Count)
        For Each row As DataRow In articulos.Rows
            pnlTpv.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO")))
        Next row
        fecha = Hoy
    End Sub

    Private Sub btnChuches_Click(sender As Object, e As EventArgs) Handles btnChuches.Click
        pnlTpv.Controls.Clear()
        articulos = buscarArticulosPorCategoria("GOM")
        Console.WriteLine(articulos.Rows.Count)
        For Each row In articulos.Rows
            pnlTpv.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO")))
        Next
        fecha = Hoy
    End Sub

    Private Sub btnPan_Click(sender As Object, e As EventArgs) Handles btnPan.Click
        pnlTpv.Controls.Clear()
        articulos = buscarArticulosPorCategoria("PAN")
        Console.WriteLine(articulos.Rows.Count)
        For Each row In articulos.Rows
            pnlTpv.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO")))
        Next
        fecha = Hoy
    End Sub

    Private Sub btnPatatas_Click(sender As Object, e As EventArgs) Handles btnPatatas.Click
        pnlTpv.Controls.Clear()
        articulos = buscarArticulosPorCategoria("PAT")
        Console.WriteLine(articulos.Rows.Count)
        For Each row In articulos.Rows
            pnlTpv.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO")))
        Next
        fecha = Hoy
    End Sub

    Private Sub btnVarios_Click(sender As Object, e As EventArgs) Handles btnVarios.Click
        pnlTpv.Controls.Clear()
        articulos = buscarArticulosPorCategoria("VAR")
        For Each row In articulos.Rows
            pnlTpv.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO")))
        Next
        fecha = Hoy
    End Sub
#End Region
    Private Sub pedidoVacio(idTrabajador As Integer)
        Dim query = "INSERT INTO PEDIDOS (IDTRABAJADOR, FECHA, PRECIOTOTAL) VALUES (@idTrabajador, @fecha,
                        @precioTotal)"
        Dim fecha As String
        fecha = obtenerFecha()

        Dim conn = DAO.Connection()
        conn.Open()

        Dim oledbCommand = New OleDbCommand(query, conn)
        With oledbCommand
            .Parameters.AddWithValue("@idTrabajador", idTrabajador)
            .Parameters.AddWithValue("@fecha", fecha)
            .Parameters.AddWithValue("@precioTotal", 0)
        End With

        oledbCommand.ExecuteNonQuery()
        conn.Close()

    End Sub

    Private Sub buscarIdPedido()
        'Obtengo el ID del nuevo pedido para hacer los insert

        Dim query = "SELECT TOP 1 * FROM PEDIDOS ORDER BY IDPEDIDO DESC"
        Dim conn = Connection()
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)

        Dim tablaLocal = New DataTable
        Dim executeReader = oleDbCommand.ExecuteReader()

        If executeReader.HasRows Then
            tablaLocal.Load(executeReader)
            idPedido = tablaLocal.Rows(0).Item(0)
            Console.WriteLine("Pedido " + $"{idPedido}")
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
        conn.Close()


    End Sub

    Private Sub borrarLinea(idLinea As Integer)
        Dim query = "DELETE FROM LINEASDEPEDIDO WHERE IDLINEASDEPEDIDO = @idLinea"
        Dim conn = DAO.Connection
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        oleDbCommand.Parameters.AddWithValue("@idLinea", idLinea)

        oleDbCommand.ExecuteNonQuery()
        conn.Close()

    End Sub

    Private Sub quitarDiferenciaLinea(idLinea As Integer)
        Dim quitarPrecio As Double
        Dim query = "SELECT PRECIO FROM LINEASDEPEDIDO WHERE IDLINEASDEPEDIDO = @idLinea"
        Dim conn = DAO.Connection
        Dim oleDbCommand = New OleDbCommand(query, conn)
        conn.Open()
        oleDbCommand.Parameters.AddWithValue("@idLinea", idLinea)
        Dim tabla = New DataTable
        Dim executeReader = oleDbCommand.ExecuteReader
        If executeReader.HasRows Then
            tabla.Load(executeReader)
            quitarPrecio = tabla.Rows(0).Item(0)
        End If

        totalCompra = totalCompra - quitarPrecio
    End Sub

#Region "====== BOTONES CANTIDAD ======"
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

            'pedidoVacio(ControladorUsuarios.idTrabajador)
            buscarIdPedido()
            insertarLinea(idArticulo, idPedido, cantidadArticulo, (precioArticulo * cantidadArticulo))
            totalCompra = totalCompra + (precioArticulo * cantidadArticulo)
            lblCuentaTotal.Text = $"{totalCompra}" + "€"
            cantidadArticulo = 0
            idArticulo = ""
        End If

    End Sub

    Private Sub cargarLineasDePedido()
        LineasDePedidoDt = New DataTable
        LineasDePedidoDt.Clear()
        Dim query = "SELECT * FROM LINEASDEPEDIDO WHERE IDPEDIDO = @idPedido"
        Dim conn = Connection()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        conn.Open()
        oleDbCommand.Parameters.AddWithValue("@idPedido", idPedido)
        Dim reader = oleDbCommand.ExecuteReader
        LineasDePedidoDt.Load(reader)

        DgvLineas.DataSource = LineasDePedidoDt
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        pnlPrincipal.Visible = False
        pnlTpvFactura.Visible = True

        cargarLineasDePedido()

    End Sub

    Private Sub btnTpvFacAtras_Click(sender As Object, e As EventArgs) Handles btnTpvFacAtras.Click
        pnlTpvFactura.Visible = False
        pnlPrincipal.Visible = True
    End Sub

    Private Sub btnTpvFacFin_Click(sender As Object, e As EventArgs) Handles btnTpvFacFin.Click
        updatePedido()
        updateVentasTrabajador(totalCompra)
        MsgBox($"{totalCompra}")
        idPedido += 1
        pnlPrincipal.Visible = True
        pnlTpvFactura.Visible = False

        pedidoVacio(ControladorUsuarios.idTrabajador)
        totalCompra = 0.00
        lblCuentaTotal.Text = "0,00€"

    End Sub

    Private Sub btnPrincipalMenu_Click(sender As Object, e As EventArgs) Handles btnPrincipalMenu.Click
        Me.Visible = False
        FormMenu.Visible = True
    End Sub

    Private Sub btnTpvFacEliminar_Click(sender As Object, e As EventArgs) Handles btnTpvFacEliminar.Click

        Try
            borrarLinea(idLinea)
            cargarLineasDePedido()
            quitarDiferenciaLinea(idLinea)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub dgvLineas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvLineas.CellClick

        Dim i As Integer
        i = DgvLineas.CurrentRow.Index
        idLinea = DgvLineas.Item(0, i).Value
        Label1.Text = idLinea.ToString

    End Sub



End Class