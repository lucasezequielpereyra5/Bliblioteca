Imports logica
Public Class frmModificarClienteAdmin
    Dim logica As New Administrador

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDni.TextChanged

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        ' Logica para que cuando un bibliotecario salga de un administrador y quiera modificar a otro cliente se lo permite
        txtDni.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtEmail.Enabled = True
        dtpFecha.Enabled = True
    End Sub

    Private Sub frmModificarClienteAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDni.ReadOnly = True
        dtpFecha.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim bln As Boolean = logica.IsValidEmail(txtEmail.Text)

        Try

            If Len(txtNombre.Text) < 3 Then
                Throw New Exception("El nombre del usuario debe contener mas de 3 caracteres")
            End If

            If Len(txtNombre.Text) > 15 Then
                Throw New Exception("El nombre del usuario debe contener menos de 15 caracteres")
            End If

            If Len(txtApellido.Text) < 3 Then
                Throw New Exception("El apellido del usuario debe contener mas de 3 caracteres")
            End If

            If Len(txtApellido.Text) > 15 Then
                Throw New Exception("El apellido del usuario debe contener menos de 15 caracteres")
            End If

            If bln = False Then
                Throw New Exception("Verifique Email Formato Incorrecto")
                txtEmail.Focus()
                Exit Sub
            End If

            If logica.verificarMail(txtEmail.Text) = False Then
                Throw New Exception("El e-mail ingresado ya existe")
            End If

            Dim xPersona As New Persona
            xPersona.Nombre = txtNombre.Text
            xPersona.Apellido = txtApellido.Text
            xPersona.Email = txtEmail.Text
            xPersona.FechaDeNac = dtpFecha.Value

            logica.modificarCliente(xPersona, txtDni.Text)
            MessageBox.Show("Modificación realizada")
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Logica para que cuando un bibliotecario salga de un administrador y quiera modificar a otro cliente se lo permite
        txtDni.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtEmail.Enabled = True
        dtpFecha.Enabled = True

        ' lista la grilla Try
        Try
            frmClientesAdm.dgvListarClientes.DataSource = logica.listarUsuarios()
        Catch ex As Exception

        End Try

    End Sub
End Class