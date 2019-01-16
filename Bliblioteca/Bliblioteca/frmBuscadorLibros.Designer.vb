<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscadorLibros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAlquilar = New System.Windows.Forms.Button()
        Me.DGVlibros = New System.Windows.Forms.DataGridView()
        Me.BTNvolver = New System.Windows.Forms.Button()
        Me.btnSala = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cbBuscarPor = New System.Windows.Forms.ComboBox()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.lblFechaDeInicio = New System.Windows.Forms.Label()
        Me.lblFechaDeEntrega = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAlquilar
        '
        Me.btnAlquilar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlquilar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlquilar.Location = New System.Drawing.Point(428, 68)
        Me.btnAlquilar.Name = "btnAlquilar"
        Me.btnAlquilar.Size = New System.Drawing.Size(124, 50)
        Me.btnAlquilar.TabIndex = 2
        Me.btnAlquilar.Text = "Alquilar"
        Me.btnAlquilar.UseVisualStyleBackColor = True
        '
        'DGVlibros
        '
        Me.DGVlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlibros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGVlibros.Location = New System.Drawing.Point(43, 255)
        Me.DGVlibros.MultiSelect = False
        Me.DGVlibros.Name = "DGVlibros"
        Me.DGVlibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVlibros.Size = New System.Drawing.Size(767, 240)
        Me.DGVlibros.TabIndex = 5
        '
        'BTNvolver
        '
        Me.BTNvolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNvolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNvolver.Location = New System.Drawing.Point(428, 180)
        Me.BTNvolver.Name = "BTNvolver"
        Me.BTNvolver.Size = New System.Drawing.Size(124, 51)
        Me.BTNvolver.TabIndex = 9
        Me.BTNvolver.Text = "Volver"
        Me.BTNvolver.UseVisualStyleBackColor = True
        '
        'btnSala
        '
        Me.btnSala.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSala.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSala.Location = New System.Drawing.Point(428, 124)
        Me.btnSala.Name = "btnSala"
        Me.btnSala.Size = New System.Drawing.Size(124, 50)
        Me.btnSala.TabIndex = 16
        Me.btnSala.Text = "En Sala"
        Me.btnSala.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.frmPrincipal.My.Resources.Resources.lupa2
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(428, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(124, 50)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(40, 98)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(64, 13)
        Me.lblBuscar.TabIndex = 17
        Me.lblBuscar.Text = "Buscar por: "
        '
        'cbBuscarPor
        '
        Me.cbBuscarPor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBuscarPor.FormattingEnabled = True
        Me.cbBuscarPor.Location = New System.Drawing.Point(100, 95)
        Me.cbBuscarPor.Name = "cbBuscarPor"
        Me.cbBuscarPor.Size = New System.Drawing.Size(121, 21)
        Me.cbBuscarPor.TabIndex = 18
        '
        'txtBuscador
        '
        Me.txtBuscador.Location = New System.Drawing.Point(227, 98)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(170, 20)
        Me.txtBuscador.TabIndex = 19
        '
        'btnListar
        '
        Me.btnListar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(100, 157)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(121, 51)
        Me.btnListar.TabIndex = 20
        Me.btnListar.Text = "Listar todos los libros"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'lblFechaDeInicio
        '
        Me.lblFechaDeInicio.AutoSize = True
        Me.lblFechaDeInicio.Location = New System.Drawing.Point(583, 98)
        Me.lblFechaDeInicio.Name = "lblFechaDeInicio"
        Me.lblFechaDeInicio.Size = New System.Drawing.Size(41, 13)
        Me.lblFechaDeInicio.TabIndex = 22
        Me.lblFechaDeInicio.Text = "Desde:"
        '
        'lblFechaDeEntrega
        '
        Me.lblFechaDeEntrega.AutoSize = True
        Me.lblFechaDeEntrega.Location = New System.Drawing.Point(583, 161)
        Me.lblFechaDeEntrega.Name = "lblFechaDeEntrega"
        Me.lblFechaDeEntrega.Size = New System.Drawing.Size(38, 13)
        Me.lblFechaDeEntrega.TabIndex = 23
        Me.lblFechaDeEntrega.Text = "Hasta:"
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(631, 98)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.ReadOnly = True
        Me.txtDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtDesde.TabIndex = 25
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(631, 161)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(100, 20)
        Me.dtpHasta.TabIndex = 26
        '
        'frmBuscadorLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 519)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.lblFechaDeEntrega)
        Me.Controls.Add(Me.lblFechaDeInicio)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.cbBuscarPor)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnSala)
        Me.Controls.Add(Me.BTNvolver)
        Me.Controls.Add(Me.DGVlibros)
        Me.Controls.Add(Me.btnAlquilar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "frmBuscadorLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libros"
        CType(Me.DGVlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnAlquilar As System.Windows.Forms.Button
    Friend WithEvents DGVlibros As System.Windows.Forms.DataGridView
    Friend WithEvents BTNvolver As System.Windows.Forms.Button
    Friend WithEvents btnSala As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents cbBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscador As System.Windows.Forms.TextBox
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents lblFechaDeInicio As System.Windows.Forms.Label
    Friend WithEvents lblFechaDeEntrega As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
End Class
