
Public Class Form1

    Dim ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;Persist Security Info=False;"

#Region "Funcion Limpiar"
    Sub clearLogin()
        textUsuario.Text = ""
        textContrasena.Text = ""
    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblLogin.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblContrasena.Click

    End Sub

    Private Sub TextBoxUsuario_TextChanged(sender As Object, e As EventArgs) Handles textUsuario.TextChanged

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        clearLogin()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If textUsuario.Text = "admin" Then
            pnlLogin.Visible = False
            pnlRegistro.Visible = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblRegDni.Click

    End Sub
End Class
