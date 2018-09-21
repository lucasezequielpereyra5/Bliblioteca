Public Class FRMadmin

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
        pnlBusquedaCliente.Visible = False
        pnlBusquedaPeliculas.Visible = False
    End Sub

    Private Sub btnBuscarCliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCliente.Click
        pnlBusquedaPeliculas.Hide()
        pnlBusquedaCliente.Show()
        txtNombrePelicula.Text = txtBuscarCliente.Text

    End Sub

    Private Sub btnBuscarPelicula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPelicula.Click
        pnlBusquedaCliente.Hide()
        pnlBusquedaPeliculas.Show()

    End Sub

    Private Sub pnlBusuqedaPelicula_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub pnlBusquedaCliente_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBusquedaCliente.Paint
        txtNombreCliente.Text = txtBuscarCliente.Text

    End Sub

    Private Sub pnlBusquedaPelicula_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlBusquedaPeliculas.Paint
        txtNombrePelicula.Text = txtBuscarCliente.Text
    End Sub

    Private Sub txtNombrePelicula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombrePelicula.TextChanged
        txtNombrePelicula.Text = txtBuscarCliente.Text

    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        Dim form As New frmSocios

        frmSocios.Show()
        Me.Hide()
    End Sub
End Class