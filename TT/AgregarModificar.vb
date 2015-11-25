Imports System.Data.SqlServerCe
Public Class Agregar_Modificar
    Dim validador As New BSNValidador
    Dim scon As New SqlCeConnection("Data Source=|DataDirectory|\bdremuneracion.sdf")

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim nuevo As New MantenedorEmpleados
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub txt_rut_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_rut.LostFocus
        Dim rut = txt_rut.Text
        validador.validarRut(rut) 
        
    End Sub

    Private Sub txt_email_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_email.LostFocus
        Dim bln As Boolean = validador.IsValidEmail(txt_email.Text)
        If (bln = False And validador.validarRut(txt_rut.Text) = True) Then
            MessageBox.Show("Verifique Email Formato Incorrecto")
            txt_email.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txt_rut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_rut.TextChanged

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        Dim sexo As Char
        MessageBox.Show(DateTime.Now.ToShortDateString())
        If (RM.Checked = True) Then
            sexo = "M"
        Else : sexo = "F"
        End If
        Dim x As String
        If (cmb_EstadoCivil.SelectedIndex = 0) Then
            x = "S"
        ElseIf (cmb_EstadoCivil.SelectedIndex = 1) Then
            x = "C"
        ElseIf (cmb_EstadoCivil.SelectedIndex = 2) Then
            x = "V"
        Else : x = "D"
        End If
        Dim d As String = cmb_cargo.SelectedValue.ToString
        Me.TrabajadorTableAdapter.Insert(txt_rut.Text, txt_nombre.Text, txt_ap.Text, txt_am.Text, x, sexo, txt_dir.Text, DataFecha.Text, "1", d, txt_email.Text)
        Me.Cc_trabajadorTableAdapter.Insert(DateTime.Now.ToShortDateString(), txt_rut.Text, cmb_cc.SelectedIndex)
        Me.Cuenta_bancariaTableAdapter.Insert(txt_numCuenta.Text, cmb_cuenta.SelectedIndex(), cmb_banco.SelectedIndex(), txt_rut.Text)
        Me.Trabajador_previsionTableAdapter.Insert(cmb_prevision.SelectedIndex, txt_rut.Text, DateTime.Now.ToShortDateString)
        Me.Trabajador_saludTableAdapter.Insert(DateTime.Now.ToShortDateString, txt_rut.Text, txt_cotizacion.Text, cmb_salud.SelectedIndex)


        MessageBox.Show("Empleado agregado con éxito")

    End Sub

    Private Sub Agregar_Modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.banco' Puede moverla o quitarla según sea necesario.
            Me.BancoTableAdapter.Fill(Me.BdremuneracionDataSet.banco)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.cc_trabajador' Puede moverla o quitarla según sea necesario.
            Me.Cc_trabajadorTableAdapter.Fill(Me.BdremuneracionDataSet.cc_trabajador)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.cuenta_bancaria' Puede moverla o quitarla según sea necesario.
            Me.Cuenta_bancariaTableAdapter.Fill(Me.BdremuneracionDataSet.cuenta_bancaria)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador_salud' Puede moverla o quitarla según sea necesario.
            Me.Trabajador_saludTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador_salud)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador_prevision' Puede moverla o quitarla según sea necesario.
            Me.Trabajador_previsionTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador_prevision)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador' Puede moverla o quitarla según sea necesario.
            Me.TrabajadorTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.CentroCosto' Puede moverla o quitarla según sea necesario.
            Me.CentroCostoTableAdapter.Fill(Me.BdremuneracionDataSet.CentroCosto)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Oficio' Puede moverla o quitarla según sea necesario.
            Me.OficioTableAdapter.Fill(Me.BdremuneracionDataSet.Oficio)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.OrganismoSalud' Puede moverla o quitarla según sea necesario.
            Me.OrganismoSaludTableAdapter.Fill(Me.BdremuneracionDataSet.OrganismoSalud)
            'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.OrganismoPrevision' Puede moverla o quitarla según sea necesario.
            Me.OrganismoPrevisionTableAdapter.Fill(Me.BdremuneracionDataSet.OrganismoPrevision)


        Cc_trabajadorDataGridView.Visible = False
        Trabajador_previsionDataGridView.Visible = False
        Trabajador_saludDataGridView.Visible = False
        TrabajadorDataGridView.Visible = False
        Cuenta_bancariaDataGridView.Visible = False




    End Sub

    
    
   
    Private Sub cmb_salud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_salud.SelectedIndexChanged

    End Sub
End Class