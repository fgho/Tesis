Public Class ImprimirFiniquito

    

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(RichFiniquito.Text, Font, Brushes.Blue, 100, 100)

    End Sub

    Private Sub Finiquito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ImprimirFiniquito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichFiniquito.Text = "En Quilpué a CONTRATO.FECHATERMINO entre JVRMONTAJES, RUT 76374245-8, con domicilio en PASAJEVIDAL y don(a) TRABAJADOR.NOMBRE, RUT TRABAJADOR.RUT, se acuerda el siguiente Finiquito:" +
                          "PRIMERO: Don(a) TRABAJADOR.NOMBRE declara haberle prestado servicios a JVERGARA en calidad de CARGO.NOMBRE desde el CONTRATO.INICIO hasta el CONTRATO.TERMINO, fecha esta última de terminación de sus servicios por la siguiente causa de acuerdo a lo dispuesto en el FINIQUITO.CAUSAL." +
                           "SEGUNDO: Don(a) TRABAJADOR.NOMBRE declara recibir en este acto, a su entera satisfacción, de parte de JVRMONTAJES las sumas que a continuación se indican, por los siguientes conceptos:" +
                          "Finiquito.MONTO" +
                          "TERCERO: Don(a) TRABAJADOR.NOMBRE deja constancia que durante todo el tiempo que le prestó servicios a la empresa JVRMONTAJES, recibió de ésta, correcta y oportunamente el total de las remuneraciones convenidas, de acuerdo con su contrato de trabajo, clase de trabajo ejecutado, reajustes legales, pago de asignaciones familiares autorizadas por la respectiva Institución de Previsión, horas extraordinarias cuando las trabajó, feriados legales, gratificaciones y participaciones, en conformidad a la Ley y que nada se le adeuda por los conceptos antes indicados ni por ningún otro, sea de origen legal o contractual derivado de la prestación de sus servicios, y motivo por el cual, no teniendo reclamo ni cargo alguno que formular en contra de JVRMONTAJES, le otorga el más amplio y total finiquito, declaración que formula libre y espontáneamente, en perfecto y cabal conocimiento de cada uno y todos sus derechos." +
                          "Para constancia las partes firman el presente Finiquito en tres ejemplares, quedando dos de ellos en poder del empleador y uno en poder del trabajador."
                         
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim nuevo As New Eventos()
        Me.Hide()

        nuevo.Show()
    End Sub

    Private Sub Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimir.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class