Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data

Public Class DataGridView
    Dim i As Integer = 0
    Dim query As String = ""
    Dim result As String = -99
    Dim cnn As New SqlConnection("Data Source= LAPTOP-DSRES6T6\SQLEXPRESS; Initial Catalog= ProyectoInicial;Integrated Security = SSPI")
    Dim msj As DialogResult
    Private Sub DataGridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DataGridView1.Rows.Add()

        'DataGridView1.Rows(0).Cells(0).Value = "gabriel"
        'DataGridView1.Rows(0).Cells(1).Value = "mondino"
        'DataGridView1.Rows(0).Cells(2).Value = "23"
        'DataGridView1.Rows(0).Cells(3).Value = "pepito@gmail.com"

        'DataGridView1.Rows(1).Cells(0).Value = "juan"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnn As New SqlConnection("Data Source= LAPTOP-DSRES6T6\SQLEXPRESS; Initial Catalog= ProyectoInicial;Integrated Security = SSPI")
        Dim da As New SqlDataAdapter("Select * from dbo.Clientes", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView


    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim state As Boolean = False
        If DataGridView1.CurrentRow IsNot Nothing Then
            If (MessageBox.Show("¿Desea eliminar el cliente " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("clId").Value.ToString & " - " & DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("clNombre").Value.ToString & "?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                ''No es necesario quitar la fila ya que se quita sola al presionar Delete
                ''DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                Cliente_Borrar(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("clId").Value)
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Public Function Cliente_Borrar(ByVal id As Integer) As Integer
        Try
            query = String.Format("DELETE FROM [dbo].[Clientes] WHERE clId = '{0}'", id)
            result = SqlHelper.ExecuteNonQuery(cnn, CommandType.Text, query)
        Catch ex As Exception

        End Try
        Return result
    End Function
End Class