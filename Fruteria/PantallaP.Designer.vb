<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaP
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.PanelSubMenu = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BotonMenu = New System.Windows.Forms.Button()
        Me.Horafecha = New System.Windows.Forms.Timer(Me.components)
        Me.OcultarM = New System.Windows.Forms.Timer(Me.components)
        Me.MostrarM = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCierreVenta = New FontAwesome.Sharp.IconButton()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.btnAlmacen = New FontAwesome.Sharp.IconButton()
        Me.btnVenta = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelLateral.SuspendLayout()
        Me.PanelSubMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.CadetBlue
        Me.PanelLateral.Controls.Add(Me.PanelSubMenu)
        Me.PanelLateral.Controls.Add(Me.BotonMenu)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelLateral.Location = New System.Drawing.Point(960, 0)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(120, 689)
        Me.PanelLateral.TabIndex = 0
        '
        'PanelSubMenu
        '
        Me.PanelSubMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelSubMenu.Controls.Add(Me.Button4)
        Me.PanelSubMenu.Controls.Add(Me.Button3)
        Me.PanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenu.Location = New System.Drawing.Point(0, 57)
        Me.PanelSubMenu.Name = "PanelSubMenu"
        Me.PanelSubMenu.Size = New System.Drawing.Size(120, 100)
        Me.PanelSubMenu.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 41)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "CERRAR SESION"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 41)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BotonMenu
        '
        Me.BotonMenu.BackColor = System.Drawing.Color.Tan
        Me.BotonMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonMenu.FlatAppearance.BorderSize = 0
        Me.BotonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonMenu.Location = New System.Drawing.Point(0, 0)
        Me.BotonMenu.Name = "BotonMenu"
        Me.BotonMenu.Size = New System.Drawing.Size(120, 57)
        Me.BotonMenu.TabIndex = 0
        Me.BotonMenu.Text = "MENU"
        Me.BotonMenu.UseVisualStyleBackColor = False
        '
        'Horafecha
        '
        Me.Horafecha.Enabled = True
        '
        'OcultarM
        '
        Me.OcultarM.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.IconPictureBox2)
        Me.Panel2.Controls.Add(Me.Fecha)
        Me.Panel2.Controls.Add(Me.Hora)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(960, 57)
        Me.Panel2.TabIndex = 4
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.IconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket
        Me.IconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 57
        Me.IconPictureBox2.Location = New System.Drawing.Point(22, 0)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(57, 57)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.IconPictureBox2.TabIndex = 2
        Me.IconPictureBox2.TabStop = False
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(626, 34)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(51, 17)
        Me.Fecha.TabIndex = 1
        Me.Fecha.Text = "Label1"
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.Location = New System.Drawing.Point(679, 8)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(51, 17)
        Me.Hora.TabIndex = 0
        Me.Hora.Text = "Label1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Tan
        Me.Panel3.Controls.Add(Me.btnCierreVenta)
        Me.Panel3.Controls.Add(Me.btnUsuarios)
        Me.Panel3.Controls.Add(Me.btnAlmacen)
        Me.Panel3.Controls.Add(Me.btnVenta)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(960, 38)
        Me.Panel3.TabIndex = 5
        '
        'btnCierreVenta
        '
        Me.btnCierreVenta.Font = New System.Drawing.Font("Leelawadee UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCierreVenta.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnCierreVenta.IconColor = System.Drawing.Color.Black
        Me.btnCierreVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCierreVenta.IconSize = 30
        Me.btnCierreVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCierreVenta.Location = New System.Drawing.Point(353, 1)
        Me.btnCierreVenta.Name = "btnCierreVenta"
        Me.btnCierreVenta.Size = New System.Drawing.Size(117, 37)
        Me.btnCierreVenta.TabIndex = 7
        Me.btnCierreVenta.Text = "    CIERRE VENTA"
        Me.btnCierreVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCierreVenta.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnUsuarios.IconColor = System.Drawing.Color.Black
        Me.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsuarios.IconSize = 26
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(243, 1)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(112, 37)
        Me.btnUsuarios.TabIndex = 6
        Me.btnUsuarios.Text = "    USUARIOS"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnAlmacen
        '
        Me.btnAlmacen.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlmacen.IconChar = FontAwesome.Sharp.IconChar.Box
        Me.btnAlmacen.IconColor = System.Drawing.Color.Black
        Me.btnAlmacen.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAlmacen.IconSize = 30
        Me.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlmacen.Location = New System.Drawing.Point(133, 1)
        Me.btnAlmacen.Name = "btnAlmacen"
        Me.btnAlmacen.Size = New System.Drawing.Size(112, 37)
        Me.btnAlmacen.TabIndex = 5
        Me.btnAlmacen.Text = "      ALMACEN"
        Me.btnAlmacen.UseVisualStyleBackColor = True
        '
        'btnVenta
        '
        Me.btnVenta.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.btnVenta.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenta.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.btnVenta.IconColor = System.Drawing.Color.Black
        Me.btnVenta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVenta.IconSize = 32
        Me.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.Location = New System.Drawing.Point(22, 1)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(112, 37)
        Me.btnVenta.TabIndex = 4
        Me.btnVenta.Text = "VENTA"
        Me.btnVenta.UseMnemonic = False
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 594)
        Me.Panel1.TabIndex = 6
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.YellowGreen
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag
        Me.IconPictureBox1.IconColor = System.Drawing.Color.YellowGreen
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 192
        Me.IconPictureBox1.Location = New System.Drawing.Point(353, 180)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(207, 192)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'PantallaP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 689)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelLateral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaP"
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelSubMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLateral As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCierreVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAlmacen As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVenta As FontAwesome.Sharp.IconButton
    Friend WithEvents Horafecha As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OcultarM As Timer
    Friend WithEvents MostrarM As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelSubMenu As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BotonMenu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Fecha As Label
    Friend WithEvents Hora As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
End Class
