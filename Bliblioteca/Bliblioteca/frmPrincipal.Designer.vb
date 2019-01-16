<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnEnviarClave = New System.Windows.Forms.Button()
        Me.txtEnviarClave = New System.Windows.Forms.TextBox()
        Me.lblEnviado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(96, 32)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(146, 20)
        Me.txtDni.TabIndex = 0
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(96, 84)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(146, 20)
        Me.txtContraseña.TabIndex = 1
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(12, 35)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(29, 13)
        Me.lblDni.TabIndex = 2
        Me.lblDni.Text = "DNI:"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(12, 87)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(67, 13)
        Me.lblContraseña.TabIndex = 3
        Me.lblContraseña.Text = "Contraseña: "
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(27, 149)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(83, 34)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(168, 149)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(83, 34)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(24, 186)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Recuperar contraseña"
        '
        'btnEnviarClave
        '
        Me.btnEnviarClave.Location = New System.Drawing.Point(192, 198)
        Me.btnEnviarClave.Name = "btnEnviarClave"
        Me.btnEnviarClave.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviarClave.TabIndex = 7
        Me.btnEnviarClave.Text = "Enviar"
        Me.btnEnviarClave.UseVisualStyleBackColor = True
        '
        'txtEnviarClave
        '
        Me.txtEnviarClave.Location = New System.Drawing.Point(26, 200)
        Me.txtEnviarClave.Name = "txtEnviarClave"
        Me.txtEnviarClave.Size = New System.Drawing.Size(159, 20)
        Me.txtEnviarClave.TabIndex = 8
        '
        'lblEnviado
        '
        Me.lblEnviado.AutoSize = True
        Me.lblEnviado.Location = New System.Drawing.Point(27, 227)
        Me.lblEnviado.Name = "lblEnviado"
        Me.lblEnviado.Size = New System.Drawing.Size(49, 13)
        Me.lblEnviado.TabIndex = 9
        Me.lblEnviado.Text = "Enviado!"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 266)
        Me.Controls.Add(Me.lblEnviado)
        Me.Controls.Add(Me.txtEnviarClave)
        Me.Controls.Add(Me.btnEnviarClave)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtDni)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnEnviarClave As System.Windows.Forms.Button
    Friend WithEvents txtEnviarClave As System.Windows.Forms.TextBox
    Friend WithEvents lblEnviado As System.Windows.Forms.Label

End Class
