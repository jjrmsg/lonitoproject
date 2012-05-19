<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cartelera.aspx.cs" Inherits="WEvents4ALL.cartelera"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
   
   <h3>Cartelera</h3>
   <%
       
        string tipo = Request.QueryString["tipo"];

       %>
       <div class="btn-group" data-toggle="buttons-radio">
       

         <%if (tipo == "Teatro")
        {%>
                    <a class="btn" href="/cartelera.aspx?tipo=Cine"><i class="icon-film"></i> Cine</a>
                    <a class="btn active" href="/cartelera.aspx?tipo=Teatro"><i class="icon-star"></i> Teatro</a>
                    <a class="btn" href="/cartelera.aspx?tipo=Concierto"><i class="icon-music"></i> Concierto</a>
       <% }
        else if (tipo == "Concierto")
        {%>
                    <a class="btn" href="/cartelera.aspx?tipo=Cine"><i class="icon-film"></i> Cine</a>
                    <a class="btn" href="/cartelera.aspx?tipo=Teatro"><i class="icon-star"></i> Teatro</a>
                    <a class="btn active" href="/cartelera.aspx?tipo=Concierto"><i class="icon-music"></i> Concierto</a>
        <%}
        else
        {%>
                    <a class="btn active" href="/cartelera.aspx?tipo=Cine"><i class="icon-film"></i> Cine</a>
                    <a class="btn" href="/cartelera.aspx?tipo=Teatro"><i class="icon-star"></i> Teatro</a>
                    <a class="btn" href="/cartelera.aspx?tipo=Concierto"><i class="icon-music"></i> Concierto</a>
        <%}%>
        </div>

        <%try{
            foreach(System.Data.DataRow r in resultado.Tables[0].Rows) {
                if (System.DateTime.Now < Convert.ToDateTime(r["FechaFin"]))
                {%>
                    <div class="well" id="caixaContenidora">
                        <div class="row">
                                <div class="titol_n">
                                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><h3><%= r["Titulo"].ToString() %></h3></a>
                                </div>
                                <div class="cartell_n">
                                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><img class="cartelera_img" alt=<%= r["Titulo"].ToString() %> src="utilidades/img_esp.aspx?id=<%=r["IDEspectaculo"].ToString()%>" /></a>
                                    <a class="btn btn-success" href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><i class="icon-tag icon-white"></i> Detalles</a>
                                </div>
                                    <%
                                        char[] delimiterChars = {','};
                                        string text = r["Horarios"].ToString();
                                        string[] words = text.Split(delimiterChars);
                                        foreach (string s in words)
                                        {%>
                                            <div class="horario"> <span class="badge badge-info"> <%=s%></span></div>
                                        <%}
                                    %>

                        </div>
                    </div>
                <%} %>
            <%} %>
        <%}
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        %>
   
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
