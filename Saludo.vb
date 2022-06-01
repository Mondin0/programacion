Public Class Saludo
    Dim msj As String
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        Me.EtiquetaHolaMundo.Text = msj
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msj = "Ejecutado"
        Me.BtnEjecutar.Text = "Boton"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        index.Show()
        EtiquetaHolaMundo.Text = ""
    End Sub
End Class
