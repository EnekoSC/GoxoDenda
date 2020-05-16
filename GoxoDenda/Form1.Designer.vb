<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLoginAñadir = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.pnlRegistro = New System.Windows.Forms.Panel()
        Me.txtRegDni = New System.Windows.Forms.TextBox()
        Me.txtRegContrasena = New System.Windows.Forms.TextBox()
        Me.txtRegUsuario = New System.Windows.Forms.TextBox()
        Me.btnRegLimpiar = New System.Windows.Forms.Button()
        Me.lblRegDni = New System.Windows.Forms.Label()
        Me.lblRegContrasena = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRegUsuario = New System.Windows.Forms.Label()
        Me.btnRegCrear = New System.Windows.Forms.Button()
        Me.ArticulosTableAdapter1 = New GoxoDenda.GoxoDendaDataSetTableAdapters.ARTICULOSTableAdapter()
        Me.pnlLogin.SuspendLayout()
        Me.pnlRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlLogin.Controls.Add(Me.btnLoginAñadir)
        Me.pnlLogin.Controls.Add(Me.btnEntrar)
        Me.pnlLogin.Controls.Add(Me.btnLimpiar)
        Me.pnlLogin.Controls.Add(Me.txtContrasena)
        Me.pnlLogin.Controls.Add(Me.txtUsuario)
        Me.pnlLogin.Controls.Add(Me.lblContrasena)
        Me.pnlLogin.Controls.Add(Me.lblUsuario)
        Me.pnlLogin.Controls.Add(Me.lblLogin)
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(827, 454)
        Me.pnlLogin.TabIndex = 0
        '
        'btnLoginAñadir
        '
        Me.btnLoginAñadir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginAñadir.Location = New System.Drawing.Point(358, 332)
        Me.btnLoginAñadir.Name = "btnLoginAñadir"
        Me.btnLoginAñadir.Size = New System.Drawing.Size(101, 34)
        Me.btnLoginAñadir.TabIndex = 7
        Me.btnLoginAñadir.Text = "Añadir"
        Me.btnLoginAñadir.UseVisualStyleBackColor = True
        '
        'btnEntrar
        '
        Me.btnEntrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.Location = New System.Drawing.Point(485, 332)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(101, 34)
        Me.btnEntrar.TabIndex = 6
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(225, 332)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(101, 34)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(405, 222)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(171, 27)
        Me.txtContrasena.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(405, 160)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(171, 27)
        Me.txtUsuario.TabIndex = 3
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.Black
        Me.lblContrasena.Location = New System.Drawing.Point(212, 222)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(124, 22)
        Me.lblContrasena.TabIndex = 2
        Me.lblContrasena.Text = "Contraseña:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblUsuario.Location = New System.Drawing.Point(256, 162)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(80, 22)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Black
        Me.lblLogin.Location = New System.Drawing.Point(200, 57)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(432, 42)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Ingresa tus credenciales"
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
        Me.pnlRegistro.Controls.Add(Me.Label1)
        Me.pnlRegistro.Controls.Add(Me.lblRegUsuario)
        Me.pnlRegistro.Controls.Add(Me.btnRegCrear)
        Me.pnlRegistro.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegistro.Name = "pnlRegistro"
        Me.pnlRegistro.Size = New System.Drawing.Size(827, 454)
        Me.pnlRegistro.TabIndex = 7
        '
        'txtRegDni
        '
        Me.txtRegDni.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegDni.Location = New System.Drawing.Point(377, 239)
        Me.txtRegDni.Name = "txtRegDni"
        Me.txtRegDni.Size = New System.Drawing.Size(209, 27)
        Me.txtRegDni.TabIndex = 12
        '
        'txtRegContrasena
        '
        Me.txtRegContrasena.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegContrasena.Location = New System.Drawing.Point(377, 198)
        Me.txtRegContrasena.Name = "txtRegContrasena"
        Me.txtRegContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegContrasena.Size = New System.Drawing.Size(209, 27)
        Me.txtRegContrasena.TabIndex = 11
        '
        'txtRegUsuario
        '
        Me.txtRegUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegUsuario.Location = New System.Drawing.Point(377, 160)
        Me.txtRegUsuario.Name = "txtRegUsuario"
        Me.txtRegUsuario.Size = New System.Drawing.Size(209, 27)
        Me.txtRegUsuario.TabIndex = 7
        '
        'btnRegLimpiar
        '
        Me.btnRegLimpiar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnRegLimpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegLimpiar.Location = New System.Drawing.Point(241, 315)
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
        Me.lblRegDni.Location = New System.Drawing.Point(237, 244)
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
        Me.lblRegContrasena.Location = New System.Drawing.Point(237, 200)
        Me.lblRegContrasena.Name = "lblRegContrasena"
        Me.lblRegContrasena.Size = New System.Drawing.Size(124, 22)
        Me.lblRegContrasena.TabIndex = 8
        Me.lblRegContrasena.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(265, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Registrar usuario"
        '
        'lblRegUsuario
        '
        Me.lblRegUsuario.AutoSize = True
        Me.lblRegUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegUsuario.ForeColor = System.Drawing.Color.Black
        Me.lblRegUsuario.Location = New System.Drawing.Point(237, 160)
        Me.lblRegUsuario.Name = "lblRegUsuario"
        Me.lblRegUsuario.Size = New System.Drawing.Size(80, 22)
        Me.lblRegUsuario.TabIndex = 7
        Me.lblRegUsuario.Text = "Usuario:"
        '
        'btnRegCrear
        '
        Me.btnRegCrear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnRegCrear.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegCrear.Location = New System.Drawing.Point(485, 315)
        Me.btnRegCrear.Name = "btnRegCrear"
        Me.btnRegCrear.Size = New System.Drawing.Size(101, 34)
        Me.btnRegCrear.TabIndex = 7
        Me.btnRegCrear.Text = "Crear"
        Me.btnRegCrear.UseVisualStyleBackColor = False
        '
        'ArticulosTableAdapter1
        '
        Me.ArticulosTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlRegistro)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Goxo Denda App"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlRegistro.ResumeLayout(False)
        Me.pnlRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents pnlRegistro As Panel
    Friend WithEvents lblRegContrasena As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRegUsuario As Label
    Friend WithEvents btnRegCrear As Button
    Friend WithEvents lblRegDni As Label
    Friend WithEvents btnRegLimpiar As Button
    Friend WithEvents txtRegDni As TextBox
    Friend WithEvents txtRegContrasena As TextBox
    Friend WithEvents txtRegUsuario As TextBox
    Friend WithEvents ArticulosTableAdapter1 As GoxoDendaDataSetTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents btnLoginAñadir As Button
End Class
