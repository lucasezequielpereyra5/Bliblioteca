Imports logica

Public Class frmMesa

    Private Sub BTNsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsalir.Click
        Dim frm As New frmBuscadorLibros

        frm.Show()
        frm.Refresh()
        Me.Hide()
    End Sub

    Private Sub frmMesa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xMesa As New Mesa
        Try

            Dim dt As DataTable = xMesa.consultar_lugar()

            Me.DataGridView1.DataSource = dt
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            If xMesa.chequearUsuario(dni) = 0 Then
                BTNDesocupar.Enabled = False
                Me.habilitarButtons(0)

            Else

                Me.habilitarButtons(1)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNOcupar.Click
        Try
            Dim xMesa As New Mesa

            If Me.s.Checked Then
                xMesa.id = 1
                Me.Timer1.Enabled = True

            ElseIf Me.RadioButton2.Checked = True Then
                xMesa.id = 2
                Me.Timer2.Enabled = True
            ElseIf Me.RadioButton3.Checked = True Then
                xMesa.id = 3
                Me.Timer3.Enabled = True
            ElseIf Me.RadioButton4.Checked = True Then
                xMesa.id = 4
                Me.Timer4.Enabled = True
            ElseIf Me.RadioButton5.Checked = True Then
                xMesa.id = 5
                Me.Timer5.Enabled = True
            ElseIf Me.RadioButton6.Checked = True Then
                xMesa.id = 6
                Me.Timer6.Enabled = True
            ElseIf Me.RadioButton7.Checked = True Then
                xMesa.id = 7
                Me.Timer7.Enabled = True
            ElseIf Me.RadioButton8.Checked = True Then
                xMesa.id = 8
                Me.Timer8.Enabled = True

            End If

            If Me.DataGridView1.Rows(xMesa.id - 1).Cells("estado").Value = "no" Then
                MessageBox.Show("Lugar ya ocupado.")
            Else

                xMesa.estado = "no"
                xMesa.dni = dni
                xMesa.id_libro = moverDatos.id_libro
                xMesa.ocupar(xMesa)
                Me.habilitarButtons(1)
                Me.DataGridView1.DataSource = xMesa.consultar_lugar()

                MessageBox.Show("Lugar " + xMesa.id.ToString + ". Tiene 60 minutos")


            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNDesocupar.Click
        Try
            Dim xMesa As New Mesa
            If Me.s.Checked Then
                xMesa.id = 1
                Me.Timer1.Enabled = False
            ElseIf Me.RadioButton2.Checked = True Then
                xMesa.id = 2
                Me.Timer2.Enabled = False
                '            lblTimer2.Text = "Lugar 2: Libre"
            ElseIf Me.RadioButton3.Checked = True Then
                xMesa.id = 3
                Me.Timer3.Enabled = False
                '           lblTimer3.Text = "Lugar 8: Libre"
            ElseIf Me.RadioButton4.Checked = True Then
                xMesa.id = 4
                Me.Timer4.Enabled = False

                '          lblTimer4.Text = "Lugar 4: Libre"
            ElseIf Me.RadioButton5.Checked = True Then
                xMesa.id = 5
                Me.Timer5.Enabled = False
                '         lblTimer5.Text = "Lugar 5: Libre"
            ElseIf Me.RadioButton6.Checked = True Then
                xMesa.id = 6
                Me.Timer6.Enabled = False

                '        lblTimer6.Text = "Lugar 8: Libre"
            ElseIf Me.RadioButton7.Checked = True Then
                xMesa.id = 7
                Me.Timer7.Enabled = False
                '       lblTimer7.Text = "Lugar 7: Libre"
            ElseIf Me.RadioButton8.Checked = True Then
                xMesa.id = 8
                Me.Timer8.Enabled = False
                '      lblTimer8.Text = "Lugar 8: Libre"
            End If

            Me.s.Enabled = True
            Me.RadioButton2.Enabled = True
            Me.RadioButton3.Enabled = True
            Me.RadioButton4.Enabled = True
            Me.RadioButton5.Enabled = True
            Me.RadioButton6.Enabled = True
            Me.RadioButton7.Enabled = True
            Me.RadioButton8.Enabled = True

            xMesa.estado = "si"
            xMesa.id_libro = moverDatos.id_libro
            xMesa.desocupar(xMesa)
            Me.DataGridView1.DataSource = xMesa.consultar_lugar()

        Catch ex As Exception

        End Try

    End Sub

    Dim xMesa As New Mesa
    Dim email As New Mail
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            If xMesa.obtenerHora(1) = 5 Then

                Me.Timer1.Enabled = False

                xMesa.estado = "si"
                xMesa.id = 1
                email.ultimo_aviso(1)
                xMesa.desocupar(xMesa)

                Timer1.Enabled = False
            End If

        Catch ex As Exception

        End Try

        'lblTimer1.Text = "Lugar 1: " & xMesa.obtenerHora(1).ToString
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try

            If xMesa.obtenerHora(2) = 0 Then

                Me.Timer2.Enabled = False

                xMesa.mail = email.obtenerMail(2)
                xMesa.id = 2

                xMesa.estado = "si"
                email.ultimo_aviso(xMesa.id)
                xMesa.desocupar(xMesa)

                Timer2.Enabled = False
            End If

        Catch ex As Exception

        End Try

        'lblTimer2.Text = "Lugar 2: " & xMesa.obtenerHora(2)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Try

            If xMesa.obtenerHora(3) = 0 Then

                Me.Timer3.Enabled = False

                xMesa.mail = email.obtenerMail(3)
                xMesa.id = 3

                xMesa.estado = "si"
                email.ultimo_aviso(xMesa.id)
                xMesa.desocupar(xMesa)

                Timer3.Enabled = False
            End If

        Catch ex As Exception

        End Try

        'lblTimer3.Text = "Lugar 3: " & xMesa.obtenerHora(3)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        Try

            If xMesa.obtenerHora(4) = 0 Then

                Me.Timer4.Enabled = False

                xMesa.id = 4

                xMesa.estado = "si"
                email.ultimo_aviso(xMesa.id)
                xMesa.desocupar(xMesa)

                Timer4.Enabled = False
            End If


        Catch ex As Exception

        End Try

        'lblTimer4.Text = "Lugar 4: " & xMesa.obtenerHora(4)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        Try
            Dim xMesa As New Mesa
            xMesa.mail = email.obtenerMail(5)
            xMesa.id = 5

            If xMesa.obtenerHora(5) = 0 Then
                Me.Timer5.Enabled = False
                xMesa.estado = "si"
                xMesa.desocupar(xMesa)
                email.ultimo_aviso(xMesa.id)
            End If
        Catch ex As Exception

        End Try

        'lblTimer5.Text = "Lugar 5: " & xMesa.obtenerHora(5)
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Try

            Dim xMesa As New Mesa
            xMesa.mail = email.obtenerMail(6)
            xMesa.id = 6

            If xMesa.obtenerHora(6) = 0 Then
                Me.Timer6.Enabled = False
                xMesa.estado = "si"
                xMesa.desocupar(xMesa)
                email.ultimo_aviso(xMesa.id)
            End If
        Catch ex As Exception

        End Try

        'lblTimer6.Text = "Lugar 6: " & xMesa.obtenerHora(6)
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Try

            Dim xMesa As New Mesa
            xMesa.mail = email.obtenerMail(7)
            xMesa.id = 7

            If xMesa.obtenerHora(7) = 0 Then
                Me.Timer7.Enabled = False
                xMesa.estado = "si"
                xMesa.desocupar(xMesa)
                email.ultimo_aviso(xMesa.id)
            End If
        Catch ex As Exception

        End Try

        'lblTimer6.Text = "Lugar 7: " & xMesa.obtenerHora(7)
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Try

            Dim xMesa As New Mesa
            xMesa.mail = email.obtenerMail(8)
            xMesa.id = 8
            If xMesa.obtenerHora(8) = 5 Then
                email.ultimo_aviso(8)
            End If

            If xMesa.obtenerHora(8) = 0 Then
                Me.Timer6.Enabled = False
                xMesa.estado = "si"
                xMesa.desocupar(xMesa)
                email.ultimo_aviso(xMesa.id)
            End If
        Catch ex As Exception

        End Try

        'lblTimer8.Text = "Lugar 8: " & xMesa.obtenerHora(8)
    End Sub



    Sub habilitarButtons(n As Integer)
        If n = 0 Then

            Me.s.Enabled = True
            Me.RadioButton2.Enabled = True
            Me.RadioButton3.Enabled = True
            Me.RadioButton4.Enabled = True
            Me.RadioButton5.Enabled = True
            Me.RadioButton6.Enabled = True
            Me.RadioButton7.Enabled = True
            Me.RadioButton8.Enabled = True

        Else
            BTNDesocupar.Enabled = True

            Dim xMesa As New Mesa
            Me.s.Enabled = False
            Me.RadioButton2.Enabled = False
            Me.RadioButton3.Enabled = False
            Me.RadioButton4.Enabled = False
            Me.RadioButton5.Enabled = False
            Me.RadioButton6.Enabled = False
            Me.RadioButton7.Enabled = False
            Me.RadioButton8.Enabled = False

            If xMesa.chequearUsuario(dni) = 1 Then
                Me.s.Enabled = True
            ElseIf xMesa.chequearUsuario(dni) = 2 Then
                Me.RadioButton2.Enabled = True
            ElseIf xMesa.chequearUsuario(dni) = 3 Then
                Me.RadioButton3.Enabled = True
            ElseIf xMesa.chequearUsuario(dni) = 4 Then
                Me.RadioButton4.Enabled = True
            ElseIf xMesa.chequearUsuario(dni) = 5 Then
                Me.RadioButton5.Enabled = True
            ElseIf xMesa.chequearUsuario(dni) = 6 Then
                Me.RadioButton6.Enabled = True
            ElseIf xMesa.chequearUsuario(dni) = 7 Then
                Me.RadioButton7.Enabled = True
            ElseIf xMesa.chequearUsuario(dni) = 8 Then
                Me.RadioButton8.Enabled = True

            End If
        End If

    End Sub

End Class