<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pagina.Master" CodeBehind="frmPeliculas.aspx.vb" Inherits="AppWebPeliculas.frmLogin" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPage" runat="server" >
    <asp:SqlDataSource ID="SqlDataSourcePeliculas" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [Titulo], [Duracion], [Director] FROM [Peliculas]">
  </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSourcePeliculas" 
                AutoGenerateColumns="False" CssClass="auto-style1" >
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
                    <asp:BoundField DataField="Duracion" HeaderText="Duracion" SortExpression="Duracion" />
                    <asp:BoundField DataField="Director" HeaderText="Director" SortExpression="Director" />
                    <asp:ButtonField CommandName="btnAlquilar" Text="Añadir al carrito" />
                </Columns>
                <SelectedRowStyle BackColor="#66FF66" />
            </asp:GridView>


    </asp:Content>

<asp:Content ID="Content4" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        margin-right: 50px;
    }
</style>
    </asp:Content>


