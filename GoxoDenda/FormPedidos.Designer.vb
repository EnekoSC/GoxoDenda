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
        Me.pnlArtMenu = New System.Windows.Forms.Panel()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.btnArtMenuAtras = New System.Windows.Forms.Button()
        Me.lblArtTitulo = New System.Windows.Forms.Label()
        Me.pnlArtMenu.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlArtMenu)
        Me.Name = "FormPedidos"
        Me.Text = "Form1"
        Me.pnlArtMenu.ResumeLayout(False)
        Me.pnlArtMenu.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlArtMenu As Panel
    Friend WithEvents btnArtMenuAtras As Button
    Friend WithEvents lblArtTitulo As Label
    Friend WithEvents dgvPedidos As DataGridView
End Class
