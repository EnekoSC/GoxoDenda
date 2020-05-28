<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuArticulos))
        Me.pnlArtMenu = New System.Windows.Forms.Panel()
        Me.btnArtMenuAtras = New System.Windows.Forms.Button()
        Me.btnArtAnadir = New System.Windows.Forms.Button()
        Me.lblArtTitulo = New System.Windows.Forms.Label()
        Me.btnArtMod = New System.Windows.Forms.Button()
        Me.pnlModArticulos = New System.Windows.Forms.Panel()
        Me.btnModArtGuardar = New System.Windows.Forms.Button()
        Me.txtModArtPrecio = New System.Windows.Forms.TextBox()
        Me.txtModArtNombre = New System.Windows.Forms.TextBox()
        Me.txtModArtCategoria = New System.Windows.Forms.TextBox()
        Me.txtModArtId = New System.Windows.Forms.TextBox()
        Me.lblModArtPrecio = New System.Windows.Forms.Label()
        Me.lblModArtCategoria = New System.Windows.Forms.Label()
        Me.lblModArtId = New System.Windows.Forms.Label()
        Me.lblModArtNombre = New System.Windows.Forms.Label()
        Me.cmbModArt = New System.Windows.Forms.ComboBox()
        Me.btnModArtAtras = New System.Windows.Forms.Button()
        Me.lblModArtTitulo = New System.Windows.Forms.Label()
        Me.pnlNewArt = New System.Windows.Forms.Panel()
        Me.cmbNewArtCategoria = New System.Windows.Forms.ComboBox()
        Me.btnNewArtFin = New System.Windows.Forms.Button()
        Me.txtNewArtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNewArtNombre = New System.Windows.Forms.TextBox()
        Me.txtNewArtId = New System.Windows.Forms.TextBox()
        Me.lblNewArtPrecio = New System.Windows.Forms.Label()
        Me.lblNewArtCategoria = New System.Windows.Forms.Label()
        Me.lblNewArtId = New System.Windows.Forms.Label()
        Me.lvlNewArtNombre = New System.Windows.Forms.Label()
        Me.btnNewArtAtras = New System.Windows.Forms.Button()
        Me.lblNewArtTitulo = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.cmbModArtCategoria = New System.Windows.Forms.ComboBox()
        Me.lblNewEuro = New System.Windows.Forms.Label()
        Me.pnlArtMenu.SuspendLayout()
        Me.pnlModArticulos.SuspendLayout()
        Me.pnlNewArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlArtMenu
        '
        Me.pnlArtMenu.Controls.Add(Me.btnArtMenuAtras)
        Me.pnlArtMenu.Controls.Add(Me.btnArtAnadir)
        Me.pnlArtMenu.Controls.Add(Me.lblArtTitulo)
        Me.pnlArtMenu.Controls.Add(Me.btnArtMod)
        Me.pnlArtMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlArtMenu.Name = "pnlArtMenu"
        Me.pnlArtMenu.Size = New System.Drawing.Size(826, 453)
        Me.pnlArtMenu.TabIndex = 14
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
        'btnArtMod
        '
        Me.btnArtMod.BackColor = System.Drawing.Color.LightCoral
        Me.btnArtMod.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtMod.Location = New System.Drawing.Point(69, 168)
        Me.btnArtMod.Name = "btnArtMod"
        Me.btnArtMod.Size = New System.Drawing.Size(305, 143)
        Me.btnArtMod.TabIndex = 10
        Me.btnArtMod.Text = "Modificar Artículo"
        Me.btnArtMod.UseVisualStyleBackColor = False
        '
        'pnlModArticulos
        '
        Me.pnlModArticulos.Controls.Add(Me.cmbModArtCategoria)
        Me.pnlModArticulos.Controls.Add(Me.lblEuro)
        Me.pnlModArticulos.Controls.Add(Me.btnModArtGuardar)
        Me.pnlModArticulos.Controls.Add(Me.txtModArtPrecio)
        Me.pnlModArticulos.Controls.Add(Me.txtModArtNombre)
        Me.pnlModArticulos.Controls.Add(Me.txtModArtCategoria)
        Me.pnlModArticulos.Controls.Add(Me.txtModArtId)
        Me.pnlModArticulos.Controls.Add(Me.lblModArtPrecio)
        Me.pnlModArticulos.Controls.Add(Me.lblModArtCategoria)
        Me.pnlModArticulos.Controls.Add(Me.lblModArtId)
        Me.pnlModArticulos.Controls.Add(Me.lblModArtNombre)
        Me.pnlModArticulos.Controls.Add(Me.cmbModArt)
        Me.pnlModArticulos.Controls.Add(Me.btnModArtAtras)
        Me.pnlModArticulos.Controls.Add(Me.lblModArtTitulo)
        Me.pnlModArticulos.Location = New System.Drawing.Point(-1, -1)
        Me.pnlModArticulos.Name = "pnlModArticulos"
        Me.pnlModArticulos.Size = New System.Drawing.Size(826, 453)
        Me.pnlModArticulos.TabIndex = 15
        '
        'btnModArtGuardar
        '
        Me.btnModArtGuardar.BackColor = System.Drawing.SystemColors.Menu
        Me.btnModArtGuardar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModArtGuardar.Location = New System.Drawing.Point(668, 396)
        Me.btnModArtGuardar.Name = "btnModArtGuardar"
        Me.btnModArtGuardar.Size = New System.Drawing.Size(101, 34)
        Me.btnModArtGuardar.TabIndex = 22
        Me.btnModArtGuardar.Text = "Guardar"
        Me.btnModArtGuardar.UseVisualStyleBackColor = True
        '
        'txtModArtPrecio
        '
        Me.txtModArtPrecio.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModArtPrecio.Location = New System.Drawing.Point(608, 279)
        Me.txtModArtPrecio.Name = "txtModArtPrecio"
        Me.txtModArtPrecio.Size = New System.Drawing.Size(69, 31)
        Me.txtModArtPrecio.TabIndex = 21
        Me.txtModArtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtModArtNombre
        '
        Me.txtModArtNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModArtNombre.Location = New System.Drawing.Point(239, 215)
        Me.txtModArtNombre.Name = "txtModArtNombre"
        Me.txtModArtNombre.Size = New System.Drawing.Size(438, 31)
        Me.txtModArtNombre.TabIndex = 20
        '
        'txtModArtCategoria
        '
        Me.txtModArtCategoria.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModArtCategoria.Location = New System.Drawing.Point(437, 279)
        Me.txtModArtCategoria.Name = "txtModArtCategoria"
        Me.txtModArtCategoria.Size = New System.Drawing.Size(59, 31)
        Me.txtModArtCategoria.TabIndex = 19
        '
        'txtModArtId
        '
        Me.txtModArtId.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModArtId.Location = New System.Drawing.Point(188, 279)
        Me.txtModArtId.MaxLength = 6
        Me.txtModArtId.Name = "txtModArtId"
        Me.txtModArtId.Size = New System.Drawing.Size(92, 31)
        Me.txtModArtId.TabIndex = 18
        '
        'lblModArtPrecio
        '
        Me.lblModArtPrecio.AutoSize = True
        Me.lblModArtPrecio.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModArtPrecio.Location = New System.Drawing.Point(511, 282)
        Me.lblModArtPrecio.Name = "lblModArtPrecio"
        Me.lblModArtPrecio.Size = New System.Drawing.Size(71, 22)
        Me.lblModArtPrecio.TabIndex = 17
        Me.lblModArtPrecio.Text = "Precio:"
        '
        'lblModArtCategoria
        '
        Me.lblModArtCategoria.AutoSize = True
        Me.lblModArtCategoria.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModArtCategoria.Location = New System.Drawing.Point(312, 282)
        Me.lblModArtCategoria.Name = "lblModArtCategoria"
        Me.lblModArtCategoria.Size = New System.Drawing.Size(109, 22)
        Me.lblModArtCategoria.TabIndex = 16
        Me.lblModArtCategoria.Text = "Categoría:"
        '
        'lblModArtId
        '
        Me.lblModArtId.AutoSize = True
        Me.lblModArtId.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModArtId.Location = New System.Drawing.Point(136, 282)
        Me.lblModArtId.Name = "lblModArtId"
        Me.lblModArtId.Size = New System.Drawing.Size(34, 22)
        Me.lblModArtId.TabIndex = 15
        Me.lblModArtId.Text = "ID:"
        '
        'lblModArtNombre
        '
        Me.lblModArtNombre.AutoSize = True
        Me.lblModArtNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModArtNombre.Location = New System.Drawing.Point(136, 218)
        Me.lblModArtNombre.Name = "lblModArtNombre"
        Me.lblModArtNombre.Size = New System.Drawing.Size(89, 22)
        Me.lblModArtNombre.TabIndex = 14
        Me.lblModArtNombre.Text = "Nombre:"
        '
        'cmbModArt
        '
        Me.cmbModArt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModArt.FormattingEnabled = True
        Me.cmbModArt.Location = New System.Drawing.Point(230, 133)
        Me.cmbModArt.Name = "cmbModArt"
        Me.cmbModArt.Size = New System.Drawing.Size(376, 30)
        Me.cmbModArt.TabIndex = 13
        '
        'btnModArtAtras
        '
        Me.btnModArtAtras.BackColor = System.Drawing.SystemColors.Menu
        Me.btnModArtAtras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModArtAtras.Location = New System.Drawing.Point(52, 396)
        Me.btnModArtAtras.Name = "btnModArtAtras"
        Me.btnModArtAtras.Size = New System.Drawing.Size(101, 34)
        Me.btnModArtAtras.TabIndex = 12
        Me.btnModArtAtras.Text = "Atrás"
        Me.btnModArtAtras.UseVisualStyleBackColor = True
        '
        'lblModArtTitulo
        '
        Me.lblModArtTitulo.AutoSize = True
        Me.lblModArtTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblModArtTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModArtTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblModArtTitulo.Location = New System.Drawing.Point(223, 35)
        Me.lblModArtTitulo.Name = "lblModArtTitulo"
        Me.lblModArtTitulo.Size = New System.Drawing.Size(387, 42)
        Me.lblModArtTitulo.TabIndex = 7
        Me.lblModArtTitulo.Text = "MODIFICAR ARTÍCULO"
        '
        'pnlNewArt
        '
        Me.pnlNewArt.Controls.Add(Me.lblNewEuro)
        Me.pnlNewArt.Controls.Add(Me.cmbNewArtCategoria)
        Me.pnlNewArt.Controls.Add(Me.btnNewArtFin)
        Me.pnlNewArt.Controls.Add(Me.txtNewArtPrecio)
        Me.pnlNewArt.Controls.Add(Me.txtNewArtNombre)
        Me.pnlNewArt.Controls.Add(Me.txtNewArtId)
        Me.pnlNewArt.Controls.Add(Me.lblNewArtPrecio)
        Me.pnlNewArt.Controls.Add(Me.lblNewArtCategoria)
        Me.pnlNewArt.Controls.Add(Me.lblNewArtId)
        Me.pnlNewArt.Controls.Add(Me.lvlNewArtNombre)
        Me.pnlNewArt.Controls.Add(Me.btnNewArtAtras)
        Me.pnlNewArt.Controls.Add(Me.lblNewArtTitulo)
        Me.pnlNewArt.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNewArt.Location = New System.Drawing.Point(0, 0)
        Me.pnlNewArt.Name = "pnlNewArt"
        Me.pnlNewArt.Size = New System.Drawing.Size(826, 453)
        Me.pnlNewArt.TabIndex = 16
        '
        'cmbNewArtCategoria
        '
        Me.cmbNewArtCategoria.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewArtCategoria.FormattingEnabled = True
        Me.cmbNewArtCategoria.Location = New System.Drawing.Point(475, 226)
        Me.cmbNewArtCategoria.Name = "cmbNewArtCategoria"
        Me.cmbNewArtCategoria.Size = New System.Drawing.Size(201, 30)
        Me.cmbNewArtCategoria.TabIndex = 23
        '
        'btnNewArtFin
        '
        Me.btnNewArtFin.BackColor = System.Drawing.SystemColors.Menu
        Me.btnNewArtFin.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewArtFin.Location = New System.Drawing.Point(668, 396)
        Me.btnNewArtFin.Name = "btnNewArtFin"
        Me.btnNewArtFin.Size = New System.Drawing.Size(101, 34)
        Me.btnNewArtFin.TabIndex = 22
        Me.btnNewArtFin.Text = "Finalizar"
        Me.btnNewArtFin.UseVisualStyleBackColor = True
        '
        'txtNewArtPrecio
        '
        Me.txtNewArtPrecio.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewArtPrecio.Location = New System.Drawing.Point(409, 281)
        Me.txtNewArtPrecio.Name = "txtNewArtPrecio"
        Me.txtNewArtPrecio.Size = New System.Drawing.Size(69, 31)
        Me.txtNewArtPrecio.TabIndex = 21
        Me.txtNewArtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNewArtNombre
        '
        Me.txtNewArtNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewArtNombre.Location = New System.Drawing.Point(239, 168)
        Me.txtNewArtNombre.Name = "txtNewArtNombre"
        Me.txtNewArtNombre.Size = New System.Drawing.Size(438, 31)
        Me.txtNewArtNombre.TabIndex = 20
        '
        'txtNewArtId
        '
        Me.txtNewArtId.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewArtId.Location = New System.Drawing.Point(187, 225)
        Me.txtNewArtId.Name = "txtNewArtId"
        Me.txtNewArtId.Size = New System.Drawing.Size(108, 31)
        Me.txtNewArtId.TabIndex = 18
        '
        'lblNewArtPrecio
        '
        Me.lblNewArtPrecio.AutoSize = True
        Me.lblNewArtPrecio.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewArtPrecio.Location = New System.Drawing.Point(332, 284)
        Me.lblNewArtPrecio.Name = "lblNewArtPrecio"
        Me.lblNewArtPrecio.Size = New System.Drawing.Size(71, 22)
        Me.lblNewArtPrecio.TabIndex = 17
        Me.lblNewArtPrecio.Text = "Precio:"
        '
        'lblNewArtCategoria
        '
        Me.lblNewArtCategoria.AutoSize = True
        Me.lblNewArtCategoria.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewArtCategoria.Location = New System.Drawing.Point(350, 228)
        Me.lblNewArtCategoria.Name = "lblNewArtCategoria"
        Me.lblNewArtCategoria.Size = New System.Drawing.Size(109, 22)
        Me.lblNewArtCategoria.TabIndex = 16
        Me.lblNewArtCategoria.Text = "Categoría:"
        '
        'lblNewArtId
        '
        Me.lblNewArtId.AutoSize = True
        Me.lblNewArtId.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewArtId.Location = New System.Drawing.Point(138, 228)
        Me.lblNewArtId.Name = "lblNewArtId"
        Me.lblNewArtId.Size = New System.Drawing.Size(34, 22)
        Me.lblNewArtId.TabIndex = 15
        Me.lblNewArtId.Text = "ID:"
        '
        'lvlNewArtNombre
        '
        Me.lvlNewArtNombre.AutoSize = True
        Me.lvlNewArtNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlNewArtNombre.Location = New System.Drawing.Point(136, 171)
        Me.lvlNewArtNombre.Name = "lvlNewArtNombre"
        Me.lvlNewArtNombre.Size = New System.Drawing.Size(89, 22)
        Me.lvlNewArtNombre.TabIndex = 14
        Me.lvlNewArtNombre.Text = "Nombre:"
        '
        'btnNewArtAtras
        '
        Me.btnNewArtAtras.BackColor = System.Drawing.SystemColors.Menu
        Me.btnNewArtAtras.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewArtAtras.Location = New System.Drawing.Point(52, 396)
        Me.btnNewArtAtras.Name = "btnNewArtAtras"
        Me.btnNewArtAtras.Size = New System.Drawing.Size(101, 34)
        Me.btnNewArtAtras.TabIndex = 12
        Me.btnNewArtAtras.Text = "Atrás"
        Me.btnNewArtAtras.UseVisualStyleBackColor = True
        '
        'lblNewArtTitulo
        '
        Me.lblNewArtTitulo.AutoSize = True
        Me.lblNewArtTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblNewArtTitulo.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewArtTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblNewArtTitulo.Location = New System.Drawing.Point(256, 34)
        Me.lblNewArtTitulo.Name = "lblNewArtTitulo"
        Me.lblNewArtTitulo.Size = New System.Drawing.Size(324, 42)
        Me.lblNewArtTitulo.TabIndex = 7
        Me.lblNewArtTitulo.Text = "AÑADIR ARTÍCULO"
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuro.Location = New System.Drawing.Point(676, 282)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(21, 22)
        Me.lblEuro.TabIndex = 23
        Me.lblEuro.Text = "€"
        '
        'cmbModArtCategoria
        '
        Me.cmbModArtCategoria.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModArtCategoria.FormattingEnabled = True
        Me.cmbModArtCategoria.Location = New System.Drawing.Point(316, 341)
        Me.cmbModArtCategoria.Name = "cmbModArtCategoria"
        Me.cmbModArtCategoria.Size = New System.Drawing.Size(201, 30)
        Me.cmbModArtCategoria.TabIndex = 24
        '
        'lblNewEuro
        '
        Me.lblNewEuro.AutoSize = True
        Me.lblNewEuro.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewEuro.Location = New System.Drawing.Point(477, 284)
        Me.lblNewEuro.Name = "lblNewEuro"
        Me.lblNewEuro.Size = New System.Drawing.Size(21, 22)
        Me.lblNewEuro.TabIndex = 24
        Me.lblNewEuro.Text = "€"
        '
        'FormMenuArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlArtMenu)
        Me.Controls.Add(Me.pnlNewArt)
        Me.Controls.Add(Me.pnlModArticulos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMenuArticulos"
        Me.Text = "Goxo Denda App"
        Me.pnlArtMenu.ResumeLayout(False)
        Me.pnlArtMenu.PerformLayout()
        Me.pnlModArticulos.ResumeLayout(False)
        Me.pnlModArticulos.PerformLayout()
        Me.pnlNewArt.ResumeLayout(False)
        Me.pnlNewArt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlArtMenu As Panel
    Friend WithEvents btnArtMenuAtras As Button
    Friend WithEvents btnArtAnadir As Button
    Friend WithEvents lblArtTitulo As Label
    Friend WithEvents btnArtMod As Button
    Friend WithEvents pnlModArticulos As Panel
    Friend WithEvents btnModArtAtras As Button
    Friend WithEvents lblModArtTitulo As Label
    Friend WithEvents cmbModArt As ComboBox
    Friend WithEvents lblModArtCategoria As Label
    Friend WithEvents lblModArtId As Label
    Friend WithEvents lblModArtNombre As Label
    Friend WithEvents btnModArtGuardar As Button
    Friend WithEvents txtModArtPrecio As TextBox
    Friend WithEvents txtModArtNombre As TextBox
    Friend WithEvents txtModArtCategoria As TextBox
    Friend WithEvents txtModArtId As TextBox
    Friend WithEvents lblModArtPrecio As Label
    Friend WithEvents pnlNewArt As Panel
    Friend WithEvents cmbNewArtCategoria As ComboBox
    Friend WithEvents btnNewArtFin As Button
    Friend WithEvents txtNewArtPrecio As TextBox
    Friend WithEvents txtNewArtNombre As TextBox
    Friend WithEvents txtNewArtId As TextBox
    Friend WithEvents lblNewArtPrecio As Label
    Friend WithEvents lblNewArtCategoria As Label
    Friend WithEvents lblNewArtId As Label
    Friend WithEvents lvlNewArtNombre As Label
    Friend WithEvents btnNewArtAtras As Button
    Friend WithEvents lblNewArtTitulo As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents cmbModArtCategoria As ComboBox
    Friend WithEvents lblNewEuro As Label
End Class
