Public Class ValorYReferencia
    Public numero As Integer


    Public Function sumarValor(ByVal num As Integer)
        num = num + 1
        Return num
    End Function

    Public Function sumarRef(ByRef num As Integer)
        numero = numero + 1
        Return numero
    End Function

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        numero = txtValor.Text
    End Sub

    Private Sub btnSumarValor_Click(sender As Object, e As EventArgs) Handles btnSumarValor.Click
        Label2.Text = sumarValor(numero)
        Label1.Text = numero

    End Sub


    Private Sub btnSumarReferencia_Click(sender As Object, e As EventArgs) Handles btnSumarReferencia.Click
        Label4.Text = numero
        Label3.Text = sumarRef(numero)
    End Sub

    Private Sub btnCargar2_Click(sender As Object, e As EventArgs) Handles btnCargar2.Click
        numero = txtCargar1.Text
    End Sub
End Class