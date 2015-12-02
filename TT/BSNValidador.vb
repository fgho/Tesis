Imports System.Text.RegularExpressions
Public Class BSNValidador
    Public Function validarRut(ByVal rut As String)
        Dim value As Boolean = True
        Try

            Dim rutLimpio As String
            Dim digitoVerificador As String
            Dim suma As Integer
            Dim contador As Integer = 2
            rutLimpio = rut.Replace(".", "")
            rutLimpio = rutLimpio.Replace("-", "")
            rutLimpio = rutLimpio.Replace(" ", "")
            rutLimpio = rutLimpio.Substring(0, rutLimpio.Length - 1)
            digitoVerificador = rut.Substring(rut.Length - 1, 1)
            Dim i As Integer
            For i = rutLimpio.Length - 1 To 0 Step -1
                If contador > 7 Then
                    contador = 2
                End If
                suma += Integer.Parse(rutLimpio(i).ToString()) * contador
                contador += 1
            Next
            Dim dv As Integer = 11 - (suma Mod 11)
            Dim DigVer As String = dv.ToString()
            If DigVer = "10″ Then" Then
                DigVer = "K"
            End If
            If DigVer = "11″ Then" Then
                DigVer = "0″"
            End If
            If DigVer = digitoVerificador.ToUpper Then
            Else
                MessageBox.Show("Rut Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                value = False
            End If

        Catch EX As Exception

        End Try
        Return value
    End Function

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function
End Class
