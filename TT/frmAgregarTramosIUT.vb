Public Class frmAgregarTramosIUT

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltramo2.Click

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAceptarIUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarIUT.Click
        Try
            Me.TramosIUTTableAdapter.InsertQuery()

            MsgBox("insertado exitosamente")
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'If Not ValidarVacios(txtHasta1.Text, lbldesde.Text, txtFactor1.Text, txtRebaja1.Text, txtTasa1.Text) Then

        '    MsgBox("Campo vacio")



        '    'ElseIf Not ValidarVacios(txtHasta2.Text, txtDesde2.Text, txtFactor2.Text, txtRebaja2.Text, txtTasa2.Text) Then
        '    '    MsgBox("3")
        '    'ElseIf ValidarVacios(txtHasta3.Text, txtDesde3.Text, txtFactor3.Text, txtRebaja3.Text, txtTasa3.Text) Then
        '    '    MsgBox("4")
        '    'ElseIf ValidarVacios(txtHasta4.Text, txtDesde4.Text, txtFactor4.Text, txtRebaja4.Text, txtTasa4.Text) Then
        '    '    MsgBox("5")
        '    'ElseIf ValidarVacios(txtHasta5.Text, txtDesde5.Text, txtFactor5.Text, txtRebaja5.Text, txtTasa5.Text) Then
        '    '    MsgBox("6")
        '    'ElseIf ValidarVacios(txtHasta6.Text, txtDesde6.Text, txtFactor6.Text, txtRebaja6.Text, txtTasa6.Text) Then
        '    '    MsgBox("7o")
        '    'ElseIf ValidarVacios(txtHasta7.Text, txtDesde7.Text, txtFactor7.Text, txtRebaja7.Text, txtTasa7.Text) Then
        '    '    MsgBox("8")
        '    'ElseIf ValidarVacios(txtHasta8.Text, txtDesde8.Text, txtFactor8.Text, txtRebaja8.Text, txtTasa8.Text) Then
        '    '    MsgBox("9")
        'Else
        '    MsgBox("entré perras")

        '    'param.TramosIUTTableAdapter.insertar(Integer.Parse(lbltramo2.Text), txtDesde2.Text, Double.Parse(txtHasta2.Text), Double.Parse(txtFactor2.Text), Double.Parse(txtRebaja2.Text), Now, Double.Parse(txtTasa2.Text))
        '    'param.TramosIUTTableAdapter.Insert(Integer.Parse(lbltramo3.Text), txtDesde3.Text, Double.Parse(txtHasta3.Text), Double.Parse(txtFactor3.Text), Double.Parse(txtRebaja3.Text), Now, Double.Parse(txtTasa3.Text))
        '    'param.TramosIUTTableAdapter.Insert(Integer.Parse(lbltramo4.Text), txtDesde4.Text, Double.Parse(txtHasta4.Text), Double.Parse(txtFactor4.Text), Double.Parse(txtRebaja4.Text), Now, Double.Parse(txtTasa4.Text))
        '    'param.TramosIUTTableAdapter.Insert(Integer.Parse(lbltramo5.Text), txtDesde5.Text, Double.Parse(txtHasta5.Text), Double.Parse(txtFactor5.Text), Double.Parse(txtRebaja5.Text), Now, Double.Parse(txtTasa5.Text))
        '    'param.TramosIUTTableAdapter.Insert(Integer.Parse(lbltramo6.Text), txtDesde6.Text, Double.Parse(txtHasta6.Text), Double.Parse(txtFactor6.Text), Double.Parse(txtRebaja6.Text), Now, Double.Parse(txtTasa6.Text))
        '    'param.TramosIUTTableAdapter.Insert(Integer.Parse(lbltramo7.Text), txtDesde7.Text, Double.Parse(txtHasta7.Text), Double.Parse(txtFactor7.Text), Double.Parse(txtRebaja7.Text), Now, Double.Parse(txtTasa7.Text))
        '    'param.TramosIUTTableAdapter.Insert(Integer.Parse(lbltramo8.Text), txtDesde8.Text, Double.Parse(txtHasta8.Text), Double.Parse(txtFactor8.Text), Double.Parse(txtRebaja8.Text), Now, Double.Parse(txtTasa8.Text))

        'MsgBox("Tramos Actualizado con exito")

        'End If






    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.TramosIUT' Puede moverla o quitarla según sea necesario.
        Me.TramosIUTTableAdapter.Fill(Me.BdremuneracionDataSet.TramosIUT)


    End Sub
    Function ValidarVacios(ByVal hasta As String, ByVal desde As String, ByVal factor As String, ByVal rebaja As String, ByVal tasa As String) As Boolean
        ValidarVacios = True
        If ((String.IsNullOrEmpty(hasta) = True) Or (String.IsNullOrEmpty(desde) = True) Or (String.IsNullOrEmpty(rebaja) = True) Or (String.IsNullOrEmpty(factor) = True) Or (String.IsNullOrEmpty(tasa) = True)) Then
            ValidarVacios = False
        End If


    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nuevo As New Informes
        Me.Hide()
        nuevo.Show()
    End Sub
End Class
