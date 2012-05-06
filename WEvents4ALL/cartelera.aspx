<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cartelera.aspx.cs" Inherits="WEvents4ALL.cartelera"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
   
   <h3>Cartelera</h3>
   <%
        string tipo = Request.QueryString["tipo"];
        Response.Write("<ul id=\"tipoEvento\">");
        if (tipo == "Teatro")
        {
            Response.Write("<li><a href=\"?tipo=Cine\">Cine</a></li>");
            Response.Write("<li><a href=\"?tipo=Concierto\">Concierto</a></li>");
            Response.Write("<li><a  class=\"tipoEventoSel\" href=\"?tipo=Teatro\">Teatro</a></li>");
        }
        else if (tipo == "Concierto")
        {
            Response.Write("<li><a href=\"?tipo=Cine\">Cine</a></li>");
            Response.Write("<li><a class=\"tipoEventoSel\" href=\"?tipo=Concierto\">Concierto</a></li>");
            Response.Write("<li><a href=\"?tipo=Teatro\">Teatro</a></li>");
        }
        else
        {
            Response.Write("<li><a class=\"tipoEventoSel\" href=\"?tipo=Cine\">Cine</a></li>");
            Response.Write("<li><a href=\"?tipo=Concierto\">Concierto</a></li>");
            Response.Write("<li><a href=\"?tipo=Teatro\">Teatro</a></li>");
        }
        Response.Write("</ul>");
     %>


        <%foreach(System.Data.DataRow r in resultado.Tables[0].Rows) { %>
            <div class="caixaContenedora">
                <div class="row">
                    <div class="span9">
                        <div class="titol_n">
                            <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><h3><%= r["Titulo"].ToString() %></h3></a>
                        </div>
                        <div class="cartell_n">
                            <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><img class="rank_img" alt=<%= r["Titulo"].ToString() %> src="utilidades/img_esp.aspx?id=<%=r["IDEspectaculo"].ToString()%>" /></a>
                            <a class="btn btn-success" href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><i class="icon-tag icon-white"></i> Comprar</a>
                        </div>
                        <div class="descripcio_n">
                            <%= r["Descripcion"].ToString() %>
                        </div>
                    </div>
                </div>
            </div>
        <%} %>
   
   <!--<h3>Cartelera</h3>

    <ul id="tipoEvento">
        <li><a class="tipoEventoSel" href="#">Cine</a></li>
        <li><a href="#">Concierto</a></li>
        <li><a href="#">Teatro</a></li>
    </ul>
    
    
    
    <div id="b1" class="bloque">
        <div id="c1" class="cartel">
            <img id="f1" class="tamCartel" alt="los vengadores" src="/img/carteles/los vengadores.jpg"/>
        </div>
        <div id="t1" class="titulo">
            Los Vengadores
        </div>
        <div id="fa1" class="fecha">
            16:00
        </div>
        <div id="fa2" class="fecha">
            19:00
        </div>
        <div id="fa3" class="fecha">
            22:00
        </div>
    </div>

    <div id="b2" class="bloque">
        <div id="c2" class="cartel">
            <img id="f2" class="tamCartel" alt="hook" src="/img/carteles/hook.png" />
        </div>
        <div id="t2" class="titulo">
            Hook
        </div>
        <div id="fb1" class="fecha">
            16:00
        </div>
        <div id="fb2" class="fecha">
            19:00
        </div>
        <div id="fb3" class="fecha">
            22:00
        </div>
    </div>
    -->
    </asp:Content>
