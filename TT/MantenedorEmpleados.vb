Imports System.Data.SqlServerCe


Public Class MantenedorEmpleados

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim nuevo As New Menúvb()
        Me.Hide()
        nuevo.Show()

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        Dim nuevo As New Agregar_Modificar

        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim nuevo As New Agregar_Modificar

        nuevo.txt_rut.Text = DataEmp.CurrentRow.Cells(0).Value.ToString
        nuevo.txt_nombre.Text = DataEmp.CurrentRow.Cells(1).Value.ToString
        nuevo.txt_ap.Text = DataEmp.CurrentRow.Cells(2).Value.ToString
        nuevo.txt_am.Text = DataEmp.CurrentRow.Cells(3).Value.ToString
        If (DataEmp.CurrentRow.Cells(4).Value.ToString = "S") Then
            nuevo.cmb_EstadoCivil.SelectedIndex = 0
        ElseIf (DataEmp.CurrentRow.Cells(4).Value.ToString = "C") Then
            nuevo.cmb_EstadoCivil.SelectedIndex = 1
        ElseIf (DataEmp.CurrentRow.Cells(4).Value.ToString = "V") Then
            nuevo.cmb_EstadoCivil.SelectedIndex = 2
        Else : nuevo.cmb_EstadoCivil.SelectedIndex = 3
        End If
        If (DataEmp.CurrentRow.Cells(5).Value.ToString = "M") Then
            nuevo.RM.Checked = True
        Else : nuevo.RF.Checked = True
        End If
        nuevo.txt_dir.Text = DataEmp.CurrentRow.Cells(6).Value.ToString
        nuevo.DataFecha.Text = DataEmp.CurrentRow.Cells(7).Value.ToString
        nuevo.cmb_cargo.SelectedValue = 7
        nuevo.txt_email.Text = DataEmp.CurrentRow.Cells(10).Value.ToString
        Me.Hide()
        nuevo.Show()
    End Sub

    Private Sub MantenedorEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.trabajador' Puede moverla o quitarla según sea necesario.
        Me.TrabajadorTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador)

    End Sub

    Private Sub TrabajadorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TrabajadorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)

    End Sub

    Private Sub DataEmp_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataEmp.CellClick
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True




    End Sub

   
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If (DataEmp.CurrentRow.Cells(8).Value.ToString = 1) Then
            If MessageBox.Show("¿ Está seguro de eliminar al trabajador ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Me.TrabajadorTableAdapter.UpdateQuery(0, DataEmp.CurrentRow.Cells(0).Value.ToString)
                MsgBox("trabajador eliminado correctamente", MsgBoxStyle.Information, "Alerta")
                Me.TrabajadorTableAdapter.Fill(Me.BdremuneracionDataSet.trabajador)
            End If
        Else : MsgBox("Este trabajador ya se encuentra eliminado", MsgBoxStyle.Critical, "Error")
        End If
        

    End Sub
End Class