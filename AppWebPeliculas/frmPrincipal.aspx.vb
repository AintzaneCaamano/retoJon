Public Class frmPrincipal
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Comprobamos si el usuario está conectado
        If Not HttpContext.Current.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub

    Protected Sub Menu1_MenuItemClick(sender As Object, e As MenuEventArgs) Handles Menu1.MenuItemClick

        Response.Redirect("frmChangePassword.aspx")

    End Sub
End Class