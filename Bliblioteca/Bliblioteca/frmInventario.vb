Imports logica

Public Class FRMinventario
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

    Private Sub btnAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdm.Click
        Dim Form As New FRMadmin

        FRMadmin.Show()
        Me.Hide()
    End Sub

    Private Sub pnlAltaArticulo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAltaArticulo.Paint

    End Sub

    Private Sub btnAltaStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaStock.Click
        pnlAltaArticulo.Show()
        pnlModificaLibro.Hide()



    End Sub

    Private Sub btnModifStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifStock.Click

        pnlModificaLibro.Show()
        pnlModificaLibro.Visible = True
        pnlAltaArticulo.Hide()

        Try

            dgvListaLibro.DataSource = logica.listarLibros()


        Catch ex As Exception

            Debug.Print("Problema en logica: " & ex.ToString)

        End Try


    End Sub

    Private Sub FRMinventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlModificaLibro.Visible = False
        dgvListaLibro.AllowUserToAddRows = False
        dgvListaLibro.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub pnlModificarLibro_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlModificaLibro.Paint

    End Sub

    Private Sub btnDevolvucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolvucion.Click
        Dim Form As New frmDevolucion

        frmDevolucion.Show()
        Me.Hide()
    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        MessageBox.Show("Utilidad aún no disponible")
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim xLibro As New Libro

        xLibro.Autor = txtAutor.Text
        xLibro.Descripcion = txtDescrip.Text
        xLibro.Editorial = txtEditorial.Text
        xLibro.Genero = txtGenero.Text
        xLibro.Nombre = txtNombre.Text
        xLibro.Precio = txtPrecio.Text
        xLibro.Stock = txtCantidad.Text

        Try

            logica.altaLibro(xLibro)
            MessageBox.Show("Se agrego Libro al inventario")
            txtAutor.Text = ""
            txtDescrip.Text = ""
            txtEditorial.Text = ""
            txtGenero.Text = ""
            txtNombre.Text = ""
            txtPrecio.Text = ""
            txtCantidad.Text = ""
        Catch ex As Exception
            Debug.Print("Problema en logica: " & ex.ToString)

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListaLibro.CellContentClick

    End Sub

    Private Sub pnlInventario_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlInventario.Paint

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim form As New frmModificarLibrosAdmin
        frmModificarLibrosAdmin.Show()

        Try
            ' relleno los campos a modificar en el panel MODIFICARLIBROSADMIN
            frmModificarLibrosAdmin.lblNombreLibro.Text = dgvListaLibro.SelectedCells(1).Value
            frmModificarLibrosAdmin.txtId.Text = dgvListaLibro.SelectedCells(0).Value
            frmModificarLibrosAdmin.txtNombre.Text = dgvListaLibro.SelectedCells(1).Value
            frmModificarLibrosAdmin.txtDescrp.Text = dgvListaLibro.SelectedCells(2).Value
            frmModificarLibrosAdmin.txtAutor.Text = dgvListaLibro.SelectedCells(3).Value
            frmModificarLibrosAdmin.txtEdit.Text = dgvListaLibro.SelectedCells(4).Value
            frmModificarLibrosAdmin.txtGenero.Text = dgvListaLibro.SelectedCells(5).Value
            frmModificarLibrosAdmin.txtPrecio.Text = dgvListaLibro.SelectedCells(6).Value
            frmModificarLibrosAdmin.txtStock.Text = dgvListaLibro.SelectedCells(7).Value

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error")
        End Try

    End Sub
End Class