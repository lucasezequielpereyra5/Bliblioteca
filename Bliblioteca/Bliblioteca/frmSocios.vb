Public Class frmSocios

    Private Sub frmSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Dim Form As New FRMinicio

        FRMinicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        Dim Form As New frmClientesAdm

        FRMinicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdm.Click
        Dim Form As New FRMadmin

        FRMinicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        Dim Form As New FRMinventario

        FRMinicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnDevolvucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolvucion.Click
        Dim Form As New frmDevolucion

        FRMinicio.Show()
        Me.Hide()
    End Sub
End Class