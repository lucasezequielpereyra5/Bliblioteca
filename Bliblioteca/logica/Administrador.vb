Imports Datos
Public Class Administrador
    Inherits Persona

    ' Alta de Usuario en la base de datos
    Public Function altaUsuario(ByVal Dni As Integer,
                                ByVal Nombre As String,
                                ByVal Apellido As String,
                                ByVal FechaDeNac As Date,
                                ByVal Email As String,
                                ByVal Password As String) As String

        Dim conexion As New conexionSql
        Dim xCliente As New Cliente
        xCliente.Dni = Dni
        xCliente.Nombre = Nombre
        xCliente.Apellido = Apellido
        xCliente.FechaDeNac = FechaDeNac
        xCliente.Email = Email
        xCliente.Password = Password

        conexion.guardar("INSERT INTO usuarios VALUES (" & xCliente.Dni & "," & xCliente.Nombre & "," & xCliente.Apellido & "," & xCliente.FechaDeNac & "," & xCliente.Email & "," & xCliente.Password)



  

        Return MessageBox.Show("Cliente creado exitosamente")
    End Function


    ' Baja de Usuario en la base de datos
    Public Function bajaUsuario(ByVal Dni As Integer) As String

        Return MessageBox.Show("Cliente eliminado")
    End Function

    Public Function modificarUsuario(ByVal Dni As Integer,
                                ByVal Nombre As String,
                                ByVal Apellido As String,
                                ByVal FechaDeNac As Date,
                                ByVal Email As String,
                                ByVal Password As String) As String
        Dim xCliente As New Cliente
        xCliente.Dni = Dni
        xCliente.Nombre = Nombre
        xCliente.Apellido = Apellido
        xCliente.FechaDeNac = FechaDeNac
        xCliente.Email = Email
        xCliente.Password = Password

        Return MessageBox.Show("Cliente Modificado")
    End Function

    ' Alta de usuario en la base de datos
    Public Function altaLibro(ByVal Id As Integer,
                              ByVal Nombre As String,
                              ByVal Descripcion As String,
                              ByVal Autor As String,
                              ByVal Editorial As String,
                              ByVal Genero As String,
                              ByVal Precio As Double,
                              ByVal Stock As Integer)

        Dim xLibro As New Libro
        xLibro.Id = Id
        xLibro.Descripcion = Descripcion
        xLibro.Autor = Autor
        xLibro.Editorial = Editorial
        xLibro.Genero = Genero
        xLibro.Precio = Precio
        xLibro.Stock = Stock

        Return MessageBox.Show("Libro agregado!")

    End Function

    ' Modificacion de libros en la base de datos
    Public Function modificarLibro(ByVal Id As Integer,
                              ByVal Nombre As String,
                              ByVal Descripcion As String,
                              ByVal Autor As String,
                              ByVal Editorial As String,
                              ByVal Genero As String,
                              ByVal Precio As Double,
                              ByVal Stock As Integer)

        Dim xLibro As New Libro
        xLibro.Id = Id
        xLibro.Descripcion = Descripcion
        xLibro.Autor = Autor
        xLibro.Editorial = Editorial
        xLibro.Genero = Genero
        xLibro.Precio = Precio
        xLibro.Stock = Stock
        Return MessageBox.Show("Libro modificado!")
    End Function
    ' Eliminar libros en la base de datos
    Public Function eliminarLibro(ByVal Id As Integer) As String

        Return MessageBox.Show("Libro Eliminado!")
    End Function
    ' Devolucion de Libros por parte del cliente
    Public Function devolverLibro(ByVal Id As Integer) As String
        Dim xLibro As New Libro

        Return MessageBox.Show("Libro devuelto: " & xLibro.Nombre)
    End Function

    Private Function MessageBox() As Object
        Throw New NotImplementedException
    End Function


End Class
