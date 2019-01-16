Imports logica
Public Class FRMadmin
    Dim admin As New Administrador
    Dim libro As New Libro

    Private Sub btnDevolvucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolvucion.Click
        Dim Form As New frmDevolucion

        frmDevolucion.Show()
        Me.Hide()
    End Sub
    Private Sub btnAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Dim Form As New FRMinicio

        FRMinicio.Show()
        Me.Hide()
    End Sub
    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        Dim Form As New FRMinventario

        FRMinventario.Show()
        Me.Hide()
    End Sub
    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        Dim Form As New frmClientesAdm

        frmClientesAdm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub FRMadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbListaLibros.DropDownStyle = ComboBoxStyle.DropDownList
        pnlBusquedaCliente.Visible = False
        pnlBusquedaPeliculas.Visible = False
        Try

            'Relleno el combobox con la lista de libros
            Dim lista As New DataTable
            lista = admin.listarLibros

            cmbListaLibros.DisplayMember = "nombre"
            cmbListaLibros.ValueMember = "id_libro"
            cmbListaLibros.DataSource = lista

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error")
        End Try




    End Sub

    Private Sub btnBuscarCliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        pnlBusquedaPeliculas.Hide()
        pnlBusquedaCliente.Show()
        dgvAlquilerXCliente1.AllowUserToAddRows = False

        Try
            ' lleno el dgv de los libros con la funcion de la clase Persona
            dgvAlquilerXCliente1.DataSource = admin.listarLibrosEnAlquiler(txtBuscarCliente.Text)
            ' le doy estructura automatica al dgv
            dgvAlquilerXCliente1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            ' valido el nombre de usuario
            If Len(txtBuscarCliente.Text) = 0 Then
                MessageBox.Show("Debe ingresar un valor")
            ElseIf admin.verificarUsuario(txtBuscarCliente.Text) = False Then
                MessageBox.Show("El cliente ingresado es incorrecto")
                lblNombreDeCliente.Text = "Error de nombre de cliente"
                lblNombreDeCliente.Enabled = False
                txtBuscarCliente.Clear()
                txtBuscarCliente.Focus()
            Else
                ' Relleno el campo "Nombre Cliente" 
                admin.buscarNombre(txtBuscarCliente.Text)
                lblNombreDeCliente.Enabled = True
                lblNombreDeCliente.Text = admin.Nombre
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error")
        End Try

    End Sub

    Private Sub btnBuscarPelicula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPelicula.Click
        pnlBusquedaCliente.Hide()
        pnlBusquedaPeliculas.Show()
        Try
            'lleno el dgv con la funcion de la clase Persona
            dgvLibrosAlquiladosXUsuarios.DataSource = admin.listarLibrosAlquilados(cmbListaLibros.Text)
            ' le doy estructura automatica al dgv
            dgvLibrosAlquiladosXUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'relleno el label del nombre de libro
            lblNombreDeLibro.Text = cmbListaLibros.Text

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error")

        End Try

    End Sub

    Private Sub pnlBusuqedaPelicula_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub pnlBusquedaCliente_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBusquedaCliente.Paint

    End Sub

    Private Sub pnlBusquedaPelicula_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBusquedaPeliculas.Paint

    End Sub

    Private Sub txtNombrePelicula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        MessageBox.Show("Utilidad aún no disponible")
    End Sub

    Private Sub pnlAdm_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAdm.Paint

    End Sub

    Private Sub cmbListaLibros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbListaLibros.SelectedIndexChanged

    End Sub
End Class