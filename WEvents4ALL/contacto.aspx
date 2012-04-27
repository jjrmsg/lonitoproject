<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <h1>Formulario de Contacto</h1>
    <label>Mail de contacto</label><input id="Text1" type="text" /><br />
    <label>Asunto</label><asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Error en web</asp:ListItem>
                <asp:ListItem>Ventas</asp:ListItem>
                <asp:ListItem>Otros</asp:ListItem>
    </asp:DropDownList><br />
    <label>Motivo</label><br />
    <textarea id="TextArea1" rows="30" cols="80"></textarea><br />
    <asp:Button ID="bot_enviar" runat="server" Text="Enviar" CssClass="bot_enviar" />
</asp:Content>
