Imports System.Text.RegularExpressions

Public Class AltaPelis
    Dim titulo As String
    Dim peli As Peliculas
    Dim MIN As Integer = 3
    Dim MAXIMO As Integer = 255
    Dim REGULAR As String = "[0-9]"

    Private Sub AltaPelis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        peli = New Peliculas
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        titulo = Me.txtBoxTitulo.Text
        'Comprobar y guardar datos
        If comprobarLongitud(MIN, MAXIMO, titulo) Then
            'titulo
            peli.titulo = titulo
            'productora
            If comprobarLongitud(MIN, MAXIMO, Me.txtBoxProductora.Text) Then
                peli.productora = Me.txtBoxProductora.Text
            End If
            'pais
            If comprobarLongitud(MIN, MAXIMO, Me.txtBoxPais.Text) Then
                peli.pais = Me.txtBoxPais.Text
            End If
            'director
            If comprobarLongitud(MIN, MAXIMO, Me.TextBtxtBoxDirector.Text) Then
                peli.director = Me.TextBtxtBoxDirector.Text
            End If
            'anyo
            If isNum(Me.txtBoxAnyo.Text) Then
                peli.anyo = CInt(Me.txtBoxAnyo.Text)
            End If

            If isNum(Me.txtBoxDuracion.Text) Then
                peli.duracion = CInt(Me.txtBoxDuracion.Text)
            End If

            If isNum(Me.txtBoxPrecio.Text) Then
                peli.precio = CInt(Me.txtBoxPrecio.Text)
            End If

            peli.genero = Me.NumericUpDown1.Value



        Else
            MessageBox.Show("El título es obligatorio, debe contener entre 3 y 255 caracteres")
        End If
    End Sub

    Function comprobarLongitud(minimo As Integer, maximo As Integer, text As String) As Boolean
        If text.Length > MIN And text.Length < maximo Then
            Return True
        Else
            Return False
        End If
    End Function

    Function isNum(text As String) As Boolean
        'RegEx System.Text.RegularExpressions
        'System.Text.RegularExpressions.Match(text, REGULAR, RegexOptions.IgnoreCase)

        If Regex.IsMatch(text, REGULAR) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class