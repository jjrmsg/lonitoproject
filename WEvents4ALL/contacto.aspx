<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <h1>Formulario de Contacto</h1>
    <label class="contact_label">Mail de contacto</label><input id="Text1" type="text" class="contact_imput" /><br />
    <label class="contact_label">Asunto</label><asp:DropDownList ID="DropDownList1" runat="server" CssClass="contact_imput_down">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Error en web</asp:ListItem>
                <asp:ListItem>Ventas</asp:ListItem>
                <asp:ListItem>Otros</asp:ListItem>
    </asp:DropDownList><br /><br />
    <label>Motivo</label><br />
    <textarea id="TextArea1" rows="30" cols="80" class="contact_textarea"></textarea><br />
    <asp:Button ID="bot_enviar" runat="server" Text="Enviar" CssClass="contact_bot_enviar" />
</asp:Content>
