Imports System.Net.Mail

Public Class Mail
    Public Property _Mensaje As New MailMessage
    Public Property _SMTP As New SmtpClient

    Public Property clave As String = "Be456321%"
    Public Property saludo As String
    Public Property user As String = "usuario"
    Public Property foto As String = "<img src='http://i1064.photobucket.com/albums/u368/laurivero007/patitasnews_zps0jbc0hrg.png' border='0' alt='Logo Refugio Patitas' />"

    Public Property Mailz As String = ""
    Public Property Origen As String = "elrefugiopatitas@gmail.com"
    Public Property Origen_Detalle As String = "Biblioteca"
    Public Property Asunto As String = "Tu contraseña"
    Public Property envio As String = ""

    Function enviarMail()

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


        _Mensaje.Body = Mailz 'contenido del mail
        _Mensaje.BodyEncoding = System.Text.Encoding.UTF8
        _Mensaje.Priority = System.Net.Mail.MailPriority.Normal
        _Mensaje.IsBodyHtml = True

        _SMTP.Send(_Mensaje)

    End Function


End Class
