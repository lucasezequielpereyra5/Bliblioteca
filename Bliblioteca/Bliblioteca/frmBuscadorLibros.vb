Imports logica
Public Class frmBuscadorLibros
    Dim persona As New Persona
    Dim libro As New Libro

    Private Sub frmBuscadorLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGVlibros.AllowUserToAddRows = False

        ' relleno la grilla de libros
        DGVlibros.DataSource = persona.listarLibros()
        DGVlibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        cbBuscarPor.Items.Add("Nombre")
        cbBuscarPor.Items.Add("Autor")
        cbBuscarPor.Items.Add("Editorial")
        cbBuscarPor.Items.Add("Genero")
        cbBuscarPor.SelectedIndex = 0
        'seteo el txt para que muestra la fecha del dia segun el sistema operativo
        txtDesde.Text = Now.Date
        'muestro el minimo desde cuando se puede pedir
        dtpHasta.MinDate = Now
        'asigno el maximo del datetimepicker para que solo se pueda hasta 7 dias como maximo.
        dtpHasta.MaxDate = DateTime.Today.AddDays(7)

    End Sub

    

    Private Sub BTNvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNvolver.Click
        Dim frm As New frmCliente
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSala.Click
        Dim frm As New frmMesa
        moverDatos.id_libro = DGVlibros.CurrentRow.Cells(0).Value
        Me.Hide()

        frm.Show()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'buscamos libros por nombre, autor, editorial y genero.
        If (cbBuscarPor.SelectedItem.ToString = "Nombre") Then
            If (persona.buscarLibroPorNombre(txtBuscador.Text).Rows.Count > 0) Then
                DGVlibros.DataSource = persona.buscarLibroPorNombre(txtBuscador.Text)
            Else
                MessageBox.Show("El libro que esta intentando buscar por el nombre de '" & txtBuscador.Text & "' no se encuentra en el inventario, lo sentimos!")
            End If

        ElseIf (cbBuscarPor.SelectedItem.ToString = "Autor") Then
            If (persona.buscarLibroPorAutor(txtBuscador.Text).Rows.Count > 0) Then
                DGVlibros.DataSource = persona.buscarLibroPorAutor(txtBuscador.Text)
            Else
                MessageBox.Show("No se encontro ningun libro por ese autor")
            End If

        ElseIf (cbBuscarPor.SelectedItem.ToString = "Editorial") Then
            If (persona.buscarLibroPorEditorial(txtBuscador.Text).Rows.Count > 0) Then
                DGVlibros.DataSource = persona.buscarLibroPorEditorial(txtBuscador.Text)
            Else
                MessageBox.Show("No se encontro ningun libro por esa editorial")
            End If

        ElseIf (cbBuscarPor.SelectedItem.ToString = "Genero") Then
            If (persona.buscarLibroPorGenero(txtBuscador.Text).Rows.Count > 0) Then
                DGVlibros.DataSource = persona.buscarLibroPorGenero(txtBuscador.Text)
            Else
                MessageBox.Show("No se encontro ningun libro por ese genero")
            End If


        End If
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        'listamos los libros
        Try
            DGVlibros.DataSource = persona.listarLibros()
            txtBuscador.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mcCalendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
        'txtFechaDeAlquiler.Text = mcCalendario.SelectionRange.Start
        'txtFechaDeDevolucion.Text = mcCalendario.SelectionRange.End
    End Sub

    Private Sub btnAlquilar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlquilar.Click
        'hacemos una alta de alquiler
        Try
            'tomamos el valor de la columna id de la fila seleccionada
            libro.Id = DGVlibros.SelectedRows.Item(0).Cells(0).Value
            libro.Nombre = DGVlibros.SelectedRows.Item(0).Cells(1).Value
            'MessageBox.Show(libro.Id)
            'MessageBox.Show(moverDatos.dni)
           
            Dim Msg As MsgBoxResult
            Msg = MsgBox("¿Desea alquilar el libro: '" & libro.Nombre & "' ?", vbYesNo, "Alquilar")
            If Msg = MsgBoxResult.Yes Then
                libro.guardarAlquiler(moverDatos.dni, libro.Id, txtDesde.Text, dtpHasta.Value)
                'despues de hacer la alta de alquiler, actualizamos la lista para mostrar el stock actualizado.
                DGVlibros.DataSource = persona.listarLibros()

                MessageBox.Show("Pase por la mesa del Bibliotecario que le entregara el libro!" & vbLf & "Gracias!")
            Else
                Exit Sub
            End If
            

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHasta.ValueChanged

    End Sub
End Class