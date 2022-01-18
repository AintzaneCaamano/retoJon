Public Class Peliculas
    ' una prueba desde VS 
    Private _titulo As String
    Public Property titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property

    Private _anio As String
    Public Property Anio() As String
        Get
            Return _anio
        End Get
        Set(ByVal value As String)
            _anio = value
        End Set
    End Property

    Private _director As String
    Public Property director() As String
        Get
            Return _director
        End Get
        Set(ByVal value As String)
            _director = value
        End Set
    End Property

    Private _genero As String
    Public Property genero() As String
        Get
            Return _genero
        End Get
        Set(ByVal value As String)
            _genero = value
        End Set
    End Property

End Class
