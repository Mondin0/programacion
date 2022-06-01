<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValorYReferencia
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
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSumarValor = New System.Windows.Forms.Button()
        Me.btnSumarReferencia = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCargar2 = New System.Windows.Forms.Button()
        Me.txtCargar1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(305, 53)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(198, 23)
        Me.txtValor.TabIndex = 0
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(180, 52)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 1
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(562, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(562, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'btnSumarValor
        '
        Me.btnSumarValor.Location = New System.Drawing.Point(322, 113)
        Me.btnSumarValor.Name = "btnSumarValor"
        Me.btnSumarValor.Size = New System.Drawing.Size(163, 64)
        Me.btnSumarValor.TabIndex = 4
        Me.btnSumarValor.Text = "Sumar por valor"
        Me.btnSumarValor.UseVisualStyleBackColor = True
        '
        'btnSumarReferencia
        '
        Me.btnSumarReferencia.Location = New System.Drawing.Point(322, 297)
        Me.btnSumarReferencia.Name = "btnSumarReferencia"
        Me.btnSumarReferencia.Size = New System.Drawing.Size(163, 64)
        Me.btnSumarReferencia.TabIndex = 9
        Me.btnSumarReferencia.Text = "Sumar por referencia"
        Me.btnSumarReferencia.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(562, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(562, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'btnCargar2
        '
        Me.btnCargar2.Location = New System.Drawing.Point(180, 236)
        Me.btnCargar2.Name = "btnCargar2"
        Me.btnCargar2.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar2.TabIndex = 6
        Me.btnCargar2.Text = "Cargar"
        Me.btnCargar2.UseVisualStyleBackColor = True
        '
        'txtCargar1
        '
        Me.txtCargar1.Location = New System.Drawing.Point(305, 237)
        Me.txtCargar1.Name = "txtCargar1"
        Me.txtCargar1.Size = New System.Drawing.Size(198, 23)
        Me.txtCargar1.TabIndex = 5
        '
        'ValorYReferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSumarReferencia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCargar2)
        Me.Controls.Add(Me.txtCargar1)
        Me.Controls.Add(Me.btnSumarValor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtValor)
        Me.Name = "ValorYReferencia"
        Me.Text = "Valor y referencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValor As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSumarValor As Button
    Friend WithEvents btnSumarReferencia As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCargar2 As Button
    Friend WithEvents txtCargar1 As TextBox
End Class
