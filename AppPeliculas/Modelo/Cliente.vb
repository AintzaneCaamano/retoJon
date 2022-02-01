Public Class Cliente
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Private _apellido1 As String
    Public Property Apellido1() As String
        Get
            Return _apellido1
        End Get
        Set(ByVal value As String)
            _apellido1 = value
        End Set
    End Property

    Private _apellido2 As String
    Public Property Apellido2() As String
        Get
            Return _apellido2
        End Get
        Set(ByVal value As String)
            _apellido2 = value
        End Set
    End Property

    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Private _cp As String
    Public Property Cp() As String
        Get
            Return _cp
        End Get
        Set(ByVal value As String)
            _cp = value
        End Set
    End Property

    Private _municipio As Municipio
    Public Property Municipio() As Municipio
        Get
            Return _municipio
        End Get
        Set(ByVal value As Municipio)
            _municipio = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _esBaja As Boolean
    Public Property EsBaja() As Boolean
        Get
            Return _esBaja
        End Get
        Set(ByVal value As Boolean)
            _esBaja = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
