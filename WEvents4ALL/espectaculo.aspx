<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="espectaculo.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

    
    <div class="row">
        <div class="span12">
            <h3>Ajhussi</h3>
            <div class="row">
                <div class="span8">
                    <ul class="nav nav-list">
                        <li class="nav-header">Titulo</li>
                        <li>Ajhussi</li>
                        <li class="nav-header">Descripción</li>
                        <li>La única conexión de ex-agente especial CHA Tae-sik al resto del mundo es una niña, So-mi, que vive cerca. La madre de So-mi, Hyo-jeong contrabandea drogas de una organización de tráfico de drogas y confía con el producto a Tae-sik, sin hacérselo saber.</li>
                        <li class="nav-header">Tipo de espectáculo</li>
                        <li>Cine</li>
                        <li class="nav-header">Fecha de inicio</li>
                        <li>08-05-2012</li>
                        <li class="nav-header">Fecha de fin</li>
                        <li>12-06-2012</li>
                        <li class="nav-header">Sala</li>
                        <li>Sala 1</li>
                        <li class="nav-header">Horarios</li>
                        <li>16:00 | 18:00 | 20:00 | 22:00 | 00:00</li>
                    </ul>
                    <button class="btn btn-primary pull-right" id="btnComprar">Comprar</button>
                </div>
                <div class="span2 offset2 pull-right">
                    <img id="imgEspectaculo" src="img/layout/ahjussi.jpg" alt="Ahjussi" title="" />
                </div>
            </div>

            <div id="especCompra">
                <br />
                <br />
                <br />
                <h3>Compra de entradas para Ajhussi</h3>
                <br />
                <br />
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
                <img src="img/layout/sala.png" />
                <br /><br />
                <h4>4 asientos seleccionados</h4>
                <p>A 8-5 / A 8-6 / A 8-7 / A 8-8</p>
        
                <p class="pull-right">Importe: 36 € <button class="btn btn-primary"><i class="icon-shopping-cart icon-white"></i> Comprar</button></p>
                </div>
        </div>
    </div>

    <div class="row" 
    </div>

    <div >
        
        
    </div>
    <script>
        document.getElementById("btnComprar").onclick = function (e) {
            document.getElementById("especCompra").style.display = "block";
            this.style.display = "none";
            e.preventDefault();            
        };
    
    </script>
</asp:Content>


