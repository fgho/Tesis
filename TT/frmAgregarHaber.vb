

Public Class frmAgregarHaber

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


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim parametros As New Parametrosvb
        If (txtNombreHaber.Text.Equals("") Or txtTipo.Text.Equals("")) Then
            MsgBox("No deben existir campos vacios")
        ElseIf Not (txtTipo.Text.ToUpper.Equals("I") Or txtTipo.Text.ToUpper.Equals("T") Or txtTipo.Text.ToUpper.Equals("N")) Then
            MsgBox("No se reconoce el tipo de haber ingresado")
        Else
            MsgBox("entre")
            MsgBox(Me.metodo)
            Select Case (Me.metodo)
                Case 1
                    MsgBox("ahora voy a agregar juan!")
                    parametros.HaberesTableAdapter.InsertarHaber(txtNombreHaber.Text, txtTipo.Text.ToUpper)
                    MsgBox("Haber Ingresado Exitosamente")
                    Me.Dispose()




                Case 2
                    parametros.HaberesTableAdapter.UpdateQuery(txtNombreHaber.Text, txtTipo.Text.ToUpper, Me.clave)
                    MsgBox("valor actualizado exitosamente")
            End Select

       End If

    End Sub


End Class