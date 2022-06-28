Public Class ArrayEjercicio1
    Dim numeros() As Integer
    Dim i As Integer = -1 ' lo inicializo en -1 para que la posición inicial del array al presionar Almacenar, sea 0
    Dim suma As Integer = 0
    Dim media As Double = 0
    Dim msj As DialogResult

    'Ejercicio: Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y sacar la media
    'En este caso se crea un array de n posiciones
    Private Sub ArrayEjercicio1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtValor.Text = ""
    End Sub


    Private Sub btnAlmacenar_Click(sender As Object, e As EventArgs) Handles btnAlmacenar.Click
        Try
            i = i + 1 ' incremento en uno el índice para ir almacenando en cada posición del array
            numeros(i) = CInt(txtValor.Text.Trim)
            suma += numeros(i)
            txtValor.Text = "" ' limpio el textbox para ingresar el siguiente valor
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Function CalcularPromedio(ByVal suma As Integer)
        media = suma / numeros.Length

        msj = MessageBox.Show("El Promedio de los números ingresados es:" & media, "Información", MessageBoxButtons.OK)
        Return media
    End Function

    Private Sub btnPromedio_Click(sender As Object, e As EventArgs) Handles btnPromedio.Click
        CalcularPromedio(suma)
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim n As Integer
        For n = 0 To numeros.Length - 1 ' recorro hasta la longitud -1
            msj = MessageBox.Show(numeros(n)) ' Muestro los elementos del array
        Next
    End Sub
End Class