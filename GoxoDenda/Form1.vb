
Public Class Form1

    Dim ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;Persist Security Info=False;"


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
        'NO SÉ COMO COGER DATOS DE LA TABLA Y COMPARAR CON LAS VARIABLES QUE INTRODUCE EL USUARIO

        Dim acceso As Integer

        acceso = login(txtUsuario.Text, txtContrasena.Text)

        If acceso = 1 Then
            Me.Visible = False
            FormArticulos.Visible = True
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
