Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed1_SelectedIndexChanging(sender As Object, e As GridViewSelectEventArgs)

    End Sub

    Protected Sub Unnamed1_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        Dim nombreBoton As String = e.CommandName
        Dim index As Integer = e.CommandArgument

        If nombreBoton = "btnAlquilar" Then
            'GridPeliculas.Rows(index).ite.da "PeliculaId")
        End If
    End Sub
End Class