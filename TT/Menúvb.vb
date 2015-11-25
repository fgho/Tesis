Public Class Menúvb

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub link_trabajadores_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_trabajadores.LinkClicked
        Dim nuevo As New MantenedorEmpleados()
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub link_eventos_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_eventos.LinkClicked
        Dim nuevo As New Eventos
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub link_cal_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_cal.LinkClicked
        Dim nuevo As New Calculo
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub link_informes_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_informes.LinkClicked
        Dim nuevo As New Informes
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub link_para_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_para.LinkClicked
        Dim nuevo As New Parametrosvb
        Me.Hide()
        nuevo.Show()
    End Sub
End Class