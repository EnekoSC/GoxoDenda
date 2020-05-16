Public Class FormArticulos

    Dim articulos As DataTable

    Function crearBotones(nombre As String, id As String) As Button
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
        myTooltip.SetToolTip(myCtrl, $"{nombre}")
        Return myCtrl
    End Function

    Private Sub pnlTPV_Paint(sender As Object, e As PaintEventArgs) Handles pnlTPV.Paint
        articulos = Nothing

        For Each row In articulos.Rows

            pnlTPV.Controls.Add(crearBotones(row("NOMBRE"), row("ID")))
        Next
    End Sub
End Class