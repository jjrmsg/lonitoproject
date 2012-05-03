<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEvents4ALL.index"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">



<!--<div id="carrusel">
    <img id="banner" src="/img/layout/banner.png" alt="" title="" />
</div>
<br />
<hr />

<div id="noticias">
    <div class="new">
        <div class="cabecera">
            <b>El caballero oscuro</b>
        </div>
        <div class="cuerpo">
            <div class="imgNoticia">
                <img id="cart" src="/img/layout/dark.jpg" alt="" title="" />
            </div>
            <div class="descripcion">
                Batman (Christian Bale) regresa para continuar su guerra contra el crimen. Con la ayuda del teniente Jim Gordon y del Fiscal del Distrito Harvey Dent, Batman se propone destruir el crimen organizado en la ciudad de Gotham. El triunvirato demuestra su eficacia, pero, de repente, aparece Joker, un nuevo criminal que desencadena el caos y tiene aterrados a los ciudadanos. 
            </div>
        </div>
    </div>
</div>-->

<div class="row">
    <div class="span10 offset1">
        <%foreach(System.Data.DataRow r in esp.Tables[0].Rows) { %>
            <div class="well">
                <div class="titulo_n">
                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><h3><%= r["Titulo"].ToString() %></h3></a>
                </div>
                <div class="poster_n">
                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><img class="rank_img" alt=<%= r["Titulo"].ToString() %> src="utilidades/img_esp.aspx?id=<%=r["IDEspectaculo"].ToString()%>" /></a>
                    <a class="btn btn-success" href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><i class="icon-tag icon-white"></i> Comprar</a>
                </div>
                <div class="descripcion_n">
                    <%= r["Descripcion"].ToString() %>
                </div>
            </div>
        <%} %>
    </div>
</div>




</asp:Content>
