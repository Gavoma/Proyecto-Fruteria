<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Dim CodproLabel As System.Windows.Forms.Label
        Dim NomproLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim ExistenciaLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOVENTADataSet = New Fruteria.PROYECTOVENTADataSet()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.PRODUCTOSTableAdapter = New Fruteria.PROYECTOVENTADataSetTableAdapters.PRODUCTOSTableAdapter()
        Me.TableAdapterManager = New Fruteria.PROYECTOVENTADataSetTableAdapters.TableAdapterManager()
        Me.PRODUCTOSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CodproTextBox = New System.Windows.Forms.TextBox()
        Me.NomproTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ExistenciaTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CodproLabel = New System.Windows.Forms.Label()
        NomproLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        ExistenciaLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOVENTADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodproLabel
        '
        CodproLabel.AutoSize = True
        CodproLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodproLabel.Location = New System.Drawing.Point(33, 133)
        CodproLabel.Name = "CodproLabel"
        CodproLabel.Size = New System.Drawing.Size(75, 23)
        CodproLabel.TabIndex = 26
        CodproLabel.Text = "Código:"
        '
        'NomproLabel
        '
        NomproLabel.AutoSize = True
        NomproLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomproLabel.Location = New System.Drawing.Point(17, 190)
        NomproLabel.Name = "NomproLabel"
        NomproLabel.Size = New System.Drawing.Size(91, 23)
        NomproLabel.TabIndex = 28
        NomproLabel.Text = "Producto:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.Location = New System.Drawing.Point(41, 250)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(67, 23)
        PrecioLabel.TabIndex = 30
        PrecioLabel.Text = "Precio:"
        '
        'ExistenciaLabel
        '
        ExistenciaLabel.AutoSize = True
        ExistenciaLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExistenciaLabel.Location = New System.Drawing.Point(449, 133)
        ExistenciaLabel.Name = "ExistenciaLabel"
        ExistenciaLabel.Size = New System.Drawing.Size(97, 23)
        ExistenciaLabel.TabIndex = 32
        ExistenciaLabel.Text = "Existencia:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(450, 190)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(96, 23)
        CategoriaLabel.TabIndex = 34
        CategoriaLabel.Text = "Categoria:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(433, 253)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(113, 23)
        DescripcionLabel.TabIndex = 36
        DescripcionLabel.Text = "Descripción:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 47)
        Me.Panel1.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Berlin Sans FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(388, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 35)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "ALMACEN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 29)
        Me.Label20.TabIndex = 6
        '
        'PRODUCTOSBindingSource
        '
        Me.PRODUCTOSBindingSource.DataMember = "PRODUCTOS"
        Me.PRODUCTOSBindingSource.DataSource = Me.PROYECTOVENTADataSet
        '
        'PROYECTOVENTADataSet
        '
        Me.PROYECTOVENTADataSet.DataSetName = "PROYECTOVENTADataSet"
        Me.PROYECTOVENTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(666, 66)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(203, 22)
        Me.TextBox9.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(434, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Filtrar por:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Categoria", "Precio", "Codigo"})
        Me.ComboBox3.Location = New System.Drawing.Point(515, 66)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox3.TabIndex = 1
        '
        'PRODUCTOSTableAdapter
        '
        Me.PRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BITACORATableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Me.PRODUCTOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = Fruteria.PROYECTOVENTADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USUARIOTableAdapter = Nothing
        Me.TableAdapterManager.VENTASHECHASTableAdapter = Nothing
        Me.TableAdapterManager.VENTASREGISTRADASTableAdapter = Nothing
        '
        'PRODUCTOSDataGridView
        '
        Me.PRODUCTOSDataGridView.AllowUserToAddRows = False
        Me.PRODUCTOSDataGridView.AllowUserToDeleteRows = False
        Me.PRODUCTOSDataGridView.AutoGenerateColumns = False
        Me.PRODUCTOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PRODUCTOSDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PRODUCTOSDataGridView.BackgroundColor = System.Drawing.Color.Beige
        Me.PRODUCTOSDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.PRODUCTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PRODUCTOSDataGridView.DataSource = Me.PRODUCTOSBindingSource
        Me.PRODUCTOSDataGridView.Location = New System.Drawing.Point(12, 307)
        Me.PRODUCTOSDataGridView.Name = "PRODUCTOSDataGridView"
        Me.PRODUCTOSDataGridView.Size = New System.Drawing.Size(936, 311)
        Me.PRODUCTOSDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "codpro"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Código producto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nompro"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre producto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "existencia"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Existencia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 27)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "LISTA DE PRODUCTOS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = Global.Fruteria.My.Resources.Resources.borrador
        Me.PictureBox2.Location = New System.Drawing.Point(921, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.Fruteria.My.Resources.Resources.lupas
        Me.PictureBox3.Location = New System.Drawing.Point(875, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'CodproTextBox
        '
        Me.CodproTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "codpro", True))
        Me.CodproTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodproTextBox.Location = New System.Drawing.Point(126, 130)
        Me.CodproTextBox.Name = "CodproTextBox"
        Me.CodproTextBox.Size = New System.Drawing.Size(261, 32)
        Me.CodproTextBox.TabIndex = 27
        '
        'NomproTextBox
        '
        Me.NomproTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "nompro", True))
        Me.NomproTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomproTextBox.Location = New System.Drawing.Point(126, 187)
        Me.NomproTextBox.Name = "NomproTextBox"
        Me.NomproTextBox.Size = New System.Drawing.Size(261, 32)
        Me.NomproTextBox.TabIndex = 29
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "precio", True))
        Me.PrecioTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioTextBox.Location = New System.Drawing.Point(126, 247)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(261, 32)
        Me.PrecioTextBox.TabIndex = 31
        '
        'ExistenciaTextBox
        '
        Me.ExistenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "existencia", True))
        Me.ExistenciaTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistenciaTextBox.Location = New System.Drawing.Point(552, 130)
        Me.ExistenciaTextBox.Name = "ExistenciaTextBox"
        Me.ExistenciaTextBox.Size = New System.Drawing.Size(261, 32)
        Me.ExistenciaTextBox.TabIndex = 33
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "categoria", True))
        Me.CategoriaTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(552, 187)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(261, 32)
        Me.CategoriaTextBox.TabIndex = 35
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PRODUCTOSBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(552, 250)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(261, 32)
        Me.DescripcionTextBox.TabIndex = 37
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(837, 267)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 34)
        Me.btnCancelar.TabIndex = 42
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(837, 117)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(102, 34)
        Me.btnNuevo.TabIndex = 41
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(837, 227)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(102, 34)
        Me.btnEliminar.TabIndex = 40
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(837, 157)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(102, 34)
        Me.btnGuardar.TabIndex = 39
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 643)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(CodproLabel)
        Me.Controls.Add(Me.CodproTextBox)
        Me.Controls.Add(NomproLabel)
        Me.Controls.Add(Me.NomproTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(ExistenciaLabel)
        Me.Controls.Add(Me.ExistenciaTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PRODUCTOSDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Almacen"
        Me.Text = "Almacen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOVENTADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PROYECTOVENTADataSet As PROYECTOVENTADataSet
    Friend WithEvents PRODUCTOSBindingSource As BindingSource
    Friend WithEvents PRODUCTOSTableAdapter As PROYECTOVENTADataSetTableAdapters.PRODUCTOSTableAdapter
    Friend WithEvents TableAdapterManager As PROYECTOVENTADataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents PRODUCTOSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents CodproTextBox As TextBox
    Friend WithEvents NomproTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents ExistenciaTextBox As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
End Class
