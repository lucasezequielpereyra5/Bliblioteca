Public Class frmBuscadorLibros

    Private Sub frmBuscadorLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DGVlibros.Rows.Add("AAAA", "aaaa", "aaaaa", "bbbb", "4444", "bbbbb", "5")
        DGVlibros.Rows.Add("cccc", "aaaa", "aaaaa", "bbbb", "4444", "bbbbb", "1")
        DGVlibros.Rows.Add("dddd", "aaaa", "aaaaa", "bbbb", "4444", "bbbbb", "4")
        DGVlibros.Rows.Add("eeee", "aaaa", "aaaaa", "bbbb", "4444", "bbbbb", "6")
        DGVlibros.Rows.Add("fffff", "aaaa", "aaaaa", "bbbb", "4444", "bbbbb", "7")

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVlibros.CellContentClick

    End Sub

    Private Sub BTNvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNvolver.Click
        Dim frm As New frmCliente
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLgenero.Click

    End Sub
End Class