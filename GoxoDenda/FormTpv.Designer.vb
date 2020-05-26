<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTpv
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTpv))
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.lblCantidadProd = New System.Windows.Forms.Label()
        Me.pnlCantidad = New System.Windows.Forms.Panel()
        Me.btnCantidadOK = New System.Windows.Forms.Button()
        Me.btnCantidadEliminar = New System.Windows.Forms.Button()
        Me.btnTpv0 = New System.Windows.Forms.Button()
        Me.btnTpv9 = New System.Windows.Forms.Button()
        Me.btnTpv8 = New System.Windows.Forms.Button()
        Me.btnTpv7 = New System.Windows.Forms.Button()
        Me.btnTpv6 = New System.Windows.Forms.Button()
        Me.btnTpv5 = New System.Windows.Forms.Button()
        Me.btnTpv4 = New System.Windows.Forms.Button()
        Me.btnTpv3 = New System.Windows.Forms.Button()
        Me.btnTpv2 = New System.Windows.Forms.Button()
        Me.btnTpv1 = New System.Windows.Forms.Button()
        Me.lblTamano = New System.Windows.Forms.Label()
        Me.lblCuentaTotal = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnPrincipalMenu = New System.Windows.Forms.Button()
        Me.btnVarios = New System.Windows.Forms.Button()
        Me.btnPatatas = New System.Windows.Forms.Button()
        Me.btnPan = New System.Windows.Forms.Button()
        Me.btnChuches = New System.Windows.Forms.Button()
        Me.btnBolleria = New System.Windows.Forms.Button()
        Me.btnBebidas = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlTpv = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlPrincipal.SuspendLayout()
        Me.pnlCantidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlPrincipal.Controls.Add(Me.pnlTpv)
        Me.pnlPrincipal.Controls.Add(Me.lblCantidadProd)
        Me.pnlPrincipal.Controls.Add(Me.pnlCantidad)
        Me.pnlPrincipal.Controls.Add(Me.lblTamano)
        Me.pnlPrincipal.Controls.Add(Me.lblCuentaTotal)
        Me.pnlPrincipal.Controls.Add(Me.btnFinalizar)
        Me.pnlPrincipal.Controls.Add(Me.btnPrincipalMenu)
        Me.pnlPrincipal.Controls.Add(Me.btnVarios)
        Me.pnlPrincipal.Controls.Add(Me.btnPatatas)
        Me.pnlPrincipal.Controls.Add(Me.btnPan)
        Me.pnlPrincipal.Controls.Add(Me.btnChuches)
        Me.pnlPrincipal.Controls.Add(Me.btnBolleria)
        Me.pnlPrincipal.Controls.Add(Me.btnBebidas)
        Me.pnlPrincipal.Controls.Add(Me.lblTotal)
        Me.pnlPrincipal.Controls.Add(Me.lblTitulo)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(827, 454)
        Me.pnlPrincipal.TabIndex = 9
        '
        'lblCantidadProd
        '
        Me.lblCantidadProd.AutoSize = True
        Me.lblCantidadProd.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadProd.Location = New System.Drawing.Point(582, 330)
        Me.lblCantidadProd.Name = "lblCantidadProd"
        Me.lblCantidadProd.Size = New System.Drawing.Size(120, 22)
        Me.lblCantidadProd.TabIndex = 14
        Me.lblCantidadProd.Text = "Cantidad: 0"
        '
        'pnlCantidad
        '
        Me.pnlCantidad.Controls.Add(Me.btnCantidadOK)
        Me.pnlCantidad.Controls.Add(Me.btnCantidadEliminar)
        Me.pnlCantidad.Controls.Add(Me.btnTpv0)
        Me.pnlCantidad.Controls.Add(Me.btnTpv9)
        Me.pnlCantidad.Controls.Add(Me.btnTpv8)
        Me.pnlCantidad.Controls.Add(Me.btnTpv7)
        Me.pnlCantidad.Controls.Add(Me.btnTpv6)
        Me.pnlCantidad.Controls.Add(Me.btnTpv5)
        Me.pnlCantidad.Controls.Add(Me.btnTpv4)
        Me.pnlCantidad.Controls.Add(Me.btnTpv3)
        Me.pnlCantidad.Controls.Add(Me.btnTpv2)
        Me.pnlCantidad.Controls.Add(Me.btnTpv1)
        Me.pnlCantidad.Location = New System.Drawing.Point(583, 58)
        Me.pnlCantidad.Name = "pnlCantidad"
        Me.pnlCantidad.Size = New System.Drawing.Size(229, 251)
        Me.pnlCantidad.TabIndex = 6
        '
        'btnCantidadOK
        '
        Me.btnCantidadOK.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCantidadOK.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidadOK.Location = New System.Drawing.Point(153, 186)
        Me.btnCantidadOK.Name = "btnCantidadOK"
        Me.btnCantidadOK.Size = New System.Drawing.Size(76, 62)
        Me.btnCantidadOK.TabIndex = 25
        Me.btnCantidadOK.Text = "OK"
        Me.btnCantidadOK.UseVisualStyleBackColor = False
        '
        'btnCantidadEliminar
        '
        Me.btnCantidadEliminar.BackColor = System.Drawing.Color.LightCoral
        Me.btnCantidadEliminar.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidadEliminar.Location = New System.Drawing.Point(3, 186)
        Me.btnCantidadEliminar.Name = "btnCantidadEliminar"
        Me.btnCantidadEliminar.Size = New System.Drawing.Size(76, 62)
        Me.btnCantidadEliminar.TabIndex = 24
        Me.btnCantidadEliminar.Text = "C"
        Me.btnCantidadEliminar.UseVisualStyleBackColor = False
        '
        'btnTpv0
        '
        Me.btnTpv0.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv0.Location = New System.Drawing.Point(78, 186)
        Me.btnTpv0.Name = "btnTpv0"
        Me.btnTpv0.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv0.TabIndex = 23
        Me.btnTpv0.Text = "0"
        Me.btnTpv0.UseVisualStyleBackColor = True
        '
        'btnTpv9
        '
        Me.btnTpv9.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv9.Location = New System.Drawing.Point(153, 125)
        Me.btnTpv9.Name = "btnTpv9"
        Me.btnTpv9.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv9.TabIndex = 22
        Me.btnTpv9.Text = "9"
        Me.btnTpv9.UseVisualStyleBackColor = True
        '
        'btnTpv8
        '
        Me.btnTpv8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv8.Location = New System.Drawing.Point(78, 125)
        Me.btnTpv8.Name = "btnTpv8"
        Me.btnTpv8.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv8.TabIndex = 21
        Me.btnTpv8.Text = "8"
        Me.btnTpv8.UseVisualStyleBackColor = True
        '
        'btnTpv7
        '
        Me.btnTpv7.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv7.Location = New System.Drawing.Point(3, 125)
        Me.btnTpv7.Name = "btnTpv7"
        Me.btnTpv7.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv7.TabIndex = 20
        Me.btnTpv7.Text = "7"
        Me.btnTpv7.UseVisualStyleBackColor = True
        '
        'btnTpv6
        '
        Me.btnTpv6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv6.Location = New System.Drawing.Point(153, 64)
        Me.btnTpv6.Name = "btnTpv6"
        Me.btnTpv6.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv6.TabIndex = 19
        Me.btnTpv6.Text = "6"
        Me.btnTpv6.UseVisualStyleBackColor = True
        '
        'btnTpv5
        '
        Me.btnTpv5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv5.Location = New System.Drawing.Point(78, 64)
        Me.btnTpv5.Name = "btnTpv5"
        Me.btnTpv5.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv5.TabIndex = 18
        Me.btnTpv5.Text = "5"
        Me.btnTpv5.UseVisualStyleBackColor = True
        '
        'btnTpv4
        '
        Me.btnTpv4.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv4.Location = New System.Drawing.Point(3, 64)
        Me.btnTpv4.Name = "btnTpv4"
        Me.btnTpv4.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv4.TabIndex = 17
        Me.btnTpv4.Text = "4"
        Me.btnTpv4.UseVisualStyleBackColor = True
        '
        'btnTpv3
        '
        Me.btnTpv3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv3.Location = New System.Drawing.Point(153, 3)
        Me.btnTpv3.Name = "btnTpv3"
        Me.btnTpv3.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv3.TabIndex = 16
        Me.btnTpv3.Text = "3"
        Me.btnTpv3.UseVisualStyleBackColor = True
        '
        'btnTpv2
        '
        Me.btnTpv2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv2.Location = New System.Drawing.Point(78, 3)
        Me.btnTpv2.Name = "btnTpv2"
        Me.btnTpv2.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv2.TabIndex = 15
        Me.btnTpv2.Text = "2"
        Me.btnTpv2.UseVisualStyleBackColor = True
        '
        'btnTpv1
        '
        Me.btnTpv1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTpv1.Location = New System.Drawing.Point(3, 3)
        Me.btnTpv1.Name = "btnTpv1"
        Me.btnTpv1.Size = New System.Drawing.Size(76, 62)
        Me.btnTpv1.TabIndex = 14
        Me.btnTpv1.Text = "1"
        Me.btnTpv1.UseVisualStyleBackColor = True
        '
        'lblTamano
        '
        Me.lblTamano.AutoSize = True
        Me.lblTamano.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamano.Location = New System.Drawing.Point(9, 371)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(0, 17)
        Me.lblTamano.TabIndex = 13
        Me.lblTamano.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCuentaTotal
        '
        Me.lblCuentaTotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentaTotal.Location = New System.Drawing.Point(698, 413)
        Me.lblCuentaTotal.Name = "lblCuentaTotal"
        Me.lblCuentaTotal.Size = New System.Drawing.Size(104, 22)
        Me.lblCuentaTotal.TabIndex = 12
        Me.lblCuentaTotal.Text = "0,00€"
        Me.lblCuentaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.DimGray
        Me.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnFinalizar.FlatAppearance.BorderSize = 0
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.ForeColor = System.Drawing.Color.Transparent
        Me.btnFinalizar.Image = CType(resources.GetObject("btnFinalizar.Image"), System.Drawing.Image)
        Me.btnFinalizar.Location = New System.Drawing.Point(510, 399)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(54, 46)
        Me.btnFinalizar.TabIndex = 11
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'btnPrincipalMenu
        '
        Me.btnPrincipalMenu.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrincipalMenu.Location = New System.Drawing.Point(12, 413)
        Me.btnPrincipalMenu.Name = "btnPrincipalMenu"
        Me.btnPrincipalMenu.Size = New System.Drawing.Size(114, 29)
        Me.btnPrincipalMenu.TabIndex = 10
        Me.btnPrincipalMenu.Text = "Menú"
        Me.btnPrincipalMenu.UseVisualStyleBackColor = True
        '
        'btnVarios
        '
        Me.btnVarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVarios.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVarios.Location = New System.Drawing.Point(4, 233)
        Me.btnVarios.Name = "btnVarios"
        Me.btnVarios.Size = New System.Drawing.Size(114, 29)
        Me.btnVarios.TabIndex = 9
        Me.btnVarios.Text = "VARIOS"
        Me.btnVarios.UseVisualStyleBackColor = False
        '
        'btnPatatas
        '
        Me.btnPatatas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPatatas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatatas.Location = New System.Drawing.Point(4, 198)
        Me.btnPatatas.Name = "btnPatatas"
        Me.btnPatatas.Size = New System.Drawing.Size(114, 29)
        Me.btnPatatas.TabIndex = 8
        Me.btnPatatas.Text = "PATATAS"
        Me.btnPatatas.UseVisualStyleBackColor = False
        '
        'btnPan
        '
        Me.btnPan.BackColor = System.Drawing.Color.PaleGreen
        Me.btnPan.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPan.Location = New System.Drawing.Point(5, 162)
        Me.btnPan.Name = "btnPan"
        Me.btnPan.Size = New System.Drawing.Size(114, 29)
        Me.btnPan.TabIndex = 7
        Me.btnPan.Text = "PAN"
        Me.btnPan.UseVisualStyleBackColor = False
        '
        'btnChuches
        '
        Me.btnChuches.BackColor = System.Drawing.Color.Aquamarine
        Me.btnChuches.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChuches.Location = New System.Drawing.Point(4, 127)
        Me.btnChuches.Name = "btnChuches"
        Me.btnChuches.Size = New System.Drawing.Size(114, 29)
        Me.btnChuches.TabIndex = 6
        Me.btnChuches.Text = "CHUCHES"
        Me.btnChuches.UseVisualStyleBackColor = False
        '
        'btnBolleria
        '
        Me.btnBolleria.BackColor = System.Drawing.Color.Yellow
        Me.btnBolleria.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBolleria.Location = New System.Drawing.Point(5, 92)
        Me.btnBolleria.Name = "btnBolleria"
        Me.btnBolleria.Size = New System.Drawing.Size(114, 29)
        Me.btnBolleria.TabIndex = 4
        Me.btnBolleria.Text = "BOLLERÍA"
        Me.btnBolleria.UseVisualStyleBackColor = False
        '
        'btnBebidas
        '
        Me.btnBebidas.BackColor = System.Drawing.Color.LightCoral
        Me.btnBebidas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBebidas.Location = New System.Drawing.Point(5, 57)
        Me.btnBebidas.Name = "btnBebidas"
        Me.btnBebidas.Size = New System.Drawing.Size(114, 29)
        Me.btnBebidas.TabIndex = 3
        Me.btnBebidas.Text = "BEBIDAS"
        Me.btnBebidas.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(629, 413)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 22)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total: "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(288, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(252, 42)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "GOXODENDA"
        '
        'pnlTpv
        '
        Me.pnlTpv.Location = New System.Drawing.Point(137, 59)
        Me.pnlTpv.Name = "pnlTpv"
        Me.pnlTpv.Size = New System.Drawing.Size(426, 292)
        Me.pnlTpv.TabIndex = 15
        '
        'FormTpv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "FormTpv"
        Me.Text = "Goxo Denda App"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.pnlCantidad.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents btnPrincipalMenu As Button
    Friend WithEvents btnVarios As Button
    Friend WithEvents btnPatatas As Button
    Friend WithEvents btnPan As Button
    Friend WithEvents btnChuches As Button
    Friend WithEvents btnBolleria As Button
    Friend WithEvents btnBebidas As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents lblCuentaTotal As Label
    Friend WithEvents lblTamano As Label
    Friend WithEvents pnlCantidad As Panel
    Friend WithEvents btnCantidadOK As Button
    Friend WithEvents btnCantidadEliminar As Button
    Friend WithEvents btnTpv0 As Button
    Friend WithEvents btnTpv9 As Button
    Friend WithEvents btnTpv8 As Button
    Friend WithEvents btnTpv7 As Button
    Friend WithEvents btnTpv6 As Button
    Friend WithEvents btnTpv5 As Button
    Friend WithEvents btnTpv4 As Button
    Friend WithEvents btnTpv3 As Button
    Friend WithEvents btnTpv2 As Button
    Friend WithEvents btnTpv1 As Button
    Friend WithEvents lblCantidadProd As Label
    Friend WithEvents pnlTpv As FlowLayoutPanel
End Class
