<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeCC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeCC))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BdremuneracionDataSet = New R.bdremuneracionDataSet()
        Me.CentroCostoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CentroCostoTableAdapter = New R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter()
        Me.TableAdapterManager = New R.bdremuneracionDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CentroCostoDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CentroCostoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(164, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de Centro de costos registrados"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(455, 297)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 69)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 286)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 69)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BdremuneracionDataSet
        '
        Me.BdremuneracionDataSet.DataSetName = "bdremuneracionDataSet"
        Me.BdremuneracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CentroCostoBindingSource
        '
        Me.CentroCostoBindingSource.DataMember = "CentroCosto"
        Me.CentroCostoBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'CentroCostoTableAdapter
        '
        Me.CentroCostoTableAdapter.ClearBeforeFill = True
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_empresa"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_empresa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "asignacion_colacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "asignacion_colacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "asignacion_mov"
        Me.DataGridViewTextBoxColumn3.HeaderText = "asignacion_mov"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cc"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cc"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'CentroCostoDataGridView
        '
        Me.CentroCostoDataGridView.AutoGenerateColumns = False
        Me.CentroCostoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.CentroCostoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CentroCostoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CentroCostoDataGridView.DataSource = Me.CentroCostoBindingSource
        Me.CentroCostoDataGridView.Enabled = False
        Me.CentroCostoDataGridView.Location = New System.Drawing.Point(89, 124)
        Me.CentroCostoDataGridView.Name = "CentroCostoDataGridView"
        Me.CentroCostoDataGridView.Size = New System.Drawing.Size(444, 131)
        Me.CentroCostoDataGridView.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 81)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(233, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'InformeCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(591, 417)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.CentroCostoDataGridView)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InformeCC"
        Me.Text = "JVRMONTAJE"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentroCostoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CentroCostoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BdremuneracionDataSet As R.bdremuneracionDataSet
    Friend WithEvents CentroCostoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CentroCostoTableAdapter As R.bdremuneracionDataSetTableAdapters.CentroCostoTableAdapter
    Friend WithEvents TableAdapterManager As R.bdremuneracionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CentroCostoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
