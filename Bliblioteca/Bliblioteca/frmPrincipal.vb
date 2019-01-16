Imports System.Net
Imports System.Net.Mail
Imports logica

Public Class frmPrincipal
    Dim usuario As String = "usuario"
    Dim administrador As String = "administrador"
    Dim persona As New Persona
    Public dni As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea salir de la aplicaciòn?", vbYesNo, "Salir de la aplicaciòn")
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
        'If (txtDni.Text = usuario) Then
        'Dim frm As New frmCliente
        'frm.Show()
        'Me.Hide()

        '        ElseIf (txtDni.Text = administrador) Then
        '       Dim frm As New FRMinicio
        '      frm.Show()
        '     Me.Hide()

        'End If
        'verificamos que exista el usuario
        If (persona.verificarUsuario(txtDni.Text)) Then
            'verificamos que la contraseña sea correcta
            If (persona.Encriptar(txtContraseña.Text) = persona.Password) Then
                ' verificamos al grupo que pertenece llamando al metodo de la clase persona
                If ((persona.verificarGrupo(txtDni.Text) = "administrador") Or (persona.verificarGrupo(txtDni.Text) = "bibliotecario")) Then
                    Dim frm As New FRMinicio
                    frm.Show()
                    moverDatos.dni = txtDni.Text
                    Me.Hide()

                ElseIf (persona.verificarGrupo(txtDni.Text) = "usuario") Then
                    Dim frm As New frmCliente
                    moverDatos.dni = txtDni.Text
                    frm.Show()
                    Me.Hide()

                End If
            Else
                MessageBox.Show("La contraseña es incorrecta")
            End If

        Else
            MessageBox.Show("El DNI no existe en la base de datos")
        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtEnviarClave.Visible = True
        btnEnviarClave.Visible = True
    End Sub

    Private Sub btnEnviarClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarClave.Click
        Try
            Dim nuevomail = New logica.Mail
            Dim texto As String = ""
            nuevomail.envio = txtEnviarClave.Text
            Dim nuevaclave = nuevomail.generarClave(nuevomail.envio)
            nuevomail.texto = "Se reestableció tu clave en La Biblioteca. <br /> Tu nueva clave es: <br />" & nuevaclave

            nuevomail.Asunto = "Tu contraseña de La Biblioteca"
            nuevomail.titulo = "Tu contraseña de La Biblioteca"
            nuevomail.enviarMail(nuevomail)
            lblEnviado.Visible = True


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub
End Class
