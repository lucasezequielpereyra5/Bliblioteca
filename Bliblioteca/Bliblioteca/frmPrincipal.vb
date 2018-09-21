Imports System.Net
Imports System.Net.Mail
Imports logica

Public Class frmPrincipal
    Dim usuario As String = "usuario"
    Dim administrador As String = "administrador"
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea salir de la aplicaciòn?", vbYesNo, "Salir del Modulo")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEnviarClave.Visible = False
        btnEnviarClave.Visible = False
        lblEnviado.Visible = False

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If (txtUsuario.Text = usuario) Then
            Dim frm As New frmCliente
            frm.Show()
            Me.Hide()

        ElseIf (txtUsuario.Text = administrador) Then
            Dim frm As New FRMinicio
            frm.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtEnviarClave.Visible = True
        btnEnviarClave.Visible = True
    End Sub

    Private Sub btnEnviarClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarClave.Click
        Try
            'De aqui en adelante donde proceses el texto....
            Dim nuevomail = New logica.Mail
            nuevomail.envio = txtEnviarClave.Text
            nuevomail.Mailz = "" &
            " <!DOCTYPE html>" &
            "<html xmlns='http://www.w3.org/1999/xhtml'>" &
            "<head>" &
            "    <title>Tu contraseña</title>" &
            "</head>" &
            "<body>" & nuevomail.foto & "<br />" &
            "<strong>Usuario: </strong>" & nuevomail.user & "<br />" &
             "<strong>Clave: 1 </strong><br />" &
            "<br /> Si tenés dudas comunicate con soporte@biblioteca.com.ar </html>"
            ' Dim cuerpoDelMensaje As String = "¡Hola amigo! Tu usuario de Refugio Patitas es: " + clavePatitas + "Tu clave: " + clavePatitas + vbCr + "Si tenés otro problema comunicate con el administrador!"
            nuevomail.enviarMail()
            lblEnviado.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub
End Class
