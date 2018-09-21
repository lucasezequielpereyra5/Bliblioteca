Public Class FRMinventario

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


    End Sub

    Private Sub FRMinventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlModificaLibro.Visible = False
    End Sub

    Private Sub pnlModificarLibro_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlModificaLibro.Paint

    End Sub

    Private Sub btnDevolvucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolvucion.Click
        Dim Form As New frmDevolucion

        frmDevolucion.Show()
        Me.Hide()
    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        Dim form As New frmSocios

        frmSocios.Show()
        Me.Hide()
    End Sub
End Class