<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cartelera.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <div id="cartel" class="izquierda">
        <img id="portada" alt="los vengadores" src="/img/carteles/los vengadores.jpg"/>
    </div>
    
    <div id="cb1" class="derecha">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Cine</asp:ListItem>
            <asp:ListItem>Espectaculo</asp:ListItem>
            <asp:ListItem>Teatro</asp:ListItem>
        </asp:DropDownList>
    </div>

    <br id="Br1"/>
    <br id="Br2"/>

    <div id="cb2" class="derecha">
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Los Vengadores</asp:ListItem>
        </asp:DropDownList>
    </div>
    </asp:Content>
