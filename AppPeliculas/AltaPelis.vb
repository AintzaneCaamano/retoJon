Public Class AltaPelis
    Dim titulo As String
    Dim peli As Peliculas
    Dim MIN As Integer = 3
    Dim MAXIMO As Integer = 255

    Private Sub AltaPelis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        peli = New Peliculas
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        titulo = Me.txtBoxTitulo.Text
        If comprobarLongitud(MIN, MAXIMO, titulo) Then
            peli.titulo = titulo



        End If
    End Sub

    Function comprobarLongitud(minimo As Integer, maximo As Integer, text As String) As Boolean
        If text.Length > MIN And text.Length < maximo Then
            Return True
        Else
            Return False
        End If
    End Function

    Function comprobarAnyo(text As String) As Integer
        System.Text.RegularExpressions
        Return 0
    End Function
End Class