Public Class frmMantenedorIUT
    Public anterior As frmMantenedorIUT
    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
        Dim tramo8 As New frmMantenedorIUT

    End Sub
    Private Sub frmMantenedorIUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        Dim nuevoTramo As New frmMantenedorIUT
        nuevoTramo.ShowDialog()


    End Sub


    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        Me.Close()


    End Sub
End Class