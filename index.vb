Public Class index

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
        'Dim f As Form

        'For Each f In Me.MdiChildren
        '    If (f.Text = "Calculos") Then
        '        f.BringToFront()
        '        Return
        '    End If
        'Next

        'Dim childForm As New Calculos
        'childForm.Text = "Horas Trabajadas"
        'childForm.MdiParent = Me
        'childForm.Dock = DockStyle.Fill
        'childForm.Show()
        Llamar("Calculos")
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
        'childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem1.Click
        Dim f As Form

        For Each f In Me.MdiChildren
            If (f.Text = "Ejercicio 1 Array") Then
                f.BringToFront()
                Return
            End If
        Next

        Dim childForm As New ArrayEjercicio1
        childForm.Text = "Ejercicio 1 Array"
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem2.Click
        Dim f As Form

        For Each f In Me.MdiChildren
            If (f.Text = "Data grid view") Then
                f.BringToFront()
                Return
            End If
        Next

        Dim childForm As New DataGridView
        childForm.Text = "Data grid view"
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub

    Public Sub Llamar(texto As String)
        Dim f As Form
        Dim hijo As Form

        For Each f In Me.MdiChildren
            If f.Text = texto Then
                f.BringToFront()
                Return
            End If
        Next

        Select Case texto
            Case "Saludo"
                hijo = New Saludo
            Case "Calculos"
                hijo = New Calculos
                'Case "ValorReferencia"
                '    hijo = New ValorReferencia
                'Case "Listas"
                '    hijo = New Listas
                'Case "Arrays"
                '    hijo = New Arrays
        End Select

        hijo.Text = texto
        hijo.MdiParent = Me
        hijo.Dock = DockStyle.Fill
        hijo.Show()
    End Sub

    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class