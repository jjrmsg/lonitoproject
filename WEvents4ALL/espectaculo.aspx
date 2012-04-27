<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="espectaculo.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

    <h3>Ajhussi</h3>
    <div id="especInfo">
        <ul id="datosEspectaculo">
            <li>Titulo:<br /><span>Ajhussi</li>
            <li>Descripción:<br /><span> La única conexión de ex-agente especial CHA Tae-sik al resto del mundo es una niña, So-mi, que vive cerca. La madre de So-mi, Hyo-jeong contrabandea drogas de una organización de tráfico de drogas y confía con el producto a Tae-sik, sin hacérselo saber.</li>
            <li>Tipo de espectáculo:<br /><span>Cine</span></li>
            <li>Fecha de inicio:<br /><span> 08-05-2012</li>
            <li>Fecha de inicio:<br /><span> 12-06-2012</li>
            <li>Sala:<br /><span>Sala 1</li>
            <li>Horarios:<br /><span>16:00 | 18:00 | 20:00 | 22:00 | 00:00</li>
        </ul>
        <img id="imgEspectaculo" src="img/layout/ahjussi.jpg" alt="Ahjussi" title="" />
        <button id="btnComprar">Comprar entradas</button>
    </div>
    <div id="especCompra">
        <h3>Compra de entradas para Ajhussi</h3>
        <asp:Label ID="Label1" runat="server" Text="Horario:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>16:00</asp:ListItem>
            <asp:ListItem>18:00</asp:ListItem>
            <asp:ListItem>20:00</asp:ListItem>
            <asp:ListItem>22:00</asp:ListItem>
            <asp:ListItem>00:00</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <img src="img/layout/sala.png" />
        <br /><br />
        <h4>4 asientos seleccionados</h4>
        <p style="margin: 10px;">A 8-5 / A 8-6 / A 8-7 / A 8-8</p>
        
        <p id="confirmCompra">Importe: 36 € <button id="Button1">Confirmar compra</button></p>
        
    </div>
    <script>
        document.getElementById("btnComprar").onclick = function (e) {
            document.getElementById("especCompra").style.display = "block";
            this.style.display = "none";
            e.preventDefault();            
        };
    
    </script>
</asp:Content>


