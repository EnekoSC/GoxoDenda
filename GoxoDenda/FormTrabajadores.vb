Public Class FormTrabajadores
    Private Sub btnTraAnadir_Click(sender As Object, e As EventArgs) Handles btnTraAnadir.Click
        pnlTraMenu.Visible = False
        pnlRegistro.Visible = True
    End Sub

    Private Sub btnTraMenuAtras_Click(sender As Object, e As EventArgs) Handles btnTraMenuAtras.Click
        Me.Visible = False
        FormMenu.Visible = True
    End Sub
End Class