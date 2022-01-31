Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class AltaPelis
    'Variables BBDD
    Dim file As String = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), "EMPRESA.mdb")
    Dim cnnString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file}"
    'Variables par ael form
    Dim titulo As String
    Dim peli As Peliculas
    Dim MIN As Integer = 3
    Dim MAXIMO As Integer = 255
    Dim REGULAREXP As String = "[0-9]"
    Dim id As Integer


    Public Sub New()
        InitializeComponent()
        rellenarGeneros()
        peli = New Peliculas()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        titulo = Me.txtBoxTitulo.Text
        'Comprobar y guardar datos
        If comprobarLongitud(MIN, MAXIMO, titulo) Then
            'id
            actualizarId()
            'titulo
            peli.titulo = titulo
            'productora
            If comprobarLongitud(MIN, MAXIMO, Me.txtBoxProductora.Text) Then
                peli.productora = Me.txtBoxProductora.Text
            Else
                MessageBox.Show("El nombre de la productora debe ser de entre 3 y 255 caracteres")
                peli.productora = "Miramax"
            End If
            'pais
            If comprobarLongitud(MIN, MAXIMO, Me.txtBoxPais.Text) Then
                peli.pais = Me.txtBoxPais.Text
            Else
                MessageBox.Show("El nombre del pais debe ser de entre 3 y 255 caracteres")
                peli.pais = "EEUU"
            End If
            'director
            If comprobarLongitud(MIN, MAXIMO, Me.TextBtxtBoxDirector.Text) Then
                peli.director = Me.TextBtxtBoxDirector.Text
            Else
                MessageBox.Show("El nombre del director debe ser de entre 3 y 255 caracteres")
                peli.director = "Una genio"
            End If
            'anyo
            If isNum(Me.txtBoxAnyo.Text) Then
                peli.anyo = CInt(Me.txtBoxAnyo.Text)
            Else
                MessageBox.Show("Año debe ser un numero")
                peli.anyo = 1980
            End If

            If isNum(Me.txtBoxDuracion.Text) Then
                peli.duracion = CInt(Me.txtBoxDuracion.Text)
            Else
                MessageBox.Show("Duracion debe ser un numero")
                peli.duracion = 90
            End If

            If isNum(Me.txtBoxPrecio.Text) Then
                peli.precio = CInt(Me.txtBoxPrecio.Text)
            Else
                MessageBox.Show("Precio debe ser un numero")
                peli.precio = 12
            End If

            peli.genero = ComboBoxGeneros.SelectedValue

            guardarPeli()

        Else
            MessageBox.Show("El título es obligatorio, debe contener entre 3 y 255 caracteres")
        End If

    End Sub

    Private Sub actualizarId()
        ' instanciamos la base de datos
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)


        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try
                    Dim sql As String = "SELECT MAX(PeliculaId) FROM Peliculas"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        peli.Id = cmd.ExecuteScalar() + 1

                    Catch ex As Exception

                    End Try

                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception
            MessageBox.Show("Error de conexión")
        Finally
            If Not IsNothing(cnnDB) Then
                cnnDB.Close()
            End If
        End Try
    End Sub

    Private Sub guardarPeli()

        Try

            ' instanciamos la base de datos
            Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

            Try
                cnnDB.Open()
                If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                    Try

                        'id = cmd.ExecuteNonQuery() + 1

                        'Dim Sql = String.Format("INSERT into Peliculas (PeliculaId, Titulo, Duracion, CodGenero, Anyo, Productora, Pais, Precio, Director) VALUES ({0}, {1}, {2}, {3}. {4}, {5}, {6}, {7}, {8});", id, peli.titulo, peli.duracion, peli.anyo, peli.productora, peli.pais, peli.precio, peli.director)
                        Dim Sql = "INSERT into Peliculas ([PeliculaId], [Titulo], [Duracion], [CodGenero], [Anyo], [Productora], [Pais], [Precio], [Director]) VALUES (@PeliculaId, @Titulo, @Duracion, @CodGenero, @Anyo, @Productora, @Pais, @Precio, @Director)"
                        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, cnnDB)

                        cmd.Parameters.AddWithValue("@PeliculaId", peli.Id)
                        cmd.Parameters.AddWithValue("@Titulo", peli.titulo)
                        cmd.Parameters.AddWithValue("@Duracion", peli.duracion)
                        cmd.Parameters.AddWithValue("@CodGenero", peli.genero)
                        cmd.Parameters.AddWithValue("@Anyo", peli.anyo)
                        cmd.Parameters.AddWithValue("@Productora", peli.productora)
                        cmd.Parameters.AddWithValue("@Pais", peli.pais)
                        cmd.Parameters.AddWithValue("@Precio", peli.precio)
                        cmd.Parameters.AddWithValue("@Director", peli.director)


                        If cmd.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("Pelicula insertada correctamente", "Resultado")

                            GestionPeliculas.gridViewPelis.Rows.Add(peli.Id, peli.titulo, peli.anyo, peli.director, ComboBoxGeneros.Text)

                        Else
                            MessageBox.Show("Error al insertar", "Resultado")
                        End If

                    Catch ex As Exception

                    End Try

                End If
            Catch ex As Exception
                MessageBox.Show("Error de conexión")
            Finally
                If Not IsNothing(cnnDB) Then
                    cnnDB.Close()
                End If
            End Try
        Catch ex As Exception

        End Try
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

        If Regex.IsMatch(text, REGULAREXP) Then
            Return True
        Else
            Return False
        End If
    End Function


    Function rellenarGeneros() As Integer
        ' instanciamos la base de datos
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = "SELECT Nombre, GeneroId FROM Generos"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        ' Dim dataReader As OleDbDataReader = cmd.ExecuteReader()


                        'While dataReader.Read()

                        'Me.ComboBoxGeneros.Items.Add(dataReader.Item(0))

                        'End While

                        'Dim dic As New Dictionary(Of Integer, String)
                        'Me.ComboBoxGeneros.DataSource = dic
                        'Me.ComboBoxGeneros.ValueMember = "Key"
                        'Me.ComboBoxGeneros.DisplayMember = "Value"
                        'NameOf(variable)

                        '*******
                        Dim dt As DataTable = New DataTable()
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        Dim selectedIndex As Integer = 0

                        adapter.Fill(dt)

                        For i = 0 To dt.Rows.Count - 1
                            If dt.Rows.Item(i).Item(0) = "GeneroId" Then
                                selectedIndex = i
                            End If
                        Next

                        ComboBoxGeneros.Items.Clear()

                        ComboBoxGeneros.DataSource = dt
                        ComboBoxGeneros.ValueMember = "GeneroID"
                        ComboBoxGeneros.DisplayMember = "Nombre"
                        ComboBoxGeneros.SelectedIndex = selectedIndex

                        ComboBoxGeneros.Refresh()
                        '************



                    Catch ex As Exception

                    End Try

                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception
            MessageBox.Show("Error de conexión")
        Finally
            If Not IsNothing(cnnDB) Then
                cnnDB.Close()
            End If
        End Try
        Me.ComboBoxGeneros.SelectedIndex = 0
        Return 0
    End Function

    Private Sub btnAltaVolver_Click(sender As Object, e As EventArgs) Handles btnAltaVolver.Click
        Me.Dispose()
    End Sub
End Class