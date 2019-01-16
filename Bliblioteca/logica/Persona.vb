Imports Datos
Imports System
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Persona
    Dim conexion As New conexionSql

    Private Const sSecretKey As String = "12345678"

    Public Property Dni As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Email As String
    Public Property FechaDeNac As Date
    Public Property Password As String


    Public Function buscarLibroPorNombre(ByVal nombre As String) As DataTable
        Dim lista As DataTable
        Try
            'intentamos hacer la consulta y la devolvemos
            lista = conexion.consultar("SELECT * FROM libros WHERE nombre LIKE '" & nombre & "'")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista

    End Function

    Public Function buscarLibroPorAutor(ByVal autor As String) As DataTable
        Dim lista As DataTable
        Try
            'intentamos hacer la consulta y la devolvemos
            lista = conexion.consultar("SELECT * FROM libros WHERE autor LIKE '" & autor & "'")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista

    End Function

    Public Function buscarLibroPorEditorial(ByVal editorial As String) As DataTable
        Dim lista As DataTable
        Try
            'intentamos hacer la consulta y la devolvemos
            lista = conexion.consultar("SELECT * FROM libros WHERE editorial LIKE '" & editorial & "'")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista

    End Function

    Public Function buscarLibroPorGenero(ByVal genero As String) As DataTable
        Dim lista As DataTable
        Try
            'intentamos hacer la consulta y la devolvemos
            lista = conexion.consultar("SELECT * FROM libros WHERE genero LIKE '" & genero & "'")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista

    End Function

    ' Lista de libro en la base de datos
    'funcion que devuelve la lista de libros que hay registrados
    Public Function listarLibros() As DataTable
        'definimos una variable del tipo datatable para poder cargarla con lo que devuelve la funcion consultar en la clase conexionSql
        Dim lista As DataTable
        Try
            'intentamos hacer la consulta y la devolvemos
            lista = conexion.consultar("SELECT * FROM libros WHERE stock > 0")
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
    'funcion que devuelve la contraseña encriptada
    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes(sSecretKey) 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    'funcion que devuelve la contraseña desencriptada
    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes(sSecretKey) 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    'funcion que verifica el usuario si existe en la base de datos
    Public Function verificarUsuario(ByVal dni As Integer) As Boolean
        Dim existe As Boolean = False
        Dim usuario As DataTable


        Try
            'traemos el usuario, si existe va a tener 1 fila, si no va a tener 0 filas
            usuario = conexion.consultar("SELECT * FROM usuarios WHERE dni=" & dni)

            'verificamos que tenga 1 fila o mas
            If (usuario.Rows.Count > 0) Then
                'llenamos las propiedades con el valor de la fila y columna segun tengamos en la base de datos.
                Me.Dni = CStr(usuario.Rows.Item(0)(0))
                Me.Nombre = CStr(usuario.Rows.Item(0)(1))
                Me.Apellido = CStr(usuario.Rows.Item(0)(2))
                Me.Email = CStr(usuario.Rows.Item(0)(3))
                Me.FechaDeNac = CStr(usuario.Rows.Item(0)(4))
                Me.Password = CStr(usuario.Rows.Item(0)(5))

                'le asignamos valor true a la variable
                existe = True
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return existe
    End Function
    ' funcion que devuelve el grupo al que pertenece el usuario
    Public Function verificarGrupo(ByVal dni As Integer) As String
        Dim grupo As String
        Dim usuario As DataTable

        Try
            'traemos al usuario con todos sus datos y el nombre al grupo al que pertenece
            usuario = conexion.consultar("SELECT u.*, g.nombre FROM usuarios u INNER JOIN usuarios_grupo ug ON ug.fk_dni_usuario = u.dni INNER JOIN grupos g ON g.id_grupo = ug.fk_id_grupo WHERE(u.dni = " & dni & ")")

            'guardamos en la variable el grupo al que pertenece el usuario
            grupo = CStr(usuario.Rows.Item(0)(6))

        Catch ex As Exception
            Throw ex
        End Try

        Return grupo
    End Function


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

    'lista los libros que tiene un usuario alquilado, recibe un DNI y solo muestra los libros que tengan stock mayor a 0
    Public Function listarLibrosEnAlquiler(ByVal dni As Integer) As DataTable
        Dim lista As New DataTable
        Try
            lista = conexion.consultar("SELECT l.nombre, l.editorial, lu.fechaDeAlquiler, lu.fechaDeDevolucion FROM libros l INNER JOIN libro_usuario lu ON lu.fk_id_libro = l.id_libro INNER JOIN usuarios u ON u.dni = lu.fk_dni_usuario WHERE u.dni=" & dni)
        Catch ex As Exception
            Throw ex
        End Try


        Return lista
    End Function

    Public Sub buscarNombre(ByVal dni As String)
        Dim lista As DataTable

        lista = conexion.consultar("SELECT dni, nombre, apellido, email, fecha_nacimiento, password FROM usuarios WHERE dni=" & dni)
        'llenamos las propiedades con el valor de la fila y columna segun tengamos en la base de datos.
        Me.Dni = CStr(lista.Rows.Item(0)(0))
        Me.Nombre = CStr(lista.Rows.Item(0)(1))
        Me.Apellido = CStr(lista.Rows.Item(0)(2))
        Me.Email = CStr(lista.Rows.Item(0)(3))
        Me.FechaDeNac = CStr(lista.Rows.Item(0)(4))
        'la contraseña debemos desencriptarla llamando a la funcion desencriptar que devuelve la contraseña ya desencriptada.
        Me.Password = CStr(lista.Rows.Item(0)(5))
    End Sub

    Public Function listarLibrosAlquilados(ByVal nombre As String) As DataTable
        Dim lista As New DataTable
        Try
            lista = conexion.consultar("select l.nombre, u.nombre from usuarios u INNER JOIN libro_usuario lu ON lu.fk_dni_usuario = u.dni INNER JOIN libros l ON l.id_libro = lu.fk_id_libro WHERE l.nombre LIKE '" & nombre & "'")
        Catch ex As Exception
            Throw ex
        End Try

        Return lista
    End Function

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

End Class
