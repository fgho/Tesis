Public Class Calculo



    Private Sub AnticiposBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AnticiposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)

    End Sub

    Private Sub Calculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador' Puede moverla o quitarla según sea necesario.
        Me.TrabajadorTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Oficio' Puede moverla o quitarla según sea necesario.
        Me.OficioTableAdapter.Fill(Me.BdremuneracionDataSet.Oficio)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Contrato' Puede moverla o quitarla según sea necesario.
        Me.ContratoTableAdapter.Fill(Me.BdremuneracionDataSet.Contrato)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.TasasPrevisionales' Puede moverla o quitarla según sea necesario.
        Me.TasasPrevisionalesTableAdapter.Fill(Me.BdremuneracionDataSet.TasasPrevisionales)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.OrganismoPrevision' Puede moverla o quitarla según sea necesario.
        Me.OrganismoPrevisionTableAdapter.Fill(Me.BdremuneracionDataSet.OrganismoPrevision)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador_salud' Puede moverla o quitarla según sea necesario.
        Me.Trabajador_saludTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador_salud)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador_prevision' Puede moverla o quitarla según sea necesario.
        Me.Trabajador_previsionTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador_prevision)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.haber_liquidacion' Puede moverla o quitarla según sea necesario.
        Me.Haber_liquidacionTableAdapter.Fill(Me.BdremuneracionDataSet.haber_liquidacion)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.descuentos_liquidacion' Puede moverla o quitarla según sea necesario.
        Me.Descuentos_liquidacionTableAdapter.Fill(Me.BdremuneracionDataSet.descuentos_liquidacion)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.CentroCosto' Puede moverla o quitarla según sea necesario.
        Me.CentroCostoTableAdapter.Fill(Me.BdremuneracionDataSet.CentroCosto)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.cc_trabajador' Puede moverla o quitarla según sea necesario.
        Me.Cc_trabajadorTableAdapter.Fill(Me.BdremuneracionDataSet.cc_trabajador)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Anticipos' Puede moverla o quitarla según sea necesario.
        Me.AnticiposTableAdapter.Fill(Me.BdremuneracionDataSet.Anticipos)
        TrabajadorDataGridView.Columns(1).Visible = False
        TrabajadorDataGridView.Columns(2).Visible = False
        TrabajadorDataGridView.Columns(3).Visible = False
        TrabajadorDataGridView.Columns(4).Visible = False
        TrabajadorDataGridView.Columns(5).Visible = False
        TrabajadorDataGridView.Columns(8).Visible = False
        'TrabajadorDataGridView.Columns(10).Visible = False
      

    End Sub


  
  

   

  
    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Trabajador_previsionTableAdapter.ConsultarAFP(Me.BdremuneracionDataSet.trabajador_prevision, RutTextBox.Text)
    End Sub

  
   
End Class