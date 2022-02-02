Public Class Pagina
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub MiMenu_MenuItemClick(sender As Object, e As MenuEventArgs) Handles MiMenu.MenuItemClick
        Response.Redirect("frmPeliculas.aspx")
    End Sub
End Class