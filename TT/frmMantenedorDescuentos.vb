Public Class frmMantenedorDescuentos
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
    Private Sub frmMantenedorDescuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim parametros As New Parametrosvb
        If (txtNombreDcto.Text.Equals("") Or txtTipoDcto.Text.Equals("")) Then
            MsgBox("No deben existir campos vacios")
        ElseIf Not (txtTipoDcto.Text.ToUpper.Equals("I") Or txtTipoDcto.Text.ToUpper.Equals("T") Or txtTipoDcto.Text.ToUpper.Equals("N")) Then
            MsgBox("No se reconoce el tipo de haber ingresado")
        Else


            Select Case (Me.metodo)
                Case 1

                    parametros.DescuentosTableAdapter.Insertar(txtNombreDcto.Text, txtTipoDcto.Text.ToUpper)
                    MsgBox("Haber Ingresado Exitosamente")
                    Me.Dispose()




                Case 2
                    parametros.DescuentosTableAdapter.Update1(txtNombreDcto.Text, txtTipoDcto.Text.ToUpper, Me.clave)
                    MsgBox("valor actualizado exitosamente")
            End Select

        End If
    End Sub
End Class