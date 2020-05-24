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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormArticulos))
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnPrincipalMenu = New System.Windows.Forms.Button()
        Me.btnVarios = New System.Windows.Forms.Button()
        Me.btnPatatas = New System.Windows.Forms.Button()
        Me.btnPan = New System.Windows.Forms.Button()
        Me.btnChuches = New System.Windows.Forms.Button()
        Me.pnlTPV = New System.Windows.Forms.Panel()
        Me.btnBolleria = New System.Windows.Forms.Button()
        Me.btnBebidas = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlPrincipal.Controls.Add(Me.btnFinalizar)
        Me.pnlPrincipal.Controls.Add(Me.btnPrincipalMenu)
        Me.pnlPrincipal.Controls.Add(Me.btnVarios)
        Me.pnlPrincipal.Controls.Add(Me.btnPatatas)
        Me.pnlPrincipal.Controls.Add(Me.btnPan)
        Me.pnlPrincipal.Controls.Add(Me.btnChuches)
        Me.pnlPrincipal.Controls.Add(Me.pnlTPV)
        Me.pnlPrincipal.Controls.Add(Me.btnBolleria)
        Me.pnlPrincipal.Controls.Add(Me.btnBebidas)
        Me.pnlPrincipal.Controls.Add(Me.txtTotal)
        Me.pnlPrincipal.Controls.Add(Me.lblTotal)
        Me.pnlPrincipal.Controls.Add(Me.lblTitulo)
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(827, 454)
        Me.pnlPrincipal.TabIndex = 9
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.Transparent
        Me.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFinalizar.Image = CType(resources.GetObject("btnFinalizar.Image"), System.Drawing.Image)
        Me.btnFinalizar.Location = New System.Drawing.Point(495, 398)
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
        Me.btnPan.BackColor = System.Drawing.Color.Lime
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
        Me.btnChuches.BackColor = System.Drawing.Color.Aqua
        Me.btnChuches.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChuches.Location = New System.Drawing.Point(4, 127)
        Me.btnChuches.Name = "btnChuches"
        Me.btnChuches.Size = New System.Drawing.Size(114, 29)
        Me.btnChuches.TabIndex = 6
        Me.btnChuches.Text = "CHUCHES"
        Me.btnChuches.UseVisualStyleBackColor = False
        '
        'pnlTPV
        '
        Me.pnlTPV.Location = New System.Drawing.Point(150, 58)
        Me.pnlTPV.Name = "pnlTPV"
        Me.pnlTPV.Size = New System.Drawing.Size(648, 330)
        Me.pnlTPV.TabIndex = 5
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
        Me.btnBebidas.BackColor = System.Drawing.Color.Red
        Me.btnBebidas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBebidas.Location = New System.Drawing.Point(5, 57)
        Me.btnBebidas.Name = "btnBebidas"
        Me.btnBebidas.Size = New System.Drawing.Size(114, 29)
        Me.btnBebidas.TabIndex = 3
        Me.btnBebidas.Text = "BEBIDAS"
        Me.btnBebidas.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.DimGray
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(712, 413)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(102, 24)
        Me.txtTotal.TabIndex = 2
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'FormArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 451)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Name = "FormArticulos"
        Me.Text = "Form2"
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnPrincipalMenu As Button
    Friend WithEvents btnVarios As Button
    Friend WithEvents btnPatatas As Button
    Friend WithEvents btnPan As Button
    Friend WithEvents btnChuches As Button
    Friend WithEvents pnlTPV As Panel
    Friend WithEvents btnBolleria As Button
    Friend WithEvents btnBebidas As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTitulo As Label
End Class
