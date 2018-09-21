<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMadmin
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
        Me.btnInv = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.pnlAdm = New System.Windows.Forms.Panel()
        Me.pnlBusquedaPeliculas = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.clmClientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaAlquilerP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaVencimientoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombrePelicula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlBusquedaCliente = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clmPeliculasAlquiladas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaAlquiler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaDeVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscarPelicula = New System.Windows.Forms.Button()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtBuscarPelicula = New System.Windows.Forms.TextBox()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSocios = New System.Windows.Forms.Button()
        Me.pnlAdm.SuspendLayout()
        Me.pnlBusquedaPeliculas.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBusquedaCliente.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnInv
        '
        Me.btnInv.Location = New System.Drawing.Point(278, 12)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(127, 23)
        Me.btnInv.TabIndex = 6
        Me.btnInv.Text = "Inventario"
        Me.btnInv.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 12)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(127, 23)
        Me.btnInicio.TabIndex = 5
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
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
        'pnlAdm
        '
        Me.pnlAdm.Controls.Add(Me.pnlBusquedaPeliculas)
        Me.pnlAdm.Controls.Add(Me.pnlBusquedaCliente)
        Me.pnlAdm.Controls.Add(Me.btnBuscarPelicula)
        Me.pnlAdm.Controls.Add(Me.btnBuscarCliente)
        Me.pnlAdm.Controls.Add(Me.txtBuscarPelicula)
        Me.pnlAdm.Controls.Add(Me.txtBuscarCliente)
        Me.pnlAdm.Controls.Add(Me.Label3)
        Me.pnlAdm.Controls.Add(Me.Label2)
        Me.pnlAdm.Controls.Add(Me.Label1)
        Me.pnlAdm.Location = New System.Drawing.Point(12, 41)
        Me.pnlAdm.Name = "pnlAdm"
        Me.pnlAdm.Size = New System.Drawing.Size(659, 450)
        Me.pnlAdm.TabIndex = 9
        '
        'pnlBusquedaPeliculas
        '
        Me.pnlBusquedaPeliculas.Controls.Add(Me.DataGridView2)
        Me.pnlBusquedaPeliculas.Controls.Add(Me.txtNombrePelicula)
        Me.pnlBusquedaPeliculas.Controls.Add(Me.Label5)
        Me.pnlBusquedaPeliculas.Location = New System.Drawing.Point(0, 142)
        Me.pnlBusquedaPeliculas.Name = "pnlBusquedaPeliculas"
        Me.pnlBusquedaPeliculas.Size = New System.Drawing.Size(665, 308)
        Me.pnlBusquedaPeliculas.TabIndex = 3
        Me.pnlBusquedaPeliculas.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmClientes, Me.clmFechaAlquilerP, Me.clmFechaVencimientoP})
        Me.DataGridView2.Location = New System.Drawing.Point(74, 63)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(506, 219)
        Me.DataGridView2.TabIndex = 2
        '
        'clmClientes
        '
        Me.clmClientes.HeaderText = "Clientes que la Alquilaron"
        Me.clmClientes.Name = "clmClientes"
        Me.clmClientes.ReadOnly = True
        '
        'clmFechaAlquilerP
        '
        Me.clmFechaAlquilerP.HeaderText = "Fecha de Alquiler"
        Me.clmFechaAlquilerP.Name = "clmFechaAlquilerP"
        Me.clmFechaAlquilerP.ReadOnly = True
        '
        'clmFechaVencimientoP
        '
        Me.clmFechaVencimientoP.HeaderText = "Fecha de Vencimiento"
        Me.clmFechaVencimientoP.Name = "clmFechaVencimientoP"
        '
        'txtNombrePelicula
        '
        Me.txtNombrePelicula.Location = New System.Drawing.Point(156, 8)
        Me.txtNombrePelicula.Name = "txtNombrePelicula"
        Me.txtNombrePelicula.Size = New System.Drawing.Size(222, 20)
        Me.txtNombrePelicula.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre de Libro:"
        '
        'pnlBusquedaCliente
        '
        Me.pnlBusquedaCliente.Controls.Add(Me.DataGridView1)
        Me.pnlBusquedaCliente.Controls.Add(Me.txtNombreCliente)
        Me.pnlBusquedaCliente.Controls.Add(Me.Label4)
        Me.pnlBusquedaCliente.Location = New System.Drawing.Point(3, 142)
        Me.pnlBusquedaCliente.Name = "pnlBusquedaCliente"
        Me.pnlBusquedaCliente.Size = New System.Drawing.Size(519, 305)
        Me.pnlBusquedaCliente.TabIndex = 7
        Me.pnlBusquedaCliente.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmPeliculasAlquiladas, Me.clmFechaAlquiler, Me.clmFechaDeVencimiento})
        Me.DataGridView1.Location = New System.Drawing.Point(74, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 257)
        Me.DataGridView1.TabIndex = 2
        '
        'clmPeliculasAlquiladas
        '
        Me.clmPeliculasAlquiladas.HeaderText = "Peliculas Alquiladas"
        Me.clmPeliculasAlquiladas.Name = "clmPeliculasAlquiladas"
        Me.clmPeliculasAlquiladas.ReadOnly = True
        '
        'clmFechaAlquiler
        '
        Me.clmFechaAlquiler.HeaderText = "Fecha de Alquiler"
        Me.clmFechaAlquiler.Name = "clmFechaAlquiler"
        Me.clmFechaAlquiler.ReadOnly = True
        '
        'clmFechaDeVencimiento
        '
        Me.clmFechaDeVencimiento.HeaderText = "Fecha de Vencimiento"
        Me.clmFechaDeVencimiento.Name = "clmFechaDeVencimiento"
        Me.clmFechaDeVencimiento.ReadOnly = True
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(127, 4)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(205, 20)
        Me.txtNombreCliente.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre de Cliente:"
        '
        'btnBuscarPelicula
        '
        Me.btnBuscarPelicula.Image = Global.frmPrincipal.My.Resources.Resources.lupa2
        Me.btnBuscarPelicula.Location = New System.Drawing.Point(435, 84)
        Me.btnBuscarPelicula.Name = "btnBuscarPelicula"
        Me.btnBuscarPelicula.Size = New System.Drawing.Size(35, 36)
        Me.btnBuscarPelicula.TabIndex = 6
        Me.btnBuscarPelicula.UseVisualStyleBackColor = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = Global.frmPrincipal.My.Resources.Resources.lupa2
        Me.btnBuscarCliente.Location = New System.Drawing.Point(435, 29)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(35, 36)
        Me.btnBuscarCliente.TabIndex = 5
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtBuscarPelicula
        '
        Me.txtBuscarPelicula.Location = New System.Drawing.Point(89, 93)
        Me.txtBuscarPelicula.Name = "txtBuscarPelicula"
        Me.txtBuscarPelicula.Size = New System.Drawing.Size(215, 20)
        Me.txtBuscarPelicula.TabIndex = 4
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(89, 38)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(215, 20)
        Me.txtBuscarCliente.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libros:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clientes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Alquileres Por:"
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
        'FRMadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 519)
        Me.Controls.Add(Me.btnSocios)
        Me.Controls.Add(Me.pnlAdm)
        Me.Controls.Add(Me.btnDevolvucion)
        Me.Controls.Add(Me.btnInv)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnCliente)
        Me.IsMdiContainer = True
        Me.Name = "FRMadmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMadmin"
        Me.pnlAdm.ResumeLayout(False)
        Me.pnlAdm.PerformLayout()
        Me.pnlBusquedaPeliculas.ResumeLayout(False)
        Me.pnlBusquedaPeliculas.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBusquedaCliente.ResumeLayout(False)
        Me.pnlBusquedaCliente.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDevolvucion As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents pnlAdm As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPelicula As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txtBuscarPelicula As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscarCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlBusquedaCliente As System.Windows.Forms.Panel
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clmPeliculasAlquiladas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAlquiler As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaDeVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlBusquedaPeliculas As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents clmClientes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAlquilerP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaVencimientoP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNombrePelicula As System.Windows.Forms.TextBox
    Friend WithEvents btnSocios As System.Windows.Forms.Button
End Class
