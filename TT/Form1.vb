
Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub Ingreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ingreso.Click
        Dim Menu As New Menúvb()
        Me.Hide()
        Menu.Show()

    End Sub
End Class
