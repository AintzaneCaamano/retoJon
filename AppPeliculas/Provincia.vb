Public Class Provincia
    Private _codProvincia As String
    Public Property CodProvincia() As String
        Get
            Return _codProvincia
        End Get
        Set(ByVal value As String)
            _codProvincia = value
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

    Public Sub New()

    End Sub
End Class
