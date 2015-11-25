Public Class Informes

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If (rbCC.Checked = True) Then
            Dim nuevo As New InformeCC
            Me.Hide()
            nuevo.Show()
        ElseIf (rbHorasExtras.Checked = True) Then
            Dim nuevo As New InformeHorasExtras
            Me.Hide()
            nuevo.Show()
        ElseIf (rbLicencias.Checked = True) Then
            Dim nuevo As New LibroLicencias()
            Me.Hide()
            nuevo.Show()
        ElseIf (rbPagos.Checked = True) Then
            Dim nuevo As New InformePagos
            Me.Hide()
            nuevo.Show()
        ElseIf (rbTrabajadores.Checked = True) Then
            Dim nuevo As New InformeTrabajadores
            Me.Hide()
            nuevo.Show()
        Else
            Dim nuevo As New InformeLibro
            Me.Hide()
            nuevo.Show()
        End If
    End Sub
End Class