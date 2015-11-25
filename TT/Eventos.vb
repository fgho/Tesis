Public Class Eventos
    Dim validador As New BSNValidador

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscarHB.Click
        Dim rut = txt_hdrut.Text
        If (validador.validarRut(rut) = True) Then
            ' Me.TrabajadorTableAdapter.ConsultarRut(Me.BdremuneracionDataSet.trabajador, txt_hdrut.Text)
            'ARREGLAR ESTO
            ' If (Me.TrabajadorDataGridView.CurrentRow.Cells(0).Value.ToString <> txt_hdrut.Text) Then
            'MessageBox.Show("El empleado no está registrado en el sistema", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
            'Else
            cmb_haber.Enabled = True
            cmb_descuento.Enabled = True
            txt_montoDescuento.Enabled = True
            txt_montoHaber.Enabled = True
            picHaber.Enabled = True
            picDescuentos.Enabled = True
            Me.Haber_liquidacionTableAdapter.Consultar(Me.BdremuneracionDataSet.haber_liquidacion, txt_hdrut.Text)
            Haber_liquidacionDataGridView.Visible = True
            Me.Descuentos_liquidacionTableAdapter.Consultar(Me.BdremuneracionDataSet.descuentos_liquidacion, txt_hdrut.Text)
            Descuentos_liquidacionDataGridView.Visible = True
            ' End If

        Else
            cmb_haber.Enabled = False
            cmb_descuento.Enabled = False
            txt_montoDescuento.Enabled = False
            txt_montoHaber.Enabled = False
            picHaber.Enabled = False
            picDescuentos.Enabled = False
        End If
    End Sub

    Private Sub picHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHaber.Click
        Dim aux As String = cmb_haber.SelectedValue()

        If ((txt_montoHaber.Text = "0.00") And (txt_montoDescuento.Text = "0.00")) Then
            MessageBox.Show("No se ha ingresado monto del haber", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("¿Está seguro de ingresar los datos al sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Me.Haber_liquidacionTableAdapter.Insert(aux, DateTime.Now.ToShortDateString, txt_hdrut.Text, txt_montoHaber.Text)
            MessageBox.Show("Haber agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Haber_liquidacionTableAdapter.Consultar(Me.BdremuneracionDataSet.haber_liquidacion, txt_hdrut.Text)
            txt_hdrut.Text = ""
            txt_montoHaber.Text = "0.00"


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar2.Click
        If (txt_buscrut2.Text = "") Then
            MessageBox.Show("No se ha ingresado ningun rut", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)

        ElseIf (validador.validarRut(txt_buscrut2.Text) = True) Then
            FechaInicio.Enabled = True
            FechaTermino.Enabled = True
            RichMotivo.Enabled = True
            AgregarLicencia.Enabled = True
            Me.LicenciaMedicaTableAdapter.Consultar(Me.BdremuneracionDataSet.LicenciaMedica, txt_buscrut2.Text)
            LicenciaMedicaDataGridView.Visible = True
        Else
            FechaInicio.Enabled = False
            FechaTermino.Enabled = False
            RichMotivo.Enabled = False
            AgregarLicencia.Enabled = False


        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (validador.validarRut(txt_buscrut3.Text) = True) Then
            FechaAnticipo.Enabled = True
            cmb_moneda.Enabled = True
            TxtMontoAnticipo.Enabled = True
            AgregarAnticipo.Enabled = True
            Me.AnticiposTableAdapter.Consultar(Me.BdremuneracionDataSet.Anticipos, txt_buscrut3.Text)
            AnticiposDataGridView.Visible = True

        Else
            FechaAnticipo.Enabled = False
            cmb_moneda.Enabled = False
            TxtMontoAnticipo.Enabled = False


        End If
    End Sub

    Private Sub AgregarAnticipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAnticipo.Click
        If (TxtMontoAnticipo.Text = "0.00") Then
            MessageBox.Show("No se ha ingresado monto del anticipo", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            Me.AnticiposTableAdapter.Insert(FechaAnticipo.Text, txt_buscrut3.Text, TxtMontoAnticipo.Text)
            MessageBox.Show("Anticipo agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.AnticiposTableAdapter.Consultar(Me.BdremuneracionDataSet.Anticipos, txt_buscrut3.Text)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (validador.validarRut(txt_buscrut4.Text) = True) Then
            FechaFiniquito.Enabled = True
            RichCausal.Enabled = True
            Me.FiniquitoTableAdapter.Consultar(Me.BdremuneracionDataSet.Finiquito, txt_buscrut4.Text)
            FiniquitoDataGridView.Visible = True
            AgregarFiniquito.Enabled = True

        Else
            FechaFiniquito.Enabled = False
            RichCausal.Enabled = False


        End If
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If (validador.validarRut(txt_buscrut6.Text) = True) Then
            TxtHorasTrabajadas.Enabled = True
            TxtHorasExtras.Enabled = True
            TxtNumFallas.Enabled = True
            cmb_Empresa.Enabled = True
            TxtSobretiempo.Enabled = True
            Me.IngresoHorasTableAdapter.Consultar(Me.BdremuneracionDataSet.IngresoHoras, txt_buscrut6.Text)
            AgregarHoras.Enabled = True
            IngresoHorasDataGridView.Visible = True
        Else
            TxtHorasTrabajadas.Enabled = False
            TxtHorasExtras.Enabled = False
            TxtNumFallas.Enabled = False
            cmb_Empresa.Enabled = False
            TxtSobretiempo.Enabled = False


        End If
    End Sub

    Private Sub AgregarHoras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarHoras.Click
        If (TxtHorasTrabajadas.Text = "" Or TxtHorasExtras.Text = "" Or TxtNumFallas.Text = "" Or TxtSobretiempo.Text = "") Then
            MessageBox.Show("Porfavor rellene todos los campos", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            Me.IngresoHorasTableAdapter.Insert(DateTime.Now.ToShortDateString, TxtHorasTrabajadas.Text, TxtNumFallas.Text, TxtSobretiempo.Text, txt_buscrut6.Text, cmb_Empresa.SelectedValue, TxtHorasExtras.Text)
            MessageBox.Show("El Ingreso de horas se ha realizado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.IngresoHorasTableAdapter.Consultar(Me.BdremuneracionDataSet.IngresoHoras, txt_buscrut6.Text)

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (validador.validarRut(Carga_buscar.Text) = True) Then
            Carga_rutCarga.Enabled = True
            Carga_AM.Enabled = True
            Carga_AP.Enabled = True
            Carga_Nombre.Enabled = True
            Carga_cmbCarga.Enabled = True
            Me.CargaFamiliarTableAdapter.Consultar(Me.BdremuneracionDataSet.CargaFamiliar, Carga_buscar.Text)
            CargaFamiliarDataGridView.Visible = True
            AgregarCarga.Enabled = True
        Else
            Carga_rutCarga.Enabled = False
            Carga_AM.Enabled = False
            Carga_AP.Enabled = False
            Carga_Nombre.Enabled = False

            Carga_cmbCarga.Enabled = False

        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (validador.validarRut(Vac_buscar.Text) = True) Then
            Vac_FechaInicio.Enabled = True
            Vac_FechaTermino.Enabled = True
            Me.VacacionesTableAdapter.Consultar(Me.BdremuneracionDataSet.Vacaciones, Vac_buscar.Text)
            AgregarVaciones.Enabled = True
            VacacionesDataGridView.Visible = True
        Else
            Vac_FechaInicio.Enabled = False
            Vac_FechaTermino.Enabled = False

        End If
    End Sub

   

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If (validador.validarRut(Anexo_BuscRut.Text) = True) Then
            Anexo_CmbTipo.Enabled = True
            Anexo_Fecha.Enabled = True
            Anexo_Descripción.Enabled = True
            Me.AnexoTableAdapter.Consultar(Me.BdremuneracionDataSet.anexo, Anexo_BuscRut.Text)
            AgregarAnexo.Enabled = True
        Else
            Anexo_CmbTipo.Enabled = False
            Anexo_Fecha.Enabled = False
            Anexo_Descripción.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (validador.validarRut(Contratos_BuscRut.Text) = True) Then
            Contratos_Tipo.Enabled = True
            Contrato_CC.Enabled = True
            Contrato_Empresa.Enabled = True
            Contrato_Fecha.Enabled = True
            Contrato_Horas.Enabled = True
            Me.ContratoTableAdapter.Consultar(Me.BdremuneracionDataSet.Contrato, Contratos_BuscRut.Text)

        Else
            Contratos_Tipo.Enabled = False
            Contrato_CC.Enabled = False
            Contrato_Empresa.Enabled = False
            Contrato_Fecha.Enabled = False
            Contrato_Horas.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim nuevo As New ImprimirFiniquito()
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub Eventos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Contrato' Puede moverla o quitarla según sea necesario.
        Me.ContratoTableAdapter.Fill(Me.BdremuneracionDataSet.Contrato)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.CentroCosto' Puede moverla o quitarla según sea necesario.
        Me.CentroCostoTableAdapter.Fill(Me.BdremuneracionDataSet.CentroCosto)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.anexo' Puede moverla o quitarla según sea necesario.
        Me.AnexoTableAdapter.Fill(Me.BdremuneracionDataSet.anexo)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Vacaciones' Puede moverla o quitarla según sea necesario.
        Me.VacacionesTableAdapter.Fill(Me.BdremuneracionDataSet.Vacaciones)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.CargaFamiliar' Puede moverla o quitarla según sea necesario.
        Me.CargaFamiliarTableAdapter.Fill(Me.BdremuneracionDataSet.CargaFamiliar)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet1.EmpresaContratista' Puede moverla o quitarla según sea necesario.
        Me.EmpresaContratistaTableAdapter.Fill(Me.BdremuneracionDataSet1.EmpresaContratista)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.IngresoHoras' Puede moverla o quitarla según sea necesario.
        Me.IngresoHorasTableAdapter.Fill(Me.BdremuneracionDataSet.IngresoHoras)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Finiquito' Puede moverla o quitarla según sea necesario.
        Me.FiniquitoTableAdapter.Fill(Me.BdremuneracionDataSet.Finiquito)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Anticipos' Puede moverla o quitarla según sea necesario.
        Me.AnticiposTableAdapter.Fill(Me.BdremuneracionDataSet.Anticipos)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.LicenciaMedica' Puede moverla o quitarla según sea necesario.
        Me.LicenciaMedicaTableAdapter.Fill(Me.BdremuneracionDataSet.LicenciaMedica)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador' Puede moverla o quitarla según sea necesario.
        Me.TrabajadorTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.descuentos_liquidacion' Puede moverla o quitarla según sea necesario.
        Me.Descuentos_liquidacionTableAdapter.Fill(Me.BdremuneracionDataSet.descuentos_liquidacion)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.haber_liquidacion' Puede moverla o quitarla según sea necesario.
        Me.Haber_liquidacionTableAdapter.Fill(Me.BdremuneracionDataSet.haber_liquidacion)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Descuentos' Puede moverla o quitarla según sea necesario.
        Me.DescuentosTableAdapter.Fill(Me.BdremuneracionDataSet.Descuentos)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Haberes' Puede moverla o quitarla según sea necesario.
        Me.HaberesTableAdapter.Fill(Me.BdremuneracionDataSet.Haberes)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Haberes' Puede moverla o quitarla según sea necesario.
        Me.HaberesTableAdapter.Fill(Me.BdremuneracionDataSet.Haberes)
        Haber_liquidacionDataGridView.Columns(2).Visible = False
        Haber_liquidacionDataGridView.Visible = False
        Descuentos_liquidacionDataGridView.Columns(2).Visible = False
        Descuentos_liquidacionDataGridView.Visible = False
        LicenciaMedicaDataGridView.Visible = False
        LicenciaMedicaDataGridView.Columns(1).Visible = False
        AnticiposDataGridView.Visible = False
        AnticiposDataGridView.Columns(1).Visible = False
        FiniquitoDataGridView.Visible = False
        FiniquitoDataGridView.Columns(1).Visible = False
        FiniquitoDataGridView.Columns(3).Visible = False
        IngresoHorasDataGridView.Columns(4).Visible = False
        IngresoHorasDataGridView.Visible = False
        CargaFamiliarDataGridView.Visible = False
        CargaFamiliarDataGridView.Columns(4).Visible = False
        VacacionesDataGridView.Visible = False
        VacacionesDataGridView.Columns(2).Visible = False
    End Sub


    Private Sub picDescuentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDescuentos.Click
        Dim aux As String = cmb_descuento.SelectedValue()
        If ((txt_montoHaber.Text = "0.00") And (txt_montoDescuento.Text = "0.00")) Then
            MessageBox.Show("No se ha ingresado monto del descuento", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        Else
            Me.Descuentos_liquidacionTableAdapter.Insert(aux, DateTime.Now.ToShortDateString, txt_hdrut.Text, txt_montoDescuento.Text)
            MessageBox.Show("Descuento agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Descuentos_liquidacionTableAdapter.Consultar(Me.BdremuneracionDataSet.descuentos_liquidacion, txt_hdrut.Text)

        End If
    End Sub


    Private Sub AgregarLicencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarLicencia.Click
        If (Year(FechaInicio.Text) > Year(FechaTermino.Text)) Then
            MessageBox.Show("El año de la fecha de inicio no puede ser mayor al año de la fecha de termino", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            
        ElseIf (Year(FechaInicio.Text) = Year(FechaTermino.Text) And (Month(FechaInicio.Text) > Month(FechaTermino.Text))) Then
            MessageBox.Show("El mes de la fecha de inicio no puede ser mayor al mes de la fecha de termino", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Else
            Me.LicenciaMedicaTableAdapter.Insert(FechaInicio.Text, txt_buscrut2.Text, FechaTermino.Text, RichMotivo.Text)
            MessageBox.Show("Licencia con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.LicenciaMedicaTableAdapter.Consultar(Me.BdremuneracionDataSet.LicenciaMedica, txt_buscrut2.Text)
            FechaInicio.Text = DateTime.Now.ToShortDateString
            FechaTermino.Text = DateTime.Now.ToShortDateString
            RichMotivo.Text = ""
            txt_buscrut2.Text = ""
        End If
        
    End Sub


    Private Sub AgregarFiniquito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarFiniquito.Click
        Me.FiniquitoTableAdapter.Insert(FechaFiniquito.Text, txt_buscrut4.Text, RichCausal.Text, 0)
        MessageBox.Show("Finiquito agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.FiniquitoTableAdapter.Consultar(Me.BdremuneracionDataSet.Finiquito, txt_buscrut4.Text)
        txt_buscrut4.Text = ""
        FechaFiniquito.Text = DateTime.Now.ToShortDateString()
        RichCausal.Text = ""
        txt_buscrut4.Focus()

    End Sub

    Private Sub AgregarCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCarga.Click
        Me.CargaFamiliarTableAdapter.Insert(Carga_rutCarga.Text, Carga_Fecha.Text, Carga_AP.Text, Carga_AM.Text, Carga_buscar.Text)
        MessageBox.Show("Carga agregada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.CargaFamiliarTableAdapter.Consultar(Me.BdremuneracionDataSet.CargaFamiliar, Carga_buscar.Text)
    End Sub

    
    Private Sub AgregarVaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarVaciones.Click
        If (Year(Vac_FechaInicio.Text) > Year(Vac_FechaTermino.Text)) Then
            MessageBox.Show("El año de la fecha de inicio no puede ser mayor al año de la fecha de termino", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

        ElseIf (Year(Vac_FechaInicio.Text) = Year(Vac_FechaTermino.Text) And (Month(Vac_FechaInicio.Text) > Month(Vac_FechaTermino.Text))) Then
            MessageBox.Show("El mes de la fecha de inicio no puede ser mayor al mes de la fecha de termino", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Else
            Me.VacacionesTableAdapter.Insert(Vac_FechaInicio.Text, Vac_FechaTermino.Text, Vac_buscar.Text)
            MessageBox.Show("Vacación con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.VacacionesTableAdapter.Consultar(Me.BdremuneracionDataSet.Vacaciones, Vac_buscar.Text)
        End If
    End Sub

    Private Sub AgregarAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAnexo.Click
        Me.AnexoTableAdapter.Insert(Anexo_CmbTipo.SelectedItem, Anexo_Descripción.Text, DateTime.Now.ToShortDateString, Anexo_Fecha.Text, Anexo_BuscRut.Text)
        MessageBox.Show("Anexo agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.AnexoTableAdapter.Consultar(Me.BdremuneracionDataSet.anexo, Anexo_BuscRut.Text)
    End Sub

    Private Sub AgregarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarContrato.Click
        If (Year(Contrato_Fecha.Text) > Year(Contrato_FechaTermino.Text)) Then
            MessageBox.Show("El año de la fecha de inicio no puede ser mayor al año de la fecha de termino", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

        ElseIf (Year(Contrato_Fecha.Text) = Year(Contrato_FechaTermino.Text) And (Month(Contrato_Fecha.Text) > Month(Contrato_FechaTermino.Text))) Then
            MessageBox.Show("El mes de la fecha de inicio no puede ser mayor al mes de la fecha de termino", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Else
            Me.ContratoTableAdapter.Insert(Contrato_Fecha.Text, Contratos_BuscRut.Text, Contrato_Horas.Text, Contrato_FechaTermino.Text, Contratos_Tipo.SelectedIndex, Contrato_CC.SelectedValue)
            MessageBox.Show("Contrato agregado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ContratoTableAdapter.Consultar(Me.BdremuneracionDataSet.Contrato, Contratos_BuscRut.Text)
        End If
    End Sub

    Private Sub TabPage1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        Texto.Text = "En Eventos se ingresan los haberes y descuentos para un trabajador" +
                      " Puede ingresar Horas extras y el sistema efectuará los cálculos" +
                      "Además es posible ingresar Anticipos"
    End Sub

    
  
   
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim nuevo As New Menúvb()
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim nuevo As New Menúvb
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click

    End Sub
End Class