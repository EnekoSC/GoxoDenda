Imports System.Data.OleDb
Imports GoxoDenda.DAO

Public Class FormPedidos

    Private Sub FormPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPedidos()

    End Sub

    Dim PedidosDt As DataTable
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

        dgvPedidos.DataSource = PedidosDt
    End Sub


End Class