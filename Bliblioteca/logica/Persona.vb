Public Class Persona

    Public Property Dni As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Email As String
    Public Property FechaDeNac As Date
    Public Property Password As String

    Public Sub buscarLibroNombre(ByVal Nombre As String)

    End Sub

    ' Cambia password de usuario
    Public Function cambiarPassword(ByVal Password As String) As String
        Dim xCliente As New Cliente
        xCliente.Password = Password

        Return MessageBox.Show("Contraseña cambiada con exito!")
    End Function
    ' Cambia Email de usuario
    Public Function cambiarEmail(ByVal Email As String) As String
        Dim xCliente As New Cliente
        xCliente.Email = Email

        Return MessageBox.Show("Email cambiado con exito!")
    End Function

    Private Function MessageBox() As Object
        Throw New NotImplementedException
    End Function

End Class
