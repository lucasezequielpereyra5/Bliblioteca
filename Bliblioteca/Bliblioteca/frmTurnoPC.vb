Imports logica

Public Class frmTurnoPC
    Dim persona As New Persona

    Private Sub turnoPC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (persona.verificarGrupo(dni) = "usuario") Then

            BTNDesocupar1.Visible = False
            BTNDesocupar2.Visible = False
            BTNDesocupar3.Visible = False

        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNPC1.Click
        Dim t As New SalaPC
        t.id = 1
        t.dni_cliente = moverDatos.dni

        If t.chequear(t.dni_cliente) = 0 Then

            MessageBox.Show("Pc 1. Tenés 60 minutos.")
            t.ocuparPC(t)
            BTNPC1.Enabled = False
            ' activa el timer que va a controlar el tiempo
            Timer1.Enabled = True

        Else

            MessageBox.Show("Tu DNI ya se encuentra registrado en una PC.")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNPc2.Click
        Dim t As New SalaPC
        t.id = 2
        t.dni_cliente = moverDatos.dni
        If t.chequear(t.dni_cliente) = 0 Then
            MessageBox.Show("Pc 2. Tenés 60 minutos.")
            t.ocuparPC(t)
            BTNPc2.Enabled = False
            ' activa el timer que va a controlar el tiempo
            Timer2.Enabled = True

        Else

            MessageBox.Show("Tu DNI ya se encuentra registrado en una PC.")

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNPc3.Click
        Dim t As New SalaPC
        t.id = 3
        t.dni_cliente = moverDatos.dni

        If t.chequear(t.dni_cliente) = 0 Then
            MessageBox.Show("Pc 3. Tenés 60 minutos.")
            BTNPc2.Enabled = False
            t.ocuparPC(t)
            ' activa el timer que va a controlar el tiempo
            Timer3.Enabled = True

        Else
            MessageBox.Show("Tu DNI ya se encuentra registrado en una PC.")

        End If

    End Sub


    Dim m = 60
    Dim s = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As New SalaPC

        If s = 0 Then
            m = m - 1
            s = 59
        ElseIf s > 0 Then
            s = s - 1
        End If

        lblTimer1.Text = m & ":" & s

        If m = 0 And s = 0 Then
            m = 60
            s = 0

            t.id = 1
            t.desocuparPC(t)

            Timer1.Enabled = False
            BTNPC1.Enabled = True
            lblTimer1.Text = "Libre"

        End If
    End Sub

    Dim m2 As Integer = 60
    Dim s2 As Integer = 0

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim t As New SalaPC
        If s2 = 0 Then
            m2 = m2 - 1
            s2 = 59
        ElseIf s2 > 0 Then
            s2 = s2 - 1
        End If

        lblTimer2.Text = m & ":" & s

        If m2 = 0 Then
            t.id = 2
            t.desocuparPC(t)

            Timer2.Enabled = False
            BTNPc2.Enabled = True
        End If

    End Sub

    Dim m3 As Integer = 60
    Dim s3 As Integer = 0
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim t As New SalaPC
        m3 = m3 - 1
        If s3 = 0 Then
            m3 = m3 - 1
            s3 = 59
        ElseIf s > 0 Then
            s3 = s3 - 1
        End If

        lblTimer3.Text = m & ":" & s

        If m3 = 0 Then
            t.id = 3
            t.desocuparPC(t)

            Timer3.Enabled = False
            BTNPc3.Enabled = True
        End If

    End Sub

    Private Sub BTNsalir_Click(sender As Object, e As EventArgs) Handles BTNsalir.Click

        If (persona.verificarGrupo(dni) = "usuario") Then
            Dim frm As New frmCliente
            frm.Show()

        ElseIf (persona.verificarGrupo(dni) = "bibliotecario") Then
            ' Dim frm As New 
            ' frm.Show()
        End If

        Me.Hide()

    End Sub

    Private Sub BTNDesocupar1_Click(sender As Object, e As EventArgs) Handles BTNDesocupar1.Click
        Dim t As New SalaPC
        t.id = 1
        Timer1.Enabled = False
        BTNPC1.Enabled = True
        t.desocuparPC(t)
    End Sub

    Private Sub BTNDesocupar2_Click(sender As Object, e As EventArgs) Handles BTNDesocupar2.Click
        Dim t As New SalaPC
        t.id = 2
        Timer2.Enabled = False
        BTNPc2.Enabled = True
        t.desocuparPC(t)

    End Sub

    Private Sub BTNDesocupar3_Click(sender As Object, e As EventArgs) Handles BTNDesocupar3.Click
        Dim t As New SalaPC
        t.id = 2
        Timer3.Enabled = False
        BTNPc3.Enabled = True
        t.desocuparPC(t)

    End Sub
End Class