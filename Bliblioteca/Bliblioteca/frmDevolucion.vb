Imports logica
Public Class frmDevolucion
    Dim logica As New Administrador
    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Dim Form As New FRMinicio

        FRMinicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        Dim Form As New frmClientesAdm

        frmClientesAdm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            dgvListaDevolucion.DataSource = logica.listarLibrosEnAlquiler(txtDni.Text)
            dgvListaDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdm.Click
        Dim Form As New FRMadmin

        FRMadmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        Dim Form As New FRMinventario

        FRMinventario.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDevolverLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDevolverLibro.Click
        Try
            'le pasamos el id y el dni
            If (txtDni.Text <> "") Then
                logica.devolverLibro(dgvListaDevolucion.SelectedCells(0).Value, txtDni.Text)
                dgvListaDevolucion.DataSource = logica.listarLibrosEnAlquiler(txtDni.Text)
                dgvListaDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                MessageBox.Show("Se devolvio con exito el libro id: " & dgvListaDevolucion.SelectedCells(0).Value & ", Nombre: " & dgvListaDevolucion.SelectedCells(1).Value)
            Else
                MessageBox.Show("por favor primero colque un DNI, luego presione la lupa y luego puede devolver libros")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        MessageBox.Show("Utilidad aún no disponible")
    End Sub

    Private Sub frmDevolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvListaDevolucion.DataSource = logica.listarLibrosAlquilados()
            dgvListaDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        txtDni.Text = ""
        Try
            dgvListaDevolucion.DataSource = logica.listarLibrosAlquilados()
            dgvListaDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class