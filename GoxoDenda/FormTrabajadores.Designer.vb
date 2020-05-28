<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTrabajadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTrabajadores))
        Me.pnlRegistro = New System.Windows.Forms.Panel()
        Me.txtRegDni = New System.Windows.Forms.TextBox()
        Me.txtRegContrasena = New System.Windows.Forms.TextBox()
        Me.txtRegUsuario = New System.Windows.Forms.TextBox()
        Me.btnRegLimpiar = New System.Windows.Forms.Button()
        Me.lblRegDni = New System.Windows.Forms.Label()
        Me.lblRegContrasena = New System.Windows.Forms.Label()
        Me.lblRegTitulo = New System.Windows.Forms.Label()
        Me.lblRegUsuario = New System.Windows.Forms.Label()
        Me.btnRegCrear = New System.Windows.Forms.Button()
        Me.pnlTraMenu = New System.Windows.Forms.Panel()
        Me.btnTraMenuAtras = New System.Windows.Forms.Button()
        Me.btnTraAnadir = New System.Windows.Forms.Button()
        Me.lblTraTitulo = New System.Windows.Forms.Label()
        Me.btnTraBorrar = New System.Windows.Forms.Button()
        Me.pnlTraEliminar = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlRegistro.SuspendLayout()
        Me.pnlTraMenu.SuspendLayout()
        Me.pnlTraEliminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlRegistro
        '
        Me.pnlRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlRegistro.Controls.Add(Me.txtRegDni)
        Me.pnlRegistro.Controls.Add(Me.txtRegContrasena)
        Me.pnlRegistro.Controls.Add(Me.txtRegUsuario)
        Me.pnlRegistro.Controls.Add(Me.btnRegLimpiar)
        Me.pnlRegistro.Controls.Add(Me.lblRegDni)
        Me.pnlRegistro.Controls.Add(Me.lblRegContrasena)
        Me.pnlRegistro.Controls.Add(Me.lblRegTitulo)
        Me.pnlRegistro.Controls.Add(Me.lblRegUsuario)
        Me.pnlRegistro.Controls.Add(Me.btnRegCrear)
        Me.pnlRegistro.Location = New System.Drawing.Point(-1, -2)
        Me.pnlRegistro.Name = "pnlRegistro"
        Me.pnlRegistro.Size = New System.Drawing.Size(827, 454)
        Me.pnlRegistro.TabIndex = 8
        '
        'txtRegDni
        '
        Me.txtRegDni.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegDni.Location = New System.Drawing.Point(374, 236)
        Me.txtRegDni.Name = "txtRegDni"
        Me.txtRegDni.Size = New System.Drawing.Size(209, 27)
        Me.txtRegDni.TabIndex = 12
        '
        'txtRegContrasena
        '
        Me.txtRegContrasena.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegContrasena.Location = New System.Drawing.Point(374, 195)
        Me.txtRegContrasena.Name = "txtRegContrasena"
        Me.txtRegContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegContrasena.Size = New System.Drawing.Size(209, 27)
        Me.txtRegContrasena.TabIndex = 11
        '
        'txtRegUsuario
        '
        Me.txtRegUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegUsuario.Location = New System.Drawing.Point(374, 157)
        Me.txtRegUsuario.Name = "txtRegUsuario"
        Me.txtRegUsuario.Size = New System.Drawing.Size(209, 27)
        Me.txtRegUsuario.TabIndex = 7
        '
        'btnRegLimpiar
        '
        Me.btnRegLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnRegLimpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegLimpiar.Location = New System.Drawing.Point(238, 312)
        Me.btnRegLimpiar.Name = "btnRegLimpiar"
        Me.btnRegLimpiar.Size = New System.Drawing.Size(101, 34)
        Me.btnRegLimpiar.TabIndex = 10
        Me.btnRegLimpiar.Text = "Limpiar"
        Me.btnRegLimpiar.UseVisualStyleBackColor = False
        '
        'lblRegDni
        '
        Me.lblRegDni.AutoSize = True
        Me.lblRegDni.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegDni.ForeColor = System.Drawing.Color.Black
        Me.lblRegDni.Location = New System.Drawing.Point(234, 241)
        Me.lblRegDni.Name = "lblRegDni"
        Me.lblRegDni.Size = New System.Drawing.Size(53, 22)
        Me.lblRegDni.TabIndex = 9
        Me.lblRegDni.Text = "DNI: "
        '
        'lblRegContrasena
        '
        Me.lblRegContrasena.AutoSize = True
        Me.lblRegContrasena.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegContrasena.ForeColor = System.Drawing.Color.Black
        Me.lblRegContrasena.Location = New System.Drawing.Point(234, 197)
        Me.lblRegContrasena.Name = "lblRegContrasena"
        Me.lblRegContrasena.Size = New System.Drawing.Size(124, 22)
        Me.lblRegContrasena.TabIndex = 8
        Me.lblRegContrasena.Text = "Contraseña:"
        '
        'lblRegTitulo
        '
        Me.lblRegTitulo.AutoSize = True
        Me.lblRegTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblRegTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblRegTitulo.Location = New System.Drawing.Point(262, 54)
        Me.lblRegTitulo.Name = "lblRegTitulo"
        Me.lblRegTitulo.Size = New System.Drawing.Size(296, 42)
        Me.lblRegTitulo.TabIndex = 7
        Me.lblRegTitulo.Text = "Registrar usuario"
        '
        'lblRegUsuario
        '
        Me.lblRegUsuario.AutoSize = True
        Me.lblRegUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblRegUsuario.Location = New System.Drawing.Point(234, 157)
        Me.lblRegUsuario.Name = "lblRegUsuario"
        Me.lblRegUsuario.Size = New System.Drawing.Size(80, 22)
        Me.lblRegUsuario.TabIndex = 7
        Me.lblRegUsuario.Text = "Usuario:"
        '
        'btnRegCrear
        '
        Me.btnRegCrear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnRegCrear.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegCrear.Location = New System.Drawing.Point(482, 312)
        Me.btnRegCrear.Name = "btnRegCrear"
        Me.btnRegCrear.Size = New System.Drawing.Size(101, 34)
        Me.btnRegCrear.TabIndex = 7
        Me.btnRegCrear.Text = "Crear"
        Me.btnRegCrear.UseVisualStyleBackColor = False
        '
        'pnlTraMenu
        '
        Me.pnlTraMenu.Controls.Add(Me.btnTraMenuAtras)
        Me.pnlTraMenu.Controls.Add(Me.btnTraAnadir)
        Me.pnlTraMenu.Controls.Add(Me.lblTraTitulo)
        Me.pnlTraMenu.Controls.Add(Me.btnTraBorrar)
        Me.pnlTraMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlTraMenu.Name = "pnlTraMenu"
        Me.pnlTraMenu.Size = New System.Drawing.Size(826, 453)
        Me.pnlTraMenu.TabIndex = 13
        '
        'btnTraMenuAtras
        '
        Me.btnTraMenuAtras.BackColor = System.Drawing.SystemColors.Menu
        Me.btnTraMenuAtras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraMenuAtras.Location = New System.Drawing.Point(52, 396)
        Me.btnTraMenuAtras.Name = "btnTraMenuAtras"
        Me.btnTraMenuAtras.Size = New System.Drawing.Size(101, 34)
        Me.btnTraMenuAtras.TabIndex = 12
        Me.btnTraMenuAtras.Text = "Atrás"
        Me.btnTraMenuAtras.UseVisualStyleBackColor = True
        '
        'btnTraAnadir
        '
        Me.btnTraAnadir.BackColor = System.Drawing.Color.LightGreen
        Me.btnTraAnadir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraAnadir.Location = New System.Drawing.Point(449, 168)
        Me.btnTraAnadir.Name = "btnTraAnadir"
        Me.btnTraAnadir.Size = New System.Drawing.Size(305, 143)
        Me.btnTraAnadir.TabIndex = 11
        Me.btnTraAnadir.Text = "Añadir Trabajador"
        Me.btnTraAnadir.UseVisualStyleBackColor = False
        '
        'lblTraTitulo
        '
        Me.lblTraTitulo.AutoSize = True
        Me.lblTraTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTraTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTraTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTraTitulo.Location = New System.Drawing.Point(230, 39)
        Me.lblTraTitulo.Name = "lblTraTitulo"
        Me.lblTraTitulo.Size = New System.Drawing.Size(387, 42)
        Me.lblTraTitulo.TabIndex = 7
        Me.lblTraTitulo.Text = "MENU TRABAJADORES"
        '
        'btnTraBorrar
        '
        Me.btnTraBorrar.BackColor = System.Drawing.Color.LightCoral
        Me.btnTraBorrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraBorrar.Location = New System.Drawing.Point(72, 168)
        Me.btnTraBorrar.Name = "btnTraBorrar"
        Me.btnTraBorrar.Size = New System.Drawing.Size(305, 143)
        Me.btnTraBorrar.TabIndex = 10
        Me.btnTraBorrar.Text = "Eliminar Trabajador"
        Me.btnTraBorrar.UseVisualStyleBackColor = False
        '
        'pnlTraEliminar
        '
        Me.pnlTraEliminar.Controls.Add(Me.ComboBox1)
        Me.pnlTraEliminar.Controls.Add(Me.Label1)
        Me.pnlTraEliminar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTraEliminar.Name = "pnlTraEliminar"
        Me.pnlTraEliminar.Size = New System.Drawing.Size(827, 455)
        Me.pnlTraEliminar.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(189, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(448, 30)
        Me.ComboBox1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(216, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ELIMINAR TRABAJADOR"
        '
        'FormTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlTraEliminar)
        Me.Controls.Add(Me.pnlTraMenu)
        Me.Controls.Add(Me.pnlRegistro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTrabajadores"
        Me.Text = "Goxo Denda App"
        Me.pnlRegistro.ResumeLayout(False)
        Me.pnlRegistro.PerformLayout()
        Me.pnlTraMenu.ResumeLayout(False)
        Me.pnlTraMenu.PerformLayout()
        Me.pnlTraEliminar.ResumeLayout(False)
        Me.pnlTraEliminar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRegistro As Panel
    Friend WithEvents txtRegDni As TextBox
    Friend WithEvents txtRegContrasena As TextBox
    Friend WithEvents txtRegUsuario As TextBox
    Friend WithEvents btnRegLimpiar As Button
    Friend WithEvents lblRegDni As Label
    Friend WithEvents lblRegContrasena As Label
    Friend WithEvents lblRegTitulo As Label
    Friend WithEvents lblRegUsuario As Label
    Friend WithEvents btnRegCrear As Button
    Friend WithEvents pnlTraMenu As Panel
    Friend WithEvents btnTraAnadir As Button
    Friend WithEvents lblTraTitulo As Label
    Friend WithEvents btnTraBorrar As Button
    Friend WithEvents pnlTraEliminar As Panel
    Friend WithEvents btnTraMenuAtras As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
