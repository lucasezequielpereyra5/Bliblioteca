Imports Datos
Public Class Cliente
    Inherits Persona
    Dim conexion As New conexionSql

    Private Property MessageBox As Object

    ' Alquiler de libros para cliente 
    Public Function alquilarLibro(ByVal Id As Integer) As String
        Dim xLibro As New Libro

        Return MessageBox.Show("Libro: " & xLibro.Nombre & " Precio: " & xLibro.Precio)
    End Function
    Public Sub modificarPass(ByVal dni As Integer, ByVal password As String)

        conexion.guardar("UPDATE usuarios SET password = '" & Me.Encriptar(password) & "' WHERE dni='" & dni & "'")
    End Sub

End Class
