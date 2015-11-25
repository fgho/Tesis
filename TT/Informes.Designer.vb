<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informes))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCC = New System.Windows.Forms.RadioButton()
        Me.rbHorasExtras = New System.Windows.Forms.RadioButton()
        Me.rbLicencias = New System.Windows.Forms.RadioButton()
        Me.rbPagos = New System.Windows.Forms.RadioButton()
        Me.rbTrabajadores = New System.Windows.Forms.RadioButton()
        Me.RbLibro = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(584, 13)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 76)
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-318, 213)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 118)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 55)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Informes"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(162, 100)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RbLibro)
        Me.GroupBox1.Controls.Add(Me.rbTrabajadores)
        Me.GroupBox1.Controls.Add(Me.rbPagos)
        Me.GroupBox1.Controls.Add(Me.rbLicencias)
        Me.GroupBox1.Controls.Add(Me.rbHorasExtras)
        Me.GroupBox1.Controls.Add(Me.rbCC)
        Me.GroupBox1.Location = New System.Drawing.Point(154, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 148)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informes"
        '
        'rbCC
        '
        Me.rbCC.AutoSize = True
        Me.rbCC.Checked = True
        Me.rbCC.Location = New System.Drawing.Point(6, 25)
        Me.rbCC.Name = "rbCC"
        Me.rbCC.Size = New System.Drawing.Size(125, 23)
        Me.rbCC.TabIndex = 0
        Me.rbCC.TabStop = True
        Me.rbCC.Text = "Centro de costo"
        Me.rbCC.UseVisualStyleBackColor = True
        '
        'rbHorasExtras
        '
        Me.rbHorasExtras.AutoSize = True
        Me.rbHorasExtras.Location = New System.Drawing.Point(6, 54)
        Me.rbHorasExtras.Name = "rbHorasExtras"
        Me.rbHorasExtras.Size = New System.Drawing.Size(104, 23)
        Me.rbHorasExtras.TabIndex = 1
        Me.rbHorasExtras.Text = "Horas extras"
        Me.rbHorasExtras.UseVisualStyleBackColor = True
        '
        'rbLicencias
        '
        Me.rbLicencias.AutoSize = True
        Me.rbLicencias.Location = New System.Drawing.Point(6, 83)
        Me.rbLicencias.Name = "rbLicencias"
        Me.rbLicencias.Size = New System.Drawing.Size(83, 23)
        Me.rbLicencias.TabIndex = 2
        Me.rbLicencias.Text = "Licencias"
        Me.rbLicencias.UseVisualStyleBackColor = True
        '
        'rbPagos
        '
        Me.rbPagos.AutoSize = True
        Me.rbPagos.Location = New System.Drawing.Point(182, 25)
        Me.rbPagos.Name = "rbPagos"
        Me.rbPagos.Size = New System.Drawing.Size(195, 23)
        Me.rbPagos.TabIndex = 3
        Me.rbPagos.Text = "Informe pagos previsionales"
        Me.rbPagos.UseVisualStyleBackColor = True
        '
        'rbTrabajadores
        '
        Me.rbTrabajadores.AutoSize = True
        Me.rbTrabajadores.Location = New System.Drawing.Point(182, 54)
        Me.rbTrabajadores.Name = "rbTrabajadores"
        Me.rbTrabajadores.Size = New System.Drawing.Size(171, 23)
        Me.rbTrabajadores.TabIndex = 4
        Me.rbTrabajadores.Text = "Listado de trabajadores"
        Me.rbTrabajadores.UseVisualStyleBackColor = True
        '
        'RbLibro
        '
        Me.RbLibro.AutoSize = True
        Me.RbLibro.Location = New System.Drawing.Point(182, 83)
        Me.RbLibro.Name = "RbLibro"
        Me.RbLibro.Size = New System.Drawing.Size(177, 23)
        Me.RbLibro.TabIndex = 5
        Me.RbLibro.Text = "Libro de remuneraciones"
        Me.RbLibro.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(424, 267)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(67, 71)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Volver"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(154, 267)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(77, 71)
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(688, 362)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Informes"
        Me.Text = "JVRMONTAJES"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbLibro As System.Windows.Forms.RadioButton
    Friend WithEvents rbTrabajadores As System.Windows.Forms.RadioButton
    Friend WithEvents rbPagos As System.Windows.Forms.RadioButton
    Friend WithEvents rbLicencias As System.Windows.Forms.RadioButton
    Friend WithEvents rbHorasExtras As System.Windows.Forms.RadioButton
    Friend WithEvents rbCC As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
