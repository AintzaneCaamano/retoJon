Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Public Class GestionPeliculas
    Dim file As String = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), "EMPRESA.mdb")
    Dim cnnString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file}"

    Private _bs As BindingSource
    Public Property MiBS() As BindingSource
        Get
            Return _bs
        End Get
        Set(ByVal value As BindingSource)
            _bs = value
        End Set
    End Property

    Private _altaPelis As AltaPelis
    Public Property altaPelis() As AltaPelis
        Get
            Return _altaPelis
        End Get
        Set(ByVal value As AltaPelis)
            _altaPelis = value
        End Set
    End Property

    Private _modPeli As ModificarPelis
    Public Property modificarPeli() As ModificarPelis
        Get
            Return _modPeli
        End Get
        Set(ByVal value As ModificarPelis)
            _modPeli = value
        End Set
    End Property

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub GestionPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnPelisDetalles_Click(sender As Object, e As EventArgs) Handles btnPelisDetalles.Click
        Dim idCliente
        Try
            idCliente = gridViewPelis.Rows.Item(gridViewPelis.SelectedCells.Item(0).RowIndex).Cells.Item("PeliculaId").Value

            ' instanciamos la base de datos
            Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

            Try
                cnnDB.Open()
                If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                    Try

                        Dim sql As String = $"SELECT PeliculaId, Titulo, Duracion, CodGenero, Anyo, Productora, Pais, Precio, Director FROM Peliculas WHERE PeliculaId = {idCliente}"
                        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                        Try

                            Dim dt As DataTable = New DataTable()
                            Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)

                            adapter.Fill(dt)

                            For Each row As DataRow In dt.Rows
                                MessageBox.Show($"Id: {row.Field(Of Integer)("PeliculaId")} 
                                {Environment.NewLine}Titulo: {row.Field(Of String)("Titulo")} 
                                {Environment.NewLine} Duracion: {row.Field(Of Integer)("Duracion")}
                                {Environment.NewLine} CodGenero: {row.Field(Of Integer)("CodGenero")}
                                {Environment.NewLine}Director: {row.Field(Of String)("Director")} 
                                {Environment.NewLine} Anyo: {row.Field(Of Short)("Anyo")} 
                                {Environment.NewLine} Productora: {row.Field(Of String)("Productora")} 
                                {Environment.NewLine} Pais: {row.Field(Of String)("Pais")}
                                {Environment.NewLine} Pais: {row.Field(Of Double)("Precio")}")
                            Next

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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPelisCrear_Click(sender As Object, e As EventArgs) Handles btnPelisCrear.Click
        altaPelis = New AltaPelis()

        Me.Hide()
        altaPelis.ShowDialog()
        loadData()
        Me.Show()
    End Sub

    Private Sub btnPelisModificar_Click(sender As Object, e As EventArgs) Handles btnPelisModificar.Click
        Dim id As Integer = gridViewPelis.Rows.Item(gridViewPelis.SelectedCells.Item(0).RowIndex).Cells.Item(0).Value
        modificarPeli = New ModificarPelis(id)
        Me.Hide()
        modificarPeli.ShowDialog()
        loadData()
        Me.Show()
    End Sub

    Private Sub btnPelisBaja_Click(sender As Object, e As EventArgs) Handles btnPelisBaja.Click
        Dim id

        Try
            id = gridViewPelis.Rows.Item(gridViewPelis.SelectedCells.Item(0).RowIndex).Cells.Item(0).Value

            ' instanciamos la base de datos
            Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

            Try
                cnnDB.Open()
                If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                    Try
                        Dim sql As String = $"DELETE FROM Peliculas WHERE [PeliculaId] = @idPelicula"
                        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                        cmd.Parameters.AddWithValue("@idPelicula", id).OleDbType = OleDb.OleDbType.Integer

                        If MessageBox.Show("¿Seguro que quieres borrar la película?", "Aviso", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            If cmd.ExecuteNonQuery() Then
                                MessageBox.Show("Pelicula dada de baja con exito")
                                loadData()
                            Else
                                MessageBox.Show("Ha ocurrido un error al dar de baja la Pelicula", "Aviso")
                            End If
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
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Selecciona un registro para darlo de baja")
        End Try
    End Sub

    Public Sub loadData()
        ' instanciamos la base de datos
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)


        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = "SELECT  Peliculas.PeliculaId, Peliculas.Titulo,  Peliculas.Anyo as Año, Peliculas.Director,  Generos.Nombre as Genero FROM (Peliculas INNER JOIN Generos ON Peliculas.CodGenero = Generos.GeneroId)"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        'Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, cnnDB)
                        adapter.Fill(dt)

                        MiBS = New BindingSource()
                        MiBS.DataSource = dt
                        gridViewPelis.DataSource = MiBS
                        MiBS.ResetBindings(False)

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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim info As List(Of Peliculas) = New List(Of Peliculas)()
        Dim appPath As String = Application.StartupPath()
        Dim jsonPath As String = Path.Combine(appPath, "Data", "info.json")

        Dim dt As DataTable = CType(_bs.DataSource, DataTable)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim peli1 As Peliculas = New Peliculas()

            peli1.titulo = dt.Rows(i)("Titulo")
            peli1.anyo = dt.Rows(i)("Año")
            If Not IsDBNull(dt.Rows(i)("Director")) Then
                peli1.director = dt.Rows(i)("Director")
            Else
                peli1.director = " "
            End If
            info.Add(peli1)
        Next

        Dim fs As FileStream
        Try
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = System.IO.File.Create(jsonPath)
                fs.Close()
                jsonPath = Path.Combine(FolderBrowserDialog1.SelectedPath, "info.json")
                Dim escribir As New StreamWriter(jsonPath)
                escribir.WriteLine(JsonConvert.SerializeObject(info))
                escribir.Close()
                MsgBox("Fichero generado en " & jsonPath, MsgBoxStyle.Information, "Información")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


        Dim json As String = JsonConvert.SerializeObject(info)
    End Sub

    Private Sub btnGuardarCsv_Click(sender As Object, e As EventArgs) Handles btnGuardarCsv.Click
        Dim info As List(Of Peliculas) = New List(Of Peliculas)()
        Dim appPath As String = Application.StartupPath()
        Dim filePath As String = Path.Combine(appPath, "Data", "info.csv")
        Dim separador As String = ";"

        Dim dt As DataTable = CType(_bs.DataSource, DataTable)

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim peli1 As Peliculas = New Peliculas()

            peli1.titulo = dt.Rows(i)("Titulo")
            peli1.anyo = dt.Rows(i)("Año")
            If Not IsDBNull(dt.Rows(i)("Director")) Then
                peli1.director = dt.Rows(i)("Director")
            Else
                peli1.director = " "
            End If
            info.Add(peli1)
        Next

        Dim fs As FileStream

        Try
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = System.IO.File.Create(filePath)
                fs.Close()
                filePath = Path.Combine(FolderBrowserDialog1.SelectedPath, "info.csv")



                Dim sw As New StreamWriter(filePath, False, Encoding.UTF8)

                Dim headers As String() = {"Titulo", "Año", "Director", "CodGenero"}
                sw.WriteLine(String.Join(separador, headers))

                For i = 0 To dt.Rows.Count - 1
                    Dim fields As String = dt.Rows(i).Item(1) & separador & dt.Rows(i).Item(2) & separador & dt.Rows(i).Item(3) & separador & dt.Rows(i).Item(4) & separador


                    sw.WriteLine(String.Join(separador, fields))
                Next
                sw.Close()

                MsgBox("Fichero generado en " & filePath, MsgBoxStyle.Information, "Información")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try


        Dim json As String = JsonConvert.SerializeObject(info)
    End Sub
End Class