Imports System.Data
Imports System.Data.SqlClient

Public Class DataGridView
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
End Class