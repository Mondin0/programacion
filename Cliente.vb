Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class ClienteE
    Public f As New DataGridView
    Dim msj As DialogResult
    Dim query As String = ""
    Dim result As String = -99
    Dim cnn As New SqlConnection("Data Source= LAPTOP-DSRES6T6\SQLEXPRESS; Initial Catalog= ProyectoInicial;Integrated Security = SSPI")

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
    End Sub
    Public Sub InicializarComponentes()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtEmail.Text = ""
        txtDireccion.Text = ""
    End Sub


    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close() 'cierra el formulario
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            txtNombre.Focus()
            Utilidades.ShowBalloon(txtNombre, "Error", "El campo Nombre no puede estar vacío", ToolTipIcon.Error, 5000)
            Return
        End If
        If String.IsNullOrEmpty(txtApellido.Text) Then
            txtApellido.Focus()
            Utilidades.ShowBalloon(txtApellido, "Error", "El campo Apellido no puede estar vacío", ToolTipIcon.Error, 5000)
            Return
        End If
        query = String.Format("INSERT INTO [dbo].[Clientes]
            ([clApellido],[clNombre],[clDireccion],[clEmail])
         VALUES
           ('{0}','{1}','{2}','{3}')", txtApellido.Text.Trim, txtNombre.Text.Trim, txtDireccion.Text.Trim, txtEmail.Text.Trim)
        result = SqlHelper.ExecuteNonQuery(cnn, CommandType.Text, query)
        Select Case btnGuardar.Text
            Case "Guardar"
                Select Case result
                    Case -99 ' Error al guardar en la base de datos
                        Utilidades.ShowBalloon(btnGuardar, "Lo siento", "No se pudo guardar el cliente", ToolTipIcon.Error)
                    Case Else
                        msj = MessageBox.Show("Cliente creado exitosamente!", "Felicitaciones", MessageBoxButtons.OK)
                        Me.Close()

                End Select
            Case "Modificar"
                Select Case result
                    Case -99 ' Error al guardar en la base de datos
                        Utilidades.ShowBalloon(btnGuardar, "Lo siento", "No se pudo modificar el cliente", ToolTipIcon.Error)
                    Case Else
                        msj = MessageBox.Show("Cliente modificado exitosamente!", "Felicitaciones", MessageBoxButtons.OK)
                        Me.Close()
                End Select
        End Select
    End Sub
End Class