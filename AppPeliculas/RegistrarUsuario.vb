Public Class RegistrarUsuario
    Dim cnnString As String = My.Settings.EMPRESAConnectionString

    Public Sub New()

        InitializeComponent()

        CargarProvincias()
        CargarMunicipios(ComboProvincia.SelectedValue)

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

                        adapter.Fill(dt)

                        ComboProvincia.Items.Clear()

                        ComboProvincia.DataSource = dt
                        ComboProvincia.ValueMember = "CodPro"
                        ComboProvincia.DisplayMember = "NombPro"

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

                        adapter.Fill(dt)

                        ComboMunicipio.DataSource = dt
                        ComboMunicipio.ValueMember = "MunId"
                        ComboMunicipio.DisplayMember = "Nombre"

                        ComboMunicipio.Refresh()

                        'ComboMunicipio.SelectedValue = 
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
                    Dim Sql As String = "INSERT INTO Clientes (Nombre, Apellido1, Apellido2, Direccion, CP, MunId, Password) VALUES (" _
                        & "[Nombre] = @Nombre, " _
                        & "[Apellido1] = @Apellido1, " _
                        & "[Apellido2] = @Apellido2, " _
                        & "[Direccion] = @Direccion, " _
                        & "[CP] = @CP, " _
                        & "[MunId] = @MunId, " _
                        & "[Password] = @Password)"


                    cmd.Parameters.AddWithValue("@Nombre", TextNombre.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Apellido1", TextApellido1.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Apellido2", TextApellido2.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@Direccion", TextDireccion.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@CP", TextCP.Text).OleDbType = OleDb.OleDbType.WChar
                    cmd.Parameters.AddWithValue("@MunId", ComboMunicipio.SelectedValue).OleDbType = OleDb.OleDbType.Integer
                    cmd.Parameters.AddWithValue("@Password", UpdatePassword.Text).OleDbType = OleDb.OleDbType.WChar

                    If (Not UpdatePassword.Text = UpdatePasswordTest.Text) Then
                        MessageBox.Show("Las contraseñas no coinciden", "Validación")
                        Exit Sub
                    End If

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
