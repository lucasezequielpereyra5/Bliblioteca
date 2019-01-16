Imports logica
Public Class frmCliente
    Dim cliente As New Cliente

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvListrarLibrosAlquiler.AllowUserToAddRows = False

        Try
            dgvListrarLibrosAlquiler.DataSource = cliente.listarLibrosEnAlquiler(moverDatos.dni)
            dgvListrarLibrosAlquiler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'MessageBox.Show(moverDatos.dni)
        Catch ex As Exception
            Throw ex
        End Try
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
            Application.Restart()

        Else
            Exit Sub
        End If


    End Sub

    Private Sub dgvListrarLibrosAlquiler_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListrarLibrosAlquiler.CellContentClick

    End Sub
End Class
