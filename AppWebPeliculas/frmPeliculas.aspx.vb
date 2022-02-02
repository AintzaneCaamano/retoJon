Imports System.Data.OleDb

Public Class frmPeliculas
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Master.FindControl("Menu").Visible = False

    End Sub

    Protected Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.
        btnCarrito
    End Sub
End Class