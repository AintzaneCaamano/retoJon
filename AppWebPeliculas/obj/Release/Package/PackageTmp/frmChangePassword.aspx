<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pagina.Master" CodeBehind="frmChangePassword.aspx.vb" Inherits="AppWebPeliculas.frmChangePassword" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPage" runat="server" >
    <br>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Introduce su contraseña actual&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPassActual" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp; 
    </p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
         runat="server"
         controlToValidate = "TextBoxPassActual"
         ErrorMessage = "El campo es obligatorio"
         EnableClientScript="false"
         ForeColor = "Red"></asp:RequiredFieldValidator>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Introduce su nueva contraseña&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPassNueva" runat="server" TextMode="Password"></asp:TextBox>
        <br>
        <br>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNuevaPass" runat="server"
         controlToValidate = "TextBoxPassNueva"
         ErrorMessage = "El campo es obligatorio"
         EnableClientScript="false"
         ForeColor = "Red"></asp:RequiredFieldValidator>
        <br/>
    </p>
    <p>Vuelva a introducir su nueva contraseña&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox 
        ID="TextBoxPassNuevaRepetida" runat="server" TextMode="Password"></asp:TextBox>
   <br>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCampoObligatorio" 
         runat="server"
         controlToValidate = "TextBoxPassNuevaRepetida"
         ErrorMessage = "El campo es obligatorio"
         EnableClientScript="false"
         ForeColor = "Red"></asp:RequiredFieldValidator>
    <br>
        <asp:CompareValidator ErrorMessage="Las contraseñas deben coincidir" ControlToValidate="TextBoxPassNueva" ControlToCompare="TextBoxPassNuevaRepetida" ForeColor="Red" runat="server" />
        <br />
    <asp:RegularExpressionValidator runat="server" ID="rexPassNueva"
         controlToValidate="TextBoxPassNueva"
         ValidationExpression="^(?=.*[A-Z]){1,}(?=.*[a-z]){1,}(?=.*\d){1,}(?=.*[^A-Za-z0-9]){1,}.{8,16}$" 
         ErrorMessage="La contraseña debe tener minimo 8 caracteres y maximo 16 y tiene que contener 1 Mayuscula, 1 minusculas, 1 digitos y 1 caracter especial"
         forecolor="Red">
    </asp:RegularExpressionValidator>
        <br/>
        <br>
    </p>
    <p>
        <asp:Button ID="ButtonCancelar" runat="server" 
            Text="CANCELAR" Width="127px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonAceptar" runat="server" 
            Text="ACEPTAR" Width="127px" />
    </p>    
</asp:Content>



