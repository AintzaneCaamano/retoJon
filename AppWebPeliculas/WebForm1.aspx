<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Pagina.Master" CodeBehind="WebForm1.aspx.vb" Inherits="AppWebPeliculas.WebForm1" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainPage" runat="server" >
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT Peliculas.PeliculaId, Peliculas.Titulo, Peliculas.Duracion, Generos.Nombre, Peliculas.Anyo, Peliculas.Pais
FROM Generos INNER JOIN Peliculas ON Generos.GeneroId = Peliculas.CodGenero;
"></asp:SqlDataSource>
    <div><asp:GridView runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" ID="GridPeliculas" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowCommand="Unnamed1_RowCommand">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="PeliculaId" HeaderText="PeliculaId" SortExpression="PeliculaId" />
            <asp:BoundField DataField="Titulo" HeaderText="Titulo" SortExpression="Titulo" />
            <asp:BoundField DataField="Duracion" HeaderText="Duracion" SortExpression="Duracion" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Anyo" HeaderText="Anyo" SortExpression="Anyo" />
            <asp:BoundField DataField="Pais" HeaderText="Pais" SortExpression="Pais" />
            <asp:ButtonField DataTextField="btnAlquilar" Text="Botón" />
        </Columns>
        </asp:GridView>
        </div>
</asp:Content>
