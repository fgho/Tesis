<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eventos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eventos))
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Contrato_FechaTermino = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.ContratoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContratoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdremuneracionDataSet = New R.bdremuneracionDataSet()
        Me.AgregarContrato = New System.Windows.Forms.PictureBox()
        Me.Contrato_Empresa = New System.Windows.Forms.ComboBox()
        Me.EmpresaContratistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdremuneracionDataSet1 = New R.bdremuneracionDataSet()
        Me.Contrato_CC = New System.Windows.Forms.ComboBox()
        Me.CentroCostoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contratos_Tipo = New System.Windows.Forms.ComboBox()
        Me.Contrato_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Contrato_Horas = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Contratos_BuscRut = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.AnexoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.AgregarAnexo = New System.Windows.Forms.PictureBox()
        Me.Anexo_CmbTipo = New System.Windows.Forms.ComboBox()
        Me.Anexo_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Anexo_Descripción = New System.Windows.Forms.RichTextBox()
        Me.Anexo_BuscRut = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.VacacionesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Vac_FechaTermino = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AgregarVaciones = New System.Windows.Forms.PictureBox()
        Me.Vac_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Vac_buscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.CargaFamiliarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargaFamiliarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Carga_AM = New System.Windows.Forms.TextBox()
        Me.Carga_AP = New System.Windows.Forms.TextBox()
        Me.Carga_Nombre = New System.Windows.Forms.TextBox()
        Me.Carga_rutCarga = New System.Windows.Forms.TextBox()
        Me.Carga_buscar = New System.Windows.Forms.TextBox()
        Me.Carga_cmbCarga = New System.Windows.Forms.ComboBox()
        Me.Carga_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.AgregarCarga = New System.Windows.Forms.PictureBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.IngresoHorasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoHorasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.TxtNumFallas = New System.Windows.Forms.TextBox()
        Me.TxtHorasExtras = New System.Windows.Forms.TextBox()
        Me.TxtSobretiempo = New System.Windows.Forms.TextBox()
        Me.cmb_Empresa = New System.Windows.Forms.ComboBox()
        Me.AgregarHoras = New System.Windows.Forms.PictureBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txt_buscrut6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FiniquitoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiniquitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgregarFiniquito = New System.Windows.Forms.PictureBox()
        Me.RichCausal = New System.Windows.Forms.RichTextBox()
        Me.FechaFiniquito = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_buscrut4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.AnticiposDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnticiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.AgregarAnticipo = New System.Windows.Forms.PictureBox()
        Me.TxtMontoAnticipo = New System.Windows.Forms.TextBox()
        Me.txt_buscrut3 = New System.Windows.Forms.TextBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.FechaAnticipo = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.LicenciaMedicaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicenciaMedicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AgregarLicencia = New System.Windows.Forms.PictureBox()
        Me.RichMotivo = New System.Windows.Forms.RichTextBox()
        Me.txt_buscrut2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FechaTermino = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_buscar2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Descuentos_liquidacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuentos_liquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Haber_liquidacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Haber_liquidacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picDescuentos = New System.Windows.Forms.PictureBox()
        Me.txt_montoDescuento = New System.Windows.Forms.TextBox()
        Me.cmb_descuento = New System.Windows.Forms.ComboBox()
        Me.DescuentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picHaber = New System.Windows.Forms.PictureBox()
        Me.txt_montoHaber = New System.Windows.Forms.TextBox()
        Me.cmb_haber = New System.Windows.Forms.ComboBox()
        Me.HaberesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_buscarHB = New System.Windows.Forms.Button()
        Me.txt_hdrut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TrabajadorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Texto = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.HaberesTableAdapter = New R.bdremuneracionDataSetTableAdapters.HaberesTableAdapter()
        Me.DescuentosTableAdapter = New R.bdremuneracionDataSetTableAdapters.DescuentosTableAdapter()
        Me.Haber_liquidacionTableAdapter = New R.bdremuneracionDataSetTableAdapters.haber_liquidacionTableAdapter()
        Me.TableAdapterManager = New R.bdremuneracionDataSetTableAdapters.TableAdapterManager()
        Me.Descuentos_liquidacionTableAdapter = New R.bdremuneracionDataSetTableAdapters.descuentos_liquidacionTableAdapter()
        Me.TrabajadorTableAdapter = New R.bdremuneracionDataSetTableAdapters.trabajadorTableAdapter()
        Me.LicenciaMedicaTableAdapter = New R.bdremuneracionDataSetTableAdapters.LicenciaMedicaTableAdapter()
        Me.AnticiposTableAdapter = New R.bdremuneracionDataSetTableAdapters.AnticiposTableAdapter()
        Me.FiniquitoTableAdapter = New R.bdremuneracionDataSetTableAdapters.FiniquitoTableAdapter()
        Me.IngresoHorasTableAdapter = New R.bdremuneracionDataSetTableAdapters.IngresoHorasTableAdapter()
        Me.EmpresaContratistaTableAdapter = New R.bdremuneracionDataSetTableAdapters.EmpresaContratistaTableAdapter()
        Me.CargaFamiliarTableAdapter = New R.bdremuneracionDataSetTableAdapters.CargaFamiliarTableAdapter()
        Me.VacacionesTableAdapter = New R.bdremuneracionDataSetTableAdapters.VacacionesTableAdapter()
        Me.AnexoTableAdapter = New R.bdremuneracionDataSetTableAdapters.anexoTableAdapter()
        Me.CentroCostoTableAdapter = New R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter()
        Me.ContratoTableAdapter = New R.bdremuneracionDataSetTableAdapters.ContratoTableAdapter()
        Me.TabPage10.SuspendLayout()
        CType(Me.ContratoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaContratistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdremuneracionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.AnexoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.VacacionesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarVaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.CargaFamiliarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargaFamiliarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.IngresoHorasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoHorasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.FiniquitoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FiniquitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarFiniquito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.AnticiposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.LicenciaMedicaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicenciaMedicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgregarLicencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Descuentos_liquidacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Descuentos_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Haber_liquidacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Haber_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picHaber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HaberesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.TrabajadorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage10
        '
        Me.TabPage10.BackgroundImage = CType(resources.GetObject("TabPage10.BackgroundImage"), System.Drawing.Image)
        Me.TabPage10.Controls.Add(Me.Contrato_FechaTermino)
        Me.TabPage10.Controls.Add(Me.Label43)
        Me.TabPage10.Controls.Add(Me.ContratoDataGridView)
        Me.TabPage10.Controls.Add(Me.AgregarContrato)
        Me.TabPage10.Controls.Add(Me.Contrato_Empresa)
        Me.TabPage10.Controls.Add(Me.Contrato_CC)
        Me.TabPage10.Controls.Add(Me.Contratos_Tipo)
        Me.TabPage10.Controls.Add(Me.Contrato_Fecha)
        Me.TabPage10.Controls.Add(Me.Contrato_Horas)
        Me.TabPage10.Controls.Add(Me.Label42)
        Me.TabPage10.Controls.Add(Me.Label41)
        Me.TabPage10.Controls.Add(Me.Label40)
        Me.TabPage10.Controls.Add(Me.Label39)
        Me.TabPage10.Controls.Add(Me.Label38)
        Me.TabPage10.Controls.Add(Me.Contratos_BuscRut)
        Me.TabPage10.Controls.Add(Me.Button1)
        Me.TabPage10.Controls.Add(Me.Label37)
        Me.TabPage10.Controls.Add(Me.PictureBox10)
        Me.TabPage10.Location = New System.Drawing.Point(4, 30)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(942, 643)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Contratos del trabajador"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'Contrato_FechaTermino
        '
        Me.Contrato_FechaTermino.Enabled = False
        Me.Contrato_FechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Contrato_FechaTermino.Location = New System.Drawing.Point(160, 351)
        Me.Contrato_FechaTermino.Name = "Contrato_FechaTermino"
        Me.Contrato_FechaTermino.Size = New System.Drawing.Size(121, 29)
        Me.Contrato_FechaTermino.TabIndex = 33
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(23, 351)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(116, 21)
        Me.Label43.TabIndex = 32
        Me.Label43.Text = "Fecha termino"
        '
        'ContratoDataGridView
        '
        Me.ContratoDataGridView.AutoGenerateColumns = False
        Me.ContratoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContratoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56})
        Me.ContratoDataGridView.DataSource = Me.ContratoBindingSource
        Me.ContratoDataGridView.Location = New System.Drawing.Point(287, 125)
        Me.ContratoDataGridView.Name = "ContratoDataGridView"
        Me.ContratoDataGridView.Size = New System.Drawing.Size(647, 220)
        Me.ContratoDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "fecha_inicio"
        Me.DataGridViewTextBoxColumn51.HeaderText = "fecha_inicio"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn52.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "horas"
        Me.DataGridViewTextBoxColumn53.HeaderText = "horas"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "fecha_termino"
        Me.DataGridViewTextBoxColumn54.HeaderText = "fecha_termino"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn55.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "id_cc"
        Me.DataGridViewTextBoxColumn56.HeaderText = "id_cc"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'ContratoBindingSource
        '
        Me.ContratoBindingSource.DataMember = "Contrato"
        Me.ContratoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'BdremuneracionDataSet
        '
        Me.BdremuneracionDataSet.DataSetName = "bdremuneracionDataSet"
        Me.BdremuneracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgregarContrato
        '
        Me.AgregarContrato.Enabled = False
        Me.AgregarContrato.Image = CType(resources.GetObject("AgregarContrato.Image"), System.Drawing.Image)
        Me.AgregarContrato.Location = New System.Drawing.Point(337, 351)
        Me.AgregarContrato.Name = "AgregarContrato"
        Me.AgregarContrato.Size = New System.Drawing.Size(70, 64)
        Me.AgregarContrato.TabIndex = 31
        Me.AgregarContrato.TabStop = False
        '
        'Contrato_Empresa
        '
        Me.Contrato_Empresa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpresaContratistaBindingSource, "nombre", True))
        Me.Contrato_Empresa.DataSource = Me.EmpresaContratistaBindingSource
        Me.Contrato_Empresa.DisplayMember = "nombre"
        Me.Contrato_Empresa.Enabled = False
        Me.Contrato_Empresa.FormattingEnabled = True
        Me.Contrato_Empresa.Location = New System.Drawing.Point(160, 252)
        Me.Contrato_Empresa.Name = "Contrato_Empresa"
        Me.Contrato_Empresa.Size = New System.Drawing.Size(121, 29)
        Me.Contrato_Empresa.TabIndex = 30
        Me.Contrato_Empresa.ValueMember = "id_empresa"
        '
        'EmpresaContratistaBindingSource
        '
        Me.EmpresaContratistaBindingSource.DataMember = "EmpresaContratista"
        Me.EmpresaContratistaBindingSource.DataSource = Me.BdremuneracionDataSet1
        '
        'BdremuneracionDataSet1
        '
        Me.BdremuneracionDataSet1.DataSetName = "bdremuneracionDataSet"
        Me.BdremuneracionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Contrato_CC
        '
        Me.Contrato_CC.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CentroCostoBindingSource, "nombre", True))
        Me.Contrato_CC.DataSource = Me.CentroCostoBindingSource
        Me.Contrato_CC.DisplayMember = "nombre"
        Me.Contrato_CC.Enabled = False
        Me.Contrato_CC.FormattingEnabled = True
        Me.Contrato_CC.Location = New System.Drawing.Point(160, 291)
        Me.Contrato_CC.Name = "Contrato_CC"
        Me.Contrato_CC.Size = New System.Drawing.Size(121, 29)
        Me.Contrato_CC.TabIndex = 29
        Me.Contrato_CC.ValueMember = "id_cc"
        '
        'CentroCostoBindingSource
        '
        Me.CentroCostoBindingSource.DataMember = "CentroCosto"
        Me.CentroCostoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Contratos_Tipo
        '
        Me.Contratos_Tipo.Enabled = False
        Me.Contratos_Tipo.FormattingEnabled = True
        Me.Contratos_Tipo.Location = New System.Drawing.Point(160, 210)
        Me.Contratos_Tipo.Name = "Contratos_Tipo"
        Me.Contratos_Tipo.Size = New System.Drawing.Size(121, 29)
        Me.Contratos_Tipo.TabIndex = 28
        '
        'Contrato_Fecha
        '
        Me.Contrato_Fecha.Enabled = False
        Me.Contrato_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Contrato_Fecha.Location = New System.Drawing.Point(160, 125)
        Me.Contrato_Fecha.Name = "Contrato_Fecha"
        Me.Contrato_Fecha.Size = New System.Drawing.Size(121, 29)
        Me.Contrato_Fecha.TabIndex = 27
        '
        'Contrato_Horas
        '
        Me.Contrato_Horas.Enabled = False
        Me.Contrato_Horas.Location = New System.Drawing.Point(160, 170)
        Me.Contrato_Horas.Name = "Contrato_Horas"
        Me.Contrato_Horas.Size = New System.Drawing.Size(121, 29)
        Me.Contrato_Horas.TabIndex = 26
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(23, 125)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(100, 21)
        Me.Label42.TabIndex = 25
        Me.Label42.Text = "Fecha inicio"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(23, 173)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(55, 21)
        Me.Label41.TabIndex = 24
        Me.Label41.Text = "Horas"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(23, 210)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(45, 21)
        Me.Label40.TabIndex = 23
        Me.Label40.Text = "Tipo"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(23, 255)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(75, 21)
        Me.Label39.TabIndex = 22
        Me.Label39.Text = "Empresa"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(23, 291)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(131, 21)
        Me.Label38.TabIndex = 21
        Me.Label38.Text = "Centro de costo"
        '
        'Contratos_BuscRut
        '
        Me.Contratos_BuscRut.Location = New System.Drawing.Point(256, 52)
        Me.Contratos_BuscRut.Name = "Contratos_BuscRut"
        Me.Contratos_BuscRut.Size = New System.Drawing.Size(180, 29)
        Me.Contratos_BuscRut.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(252, 28)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(196, 21)
        Me.Label37.TabIndex = 18
        Me.Label37.Text = "Ingrese rut del trabajador"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox10.TabIndex = 10
        Me.PictureBox10.TabStop = False
        '
        'TabPage9
        '
        Me.TabPage9.BackgroundImage = CType(resources.GetObject("TabPage9.BackgroundImage"), System.Drawing.Image)
        Me.TabPage9.Controls.Add(Me.AnexoDataGridView)
        Me.TabPage9.Controls.Add(Me.PictureBox9)
        Me.TabPage9.Controls.Add(Me.AgregarAnexo)
        Me.TabPage9.Controls.Add(Me.Anexo_CmbTipo)
        Me.TabPage9.Controls.Add(Me.Anexo_Fecha)
        Me.TabPage9.Controls.Add(Me.Anexo_Descripción)
        Me.TabPage9.Controls.Add(Me.Anexo_BuscRut)
        Me.TabPage9.Controls.Add(Me.Label36)
        Me.TabPage9.Controls.Add(Me.Label35)
        Me.TabPage9.Controls.Add(Me.Label34)
        Me.TabPage9.Controls.Add(Me.Button8)
        Me.TabPage9.Controls.Add(Me.Label28)
        Me.TabPage9.Location = New System.Drawing.Point(4, 30)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(942, 643)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Anexos del trabajador"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'AnexoDataGridView
        '
        Me.AnexoDataGridView.AutoGenerateColumns = False
        Me.AnexoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnexoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50})
        Me.AnexoDataGridView.DataSource = Me.AnexoBindingSource
        Me.AnexoDataGridView.Location = New System.Drawing.Point(452, 140)
        Me.AnexoDataGridView.Name = "AnexoDataGridView"
        Me.AnexoDataGridView.Size = New System.Drawing.Size(448, 220)
        Me.AnexoDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn46.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn47.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "fecha_anexo"
        Me.DataGridViewTextBoxColumn48.HeaderText = "fecha_anexo"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "fecha_inicio_contrato"
        Me.DataGridViewTextBoxColumn49.HeaderText = "fecha_inicio_contrato"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn50.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'AnexoBindingSource
        '
        Me.AnexoBindingSource.DataMember = "anexo"
        Me.AnexoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox9.TabIndex = 26
        Me.PictureBox9.TabStop = False
        '
        'AgregarAnexo
        '
        Me.AgregarAnexo.Enabled = False
        Me.AgregarAnexo.Image = CType(resources.GetObject("AgregarAnexo.Image"), System.Drawing.Image)
        Me.AgregarAnexo.Location = New System.Drawing.Point(220, 376)
        Me.AgregarAnexo.Name = "AgregarAnexo"
        Me.AgregarAnexo.Size = New System.Drawing.Size(70, 64)
        Me.AgregarAnexo.TabIndex = 25
        Me.AgregarAnexo.TabStop = False
        '
        'Anexo_CmbTipo
        '
        Me.Anexo_CmbTipo.Enabled = False
        Me.Anexo_CmbTipo.FormattingEnabled = True
        Me.Anexo_CmbTipo.Items.AddRange(New Object() {"Pacto de horas extra ordinarias", "Finiquito"})
        Me.Anexo_CmbTipo.Location = New System.Drawing.Point(208, 202)
        Me.Anexo_CmbTipo.Name = "Anexo_CmbTipo"
        Me.Anexo_CmbTipo.Size = New System.Drawing.Size(121, 29)
        Me.Anexo_CmbTipo.TabIndex = 24
        Me.Anexo_CmbTipo.Text = "Seleccione"
        '
        'Anexo_Fecha
        '
        Me.Anexo_Fecha.Enabled = False
        Me.Anexo_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Anexo_Fecha.Location = New System.Drawing.Point(208, 153)
        Me.Anexo_Fecha.Name = "Anexo_Fecha"
        Me.Anexo_Fecha.Size = New System.Drawing.Size(200, 29)
        Me.Anexo_Fecha.TabIndex = 23
        '
        'Anexo_Descripción
        '
        Me.Anexo_Descripción.Enabled = False
        Me.Anexo_Descripción.Location = New System.Drawing.Point(197, 264)
        Me.Anexo_Descripción.Name = "Anexo_Descripción"
        Me.Anexo_Descripción.Size = New System.Drawing.Size(193, 96)
        Me.Anexo_Descripción.TabIndex = 21
        Me.Anexo_Descripción.Text = ""
        '
        'Anexo_BuscRut
        '
        Me.Anexo_BuscRut.Location = New System.Drawing.Point(254, 41)
        Me.Anexo_BuscRut.Name = "Anexo_BuscRut"
        Me.Anexo_BuscRut.Size = New System.Drawing.Size(180, 29)
        Me.Anexo_BuscRut.TabIndex = 16
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(12, 153)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(190, 21)
        Me.Label36.TabIndex = 20
        Me.Label36.Text = "Fecha inicio de contrato"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(12, 202)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 21)
        Me.Label35.TabIndex = 19
        Me.Label35.Text = "Tipo"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(15, 280)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 21)
        Me.Label34.TabIndex = 18
        Me.Label34.Text = "Descripción"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(440, 41)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 27)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "Buscar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(250, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(196, 21)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Ingrese rut del trabajador"
        '
        'TabPage8
        '
        Me.TabPage8.BackgroundImage = CType(resources.GetObject("TabPage8.BackgroundImage"), System.Drawing.Image)
        Me.TabPage8.Controls.Add(Me.VacacionesDataGridView)
        Me.TabPage8.Controls.Add(Me.PictureBox8)
        Me.TabPage8.Controls.Add(Me.Vac_FechaTermino)
        Me.TabPage8.Controls.Add(Me.Label10)
        Me.TabPage8.Controls.Add(Me.AgregarVaciones)
        Me.TabPage8.Controls.Add(Me.Vac_FechaInicio)
        Me.TabPage8.Controls.Add(Me.Label9)
        Me.TabPage8.Controls.Add(Me.Button5)
        Me.TabPage8.Controls.Add(Me.Vac_buscar)
        Me.TabPage8.Controls.Add(Me.Label8)
        Me.TabPage8.Location = New System.Drawing.Point(4, 30)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(942, 643)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Vacaciones"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'VacacionesDataGridView
        '
        Me.VacacionesDataGridView.AutoGenerateColumns = False
        Me.VacacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VacacionesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45})
        Me.VacacionesDataGridView.DataSource = Me.VacacionesBindingSource
        Me.VacacionesDataGridView.Location = New System.Drawing.Point(205, 120)
        Me.VacacionesDataGridView.Name = "VacacionesDataGridView"
        Me.VacacionesDataGridView.Size = New System.Drawing.Size(343, 220)
        Me.VacacionesDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "fecha_inicio"
        Me.DataGridViewTextBoxColumn43.HeaderText = "fecha_inicio"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "fecha_termino"
        Me.DataGridViewTextBoxColumn44.HeaderText = "fecha_termino"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn45.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'VacacionesBindingSource
        '
        Me.VacacionesBindingSource.DataMember = "Vacaciones"
        Me.VacacionesBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox8.TabIndex = 23
        Me.PictureBox8.TabStop = False
        '
        'Vac_FechaTermino
        '
        Me.Vac_FechaTermino.Enabled = False
        Me.Vac_FechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Vac_FechaTermino.Location = New System.Drawing.Point(346, 394)
        Me.Vac_FechaTermino.Name = "Vac_FechaTermino"
        Me.Vac_FechaTermino.Size = New System.Drawing.Size(123, 29)
        Me.Vac_FechaTermino.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha de termino"
        '
        'AgregarVaciones
        '
        Me.AgregarVaciones.Enabled = False
        Me.AgregarVaciones.Image = CType(resources.GetObject("AgregarVaciones.Image"), System.Drawing.Image)
        Me.AgregarVaciones.Location = New System.Drawing.Point(502, 359)
        Me.AgregarVaciones.Name = "AgregarVaciones"
        Me.AgregarVaciones.Size = New System.Drawing.Size(70, 64)
        Me.AgregarVaciones.TabIndex = 20
        Me.AgregarVaciones.TabStop = False
        '
        'Vac_FechaInicio
        '
        Me.Vac_FechaInicio.Enabled = False
        Me.Vac_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Vac_FechaInicio.Location = New System.Drawing.Point(346, 359)
        Me.Vac_FechaInicio.Name = "Vac_FechaInicio"
        Me.Vac_FechaInicio.Size = New System.Drawing.Size(123, 29)
        Me.Vac_FechaInicio.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(201, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Fecha de inicio"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(497, 60)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 27)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Vac_buscar
        '
        Me.Vac_buscar.Location = New System.Drawing.Point(311, 60)
        Me.Vac_buscar.Name = "Vac_buscar"
        Me.Vac_buscar.Size = New System.Drawing.Size(180, 29)
        Me.Vac_buscar.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(196, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Ingrese rut del trabajador"
        '
        'TabPage7
        '
        Me.TabPage7.BackgroundImage = CType(resources.GetObject("TabPage7.BackgroundImage"), System.Drawing.Image)
        Me.TabPage7.Controls.Add(Me.CargaFamiliarDataGridView)
        Me.TabPage7.Controls.Add(Me.PictureBox7)
        Me.TabPage7.Controls.Add(Me.Carga_AM)
        Me.TabPage7.Controls.Add(Me.Carga_AP)
        Me.TabPage7.Controls.Add(Me.Carga_Nombre)
        Me.TabPage7.Controls.Add(Me.Carga_rutCarga)
        Me.TabPage7.Controls.Add(Me.Carga_buscar)
        Me.TabPage7.Controls.Add(Me.Carga_cmbCarga)
        Me.TabPage7.Controls.Add(Me.Carga_Fecha)
        Me.TabPage7.Controls.Add(Me.AgregarCarga)
        Me.TabPage7.Controls.Add(Me.Label33)
        Me.TabPage7.Controls.Add(Me.Label32)
        Me.TabPage7.Controls.Add(Me.Label31)
        Me.TabPage7.Controls.Add(Me.Label30)
        Me.TabPage7.Controls.Add(Me.Label29)
        Me.TabPage7.Controls.Add(Me.Label27)
        Me.TabPage7.Controls.Add(Me.Button7)
        Me.TabPage7.Controls.Add(Me.Label26)
        Me.TabPage7.Location = New System.Drawing.Point(4, 30)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(942, 643)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Carga familiar"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'CargaFamiliarDataGridView
        '
        Me.CargaFamiliarDataGridView.AutoGenerateColumns = False
        Me.CargaFamiliarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CargaFamiliarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42})
        Me.CargaFamiliarDataGridView.DataSource = Me.CargaFamiliarBindingSource
        Me.CargaFamiliarDataGridView.Location = New System.Drawing.Point(395, 131)
        Me.CargaFamiliarDataGridView.Name = "CargaFamiliarDataGridView"
        Me.CargaFamiliarDataGridView.Size = New System.Drawing.Size(497, 220)
        Me.CargaFamiliarDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "rut_carga"
        Me.DataGridViewTextBoxColumn38.HeaderText = "rut_carga"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "fecha_nac"
        Me.DataGridViewTextBoxColumn39.HeaderText = "fecha_nac"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "apellido_paterno"
        Me.DataGridViewTextBoxColumn40.HeaderText = "apellido_paterno"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "apellido_materno"
        Me.DataGridViewTextBoxColumn41.HeaderText = "apellido_materno"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn42.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'CargaFamiliarBindingSource
        '
        Me.CargaFamiliarBindingSource.DataMember = "CargaFamiliar"
        Me.CargaFamiliarBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox7.TabIndex = 36
        Me.PictureBox7.TabStop = False
        '
        'Carga_AM
        '
        Me.Carga_AM.Enabled = False
        Me.Carga_AM.Location = New System.Drawing.Point(221, 237)
        Me.Carga_AM.MaxLength = 3
        Me.Carga_AM.Name = "Carga_AM"
        Me.Carga_AM.Size = New System.Drawing.Size(121, 29)
        Me.Carga_AM.TabIndex = 35
        '
        'Carga_AP
        '
        Me.Carga_AP.Enabled = False
        Me.Carga_AP.Location = New System.Drawing.Point(221, 205)
        Me.Carga_AP.MaxLength = 3
        Me.Carga_AP.Name = "Carga_AP"
        Me.Carga_AP.Size = New System.Drawing.Size(121, 29)
        Me.Carga_AP.TabIndex = 34
        '
        'Carga_Nombre
        '
        Me.Carga_Nombre.Enabled = False
        Me.Carga_Nombre.Location = New System.Drawing.Point(221, 168)
        Me.Carga_Nombre.MaxLength = 3
        Me.Carga_Nombre.Name = "Carga_Nombre"
        Me.Carga_Nombre.Size = New System.Drawing.Size(121, 29)
        Me.Carga_Nombre.TabIndex = 33
        '
        'Carga_rutCarga
        '
        Me.Carga_rutCarga.Enabled = False
        Me.Carga_rutCarga.Location = New System.Drawing.Point(221, 131)
        Me.Carga_rutCarga.MaxLength = 3
        Me.Carga_rutCarga.Name = "Carga_rutCarga"
        Me.Carga_rutCarga.Size = New System.Drawing.Size(121, 29)
        Me.Carga_rutCarga.TabIndex = 32
        '
        'Carga_buscar
        '
        Me.Carga_buscar.Location = New System.Drawing.Point(288, 48)
        Me.Carga_buscar.Name = "Carga_buscar"
        Me.Carga_buscar.Size = New System.Drawing.Size(180, 29)
        Me.Carga_buscar.TabIndex = 19
        '
        'Carga_cmbCarga
        '
        Me.Carga_cmbCarga.Enabled = False
        Me.Carga_cmbCarga.FormattingEnabled = True
        Me.Carga_cmbCarga.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.Carga_cmbCarga.Location = New System.Drawing.Point(221, 311)
        Me.Carga_cmbCarga.Name = "Carga_cmbCarga"
        Me.Carga_cmbCarga.Size = New System.Drawing.Size(121, 29)
        Me.Carga_cmbCarga.TabIndex = 31
        '
        'Carga_Fecha
        '
        Me.Carga_Fecha.Enabled = False
        Me.Carga_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Carga_Fecha.Location = New System.Drawing.Point(221, 272)
        Me.Carga_Fecha.Name = "Carga_Fecha"
        Me.Carga_Fecha.Size = New System.Drawing.Size(121, 29)
        Me.Carga_Fecha.TabIndex = 30
        '
        'AgregarCarga
        '
        Me.AgregarCarga.Enabled = False
        Me.AgregarCarga.Image = CType(resources.GetObject("AgregarCarga.Image"), System.Drawing.Image)
        Me.AgregarCarga.Location = New System.Drawing.Point(46, 359)
        Me.AgregarCarga.Name = "AgregarCarga"
        Me.AgregarCarga.Size = New System.Drawing.Size(70, 64)
        Me.AgregarCarga.TabIndex = 28
        Me.AgregarCarga.TabStop = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(52, 168)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 21)
        Me.Label33.TabIndex = 27
        Me.Label33.Text = "Nombre"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(52, 205)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(134, 21)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "Apellido paterno"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(52, 239)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(138, 21)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Apellido materno"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(52, 272)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(163, 21)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "Fecha de nacimiento"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(52, 311)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(113, 21)
        Me.Label29.TabIndex = 23
        Me.Label29.Text = "Tipo de carga"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(52, 134)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 21)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Rut carga"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(474, 48)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 27)
        Me.Button7.TabIndex = 20
        Me.Button7.Text = "Buscar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(284, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(196, 21)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Ingrese rut del trabajador"
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.BackgroundImage = CType(resources.GetObject("TabPage6.BackgroundImage"), System.Drawing.Image)
        Me.TabPage6.Controls.Add(Me.PictureBox6)
        Me.TabPage6.Controls.Add(Me.Panel4)
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Controls.Add(Me.Button6)
        Me.TabPage6.Controls.Add(Me.txt_buscrut6)
        Me.TabPage6.Controls.Add(Me.Label11)
        Me.TabPage6.Location = New System.Drawing.Point(4, 30)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(942, 643)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Ingreso de horas"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox6.TabIndex = 20
        Me.PictureBox6.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.IngresoHorasDataGridView)
        Me.Panel4.Controls.Add(Me.TxtHorasTrabajadas)
        Me.Panel4.Controls.Add(Me.TxtNumFallas)
        Me.Panel4.Controls.Add(Me.TxtHorasExtras)
        Me.Panel4.Controls.Add(Me.TxtSobretiempo)
        Me.Panel4.Controls.Add(Me.cmb_Empresa)
        Me.Panel4.Controls.Add(Me.AgregarHoras)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Location = New System.Drawing.Point(76, 149)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(871, 409)
        Me.Panel4.TabIndex = 19
        '
        'IngresoHorasDataGridView
        '
        Me.IngresoHorasDataGridView.AutoGenerateColumns = False
        Me.IngresoHorasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngresoHorasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.IngresoHorasDataGridView.DataSource = Me.IngresoHorasBindingSource
        Me.IngresoHorasDataGridView.Location = New System.Drawing.Point(330, 28)
        Me.IngresoHorasDataGridView.Name = "IngresoHorasDataGridView"
        Me.IngresoHorasDataGridView.Size = New System.Drawing.Size(451, 220)
        Me.IngresoHorasDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn31.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "horas_trabajadas"
        Me.DataGridViewTextBoxColumn32.HeaderText = "horas_trabajadas"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "fallas"
        Me.DataGridViewTextBoxColumn33.HeaderText = "fallas"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "sobre_tiempo"
        Me.DataGridViewTextBoxColumn34.HeaderText = "sobre_tiempo"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn35.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "id_empresa"
        Me.DataGridViewTextBoxColumn36.HeaderText = "id_empresa"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "horas_extras"
        Me.DataGridViewTextBoxColumn37.HeaderText = "horas_extras"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'IngresoHorasBindingSource
        '
        Me.IngresoHorasBindingSource.DataMember = "IngresoHoras"
        Me.IngresoHorasBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'TxtHorasTrabajadas
        '
        Me.TxtHorasTrabajadas.Enabled = False
        Me.TxtHorasTrabajadas.Location = New System.Drawing.Point(172, 28)
        Me.TxtHorasTrabajadas.MaxLength = 3
        Me.TxtHorasTrabajadas.Name = "TxtHorasTrabajadas"
        Me.TxtHorasTrabajadas.Size = New System.Drawing.Size(121, 29)
        Me.TxtHorasTrabajadas.TabIndex = 29
        '
        'TxtNumFallas
        '
        Me.TxtNumFallas.Enabled = False
        Me.TxtNumFallas.Location = New System.Drawing.Point(172, 76)
        Me.TxtNumFallas.MaxLength = 3
        Me.TxtNumFallas.Name = "TxtNumFallas"
        Me.TxtNumFallas.Size = New System.Drawing.Size(121, 29)
        Me.TxtNumFallas.TabIndex = 28
        '
        'TxtHorasExtras
        '
        Me.TxtHorasExtras.Enabled = False
        Me.TxtHorasExtras.Location = New System.Drawing.Point(172, 121)
        Me.TxtHorasExtras.MaxLength = 3
        Me.TxtHorasExtras.Name = "TxtHorasExtras"
        Me.TxtHorasExtras.Size = New System.Drawing.Size(121, 29)
        Me.TxtHorasExtras.TabIndex = 27
        '
        'TxtSobretiempo
        '
        Me.TxtSobretiempo.Enabled = False
        Me.TxtSobretiempo.Location = New System.Drawing.Point(172, 171)
        Me.TxtSobretiempo.MaxLength = 3
        Me.TxtSobretiempo.Name = "TxtSobretiempo"
        Me.TxtSobretiempo.Size = New System.Drawing.Size(121, 29)
        Me.TxtSobretiempo.TabIndex = 26
        '
        'cmb_Empresa
        '
        Me.cmb_Empresa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpresaContratistaBindingSource, "nombre", True))
        Me.cmb_Empresa.DataSource = Me.EmpresaContratistaBindingSource
        Me.cmb_Empresa.DisplayMember = "nombre"
        Me.cmb_Empresa.Enabled = False
        Me.cmb_Empresa.FormattingEnabled = True
        Me.cmb_Empresa.Location = New System.Drawing.Point(172, 211)
        Me.cmb_Empresa.Name = "cmb_Empresa"
        Me.cmb_Empresa.Size = New System.Drawing.Size(121, 29)
        Me.cmb_Empresa.TabIndex = 25
        Me.cmb_Empresa.ValueMember = "id_empresa"
        '
        'AgregarHoras
        '
        Me.AgregarHoras.Enabled = False
        Me.AgregarHoras.Image = CType(resources.GetObject("AgregarHoras.Image"), System.Drawing.Image)
        Me.AgregarHoras.Location = New System.Drawing.Point(134, 269)
        Me.AgregarHoras.Name = "AgregarHoras"
        Me.AgregarHoras.Size = New System.Drawing.Size(70, 64)
        Me.AgregarHoras.TabIndex = 24
        Me.AgregarHoras.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 21)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Numero de fallas"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(24, 124)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 21)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Horas extras"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(24, 171)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(111, 21)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Sobre tiempo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(24, 219)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 21)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Empresa "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(24, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(135, 21)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Horas trabajadas"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(72, 125)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 21)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Fecha"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(376, 55)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 27)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Buscar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txt_buscrut6
        '
        Me.txt_buscrut6.Location = New System.Drawing.Point(190, 55)
        Me.txt_buscrut6.Name = "txt_buscrut6"
        Me.txt_buscrut6.Size = New System.Drawing.Size(180, 29)
        Me.txt_buscrut6.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(186, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 21)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Ingrese rut del trabajador"
        '
        'TabPage5
        '
        Me.TabPage5.BackgroundImage = CType(resources.GetObject("TabPage5.BackgroundImage"), System.Drawing.Image)
        Me.TabPage5.Controls.Add(Me.PictureBox5)
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.Panel3)
        Me.TabPage5.Controls.Add(Me.Button3)
        Me.TabPage5.Controls.Add(Me.txt_buscrut4)
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Location = New System.Drawing.Point(4, 30)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(942, 643)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Finiquitos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(238, 390)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(271, 44)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Imprimir finiquito del trabajador"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.FiniquitoDataGridView)
        Me.Panel3.Controls.Add(Me.AgregarFiniquito)
        Me.Panel3.Controls.Add(Me.RichCausal)
        Me.Panel3.Controls.Add(Me.FechaFiniquito)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Location = New System.Drawing.Point(38, 121)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(765, 392)
        Me.Panel3.TabIndex = 12
        '
        'FiniquitoDataGridView
        '
        Me.FiniquitoDataGridView.AutoGenerateColumns = False
        Me.FiniquitoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.FiniquitoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FiniquitoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.FiniquitoDataGridView.DataSource = Me.FiniquitoBindingSource
        Me.FiniquitoDataGridView.Location = New System.Drawing.Point(306, 26)
        Me.FiniquitoDataGridView.Name = "FiniquitoDataGridView"
        Me.FiniquitoDataGridView.Size = New System.Drawing.Size(410, 220)
        Me.FiniquitoDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn27.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn28.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "causal"
        Me.DataGridViewTextBoxColumn29.HeaderText = "causal"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn30.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'FiniquitoBindingSource
        '
        Me.FiniquitoBindingSource.DataMember = "Finiquito"
        Me.FiniquitoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'AgregarFiniquito
        '
        Me.AgregarFiniquito.Enabled = False
        Me.AgregarFiniquito.Image = CType(resources.GetObject("AgregarFiniquito.Image"), System.Drawing.Image)
        Me.AgregarFiniquito.Location = New System.Drawing.Point(101, 170)
        Me.AgregarFiniquito.Name = "AgregarFiniquito"
        Me.AgregarFiniquito.Size = New System.Drawing.Size(70, 64)
        Me.AgregarFiniquito.TabIndex = 17
        Me.AgregarFiniquito.TabStop = False
        '
        'RichCausal
        '
        Me.RichCausal.Enabled = False
        Me.RichCausal.Location = New System.Drawing.Point(101, 68)
        Me.RichCausal.Name = "RichCausal"
        Me.RichCausal.Size = New System.Drawing.Size(178, 96)
        Me.RichCausal.TabIndex = 11
        Me.RichCausal.Text = ""
        '
        'FechaFiniquito
        '
        Me.FechaFiniquito.Enabled = False
        Me.FechaFiniquito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFiniquito.Location = New System.Drawing.Point(101, 26)
        Me.FechaFiniquito.Name = "FechaFiniquito"
        Me.FechaFiniquito.Size = New System.Drawing.Size(123, 29)
        Me.FechaFiniquito.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(25, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 21)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Causal"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(25, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 21)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Fecha"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(434, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 27)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_buscrut4
        '
        Me.txt_buscrut4.Location = New System.Drawing.Point(248, 54)
        Me.txt_buscrut4.Name = "txt_buscrut4"
        Me.txt_buscrut4.Size = New System.Drawing.Size(180, 29)
        Me.txt_buscrut4.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Ingrese rut del trabajador"
        '
        'TabPage4
        '
        Me.TabPage4.BackgroundImage = CType(resources.GetObject("TabPage4.BackgroundImage"), System.Drawing.Image)
        Me.TabPage4.Controls.Add(Me.AnticiposDataGridView)
        Me.TabPage4.Controls.Add(Me.PictureBox3)
        Me.TabPage4.Controls.Add(Me.AgregarAnticipo)
        Me.TabPage4.Controls.Add(Me.TxtMontoAnticipo)
        Me.TabPage4.Controls.Add(Me.txt_buscrut3)
        Me.TabPage4.Controls.Add(Me.cmb_moneda)
        Me.TabPage4.Controls.Add(Me.FechaAnticipo)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(942, 643)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Anticipos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'AnticiposDataGridView
        '
        Me.AnticiposDataGridView.AutoGenerateColumns = False
        Me.AnticiposDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.AnticiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnticiposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.AnticiposDataGridView.DataSource = Me.AnticiposBindingSource
        Me.AnticiposDataGridView.Location = New System.Drawing.Point(216, 241)
        Me.AnticiposDataGridView.Name = "AnticiposDataGridView"
        Me.AnticiposDataGridView.Size = New System.Drawing.Size(344, 220)
        Me.AnticiposDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn24.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn25.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn26.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'AnticiposBindingSource
        '
        Me.AnticiposBindingSource.DataMember = "Anticipos"
        Me.AnticiposBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'AgregarAnticipo
        '
        Me.AgregarAnticipo.Enabled = False
        Me.AgregarAnticipo.Image = CType(resources.GetObject("AgregarAnticipo.Image"), System.Drawing.Image)
        Me.AgregarAnticipo.Location = New System.Drawing.Point(597, 170)
        Me.AgregarAnticipo.Name = "AgregarAnticipo"
        Me.AgregarAnticipo.Size = New System.Drawing.Size(70, 64)
        Me.AgregarAnticipo.TabIndex = 16
        Me.AgregarAnticipo.TabStop = False
        '
        'TxtMontoAnticipo
        '
        Me.TxtMontoAnticipo.Enabled = False
        Me.TxtMontoAnticipo.Location = New System.Drawing.Point(457, 184)
        Me.TxtMontoAnticipo.Name = "TxtMontoAnticipo"
        Me.TxtMontoAnticipo.Size = New System.Drawing.Size(103, 29)
        Me.TxtMontoAnticipo.TabIndex = 14
        Me.TxtMontoAnticipo.Text = "0.00"
        Me.TxtMontoAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_buscrut3
        '
        Me.txt_buscrut3.Location = New System.Drawing.Point(216, 59)
        Me.txt_buscrut3.Name = "txt_buscrut3"
        Me.txt_buscrut3.Size = New System.Drawing.Size(180, 29)
        Me.txt_buscrut3.TabIndex = 7
        '
        'cmb_moneda
        '
        Me.cmb_moneda.Enabled = False
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(329, 187)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(79, 29)
        Me.cmb_moneda.TabIndex = 13
        '
        'FechaAnticipo
        '
        Me.FechaAnticipo.Enabled = False
        Me.FechaAnticipo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaAnticipo.Location = New System.Drawing.Point(147, 184)
        Me.FechaAnticipo.Name = "FechaAnticipo"
        Me.FechaAnticipo.Size = New System.Drawing.Size(123, 29)
        Me.FechaAnticipo.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(478, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 21)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Monto "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(325, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 21)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Moneda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(143, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 21)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Fecha"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(402, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ingrese rut del trabajador"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.LicenciaMedicaDataGridView)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.AgregarLicencia)
        Me.TabPage3.Controls.Add(Me.RichMotivo)
        Me.TabPage3.Controls.Add(Me.txt_buscrut2)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.FechaTermino)
        Me.TabPage3.Controls.Add(Me.FechaInicio)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txt_buscar2)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(942, 643)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Licencias"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LicenciaMedicaDataGridView
        '
        Me.LicenciaMedicaDataGridView.AutoGenerateColumns = False
        Me.LicenciaMedicaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.LicenciaMedicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LicenciaMedicaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.LicenciaMedicaDataGridView.DataSource = Me.LicenciaMedicaBindingSource
        Me.LicenciaMedicaDataGridView.Location = New System.Drawing.Point(142, 319)
        Me.LicenciaMedicaDataGridView.Name = "LicenciaMedicaDataGridView"
        Me.LicenciaMedicaDataGridView.Size = New System.Drawing.Size(443, 186)
        Me.LicenciaMedicaDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "fecha_inicio"
        Me.DataGridViewTextBoxColumn20.HeaderText = "fecha_inicio"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn21.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "fecha_termino"
        Me.DataGridViewTextBoxColumn22.HeaderText = "fecha_termino"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "motivo"
        Me.DataGridViewTextBoxColumn23.HeaderText = "motivo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'LicenciaMedicaBindingSource
        '
        Me.LicenciaMedicaBindingSource.DataMember = "LicenciaMedica"
        Me.LicenciaMedicaBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'AgregarLicencia
        '
        Me.AgregarLicencia.Enabled = False
        Me.AgregarLicencia.Image = CType(resources.GetObject("AgregarLicencia.Image"), System.Drawing.Image)
        Me.AgregarLicencia.Location = New System.Drawing.Point(441, 166)
        Me.AgregarLicencia.Name = "AgregarLicencia"
        Me.AgregarLicencia.Size = New System.Drawing.Size(70, 64)
        Me.AgregarLicencia.TabIndex = 13
        Me.AgregarLicencia.TabStop = False
        '
        'RichMotivo
        '
        Me.RichMotivo.Enabled = False
        Me.RichMotivo.Location = New System.Drawing.Point(235, 254)
        Me.RichMotivo.Name = "RichMotivo"
        Me.RichMotivo.Size = New System.Drawing.Size(276, 59)
        Me.RichMotivo.TabIndex = 11
        Me.RichMotivo.Text = ""
        '
        'txt_buscrut2
        '
        Me.txt_buscrut2.Location = New System.Drawing.Point(216, 56)
        Me.txt_buscrut2.Name = "txt_buscrut2"
        Me.txt_buscrut2.Size = New System.Drawing.Size(180, 29)
        Me.txt_buscrut2.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(147, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 21)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Motivo"
        '
        'FechaTermino
        '
        Me.FechaTermino.Enabled = False
        Me.FechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaTermino.Location = New System.Drawing.Point(235, 201)
        Me.FechaTermino.Name = "FechaTermino"
        Me.FechaTermino.Size = New System.Drawing.Size(123, 29)
        Me.FechaTermino.TabIndex = 9
        '
        'FechaInicio
        '
        Me.FechaInicio.Enabled = False
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(235, 147)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(123, 29)
        Me.FechaInicio.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(147, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 21)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Hasta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(147, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 21)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Desde"
        '
        'txt_buscar2
        '
        Me.txt_buscar2.Location = New System.Drawing.Point(422, 58)
        Me.txt_buscar2.Name = "txt_buscar2"
        Me.txt_buscar2.Size = New System.Drawing.Size(75, 27)
        Me.txt_buscar2.TabIndex = 5
        Me.txt_buscar2.Text = "Buscar"
        Me.txt_buscar2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ingrese rut del trabajador"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.Descuentos_liquidacionDataGridView)
        Me.TabPage2.Controls.Add(Me.Haber_liquidacionDataGridView)
        Me.TabPage2.Controls.Add(Me.PictureBox11)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.btn_buscarHB)
        Me.TabPage2.Controls.Add(Me.txt_hdrut)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(942, 643)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Haberes y descuentos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Descuentos_liquidacionDataGridView
        '
        Me.Descuentos_liquidacionDataGridView.AutoGenerateColumns = False
        Me.Descuentos_liquidacionDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Descuentos_liquidacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Descuentos_liquidacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Descuentos_liquidacionDataGridView.DataSource = Me.Descuentos_liquidacionBindingSource
        Me.Descuentos_liquidacionDataGridView.Location = New System.Drawing.Point(416, 304)
        Me.Descuentos_liquidacionDataGridView.Name = "Descuentos_liquidacionDataGridView"
        Me.Descuentos_liquidacionDataGridView.Size = New System.Drawing.Size(347, 157)
        Me.Descuentos_liquidacionDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn7.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Descuentos_liquidacionBindingSource
        '
        Me.Descuentos_liquidacionBindingSource.DataMember = "descuentos_liquidacion"
        Me.Descuentos_liquidacionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Haber_liquidacionDataGridView
        '
        Me.Haber_liquidacionDataGridView.AutoGenerateColumns = False
        Me.Haber_liquidacionDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Haber_liquidacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Haber_liquidacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Haber_liquidacionDataGridView.DataSource = Me.Haber_liquidacionBindingSource
        Me.Haber_liquidacionDataGridView.Location = New System.Drawing.Point(28, 303)
        Me.Haber_liquidacionDataGridView.Name = "Haber_liquidacionDataGridView"
        Me.Haber_liquidacionDataGridView.Size = New System.Drawing.Size(351, 158)
        Me.Haber_liquidacionDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn3.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "monto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "monto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Haber_liquidacionBindingSource
        '
        Me.Haber_liquidacionBindingSource.DataMember = "haber_liquidacion"
        Me.Haber_liquidacionBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox11.TabIndex = 9
        Me.PictureBox11.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.picDescuentos)
        Me.Panel2.Controls.Add(Me.txt_montoDescuento)
        Me.Panel2.Controls.Add(Me.cmb_descuento)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(416, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 190)
        Me.Panel2.TabIndex = 4
        '
        'picDescuentos
        '
        Me.picDescuentos.Enabled = False
        Me.picDescuentos.Image = CType(resources.GetObject("picDescuentos.Image"), System.Drawing.Image)
        Me.picDescuentos.Location = New System.Drawing.Point(139, 82)
        Me.picDescuentos.Name = "picDescuentos"
        Me.picDescuentos.Size = New System.Drawing.Size(70, 64)
        Me.picDescuentos.TabIndex = 7
        Me.picDescuentos.TabStop = False
        '
        'txt_montoDescuento
        '
        Me.txt_montoDescuento.Enabled = False
        Me.txt_montoDescuento.Location = New System.Drawing.Point(191, 34)
        Me.txt_montoDescuento.MaxLength = 6
        Me.txt_montoDescuento.Name = "txt_montoDescuento"
        Me.txt_montoDescuento.Size = New System.Drawing.Size(103, 29)
        Me.txt_montoDescuento.TabIndex = 5
        Me.txt_montoDescuento.Text = "0.00"
        Me.txt_montoDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_descuento
        '
        Me.cmb_descuento.DataSource = Me.DescuentosBindingSource
        Me.cmb_descuento.DisplayMember = "nombre"
        Me.cmb_descuento.Enabled = False
        Me.cmb_descuento.FormattingEnabled = True
        Me.cmb_descuento.Location = New System.Drawing.Point(3, 34)
        Me.cmb_descuento.Name = "cmb_descuento"
        Me.cmb_descuento.Size = New System.Drawing.Size(146, 29)
        Me.cmb_descuento.TabIndex = 4
        Me.cmb_descuento.ValueMember = "id"
        '
        'DescuentosBindingSource
        '
        Me.DescuentosBindingSource.DataMember = "Descuentos"
        Me.DescuentosBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Descuento"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.picHaber)
        Me.Panel1.Controls.Add(Me.txt_montoHaber)
        Me.Panel1.Controls.Add(Me.cmb_haber)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(28, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 190)
        Me.Panel1.TabIndex = 3
        '
        'picHaber
        '
        Me.picHaber.Enabled = False
        Me.picHaber.Image = CType(resources.GetObject("picHaber.Image"), System.Drawing.Image)
        Me.picHaber.Location = New System.Drawing.Point(136, 90)
        Me.picHaber.Name = "picHaber"
        Me.picHaber.Size = New System.Drawing.Size(70, 64)
        Me.picHaber.TabIndex = 4
        Me.picHaber.TabStop = False
        '
        'txt_montoHaber
        '
        Me.txt_montoHaber.Enabled = False
        Me.txt_montoHaber.Location = New System.Drawing.Point(196, 39)
        Me.txt_montoHaber.MaxLength = 6
        Me.txt_montoHaber.Name = "txt_montoHaber"
        Me.txt_montoHaber.Size = New System.Drawing.Size(103, 29)
        Me.txt_montoHaber.TabIndex = 3
        Me.txt_montoHaber.Text = "0.00"
        Me.txt_montoHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_haber
        '
        Me.cmb_haber.DataSource = Me.HaberesBindingSource
        Me.cmb_haber.DisplayMember = "nombre"
        Me.cmb_haber.Enabled = False
        Me.cmb_haber.FormattingEnabled = True
        Me.cmb_haber.Location = New System.Drawing.Point(3, 39)
        Me.cmb_haber.Name = "cmb_haber"
        Me.cmb_haber.Size = New System.Drawing.Size(146, 29)
        Me.cmb_haber.TabIndex = 2
        Me.cmb_haber.ValueMember = "id"
        '
        'HaberesBindingSource
        '
        Me.HaberesBindingSource.DataMember = "Haberes"
        Me.HaberesBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Haberes"
        '
        'btn_buscarHB
        '
        Me.btn_buscarHB.Location = New System.Drawing.Point(442, 49)
        Me.btn_buscarHB.Name = "btn_buscarHB"
        Me.btn_buscarHB.Size = New System.Drawing.Size(75, 27)
        Me.btn_buscarHB.TabIndex = 1
        Me.btn_buscarHB.Text = "Buscar"
        Me.btn_buscarHB.UseVisualStyleBackColor = True
        '
        'txt_hdrut
        '
        Me.txt_hdrut.Location = New System.Drawing.Point(256, 49)
        Me.txt_hdrut.Name = "txt_hdrut"
        Me.txt_hdrut.Size = New System.Drawing.Size(180, 29)
        Me.txt_hdrut.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ingrese rut del trabajador"
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.TrabajadorDataGridView)
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Controls.Add(Me.Texto)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(942, 643)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inicio"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TrabajadorDataGridView
        '
        Me.TrabajadorDataGridView.AutoGenerateColumns = False
        Me.TrabajadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrabajadorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.TrabajadorDataGridView.DataSource = Me.TrabajadorBindingSource
        Me.TrabajadorDataGridView.Location = New System.Drawing.Point(222, 430)
        Me.TrabajadorDataGridView.Name = "TrabajadorDataGridView"
        Me.TrabajadorDataGridView.Size = New System.Drawing.Size(300, 67)
        Me.TrabajadorDataGridView.TabIndex = 11
        Me.TrabajadorDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "rut"
        Me.DataGridViewTextBoxColumn9.HeaderText = "rut"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn10.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "apellido_paterno"
        Me.DataGridViewTextBoxColumn11.HeaderText = "apellido_paterno"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "apellido_materno"
        Me.DataGridViewTextBoxColumn12.HeaderText = "apellido_materno"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "estado_civil"
        Me.DataGridViewTextBoxColumn13.HeaderText = "estado_civil"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "sexo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn16.HeaderText = "fecha_nacimiento"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "estado"
        Me.DataGridViewTextBoxColumn17.HeaderText = "estado"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "cod_cargo"
        Me.DataGridViewTextBoxColumn18.HeaderText = "cod_cargo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn19.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'TrabajadorBindingSource
        '
        Me.TrabajadorBindingSource.DataMember = "trabajador"
        Me.TrabajadorBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(869, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 71)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Texto
        '
        Me.Texto.BackColor = System.Drawing.SystemColors.Info
        Me.Texto.Enabled = False
        Me.Texto.Location = New System.Drawing.Point(135, 110)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(593, 314)
        Me.Texto.TabIndex = 8
        Me.Texto.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EVENTOS"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(950, 677)
        Me.TabControl1.TabIndex = 8
        '
        'HaberesTableAdapter
        '
        Me.HaberesTableAdapter.ClearBeforeFill = True
        '
        'DescuentosTableAdapter
        '
        Me.DescuentosTableAdapter.ClearBeforeFill = True
        '
        'Haber_liquidacionTableAdapter
        '
        Me.Haber_liquidacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.anexoTableAdapter = Nothing
        Me.TableAdapterManager.AnticiposTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bancoTableAdapter = Nothing
        Me.TableAdapterManager.CargaFamiliarTableAdapter = Nothing
        Me.TableAdapterManager.cc_trabajadorTableAdapter = Nothing
        Me.TableAdapterManager.CentroCostoTableAdapter = Nothing
        Me.TableAdapterManager.ContratoTableAdapter = Nothing
        Me.TableAdapterManager.cuenta_bancariaTableAdapter = Nothing
        Me.TableAdapterManager.descuentos_liquidacionTableAdapter = Me.Descuentos_liquidacionTableAdapter
        Me.TableAdapterManager.DescuentosTableAdapter = Me.DescuentosTableAdapter
        Me.TableAdapterManager.EmpresaContratistaTableAdapter = Nothing
        Me.TableAdapterManager.FiniquitoTableAdapter = Nothing
        Me.TableAdapterManager.haber_liquidacionTableAdapter = Me.Haber_liquidacionTableAdapter
        Me.TableAdapterManager.HaberesTableAdapter = Me.HaberesTableAdapter
        Me.TableAdapterManager.IngresoHorasTableAdapter = Nothing
        Me.TableAdapterManager.LicenciaMedicaTableAdapter = Nothing
        Me.TableAdapterManager.LiquidacionTableAdapter = Nothing
        Me.TableAdapterManager.OficioTableAdapter = Nothing
        Me.TableAdapterManager.OrganismoPrevisionTableAdapter = Nothing
        Me.TableAdapterManager.OrganismoSaludTableAdapter = Nothing
        Me.TableAdapterManager.parametrosTableAdapter = Nothing
        Me.TableAdapterManager.SeguroCesantiaTableAdapter = Nothing
        Me.TableAdapterManager.TasasPrevisionalesTableAdapter = Nothing
        Me.TableAdapterManager.trabajador_previsionTableAdapter = Nothing
        Me.TableAdapterManager.trabajador_saludTableAdapter = Nothing
        Me.TableAdapterManager.trabajadorTableAdapter = Nothing
        Me.TableAdapterManager.TramosAsigFamiliarTableAdapter = Nothing
        Me.TableAdapterManager.TramosIUTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = R.bdremuneracionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacacionesTableAdapter = Nothing
        '
        'Descuentos_liquidacionTableAdapter
        '
        Me.Descuentos_liquidacionTableAdapter.ClearBeforeFill = True
        '
        'TrabajadorTableAdapter
        '
        Me.TrabajadorTableAdapter.ClearBeforeFill = True
        '
        'LicenciaMedicaTableAdapter
        '
        Me.LicenciaMedicaTableAdapter.ClearBeforeFill = True
        '
        'AnticiposTableAdapter
        '
        Me.AnticiposTableAdapter.ClearBeforeFill = True
        '
        'FiniquitoTableAdapter
        '
        Me.FiniquitoTableAdapter.ClearBeforeFill = True
        '
        'IngresoHorasTableAdapter
        '
        Me.IngresoHorasTableAdapter.ClearBeforeFill = True
        '
        'EmpresaContratistaTableAdapter
        '
        Me.EmpresaContratistaTableAdapter.ClearBeforeFill = True
        '
        'CargaFamiliarTableAdapter
        '
        Me.CargaFamiliarTableAdapter.ClearBeforeFill = True
        '
        'VacacionesTableAdapter
        '
        Me.VacacionesTableAdapter.ClearBeforeFill = True
        '
        'AnexoTableAdapter
        '
        Me.AnexoTableAdapter.ClearBeforeFill = True
        '
        'CentroCostoTableAdapter
        '
        Me.CentroCostoTableAdapter.ClearBeforeFill = True
        '
        'ContratoTableAdapter
        '
        Me.ContratoTableAdapter.ClearBeforeFill = True
        '
        'Eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(946, 547)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Eventos"
        Me.Text = "JVRMONTAJES"
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        CType(Me.ContratoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaContratistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdremuneracionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.AnexoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.VacacionesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarVaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.CargaFamiliarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargaFamiliarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.IngresoHorasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoHorasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.FiniquitoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FiniquitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarFiniquito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.AnticiposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnticiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.LicenciaMedicaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicenciaMedicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgregarLicencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Descuentos_liquidacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Descuentos_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Haber_liquidacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Haber_liquidacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picHaber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HaberesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TrabajadorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents AgregarAnexo As System.Windows.Forms.PictureBox
    Friend WithEvents Anexo_CmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Anexo_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Anexo_Descripción As System.Windows.Forms.RichTextBox
    Friend WithEvents Anexo_BuscRut As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents Vac_FechaTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AgregarVaciones As System.Windows.Forms.PictureBox
    Friend WithEvents Vac_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Vac_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Carga_AM As System.Windows.Forms.TextBox
    Friend WithEvents Carga_AP As System.Windows.Forms.TextBox
    Friend WithEvents Carga_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Carga_rutCarga As System.Windows.Forms.TextBox
    Friend WithEvents Carga_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Carga_cmbCarga As System.Windows.Forms.ComboBox
    Friend WithEvents Carga_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents AgregarCarga As System.Windows.Forms.PictureBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TxtHorasTrabajadas As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumFallas As System.Windows.Forms.TextBox
    Friend WithEvents TxtHorasExtras As System.Windows.Forms.TextBox
    Friend WithEvents TxtSobretiempo As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Empresa As System.Windows.Forms.ComboBox
    Friend WithEvents AgregarHoras As System.Windows.Forms.PictureBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txt_buscrut6 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AgregarFiniquito As System.Windows.Forms.PictureBox
    Friend WithEvents RichCausal As System.Windows.Forms.RichTextBox
    Friend WithEvents FechaFiniquito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_buscrut4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents AgregarAnticipo As System.Windows.Forms.PictureBox
    Friend WithEvents TxtMontoAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents txt_buscrut3 As System.Windows.Forms.TextBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents FechaAnticipo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents AgregarLicencia As System.Windows.Forms.PictureBox
    Friend WithEvents RichMotivo As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_buscrut2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents FechaTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents picDescuentos As System.Windows.Forms.PictureBox
    Friend WithEvents txt_montoDescuento As System.Windows.Forms.TextBox
    Friend WithEvents cmb_descuento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picHaber As System.Windows.Forms.PictureBox
    Friend WithEvents txt_montoHaber As System.Windows.Forms.TextBox
    Friend WithEvents cmb_haber As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_buscarHB As System.Windows.Forms.Button
    Friend WithEvents txt_hdrut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Texto As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents AgregarContrato As System.Windows.Forms.PictureBox
    Friend WithEvents Contrato_Empresa As System.Windows.Forms.ComboBox
    Friend WithEvents Contrato_CC As System.Windows.Forms.ComboBox
    Friend WithEvents Contratos_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Contrato_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Contrato_Horas As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Contratos_BuscRut As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BdremuneracionDataSet As R.bdremuneracionDataSet
    Friend WithEvents HaberesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HaberesTableAdapter As R.bdremuneracionDataSetTableAdapters.HaberesTableAdapter
    Friend WithEvents DescuentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescuentosTableAdapter As R.bdremuneracionDataSetTableAdapters.DescuentosTableAdapter
    Friend WithEvents Haber_liquidacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Haber_liquidacionTableAdapter As R.bdremuneracionDataSetTableAdapters.haber_liquidacionTableAdapter
    Friend WithEvents TableAdapterManager As R.bdremuneracionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Haber_liquidacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuentos_liquidacionTableAdapter As R.bdremuneracionDataSetTableAdapters.descuentos_liquidacionTableAdapter
    Friend WithEvents Descuentos_liquidacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Descuentos_liquidacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TrabajadorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrabajadorTableAdapter As R.bdremuneracionDataSetTableAdapters.trabajadorTableAdapter
    Friend WithEvents TrabajadorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LicenciaMedicaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LicenciaMedicaTableAdapter As R.bdremuneracionDataSetTableAdapters.LicenciaMedicaTableAdapter
    Friend WithEvents LicenciaMedicaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnticiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnticiposTableAdapter As R.bdremuneracionDataSetTableAdapters.AnticiposTableAdapter
    Friend WithEvents AnticiposDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiniquitoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FiniquitoTableAdapter As R.bdremuneracionDataSetTableAdapters.FiniquitoTableAdapter
    Friend WithEvents FiniquitoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngresoHorasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IngresoHorasTableAdapter As R.bdremuneracionDataSetTableAdapters.IngresoHorasTableAdapter
    Friend WithEvents IngresoHorasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BdremuneracionDataSet1 As R.bdremuneracionDataSet
    Friend WithEvents EmpresaContratistaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresaContratistaTableAdapter As R.bdremuneracionDataSetTableAdapters.EmpresaContratistaTableAdapter
    Friend WithEvents CargaFamiliarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CargaFamiliarTableAdapter As R.bdremuneracionDataSetTableAdapters.CargaFamiliarTableAdapter
    Friend WithEvents CargaFamiliarDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VacacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VacacionesTableAdapter As R.bdremuneracionDataSetTableAdapters.VacacionesTableAdapter
    Friend WithEvents VacacionesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnexoTableAdapter As R.bdremuneracionDataSetTableAdapters.anexoTableAdapter
    Friend WithEvents AnexoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CentroCostoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CentroCostoTableAdapter As R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter
    Friend WithEvents ContratoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContratoTableAdapter As R.bdremuneracionDataSetTableAdapters.ContratoTableAdapter
    Friend WithEvents ContratoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contrato_FechaTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label43 As System.Windows.Forms.Label
End Class
