Public Class frmDevolucion

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

    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        Dim form As New frmSocios

        frmSocios.Show()
        Me.Hide()
    End Sub
End Class