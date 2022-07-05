Namespace Entidades
    Public Class ClienteE

#Region "Miembros"
        Private clId As Integer
        Private clApellido As String
        Private clNombre As String
        Private clDireccion As String
        Private clEmail As String
#End Region

#Region "Propiedades"

        Public Property ClId1 As Integer
            Get
                Return clId
            End Get
            Set(value As Integer)
                clId = value
            End Set
        End Property

        Public Property ClApellido1 As String
            Get
                Return clApellido
            End Get
            Set(value As String)
                clApellido = value
            End Set
        End Property

        Public Property ClNombre1 As String
            Get
                Return clNombre
            End Get
            Set(value As String)
                clNombre = value
            End Set
        End Property

        Public Property ClDireccion1 As String
            Get
                Return clDireccion
            End Get
            Set(value As String)
                clDireccion = value
            End Set
        End Property

        Public Property ClEmail1 As String
            Get
                Return clEmail
            End Get
            Set(value As String)
                clEmail = value
            End Set
        End Property
#End Region
    End Class
End Namespace


