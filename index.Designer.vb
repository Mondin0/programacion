<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LlamarAForm1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CálculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorasTrabajadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValorYReferenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SueldoPorValorYReferenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LlamarAForm1ToolStripMenuItem, Me.CálculosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(126, 450)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LlamarAForm1ToolStripMenuItem
        '
        Me.LlamarAForm1ToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.LlamarAForm1ToolStripMenuItem.Name = "LlamarAForm1ToolStripMenuItem"
        Me.LlamarAForm1ToolStripMenuItem.Size = New System.Drawing.Size(113, 19)
        Me.LlamarAForm1ToolStripMenuItem.Text = "Llamar a saludo"
        '
        'CálculosToolStripMenuItem
        '
        Me.CálculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HorasTrabajadasToolStripMenuItem, Me.ValorYReferenciaToolStripMenuItem, Me.SueldoPorValorYReferenciaToolStripMenuItem})
        Me.CálculosToolStripMenuItem.Name = "CálculosToolStripMenuItem"
        Me.CálculosToolStripMenuItem.Size = New System.Drawing.Size(113, 19)
        Me.CálculosToolStripMenuItem.Text = "Cálculos"
        '
        'HorasTrabajadasToolStripMenuItem
        '
        Me.HorasTrabajadasToolStripMenuItem.Name = "HorasTrabajadasToolStripMenuItem"
        Me.HorasTrabajadasToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.HorasTrabajadasToolStripMenuItem.Text = "Horas trabajadas"
        '
        'ValorYReferenciaToolStripMenuItem
        '
        Me.ValorYReferenciaToolStripMenuItem.Name = "ValorYReferenciaToolStripMenuItem"
        Me.ValorYReferenciaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ValorYReferenciaToolStripMenuItem.Text = "Valor y referencia"
        '
        'SueldoPorValorYReferenciaToolStripMenuItem
        '
        Me.SueldoPorValorYReferenciaToolStripMenuItem.Name = "SueldoPorValorYReferenciaToolStripMenuItem"
        Me.SueldoPorValorYReferenciaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.SueldoPorValorYReferenciaToolStripMenuItem.Text = "Sueldo por valor y referencia"
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "index"
        Me.Text = "Index"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LlamarAForm1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CálculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorasTrabajadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValorYReferenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SueldoPorValorYReferenciaToolStripMenuItem As ToolStripMenuItem
End Class
