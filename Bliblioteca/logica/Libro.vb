Imports Datos
Public Class Libro
    Dim conexion As New conexionSql
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Autor As String
    Public Property Editorial As String
    Public Property Genero As String
    Public Property Precio As Double
    Public Property Stock As Integer

    Public Sub guardarAlquiler(ByVal dni As Integer, ByVal id As Integer, ByVal fechaDeAlquiler As Date, ByVal fechaDeDevolucion As Date)
        Try
            conexion.guardar("INSERT INTO libro_usuario VALUES ('" & dni & "','" & id & "','" & fechaDeAlquiler.ToString("yyyy-MM-dd") & "','" & fechaDeDevolucion.ToString("yyyy-MM-dd") & "')")
            conexion.guardar("UPDATE libros SET stock = stock-1 WHERE id_libro = " & id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
