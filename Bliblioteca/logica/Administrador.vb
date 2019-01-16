Imports Datos
Public Class Administrador

    Inherits Persona
    Dim conexion As New conexionSql
    Dim xCliente As New Cliente
    Dim xPersona As New Persona
    Dim xLibro As New Libro

    Public Overloads Function listarLibros() As DataTable
        Dim lista As DataTable
        Try
            lista = conexion.consultar("SELECT * FROM libros")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function

    Public Overloads Function listarLibrosAlquilados() As DataTable
        Dim lista As New DataTable
        Try
            lista = conexion.consultar("SELECT l.id_libro, l.nombre as 'Nombre de libro', u.dni as 'DNI de usuario', u.nombre AS 'Nombre de usuario', lu.fechaDeAlquiler AS 'Fecha de Alquiler', lu.fechaDeDevolucion AS 'Fecha de devolucion' FROM libros l INNER JOIN libro_usuario lu ON lu.fk_id_libro = l.id_libro INNER JOIN usuarios u ON u.dni = lu.fk_dni_usuario")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
    Public Overloads Function listarLibrosEnAlquiler(ByVal dni As Integer) As DataTable
        Dim lista As New DataTable
        Try
            lista = conexion.consultar("SELECT l.id_libro, l.nombre as 'Nombre de libro', u.dni as 'DNI de usuario', u.nombre AS 'Nombre de usuario', lu.fechaDeAlquiler AS 'Fecha de Alquiler', lu.fechaDeDevolucion AS 'Fecha de devolucion' FROM libros l INNER JOIN libro_usuario lu ON lu.fk_id_libro = l.id_libro INNER JOIN usuarios u ON u.dni = lu.fk_dni_usuario WHERE u.dni = '" & dni & "'")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
    'funcion para devolver un libro, recibe el id del libro y el dni del usuario, hace una baja en libros_usuario y un upadate en la tabla libros para sumarle al stock 1 ya que devolvio el libro.
    Public Sub devolverLibro(ByVal idLibro As Integer, ByVal dni As Integer)
        Try
            conexion.guardar("DELETE libro_usuario WHERE fk_id_libro = '" & idLibro & "'AND fk_dni_usuario = '" & dni & "'")
            conexion.guardar("UPDATE libros SET stock = stock + 1 WHERE id_libro = '" & idLibro & "'")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ' Alta de Usuario en la base de datos, recibe el objeto que llenamos en el formulario frmClientesAdm
    Public Sub altaUsuario(ByVal xCliente As Cliente, ByVal grupo As Integer)
        'Dim fecha As String = xCliente.FechaDeNac.ToString("yyyy-MM-dd")

        Try
            'testeamos que funciones la query
            'conexion.guardar("INSERT INTO usuarios VALUES('123456789','hola','chau','asd@asd.com','2018-05-09','asd123')")

            'Debug.Print("INSERT INTO usuarios VALUES('" & xCliente.Dni & "','" & xCliente.Nombre & "','" & xCliente.Apellido & "','" & fecha & "','" & xCliente.Email & "','" & xCliente.Password & "')")

            'llamamos al metodo de la clase conexionSql y le enviamos la query
            conexion.guardar("INSERT INTO usuarios VALUES('" & xCliente.Dni & "','" & xCliente.Nombre & "','" & xCliente.Apellido & "','" & Me.Encriptar(xCliente.Email) & "','" & xCliente.FechaDeNac.ToString("yyyy-MM-dd") & "','" & Me.Encriptar(xCliente.Password) & "')")
            'hacemos el insert para que se guarde en un grupo al usuario
            conexion.guardar("INSERT INTO usuarios_grupo VALUES ('" & xCliente.Dni & "','" & grupo & "')")

        Catch ex As Exception

            Debug.Print("Problema en logica: " & ex.ToString)
        End Try

    End Sub
    ' VerificarDni
    Public Function verificarDni(ByVal dni As Integer) As Boolean
        Dim lista As DataTable
        Dim check As Integer = 0
        lista = conexion.consultar("Select dni from usuarios")

        For Each dt As DataRow In lista.Rows
            If dt(0) = dni Then
                check = 1
            End If
        Next
        If check = 0 Then Return True Else Return False
    End Function
    ' VerificarMail
    Public Function verificarMail(ByVal mail As String) As Boolean
        Dim lista2 As DataTable
        Dim check2 As Integer = 0
        lista2 = conexion.consultar("Select email from usuarios")

        For Each dt2 As DataRow In lista2.Rows
            If dt2(0) = mail Then
                check2 = 1
            End If
        Next
        If check2 = 0 Then Return True Else Return False
    End Function


    'funcion que devuelve la lista de usuarios que hay registrados
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

    Public Sub modificarCliente(ByVal xPersona As Persona, ByVal dni As Integer)
        conexion.guardar("UPDATE usuarios SET nombre = '" & xPersona.Nombre & "' ,apellido = '" & xPersona.Apellido & "' ,email = '" & Me.Encriptar(xPersona.Email) & "' , fecha_nacimiento = '" & xPersona.FechaDeNac.ToString("yyyy-MM-dd") & "' WHERE dni ='" & dni & "'")
    End Sub
    Public Sub altaLibro(ByVal xLibro As Libro)
        Try
            'llamoas al metodo de la clase conexionSql y le enviamos la query
            conexion.guardar("INSERT INTO libros VALUES('" & xLibro.Nombre & "','" & xLibro.Descripcion & "','" & xLibro.Autor & "','" & xLibro.Editorial & "','" & xLibro.Genero & "'," & xLibro.Precio & "," & xLibro.Stock & ")")
        Catch ex As Exception

            Debug.Print("Problema en logica: " & ex.ToString)
        End Try

    End Sub

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

    Public Sub modificarLibro(ByVal xLibro As Libro, ByVal id As Integer)
        conexion.guardar("UPDATE libros SET nombre = '" & xLibro.Nombre & "' ,descripcion = '" & xLibro.Descripcion & "' ,autor = '" & xLibro.Autor & "' , editorial = '" & xLibro.Editorial & "' ,genero = '" & xLibro.Genero & "' ,precio = '" & xLibro.Precio & "' ,stock ='" & xLibro.Stock & "' WHERE id_libro ='" & id & "'")
    End Sub

End Class
