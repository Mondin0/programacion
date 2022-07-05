Imports Clase_1_tecnicatura.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.ApplicationBlocks.Data
Namespace AccesoDatos

    Public Class SqlDataProvider
        Dim cnn As New SqlConnection("Data Source= LAPTOP-DSRES6T6\SQLEXPRESS; Initial Catalog= ProyectoInicial;Integrated Security = SSPI")
    End Class

End Namespace


