<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listas
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
        Me.lblElemento = New System.Windows.Forms.Label()
        Me.txtEemento = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.listbxElementos = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblElemento
        '
        Me.lblElemento.AutoSize = True
        Me.lblElemento.Location = New System.Drawing.Point(119, 77)
        Me.lblElemento.Name = "lblElemento"
        Me.lblElemento.Size = New System.Drawing.Size(57, 15)
        Me.lblElemento.TabIndex = 0
        Me.lblElemento.Text = "Elemento"
        '
        'txtEemento
        '
        Me.txtEemento.Location = New System.Drawing.Point(193, 74)
        Me.txtEemento.Name = "txtEemento"
        Me.txtEemento.Size = New System.Drawing.Size(235, 23)
        Me.txtEemento.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(462, 72)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(462, 136)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 3
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnVaciar
        '
        Me.btnVaciar.Location = New System.Drawing.Point(462, 198)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(75, 23)
        Me.btnVaciar.TabIndex = 4
        Me.btnVaciar.Text = "Vaciar"
        Me.btnVaciar.UseVisualStyleBackColor = True
        '
        'listbxElementos
        '
        Me.listbxElementos.FormattingEnabled = True
        Me.listbxElementos.ItemHeight = 15
        Me.listbxElementos.Location = New System.Drawing.Point(193, 150)
        Me.listbxElementos.Name = "listbxElementos"
        Me.listbxElementos.Size = New System.Drawing.Size(235, 169)
        Me.listbxElementos.TabIndex = 5
        '
        'Listas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.listbxElementos)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtEemento)
        Me.Controls.Add(Me.lblElemento)
        Me.Name = "Listas"
        Me.Text = "Listas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblElemento As Label
    Friend WithEvents txtEemento As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents listbxElementos As ListBox
End Class
