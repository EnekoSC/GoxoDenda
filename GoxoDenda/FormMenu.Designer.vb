<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.btnMenuTrabajadores = New System.Windows.Forms.Button()
        Me.btnMenuArticulos = New System.Windows.Forms.Button()
        Me.btnMenuPedidos = New System.Windows.Forms.Button()
        Me.btnMenuProveedores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(277, 34)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(300, 42)
        Me.lblLogin.TabIndex = 1
        Me.lblLogin.Text = "MENU PRINCIPAL"
        '
        'btnMenuTrabajadores
        '
        Me.btnMenuTrabajadores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuTrabajadores.Location = New System.Drawing.Point(175, 142)
        Me.btnMenuTrabajadores.Name = "btnMenuTrabajadores"
        Me.btnMenuTrabajadores.Size = New System.Drawing.Size(192, 108)
        Me.btnMenuTrabajadores.TabIndex = 2
        Me.btnMenuTrabajadores.Text = "TRABAJADORES"
        Me.btnMenuTrabajadores.UseVisualStyleBackColor = True
        '
        'btnMenuArticulos
        '
        Me.btnMenuArticulos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuArticulos.Location = New System.Drawing.Point(434, 142)
        Me.btnMenuArticulos.Name = "btnMenuArticulos"
        Me.btnMenuArticulos.Size = New System.Drawing.Size(192, 108)
        Me.btnMenuArticulos.TabIndex = 3
        Me.btnMenuArticulos.Text = "ARTÍCULOS"
        Me.btnMenuArticulos.UseVisualStyleBackColor = True
        '
        'btnMenuPedidos
        '
        Me.btnMenuPedidos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuPedidos.Location = New System.Drawing.Point(175, 277)
        Me.btnMenuPedidos.Name = "btnMenuPedidos"
        Me.btnMenuPedidos.Size = New System.Drawing.Size(192, 108)
        Me.btnMenuPedidos.TabIndex = 4
        Me.btnMenuPedidos.Text = "PEDIDOS"
        Me.btnMenuPedidos.UseVisualStyleBackColor = True
        '
        'btnMenuProveedores
        '
        Me.btnMenuProveedores.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuProveedores.Location = New System.Drawing.Point(434, 277)
        Me.btnMenuProveedores.Name = "btnMenuProveedores"
        Me.btnMenuProveedores.Size = New System.Drawing.Size(192, 108)
        Me.btnMenuProveedores.TabIndex = 5
        Me.btnMenuProveedores.Text = "PROVEEDORES"
        Me.btnMenuProveedores.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.btnMenuProveedores)
        Me.Controls.Add(Me.btnMenuPedidos)
        Me.Controls.Add(Me.btnMenuArticulos)
        Me.Controls.Add(Me.btnMenuTrabajadores)
        Me.Controls.Add(Me.lblLogin)
        Me.Name = "FormMenu"
        Me.Text = "GoxoDenda App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents btnMenuTrabajadores As Button
    Friend WithEvents btnMenuArticulos As Button
    Friend WithEvents btnMenuPedidos As Button
    Friend WithEvents btnMenuProveedores As Button
End Class
