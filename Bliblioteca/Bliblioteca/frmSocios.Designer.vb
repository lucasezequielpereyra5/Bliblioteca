<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSocios
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
        Me.btnAdm = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvSocios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDevolvucion
        '
        Me.btnDevolvucion.Location = New System.Drawing.Point(545, 12)
        Me.btnDevolvucion.Name = "btnDevolvucion"
        Me.btnDevolvucion.Size = New System.Drawing.Size(127, 23)
        Me.btnDevolvucion.TabIndex = 11
        Me.btnDevolvucion.Text = "Devoluciones"
        Me.btnDevolvucion.UseVisualStyleBackColor = True
        '
        'btnInv
        '
        Me.btnInv.Location = New System.Drawing.Point(412, 12)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(127, 23)
        Me.btnInv.TabIndex = 10
        Me.btnInv.Text = "Inventario"
        Me.btnInv.UseVisualStyleBackColor = True
        '
        'btnAdm
        '
        Me.btnAdm.Location = New System.Drawing.Point(279, 12)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(127, 23)
        Me.btnAdm.TabIndex = 9
        Me.btnAdm.Text = "Administracion"
        Me.btnAdm.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(146, 12)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(127, 23)
        Me.btnCliente.TabIndex = 8
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 12)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(127, 23)
        Me.btnInicio.TabIndex = 12
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvSocios)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 446)
        Me.Panel1.TabIndex = 14
        '
        'dgvSocios
        '
        Me.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSocios.Location = New System.Drawing.Point(17, 66)
        Me.dgvSocios.Name = "dgvSocios"
        Me.dgvSocios.Size = New System.Drawing.Size(623, 354)
        Me.dgvSocios.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de Clientes Socios"
        '
        'frmSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnDevolvucion)
        Me.Controls.Add(Me.btnInv)
        Me.Controls.Add(Me.btnAdm)
        Me.Controls.Add(Me.btnCliente)
        Me.IsMdiContainer = True
        Me.Name = "frmSocios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSocios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDevolvucion As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents btnAdm As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvSocios As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
