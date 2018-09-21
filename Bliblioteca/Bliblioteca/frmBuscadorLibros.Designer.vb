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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAlquilar = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DGVlibros = New System.Windows.Forms.DataGridView()
        Me.Libro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblDatosLibros = New System.Windows.Forms.Label()
        Me.BTNvolver = New System.Windows.Forms.Button()
        Me.TXTautor = New System.Windows.Forms.TextBox()
        Me.LBLeditorial = New System.Windows.Forms.Label()
        Me.LBLgenero = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.DGVlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(109, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(222, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btnAlquilar
        '
        Me.btnAlquilar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlquilar.Location = New System.Drawing.Point(428, 82)
        Me.btnAlquilar.Name = "btnAlquilar"
        Me.btnAlquilar.Size = New System.Drawing.Size(124, 50)
        Me.btnAlquilar.TabIndex = 2
        Me.btnAlquilar.Text = "Alquilar"
        Me.btnAlquilar.UseVisualStyleBackColor = True
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(37, 73)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(57, 16)
        Me.lblBuscar.TabIndex = 3
        Me.lblBuscar.Text = "Nombre:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(583, 12)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'DGVlibros
        '
        Me.DGVlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVlibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Libro, Me.Descripcion, Me.Autor, Me.Editorial, Me.Genero, Me.Precio, Me.Stock})
        Me.DGVlibros.Location = New System.Drawing.Point(43, 241)
        Me.DGVlibros.Name = "DGVlibros"
        Me.DGVlibros.Size = New System.Drawing.Size(745, 240)
        Me.DGVlibros.TabIndex = 5
        '
        'Libro
        '
        Me.Libro.HeaderText = "Libro"
        Me.Libro.Name = "Libro"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Autor
        '
        Me.Autor.HeaderText = "Autor"
        Me.Autor.Name = "Autor"
        '
        'Editorial
        '
        Me.Editorial.HeaderText = "Editorial"
        Me.Editorial.Name = "Editorial"
        '
        'Genero
        '
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(40, 110)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(43, 16)
        Me.lblAutor.TabIndex = 6
        Me.lblAutor.Text = "Autor:"
        '
        'lblDatosLibros
        '
        Me.lblDatosLibros.AutoSize = True
        Me.lblDatosLibros.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosLibros.Location = New System.Drawing.Point(37, 31)
        Me.lblDatosLibros.Name = "lblDatosLibros"
        Me.lblDatosLibros.Size = New System.Drawing.Size(109, 18)
        Me.lblDatosLibros.TabIndex = 8
        Me.lblDatosLibros.Text = "Datos del libro"
        '
        'BTNvolver
        '
        Me.BTNvolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNvolver.Location = New System.Drawing.Point(428, 152)
        Me.BTNvolver.Name = "BTNvolver"
        Me.BTNvolver.Size = New System.Drawing.Size(124, 51)
        Me.BTNvolver.TabIndex = 9
        Me.BTNvolver.Text = "Volver"
        Me.BTNvolver.UseVisualStyleBackColor = True
        '
        'TXTautor
        '
        Me.TXTautor.Location = New System.Drawing.Point(109, 110)
        Me.TXTautor.Name = "TXTautor"
        Me.TXTautor.Size = New System.Drawing.Size(222, 20)
        Me.TXTautor.TabIndex = 10
        '
        'LBLeditorial
        '
        Me.LBLeditorial.AutoSize = True
        Me.LBLeditorial.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLeditorial.Location = New System.Drawing.Point(39, 141)
        Me.LBLeditorial.Name = "LBLeditorial"
        Me.LBLeditorial.Size = New System.Drawing.Size(59, 16)
        Me.LBLeditorial.TabIndex = 11
        Me.LBLeditorial.Text = "Editorial:"
        '
        'LBLgenero
        '
        Me.LBLgenero.AutoSize = True
        Me.LBLgenero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLgenero.Location = New System.Drawing.Point(40, 171)
        Me.LBLgenero.Name = "LBLgenero"
        Me.LBLgenero.Size = New System.Drawing.Size(54, 16)
        Me.LBLgenero.TabIndex = 13
        Me.LBLgenero.Text = "Genero:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 171)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(222, 20)
        Me.TextBox2.TabIndex = 15
        '
        'btnBuscar
        '
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
        'frmBuscadorLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 503)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LBLgenero)
        Me.Controls.Add(Me.LBLeditorial)
        Me.Controls.Add(Me.TXTautor)
        Me.Controls.Add(Me.BTNvolver)
        Me.Controls.Add(Me.lblDatosLibros)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.DGVlibros)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnAlquilar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "frmBuscadorLibros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libros"
        CType(Me.DGVlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnAlquilar As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents DGVlibros As System.Windows.Forms.DataGridView
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents lblDatosLibros As System.Windows.Forms.Label
    Friend WithEvents BTNvolver As System.Windows.Forms.Button
    Friend WithEvents TXTautor As System.Windows.Forms.TextBox
    Friend WithEvents LBLeditorial As System.Windows.Forms.Label
    Friend WithEvents LBLgenero As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Libro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Editorial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
