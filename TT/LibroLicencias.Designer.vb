<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibroLicencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibroLicencias))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BdremuneracionDataSet = New R.bdremuneracionDataSet()
        Me.LicenciaMedicaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LicenciaMedicaTableAdapter = New R.bdremuneracionDataSetTableAdapters.LicenciaMedicaTableAdapter()
        Me.TableAdapterManager = New R.bdremuneracionDataSetTableAdapters.TableAdapterManager()
        Me.LicenciaMedicaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicenciaMedicaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicenciaMedicaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(162, 100)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 55)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "LISTADO DE LICENCIAS MÉDICAS"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(555, 55)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "LICENCIAS MÉDICAS"
        '
        'BdremuneracionDataSet
        '
        Me.BdremuneracionDataSet.DataSetName = "bdremuneracionDataSet"
        Me.BdremuneracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LicenciaMedicaBindingSource
        '
        Me.LicenciaMedicaBindingSource.DataMember = "LicenciaMedica"
        Me.LicenciaMedicaBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'LicenciaMedicaTableAdapter
        '
        Me.LicenciaMedicaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.descuentos_liquidacionTableAdapter = Nothing
        Me.TableAdapterManager.DescuentosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaContratistaTableAdapter = Nothing
        Me.TableAdapterManager.FiniquitoTableAdapter = Nothing
        Me.TableAdapterManager.haber_liquidacionTableAdapter = Nothing
        Me.TableAdapterManager.HaberesTableAdapter = Nothing
        Me.TableAdapterManager.IngresoHorasTableAdapter = Nothing
        Me.TableAdapterManager.LicenciaMedicaTableAdapter = Me.LicenciaMedicaTableAdapter
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
        'LicenciaMedicaDataGridView
        '
        Me.LicenciaMedicaDataGridView.AutoGenerateColumns = False
        Me.LicenciaMedicaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.LicenciaMedicaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LicenciaMedicaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LicenciaMedicaDataGridView.DataSource = Me.LicenciaMedicaBindingSource
        Me.LicenciaMedicaDataGridView.Enabled = False
        Me.LicenciaMedicaDataGridView.Location = New System.Drawing.Point(106, 132)
        Me.LicenciaMedicaDataGridView.Name = "LicenciaMedicaDataGridView"
        Me.LicenciaMedicaDataGridView.Size = New System.Drawing.Size(446, 220)
        Me.LicenciaMedicaDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "fecha_inicio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "fecha_inicio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "rut_trabajador"
        Me.DataGridViewTextBoxColumn2.HeaderText = "rut_trabajador"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha_termino"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha_termino"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "motivo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "motivo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(470, 358)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 69)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(106, 358)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(78, 69)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'LibroLicencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(681, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LicenciaMedicaDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LibroLicencias"
        Me.Text = "JVRMONTAJES"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicenciaMedicaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicenciaMedicaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BdremuneracionDataSet As R.bdremuneracionDataSet
    Friend WithEvents LicenciaMedicaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LicenciaMedicaTableAdapter As R.bdremuneracionDataSetTableAdapters.LicenciaMedicaTableAdapter
    Friend WithEvents TableAdapterManager As R.bdremuneracionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LicenciaMedicaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
