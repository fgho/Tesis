Public Class InformeHorasExtras

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim nuevo As New Informes
        Me.Hide()
        nuevo.Show()
    End Sub

  
    Private Sub InformeHorasExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.IngresoHoras' Puede moverla o quitarla según sea necesario.
        Me.IngresoHorasTableAdapter.Fill(Me.BdremuneracionDataSet.IngresoHoras)
        Label1.Text = DateTime.Now.ToShortDateString
        Me.IngresoHorasDataGridView.Columns(0).Visible = False
        Me.IngresoHorasDataGridView.Columns(1).Visible = False
        Me.IngresoHorasDataGridView.Columns(2).Visible = False
        Me.IngresoHorasDataGridView.Columns(3).Visible = False
        Me.IngresoHorasDataGridView.Columns(5).Visible = False
    End Sub

    Private Sub IngresoHorasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoHorasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IngresoHorasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)

    End Sub
End Class