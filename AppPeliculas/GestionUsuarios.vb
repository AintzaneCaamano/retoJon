Public Class GestionUsuarios

    Dim cnnString As String = My.Settings.EMPRESAConnectionString

    Private _formUpdateUsuario As UpdateUsuario
    Public Property FormUpdateUsuario() As UpdateUsuario
        Get
            Return _formUpdateUsuario
        End Get
        Set(ByVal value As UpdateUsuario)
            _formUpdateUsuario = value
        End Set
    End Property

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDatosClientes()

    End Sub

    Sub CargarDatosClientes()
        ' instanciamos la base de datos
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = "SELECT ClienteId, Clientes.Nombre, Apellido1, Apellido2, Municipios.Nombre As Municipio FROM Clientes INNER JOIN Municipios ON Clientes.munId = Municipios.munId"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)

                        adapter.Fill(dt)

                        GridUsuarios.DataSource = dt

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

    Private Sub BtnDetalles_Click(sender As Object, e As EventArgs) Handles BtnDetalles.Click
        Dim idCliente

        Try
            idCliente = GridUsuarios.Rows.Item(GridUsuarios.SelectedCells.Item(0).RowIndex).Cells.Item("ClienteId").Value

            ' instanciamos la base de datos
            Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

            Try
                cnnDB.Open()
                If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                    Try

                        Dim sql As String = $"SELECT ClienteId, Nombre, Apellido1, Apellido2, Direccion, CP, EsBaja, Password FROM Clientes WHERE ClienteId = {idCliente}"
                        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                        Try

                            Dim dt As DataTable = New DataTable()
                            Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)

                            adapter.Fill(dt)

                            For Each row As DataRow In dt.Rows

                                MessageBox.Show($"Id: {row.Field(Of Integer)("ClienteId")} {Environment.NewLine}Nombre: {row.Field(Of String)("Nombre")} {Environment.NewLine}1er Apellido: {row.Field(Of String)("Apellido1")} {Environment.NewLine}2do Apellido: {row.Field(Of String)("Apellido2")} {Environment.NewLine}Dirección: {row.Field(Of String)("Direccion")} {Environment.NewLine}CodPostal: {row.Field(Of String)("CP")} {Environment.NewLine}Baja: {row.Field(Of Boolean)("EsBaja")} {Environment.NewLine}Contraseña: {row.Field(Of String)("Password")}")

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

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        Dim idCliente

        Try
            idCliente = GridUsuarios.Rows.Item(GridUsuarios.SelectedCells.Item(0).RowIndex).Cells.Item("ClienteId").Value

            ' instanciamos la base de datos
            Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

            Try
                cnnDB.Open()
                If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                    Try

                        Dim sql As String = $"UPDATE Clientes SET EsBaja = 1 WHERE ClienteId = {idCliente}"
                        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                        If cmd.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("Cliente dado de baja con exito")
                        Else
                            MessageBox.Show("Ha ocurrido un error al dar de baja al cliente")
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
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim idCliente = GridUsuarios.Rows.Item(GridUsuarios.SelectedCells.Item(0).RowIndex).Cells.Item("ClienteId").Value

        _formUpdateUsuario = New UpdateUsuario(idCliente)
        _formUpdateUsuario.Show()

    End Sub
End Class