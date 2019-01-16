<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Me.lblDatosDeLibros = New System.Windows.Forms.Label()
        Me.dgvListrarLibrosAlquiler = New System.Windows.Forms.DataGridView()
        Me.BTNsalir = New System.Windows.Forms.Button()
        Me.btnAjustes = New System.Windows.Forms.Button()
        Me.btnBuscarLibro = New System.Windows.Forms.Button()
        CType(Me.dgvListrarLibrosAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDatosDeLibros
        '
        Me.lblDatosDeLibros.AutoSize = True
        Me.lblDatosDeLibros.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosDeLibros.Location = New System.Drawing.Point(19, 93)
        Me.lblDatosDeLibros.Name = "lblDatosDeLibros"
        Me.lblDatosDeLibros.Size = New System.Drawing.Size(131, 18)
        Me.lblDatosDeLibros.TabIndex = 2
        Me.lblDatosDeLibros.Text = "Libros en alquiler:"
        '
        'dgvListrarLibrosAlquiler
        '
        Me.dgvListrarLibrosAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListrarLibrosAlquiler.Location = New System.Drawing.Point(22, 123)
        Me.dgvListrarLibrosAlquiler.Name = "dgvListrarLibrosAlquiler"
        Me.dgvListrarLibrosAlquiler.ReadOnly = True
        Me.dgvListrarLibrosAlquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListrarLibrosAlquiler.Size = New System.Drawing.Size(645, 288)
        Me.dgvListrarLibrosAlquiler.TabIndex = 0
        '
        'BTNsalir
        '
        Me.BTNsalir.Location = New System.Drawing.Point(468, 12)
        Me.BTNsalir.Name = "BTNsalir"
        Me.BTNsalir.Size = New System.Drawing.Size(189, 35)
        Me.BTNsalir.TabIndex = 4
        Me.BTNsalir.Text = "Salir"
        Me.BTNsalir.UseVisualStyleBackColor = True
        '
        'btnAjustes
        '
        Me.btnAjustes.Image = Global.frmPrincipal.My.Resources.Resources.ajustes
        Me.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjustes.Location = New System.Drawing.Point(247, 12)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Size = New System.Drawing.Size(189, 35)
        Me.btnAjustes.TabIndex = 3
        Me.btnAjustes.Text = "Ajustes"
        Me.btnAjustes.UseVisualStyleBackColor = True
        '
        'btnBuscarLibro
        '
        Me.btnBuscarLibro.Image = Global.frmPrincipal.My.Resources.Resources.lupa2
        Me.btnBuscarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarLibro.Location = New System.Drawing.Point(22, 12)
        Me.btnBuscarLibro.Name = "btnBuscarLibro"
        Me.btnBuscarLibro.Size = New System.Drawing.Size(189, 35)
        Me.btnBuscarLibro.TabIndex = 0
        Me.btnBuscarLibro.Text = "Buscador de libros"
        Me.btnBuscarLibro.UseVisualStyleBackColor = True
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 447)
        Me.Controls.Add(Me.BTNsalir)
        Me.Controls.Add(Me.btnAjustes)
        Me.Controls.Add(Me.dgvListrarLibrosAlquiler)
        Me.Controls.Add(Me.lblDatosDeLibros)
        Me.Controls.Add(Me.btnBuscarLibro)
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        CType(Me.dgvListrarLibrosAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarLibro As System.Windows.Forms.Button
    Friend WithEvents lblDatosDeLibros As System.Windows.Forms.Label
    Friend WithEvents dgvListrarLibrosAlquiler As System.Windows.Forms.DataGridView
    Friend WithEvents btnAjustes As System.Windows.Forms.Button
    Friend WithEvents BTNsalir As System.Windows.Forms.Button

End Class
