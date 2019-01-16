Imports System.Text.RegularExpressions
Imports logica
Public Class frmClientesAdm
    Dim logica As New Administrador

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Dim Form As New FRMinicio

        FRMinicio.Show()
        Me.Hide()
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub btnAltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltas.Click
        pnlAlta.Show()
        pnlModif.Hide()

    End Sub


    Private Sub pnlAlta_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAlta.Paint

        If txtPass2.Text <> txtPass.Text Then
            lblPass2.Text = "Las contraseñas no coinciden"
        Else
            lblPass2.Text = "Las contraseñas concden"
        End If
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDni.TextChanged

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtEdad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged

    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub txtPass2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass2.TextChanged
        txtPass2.PasswordChar = "*"
    End Sub

    Private Sub lblPass2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPass2.Click


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim xCliente As New Cliente
        Dim bln As Boolean = logica.IsValidEmail(txtMail.Text)
        Dim grupo As Integer

        Try
            If Not IsNumeric(txtDni.Text) Then
                Throw New Exception("El valor del dni debe ser númerico")
            End If

            If Len(txtDni.Text) < 8 Then
                Throw New Exception("El dni debe contener al menos 8 caracteres")
            End If

            If logica.verificarDni(txtDni.Text) = False Then
                Throw New Exception("El dni ya existe en la base de datos")
            End If

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
                txtMail.Focus()
                Exit Sub
            End If

            If logica.verificarMail(txtMail.Text) = False Then
                Throw New Exception("El e-mail ingresado ya existe")
            End If

            If Len(txtPass.Text) < 4 Then
                Throw New Exception("La contraseña debe tener 4 o mas caracteres")
            End If

            If txtPass2.Text <> txtPass.Text Then
                Throw New Exception("Las contraseñas ingresadas no coinciden")
            End If

            'asignamos a las propiedades los valores de los textbox y del datetimepicker
            xCliente.Dni = txtDni.Text
            xCliente.Nombre = txtNombre.Text
            xCliente.Apellido = txtApellido.Text
            xCliente.FechaDeNac = dtpFechaNac.Value
            xCliente.Email = txtMail.Text
            xCliente.Password = txtPass.Text

            If (rbUusuario.Checked) Then
                grupo = 1
            ElseIf (rbBibliotecario.Checked) Then
                grupo = 3
            End If

            Try
                'llamamos al metodo en la clase Administrador de la parte logica y le enviamos el objeto ya con los propiedades asignadas
                logica.altaUsuario(xCliente, grupo)
                MessageBox.Show("Los datos se guardaron correctamente")
                'despues de hacer la alta, llamamos al metodo limpiarcampos para limpiar los txt.
                Me.limpiarCampos()
            Catch ex As Exception
                Debug.Print("Problema: " & ex.ToString)
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        

    End Sub
    'procedimiento que limpia los campos
    Public Sub limpiarCampos()
        txtDni.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtMail.Clear()
        txtPass.Clear()
        txtPass2.Clear()
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        pnlModif.Show()
        pnlAlta.Hide()

        Try
            'llenamos el datagridview con el datatable que devuelve la funcion listar usuarios en la clase administrador
            dgvListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvListarClientes.DataSource = logica.listarUsuarios()
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Private Sub pnlModif_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlModif.Paint

    End Sub

    Private Sub FRMcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlModif.Visible = False
        dgvListarClientes.AllowUserToAddRows = False
        dgvListarClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Try
            'llenamos el datagridview con el datatable que devuelve la funcion listar usuarios en la clase administrador
            dgvListarClientes.DataSource = logica.listarUsuarios()
        Catch ex As Exception
            Throw ex
        End Try
        Try

        ' ocultmos al bibliotecario para que no pueda crear usuarios bibliotecariosç
        Dim persona As New Persona
        If (persona.verificarGrupo(moverDatos.dni) = "bibliotecario") Then
            rbBibliotecario.Enabled = False
            lblBiblio.Enabled = True
            lblBiblio.Visible = True

        Else

            rbBibliotecario.Enabled = True
            lblBiblio.Enabled = False
            lblBiblio.Visible = False
        End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error")
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListarClientes.CellContentClick

    End Sub

    Private Sub btnAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdm.Click
        Dim Form As New FRMadmin

        FRMadmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnBuscarDni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDni.Click
        Try
            'llenamos el dataviewgrid pasandole el datatable que devuelve el usuario que coincida con el dni que escribimos en el txtBuscarDni
            dgvListarClientes.DataSource = logica.buscarUsuarioDni(txtBuscarDni.Text)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al listar los clientes")
        End Try
    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        Dim Form As New FRMinventario

        FRMinventario.Show()
        Me.Hide()
    End Sub

    Private Sub btnDevolvucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolvucion.Click
        Dim Form As New frmDevolucion

        frmDevolucion.Show()
        Me.Hide()
    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        MessageBox.Show("Utilidad aún no disponible")
    End Sub

    Private Sub btnBuscarNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarNombre.Click

        Try
            'llenamos el dataviewgrid pasandole el datatable que devuelve el usuario que coincida con el nombre y apellido
            dgvListarClientes.DataSource = logica.buscarUsuarioNombreApellido(txtBuscarNombre.Text, txtBuscarApellido.Text)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnModificarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCliente.Click
        Dim form As New frmModificarClienteAdmin
        frmModificarClienteAdmin.Show()

        Try

            ' logica para que los usuarios bibliotecarios no puedan modificar administradores
            Dim persona As New Persona
            If (persona.verificarGrupo(moverDatos.dni) = "bibliotecario") And ((persona.verificarGrupo(dgvListarClientes.SelectedCells(0).Value) = "administrador")) Then
                frmModificarClienteAdmin.txtDni.Enabled = False
                frmModificarClienteAdmin.txtNombre.Enabled = False
                frmModificarClienteAdmin.txtApellido.Enabled = False
                frmModificarClienteAdmin.txtEmail.Enabled = False
                frmModificarClienteAdmin.dtpFecha.Enabled = False

                MessageBox.Show("No es posible modificar usuarios administradores")
            End If

            ' relleno los campos a modificar en el panel MODIFICARCLIENTESADMIN para usuarios administradores
            frmModificarClienteAdmin.lblLabelCliente.Text = dgvListarClientes.SelectedCells(0).Value
            frmModificarClienteAdmin.txtDni.Text = dgvListarClientes.SelectedCells(0).Value
            frmModificarClienteAdmin.txtNombre.Text = dgvListarClientes.SelectedCells(1).Value
            frmModificarClienteAdmin.txtApellido.Text = dgvListarClientes.SelectedCells(2).Value
            frmModificarClienteAdmin.txtEmail.Text = logica.Desencriptar(dgvListarClientes.SelectedCells(3).Value)
            frmModificarClienteAdmin.dtpFecha.Value = dgvListarClientes.SelectedCells(4).Value

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error")

        End Try

    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Try
            dgvListarClientes.DataSource = logica.listarUsuarios()
        Catch ex As Exception

        End Try
    End Sub
End Class