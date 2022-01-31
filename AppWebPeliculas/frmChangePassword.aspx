<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pagina.Master" CodeBehind="frmChangePassword.aspx.vb" Inherits="AppWebPeliculas.frmChangePassword" %>
<asp:Content ID="Content3" ContentPlaceHolderID="MainPage" runat="server" >
    <br>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Introduce su contraseña actual&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPassActual" runat="server"></asp:TextBox>
&nbsp;&nbsp; 
    </p>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Introduce su nueva contraseña&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxPassNueva" runat="server"></asp:TextBox>
        <br>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
         controlToValidate = "TextBoxPassNueva"
         ErrorMessage = "El campo uno es obligatorio"
         EnableClientScript="false"
         ForeColor = "Red">
    </asp:RequiredFieldValidator>
        <br/>
    <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1"
        controlToValidate="TextBoxPassNueva"
         ValidationExpression="^(?=.\d)(?=.[\u0021-\u002b\u003c-\u0040])(?=.[A-Z])(?=.[a-z])\S{8,16}$" 
         ErrorMessage="La contraseña debe tener minimo 8 caracteres y maximo 16 y tiene que contener 1 Mayuscula, 1 minusculas, 1 digitos y 1 caracter especial"
                forecolor="Red">
    </asp:RegularExpressionValidator>
    </p>
    <p>Vuelva a introducir su nueva contraseña&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxPassNuevaRepetida" runat="server"></asp:TextBox>
    <br>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCampoObligatorio" runat="server"
         controlToValidate = "TextBoxPassNuevaRepetida"
         ErrorMessage = "El campo uno es obligatorio"
         EnableClientScript="false"
         ForeColor = "Red">
    </asp:RequiredFieldValidator>
        <br/>
    <asp:RegularExpressionValidator runat="server" ID="rexContra"
        controlToValidate="TextBoxPassNueva"
         ValidationExpression="^(?=.\d)(?=.[\u0021-\u002b\u003c-\u0040])(?=.[A-Z])(?=.[a-z])\S{8,16}$" 
         ErrorMessage="La contraseña debe tener minimo 8 caracteres y maximo 16 y tiene que contener 1 Mayuscula, 1 minusculas, 1 digitos y 1 caracter especial"
                forecolor="Red">
    </asp:RegularExpressionValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server"
        ErrorMessage="CompareValidator" ControlToValidate="TextBoxPassNueva" ValueToCompare="TextBoxPassNuevaRepetida"></asp:CompareValidator>
    </p>    
</asp:Content>

<asp:Content ID="Content4" runat="server" contentplaceholderid="head">
    </asp:Content>


