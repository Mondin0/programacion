<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Saludo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.EtiquetaHolaMundo = New System.Windows.Forms.Label()
        Me.BtnEjecutar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EtiquetaHolaMundo
        '
        Me.EtiquetaHolaMundo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.EtiquetaHolaMundo.Location = New System.Drawing.Point(255, 94)
        Me.EtiquetaHolaMundo.Name = "EtiquetaHolaMundo"
        Me.EtiquetaHolaMundo.Size = New System.Drawing.Size(165, 23)
        Me.EtiquetaHolaMundo.TabIndex = 0
        '
        'BtnEjecutar
        '
        Me.BtnEjecutar.Location = New System.Drawing.Point(255, 186)
        Me.BtnEjecutar.Name = "BtnEjecutar"
        Me.BtnEjecutar.Size = New System.Drawing.Size(116, 104)
        Me.BtnEjecutar.TabIndex = 1
        Me.BtnEjecutar.Text = "Ejecutar"
        Me.BtnEjecutar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnEjecutar)
        Me.Controls.Add(Me.EtiquetaHolaMundo)
        Me.Name = "Form1"
        Me.Text = "Saludo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EtiquetaHolaMundo As Label
    Friend WithEvents BtnEjecutar As Button
    Friend WithEvents Button1 As Button
End Class
