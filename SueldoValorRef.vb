Public Class SueldoValorRef
    Public num As Integer
    Private Sub calcularHoras_Click(sender As Object, e As EventArgs) Handles calcularHoras.Click

        Try
            Dim hora As Integer = CInt(txtHorasTrabajadas.Text)
            txtSueldo.Text = calcularSueldo(hora)
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Function calcularSueldo(ByVal horas As Integer)
        Dim horasTrabajadas As Integer = horas
        Dim diferencia As Integer = horasTrabajadas - 160
        Dim sueldo As Double
        If horasTrabajadas <= 160 Then
            sueldo = horasTrabajadas * 620
        Else
            sueldo = horasTrabajadas * 620
            Dim horasExtra As Double = diferencia * 680.5
            sueldo = sueldo + horasExtra
        End If

        Return sueldo
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtSueldo.Text = ""
        txtHorasTrabajadas.Text = ""

    End Sub

    Private Sub btnCalcularRef_Click(sender As Object, e As EventArgs) Handles btnCalcularRef.Click
        Try
            Dim numero As Integer = CInt(txtHorasTrabajadasRef.Text)
            txtSueldoRef.Text = calcularSueldoRef(numero)
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Function calcularSueldoRef(ByRef num As Integer)
        Dim diferencia As Integer = num - 160
        Dim sueldo As Double
        If num <= 160 Then
            sueldo = num * 620
        Else
            sueldo = num * 620
            Dim horasExtra As Double = diferencia * 680.5
            sueldo = sueldo + horasExtra
        End If

        Return sueldo
        num += 1
    End Function
End Class