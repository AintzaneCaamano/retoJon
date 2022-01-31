Public Class Peliculas
    ' una prueba desde VS 
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _titulo As String
    Public Property titulo() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
        End Set
    End Property

    Private _duracion As Integer
    Public Property duracion() As Integer
        Get
            Return _duracion
        End Get
        Set(ByVal value As Integer)
            _duracion = value
        End Set
    End Property

    Private _anyo As String
    Public Property anyo() As String
        Get
            Return _anyo
        End Get
        Set(ByVal value As String)
            _anyo = value
        End Set
    End Property


    Private _productora As String
    Public Property productora() As String
        Get
            Return _productora
        End Get
        Set(ByVal value As String)
            _productora = value
        End Set
    End Property

    Private _pais As String
    Public Property pais() As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property

    Private _precio As Double
    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
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

    Private _genero As Integer
    Public Property genero() As Integer
        Get
            Return _genero
        End Get
        Set(ByVal value As Integer)
            _genero = value
        End Set
    End Property
End Class
