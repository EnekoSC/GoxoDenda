
Public Class FormLogin


#Region "Funcion Limpiar"
    Sub clearLogin()
        txtUsuario.Text = ""
        txtContrasena.Text = ""
    End Sub
#End Region

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        clearLogin()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim acceso As DataTable

        acceso = login(txtUsuario.Text, txtContrasena.Text)

        If acceso.Rows.Count = 1 Then
            If ControladorUsuarios.permiso = 1 Then
                Me.Visible = False
                FormMenu.Visible = True
            Else
                Me.Visible = False
                FormTpv.Visible = True
            End If
        Else

            MsgBox("Usuario o contraseña incorrectos")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
