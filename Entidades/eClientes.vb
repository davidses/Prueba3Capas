Public Class eClientes
    Private _Id As String
    Private _Nombre As String
    Private _Domicilio As String
    Private _Telefono As String
    Private _Observacion As String

    Public Property Id As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            _Domicilio = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property

    Public Shared Sub Main()

    End Sub

End Class
