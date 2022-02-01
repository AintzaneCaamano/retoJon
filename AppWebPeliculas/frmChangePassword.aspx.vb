Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web.Security
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class frmChangePassword
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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        ' conexion con la Base de Datos
        Dim path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), "App_Data", "EMPRESA.mdb")
        Dim cnnString As String = String.Format("Provider=Microsoft.Jet.Oledb.4.0; Data Source={0}", path)
        _OleDbConnection = New OleDbConnection(cnnString)

        OleDbConnection.Open()

        Dim usuario As String = HttpContext.Current.User.Identity.Name

        ' PASO 1: comprobar contraseña actual
        Dim sql As String = "SELECT COUNT(*) FROM Clientes WHERE [Nombre] = @Nombre AND [Password] = @Password"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, _OleDbConnection)
        cmd.Parameters.AddWithValue("@Nombre", usuario)
        cmd.Parameters.AddWithValue("@Password", TextBoxPassActual.Text)
        ' num sería el número de registros afectados
        Dim num As Integer = cmd.ExecuteScalar()

        ' PASO 2:Actualzir en BD
        sql = "UPDATE Clientes SET [Password] = @Password WHERE [Nombre] = @Nombre"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Nombre", usuario)
        cmd.Parameters.AddWithValue("@Password", TextBoxPassNueva.Text)
        num = cmd.ExecuteNonQuery()

        OleDbConnection.Close()

    End Sub

    Protected Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click

        Response.Redirect("frmLogin.aspx")

    End Sub

    Protected Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        If Me.IsValid Then

            Response.Redirect("frmPrincipal.aspx")

        End If


    End Sub
End Class