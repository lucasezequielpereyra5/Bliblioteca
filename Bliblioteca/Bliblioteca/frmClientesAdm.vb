Imports System.Text.RegularExpressions
Imports logica
Public Class frmClientesAdm
    Dim logica As New Administrador

    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click
        Dim Form As New FRMinicio

        FRMinicio.Show()
        Me.Hide()
    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub btnAltas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltas.Click
        pnlAlta.Show()
        pnlModif.Hide()

    End Sub


    Private Sub pnlAlta_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAlta.Paint

        If txtPass2.Text <> txtPass.Text Then
            lblPass2.Text = "Las contraseñas no coinciden"
        Else
            lblPass2.Text = "Las contraseñas concden"
        End If
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDni.TextChanged

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtEdad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged

    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub txtPass2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass2.TextChanged
        txtPass2.PasswordChar = "*"
    End Sub

    Private Sub lblPass2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPass2.Click


    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim xCliente As New Cliente

        If Not IsNumeric(txtDni.Text) Then
            MessageBox.Show("Se espera un numero entero")
            txtDni.Focus()
        ElseIf txtDni.Text.Length > 5 And txtDni.Text.Length < 9 Then
            MessageBox.Show("Se espera un numero entero y de 6 a 8 caracteres")
        End If

        If IsNumeric(txtNombre.Text) Then
            MessageBox.Show("Se espera una cadena de caracteres")
            txtNombre.Focus()
        ElseIf txtNombre.Text.Length > 20 Then
            MessageBox.Show("Nombre muy largo")
            txtNombre.Focus()
        End If

        If IsNumeric(txtApellido.Text) Then
            MessageBox.Show("Se espera una cadena de caracteres")
            txtApellido.Focus()
        ElseIf txtApellido.Text.Length > 20 Then
            MessageBox.Show("Nombre muy largo")
            txtApellido.Focus()
        End If

        Dim bln As Boolean = IsValidEmail(txtMail.Text)
        If bln = False Then
            MessageBox.Show("Verifique Email Formato Incorrecto")
            txtMail.Focus()
            Exit Sub
        End If

        If txtPass2.Text <> txtPass.Text Then
            MessageBox.Show("Las contraseñas no coinciden")
        End If

        xCliente.Dni = txtDni.Text
        xCliente.Nombre = txtNombre.Text
        xCliente.Apellido = txtApellido.Text
        xCliente.FechaDeNac = dtpFechaNac.Value
        xCliente.Email = txtMail.Text
        xCliente.Password = txtPass.Text

        '' MessageBox.Show(xCliente.FechaDeNac.Date.Year & "-" & xCliente.FechaDeNac.Date.Month & "-" & xCliente.FechaDeNac.Date.Day)


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        pnlModif.Show()
        pnlAlta.Hide()


    End Sub

    Private Sub pnlModif_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlModif.Paint

    End Sub

    Private Sub FRMcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlModif.Visible = False
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdm.Click
        Dim Form As New FRMadmin

        FRMadmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnBuscarDni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDni.Click

    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        Dim Form As New FRMinventario

        FRMinventario.Show()
        Me.Hide()
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