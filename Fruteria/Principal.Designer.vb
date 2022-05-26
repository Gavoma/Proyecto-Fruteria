<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim FoliouLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim ClaveLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOVENTADataSet = New Fruteria.PROYECTOVENTADataSet()
        Me.cbFiltrar = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.USUARIOTableAdapter = New Fruteria.PROYECTOVENTADataSetTableAdapters.USUARIOTableAdapter()
        Me.TableAdapterManager = New Fruteria.PROYECTOVENTADataSetTableAdapters.TableAdapterManager()
        Me.USUARIODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FoliouTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.ClaveTextBox = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnCancelar = New System.Windows.Forms.Button()
        FoliouLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        ClaveLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOVENTADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.USUARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FoliouLabel
        '
        FoliouLabel.AutoSize = True
        FoliouLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FoliouLabel.Location = New System.Drawing.Point(23, 140)
        FoliouLabel.Name = "FoliouLabel"
        FoliouLabel.Size = New System.Drawing.Size(137, 26)
        FoliouLabel.TabIndex = 24
        FoliouLabel.Text = "Folio Usuario:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(67, 195)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(93, 26)
        NombreLabel.TabIndex = 26
        NombreLabel.Text = "Nombre:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.Location = New System.Drawing.Point(73, 257)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(87, 26)
        UsuarioLabel.TabIndex = 28
        UsuarioLabel.Text = "Usuario:"
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClaveLabel.Location = New System.Drawing.Point(457, 140)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(67, 26)
        ClaveLabel.TabIndex = 30
        ClaveLabel.Text = "Clave:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(467, 200)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(57, 26)
        TipoLabel.TabIndex = 32
        TipoLabel.Text = "Tipo:"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(846, 236)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 34)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(846, 166)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(102, 34)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "GUARDAR"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'USUARIOBindingSource
        '
        Me.USUARIOBindingSource.DataMember = "USUARIO"
        Me.USUARIOBindingSource.DataSource = Me.PROYECTOVENTADataSet
        '
        'PROYECTOVENTADataSet
        '
        Me.PROYECTOVENTADataSet.DataSetName = "PROYECTOVENTADataSet"
        Me.PROYECTOVENTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbFiltrar
        '
        Me.cbFiltrar.FormattingEnabled = True
        Me.cbFiltrar.Items.AddRange(New Object() {"Usuario", "Código", "Rol"})
        Me.cbFiltrar.Location = New System.Drawing.Point(454, 69)
        Me.cbFiltrar.Name = "cbFiltrar"
        Me.cbFiltrar.Size = New System.Drawing.Size(139, 21)
        Me.cbFiltrar.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(371, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 16)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Filtrar por:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(660, 70)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(205, 22)
        Me.txtBuscar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(599, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTA DE USUARIOS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 47)
        Me.Panel1.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(388, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 35)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "USUARIOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 29)
        Me.Label9.TabIndex = 6
        '
        'USUARIOTableAdapter
        '
        Me.USUARIOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BITACORATableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fruteria.PROYECTOVENTADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Me.USUARIOTableAdapter
        Me.TableAdapterManager.VENTASHECHASTableAdapter = Nothing
        Me.TableAdapterManager.VENTASREGISTRADASTableAdapter = Nothing
        '
        'USUARIODataGridView
        '
        Me.USUARIODataGridView.AllowUserToAddRows = False
        Me.USUARIODataGridView.AllowUserToDeleteRows = False
        Me.USUARIODataGridView.AutoGenerateColumns = False
        Me.USUARIODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.USUARIODataGridView.BackgroundColor = System.Drawing.Color.Beige
        Me.USUARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.USUARIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.USUARIODataGridView.DataSource = Me.USUARIOBindingSource
        Me.USUARIODataGridView.Location = New System.Drawing.Point(12, 327)
        Me.USUARIODataGridView.Name = "USUARIODataGridView"
        Me.USUARIODataGridView.Size = New System.Drawing.Size(936, 296)
        Me.USUARIODataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "foliou"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "clave"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contraseña"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo de usuario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ADMINISTRADOR", "EMPLEADO"})
        Me.ComboBox1.Location = New System.Drawing.Point(530, 199)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(205, 31)
        Me.ComboBox1.TabIndex = 33
        '
        'FoliouTextBox
        '
        Me.FoliouTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "foliou", True))
        Me.FoliouTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoliouTextBox.Location = New System.Drawing.Point(166, 137)
        Me.FoliouTextBox.Name = "FoliouTextBox"
        Me.FoliouTextBox.Size = New System.Drawing.Size(205, 32)
        Me.FoliouTextBox.TabIndex = 25
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(166, 194)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(205, 32)
        Me.NombreTextBox.TabIndex = 27
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(166, 251)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(205, 32)
        Me.UsuarioTextBox.TabIndex = 29
        '
        'ClaveTextBox
        '
        Me.ClaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.USUARIOBindingSource, "clave", True))
        Me.ClaveTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClaveTextBox.Location = New System.Drawing.Point(530, 139)
        Me.ClaveTextBox.Name = "ClaveTextBox"
        Me.ClaveTextBox.Size = New System.Drawing.Size(205, 32)
        Me.ClaveTextBox.TabIndex = 31
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(846, 126)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(102, 34)
        Me.btnNuevo.TabIndex = 34
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Fruteria.My.Resources.Resources.lupas
        Me.PictureBox3.Location = New System.Drawing.Point(871, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "foliou"
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Fruteria.My.Resources.Resources.lapiz
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(846, 276)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 34)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 643)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(FoliouLabel)
        Me.Controls.Add(Me.FoliouTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(ClaveLabel)
        Me.Controls.Add(Me.ClaveTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.USUARIODataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFiltrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Text = "Principal"
        CType(Me.USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOVENTADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.USUARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cbFiltrar As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PROYECTOVENTADataSet As PROYECTOVENTADataSet
    Friend WithEvents USUARIOBindingSource As BindingSource
    Friend WithEvents USUARIOTableAdapter As PROYECTOVENTADataSetTableAdapters.USUARIOTableAdapter
    Friend WithEvents TableAdapterManager As PROYECTOVENTADataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents USUARIODataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents FoliouTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents ClaveTextBox As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
End Class
