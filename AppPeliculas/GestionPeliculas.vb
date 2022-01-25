Public Class GestionPeliculas
    Dim file As String = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), "EMPRESA.mdb")
    Dim cnnString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file}"

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
        altaPelis = New AltaPelis
        modificarPeli = New ModificarPelis
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
                                {Environment.NewLine} Duracion: {row.Field(Of String)("Duracion")}
                                {Environment.NewLine} CodGenero: {row.Field(Of String)("CodGenero")}
                                {Environment.NewLine}Dirección: {row.Field(Of String)("Direccion")} 
                                {Environment.NewLine} Anyo: {row.Field(Of String)("Anyo")} 
                                {Environment.NewLine} Productora: {row.Field(Of Boolean)("Productora")} 
                                {Environment.NewLine} Pais: {row.Field(Of String)("Pais")}")
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
        altaPelis.Show()
        altaPelis.Activate()
    End Sub

    Private Sub btnPelisModificar_Click(sender As Object, e As EventArgs) Handles btnPelisModificar.Click
        modificarPeli.Show()
        modificarPeli.Activate()
    End Sub

    Private Sub btnPelisBaja_Click(sender As Object, e As EventArgs) Handles btnPelisBaja.Click

    End Sub

    Public Sub loadData()
        ' instanciamos la base de datos
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)


        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = "SELECT Peliculas.Titulo,  Peliculas.Anyo as Año, Peliculas.Director,  Generos.Nombre as Genero FROM (Peliculas INNER JOIN Generos ON Peliculas.CodGenero = Generos.GeneroId)"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)

                        adapter.Fill(dt)

                        gridViewPelis.DataSource = dt

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
End Class