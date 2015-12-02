Public Class LibroLicencias

    Private Sub LicenciaMedicaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LicenciaMedicaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)

    End Sub

    Private Sub LibroLicencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.LicenciaMedica' Puede moverla o quitarla según sea necesario.
        Me.LicenciaMedicaTableAdapter.Fill(Me.BdremuneracionDataSet.LicenciaMedica)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim nuevo As New Informes
        Me.Hide()
        nuevo.Show()
    End Sub
End Class