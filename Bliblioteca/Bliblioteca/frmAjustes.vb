Imports logica

Public Class frmAjustes

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblEmail.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCont.Click

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Dim frm As New frmCliente
        frm.Show()

        Me.Hide()

    End Sub

    Private Sub txtContraseñaNueva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseñaNueva.TextChanged

    End Sub

    Private Sub frmAjustes_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim frm As New frmCliente
        frm.Show()

        Me.Hide()
    End Sub

    Private Sub frmAjustes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Se rellena datos de ajustes de cliente desde la base de datos
        Dim xCliente As New Cliente
        txtContraseña.Text = xCliente.Password

    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEdad2.Click

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub
End Class