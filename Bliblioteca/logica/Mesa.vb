Imports Datos
Public Class Mesa
    Public Property id As Integer
    '    Public Property libro As Libro
    Public Property dni As Integer
    Public Property mail As String
    Public Property id_libro As Integer
    Public Property estado As String

    Dim conexion As New conexionSql

    Public Function consultar_lugar() As DataTable
        Dim lista As DataTable
        Try
            ' lista el id de cada lugar de la mesa y su estado (sí = libre, no = ocupado)
            lista = conexion.consultar("select id, estado from mesa")

        Catch ex As Exception
            Throw ex
        End Try

        Return lista
    End Function

    Public Function chequearUsuario(ByVal dni) As Integer
        Try
            ' Chequea si la persona ya se encuentra en un lugar
            Dim dt As DataTable
            dt = conexion.consultar("select id from mesa where dni = " & dni)
            If dt.Rows.Count = 0 Then
                Return 0
            Else
                Return dt.Rows.Item(0)(0)
            End If

        Catch ex As Exception

        End Try

    End Function

    'Public Function guardarhora()
    ' guarda la hora de entrada del cliente a la mesa y la hora a la que debería salir.
    'Dim tiempo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    'Dim tiempo2 = DateTime.Now.AddHours(1).ToString("yyyy-MM-dd HH:mm:ss")
    '   conexion.guardar("Update mesa set entrada = '" & tiempo & "' where id = 7")
    '  conexion.guardar("Update mesa set salida = '" & tiempo2 & "' where id = 7")
    '
    '    Dim dt = conexion.consultar("Select salida from mesa where id = 7")
    '   Dim d = dt.Rows.Item(0)(0)
    '  Dim da = DateDiff(DateInterval.Second, Now, d)
    ' Return da
    'End Function

    Public Function obtenerHora(ByVal id As Integer)
        Try
            ' obtiene la diferencia entre la hora de entrada y salida
            Dim min As Integer

            Dim dt = conexion.consultar("Select salida from mesa where id = " & id)

            min = DateDiff(DateInterval.Minute, Now, dt.Rows.Item(0)(0))
            Return min

        Catch ex As Exception
        End Try
    End Function

    Public Sub ocupar(ByVal xMesa As Mesa)
        Try
            ' Guarda en la BD usuario, libro y hora. Actualiza el stock del libro que se llevó a la mesa.
            Dim dt As DataTable

            ' cambiamos el estado de la mesa de SI a NO y guardamos el dni en la BD.
            conexion.guardar("Update mesa set estado='no' where id=" & xMesa.id)
            conexion.guardar("Update mesa set dni= " & xMesa.dni & " where id=" & xMesa.id)

            ' obtenemos el mail a partir del dni del cliente
            dt = conexion.consultar("Select email from usuarios where dni = " & xMesa.dni)
            xMesa.mail = CStr(dt.Rows.Item(0)(0))
            conexion.guardar("Update mesa set dirmail = '" & xMesa.mail & "' where dni = " & xMesa.dni)

            ' guardamos el id del libro que se llevó el cliente a su mesa y descontamos uno del stock del libro.
            conexion.guardar("Update mesa set id_libro = " & xMesa.id_libro & " where id = " & xMesa.id)
            conexion.guardar("Update libros Set stock = (stock - 1) where id_libro = " & xMesa.id_libro)

            ' guarda la hora de entrada del cliente a la mesa y la hora a la que debería salir.
            Dim tiempo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim tiempo2 = DateTime.Now.AddMinutes(59).ToString("yyyy-MM-dd HH:mm:ss")
            conexion.guardar("Update mesa set entrada = '" & tiempo & "' where id = " & xMesa.id)
            conexion.guardar("Update mesa set salida = '" & tiempo2 & "' where id = " & xMesa.id)


        Catch ex As Exception

        End Try

    End Sub

    Public Sub desocupar(ByVal xMesa As Mesa)
        Try
            ' busca en la tabla mesa cuál es el id del libro que tiene el cliente que va a desocupar el lugar.
            Dim dt = conexion.consultar("Select id_libro from mesa where id = " & xMesa.id)
            xMesa.id_libro = dt.Rows.Item(0)(0)
            ' suma 1 al stock porque el cliente va a devolver el libro
            conexion.guardar("Update libros set stock = (stock + 1) where id_libro = " & xMesa.id_libro)

            ' Vuelve a 0 todos los valores de la posición a desocupar.
            conexion.guardar("Update mesa set estado='si', dni= 0, dirmail= '', id_libro = 0, entrada = null, salida = null where id='" & xMesa.id & "'")
            'conexion.guardar("Update mesa set dni= " & 0)

        Catch ex As Exception

        End Try

    End Sub



End Class
