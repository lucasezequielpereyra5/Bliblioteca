Imports logica
Public Class frmModificarLibrosAdmin
    Dim logica As New Administrador

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim xLibro As New Libro
            xLibro.Nombre = txtNombre.Text
            xLibro.Descripcion = txtDescrp.Text
            xLibro.Autor = txtAutor.Text
            xLibro.Editorial = txtEdit.Text
            xLibro.Genero = txtGenero.Text
            xLibro.Precio = txtPrecio.Text
            xLibro.Stock = txtStock.Text

            logica.modificarLibro(xLibro, txtId.Text)
            MessageBox.Show("Modificación realizada")
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error")
        End Try

        Try

            FRMinventario.dgvListaLibro.DataSource = logica.listarLibros()


        Catch ex As Exception

            Debug.Print("Problema en logica: " & ex.ToString)

        End Try
    End Sub

    Private Sub frmModificarLibrosAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtId.ReadOnly = True
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
    End Sub
End Class