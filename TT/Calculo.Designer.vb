<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculo
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
        Dim RutLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Apellido_maternoLabel As System.Windows.Forms.Label
        Dim Apellido_paternoLabel As System.Windows.Forms.Label
        Dim Cod_cargoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculo))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Cod_cargoTextBox = New System.Windows.Forms.TextBox()
        Me.TrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdremuneracionDataSet = New R.bdremuneracionDataSet()
        Me.Apellido_paternoTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_maternoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.RutTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrabajadorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Trabajador_previsionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OficioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnticiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnticiposTableAdapter = New R.bdremuneracionDataSetTableAdapters.AnticiposTableAdapter()
        Me.TableAdapterManager = New R.bdremuneracionDataSetTableAdapters.TableAdapterManager()
        Me.Cc_trabajadorTableAdapter = New R.bdremuneracionDataSetTableAdapters.cc_trabajadorTableAdapter()
        Me.CentroCostoTableAdapter = New R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter()
        Me.ContratoTableAdapter = New R.bdremuneracionDataSetTableAdapters.ContratoTableAdapter()
        Me.Descuentos_liquidacionTableAdapter = New R.bdremuneracionDataSetTableAdapters.descuentos_liquidacionTableAdapter()
        Me.Haber_liquidacionTableAdapter = New R.bdremuneracionDataSetTableAdapters.haber_liquidacionTableAdapter()
        Me.OficioTableAdapter = New R.bdremuneracionDataSetTableAdapters.OficioTableAdapter()
        Me.OrganismoPrevisionTableAdapter = New R.bdremuneracionDataSetTableAdapters.OrganismoPrevisionTableAdapter()
        Me.TasasPrevisionalesTableAdapter = New R.bdremuneracionDataSetTableAdapters.TasasPrevisionalesTableAdapter()
        Me.Trabajador_previsionTableAdapter = New R.bdremuneracionDataSetTableAdapters.trabajador_previsionTableAdapter()
        Me.Trabajador_saludTableAdapter = New R.bdremuneracionDataSetTableAdapters.trabajador_saludTableAdapter()
        Me.TrabajadorTableAdapter = New R.bdremuneracionDataSetTableAdapters.trabajadorTableAdapter()
        Me.Cc_trabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CentroCostoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Descuentos_liquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Haber_liquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trabajador_saludBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrganismoPrevisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TasasPrevisionalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        RutLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Apellido_maternoLabel = New System.Windows.Forms.Label()
        Apellido_paternoLabel = New System.Windows.Forms.Label()
        Cod_cargoLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajador_previsionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cc_trabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Descuentos_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Haber_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajador_saludBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganismoPrevisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasasPrevisionalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RutLabel
        '
        RutLabel.AutoSize = True
        RutLabel.Location = New System.Drawing.Point(172, 174)
        RutLabel.Name = "RutLabel"
        RutLabel.Size = New System.Drawing.Size(28, 19)
        RutLabel.TabIndex = 23
        RutLabel.Text = "rut:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(172, 214)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(58, 19)
        NombreLabel.TabIndex = 24
        NombreLabel.Text = "nombre:"
        '
        'Apellido_maternoLabel
        '
        Apellido_maternoLabel.AutoSize = True
        Apellido_maternoLabel.Location = New System.Drawing.Point(172, 288)
        Apellido_maternoLabel.Name = "Apellido_maternoLabel"
        Apellido_maternoLabel.Size = New System.Drawing.Size(112, 19)
        Apellido_maternoLabel.TabIndex = 25
        Apellido_maternoLabel.Text = "apellido materno:"
        '
        'Apellido_paternoLabel
        '
        Apellido_paternoLabel.AutoSize = True
        Apellido_paternoLabel.Location = New System.Drawing.Point(172, 250)
        Apellido_paternoLabel.Name = "Apellido_paternoLabel"
        Apellido_paternoLabel.Size = New System.Drawing.Size(109, 19)
        Apellido_paternoLabel.TabIndex = 26
        Apellido_paternoLabel.Text = "apellido paterno:"
        '
        'Cod_cargoLabel
        '
        Cod_cargoLabel.AutoSize = True
        Cod_cargoLabel.Location = New System.Drawing.Point(172, 329)
        Cod_cargoLabel.Name = "Cod_cargoLabel"
        Cod_cargoLabel.Size = New System.Drawing.Size(73, 19)
        Cod_cargoLabel.TabIndex = 27
        Cod_cargoLabel.Text = "cod cargo:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1098, 481)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1090, 449)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inicio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(758, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 71)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(105, 109)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(593, 217)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 55)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CÁLCULO"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Cod_cargoLabel)
        Me.TabPage2.Controls.Add(Me.Cod_cargoTextBox)
        Me.TabPage2.Controls.Add(Apellido_paternoLabel)
        Me.TabPage2.Controls.Add(Me.Apellido_paternoTextBox)
        Me.TabPage2.Controls.Add(Apellido_maternoLabel)
        Me.TabPage2.Controls.Add(Me.Apellido_maternoTextBox)
        Me.TabPage2.Controls.Add(NombreLabel)
        Me.TabPage2.Controls.Add(Me.NombreTextBox)
        Me.TabPage2.Controls.Add(RutLabel)
        Me.TabPage2.Controls.Add(Me.RutTextBox)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TrabajadorDataGridView)
        Me.TabPage2.Controls.Add(Me.PictureBox11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(1090, 449)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Seleccionar Trabajador"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Cod_cargoTextBox
        '
        Me.Cod_cargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrabajadorBindingSource, "cod_cargo", True))
        Me.Cod_cargoTextBox.Location = New System.Drawing.Point(290, 329)
        Me.Cod_cargoTextBox.Name = "Cod_cargoTextBox"
        Me.Cod_cargoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Cod_cargoTextBox.TabIndex = 28
        '
        'TrabajadorBindingSource
        '
        Me.TrabajadorBindingSource.DataMember = "trabajador"
        Me.TrabajadorBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'BdremuneracionDataSet
        '
        Me.BdremuneracionDataSet.DataSetName = "bdremuneracionDataSet"
        Me.BdremuneracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Apellido_paternoTextBox
        '
        Me.Apellido_paternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrabajadorBindingSource, "apellido_paterno", True))
        Me.Apellido_paternoTextBox.Location = New System.Drawing.Point(290, 243)
        Me.Apellido_paternoTextBox.Name = "Apellido_paternoTextBox"
        Me.Apellido_paternoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Apellido_paternoTextBox.TabIndex = 27
        '
        'Apellido_maternoTextBox
        '
        Me.Apellido_maternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrabajadorBindingSource, "apellido_materno", True))
        Me.Apellido_maternoTextBox.Location = New System.Drawing.Point(290, 281)
        Me.Apellido_maternoTextBox.Name = "Apellido_maternoTextBox"
        Me.Apellido_maternoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Apellido_maternoTextBox.TabIndex = 26
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrabajadorBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(290, 211)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NombreTextBox.TabIndex = 25
        '
        'RutTextBox
        '
        Me.RutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrabajadorBindingSource, "rut", True))
        Me.RutTextBox.Location = New System.Drawing.Point(290, 167)
        Me.RutTextBox.Name = "RutTextBox"
        Me.RutTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RutTextBox.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "SELECCIONE TRABAJADOR"
        '
        'TrabajadorDataGridView
        '
        Me.TrabajadorDataGridView.AutoGenerateColumns = False
        Me.TrabajadorDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TrabajadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrabajadorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TrabajadorDataGridView.DataSource = Me.TrabajadorBindingSource
        Me.TrabajadorDataGridView.Location = New System.Drawing.Point(176, 42)
        Me.TrabajadorDataGridView.Name = "TrabajadorDataGridView"
        Me.TrabajadorDataGridView.Size = New System.Drawing.Size(396, 101)
        Me.TrabajadorDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "apellido_materno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "apellido_materno"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "estado_civil"
        Me.DataGridViewTextBoxColumn3.HeaderText = "estado_civil"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "sexo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cod_cargo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cod_cargo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn9.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "rut"
        Me.DataGridViewTextBoxColumn10.HeaderText = "rut"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox11.TabIndex = 13
        Me.PictureBox11.TabStop = False
        '
        'Trabajador_previsionBindingSource
        '
        Me.Trabajador_previsionBindingSource.DataMember = "trabajador_prevision"
        Me.Trabajador_previsionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'OficioBindingSource
        '
        Me.OficioBindingSource.DataMember = "Oficio"
        Me.OficioBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'AnticiposBindingSource
        '
        Me.AnticiposBindingSource.DataMember = "Anticipos"
        Me.AnticiposBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'AnticiposTableAdapter
        '
        Me.AnticiposTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.anexoTableAdapter = Nothing
        Me.TableAdapterManager.AnticiposTableAdapter = Me.AnticiposTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancoTableAdapter = Nothing
        Me.TableAdapterManager.CargaFamiliarTableAdapter = Nothing
        Me.TableAdapterManager.cc_trabajadorTableAdapter = Me.Cc_trabajadorTableAdapter
        Me.TableAdapterManager.CentroCostoTableAdapter = Me.CentroCostoTableAdapter
        Me.TableAdapterManager.ContratoTableAdapter = Me.ContratoTableAdapter
        Me.TableAdapterManager.cuenta_bancariaTableAdapter = Nothing
        Me.TableAdapterManager.descuentos_liquidacionTableAdapter = Me.Descuentos_liquidacionTableAdapter
        Me.TableAdapterManager.DescuentosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaContratistaTableAdapter = Nothing
        Me.TableAdapterManager.FiniquitoTableAdapter = Nothing
        Me.TableAdapterManager.haber_liquidacionTableAdapter = Me.Haber_liquidacionTableAdapter
        Me.TableAdapterManager.HaberesTableAdapter = Nothing
        Me.TableAdapterManager.IngresoHorasTableAdapter = Nothing
        Me.TableAdapterManager.LicenciaMedicaTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionTableAdapter = Nothing
        Me.TableAdapterManager.OficioTableAdapter = Me.OficioTableAdapter
        Me.TableAdapterManager.OrganismoPrevisionTableAdapter = Me.OrganismoPrevisionTableAdapter
        Me.TableAdapterManager.OrganismoSaludTableAdapter = Nothing
        Me.TableAdapterManager.parametrosTableAdapter = Nothing
        Me.TableAdapterManager.SeguroCesantiaTableAdapter = Nothing
        Me.TableAdapterManager.TasasPrevisionalesTableAdapter = Me.TasasPrevisionalesTableAdapter
        Me.TableAdapterManager.trabajador_previsionTableAdapter = Me.Trabajador_previsionTableAdapter
        Me.TableAdapterManager.trabajador_saludTableAdapter = Me.Trabajador_saludTableAdapter
        Me.TableAdapterManager.trabajadorTableAdapter = Me.TrabajadorTableAdapter
        Me.TableAdapterManager.TramosAsigFamiliarTableAdapter = Nothing
        Me.TableAdapterManager.TramosIUTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = R.bdremuneracionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'Cc_trabajadorTableAdapter
        '
        Me.Cc_trabajadorTableAdapter.ClearBeforeFill = True
        '
        'CentroCostoTableAdapter
        '
        Me.CentroCostoTableAdapter.ClearBeforeFill = True
        '
        'ContratoTableAdapter
        '
        Me.ContratoTableAdapter.ClearBeforeFill = True
        '
        'Descuentos_liquidacionTableAdapter
        '
        Me.Descuentos_liquidacionTableAdapter.ClearBeforeFill = True
        '
        'Haber_liquidacionTableAdapter
        '
        Me.Haber_liquidacionTableAdapter.ClearBeforeFill = True
        '
        'OficioTableAdapter
        '
        Me.OficioTableAdapter.ClearBeforeFill = True
        '
        'OrganismoPrevisionTableAdapter
        '
        Me.OrganismoPrevisionTableAdapter.ClearBeforeFill = True
        '
        'TasasPrevisionalesTableAdapter
        '
        Me.TasasPrevisionalesTableAdapter.ClearBeforeFill = True
        '
        'Trabajador_previsionTableAdapter
        '
        Me.Trabajador_previsionTableAdapter.ClearBeforeFill = True
        '
        'Trabajador_saludTableAdapter
        '
        Me.Trabajador_saludTableAdapter.ClearBeforeFill = True
        '
        'TrabajadorTableAdapter
        '
        Me.TrabajadorTableAdapter.ClearBeforeFill = True
        '
        'Cc_trabajadorBindingSource
        '
        Me.Cc_trabajadorBindingSource.DataMember = "cc_trabajador"
        Me.Cc_trabajadorBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'CentroCostoBindingSource
        '
        Me.CentroCostoBindingSource.DataMember = "CentroCosto"
        Me.CentroCostoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Descuentos_liquidacionBindingSource
        '
        Me.Descuentos_liquidacionBindingSource.DataMember = "descuentos_liquidacion"
        Me.Descuentos_liquidacionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Haber_liquidacionBindingSource
        '
        Me.Haber_liquidacionBindingSource.DataMember = "haber_liquidacion"
        Me.Haber_liquidacionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Trabajador_saludBindingSource
        '
        Me.Trabajador_saludBindingSource.DataMember = "trabajador_salud"
        Me.Trabajador_saludBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'OrganismoPrevisionBindingSource
        '
        Me.OrganismoPrevisionBindingSource.DataMember = "OrganismoPrevision"
        Me.OrganismoPrevisionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'TasasPrevisionalesBindingSource
        '
        Me.TasasPrevisionalesBindingSource.DataMember = "TasasPrevisionales"
        Me.TasasPrevisionalesBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'ContratoBindingSource
        '
        Me.ContratoBindingSource.DataMember = "Contrato"
        Me.ContratoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Calculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(725, 483)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Calculo"
        Me.Text = "Calculo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajador_previsionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cc_trabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Descuentos_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Haber_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajador_saludBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganismoPrevisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasasPrevisionalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents BdremuneracionDataSet As R.bdremuneracionDataSet
    Friend WithEvents AnticiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnticiposTableAdapter As R.bdremuneracionDataSetTableAdapters.AnticiposTableAdapter
    Friend WithEvents TableAdapterManager As R.bdremuneracionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cc_trabajadorTableAdapter As R.bdremuneracionDataSetTableAdapters.cc_trabajadorTableAdapter
    Friend WithEvents Cc_trabajadorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CentroCostoTableAdapter As R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter
    Friend WithEvents CentroCostoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Descuentos_liquidacionTableAdapter As R.bdremuneracionDataSetTableAdapters.descuentos_liquidacionTableAdapter
    Friend WithEvents Descuentos_liquidacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Haber_liquidacionTableAdapter As R.bdremuneracionDataSetTableAdapters.haber_liquidacionTableAdapter
    Friend WithEvents Haber_liquidacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trabajador_previsionTableAdapter As R.bdremuneracionDataSetTableAdapters.trabajador_previsionTableAdapter
    Friend WithEvents Trabajador_previsionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trabajador_saludTableAdapter As R.bdremuneracionDataSetTableAdapters.trabajador_saludTableAdapter
    Friend WithEvents Trabajador_saludBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrganismoPrevisionTableAdapter As R.bdremuneracionDataSetTableAdapters.OrganismoPrevisionTableAdapter
    Friend WithEvents OrganismoPrevisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TasasPrevisionalesTableAdapter As R.bdremuneracionDataSetTableAdapters.TasasPrevisionalesTableAdapter
    Friend WithEvents TasasPrevisionalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratoTableAdapter As R.bdremuneracionDataSetTableAdapters.ContratoTableAdapter
    Friend WithEvents ContratoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OficioTableAdapter As R.bdremuneracionDataSetTableAdapters.OficioTableAdapter
    Friend WithEvents OficioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrabajadorTableAdapter As R.bdremuneracionDataSetTableAdapters.trabajadorTableAdapter
    Friend WithEvents TrabajadorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrabajadorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cod_cargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_paternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_maternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RutTextBox As System.Windows.Forms.TextBox
End Class
