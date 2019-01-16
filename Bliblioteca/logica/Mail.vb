Imports System.Net.Mail
Imports System.Text
Imports Datos

Public Class Mail
    Public Property _Mensaje As New MailMessage
    Public Property _SMTP As New SmtpClient
    Dim conexion As New conexionSql

    Public Property clave As String = "Be456321%"
    Public Property saludo As String
    Public Property user As String = "usuario"
    Public Property foto As String = "<a href='https://beta.photobucket.com/u/lunitakulbak/p/8e978263-c873-46e6-9938-e9a085fb2efd' target='_blank'> <img src='https://beta-static.photobucket.com/images/f36/lunitakulbak/La%20biblioteca%201_1.png' border='0' alt='La biblioteca 1_1'/> </a>"
    Public Property texto As String = ""
    Public Property titulo As String = ""
    Public Property Origen As String = "elrefugiopatitas@gmail.com"
    Public Property Origen_Detalle As String = "Biblioteca"
    Public Property Asunto As String = ""
    Public Property envio As String = ""

    Public Sub enviarMail(ByVal nuevomail As Mail)

        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential(Origen, clave)
        _SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        _Mensaje.From = New System.Net.Mail.MailAddress(Origen, Origen_Detalle, System.Text.Encoding.UTF8) 'Quien lo envía
        _Mensaje.[To].Add(envio) 'Pone la direccion donde querés enviarlo
        _Mensaje.Subject = Asunto 'Asunto del e-mail
        _Mensaje.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion


        ' obtiene el nombre del usuario para ponerlo en el mail
        Dim dt1 = conexion.consultar("Select nombre from usuarios where email = '" & nuevomail.envio & "'")
        user = CStr(dt1.Rows.Item(0)(0))

        _Mensaje.Body = "" &
            " <!DOCTYPE html>" &
            "<html xmlns='http://www.w3.org/1999/xhtml'>" &
            "<head>" &
            "    <title>" & titulo & "</title>" &
            "</head>" &
            "<body>" & foto & "<br /> Hola " & user & "! <br /> " & texto &
            "<br /> Si tenés dudas comunicate con soporte@biblioteca.com.ar </html>"

        _Mensaje.BodyEncoding = System.Text.Encoding.UTF8
        _Mensaje.Priority = System.Net.Mail.MailPriority.Normal
        _Mensaje.IsBodyHtml = True

        _SMTP.Send(_Mensaje)

    End Sub

    Public Function generarClave(ByVal email) As String
        Dim persona As New Persona
        Dim strRand As String = Nothing, r As New Random, n As Integer

        n = 7
        For i = 0 To n
            strRand &= Chr(Math.Round(r.Next(65, 90)))

        Next

        conexion.guardar("Update usuarios set password = '" & persona.Encriptar(strRand) & "' where email = '" & email & "'")
        Return strRand

    End Function

    Public Function obtenerMail(ByVal id) As String
        Try
            Dim dt As DataTable
            Dim mail As String
            dt = conexion.consultar("Select dirmail from mesa where id = " & id)
            mail = CStr(dt.Rows.Item(0)(0))

            Return mail

        Catch ex As Exception

        End Try
    End Function


    Public Sub avisar_tiempo_limite(ByVal id As Integer)
        Try
            ' manda un mail al usuario avisandole que le quedan 5 minutos
            Dim nuevomail As New Mail

            ' obtiene el mail de la BD
            Dim dt = conexion.consultar("Select dirmail from mesa where id = " & id)
            nuevomail.envio = CStr(dt.Rows.Item(0)(0))


            nuevomail.texto = "" &
            " <!DOCTYPE html>" &
            "<html xmlns='http://www.w3.org/1999/xhtml'>" &
            "<head>" &
            "    <title>Tiempo límite</title>" &
            "</head>" &
            "<body>" & "<br />" &
            "<strong>Hola </strong>" & nuevomail.user & "! <br />" &
             "Te quedan 5 minutos. Si necesitás más tiempo, tendrás que renovarlo." &
            "<br /> Si tenés dudas comunicate con soporte@biblioteca.com.ar </html>"
            nuevomail.enviarMail(nuevomail)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ultimo_aviso(ByVal id As Integer)
        Try
            Dim nuevomail As New Mail

            Dim dt = conexion.consultar("Select dirmail from mesa where id = " & id)

            nuevomail.envio = CStr(dt.Rows.Item(0)(0))

            Dim dt1 = conexion.consultar("Select nombre from usuarios where email = " & nuevomail.envio)
            nuevomail.user = CStr(dt1.Rows.Item(0)(0))

            Try
                nuevomail.texto = "" &
            " <!DOCTYPE html>" &
            "<html xmlns='http://www.w3.org/1999/xhtml'>" &
            "<head>" &
            "    <title>Se acabó el tiempo</title>" &
            "</head>" &
            "<body>" & nuevomail.foto & "<br />" &
            "<strong>Hola </strong>" & nuevomail.user & "<br />" &
             "Se acabó tu tiempo. Si necesitás más tiempo, tendrás que renovarlo." &
            "<br /> Si tenés dudas comunicate con soporte@biblioteca.com.ar </html>"
                nuevomail.enviarMail(nuevomail)

            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception

        End Try
    End Sub
End Class
