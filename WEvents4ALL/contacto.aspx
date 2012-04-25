<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <h1>Formulario de Contacto</h1>
    <p>Mail de contacto</p><input id="Text1" type="text" /><br />
    <p>Asunto</p><asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Error en web</asp:ListItem>
                <asp:ListItem>Ventas</asp:ListItem>
                <asp:ListItem>Otros</asp:ListItem>
    </asp:DropDownList><br />
    <textarea id="TextArea1" rows="30" cols="80"></textarea><br />
    <asp:Button ID="Button1" runat="server" Text="Enviar" />
</asp:Content>
