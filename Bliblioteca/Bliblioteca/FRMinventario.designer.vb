<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMinventario
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
        Me.btnDevolvucion = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.pnlInventario = New System.Windows.Forms.Panel()
        Me.pnlModificaLibro = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnAutor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnEdit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnGenero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnlAltaArticulo = New System.Windows.Forms.Panel()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtEditorial = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModifStock = New System.Windows.Forms.Button()
        Me.btnAltaStock = New System.Windows.Forms.Button()
        Me.btnSocios = New System.Windows.Forms.Button()
        Me.pnlInventario.SuspendLayout()
        Me.pnlModificaLibro.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAltaArticulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDevolvucion
        '
        Me.btnDevolvucion.Location = New System.Drawing.Point(411, 12)
        Me.btnDevolvucion.Name = "btnDevolvucion"
        Me.btnDevolvucion.Size = New System.Drawing.Size(127, 23)
        Me.btnDevolvucion.TabIndex = 7
        Me.btnDevolvucion.Text = "Devoluciones"
        Me.btnDevolvucion.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 12)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(127, 23)
        Me.btnInicio.TabIndex = 6
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnAdm
        '
        Me.btnAdm.Location = New System.Drawing.Point(278, 12)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(127, 23)
        Me.btnAdm.TabIndex = 5
        Me.btnAdm.Text = "Administracion"
        Me.btnAdm.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(145, 12)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(127, 23)
        Me.btnCliente.TabIndex = 4
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'pnlInventario
        '
        Me.pnlInventario.Controls.Add(Me.pnlModificaLibro)
        Me.pnlInventario.Controls.Add(Me.pnlAltaArticulo)
        Me.pnlInventario.Controls.Add(Me.btnModifStock)
        Me.pnlInventario.Controls.Add(Me.btnAltaStock)
        Me.pnlInventario.Location = New System.Drawing.Point(12, 42)
        Me.pnlInventario.Name = "pnlInventario"
        Me.pnlInventario.Size = New System.Drawing.Size(659, 468)
        Me.pnlInventario.TabIndex = 9
        '
        'pnlModificaLibro
        '
        Me.pnlModificaLibro.Controls.Add(Me.DataGridView1)
        Me.pnlModificaLibro.Controls.Add(Me.Label10)
        Me.pnlModificaLibro.Location = New System.Drawing.Point(7, 54)
        Me.pnlModificaLibro.Name = "pnlModificaLibro"
        Me.pnlModificaLibro.Size = New System.Drawing.Size(652, 413)
        Me.pnlModificaLibro.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnId, Me.clnDescrip, Me.clnAutor, Me.clnEdit, Me.clnGenero, Me.clnPrecio, Me.clnCantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(653, 363)
        Me.DataGridView1.TabIndex = 1
        '
        'clnId
        '
        Me.clnId.HeaderText = "ID"
        Me.clnId.Name = "clnId"
        Me.clnId.ReadOnly = True
        Me.clnId.Width = 25
        '
        'clnDescrip
        '
        Me.clnDescrip.HeaderText = "Descripcion"
        Me.clnDescrip.Name = "clnDescrip"
        '
        'clnAutor
        '
        Me.clnAutor.HeaderText = "Autor"
        Me.clnAutor.Name = "clnAutor"
        '
        'clnEdit
        '
        Me.clnEdit.HeaderText = "Editorial"
        Me.clnEdit.Name = "clnEdit"
        '
        'clnGenero
        '
        Me.clnGenero.HeaderText = "Genero"
        Me.clnGenero.Name = "clnGenero"
        Me.clnGenero.Width = 70
        '
        'clnPrecio
        '
        Me.clnPrecio.HeaderText = "Precio"
        Me.clnPrecio.Name = "clnPrecio"
        Me.clnPrecio.Width = 50
        '
        'clnCantidad
        '
        Me.clnCantidad.HeaderText = "Cantidad"
        Me.clnCantidad.Name = "clnCantidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Lista de Libros:"
        '
        'pnlAltaArticulo
        '
        Me.pnlAltaArticulo.Controls.Add(Me.btnAgregar)
        Me.pnlAltaArticulo.Controls.Add(Me.txtCantidad)
        Me.pnlAltaArticulo.Controls.Add(Me.txtPrecio)
        Me.pnlAltaArticulo.Controls.Add(Me.txtGenero)
        Me.pnlAltaArticulo.Controls.Add(Me.txtEditorial)
        Me.pnlAltaArticulo.Controls.Add(Me.txtAutor)
        Me.pnlAltaArticulo.Controls.Add(Me.txtDescrip)
        Me.pnlAltaArticulo.Controls.Add(Me.txtNombre)
        Me.pnlAltaArticulo.Controls.Add(Me.Label8)
        Me.pnlAltaArticulo.Controls.Add(Me.Label7)
        Me.pnlAltaArticulo.Controls.Add(Me.Label6)
        Me.pnlAltaArticulo.Controls.Add(Me.Label5)
        Me.pnlAltaArticulo.Controls.Add(Me.Label4)
        Me.pnlAltaArticulo.Controls.Add(Me.Label3)
        Me.pnlAltaArticulo.Controls.Add(Me.Label2)
        Me.pnlAltaArticulo.Controls.Add(Me.Label9)
        Me.pnlAltaArticulo.Controls.Add(Me.Label1)
        Me.pnlAltaArticulo.Location = New System.Drawing.Point(4, 55)
        Me.pnlAltaArticulo.Name = "pnlAltaArticulo"
        Me.pnlAltaArticulo.Size = New System.Drawing.Size(652, 413)
        Me.pnlAltaArticulo.TabIndex = 2
        Me.pnlAltaArticulo.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(313, 371)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(204, 23)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar Libro"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(150, 306)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 14
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(150, 276)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 13
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(150, 242)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(239, 20)
        Me.txtGenero.TabIndex = 12
        '
        'txtEditorial
        '
        Me.txtEditorial.Location = New System.Drawing.Point(150, 207)
        Me.txtEditorial.Name = "txtEditorial"
        Me.txtEditorial.Size = New System.Drawing.Size(239, 20)
        Me.txtEditorial.TabIndex = 11
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(150, 171)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(239, 20)
        Me.txtAutor.TabIndex = 10
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(150, 85)
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(367, 80)
        Me.txtDescrip.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(150, 51)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(367, 20)
        Me.txtNombre.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cantidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Precio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Genero:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Editorial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Autor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Agregar Libro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Libro:"
        '
        'btnModifStock
        '
        Me.btnModifStock.Location = New System.Drawing.Point(342, 5)
        Me.btnModifStock.Name = "btnModifStock"
        Me.btnModifStock.Size = New System.Drawing.Size(314, 44)
        Me.btnModifStock.TabIndex = 1
        Me.btnModifStock.Text = "Modificar Prductos"
        Me.btnModifStock.UseVisualStyleBackColor = True
        '
        'btnAltaStock
        '
        Me.btnAltaStock.Location = New System.Drawing.Point(3, 4)
        Me.btnAltaStock.Name = "btnAltaStock"
        Me.btnAltaStock.Size = New System.Drawing.Size(306, 44)
        Me.btnAltaStock.TabIndex = 0
        Me.btnAltaStock.Text = "Nuevos Productos"
        Me.btnAltaStock.UseVisualStyleBackColor = True
        '
        'btnSocios
        '
        Me.btnSocios.Location = New System.Drawing.Point(544, 12)
        Me.btnSocios.Name = "btnSocios"
        Me.btnSocios.Size = New System.Drawing.Size(127, 23)
        Me.btnSocios.TabIndex = 11
        Me.btnSocios.Text = "Clientes Socios"
        Me.btnSocios.UseVisualStyleBackColor = True
        '
        'FRMinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 519)
        Me.Controls.Add(Me.btnSocios)
        Me.Controls.Add(Me.pnlInventario)
        Me.Controls.Add(Me.btnDevolvucion)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnAdm)
        Me.Controls.Add(Me.btnCliente)
        Me.IsMdiContainer = True
        Me.Name = "FRMinventario"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMinventario"
        Me.pnlInventario.ResumeLayout(False)
        Me.pnlModificaLibro.ResumeLayout(False)
        Me.pnlModificaLibro.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAltaArticulo.ResumeLayout(False)
        Me.pnlAltaArticulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDevolvucion As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnAdm As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents pnlInventario As System.Windows.Forms.Panel
    Friend WithEvents pnlAltaArticulo As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnModifStock As System.Windows.Forms.Button
    Friend WithEvents btnAltaStock As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlModificaLibro As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtEditorial As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents clnId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnDescrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnAutor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnEdit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnGenero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clnCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSocios As System.Windows.Forms.Button
End Class
