Public Class index

    Private Sub LlamarAForm1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlamarAForm1ToolStripMenuItem.Click
        Llamar("Saludo")
    End Sub


    Private Sub HorasTrabajadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorasTrabajadasToolStripMenuItem.Click
        Llamar("Calculos")
    End Sub

    Private Sub ValorYReferenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValorYReferenciaToolStripMenuItem.Click
        Llamar("Valor y referencia")
    End Sub

    Private Sub SueldoPorValorYReferenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SueldoPorValorYReferenciaToolStripMenuItem.Click
        Llamar("Sueldo por valor y referencia")
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        Llamar("Listas")
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem1.Click

        Llamar("Ejercicio 1 Array")

    End Sub

    Private Sub Ejercicio1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem2.Click

        Llamar("Data grid view")
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
            Case "Valor y referencia"
                hijo = New ValorYReferencia
            Case "Sueldo por valor y referencia"
                hijo = New SueldoValorRef
            Case "Listas"
                hijo = New Listas
            Case "Ejercicio 1 Array"
                hijo = New ArrayEjercicio1
            Case "Data grid view"
                hijo = New DataGridView
        End Select

        hijo.Text = texto
        hijo.MdiParent = Me
        hijo.Dock = DockStyle.Fill
        hijo.Show()
    End Sub

    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class