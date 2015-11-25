<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menúvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menúvb))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.link_trabajadores = New System.Windows.Forms.LinkLabel()
        Me.link_eventos = New System.Windows.Forms.LinkLabel()
        Me.link_cal = New System.Windows.Forms.LinkLabel()
        Me.link_informes = New System.Windows.Forms.LinkLabel()
        Me.link_para = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(96, 178)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(522, 240)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Bienvenido al sistema de remuneraciones y gestión de personal"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(616, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 57)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 79)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menú principal"
        '
        'link_trabajadores
        '
        Me.link_trabajadores.AutoSize = True
        Me.link_trabajadores.BackColor = System.Drawing.Color.Transparent
        Me.link_trabajadores.Location = New System.Drawing.Point(24, 24)
        Me.link_trabajadores.Name = "link_trabajadores"
        Me.link_trabajadores.Size = New System.Drawing.Size(89, 19)
        Me.link_trabajadores.TabIndex = 4
        Me.link_trabajadores.TabStop = True
        Me.link_trabajadores.Text = "Trabajadores"
        '
        'link_eventos
        '
        Me.link_eventos.AutoSize = True
        Me.link_eventos.BackColor = System.Drawing.Color.Transparent
        Me.link_eventos.Location = New System.Drawing.Point(135, 24)
        Me.link_eventos.Name = "link_eventos"
        Me.link_eventos.Size = New System.Drawing.Size(57, 19)
        Me.link_eventos.TabIndex = 5
        Me.link_eventos.TabStop = True
        Me.link_eventos.Text = "Eventos"
        '
        'link_cal
        '
        Me.link_cal.AutoSize = True
        Me.link_cal.BackColor = System.Drawing.Color.Transparent
        Me.link_cal.Location = New System.Drawing.Point(236, 24)
        Me.link_cal.Name = "link_cal"
        Me.link_cal.Size = New System.Drawing.Size(55, 19)
        Me.link_cal.TabIndex = 6
        Me.link_cal.TabStop = True
        Me.link_cal.Text = "Cálculo"
        '
        'link_informes
        '
        Me.link_informes.AutoSize = True
        Me.link_informes.BackColor = System.Drawing.Color.Transparent
        Me.link_informes.Location = New System.Drawing.Point(345, 24)
        Me.link_informes.Name = "link_informes"
        Me.link_informes.Size = New System.Drawing.Size(62, 19)
        Me.link_informes.TabIndex = 7
        Me.link_informes.TabStop = True
        Me.link_informes.Text = "Informes"
        '
        'link_para
        '
        Me.link_para.AutoSize = True
        Me.link_para.BackColor = System.Drawing.Color.Transparent
        Me.link_para.Location = New System.Drawing.Point(433, 24)
        Me.link_para.Name = "link_para"
        Me.link_para.Size = New System.Drawing.Size(78, 19)
        Me.link_para.TabIndex = 8
        Me.link_para.TabStop = True
        Me.link_para.Text = "Parametros"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.link_informes)
        Me.Panel1.Controls.Add(Me.link_para)
        Me.Panel1.Controls.Add(Me.link_trabajadores)
        Me.Panel1.Controls.Add(Me.link_eventos)
        Me.Panel1.Controls.Add(Me.link_cal)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(96, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 66)
        Me.Panel1.TabIndex = 9
        '
        'Menúvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(681, 463)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menúvb"
        Me.Text = "JVRMONTAJES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents link_trabajadores As System.Windows.Forms.LinkLabel
    Friend WithEvents link_eventos As System.Windows.Forms.LinkLabel
    Friend WithEvents link_cal As System.Windows.Forms.LinkLabel
    Friend WithEvents link_informes As System.Windows.Forms.LinkLabel
    Friend WithEvents link_para As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
