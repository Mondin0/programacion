Public Class Calculos
    Private Sub calcularHoras_Click(sender As Object, e As EventArgs) Handles calcularHoras.Click

        Try
            Dim hora As Integer = CInt(txtHorasTrabajadas.Text)
            txtSueldo.Text = calcularSueldo(hora)
        Catch ex As Exception : MessageBox.Show(ex.Message, "Atención loko", MessageBoxButtons.OK)
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

    Private Sub Calculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class