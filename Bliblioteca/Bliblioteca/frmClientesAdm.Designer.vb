<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesAdm
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
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnAltas = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.pnlAlta = New System.Windows.Forms.Panel()
        Me.lblPass2 = New System.Windows.Forms.Label()
        Me.pnlModif = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clmDni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarNombre = New System.Windows.Forms.Button()
        Me.btnBuscarDni = New System.Windows.Forms.Button()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.txtBuscarDni = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnSocios = New System.Windows.Forms.Button()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.pnlAlta.SuspendLayout()
        Me.pnlModif.SuspendLayout()
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
        'btnAdm
        '
        Me.btnAdm.Location = New System.Drawing.Point(145, 12)
        Me.btnAdm.Name = "btnAdm"
        Me.btnAdm.Size = New System.Drawing.Size(127, 23)
        Me.btnAdm.TabIndex = 5
        Me.btnAdm.Text = "Administracion"
        Me.btnAdm.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 12)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(127, 23)
        Me.btnInicio.TabIndex = 4
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnAltas
        '
        Me.btnAltas.Location = New System.Drawing.Point(27, 41)
        Me.btnAltas.Name = "btnAltas"
        Me.btnAltas.Size = New System.Drawing.Size(305, 44)
        Me.btnAltas.TabIndex = 8
        Me.btnAltas.Text = "Alta de Clientes"
        Me.btnAltas.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(352, 41)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(302, 44)
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Modificacion de Clientes"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'pnlAlta
        '
        Me.pnlAlta.Controls.Add(Me.dtpFechaNac)
        Me.pnlAlta.Controls.Add(Me.lblPass2)
        Me.pnlAlta.Controls.Add(Me.btnAgregar)
        Me.pnlAlta.Controls.Add(Me.txtPass2)
        Me.pnlAlta.Controls.Add(Me.txtPass)
        Me.pnlAlta.Controls.Add(Me.txtMail)
        Me.pnlAlta.Controls.Add(Me.txtApellido)
        Me.pnlAlta.Controls.Add(Me.txtNombre)
        Me.pnlAlta.Controls.Add(Me.txtDni)
        Me.pnlAlta.Controls.Add(Me.Label7)
        Me.pnlAlta.Controls.Add(Me.Label6)
        Me.pnlAlta.Controls.Add(Me.Label5)
        Me.pnlAlta.Controls.Add(Me.Label4)
        Me.pnlAlta.Controls.Add(Me.Label3)
        Me.pnlAlta.Controls.Add(Me.Label2)
        Me.pnlAlta.Controls.Add(Me.Label1)
        Me.pnlAlta.Location = New System.Drawing.Point(27, 106)
        Me.pnlAlta.Name = "pnlAlta"
        Me.pnlAlta.Size = New System.Drawing.Size(627, 401)
        Me.pnlAlta.TabIndex = 11
        Me.pnlAlta.Visible = False
        '
        'lblPass2
        '
        Me.lblPass2.AllowDrop = True
        Me.lblPass2.AutoEllipsis = True
        Me.lblPass2.AutoSize = True
        Me.lblPass2.CausesValidation = False
        Me.lblPass2.Location = New System.Drawing.Point(351, 290)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(10, 13)
        Me.lblPass2.TabIndex = 20
        Me.lblPass2.Text = "-"
        '
        'pnlModif
        '
        Me.pnlModif.Controls.Add(Me.DataGridView1)
        Me.pnlModif.Controls.Add(Me.btnBuscarNombre)
        Me.pnlModif.Controls.Add(Me.btnBuscarDni)
        Me.pnlModif.Controls.Add(Me.txtBuscarNombre)
        Me.pnlModif.Controls.Add(Me.txtBuscarDni)
        Me.pnlModif.Controls.Add(Me.Label10)
        Me.pnlModif.Controls.Add(Me.Label9)
        Me.pnlModif.Controls.Add(Me.Label8)
        Me.pnlModif.Location = New System.Drawing.Point(528, 12)
        Me.pnlModif.Name = "pnlModif"
        Me.pnlModif.Size = New System.Drawing.Size(627, 401)
        Me.pnlModif.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDni, Me.clmMail, Me.clmPass, Me.clmNombre})
        Me.DataGridView1.Location = New System.Drawing.Point(20, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(575, 243)
        Me.DataGridView1.TabIndex = 7
        '
        'clmDni
        '
        Me.clmDni.HeaderText = "DNI Cliente"
        Me.clmDni.Name = "clmDni"
        '
        'clmMail
        '
        Me.clmMail.HeaderText = "Mail"
        Me.clmMail.Name = "clmMail"
        '
        'clmPass
        '
        Me.clmPass.HeaderText = "Contraseña"
        Me.clmPass.Name = "clmPass"
        '
        'clmNombre
        '
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        '
        'btnBuscarNombre
        '
        Me.btnBuscarNombre.Image = Global.frmPrincipal.My.Resources.Resources.lupa2
        Me.btnBuscarNombre.Location = New System.Drawing.Point(426, 84)
        Me.btnBuscarNombre.Name = "btnBuscarNombre"
        Me.btnBuscarNombre.Size = New System.Drawing.Size(39, 37)
        Me.btnBuscarNombre.TabIndex = 6
        Me.btnBuscarNombre.UseVisualStyleBackColor = True
        '
        'btnBuscarDni
        '
        Me.btnBuscarDni.Image = Global.frmPrincipal.My.Resources.Resources.lupa2
        Me.btnBuscarDni.Location = New System.Drawing.Point(347, 28)
        Me.btnBuscarDni.Name = "btnBuscarDni"
        Me.btnBuscarDni.Size = New System.Drawing.Size(39, 37)
        Me.btnBuscarDni.TabIndex = 5
        Me.btnBuscarDni.UseVisualStyleBackColor = True
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Location = New System.Drawing.Point(199, 93)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(221, 20)
        Me.txtBuscarNombre.TabIndex = 4
        '
        'txtBuscarDni
        '
        Me.txtBuscarDni.Location = New System.Drawing.Point(95, 39)
        Me.txtBuscarDni.Name = "txtBuscarDni"
        Me.txtBuscarDni.Size = New System.Drawing.Size(221, 20)
        Me.txtBuscarDni.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Nombre y Apellido:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "DNI:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Buscar cliente por:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(277, 359)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(143, 39)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(157, 283)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(184, 20)
        Me.txtPass2.TabIndex = 18
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(157, 238)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(184, 20)
        Me.txtPass.TabIndex = 17
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(157, 196)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(184, 20)
        Me.txtMail.TabIndex = 16
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(157, 115)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(184, 20)
        Me.txtApellido.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(157, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(184, 20)
        Me.txtNombre.TabIndex = 8
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(157, 37)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(184, 20)
        Me.txtDni.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Confirmar Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-MAIL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(31, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Nac:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI:"
        '
        'btnSocios
        '
        Me.btnSocios.Location = New System.Drawing.Point(544, 12)
        Me.btnSocios.Name = "btnSocios"
        Me.btnSocios.Size = New System.Drawing.Size(127, 23)
        Me.btnSocios.TabIndex = 23
        Me.btnSocios.Text = "Clientes Socios"
        Me.btnSocios.UseVisualStyleBackColor = True
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaNac.Location = New System.Drawing.Point(157, 158)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(184, 20)
        Me.dtpFechaNac.TabIndex = 21
        '
        'frmClientesAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 519)
        Me.Controls.Add(Me.btnSocios)
        Me.Controls.Add(Me.pnlModif)
        Me.Controls.Add(Me.pnlAlta)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAltas)
        Me.Controls.Add(Me.btnDevolvucion)
        Me.Controls.Add(Me.btnInv)
        Me.Controls.Add(Me.btnAdm)
        Me.Controls.Add(Me.btnInicio)
        Me.IsMdiContainer = True
        Me.Name = "frmClientesAdm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMcliente"
        Me.pnlAlta.ResumeLayout(False)
        Me.pnlAlta.PerformLayout()
        Me.pnlModif.ResumeLayout(False)
        Me.pnlModif.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDevolvucion As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    Friend WithEvents btnAdm As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnAltas As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents pnlAlta As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents txtPass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lblPass2 As System.Windows.Forms.Label
    Friend WithEvents pnlModif As System.Windows.Forms.Panel
    Friend WithEvents txtBuscarNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscarDni As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarNombre As System.Windows.Forms.Button
    Friend WithEvents btnBuscarDni As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clmDni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSocios As System.Windows.Forms.Button
    Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
End Class
