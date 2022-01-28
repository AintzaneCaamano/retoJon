Public Class Municipio
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _codMunicipio As String
    Public Property CodMunicipio() As String
        Get
            Return _codMunicipio
        End Get
        Set(ByVal value As String)
            _codMunicipio = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _provincia As Provincia
    Public Property Provincia() As Provincia
        Get
            Return _provincia
        End Get
        Set(ByVal value As Provincia)
            _provincia = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
