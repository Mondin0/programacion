Public Class index
    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LlamarAForm1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlamarAForm1ToolStripMenuItem.Click
        'Form1.Show()
        'Me.Hide()

        Dim f As Form

        For Each f In Me.MdiChildren
            If (f.Text = "Saludo") Then
                f.BringToFront()
                Return
            End If
        Next

        Dim childForm As New Saludo
        childForm.Text = "Saludo"
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()

    End Sub


    Private Sub HorasTrabajadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorasTrabajadasToolStripMenuItem.Click
        Dim f As Form

        For Each f In Me.MdiChildren
            If (f.Text = "Calculos") Then
                f.BringToFront()
                Return
            End If
        Next

        Dim childForm As New Calculos
        childForm.Text = "Horas Trabajadas"
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub

    Private Sub ValorYReferenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValorYReferenciaToolStripMenuItem.Click
        Dim f As Form

        For Each f In Me.MdiChildren
            If (f.Text = "Valor y referencia") Then
                f.BringToFront()
                Return
            End If
        Next

        Dim childForm As New ValorYReferencia
        childForm.Text = "Valor y referencia"
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub

    Private Sub SueldoPorValorYReferenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SueldoPorValorYReferenciaToolStripMenuItem.Click
        Dim f As Form

        For Each f In Me.MdiChildren
            If (f.Text = "Sueldo por valor y referencia") Then
                f.BringToFront()
                Return
            End If
        Next

        Dim childForm As New SueldoValorRef
        childForm.Text = "Sueldo por valor y referencia"
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        Dim f As Form

        For Each f In Me.MdiChildren
            If (f.Text = "Listas") Then
                f.BringToFront()
                Return
            End If
        Next

        Dim childForm As New Listas
        childForm.Text = "Listas"
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub
End Class