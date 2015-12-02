Public Class frmAgregarParametros
    Protected _metodo As Byte
    Protected _clave As Date


    Public Sub New(ByVal metodo As Byte)
        InitializeComponent()

        _metodo = metodo

    End Sub
    Public Sub New(ByVal metodo As Byte, ByVal clave As Date)
        InitializeComponent()
        _metodo = metodo
        _clave = clave

    End Sub
    Public Sub New()
        InitializeComponent()

        _metodo = _metodo

    End Sub

    Public Property metodo As Byte
        Get
            Return _metodo
        End Get
        Set(ByVal value As Byte)
            _metodo = value
        End Set
    End Property


    Public Property clave As Date
        Get
            Return _clave
        End Get
        Set(ByVal value As Date)
            _clave = value
        End Set
    End Property
    Private Sub ParametrosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ParametrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdremuneracionDataSet)

    End Sub

 

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim parametros As New Form2
        Select Case (Me.metodo)
            Case 1
                ParametrosTableAdapter.Insertar(Now, Double.Parse(txtValorUf.Text), Integer.Parse(txtValorUTM.Text), Integer.Parse(txtIngresoMinimo.Text), Integer.Parse(txtTope.Text))

                MsgBox("Datos ingresados exitosamente")

            Case 2
                parametros.ParametrosTableAdapter.Actualizar(Double.Parse(txtValorUf.Text), Integer.Parse(txtValorUTM.Text), Integer.Parse(txtIngresoMinimo.Text), Integer.Parse(txtTope.Text), Me._clave)
                MsgBox("valor actualizado exitosamente")
        End Select

    End Sub

    Private Sub frmAgregarParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class