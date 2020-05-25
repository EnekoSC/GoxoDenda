﻿
Public Class FormLogin


#Region "Funcion Limpiar"
    Sub clearLogin()
        txtUsuario.Text = ""
        txtContrasena.Text = ""
    End Sub
    Sub clearRegistro()
        txtRegUsuario.Text = ""
        txtRegContrasena.Text = ""
        txtRegDni.Text = ""
    End Sub
#End Region

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        clearLogin()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim acceso As DataTable

        acceso = login(txtUsuario.Text, txtContrasena.Text)
        MsgBox($"{acceso.Rows.Count}")
        If acceso.Rows.Count = 1 Then
            If permiso = 1 Then
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

    Private Sub btnLoginAñadir_Click(sender As Object, e As EventArgs) Handles btnLoginAñadir.Click
        pnlLogin.Visible = False
        pnlRegistro.Visible = True
    End Sub

    Private Sub btnRegLimpiar_Click(sender As Object, e As EventArgs) Handles btnRegLimpiar.Click
        clearRegistro()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
