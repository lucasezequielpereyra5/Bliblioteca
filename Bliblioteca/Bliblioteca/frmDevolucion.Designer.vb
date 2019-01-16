<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucion
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
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnInv = New System.Windows.Forms.Button()
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvListaDevolucion = New System.Windows.Forms.DataGridView()
        Me.BtnDevolverLibro = New System.Windows.Forms.Button()
        Me.btnSocios = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        CType(Me.dgvListaDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 12)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(127, 23)
        Me.btnInicio.TabIndex = 7
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnInv
        '
        Me.btnInv.Location = New System.Drawing.Point(412, 12)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(127, 23)
        Me.btnInv.TabIndex = 6
        Me.btnInv.Text = "Inventario"
        Me.btnInv.UseVisualStyleBackColor = True
        '
        'btnAdm
        '
        Me.btnAdm.Location = New System.Drawing.Point(279, 12)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(127, 23)
        Me.btnAdm.TabIndex = 5
        Me.btnAdm.Text = "Administracion"
        Me.btnAdm.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(146, 12)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(127, 23)
        Me.btnCliente.TabIndex = 4
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cliente a devolver Libro: "
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(689, 519)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -27
        Me.LineShape1.X2 = 687
        Me.LineShape1.Y1 = 60
        Me.LineShape1.Y2 = 56
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(214, 83)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(209, 20)
        Me.txtDni.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.frmPrincipal.My.Resources.Resources.lupa2
        Me.btnBuscar.Location = New System.Drawing.Point(450, 73)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(44, 39)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvListaDevolucion
        '
        Me.dgvListaDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaDevolucion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListaDevolucion.Location = New System.Drawing.Point(12, 118)
        Me.dgvListaDevolucion.MultiSelect = False
        Me.dgvListaDevolucion.Name = "dgvListaDevolucion"
        Me.dgvListaDevolucion.ReadOnly = True
        Me.dgvListaDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaDevolucion.Size = New System.Drawing.Size(665, 320)
        Me.dgvListaDevolucion.TabIndex = 13
        '
        'BtnDevolverLibro
        '
        Me.BtnDevolverLibro.Location = New System.Drawing.Point(12, 454)
        Me.BtnDevolverLibro.Name = "BtnDevolverLibro"
        Me.BtnDevolverLibro.Size = New System.Drawing.Size(665, 40)
        Me.BtnDevolverLibro.TabIndex = 14
        Me.BtnDevolverLibro.Text = "Devolver libro"
        Me.BtnDevolverLibro.UseVisualStyleBackColor = True
        '
        'btnSocios
        '
        Me.btnSocios.Location = New System.Drawing.Point(545, 12)
        Me.btnSocios.Name = "btnSocios"
        Me.btnSocios.Size = New System.Drawing.Size(127, 23)
        Me.btnSocios.TabIndex = 15
        Me.btnSocios.Text = "Clientes Socios"
        Me.btnSocios.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(500, 73)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(95, 39)
        Me.btnListar.TabIndex = 16
        Me.btnListar.Text = "Listar alquileres"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'frmDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 519)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnSocios)
        Me.Controls.Add(Me.BtnDevolverLibro)
        Me.Controls.Add(Me.dgvListaDevolucion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnInv)
        Me.Controls.Add(Me.btnAdm)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDevolucion"
        CType(Me.dgvListaDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents btnAdm As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvListaDevolucion As System.Windows.Forms.DataGridView
    Friend WithEvents BtnDevolverLibro As System.Windows.Forms.Button
    Friend WithEvents btnSocios As System.Windows.Forms.Button
    Friend WithEvents btnListar As System.Windows.Forms.Button
End Class
