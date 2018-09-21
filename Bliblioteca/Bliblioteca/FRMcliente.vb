Public Class frmCliente


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscarLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarLibro.Click
        Dim frm As New frmBuscadorLibros
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub lblDatosUsuarioç_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDatosDeLibros.Click

    End Sub

    Private Sub btnAjustes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjustes.Click
        Dim frm As New frmAjustes
        frm.Show()
        Me.Hide()


    End Sub

    Private Sub BTNsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsalir.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea volver a inicio?", vbYesNo, "Salir del Modulo")
        If Msg = MsgBoxResult.Yes Then
            Dim frm As New frmPrincipal
            frm.Show()
            Me.Hide()

        Else
            Exit Sub
        End If
    End Sub
End Class
