<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SueldoValorRef
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.calcularHoras = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.btnLimpiarRef = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSueldoRef = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcularRef = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHorasTrabajadasRef = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(30, 349)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "$"
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.Color.White
        Me.txtSueldo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSueldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSueldo.Location = New System.Drawing.Point(30, 306)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.ReadOnly = True
        Me.txtSueldo.Size = New System.Drawing.Size(100, 23)
        Me.txtSueldo.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Sueldo a cobrar"
        '
        'calcularHoras
        '
        Me.calcularHoras.Location = New System.Drawing.Point(30, 176)
        Me.calcularHoras.Name = "calcularHoras"
        Me.calcularHoras.Size = New System.Drawing.Size(116, 85)
        Me.calcularHoras.TabIndex = 9
        Me.calcularHoras.Text = "Calcular"
        Me.calcularHoras.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingrese horas trabajadas"
        '
        'txtHorasTrabajadas
        '
        Me.txtHorasTrabajadas.Location = New System.Drawing.Point(41, 128)
        Me.txtHorasTrabajadas.Name = "txtHorasTrabajadas"
        Me.txtHorasTrabajadas.Size = New System.Drawing.Size(100, 23)
        Me.txtHorasTrabajadas.TabIndex = 7
        '
        'btnLimpiarRef
        '
        Me.btnLimpiarRef.Location = New System.Drawing.Point(259, 349)
        Me.btnLimpiarRef.Name = "btnLimpiarRef"
        Me.btnLimpiarRef.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarRef.TabIndex = 20
        Me.btnLimpiarRef.Text = "Limpiar"
        Me.btnLimpiarRef.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "$"
        '
        'txtSueldoRef
        '
        Me.txtSueldoRef.BackColor = System.Drawing.Color.White
        Me.txtSueldoRef.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSueldoRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSueldoRef.Location = New System.Drawing.Point(259, 305)
        Me.txtSueldoRef.Name = "txtSueldoRef"
        Me.txtSueldoRef.ReadOnly = True
        Me.txtSueldoRef.Size = New System.Drawing.Size(100, 23)
        Me.txtSueldoRef.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Sueldo a cobrar"
        '
        'btnCalcularRef
        '
        Me.btnCalcularRef.Location = New System.Drawing.Point(259, 176)
        Me.btnCalcularRef.Name = "btnCalcularRef"
        Me.btnCalcularRef.Size = New System.Drawing.Size(116, 85)
        Me.btnCalcularRef.TabIndex = 16
        Me.btnCalcularRef.Text = "Calcular"
        Me.btnCalcularRef.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Ingrese horas trabajadas"
        '
        'txtHorasTrabajadasRef
        '
        Me.txtHorasTrabajadasRef.Location = New System.Drawing.Point(270, 128)
        Me.txtHorasTrabajadasRef.Name = "txtHorasTrabajadasRef"
        Me.txtHorasTrabajadasRef.Size = New System.Drawing.Size(100, 23)
        Me.txtHorasTrabajadasRef.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(30, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 27)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Por valor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(259, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 27)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Por referencia"
        '
        'SueldoValorRef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnLimpiarRef)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSueldoRef)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalcularRef)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHorasTrabajadasRef)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.calcularHoras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHorasTrabajadas)
        Me.Name = "SueldoValorRef"
        Me.Text = "Sueldo por valor y referencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents calcularHoras As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHorasTrabajadas As TextBox
    Friend WithEvents btnLimpiarRef As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSueldoRef As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalcularRef As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHorasTrabajadasRef As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
