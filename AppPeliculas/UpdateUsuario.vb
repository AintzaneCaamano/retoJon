Public Class UpdateUsuario
    Dim cnnString As String = My.Settings.EMPRESAConnectionString

    Private _idCliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private _idProvincia As String
    Public Property IdProvincia() As String
        Get
            Return _idProvincia
        End Get
        Set(ByVal value As String)
            _idProvincia = value
        End Set
    End Property

    Private _idMunicipio As Integer
    Public Property IdMunicipio() As Integer
        Get
            Return _idMunicipio
        End Get
        Set(ByVal value As Integer)
            _idMunicipio = value
        End Set
    End Property

    Public Sub New(idCliente As Integer)

        InitializeComponent()

        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Me._idCliente = idCliente

        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = $"SELECT Clientes.Nombre, Apellido1, Apellido2, Direccion, CP, Municipios.MunId, ProvCod FROM Clientes INNER JOIN Municipios ON Clientes.MunId = Municipios.MunId WHERE ClienteId = {idCliente}"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)

                        adapter.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            TextNombre.Text = dt.Rows.Item(0).Item(0)
                            TextApellido1.Text = dt.Rows.Item(0).Item(1)
                            TextApellido2.Text = dt.Rows.Item(0).Item(2)
                            TextDireccion.Text = dt.Rows.Item(0).Item(3)
                            TextCP.Text = dt.Rows.Item(0).Item(4)

                            _idMunicipio = CInt(dt.Rows.Item(0).Item(5))
                            _idProvincia = dt.Rows.Item(0).Item(6)

                            CargarProvincias()
                            CargarMunicipios(ComboProvincia.SelectedValue)
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

    Private Sub CargarProvincias()
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = ConnectionState.Open) Then

                Try

                    Dim sql As String = "SELECT CodPro, NombPro FROM Provincias"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        Dim selectedIndex As Integer = 0

                        adapter.Fill(dt)

                        For i = 0 To dt.Rows.Count - 1
                            If dt.Rows.Item(i).Item(0) = _idProvincia Then
                                selectedIndex = i
                            End If
                        Next

                        ComboProvincia.Items.Clear()

                        ComboProvincia.DataSource = dt
                        ComboProvincia.ValueMember = "CodPro"
                        ComboProvincia.DisplayMember = "NombPro"
                        ComboProvincia.SelectedIndex = selectedIndex

                        ComboProvincia.Refresh()

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

    Private Sub CargarMunicipios(codProvincia As String)
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = ConnectionState.Open) Then

                Try

                    Dim Sql As String = $"SELECT MunId, Nombre FROM Municipios WHERE ProvCod = '{codProvincia}'"
                    Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(Sql, cnnDB)

                    Try

                        Dim dt As DataTable = New DataTable()
                        Dim adapter As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        Dim selectedIndex As Integer = 0

                        adapter.Fill(dt)

                        For i = 0 To dt.Rows.Count - 1
                            If dt.Rows.Item(i).Item(0) = _idMunicipio Then
                                selectedIndex = i
                            End If
                        Next

                        ComboMunicipio.DataSource = dt
                        ComboMunicipio.ValueMember = "MunId"
                        ComboMunicipio.DisplayMember = "Nombre"
                        ComboMunicipio.SelectedIndex = selectedIndex

                        ComboMunicipio.Refresh()

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

    Private Sub CheckBox1_CheckStateChanged(sender As Object, e As EventArgs) Handles UpdatePasswordCheck.CheckStateChanged
        UpdatePasswordGroup.Visible = UpdatePasswordCheck.Checked
    End Sub

    Private Sub ComboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboProvincia.SelectedIndexChanged
        Try
            CargarMunicipios(ComboProvincia.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnUpdateUsuario_Click(sender As Object, e As EventArgs) Handles BtnUpdateUsuario.Click
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = ConnectionState.Open) Then

                Try

                    Dim cmd As OleDb.OleDbCommand = cnnDB.CreateCommand()
                    Dim Sql As String = "UPDATE Clientes SET " _
                        & "[Nombre] = @Nombre, " _
                        & "[Apellido1] = @Apellido1, " _
                        & "[Apellido2] = @Apellido2, " _
                        & "[Direccion] = @Direccion, " _
                        & "[CP] = @CP, " _
                        & "[MunId] = @MunId, "


                    cmd.Parameters.AddWithValue("@Nombre", TextNombre.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Apellido1", TextApellido1.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Apellido2", TextApellido2.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Direccion", TextDireccion.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@CP", TextCP.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@MunId", ComboMunicipio.SelectedValue).OleDbType = OleDb.OleDbType.Integer

                    If (UpdatePasswordCheck.Checked) Then
                        If (UpdatePassword.Text = UpdatePasswordTest.Text) Then
                            Sql += "[Password] = @Password, "
                            cmd.Parameters.AddWithValue("@Password", UpdatePassword.Text).OleDbType = OleDb.OleDbType.WChar
                        Else
                            MessageBox.Show("Las contraseñas no coinciden", "Validación")
                            Exit Sub
                        End If
                    End If

                    Sql = Sql.Substring(0, Sql.Length - 2)

                    Sql += $" WHERE [ClienteId] = @ClienteId"

                    cmd.Parameters.AddWithValue("@ClienteId", Me.IdCliente).OleDbType = OleDb.OleDbType.Integer
                    cmd.CommandText = Sql


                    Try

                        If cmd.ExecuteNonQuery() > 0 Then
                            MessageBox.Show("Datos actualizados correctamente", "Resultado")
                            GestionUsuarios.CargarDatosClientes()
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
End Class
