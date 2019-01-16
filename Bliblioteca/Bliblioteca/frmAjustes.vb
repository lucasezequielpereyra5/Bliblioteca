Imports logica

Public Class frmAjustes
    Dim dni As Integer
    Dim cliente As New Cliente
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblEmail.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCont.Click

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If cliente.Encriptar(txtPw.Text) = cliente.Password Then
                If (txtContraseñaNueva.Text = txtReingresarContraseña.Text) Then
                    cliente.modificarPass(frmPrincipal.dni, txtContraseñaNueva.Text)
                    MessageBox.Show("contraseña actualizada!")
                    txtPw.Text = ""
                    txtContraseñaNueva.Text = ""
                    txtReingresarContraseña.Text = ""
                Else
                    MessageBox.Show("Las contraseñas ingresadas no coinciden")
                End If
            Else
                MessageBox.Show("La contraseña ingresada es incorrecta")
            End If
        Catch ex As Exception

        End Try
        
        
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
        txtPw.UseSystemPasswordChar = True
        txtContraseñaNueva.UseSystemPasswordChar = True
        txtReingresarContraseña.UseSystemPasswordChar = True

        ' Se rellena datos de ajustes de cliente desde el metodo buscarNombre de la clase cliente
        cliente.buscarNombre(moverDatos.dni)
        ' Se da valores a los campos a llenar 
        LBLnom.Text = cliente.Nombre
        LBLape.Text = cliente.Apellido
        lblFechaDeNac.Text = cliente.FechaDeNac
        'desencriptamos el email para mostrarselo al usuario.
        lblEmail2.Text = cliente.Desencriptar(cliente.Email)

    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFechaDeNac.Click

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

    Private Sub LBLnom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLnom.Click

    End Sub

    Public Sub recibirDni(ByVal dni As Integer)
        Me.dni = dni
    End Sub
End Class