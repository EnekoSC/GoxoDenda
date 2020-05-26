Imports System.Data.OleDb
Imports GoxoDenda.DAO

Public Class FormMenuArticulos

    Dim conn = DAO.Connection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModArtAtras.Click
        pnlModArticulos.Visible = False
        pnlArtMenu.Visible = True
    End Sub

    Private Sub lblModArtCategoria_Click(sender As Object, e As EventArgs) Handles lblModArtCategoria.Click

    End Sub

    Private Sub btnArtMod_Click(sender As Object, e As EventArgs) Handles btnArtMod.Click
        pnlArtMenu.Visible = False
        pnlNewArt.Visible = False
        pnlModArticulos.Visible = True
        cargarComboArticulos()


    End Sub

    Private Sub btnArtAnadir_Click(sender As Object, e As EventArgs) Handles btnArtAnadir.Click
        pnlArtMenu.Visible = False
        pnlModArticulos.Visible = False
        pnlNewArt.Visible = True
        'Para cargar valores del combobox de categoria
        cargarComboCategorias()
    End Sub

    Private Sub cargarComboCategorias()
        Dim tabla As New DataTable
        Dim query = "SELECT * FROM CATEGORIA"
        Dim oledbCommand = New OleDbCommand(query, conn)
        Dim adp As New OleDbDataAdapter(oledbCommand)

        adp.Fill(tabla)

        cmbNewArtCategoria.DataSource = tabla
        cmbNewArtCategoria.DisplayMember = "NOMBRE"
        cmbNewArtCategoria.ValueMember = "IDCATEGORIA"
    End Sub

    Private Sub cargarComboArticulos()
        Dim tabla As New DataTable
        Dim query = "SELECT * FROM ARTICULOS"
        Dim oledbCommand = New OleDbCommand(query, conn)
        Dim adp As New OleDbDataAdapter(oledbCommand)

        adp.Fill(tabla)

        cmbModArt.DataSource = tabla
        cmbModArt.DisplayMember = "NOMBRE"
        cmbModArt.ValueMember = "IDARTICULO"
    End Sub

    Private Sub añadirArticulo()
        Dim query = "INSERT INTO ARTICULOS (IDARTICULO, IDCATEGORIA, NOMBRE, PRECIO) VALUES
            (@idArticulo, @idCategoria, @idNombre, @idPrecio)"

        Dim conn = DAO.Connection()
        conn.Open()
        Dim oleDbCommand = New OleDbCommand(query, conn)

        Dim idArticulo = txtNewArtId.Text
        Dim idCategoria = cmbNewArtCategoria.SelectedItem.ToString
        Dim idNombre = txtNewArtNombre.Text
        Dim idPrecio = txtNewArtPrecio.Text


        With oleDbCommand
            .Parameters.AddWithValue("@idArticulo", idArticulo)
            .Parameters.AddWithValue("@idCategoria", idCategoria)
            .Parameters.AddWithValue("@idNombre", idNombre)
            .Parameters.AddWithValue("@idPrecio", idPrecio)
        End With
        oleDbCommand.ExecuteNonQuery()
        conn.Close()


    End Sub

    Private Sub btnNewArtFin_Click(sender As Object, e As EventArgs) Handles btnNewArtFin.Click
        añadirArticulo()
    End Sub

    Private Sub btnNewArtAtras_Click(sender As Object, e As EventArgs) Handles btnNewArtAtras.Click
        pnlNewArt.Visible = False
        pnlModArticulos.Visible = False
        pnlArtMenu.Visible = True
    End Sub

    Private Sub cmbModArt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModArt.SelectedIndexChanged
        Dim idArticulo As Integer = Val(cmbModArt.SelectedValue.ToString)
        Dim nombre As String
        Dim idCategoria As String
        Dim precio As Double

        Dim conn = DAO.Connection()
        conn.Open()

        Dim tabla As New DataTable
        Dim query = "SELECT * FROM ARTICULOS WHERE IDARTICULO = @idArticulo"
        Dim oledbCommand = New OleDbCommand(query, conn)



        oledbCommand.Parameters.AddWithValue("@idArticulo", idArticulo)
        Dim executeReader = oledbCommand.ExecuteReader

        If executeReader.HasRows Then
            tabla.Load(executeReader)
            idCategoria = tabla.Rows.Item(1).ToString
            nombre = tabla.Rows.Item(2).ToString
            precio = tabla.Rows.Item(4).ToString
        End If

        txtModArtCategoria.Text = idCategoria
        txtModArtNombre.Text = nombre
        txtModArtPrecio.Text = precio
        conn.Close()

        'cmbModArt.DataSource = tabla
        'cmbModArt.DisplayMember = "NOMBRE"
    End Sub
End Class