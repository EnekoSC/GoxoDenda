<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPedidos))
        Me.pnlArtMenu = New System.Windows.Forms.Panel()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.btnArtMenuAtras = New System.Windows.Forms.Button()
        Me.lblArtTitulo = New System.Windows.Forms.Label()
        Me.pnlPedDetalles = New System.Windows.Forms.Panel()
        Me.lblPedDetCompraTotal = New System.Windows.Forms.Label()
        Me.lblPedDetTotal = New System.Windows.Forms.Label()
        Me.dgvPedDetalles = New System.Windows.Forms.DataGridView()
        Me.btnPedDetAtras = New System.Windows.Forms.Button()
        Me.lblPedDetTitulo = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.pnlArtMenu.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPedDetalles.SuspendLayout()
        CType(Me.dgvPedDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlArtMenu
        '
        Me.pnlArtMenu.Controls.Add(Me.dgvPedidos)
        Me.pnlArtMenu.Controls.Add(Me.btnArtMenuAtras)
        Me.pnlArtMenu.Controls.Add(Me.lblArtTitulo)
        Me.pnlArtMenu.Location = New System.Drawing.Point(-1, -1)
        Me.pnlArtMenu.Name = "pnlArtMenu"
        Me.pnlArtMenu.Size = New System.Drawing.Size(826, 453)
        Me.pnlArtMenu.TabIndex = 15
        '
        'dgvPedidos
        '
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(116, 91)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.Size = New System.Drawing.Size(603, 196)
        Me.dgvPedidos.TabIndex = 13
        '
        'btnArtMenuAtras
        '
        Me.btnArtMenuAtras.BackColor = System.Drawing.SystemColors.Menu
        Me.btnArtMenuAtras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtMenuAtras.Location = New System.Drawing.Point(52, 396)
        Me.btnArtMenuAtras.Name = "btnArtMenuAtras"
        Me.btnArtMenuAtras.Size = New System.Drawing.Size(101, 34)
        Me.btnArtMenuAtras.TabIndex = 12
        Me.btnArtMenuAtras.Text = "Atrás"
        Me.btnArtMenuAtras.UseVisualStyleBackColor = True
        '
        'lblArtTitulo
        '
        Me.lblArtTitulo.AutoSize = True
        Me.lblArtTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblArtTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblArtTitulo.Location = New System.Drawing.Point(331, 19)
        Me.lblArtTitulo.Name = "lblArtTitulo"
        Me.lblArtTitulo.Size = New System.Drawing.Size(165, 42)
        Me.lblArtTitulo.TabIndex = 7
        Me.lblArtTitulo.Text = "PEDIDOS"
        Me.lblArtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPedDetalles
        '
        Me.pnlPedDetalles.Controls.Add(Me.lblEuro)
        Me.pnlPedDetalles.Controls.Add(Me.lblPedDetCompraTotal)
        Me.pnlPedDetalles.Controls.Add(Me.lblPedDetTotal)
        Me.pnlPedDetalles.Controls.Add(Me.dgvPedDetalles)
        Me.pnlPedDetalles.Controls.Add(Me.btnPedDetAtras)
        Me.pnlPedDetalles.Controls.Add(Me.lblPedDetTitulo)
        Me.pnlPedDetalles.Location = New System.Drawing.Point(0, 0)
        Me.pnlPedDetalles.Name = "pnlPedDetalles"
        Me.pnlPedDetalles.Size = New System.Drawing.Size(826, 453)
        Me.pnlPedDetalles.TabIndex = 16
        '
        'lblPedDetCompraTotal
        '
        Me.lblPedDetCompraTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPedDetCompraTotal.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedDetCompraTotal.ForeColor = System.Drawing.Color.Black
        Me.lblPedDetCompraTotal.Location = New System.Drawing.Point(614, 313)
        Me.lblPedDetCompraTotal.Name = "lblPedDetCompraTotal"
        Me.lblPedDetCompraTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPedDetCompraTotal.Size = New System.Drawing.Size(105, 33)
        Me.lblPedDetCompraTotal.TabIndex = 15
        Me.lblPedDetCompraTotal.Text = "0,00"
        Me.lblPedDetCompraTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPedDetTotal
        '
        Me.lblPedDetTotal.AutoSize = True
        Me.lblPedDetTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPedDetTotal.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedDetTotal.ForeColor = System.Drawing.Color.Black
        Me.lblPedDetTotal.Location = New System.Drawing.Point(498, 313)
        Me.lblPedDetTotal.Name = "lblPedDetTotal"
        Me.lblPedDetTotal.Size = New System.Drawing.Size(105, 33)
        Me.lblPedDetTotal.TabIndex = 14
        Me.lblPedDetTotal.Text = "TOTAL: "
        Me.lblPedDetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPedDetalles
        '
        Me.dgvPedDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedDetalles.Location = New System.Drawing.Point(116, 91)
        Me.dgvPedDetalles.Name = "dgvPedDetalles"
        Me.dgvPedDetalles.ReadOnly = True
        Me.dgvPedDetalles.Size = New System.Drawing.Size(603, 196)
        Me.dgvPedDetalles.TabIndex = 13
        '
        'btnPedDetAtras
        '
        Me.btnPedDetAtras.BackColor = System.Drawing.SystemColors.Menu
        Me.btnPedDetAtras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedDetAtras.Location = New System.Drawing.Point(52, 396)
        Me.btnPedDetAtras.Name = "btnPedDetAtras"
        Me.btnPedDetAtras.Size = New System.Drawing.Size(101, 34)
        Me.btnPedDetAtras.TabIndex = 12
        Me.btnPedDetAtras.Text = "Atrás"
        Me.btnPedDetAtras.UseVisualStyleBackColor = True
        '
        'lblPedDetTitulo
        '
        Me.lblPedDetTitulo.AutoSize = True
        Me.lblPedDetTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPedDetTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedDetTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblPedDetTitulo.Location = New System.Drawing.Point(234, 19)
        Me.lblPedDetTitulo.Name = "lblPedDetTitulo"
        Me.lblPedDetTitulo.Size = New System.Drawing.Size(382, 42)
        Me.lblPedDetTitulo.TabIndex = 7
        Me.lblPedDetTitulo.Text = "DETALLES DEL PEDIDO"
        Me.lblPedDetTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEuro.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuro.ForeColor = System.Drawing.Color.Black
        Me.lblEuro.Location = New System.Drawing.Point(709, 313)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(30, 33)
        Me.lblEuro.TabIndex = 16
        Me.lblEuro.Text = "€"
        Me.lblEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlArtMenu)
        Me.Controls.Add(Me.pnlPedDetalles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPedidos"
        Me.Text = "Goxo Denda App"
        Me.pnlArtMenu.ResumeLayout(False)
        Me.pnlArtMenu.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPedDetalles.ResumeLayout(False)
        Me.pnlPedDetalles.PerformLayout()
        CType(Me.dgvPedDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlArtMenu As Panel
    Friend WithEvents btnArtMenuAtras As Button
    Friend WithEvents lblArtTitulo As Label
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents pnlPedDetalles As Panel
    Friend WithEvents lblPedDetCompraTotal As Label
    Friend WithEvents lblPedDetTotal As Label
    Friend WithEvents dgvPedDetalles As DataGridView
    Friend WithEvents btnPedDetAtras As Button
    Friend WithEvents lblPedDetTitulo As Label
    Friend WithEvents lblEuro As Label
End Class
