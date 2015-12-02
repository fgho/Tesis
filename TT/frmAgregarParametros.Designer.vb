<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarParametros
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Valor_ufLabel As System.Windows.Forms.Label
        Dim Valor_utmLabel As System.Windows.Forms.Label
        Dim Ingreso_min_mensualLabel As System.Windows.Forms.Label
        Dim Tope_gratificacionLabel As System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.ParametrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdremuneracionDataSet = New R.bdremuneracionDataSet()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtValorUf = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorUTM = New System.Windows.Forms.MaskedTextBox()
        Me.txtTope = New System.Windows.Forms.MaskedTextBox()
        Me.txtIngresoMinimo = New System.Windows.Forms.MaskedTextBox()
        Me.ParametrosTableAdapter = New R.bdremuneracionDataSetTableAdapters.parametrosTableAdapter()
        Me.TableAdapterManager = New R.bdremuneracionDataSetTableAdapters.TableAdapterManager()
        FechaLabel = New System.Windows.Forms.Label()
        Valor_ufLabel = New System.Windows.Forms.Label()
        Valor_utmLabel = New System.Windows.Forms.Label()
        Ingreso_min_mensualLabel = New System.Windows.Forms.Label()
        Tope_gratificacionLabel = New System.Windows.Forms.Label()
        CType(Me.ParametrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(23, 28)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 1
        FechaLabel.Text = "fecha:"
        '
        'Valor_ufLabel
        '
        Valor_ufLabel.AutoSize = True
        Valor_ufLabel.Location = New System.Drawing.Point(23, 53)
        Valor_ufLabel.Name = "Valor_ufLabel"
        Valor_ufLabel.Size = New System.Drawing.Size(45, 13)
        Valor_ufLabel.TabIndex = 3
        Valor_ufLabel.Text = "valor uf:"
        '
        'Valor_utmLabel
        '
        Valor_utmLabel.AutoSize = True
        Valor_utmLabel.Location = New System.Drawing.Point(23, 83)
        Valor_utmLabel.Name = "Valor_utmLabel"
        Valor_utmLabel.Size = New System.Drawing.Size(53, 13)
        Valor_utmLabel.TabIndex = 5
        Valor_utmLabel.Text = "valor utm:"
        '
        'Ingreso_min_mensualLabel
        '
        Ingreso_min_mensualLabel.AutoSize = True
        Ingreso_min_mensualLabel.Location = New System.Drawing.Point(23, 109)
        Ingreso_min_mensualLabel.Name = "Ingreso_min_mensualLabel"
        Ingreso_min_mensualLabel.Size = New System.Drawing.Size(81, 13)
        Ingreso_min_mensualLabel.TabIndex = 9
        Ingreso_min_mensualLabel.Text = "Ingreso Minimo:"
        '
        'Tope_gratificacionLabel
        '
        Tope_gratificacionLabel.AutoSize = True
        Tope_gratificacionLabel.Location = New System.Drawing.Point(23, 138)
        Tope_gratificacionLabel.Name = "Tope_gratificacionLabel"
        Tope_gratificacionLabel.Size = New System.Drawing.Size(95, 13)
        Tope_gratificacionLabel.TabIndex = 11
        Tope_gratificacionLabel.Text = "Tope gratificacion:"
        '
        'dtpFecha
        '
        Me.dtpFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ParametrosBindingSource, "fecha", True))
        Me.dtpFecha.Location = New System.Drawing.Point(153, 24)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'ParametrosBindingSource
        '
        Me.ParametrosBindingSource.DataMember = "parametros"
        Me.ParametrosBindingSource.DataSource = Me.BdremuneracionDataSet
        '
        'BdremuneracionDataSet
        '
        Me.BdremuneracionDataSet.DataSetName = "bdremuneracionDataSet"
        Me.BdremuneracionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(144, 226)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(12, 226)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtValorUf
        '
        Me.txtValorUf.Location = New System.Drawing.Point(153, 50)
        Me.txtValorUf.Mask = "99,999.99"
        Me.txtValorUf.Name = "txtValorUf"
        Me.txtValorUf.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtValorUf.Size = New System.Drawing.Size(200, 20)
        Me.txtValorUf.TabIndex = 16
        '
        'txtValorUTM
        '
        Me.txtValorUTM.Location = New System.Drawing.Point(153, 76)
        Me.txtValorUTM.Mask = "9999999"
        Me.txtValorUTM.Name = "txtValorUTM"
        Me.txtValorUTM.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtValorUTM.Size = New System.Drawing.Size(200, 20)
        Me.txtValorUTM.TabIndex = 17
        '
        'txtTope
        '
        Me.txtTope.Location = New System.Drawing.Point(153, 135)
        Me.txtTope.Mask = "99999999"
        Me.txtTope.Name = "txtTope"
        Me.txtTope.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtTope.Size = New System.Drawing.Size(200, 20)
        Me.txtTope.TabIndex = 19
        '
        'txtIngresoMinimo
        '
        Me.txtIngresoMinimo.Location = New System.Drawing.Point(153, 106)
        Me.txtIngresoMinimo.Mask = "9999999"
        Me.txtIngresoMinimo.Name = "txtIngresoMinimo"
        Me.txtIngresoMinimo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtIngresoMinimo.Size = New System.Drawing.Size(200, 20)
        Me.txtIngresoMinimo.TabIndex = 20
        '
        'ParametrosTableAdapter
        '
        Me.ParametrosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.oficiosTableAdapter = Nothing
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
        'frmAgregarParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 269)
        Me.Controls.Add(Me.txtIngresoMinimo)
        Me.Controls.Add(Me.txtTope)
        Me.Controls.Add(Me.txtValorUTM)
        Me.Controls.Add(Me.txtValorUf)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Valor_ufLabel)
        Me.Controls.Add(Valor_utmLabel)
        Me.Controls.Add(Ingreso_min_mensualLabel)
        Me.Controls.Add(Tope_gratificacionLabel)
        Me.Name = "frmAgregarParametros"
        Me.Text = "frmAgregarParametros"
        CType(Me.ParametrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdremuneracionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BdremuneracionDataSet As R.bdremuneracionDataSet
    Friend WithEvents ParametrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParametrosTableAdapter As R.bdremuneracionDataSetTableAdapters.parametrosTableAdapter
    Friend WithEvents TableAdapterManager As R.bdremuneracionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtValorUf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtValorUTM As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTope As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtIngresoMinimo As System.Windows.Forms.MaskedTextBox
End Class
