Imports System.Data.OleDb
Imports GoxoDenda.DAO

Public Class FormMenuArticulos

    Dim conn = DAO.Connection
    Dim idArticulo As String
    Dim idCategoria As String
    Dim precio As Double
    Dim nombre As String

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
        cargarComboCategorias()
        cargarComboArticulos()
        cmbModArt.DropDownStyle = 2


    End Sub

    Private Sub btnArtAnadir_Click(sender As Object, e As EventArgs) Handles btnArtAnadir.Click
        pnlArtMenu.Visible = False
        pnlModArticulos.Visible = False
        pnlNewArt.Visible = True
        cmbNewArtCategoria.DropDownStyle = 2
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

        cmbModArtCategoria.DataSource = tabla
        cmbModArtCategoria.DisplayMember = "NOMBRE"
        cmbModArtCategoria.ValueMember = "IDCATEGORIA"
    End Sub

    Private Sub cargarComboArticulos()
        Dim tabla As New DataTable
        Dim query = "SELECT * FROM ARTICULOS"
        Dim oledbCommand = New OleDbCommand(query, conn)
        Dim adp As New OleDbDataAdapter(oledbCommand)
        adp.Fill(tabla)

        cmbModArt.DisplayMember = "NOMBRE"
        cmbModArt.ValueMember = "IDARTICULO"
        cmbModArt.DataSource = tabla

    End Sub

    Private Sub añadirArticulo()
        Dim query = "INSERT INTO ARTICULOS (IDARTICULO, IDCATEGORIA, NOMBRE, PRECIO) VALUES
            (@idArticulo, @idCategoria, @idNombre, @idPrecio)"

        Dim conn = DAO.Connection()
        Try
            conn.Open()
            Dim oleDbCommand = New OleDbCommand(query, conn)

            Dim idArticulo = txtNewArtId.Text.ToString
            Dim idCategoria = cmbNewArtCategoria.SelectedValue
            Dim idNombre = txtNewArtNombre.Text.ToString
            Dim idPrecio = CDbl(txtNewArtPrecio.Text.ToString)


            With oleDbCommand
                .Parameters.AddWithValue("@idArticulo", idArticulo)
                .Parameters.AddWithValue("@idCategoria", idCategoria)
                .Parameters.AddWithValue("@idNombre", idNombre)
                .Parameters.AddWithValue("@idPrecio", idPrecio)
            End With
            oleDbCommand.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox($"{ex}")
        End Try

    End Sub

    Private Sub buscarArticuloByNombre(nombre As String)
        Dim query = "SELECT * FROM ARTICULOS WHERE NOMBRE = @nombre"
        Dim conn = DAO.Connection
        Dim oleDbCommand = New OleDbCommand(query, conn)
        conn.Open()

        oleDbCommand.Parameters.AddWithValue("@nombre", nombre)

        Dim tabla = New DataTable
        Dim executeReader = oleDbCommand.ExecuteReader
        Try
            If executeReader.HasRows Then
                tabla.Load(executeReader)
                idArticulo = tabla.Rows(0).Item(0)
                idCategoria = tabla.Rows(0).Item(1)
                precio = tabla.Rows(0).Item(3)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try


    End Sub

    Private Sub btnNewArtFin_Click(sender As Object, e As EventArgs) Handles btnNewArtFin.Click
        añadirArticulo()
        MsgBox("¡Artículo añadido con éxito!")
    End Sub

    Private Sub btnNewArtAtras_Click(sender As Object, e As EventArgs) Handles btnNewArtAtras.Click
        pnlNewArt.Visible = False
        pnlModArticulos.Visible = False
        pnlArtMenu.Visible = True
    End Sub

    Private Sub cmbModArt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModArt.SelectedIndexChanged

        nombre = cmbModArt.Text.ToString
        idCategoria = cmbModArtCategoria.SelectedValue
        buscarArticuloByNombre(nombre)

        If idCategoria = "BEB" Then
            cmbModArtCategoria.Text = "BEBIDAS"
        ElseIf idCategoria = "VAR" Then
            cmbModArtCategoria.Text = "VARIOS"
        ElseIf idCategoria = "PAT" Then
            cmbModArtCategoria.Text = "PATATAS"
        ElseIf idCategoria = "GOM" Then
            cmbModArtCategoria.Text = "GOMINOLAS"
        ElseIf idCategoria = "BOL" Then
            cmbModArtCategoria.Text = "BOLLERIA"
        ElseIf idCategoria = "PAN" Then
            cmbModArtCategoria.Text = "PAN"
        End If


        txtModArtId.Text = idArticulo
        txtModArtCategoria.Text = idCategoria
        txtModArtNombre.Text = nombre
        txtModArtPrecio.Text = precio
    End Sub


    Private Sub btnArtMenuAtras_Click(sender As Object, e As EventArgs) Handles btnArtMenuAtras.Click
        Me.Visible = False
        FormTpv.Visible = True
    End Sub

    Private Sub cmbModArtCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModArtCategoria.SelectedIndexChanged
        If cmbModArtCategoria.Text = "BEBIDAS" Then
            idCategoria = "BEB"
        ElseIf cmbModArtCategoria.Text = "PATATAS" Then
            idCategoria = "PAT"
        ElseIf cmbModArtCategoria.Text = "VARIOS" Then
            idCategoria = "VAR"
        ElseIf cmbModArtCategoria.Text = "GOMINOLAS" Then
            idCategoria = "GOM"
        ElseIf cmbModArtCategoria.Text = "BOLLERIA" Then
            idCategoria = "BOL"
        ElseIf cmbModArtCategoria.Text = "PAN" Then
            idCategoria = "PAN"
        End If
    End Sub

    Private Sub actualizarArticulo(idArticulo As String, idCategoria As String, nombre As String, precio As Double)

        Dim query = "UPDATE ARTICULOS SET Precio = @precio WHERE IDARTICULO = @idArticulo"
        Dim conn = DAO.Connection
        conn.Open()
        Dim oleDbCommand As New OleDbCommand(query, conn)

        oleDbCommand.Parameters.AddWithValue("@precio", precio)
        oleDbCommand.Parameters.AddWithValue("@idArticulo", idArticulo)

        oleDbCommand.ExecuteNonQuery()

        conn.Close()



    End Sub

    Private Sub btnModArtGuardar_Click(sender As Object, e As EventArgs) Handles btnModArtGuardar.Click
        Dim idArticulo = txtModArtId.Text.ToString
        Dim idCategoria = Me.idCategoria
        Dim precio = CDbl(txtModArtPrecio.Text.ToString)
        Dim nombre = txtModArtNombre.Text.ToString
        actualizarArticulo(idArticulo, idCategoria, nombre, precio)
        MsgBox("Artículo modificado con éxito.")
    End Sub
End Class