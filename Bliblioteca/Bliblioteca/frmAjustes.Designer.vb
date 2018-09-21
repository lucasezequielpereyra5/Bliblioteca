<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjustes))
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblEdad = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblCont = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblContraseñaNueva = New System.Windows.Forms.Label()
        Me.lblRepContraseña = New System.Windows.Forms.Label()
        Me.txtContraseñaNueva = New System.Windows.Forms.TextBox()
        Me.txtReingresarContraseña = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.LBLnom = New System.Windows.Forms.Label()
        Me.LBLape = New System.Windows.Forms.Label()
        Me.lblEdad2 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(24, 26)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(57, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apellido:"
        '
        'LblEdad
        '
        Me.LblEdad.AutoSize = True
        Me.LblEdad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEdad.Location = New System.Drawing.Point(24, 184)
        Me.LblEdad.Name = "LblEdad"
        Me.LblEdad.Size = New System.Drawing.Size(42, 16)
        Me.LblEdad.TabIndex = 5
        Me.LblEdad.Text = "Edad:"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(24, 219)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(45, 16)
        Me.LblEmail.TabIndex = 6
        Me.LblEmail.Text = "Email:"
        '
        'LblCont
        '
        Me.LblCont.AutoSize = True
        Me.LblCont.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCont.Location = New System.Drawing.Point(24, 90)
        Me.LblCont.Name = "LblCont"
        Me.LblCont.Size = New System.Drawing.Size(78, 16)
        Me.LblCont.TabIndex = 7
        Me.LblCont.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(173, 89)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(137, 20)
        Me.txtContraseña.TabIndex = 8
        '
        'lblContraseñaNueva
        '
        Me.lblContraseñaNueva.AutoSize = True
        Me.lblContraseñaNueva.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseñaNueva.Location = New System.Drawing.Point(24, 121)
        Me.lblContraseñaNueva.Name = "lblContraseñaNueva"
        Me.lblContraseñaNueva.Size = New System.Drawing.Size(115, 16)
        Me.lblContraseñaNueva.TabIndex = 11
        Me.lblContraseñaNueva.Text = "Contraseña nueva:"
        '
        'lblRepContraseña
        '
        Me.lblRepContraseña.AutoSize = True
        Me.lblRepContraseña.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepContraseña.Location = New System.Drawing.Point(24, 156)
        Me.lblRepContraseña.Name = "lblRepContraseña"
        Me.lblRepContraseña.Size = New System.Drawing.Size(144, 16)
        Me.lblRepContraseña.TabIndex = 12
        Me.lblRepContraseña.Text = "Reingresar Contraseña:"
        '
        'txtContraseñaNueva
        '
        Me.txtContraseñaNueva.Location = New System.Drawing.Point(173, 120)
        Me.txtContraseñaNueva.Name = "txtContraseñaNueva"
        Me.txtContraseñaNueva.Size = New System.Drawing.Size(137, 20)
        Me.txtContraseñaNueva.TabIndex = 13
        '
        'txtReingresarContraseña
        '
        Me.txtReingresarContraseña.Location = New System.Drawing.Point(173, 155)
        Me.txtReingresarContraseña.Name = "txtReingresarContraseña"
        Me.txtReingresarContraseña.Size = New System.Drawing.Size(137, 20)
        Me.txtReingresarContraseña.TabIndex = 14
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(38, 283)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 44)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(196, 283)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(115, 44)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'LBLnom
        '
        Me.LBLnom.AutoSize = True
        Me.LBLnom.Location = New System.Drawing.Point(171, 28)
        Me.LBLnom.Name = "LBLnom"
        Me.LBLnom.Size = New System.Drawing.Size(42, 13)
        Me.LBLnom.TabIndex = 17
        Me.LBLnom.Text = "nombre"
        '
        'LBLape
        '
        Me.LBLape.AutoSize = True
        Me.LBLape.Location = New System.Drawing.Point(170, 63)
        Me.LBLape.Name = "LBLape"
        Me.LBLape.Size = New System.Drawing.Size(43, 13)
        Me.LBLape.TabIndex = 18
        Me.LBLape.Text = "apellido"
        '
        'lblEdad2
        '
        Me.lblEdad2.AutoSize = True
        Me.lblEdad2.Location = New System.Drawing.Point(171, 186)
        Me.lblEdad2.Name = "lblEdad2"
        Me.lblEdad2.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad2.TabIndex = 19
        Me.lblEdad2.Text = "Edad"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(173, 218)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(137, 20)
        Me.txtMail.TabIndex = 20
        '
        'frmAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 339)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblEdad2)
        Me.Controls.Add(Me.LBLape)
        Me.Controls.Add(Me.LBLnom)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtReingresarContraseña)
        Me.Controls.Add(Me.txtContraseñaNueva)
        Me.Controls.Add(Me.lblRepContraseña)
        Me.Controls.Add(Me.lblContraseñaNueva)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.LblCont)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblEdad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAjustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajustes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblEdad As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents LblCont As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseñaNueva As System.Windows.Forms.Label
    Friend WithEvents lblRepContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtReingresarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents LBLnom As System.Windows.Forms.Label
    Friend WithEvents LBLape As System.Windows.Forms.Label
    Friend WithEvents lblEdad2 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
End Class
