Public Class GestionClientes

    Dim cnnString As String = My.Settings.EMPRESAConnectionString

    Private _formDetallesCliente As DetallesCliente
    Public Property FormDetallesCliente() As DetallesCliente
        Get
            Return _formDetallesCliente
        End Get
        Set(ByVal value As DetallesCliente)
            _formDetallesCliente = value
        End Set
    End Property

    Private _formUpdateCliente As UpdateCliente
    Public Property FormUpdateCliente() As UpdateCliente
        Get
            Return _formUpdateCliente
        End Get
        Set(ByVal value As UpdateCliente)
            _formUpdateCliente = value
        End Set
    End Property

    Private _formRegistrarCliente As RegistrarCliente
    Public Property FormRegistrarCliente() As RegistrarCliente
        Get
            Return _formRegistrarCliente
        End Get
        Set(ByVal value As RegistrarCliente)
            _formRegistrarCliente = value
        End Set
    End Property

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosClientes()

    End Sub

    Sub CargarDatosClientes()

        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = "SELECT ClienteId, Clientes.Nombre, Apellido1, Apellido2, Municipios.Nombre As Municipio FROM Clientes INNER JOIN Municipios ON Clientes.munId = Municipios.munId"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        Using adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                            adapter.Fill(dt)
                        End Using

                        GridUsuarios.DataSource = dt
                        GridUsuarios.Refresh()

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

                        Dim sql As String = $"SELECT ClienteId, Clientes.Nombre AS NombreCliente, Apellido1, Apellido2, Direccion, CP, EsBaja, Password, Municipios.Nombre AS NombreMunicipio FROM Clientes INNER JOIN Municipios ON Clientes.MunId = Municipios.MunId WHERE ClienteId = {idCliente}"
                        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                        Try

                            Dim dt As DataTable = New DataTable()
                            Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)

                            adapter.Fill(dt)

                            Dim cliente As Cliente = New Cliente()

                            For Each row As DataRow In dt.Rows
                                Dim municipio As Municipio = New Municipio()

                                cliente.Id = row.Field(Of Integer)("ClienteId")
                                cliente.Nombre = row.Field(Of String)("NombreCliente")
                                cliente.Apellido1 = row.Field(Of String)("Apellido1")
                                cliente.Apellido2 = row.Field(Of String)("Apellido2")
                                cliente.Direccion = row.Field(Of String)("Direccion")
                                cliente.Cp = row.Field(Of String)("CP")
                                cliente.Password = row.Field(Of String)("Password")
                                cliente.EsBaja = row.Field(Of Boolean)("EsBaja")

                                municipio.Nombre = row.Field(Of String)("NombreMunicipio")

                                cliente.Municipio = municipio
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
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Selecciona un registro para poder ver sus detalles", "Aviso")
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
                            MessageBox.Show("Ha ocurrido un error al dar de baja al cliente", "Aviso")
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
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try

            _formUpdateCliente = New UpdateCliente(GridUsuarios.Rows.Item(GridUsuarios.SelectedCells.Item(0).RowIndex))
            Me.Hide()
            _formUpdateCliente.ShowDialog()
            Me.Show()

            GridUsuarios.Refresh()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Selecciona un registro para poder modificarlo", "Aviso")
        End Try
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            Dim idCliente = GridUsuarios.Rows.Item(GridUsuarios.SelectedCells.Item(0).RowIndex).Cells.Item("ClienteId").Value

            _formRegistrarCliente = New RegistrarCliente()
            Me.Hide()
            _formRegistrarCliente.ShowDialog()
            Me.Show()

            GridUsuarios.Refresh()
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Selecciona un registro para poder modificarlo", "Aviso")
        End Try
    End Sub
End Class