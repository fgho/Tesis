Public Class frmMantenedorOficios

    Protected _metodo As Integer
    Protected _clave As Integer

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByRef metodo As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        _metodo = metodo
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub
    Public Sub New(ByVal metodo As Integer, ByVal clave As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        _metodo = metodo
        _clave = clave
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub
    Public Property clave As Integer
        Get
            Return _clave
        End Get
        Set(ByVal value As Integer)
            _clave = value
        End Set
    End Property
    Public Property metodo As Integer
        Get
            Return _metodo
        End Get
        Set(ByVal value As Integer)
            _metodo = value
        End Set
    End Property


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim parametros As New Parametrosvb
        If (txtSueldoBase.Text.Equals("")) Then
            MsgBox("Existen campos obligatorios vacios")

        Else


            Select Case (Me.metodo)
                Case 1

                    parametros.OficioTableAdapter.Insert(txtNombre.Text, txtDescripcion.Text, Integer.Parse(txtSueldoBase.Text))
                    MsgBox("Cargo Ingresado Exitosamente")
                    Me.Dispose()




                Case 2
                    parametros.OficioTableAdapter.Update(txtNombre.Text, txtDescripcion.Text, Integer.Parse(txtSueldoBase.Text), Me.clave)

                    MsgBox("valor actualizado exitosamente")
            End Select

        End If

    End Sub





    Private Sub txtSueldoBase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldoBase.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True


        End If
    End Sub


    Private Sub frmMantenedorOficios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim parametros As New Parametrosvb
        If (txtSueldoBase.Text.Equals("")) Then
            MsgBox("Campos obligatorios vacios")

        Else


            Select Case (Me.metodo)
                Case 1

                    parametros.OficioTableAdapter.Insert(txtNombre.Text, txtDescripcion.Text.ToUpper, Integer.Parse(txtSueldoBase.Text)
                                                            )
                    MsgBox("Haber Ingresado Exitosamente")
                    Me.Dispose()




                Case 2
                    parametros.DescuentosTableAdapter.Update(txtNombre.Text, txtDescripcion.Text.ToUpper, Me.clave)
                    MsgBox("valor actualizado exitosamente")
            End Select

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()

    End Sub


End Class