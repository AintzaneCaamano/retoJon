Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web.Security
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class frmLogin
    Inherits System.Web.UI.Page

    Private _OleDbConnection As OleDbConnection
    Public Property OleDbConnection() As OleDbConnection
        Get
            Return _OleDbConnection
        End Get
        Set(ByVal value As OleDbConnection)
            _OleDbConnection = value
        End Set
    End Property

    Private Sub ConexionBD()
        ' Nuestro objeto OleDbConnetion con la cadena de conexión y la ruta de la base

        Dim path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), "App_Data", "EMPRESA.mdb")
        Dim cnnString As String = String.Format("Provider=Microsoft.Jet.Oledb.4.0; Data Source={0}", path)
        OleDbConnection = New OleDbConnection(cnnString)

        ' Utilizamos el try para capturar posibles errores
        Try
            OleDbConnection.Open()
            If OleDbConnection.State = System.Data.ConnectionState.Open Then
                MsgBox("Conexion establecida")
            End If
        Catch ex As Exception
            MsgBox("No se puede conectar")
        Finally
            If Not IsNothing(OleDbConnection) Then
                OleDbConnection.Close()
            End If
        End Try
    End Sub

    Private Sub Login()
        'Dim usuarioEscrito As String = MiLogin.UserName
        'Dim passEscrita As String = MiLogin.Password
        ''Dim sql As String = "SELECT Password FROM Clientes WHERE Nombre = '" & usuarioEscrito & "'"


        'Dim sql As String = "SELECT COUNT(*) FROM Clientes WHERE [Nombre] = @Nombre AND [Password] = @Password"
        'Dim cmd As OleDbCommand = New OleDbCommand(sql, _OleDbConnection)
        'cmd.Parameters.AddWithValue("@Nombre", usuarioEscrito)

        'cmd.Parameters.AddWithValue("@Password", passEscrita)

        'Try
        '    _OleDbConnection.Open()
        '    Dim existe = cmd.ExecuteScalar

        '    If existe = 1 Then
        '        'FormsAuthentication.RedirectFromLoginPage(MiLogin.UserName, MiLogin.RememberMeSet)
        '    Else
        '    End If
        'Catch ex As Exception

        'Finally
        '    If Not IsNothing(OleDbConnection) Then
        '        OleDbConnection.Close()
        '    End If
        'End Try



    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Master.FindControl("MenuDesconectarUsuario").Visible = False
        Me.Master.FindControl("Menu").Visible = False

        Dim path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), "App_Data", "EMPRESA.mdb")
        Dim cnnString As String = String.Format("Provider=Microsoft.Jet.Oledb.4.0; Data Source={0}", path)
        _OleDbConnection = New OleDbConnection(cnnString)
    End Sub

    Protected Sub LoginButton_Click(sender As Object, e As EventArgs)
        'ConexionBD()
        Login()

    End Sub

    Protected Sub ChangePassButton_Click(sender As Object, e As EventArgs)
        Response.Redirect("frmChangePassword.aspx")
    End Sub

    Protected Sub MiLogin_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles MiLogin.Authenticate

        Dim usuarioEscrito As String = MiLogin.UserName
        Dim passEscrita As String = MiLogin.Password
        'Dim sql As String = "SELECT Password FROM Clientes WHERE Nombre = '" & usuarioEscrito & "'"

        Dim sql As String = "SELECT COUNT(*) FROM Clientes WHERE [Nombre] = @Nombre AND [Password] = @Password"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, _OleDbConnection)
        cmd.Parameters.AddWithValue("@Nombre", usuarioEscrito)

        cmd.Parameters.AddWithValue("@Password", passEscrita)

        Try
            _OleDbConnection.Open()
            Dim existe = cmd.ExecuteScalar

            If existe = 1 Then
                FormsAuthentication.RedirectFromLoginPage(MiLogin.UserName, MiLogin.RememberMeSet)
                'e.Authenticated = True
            Else
                e.Authenticated = False
            End If
        Catch ex As Exception

        Finally
            If Not IsNothing(OleDbConnection) Then
                OleDbConnection.Close()
            End If
        End Try

    End Sub
End Class