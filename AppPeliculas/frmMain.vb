Public Class frmMain

    Private f1v As GestionUsuarios
    Public Property f1() As GestionUsuarios
        Get
            Return f1v
        End Get
        Set(ByVal value As GestionUsuarios)
            f1v = value
        End Set
    End Property

    Private f2v As GestionPeliculas
        Public Property f2() As GestionPeliculas
            Get
                Return f2v
            End Get
            Set(ByVal value As GestionPeliculas)
                f2v = value
            End Set
        End Property

        Public Sub New()
            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()
        f1 = New GestionUsuarios
        f2 = New GestionPeliculas
        End Sub

    Private Sub abrirForm(f As Form)
        'Dim f As New Form()
        f.WindowState = FormWindowState.Maximized
        f.Show()
        f.Activate()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub GestionPeliculasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionPeliculasToolStripMenuItem.Click

    End Sub

    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        abrirForm(f2)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoToolStripMenuItem.Click
        abrirForm(f1)
    End Sub

    Private Sub CatalogoProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoProveedoresToolStripMenuItem.Click
        abrirForm(f1)
    End Sub
End Class