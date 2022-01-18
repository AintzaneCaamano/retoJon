Public Class GestionUsuarios
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As String = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), "EMPRESA.mdb")
        Dim cnnString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={file}"

        ' instanciamos la base de datos
        Dim cnnDB As OleDb.OleDbConnection = New OleDb.OleDbConnection(cnnString)

        Try
            cnnDB.Open()
            If (cnnDB.State() = System.Data.ConnectionState.Open) Then

                Try

                    Dim sql As String = "SELECT Clientes.Nombre, Apellido1, Apellido2, Municipios.Nombre As Municipio FROM Clientes LEFT JOIN Municipios ON Clientes.munId = Municipios.munId"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDetalles.Click

    End Sub
End Class