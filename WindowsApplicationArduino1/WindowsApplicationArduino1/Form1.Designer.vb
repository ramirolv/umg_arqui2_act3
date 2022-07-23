<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnEncender = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxDato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEncender
        '
        Me.btnEncender.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEncender.FlatAppearance.BorderSize = 0
        Me.btnEncender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncender.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEncender.Location = New System.Drawing.Point(35, 19)
        Me.btnEncender.Name = "btnEncender"
        Me.btnEncender.Size = New System.Drawing.Size(75, 23)
        Me.btnEncender.TabIndex = 0
        Me.btnEncender.Text = "Encender"
        Me.btnEncender.UseVisualStyleBackColor = False
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'btnApagar
        '
        Me.btnApagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnApagar.FlatAppearance.BorderSize = 0
        Me.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApagar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnApagar.Location = New System.Drawing.Point(161, 19)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(75, 23)
        Me.btnApagar.TabIndex = 1
        Me.btnApagar.Text = "Apagar"
        Me.btnApagar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEncender)
        Me.Panel1.Controls.Add(Me.btnApagar)
        Me.Panel1.Location = New System.Drawing.Point(12, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 67)
        Me.Panel1.TabIndex = 2
        '
        'TextBoxDato
        '
        Me.TextBoxDato.Location = New System.Drawing.Point(88, 63)
        Me.TextBoxDato.Name = "TextBoxDato"
        Me.TextBoxDato.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDato.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(98, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Escriba el dato"
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(101, 89)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 5
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDato)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEncender As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnApagar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxDato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviar As Button
End Class
