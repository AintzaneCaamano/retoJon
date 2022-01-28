Public Class Principal

    Private _formClientes As GestionClientes
    Public Property FormUsuarios() As GestionClientes
        Get
            Return _formClientes
        End Get
        Set(ByVal value As GestionClientes)
            _formClientes = value
        End Set
    End Property

    Private _formPeliculas As GestionPeliculas
    Public Property FormPeliculas() As GestionPeliculas
        Get
            Return _formPeliculas
        End Get
        Set(ByVal value As GestionPeliculas)
            _formPeliculas = value
        End Set
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnFormUsuarios_Click(sender As Object, e As EventArgs) Handles BtnFormUsuarios.Click
        _formClientes = New GestionClientes()
        Me.Hide()
        _formClientes.ShowDialog()
        Me.Show()
    End Sub
    Private Sub BtnFormPeliculas_Click(sender As Object, e As EventArgs) Handles BtnFormPeliculas.Click
        _formPeliculas = New GestionPeliculas()
        Me.Hide()
        _formPeliculas.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ta bueno
        If e.CloseReason = 3 Then
            e.Cancel = True
            MessageBox.Show("(╯°□°)╯ Cierra con el botón del menú que para algo está")
        End If
    End Sub
End Class
