Public Class InformeCC

    Private Sub CentroCostoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CentroCostoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)

    End Sub

    Private Sub InformeCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.CentroCosto' Puede moverla o quitarla según sea necesario.
        Me.CentroCostoTableAdapter.Fill(Me.BdremuneracionDataSet.CentroCosto)
        Label3.Text = DateTime.Now.ToShortDateString
        Me.CentroCostoDataGridView.Columns(0).Visible = False
        Me.CentroCostoDataGridView.Columns(4).Visible = False

    End Sub

    
End Class