<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Modificar
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
        Dim Sueldo_baseLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Modificar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_banco = New System.Windows.Forms.ComboBox()
        Me.BancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdremuneracionDataSet = New R.bdremuneracionDataSet()
        Me.label29 = New System.Windows.Forms.Label()
        Me.cmb_cuenta = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_numCuenta = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_EstadoCivil = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RF = New System.Windows.Forms.RadioButton()
        Me.RM = New System.Windows.Forms.RadioButton()
        Me.DataFecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.txt_am = New System.Windows.Forms.TextBox()
        Me.txt_ap = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_rut = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_cotizacion = New System.Windows.Forms.TextBox()
        Me.cmb_salud = New System.Windows.Forms.ComboBox()
        Me.OrganismoSaludBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_prevision = New System.Windows.Forms.ComboBox()
        Me.OrganismoPrevisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.OficioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sueldo_baseTextBox = New System.Windows.Forms.TextBox()
        Me.Asignacion_colacionTextBox = New System.Windows.Forms.TextBox()
        Me.CentroCostoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Asignacion_movTextBox = New System.Windows.Forms.TextBox()
        Me.cmb_contrato = New System.Windows.Forms.ComboBox()
        Me.cmb_cc = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Agregar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OrganismoPrevisionTableAdapter = New R.bdremuneracionDataSetTableAdapters.OrganismoPrevisionTableAdapter()
        Me.OrganismoSaludTableAdapter = New R.bdremuneracionDataSetTableAdapters.OrganismoSaludTableAdapter()
        Me.OficioTableAdapter = New R.bdremuneracionDataSetTableAdapters.OficioTableAdapter()
        Me.CentroCostoTableAdapter = New R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter()
        Me.TrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajadorTableAdapter = New R.bdremuneracionDataSetTableAdapters.trabajadorTableAdapter()
        Me.TableAdapterManager = New R.bdremuneracionDataSetTableAdapters.TableAdapterManager()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trabajador_previsionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trabajador_previsionTableAdapter = New R.bdremuneracionDataSetTableAdapters.trabajador_previsionTableAdapter()
        Me.Trabajador_previsionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trabajador_saludBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trabajador_saludTableAdapter = New R.bdremuneracionDataSetTableAdapters.trabajador_saludTableAdapter()
        Me.Trabajador_saludDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta_bancariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cuenta_bancariaTableAdapter = New R.bdremuneracionDataSetTableAdapters.cuenta_bancariaTableAdapter()
        Me.Cuenta_bancariaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cc_trabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cc_trabajadorTableAdapter = New R.bdremuneracionDataSetTableAdapters.cc_trabajadorTableAdapter()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cc_trabajadorDataGridView = New System.Windows.Forms.DataGridView()
        Me.BancoTableAdapter = New R.bdremuneracionDataSetTableAdapters.bancoTableAdapter()
        Me.OficioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Sueldo_baseLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.OrganismoSaludBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganismoPrevisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.OficioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajador_previsionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajador_previsionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajador_saludBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trabajador_saludDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cuenta_bancariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cuenta_bancariaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cc_trabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cc_trabajadorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sueldo_baseLabel
        '
        Sueldo_baseLabel.AutoSize = True
        Sueldo_baseLabel.Location = New System.Drawing.Point(3, 57)
        Sueldo_baseLabel.Name = "Sueldo_baseLabel"
        Sueldo_baseLabel.Size = New System.Drawing.Size(102, 21)
        Sueldo_baseLabel.TabIndex = 31
        Sueldo_baseLabel.Text = "sueldo base:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmb_banco)
        Me.Panel1.Controls.Add(Me.label29)
        Me.Panel1.Controls.Add(Me.cmb_cuenta)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.txt_numCuenta)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.cmb_EstadoCivil)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DataFecha)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_dir)
        Me.Panel1.Controls.Add(Me.txt_am)
        Me.Panel1.Controls.Add(Me.txt_ap)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.txt_rut)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(46, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 543)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Tag = ""
        '
        'cmb_banco
        '
        Me.cmb_banco.DataSource = Me.BancoBindingSource
        Me.cmb_banco.DisplayMember = "nombre"
        Me.cmb_banco.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_banco.FormattingEnabled = True
        Me.cmb_banco.Location = New System.Drawing.Point(170, 497)
        Me.cmb_banco.Name = "cmb_banco"
        Me.cmb_banco.Size = New System.Drawing.Size(126, 27)
        Me.cmb_banco.TabIndex = 27
        Me.cmb_banco.ValueMember = "cod_banco"
        '
        'BancoBindingSource
        '
        Me.BancoBindingSource.DataMember = "banco"
        Me.BancoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'BdremuneracionDataSet
        '
        Me.BdremuneracionDataSet.DataSetName = "bdremuneracionDataSet"
        Me.BdremuneracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label29.Location = New System.Drawing.Point(6, 500)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(48, 19)
        Me.label29.TabIndex = 26
        Me.label29.Text = "Banco"
        '
        'cmb_cuenta
        '
        Me.cmb_cuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cuenta.FormattingEnabled = True
        Me.cmb_cuenta.Items.AddRange(New Object() {"Corriente", "Vista", "Cuenta Rut"})
        Me.cmb_cuenta.Location = New System.Drawing.Point(170, 455)
        Me.cmb_cuenta.Name = "cmb_cuenta"
        Me.cmb_cuenta.Size = New System.Drawing.Size(126, 27)
        Me.cmb_cuenta.TabIndex = 25
        Me.cmb_cuenta.Text = "Seleccione"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 458)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(98, 19)
        Me.Label28.TabIndex = 24
        Me.Label28.Text = "Tipo de cuenta"
        '
        'txt_numCuenta
        '
        Me.txt_numCuenta.Location = New System.Drawing.Point(172, 418)
        Me.txt_numCuenta.Name = "txt_numCuenta"
        Me.txt_numCuenta.Size = New System.Drawing.Size(124, 26)
        Me.txt_numCuenta.TabIndex = 23
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 421)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(121, 19)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "Número de cuenta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(304, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(133, 19)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "ejemplo: xxxxxxxx-x"
        '
        'cmb_EstadoCivil
        '
        Me.cmb_EstadoCivil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_EstadoCivil.FormattingEnabled = True
        Me.cmb_EstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado"})
        Me.cmb_EstadoCivil.Location = New System.Drawing.Point(172, 375)
        Me.cmb_EstadoCivil.Name = "cmb_EstadoCivil"
        Me.cmb_EstadoCivil.Size = New System.Drawing.Size(126, 27)
        Me.cmb_EstadoCivil.TabIndex = 20
        Me.cmb_EstadoCivil.Text = "Seleccione"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RF)
        Me.GroupBox1.Controls.Add(Me.RM)
        Me.GroupBox1.Location = New System.Drawing.Point(174, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 65)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'RF
        '
        Me.RF.AutoSize = True
        Me.RF.Location = New System.Drawing.Point(19, 40)
        Me.RF.Name = "RF"
        Me.RF.Size = New System.Drawing.Size(86, 23)
        Me.RF.TabIndex = 18
        Me.RF.TabStop = True
        Me.RF.Text = "Femenino"
        Me.RF.UseVisualStyleBackColor = True
        '
        'RM
        '
        Me.RM.AutoSize = True
        Me.RM.Location = New System.Drawing.Point(19, 14)
        Me.RM.Name = "RM"
        Me.RM.Size = New System.Drawing.Size(89, 23)
        Me.RM.TabIndex = 17
        Me.RM.TabStop = True
        Me.RM.Text = "Masculino"
        Me.RM.UseVisualStyleBackColor = True
        '
        'DataFecha
        '
        Me.DataFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFecha.Location = New System.Drawing.Point(172, 193)
        Me.DataFecha.Name = "DataFecha"
        Me.DataFecha.Size = New System.Drawing.Size(126, 26)
        Me.DataFecha.TabIndex = 16
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(174, 340)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(124, 26)
        Me.txt_email.TabIndex = 15
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(174, 231)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(124, 26)
        Me.txt_dir.TabIndex = 14
        '
        'txt_am
        '
        Me.txt_am.Location = New System.Drawing.Point(174, 153)
        Me.txt_am.Name = "txt_am"
        Me.txt_am.Size = New System.Drawing.Size(124, 26)
        Me.txt_am.TabIndex = 13
        '
        'txt_ap
        '
        Me.txt_ap.Location = New System.Drawing.Point(174, 116)
        Me.txt_ap.Name = "txt_ap"
        Me.txt_ap.Size = New System.Drawing.Size(124, 26)
        Me.txt_ap.TabIndex = 12
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(174, 77)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(124, 26)
        Me.txt_nombre.TabIndex = 11
        '
        'txt_rut
        '
        Me.txt_rut.Location = New System.Drawing.Point(174, 34)
        Me.txt_rut.Name = "txt_rut"
        Me.txt_rut.Size = New System.Drawing.Size(124, 26)
        Me.txt_rut.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Rut"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Apellido Paterno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Apellido Materno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado Civil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos personales"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txt_cotizacion)
        Me.Panel2.Controls.Add(Me.cmb_salud)
        Me.Panel2.Controls.Add(Me.cmb_prevision)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(495, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 201)
        Me.Panel2.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(208, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(22, 19)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "%"
        '
        'txt_cotizacion
        '
        Me.txt_cotizacion.Location = New System.Drawing.Point(78, 111)
        Me.txt_cotizacion.Name = "txt_cotizacion"
        Me.txt_cotizacion.Size = New System.Drawing.Size(124, 29)
        Me.txt_cotizacion.TabIndex = 24
        Me.txt_cotizacion.Text = "0"
        Me.txt_cotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_salud
        '
        Me.cmb_salud.DataSource = Me.OrganismoSaludBindingSource
        Me.cmb_salud.DisplayMember = "nombre"
        Me.cmb_salud.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_salud.FormattingEnabled = True
        Me.cmb_salud.Location = New System.Drawing.Point(78, 67)
        Me.cmb_salud.Name = "cmb_salud"
        Me.cmb_salud.Size = New System.Drawing.Size(126, 27)
        Me.cmb_salud.TabIndex = 22
        Me.cmb_salud.ValueMember = "cod_salud"
        '
        'OrganismoSaludBindingSource
        '
        Me.OrganismoSaludBindingSource.DataMember = "OrganismoSalud"
        Me.OrganismoSaludBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'cmb_prevision
        '
        Me.cmb_prevision.DataSource = Me.OrganismoPrevisionBindingSource
        Me.cmb_prevision.DisplayMember = "nombre"
        Me.cmb_prevision.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_prevision.FormattingEnabled = True
        Me.cmb_prevision.Location = New System.Drawing.Point(78, 34)
        Me.cmb_prevision.Name = "cmb_prevision"
        Me.cmb_prevision.Size = New System.Drawing.Size(126, 27)
        Me.cmb_prevision.TabIndex = 21
        Me.cmb_prevision.ValueMember = "cod_prevision"
        '
        'OrganismoPrevisionBindingSource
        '
        Me.OrganismoPrevisionBindingSource.DataMember = "OrganismoPrevision"
        Me.OrganismoPrevisionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-2, 114)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 19)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Cotización"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 19)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "ISAPRE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 19)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "AFP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 21)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Datos previsionales"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cmb_cargo)
        Me.Panel3.Controls.Add(Sueldo_baseLabel)
        Me.Panel3.Controls.Add(Me.Sueldo_baseTextBox)
        Me.Panel3.Controls.Add(Me.Asignacion_colacionTextBox)
        Me.Panel3.Controls.Add(Me.Asignacion_movTextBox)
        Me.Panel3.Controls.Add(Me.cmb_contrato)
        Me.Panel3.Controls.Add(Me.cmb_cc)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Location = New System.Drawing.Point(495, 224)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(649, 225)
        Me.Panel3.TabIndex = 2
        '
        'cmb_cargo
        '
        Me.cmb_cargo.DataSource = Me.OficioBindingSource
        Me.cmb_cargo.DisplayMember = "nombre"
        Me.cmb_cargo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Location = New System.Drawing.Point(113, 24)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(126, 27)
        Me.cmb_cargo.TabIndex = 33
        Me.cmb_cargo.ValueMember = "cod_cargo"
        '
        'OficioBindingSource
        '
        Me.OficioBindingSource.DataMember = "Oficio"
        Me.OficioBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Sueldo_baseTextBox
        '
        Me.Sueldo_baseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OficioBindingSource, "sueldo_base", True))
        Me.Sueldo_baseTextBox.Enabled = False
        Me.Sueldo_baseTextBox.Location = New System.Drawing.Point(111, 54)
        Me.Sueldo_baseTextBox.Name = "Sueldo_baseTextBox"
        Me.Sueldo_baseTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Sueldo_baseTextBox.TabIndex = 32
        '
        'Asignacion_colacionTextBox
        '
        Me.Asignacion_colacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CentroCostoBindingSource, "asignacion_colacion", True))
        Me.Asignacion_colacionTextBox.Enabled = False
        Me.Asignacion_colacionTextBox.Location = New System.Drawing.Point(385, 104)
        Me.Asignacion_colacionTextBox.Name = "Asignacion_colacionTextBox"
        Me.Asignacion_colacionTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Asignacion_colacionTextBox.TabIndex = 30
        '
        'CentroCostoBindingSource
        '
        Me.CentroCostoBindingSource.DataMember = "CentroCosto"
        Me.CentroCostoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Asignacion_movTextBox
        '
        Me.Asignacion_movTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CentroCostoBindingSource, "asignacion_mov", True))
        Me.Asignacion_movTextBox.Enabled = False
        Me.Asignacion_movTextBox.Location = New System.Drawing.Point(385, 140)
        Me.Asignacion_movTextBox.Name = "Asignacion_movTextBox"
        Me.Asignacion_movTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Asignacion_movTextBox.TabIndex = 29
        '
        'cmb_contrato
        '
        Me.cmb_contrato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_contrato.FormattingEnabled = True
        Me.cmb_contrato.Items.AddRange(New Object() {"Fijo", "Indefinido" & Global.Microsoft.VisualBasic.ChrW(9), "Termino de Obra"})
        Me.cmb_contrato.Location = New System.Drawing.Point(113, 142)
        Me.cmb_contrato.Name = "cmb_contrato"
        Me.cmb_contrato.Size = New System.Drawing.Size(126, 27)
        Me.cmb_contrato.TabIndex = 28
        Me.cmb_contrato.Text = "Seleccione"
        '
        'cmb_cc
        '
        Me.cmb_cc.DataSource = Me.CentroCostoBindingSource
        Me.cmb_cc.DisplayMember = "nombre"
        Me.cmb_cc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_cc.FormattingEnabled = True
        Me.cmb_cc.Location = New System.Drawing.Point(113, 106)
        Me.cmb_cc.Name = "cmb_cc"
        Me.cmb_cc.Size = New System.Drawing.Size(126, 27)
        Me.cmb_cc.TabIndex = 27
        Me.cmb_cc.ValueMember = "id_cc"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(294, 145)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 19)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Movilización"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(294, 114)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 19)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Colación"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 145)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 19)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Tipo contrato"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 114)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 19)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Centro de costo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(47, 19)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Cargo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 21)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Información contractual"
        '
        'Agregar
        '
        Me.Agregar.BackColor = System.Drawing.Color.Transparent
        Me.Agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agregar.Image = CType(resources.GetObject("Agregar.Image"), System.Drawing.Image)
        Me.Agregar.Location = New System.Drawing.Point(549, 455)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(67, 71)
        Me.Agregar.TabIndex = 4
        Me.Agregar.TabStop = False
        Me.Agregar.Tag = "Confirmar cambios"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(669, 455)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 71)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Volver"
        '
        'OrganismoPrevisionTableAdapter
        '
        Me.OrganismoPrevisionTableAdapter.ClearBeforeFill = True
        '
        'OrganismoSaludTableAdapter
        '
        Me.OrganismoSaludTableAdapter.ClearBeforeFill = True
        '
        'OficioTableAdapter
        '
        Me.OficioTableAdapter.ClearBeforeFill = True
        '
        'CentroCostoTableAdapter
        '
        Me.CentroCostoTableAdapter.ClearBeforeFill = True
        '
        'TrabajadorBindingSource
        '
        Me.TrabajadorBindingSource.DataMember = "trabajador"
        Me.TrabajadorBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'TrabajadorTableAdapter
        '
        Me.TrabajadorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.anexoTableAdapter = Nothing
        Me.TableAdapterManager.AnticiposTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancoTableAdapter = Nothing
        Me.TableAdapterManager.CargaFamiliarTableAdapter = Nothing
        Me.TableAdapterManager.cc_trabajadorTableAdapter = Nothing
        Me.TableAdapterManager.CentroCostoTableAdapter = Me.CentroCostoTableAdapter
        Me.TableAdapterManager.ContratoTableAdapter = Nothing
        Me.TableAdapterManager.cuenta_bancariaTableAdapter = Nothing
        Me.TableAdapterManager.descuentos_liquidacionTableAdapter = Nothing
        Me.TableAdapterManager.DescuentosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaContratistaTableAdapter = Nothing
        Me.TableAdapterManager.FiniquitoTableAdapter = Nothing
        Me.TableAdapterManager.haber_liquidacionTableAdapter = Nothing
        Me.TableAdapterManager.HaberesTableAdapter = Nothing
        Me.TableAdapterManager.IngresoHorasTableAdapter = Nothing
        Me.TableAdapterManager.LicenciaMedicaTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionTableAdapter = Nothing
        Me.TableAdapterManager.OficioTableAdapter = Me.OficioTableAdapter
        Me.TableAdapterManager.OrganismoPrevisionTableAdapter = Me.OrganismoPrevisionTableAdapter
        Me.TableAdapterManager.OrganismoSaludTableAdapter = Me.OrganismoSaludTableAdapter
        Me.TableAdapterManager.parametrosTableAdapter = Nothing
        Me.TableAdapterManager.SeguroCesantiaTableAdapter = Nothing
        Me.TableAdapterManager.TasasPrevisionalesTableAdapter = Nothing
        Me.TableAdapterManager.trabajador_previsionTableAdapter = Nothing
        Me.TableAdapterManager.trabajador_saludTableAdapter = Nothing
        Me.TableAdapterManager.trabajadorTableAdapter = Me.TrabajadorTableAdapter
        Me.TableAdapterManager.TramosAsigFamiliarTableAdapter = Nothing
        Me.TableAdapterManager.TramosIUTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = R.bdremuneracionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'TrabajadorDataGridView
        '
        Me.TrabajadorDataGridView.AutoGenerateColumns = False
        Me.TrabajadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrabajadorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.TrabajadorDataGridView.DataSource = Me.TrabajadorBindingSource
        Me.TrabajadorDataGridView.Location = New System.Drawing.Point(495, 419)
        Me.TrabajadorDataGridView.Name = "TrabajadorDataGridView"
        Me.TrabajadorDataGridView.Size = New System.Drawing.Size(84, 14)
        Me.TrabajadorDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rut"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rut"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido_paterno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido_paterno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "apellido_materno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "apellido_materno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "estado_civil"
        Me.DataGridViewTextBoxColumn5.HeaderText = "estado_civil"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "sexo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn9.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "cod_cargo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "cod_cargo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn11.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Trabajador_previsionBindingSource
        '
        Me.Trabajador_previsionBindingSource.DataMember = "trabajador_prevision"
        Me.Trabajador_previsionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Trabajador_previsionTableAdapter
        '
        Me.Trabajador_previsionTableAdapter.ClearBeforeFill = True
        '
        'Trabajador_previsionDataGridView
        '
        Me.Trabajador_previsionDataGridView.AutoGenerateColumns = False
        Me.Trabajador_previsionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Trabajador_previsionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Trabajador_previsionDataGridView.DataSource = Me.Trabajador_previsionBindingSource
        Me.Trabajador_previsionDataGridView.Location = New System.Drawing.Point(795, 419)
        Me.Trabajador_previsionDataGridView.Name = "Trabajador_previsionDataGridView"
        Me.Trabajador_previsionDataGridView.Size = New System.Drawing.Size(206, 70)
        Me.Trabajador_previsionDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "cod_prevision"
        Me.DataGridViewTextBoxColumn12.HeaderText = "cod_prevision"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn13.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn14.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Trabajador_saludBindingSource
        '
        Me.Trabajador_saludBindingSource.DataMember = "trabajador_salud"
        Me.Trabajador_saludBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Trabajador_saludTableAdapter
        '
        Me.Trabajador_saludTableAdapter.ClearBeforeFill = True
        '
        'Trabajador_saludDataGridView
        '
        Me.Trabajador_saludDataGridView.AutoGenerateColumns = False
        Me.Trabajador_saludDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Trabajador_saludDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.Trabajador_saludDataGridView.DataSource = Me.Trabajador_saludBindingSource
        Me.Trabajador_saludDataGridView.Location = New System.Drawing.Point(795, 495)
        Me.Trabajador_saludDataGridView.Name = "Trabajador_saludDataGridView"
        Me.Trabajador_saludDataGridView.Size = New System.Drawing.Size(241, 10)
        Me.Trabajador_saludDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn15.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn16.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "cotizacion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "cotizacion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "cod_salud"
        Me.DataGridViewTextBoxColumn18.HeaderText = "cod_salud"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'Cuenta_bancariaBindingSource
        '
        Me.Cuenta_bancariaBindingSource.DataMember = "cuenta_bancaria"
        Me.Cuenta_bancariaBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Cuenta_bancariaTableAdapter
        '
        Me.Cuenta_bancariaTableAdapter.ClearBeforeFill = True
        '
        'Cuenta_bancariaDataGridView
        '
        Me.Cuenta_bancariaDataGridView.AutoGenerateColumns = False
        Me.Cuenta_bancariaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cuenta_bancariaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.Cuenta_bancariaDataGridView.DataSource = Me.Cuenta_bancariaBindingSource
        Me.Cuenta_bancariaDataGridView.Location = New System.Drawing.Point(754, 455)
        Me.Cuenta_bancariaDataGridView.Name = "Cuenta_bancariaDataGridView"
        Me.Cuenta_bancariaDataGridView.Size = New System.Drawing.Size(300, 100)
        Me.Cuenta_bancariaDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "nro_cuenta"
        Me.DataGridViewTextBoxColumn19.HeaderText = "nro_cuenta"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "tipo_cuenta"
        Me.DataGridViewTextBoxColumn20.HeaderText = "tipo_cuenta"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "cod_banco"
        Me.DataGridViewTextBoxColumn21.HeaderText = "cod_banco"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn22.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'Cc_trabajadorBindingSource
        '
        Me.Cc_trabajadorBindingSource.DataMember = "cc_trabajador"
        Me.Cc_trabajadorBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Cc_trabajadorTableAdapter
        '
        Me.Cc_trabajadorTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "id_cc"
        Me.DataGridViewTextBoxColumn25.HeaderText = "id_cc"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn24.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn23.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'Cc_trabajadorDataGridView
        '
        Me.Cc_trabajadorDataGridView.AutoGenerateColumns = False
        Me.Cc_trabajadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cc_trabajadorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.Cc_trabajadorDataGridView.DataSource = Me.Cc_trabajadorBindingSource
        Me.Cc_trabajadorDataGridView.Location = New System.Drawing.Point(791, 12)
        Me.Cc_trabajadorDataGridView.Name = "Cc_trabajadorDataGridView"
        Me.Cc_trabajadorDataGridView.Size = New System.Drawing.Size(300, 128)
        Me.Cc_trabajadorDataGridView.TabIndex = 9
        '
        'BancoTableAdapter
        '
        Me.BancoTableAdapter.ClearBeforeFill = True
        '
        'OficioBindingSource1
        '
        Me.OficioBindingSource1.DataMember = "Oficio"
        Me.OficioBindingSource1.DataSource = Me.BdremuneracionDataSet
        '
        'Agregar_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1144, 555)
        Me.Controls.Add(Me.Cc_trabajadorDataGridView)
        Me.Controls.Add(Me.Cuenta_bancariaDataGridView)
        Me.Controls.Add(Me.Trabajador_saludDataGridView)
        Me.Controls.Add(Me.Trabajador_previsionDataGridView)
        Me.Controls.Add(Me.TrabajadorDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Agregar_Modificar"
        Me.Text = "JVRMONTAJES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.OrganismoSaludBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganismoPrevisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.OficioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajador_previsionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajador_previsionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajador_saludBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trabajador_saludDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cuenta_bancariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cuenta_bancariaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cc_trabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cc_trabajadorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmb_EstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RF As System.Windows.Forms.RadioButton
    Friend WithEvents RM As System.Windows.Forms.RadioButton
    Friend WithEvents DataFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents txt_am As System.Windows.Forms.TextBox
    Friend WithEvents txt_ap As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmb_cuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_numCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_cotizacion As System.Windows.Forms.TextBox
    Friend WithEvents cmb_salud As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_prevision As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmb_contrato As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_cc As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Agregar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BdremuneracionDataSet As R.bdremuneracionDataSet
    Friend WithEvents OrganismoPrevisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrganismoPrevisionTableAdapter As R.bdremuneracionDataSetTableAdapters.OrganismoPrevisionTableAdapter
    Friend WithEvents OrganismoSaludBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrganismoSaludTableAdapter As R.bdremuneracionDataSetTableAdapters.OrganismoSaludTableAdapter
    Friend WithEvents OficioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OficioTableAdapter As R.bdremuneracionDataSetTableAdapters.OficioTableAdapter
    Friend WithEvents CentroCostoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CentroCostoTableAdapter As R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter
    Friend WithEvents TrabajadorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrabajadorTableAdapter As R.bdremuneracionDataSetTableAdapters.trabajadorTableAdapter
    Friend WithEvents TableAdapterManager As R.bdremuneracionDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Trabajador_previsionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trabajador_previsionTableAdapter As R.bdremuneracionDataSetTableAdapters.trabajador_previsionTableAdapter
    Friend WithEvents Trabajador_previsionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Trabajador_saludBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trabajador_saludTableAdapter As R.bdremuneracionDataSetTableAdapters.trabajador_saludTableAdapter
    Friend WithEvents Trabajador_saludDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta_bancariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cuenta_bancariaTableAdapter As R.bdremuneracionDataSetTableAdapters.cuenta_bancariaTableAdapter
    Friend WithEvents Cuenta_bancariaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cc_trabajadorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cc_trabajadorTableAdapter As R.bdremuneracionDataSetTableAdapters.cc_trabajadorTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cc_trabajadorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_banco As System.Windows.Forms.ComboBox
    Friend WithEvents label29 As System.Windows.Forms.Label
    Friend WithEvents BancoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BancoTableAdapter As R.bdremuneracionDataSetTableAdapters.bancoTableAdapter
    Friend WithEvents Asignacion_colacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Asignacion_movTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OficioBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Sueldo_baseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmb_cargo As System.Windows.Forms.ComboBox
End Class
