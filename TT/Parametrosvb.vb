Public Class Parametrosvb

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicAgregarFiniquito.Click
        Dim openfile As New OpenFileDialog
        openfile.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        openfile.Filter = "Text  File|*.txt"
        If (openfile.ShowDialog() = DialogResult.OK) Then
            Dim filename As String = openfile.FileName
            Me.rtxtTextoFiniquito.LoadFile(filename, RichTextBoxStreamType.PlainText)
            MsgBox(openfile.FileName)
        End If
    End Sub

    Private Sub PicGuardarFiniquito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicGuardarFiniquito.Click
        Dim save As New SaveFileDialog
        save.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        If rtxtTextoFiniquito.TextLength > 0 Then
            save.ShowDialog()
            System.IO.File.WriteAllText(save.FileName, rtxtTextoFiniquito.Text)
        End If
    End Sub

    Private Sub PicCargarAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCargarAnexo.Click
        Dim openfile As New OpenFileDialog
        openfile.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        openfile.Filter = "Text  File|*.txt"
        If (openfile.ShowDialog() = DialogResult.OK) Then
            Dim filename As String = openfile.FileName
            Me.rTextAnexo.LoadFile(filename, RichTextBoxStreamType.PlainText)
            MsgBox(openfile.FileName)
        End If
    End Sub

    Private Sub PiGuardarAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PiGuardarAnexo.Click
        Dim save As New SaveFileDialog
        save.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        If rTextAnexo.TextLength > 0 Then
            save.ShowDialog()
            System.IO.File.WriteAllText(save.FileName, rTextAnexo.Text)
        End If
    End Sub

    Private Sub CentroCostoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentroCostoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CentroCostoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)
        MessageBox.Show("Cambios realizados con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Parametrosvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Oficio' Puede moverla o quitarla según sea necesario.
        Me.OficioTableAdapter.Fill(Me.BdremuneracionDataSet.Oficio)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Oficio' Puede moverla o quitarla según sea necesario.
        Me.OficioTableAdapter.Fill(Me.BdremuneracionDataSet.Oficio)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Descuentos' Puede moverla o quitarla según sea necesario.
        Me.DescuentosTableAdapter.Fill(Me.BdremuneracionDataSet.Descuentos)


        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Haberes' Puede moverla o quitarla según sea necesario.
        Me.HaberesTableAdapter.Fill(Me.BdremuneracionDataSet.Haberes)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Oficio' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Haberes' Puede moverla o quitarla según sea necesario.
        Me.HaberesTableAdapter.Fill(Me.BdremuneracionDataSet.Haberes)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.Descuentos' Puede moverla o quitarla según sea necesario.
        'Me.DescuentosTableAdapter.Fill(Me.BdremuneracionDataSet.Descuentos)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.EmpresaContratista' Puede moverla o quitarla según sea necesario.
        Me.EmpresaContratistaTableAdapter.Fill(Me.BdremuneracionDataSet.EmpresaContratista)
        'TODO: esta línea de código carga datos en la tabla 'BdremuneracionDataSet.CentroCosto' Puede moverla o quitarla según sea necesario.
        Me.CentroCostoTableAdapter.Fill(Me.BdremuneracionDataSet.CentroCosto)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Label7.Visible = True
        cmb_empresa.Visible = True
        Label8.Visible = True
        Id_empresaTextBox.Visible = True
    End Sub

   
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Label10.Visible = True
        Label11.Visible = True
        cmb_cc.Visible = True
        Id_ccTextBox.Visible = True
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.Validate()
        Me.EmpresaContratistaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)
        MessageBox.Show("Cambios realizados con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim nuevo As New Menúvb
        Me.Hide()
        nuevo.Show()
    End Sub

   

    Private Sub btnAgregarHaber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarHaber.Click
        Dim agregar As New frmAgregarHaber(1)
        agregar.ShowDialog()


    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.HaberesTableAdapter.Fill(Me.BdremuneracionDataSet.Haberes)
    End Sub

    Private Sub HaberesDataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HaberesDataGridView.Click

        If HaberesDataGridView.CurrentRow IsNot Nothing Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim agregar As New frmAgregarHaber(2, HaberesDataGridView.CurrentRow.Cells(2).Value)
        agregar.ShowDialog()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("Esta Seguro de que desea Eliminar?", vbYesNo, "CONFIRMACION") = vbYes Then
            HaberesTableAdapter.Eliminar(HaberesDataGridView.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Private Sub btnEliminarDcto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDcto.Click
        If MsgBox("Esta Seguro de que desea Eliminar?", vbYesNo, "CONFIRMACION") = vbYes Then
            DescuentosTableAdapter.Delete(DescuentosDataGridView.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Private Sub btnModificarDcto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarDcto.Click
        Dim agregar As New frmMantenedorDescuentos(2, DescuentosDataGridView.CurrentRow.Cells(0).Value)

        agregar.ShowDialog()
    End Sub

    Private Sub btnActualizarDcto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarDcto.Click
        Me.DescuentosTableAdapter.Fill(Me.BdremuneracionDataSet.Descuentos)
    End Sub

    Private Sub btmAgregarDcto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmAgregarDcto.Click
        Dim agregar As New frmMantenedorDescuentos(1)
        agregar.ShowDialog()
    End Sub

    Private Sub btnAgregarO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarO.Click
        Dim mantenedor As New frmMantenedorOficios(1)
        mantenedor.ShowDialog()


    End Sub

    Private Sub btnActualizarO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarO.Click
        Me.OficioTableAdapter.Fill(Me.BdremuneracionDataSet.Oficio)
    End Sub

    Private Sub btnModificarO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarO.Click
        Dim mantenedor As New frmMantenedorOficios(2, oficioDataGridView.CurrentRow.Cells(0).Value)
        mantenedor.ShowDialog()

    End Sub

    Private Sub btnElminarO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElminarO.Click
        If MsgBox("Esta Seguro de que desea Eliminar?", vbYesNo, "CONFIRMACION") = vbYes Then
            OficioTableAdapter.Delete(OficioDataGridView.CurrentRow.Cells(0).Value)
        End If
    End Sub



    Private Sub OficiosDataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If oficioDataGridView.CurrentRow IsNot Nothing Then
            btnModificarO.Enabled = True
            btnElminarO.Enabled = True

        End If
    End Sub


    Private Sub btnGuardarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarContrato.Click

        Dim openfile As New OpenFileDialog
        openfile.InitialDirectory = "\..\..\.. \bin\"
        openfile.Filter = "Text  File|*.txt"
        If (openfile.ShowDialog() = DialogResult.OK) Then
            Dim filename As String = openfile.FileName
            Me.rtxtTextoContrato.LoadFile(filename, RichTextBoxStreamType.PlainText)
            MsgBox(openfile.FileName)
        End If
    End Sub


    Private Sub DescuentosDataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DescuentosDataGridView.Click
        If DescuentosDataGridView.CurrentRow IsNot Nothing Then
            btnModificarDcto.Enabled = True
            btnEliminarDcto.Enabled = True

        End If
    End Sub

    Private Sub oficioDataGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles oficioDataGridView.Click
        If oficioDataGridView.CurrentRow IsNot Nothing Then
            btnModificarO.Enabled = True
            btnElminarO.Enabled = True

        End If
    End Sub

    Private Sub btnCargarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarContrato.Click
        Dim save As New SaveFileDialog
        save.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        If rtxtTextoContrato.TextLength > 0 Then
            save.ShowDialog()
            System.IO.File.WriteAllText(save.FileName, rtxtTextoContrato.Text)
        End If
    End Sub
End Class