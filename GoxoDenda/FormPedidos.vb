Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports GoxoDenda.DAO

Public Class FormPedidos

    Dim PedidosDt As DataTable

    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPedidos()

    End Sub

    Private Function seleccionarLineas(idPedido As Integer)
        Dim query = "SELECT * FROM LINEASDEPEDIDO WHERE IDPEDIDO = @idPedido"
        Dim conn = DAO.Connection
        Dim oleDbCommand = New OleDbCommand(query, conn)
        conn.Open()
        Dim tabla = New DataTable
        oleDbCommand.Parameters.AddWithValue("@idPedido", idPedido)
        Dim executeReader = oleDbCommand.ExecuteReader

        If executeReader.HasRows Then
            tabla.Load(executeReader)
        End If
        conn.Close()
        Return tabla
    End Function

    Private Sub btnArtMenuAtras_Click(sender As Object, e As EventArgs) Handles btnArtMenuAtras.Click
        Me.Visible = False
        FormMenu.Visible = True
    End Sub

    Private Sub cargarPedidos()
        PedidosDt = New DataTable
        PedidosDt.Clear()
        Dim query = "SELECT * FROM PEDIDOS"
        Dim conn = DAO.Connection()
        Dim oleDbCommand = New OleDbCommand(query, conn)
        conn.Open()
        Dim reader = oleDbCommand.ExecuteReader
        PedidosDt.Load(reader)
        conn.Close()
        dgvPedidos.DataSource = PedidosDt
        'Boton de ver detalles
        Dim btnDgv As New DataGridViewButtonColumn()
        dgvPedidos.Columns.Add(btnDgv)
        btnDgv.HeaderText = "Información"
        btnDgv.Text = "Ver detalles"
        btnDgv.Name = "btnVerDetalles"
        btnDgv.UseColumnTextForButtonValue = True





    End Sub

    Private Sub dgvPedidos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidos.CellClick
        Dim tabla = New DataTable
        Dim i As Integer
        Dim idPedido As Integer
        Dim precioTotal As Double

        i = dgvPedidos.CurrentRow.Index
        idPedido = dgvPedidos.Item(0, i).Value

        tabla = seleccionarLineas(idPedido)
        precioTotal = sumaLineas(idPedido)

        dgvPedDetalles.DataSource = tabla

        pnlPedDetalles.Visible = True
        pnlArtMenu.Visible = False

        lblPedDetCompraTotal.Text = precioTotal

    End Sub

    Private Sub btnPedDetAtras_Click(sender As Object, e As EventArgs) Handles btnPedDetAtras.Click
        pnlPedDetalles.Visible = False
        pnlArtMenu.Visible = True
    End Sub

    Public Function sumaLineas(idPedido As Integer)
        Dim precioTotal As Double
        Dim query = "SELECT SUM (Precio) FROM LINEASDEPEDIDO WHERE IDPEDIDO = @idPedido"
        Dim conn = DAO.Connection
        Dim oleDbCommand = New OleDbCommand(query, conn)
        conn.Open()
        oleDbCommand.Parameters.AddWithValue("@idPedido", idPedido)
        Dim reader = oleDbCommand.ExecuteReader
        Dim tabla = New DataTable
        If reader.HasRows Then
            tabla.Load(reader)
            precioTotal = tabla.Rows(0).Item(0)
        End If
        Return precioTotal
    End Function

End Class