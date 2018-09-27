Imports Datos
Public Class Administrador

    Inherits Persona
    Dim conexion As New conexionSql
    Dim xCliente As New Cliente


    ' Alta de Usuario en la base de datos, recibe el objeto que llenamos en el formulario frmClientesAdm
    Public Sub altaUsuario(ByVal xCliente As Cliente)
        'Dim fecha As String = xCliente.FechaDeNac.ToString("yyyy-MM-dd")

        Try
            'testeamos que funciones la query
            'conexion.guardar("INSERT INTO usuarios VALUES('123456789','hola','chau','asd@asd.com','2018-05-09','asd123')")

            'Debug.Print("INSERT INTO usuarios VALUES('" & xCliente.Dni & "','" & xCliente.Nombre & "','" & xCliente.Apellido & "','" & fecha & "','" & xCliente.Email & "','" & xCliente.Password & "')")

            'llamoas al metodo de la clase conexionSql y le enviamos la query
            conexion.guardar("INSERT INTO usuarios VALUES('" & xCliente.Dni & "','" & xCliente.Nombre & "','" & xCliente.Apellido & "','" & xCliente.Email & "','" & xCliente.FechaDeNac.ToString("yyyy-MM-dd") & "','" & xCliente.Password & "')")
        Catch ex As Exception

            Debug.Print("Problema en logica: " & ex.ToString)
        End Try

    End Sub
    'funcion que devuelve la lista de ususarios que hay registrados
    Public Function listarUsuarios() As DataTable
        'definimos una variable del tipo datatable para poder cargarla con lo que devuelve la funcion consultar en la clase conexionSql
        Dim lista As DataTable
        Try
            'intentamos hacer la consulta y la devolvemos
            lista = conexion.consultar("SELECT dni, nombre, apellido, email, fecha_nacimiento FROM usuarios")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function

    'buscar usuario por DNI, le pasamos por parametro el dni del usuario
    Public Function buscarUsuarioDni(ByVal dni As Integer) As DataTable
        'definimos una variable del tipo dataTable 
        Dim lista As DataTable
        Try
            'llenamos el datatable con lo que devuelve la funcion consultar de la clase conexionSql
            lista = conexion.consultar("SELECT dni, nombre, apellido, email, fecha_nacimiento FROM usuarios WHERE dni=" & dni)
        Catch ex As Exception
            Throw ex
        End Try


        Return lista
    End Function

    'buscar usuario por nombre y apellido
    Public Function buscarUsuarioNombreApellido(ByVal nombre As String, ByVal apellido As String) As DataTable
        'definimos una variable del tipo dataTable 
        Dim lista As DataTable
        Try
            'llenamos el datatable con lo que devuelve la funcion consultar de la clase conexionSql
            lista = conexion.consultar("SELECT dni, nombre, apellido, email, fecha_nacimiento FROM usuarios WHERE nombre='" & nombre & "' AND apellido='" & apellido & "'")
        Catch ex As Exception
            Throw ex
        End Try

        Return lista
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
