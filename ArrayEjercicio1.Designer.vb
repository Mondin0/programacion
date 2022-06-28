<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayEjercicio1
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
        Me.btnAlmacenar = New System.Windows.Forms.Button()
        Me.btnPromedio = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAlmacenar
        '
        Me.btnAlmacenar.Location = New System.Drawing.Point(501, 108)
        Me.btnAlmacenar.Name = "btnAlmacenar"
        Me.btnAlmacenar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlmacenar.TabIndex = 0
        Me.btnAlmacenar.Text = "Almacenar"
        Me.btnAlmacenar.UseVisualStyleBackColor = True
        '
        'btnPromedio
        '
        Me.btnPromedio.Location = New System.Drawing.Point(501, 164)
        Me.btnPromedio.Name = "btnPromedio"
        Me.btnPromedio.Size = New System.Drawing.Size(75, 23)
        Me.btnPromedio.TabIndex = 1
        Me.btnPromedio.Text = "Promedio"
        Me.btnPromedio.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(501, 214)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 2
        Me.btnVer.Text = "Visualizar"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(134, 94)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 23)
        Me.txtValor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingresar valor"
        '
        'ArrayEjercicio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnPromedio)
        Me.Controls.Add(Me.btnAlmacenar)
        Me.Name = "ArrayEjercicio1"
        Me.Text = "Ejercicio 1 array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAlmacenar As Button
    Friend WithEvents btnPromedio As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
End Class
