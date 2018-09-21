Public Class Cliente
    Inherits Persona

    Private Property MessageBox As Object

    ' Alquiler de libros para cliente 
    Public Function alquilarLibro(ByVal Id As Integer) As String
        Dim xLibro As New Libro

        Return MessageBox.Show("Libro: " & xLibro.Nombre & " Precio: " & xLibro.Precio)
    End Function


End Class
