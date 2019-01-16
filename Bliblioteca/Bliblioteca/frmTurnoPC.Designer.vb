<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurnoPC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurnoPC))
        Me.imgPC = New System.Windows.Forms.PictureBox()
        Me.lblTimer1 = New System.Windows.Forms.Label()
        Me.BTNPC1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTNPc2 = New System.Windows.Forms.Button()
        Me.lblTimer2 = New System.Windows.Forms.Label()
        Me.BTNPc3 = New System.Windows.Forms.Button()
        Me.lblTimer3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.BTNsalir = New System.Windows.Forms.Button()
        Me.lblSalaPC = New System.Windows.Forms.Label()
        Me.lblTextoSalaPC = New System.Windows.Forms.Label()
        Me.BTNDesocupar1 = New System.Windows.Forms.Button()
        Me.BTNDesocupar2 = New System.Windows.Forms.Button()
        Me.BTNDesocupar3 = New System.Windows.Forms.Button()
        CType(Me.imgPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgPC
        '
        Me.imgPC.Image = CType(resources.GetObject("imgPC.Image"), System.Drawing.Image)
        Me.imgPC.Location = New System.Drawing.Point(48, 47)
        Me.imgPC.Name = "imgPC"
        Me.imgPC.Size = New System.Drawing.Size(140, 111)
        Me.imgPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPC.TabIndex = 0
        Me.imgPC.TabStop = False
        '
        'lblTimer1
        '
        Me.lblTimer1.AutoSize = True
        Me.lblTimer1.Location = New System.Drawing.Point(182, 339)
        Me.lblTimer1.Name = "lblTimer1"
        Me.lblTimer1.Size = New System.Drawing.Size(38, 17)
        Me.lblTimer1.TabIndex = 2
        Me.lblTimer1.Text = "PC 1"
        '
        'BTNPC1
        '
        Me.BTNPC1.Image = CType(resources.GetObject("BTNPC1.Image"), System.Drawing.Image)
        Me.BTNPC1.Location = New System.Drawing.Point(135, 224)
        Me.BTNPC1.Name = "BTNPC1"
        Me.BTNPC1.Size = New System.Drawing.Size(121, 90)
        Me.BTNPC1.TabIndex = 12
        Me.BTNPC1.Text = "PC 1"
        Me.BTNPC1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BTNPc2
        '
        Me.BTNPc2.Image = CType(resources.GetObject("BTNPc2.Image"), System.Drawing.Image)
        Me.BTNPc2.Location = New System.Drawing.Point(326, 224)
        Me.BTNPc2.Name = "BTNPc2"
        Me.BTNPc2.Size = New System.Drawing.Size(131, 95)
        Me.BTNPc2.TabIndex = 14
        Me.BTNPc2.Text = "PC 2"
        Me.BTNPc2.UseVisualStyleBackColor = True
        '
        'lblTimer2
        '
        Me.lblTimer2.AutoSize = True
        Me.lblTimer2.Location = New System.Drawing.Point(373, 339)
        Me.lblTimer2.Name = "lblTimer2"
        Me.lblTimer2.Size = New System.Drawing.Size(38, 17)
        Me.lblTimer2.TabIndex = 13
        Me.lblTimer2.Text = "PC 1"
        '
        'BTNPc3
        '
        Me.BTNPc3.Image = CType(resources.GetObject("BTNPc3.Image"), System.Drawing.Image)
        Me.BTNPc3.Location = New System.Drawing.Point(520, 224)
        Me.BTNPc3.Name = "BTNPc3"
        Me.BTNPc3.Size = New System.Drawing.Size(131, 95)
        Me.BTNPc3.TabIndex = 16
        Me.BTNPc3.Text = "PC 3"
        Me.BTNPc3.UseVisualStyleBackColor = True
        '
        'lblTimer3
        '
        Me.lblTimer3.AutoSize = True
        Me.lblTimer3.Location = New System.Drawing.Point(567, 339)
        Me.lblTimer3.Name = "lblTimer3"
        Me.lblTimer3.Size = New System.Drawing.Size(38, 17)
        Me.lblTimer3.TabIndex = 15
        Me.lblTimer3.Text = "PC 1"
        '
        'Timer2
        '
        Me.Timer2.Interval = 60000
        '
        'Timer3
        '
        Me.Timer3.Interval = 60000
        '
        'BTNsalir
        '
        Me.BTNsalir.Location = New System.Drawing.Point(650, 9)
        Me.BTNsalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNsalir.Name = "BTNsalir"
        Me.BTNsalir.Size = New System.Drawing.Size(138, 43)
        Me.BTNsalir.TabIndex = 17
        Me.BTNsalir.Text = "Salir"
        Me.BTNsalir.UseVisualStyleBackColor = True
        '
        'lblSalaPC
        '
        Me.lblSalaPC.AutoSize = True
        Me.lblSalaPC.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblSalaPC.Location = New System.Drawing.Point(232, 51)
        Me.lblSalaPC.Name = "lblSalaPC"
        Me.lblSalaPC.Size = New System.Drawing.Size(130, 23)
        Me.lblSalaPC.TabIndex = 1
        Me.lblSalaPC.Text = "Turnos de PC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTextoSalaPC
        '
        Me.lblTextoSalaPC.AutoSize = True
        Me.lblTextoSalaPC.Location = New System.Drawing.Point(233, 93)
        Me.lblTextoSalaPC.Name = "lblTextoSalaPC"
        Me.lblTextoSalaPC.Size = New System.Drawing.Size(359, 51)
        Me.lblTextoSalaPC.TabIndex = 18
        Me.lblTextoSalaPC.Text = "Los turnos duran 60 minutos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si necesitás imprimir, avisá previamente al bibli" &
    "otecario."
        '
        'BTNDesocupar1
        '
        Me.BTNDesocupar1.Location = New System.Drawing.Point(158, 376)
        Me.BTNDesocupar1.Name = "BTNDesocupar1"
        Me.BTNDesocupar1.Size = New System.Drawing.Size(85, 23)
        Me.BTNDesocupar1.TabIndex = 19
        Me.BTNDesocupar1.Text = "Desocupar"
        Me.BTNDesocupar1.UseVisualStyleBackColor = True
        '
        'BTNDesocupar2
        '
        Me.BTNDesocupar2.Location = New System.Drawing.Point(348, 376)
        Me.BTNDesocupar2.Name = "BTNDesocupar2"
        Me.BTNDesocupar2.Size = New System.Drawing.Size(85, 23)
        Me.BTNDesocupar2.TabIndex = 20
        Me.BTNDesocupar2.Text = "Desocupar"
        Me.BTNDesocupar2.UseVisualStyleBackColor = True
        '
        'BTNDesocupar3
        '
        Me.BTNDesocupar3.Location = New System.Drawing.Point(547, 376)
        Me.BTNDesocupar3.Name = "BTNDesocupar3"
        Me.BTNDesocupar3.Size = New System.Drawing.Size(85, 23)
        Me.BTNDesocupar3.TabIndex = 21
        Me.BTNDesocupar3.Text = "Desocupar"
        Me.BTNDesocupar3.UseVisualStyleBackColor = True
        '
        'frmTurnoPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNDesocupar3)
        Me.Controls.Add(Me.BTNDesocupar2)
        Me.Controls.Add(Me.BTNDesocupar1)
        Me.Controls.Add(Me.lblTextoSalaPC)
        Me.Controls.Add(Me.BTNsalir)
        Me.Controls.Add(Me.BTNPc3)
        Me.Controls.Add(Me.lblTimer3)
        Me.Controls.Add(Me.BTNPc2)
        Me.Controls.Add(Me.lblTimer2)
        Me.Controls.Add(Me.BTNPC1)
        Me.Controls.Add(Me.lblTimer1)
        Me.Controls.Add(Me.lblSalaPC)
        Me.Controls.Add(Me.imgPC)
        Me.Name = "frmTurnoPC"
        Me.Text = "turnoPC"
        CType(Me.imgPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgPC As PictureBox
    Friend WithEvents lblTimer1 As Label
    Friend WithEvents BTNPC1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BTNPc2 As Button
    Friend WithEvents lblTimer2 As Label
    Friend WithEvents BTNPc3 As Button
    Friend WithEvents lblTimer3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents BTNsalir As Button
    Friend WithEvents lblSalaPC As Label
    Friend WithEvents lblTextoSalaPC As Label
    Friend WithEvents BTNDesocupar1 As Button
    Friend WithEvents BTNDesocupar2 As Button
    Friend WithEvents BTNDesocupar3 As Button
End Class
