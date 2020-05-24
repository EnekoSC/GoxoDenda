Imports System.Data.OleDb
Imports GoxoDenda.DAO

Public Class FormArticulos

    Dim articulos As DataTable
    Dim idArticulo As String
    Dim nombreArticulo As String
    Dim precioArticulo As Double

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

    Function crearBotones(nombre As String, id As String, precio As Double) As Button
        Dim myCtrl As New Button
        With myCtrl
            .Size = New Size(100, 100)
            .Text = nombre
            .TextAlign = ContentAlignment.BottomCenter
            .Font = lblTotal.Font
            .ForeColor = Color.Blue
            .Tag = id
            '.Image = 
            '.ImageAlign = ContentAlignment.TopCenter
            '.BackgroundImageLayout = ImageLayout.Zoom
            '.BackgroundImage = 
        End With
        Dim myTooltip As New ToolTip
        Dim precioArticulo As Double
        precioArticulo = precio
        myTooltip.SetToolTip(myCtrl, $"{nombre}")
        Return myCtrl
    End Function

    Function buscarArticuloPorId(id As String)
        Dim query = "SELECT NOMBRE, PRECIO FROM ARTICULOS WHERE IDARTICULO = @id"
        Dim conn = Connection()
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
        MsgBox($"{precioArticulo}")
        'Dim reader As OleDbDataReader = oledbCommand.ExecuteReader()
        tablaArticulos.Load(executeReader)
        conn.Close()
        Return tablaArticulos
    End Function


    Function buscarArticulosPorCategoria(categoria As String)

        Dim query = "SELECT NOMBRE, IDARTICULO, PRECIO FROM ARTICULOS WHERE IDCATEGORIA = @categoria"
        Dim id = Guid.NewGuid()
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
            .Size = New Size(100, 100)
            .Text = nombre
            .TextAlign = ContentAlignment.BottomCenter
            .Font = btnBebidas.Font
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
        'Aquí deberia poner la línea para obtener el precio y sumar al total

        '       sender.Text + vbCrLf +
        Dim id = sender.tag
        MsgBox("Articulo seleccionado ID: " + $"{id}")
        Dim datosArticulo = buscarArticuloPorId(id)
        Dim precio = datosArticulo
        'SetForm(sender.tag)
    End Sub

    Private Sub btnBolleria_Click(sender As Object, e As EventArgs) Handles btnBolleria.Click
        'articulos.Clear()
        pnlTPV.Controls.Clear()
        articulos = buscarArticulosPorCategoria("BOL")
        Console.WriteLine(articulos.Rows.Count)

        For Each row In articulos.Rows
            pnlTPV.Controls.Add(CreateButton(row("NOMBRE"), row("IDARTICULO"), row("Precio")))
        Next

    End Sub

End Class