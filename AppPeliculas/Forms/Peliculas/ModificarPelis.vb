Public Class ModificarPelis
    'Variables BBDD
    Dim file As String = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), "EMPRESA.mdb")
    Dim cnnString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file}"
    Dim idPeli As Integer
    Public Sub New(id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idPeli = id
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ModificarPelis_Load()
        rellenarGeneros()
    End Sub
    Private Sub ModificarPelis_Load()

        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)


        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = $"SELECT PeliculaId, Titulo, Duracion, CodGenero, Anyo, Productora, Pais, Precio, Director FROM Peliculas WHERE PeliculaId = {idPeli}"

                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)

                        adapter.Fill(dt)

                        If dt.Rows.Count > 0 Then

                            txtBoxTitulo.Text = dt.Rows.Item(0).Item(1)
                            txtBoxDuracion.Text = dt.Rows.Item(0).Item(2)
                            txtBoxAnyo.Text = dt.Rows.Item(0).Item(4)
                            txtBoxProductora.Text = dt.Rows.Item(0).Item(5)
                            txtBoxPais.Text = dt.Rows.Item(0).Item(6)
                            txtBoxPrecio.Text = dt.Rows.Item(0).Item(7)
                            TextBtxtBoxDirector.Text = dt.Rows.Item(0).Item(8)

                        End If

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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = ConnectionState.Open) Then

                Try

                    Dim cmd As OleDb.OleDbCommand = cnnDB.CreateCommand()
                    Dim Sql As String = "UPDATE Peliculas SET " _
                        & "[Titulo] = @Titulo, " _
                        & "[Duracion] = @Duracion, " _
                        & "[Anyo] = @Anyo, " _
                        & "[Productora] = @Productora, " _
                        & "[Pais] = @Pais, " _
                        & "[Precio] = @Precio, " _
                        & "[Director] = @Director, " _
                        & "[CodGenero] = @GeneroId"




                    cmd.Parameters.AddWithValue("@Titulo", txtBoxTitulo.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Duracion", txtBoxDuracion.Text).OleDbType = OleDb.OleDbType.Integer
                    cmd.Parameters.AddWithValue("@Anyo", txtBoxAnyo.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Productora", txtBoxProductora.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Pais", txtBoxPais.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Precio", txtBoxPrecio.Text).OleDbType = OleDb.OleDbType.Double
                    cmd.Parameters.AddWithValue("@Director", TextBtxtBoxDirector.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@GeneroId", ComboBoxGeneros.SelectedValue).OleDbType = OleDb.OleDbType.Integer


                    Sql = Sql.Substring(0, Sql.Length - 2)

                    Sql += $" WHERE [PeliculaId] = @PeliculaId"

                    cmd.Parameters.AddWithValue("@PeliculaId", idPeli).OleDbType = OleDb.OleDbType.Integer
                    cmd.CommandText = Sql


                    Try

                        If cmd.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("Datos actualizados correctamente", "Resultado")

                            Me.Dispose()
                        Else
                            MessageBox.Show("Error al actualizar", "Resultado")
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
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

    Private Sub btnAltaVolver_Click(sender As Object, e As EventArgs) Handles btnAltaVolver.Click
        Me.Dispose()
    End Sub

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

End Class