Public Class FormMenu
    Private Sub btnMenuArticulos_Click(sender As Object, e As EventArgs) Handles btnMenuArticulos.Click
        Me.Visible = False
        FormMenuArticulos.Visible = True
    End Sub

    Private Sub btnMenuTrabajadores_Click(sender As Object, e As EventArgs) Handles btnMenuTrabajadores.Click
        Me.Visible = False
        FormTrabajadores.Visible = True
    End Sub

    Private Sub btnMenuPedidos_Click(sender As Object, e As EventArgs) Handles btnMenuPedidos.Click
        Me.Visible = False
        FormPedidos.Visible = True
    End Sub
End Class