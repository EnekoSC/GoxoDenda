<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArticulos
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
        Me.pnlTraMenu = New System.Windows.Forms.Panel()
        Me.btnArtMenuAtras = New System.Windows.Forms.Button()
        Me.btnArtAnadir = New System.Windows.Forms.Button()
        Me.lblArtTitulo = New System.Windows.Forms.Label()
        Me.btnArtBorrar = New System.Windows.Forms.Button()
        Me.pnlTraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTraMenu
        '
        Me.pnlTraMenu.Controls.Add(Me.btnArtMenuAtras)
        Me.pnlTraMenu.Controls.Add(Me.btnArtAnadir)
        Me.pnlTraMenu.Controls.Add(Me.lblArtTitulo)
        Me.pnlTraMenu.Controls.Add(Me.btnArtBorrar)
        Me.pnlTraMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTraMenu.Name = "pnlTraMenu"
        Me.pnlTraMenu.Size = New System.Drawing.Size(826, 453)
        Me.pnlTraMenu.TabIndex = 14
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
        'btnArtAnadir
        '
        Me.btnArtAnadir.BackColor = System.Drawing.Color.LightGreen
        Me.btnArtAnadir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtAnadir.Location = New System.Drawing.Point(447, 168)
        Me.btnArtAnadir.Name = "btnArtAnadir"
        Me.btnArtAnadir.Size = New System.Drawing.Size(305, 143)
        Me.btnArtAnadir.TabIndex = 11
        Me.btnArtAnadir.Text = "Añadir Artículo"
        Me.btnArtAnadir.UseVisualStyleBackColor = False
        '
        'lblArtTitulo
        '
        Me.lblArtTitulo.AutoSize = True
        Me.lblArtTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblArtTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblArtTitulo.Location = New System.Drawing.Point(271, 34)
        Me.lblArtTitulo.Name = "lblArtTitulo"
        Me.lblArtTitulo.Size = New System.Drawing.Size(308, 42)
        Me.lblArtTitulo.TabIndex = 7
        Me.lblArtTitulo.Text = "MENU ARTÍCULOS"
        '
        'btnArtBorrar
        '
        Me.btnArtBorrar.BackColor = System.Drawing.Color.LightCoral
        Me.btnArtBorrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtBorrar.Location = New System.Drawing.Point(69, 168)
        Me.btnArtBorrar.Name = "btnArtBorrar"
        Me.btnArtBorrar.Size = New System.Drawing.Size(305, 143)
        Me.btnArtBorrar.TabIndex = 10
        Me.btnArtBorrar.Text = "Eliminar Artículo"
        Me.btnArtBorrar.UseVisualStyleBackColor = False
        '
        'FormArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlTraMenu)
        Me.Name = "FormArticulos"
        Me.Text = "Goxo Denda App"
        Me.pnlTraMenu.ResumeLayout(False)
        Me.pnlTraMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTraMenu As Panel
    Friend WithEvents btnArtMenuAtras As Button
    Friend WithEvents btnArtAnadir As Button
    Friend WithEvents lblArtTitulo As Label
    Friend WithEvents btnArtBorrar As Button
End Class
