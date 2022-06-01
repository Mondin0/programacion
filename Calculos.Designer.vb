<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculos
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
        Me.txtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calcularHoras = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHorasTrabajadas
        '
        Me.txtHorasTrabajadas.Location = New System.Drawing.Point(141, 64)
        Me.txtHorasTrabajadas.Name = "txtHorasTrabajadas"
        Me.txtHorasTrabajadas.Size = New System.Drawing.Size(100, 23)
        Me.txtHorasTrabajadas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese horas trabajadas"
        '
        'calcularHoras
        '
        Me.calcularHoras.Location = New System.Drawing.Point(130, 112)
        Me.calcularHoras.Name = "calcularHoras"
        Me.calcularHoras.Size = New System.Drawing.Size(116, 85)
        Me.calcularHoras.TabIndex = 2
        Me.calcularHoras.Text = "Calcular"
        Me.calcularHoras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sueldo a cobrar"
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.Color.White
        Me.txtSueldo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSueldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSueldo.Location = New System.Drawing.Point(338, 174)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.ReadOnly = True
        Me.txtSueldo.Size = New System.Drawing.Size(100, 23)
        Me.txtSueldo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "$"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(363, 232)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Calculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.calcularHoras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHorasTrabajadas)
        Me.Name = "Calculos"
        Me.Text = "Calculos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHorasTrabajadas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents calcularHoras As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLimpiar As Button
End Class
