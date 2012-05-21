<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="espectaculo.aspx.cs" Inherits="WEvents4ALL.espectaculo"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

    <div class="row">
	    <div class="span10">
        <%  
        string salaEspID = "";
        string espID = "";
        try {
            System.Data.DataRow espectaculo = datosEsp.Tables[0].Rows[0];
            %>
            <h3><%=espectaculo["Titulo"].ToString()%></h3>
            <br />
            <div class="row">
                <div class="span8">
                    <ul class="nav nav-list">
                        <li class="nav-header">Titulo</li>
                        <li><%=espectaculo["Titulo"].ToString()%></li>
                        <% espID = espectaculo["IdEspectaculo"].ToString(); %>
                        <li class="nav-header">Descripción</li>
                        <li><%=espectaculo["Descripcion"].ToString()%></li>
                        <li class="nav-header">Tipo de espectáculo</li>
                        <li><%=espectaculo["Tipo"].ToString()%></li>
                        <li class="nav-header">Fecha de inicio</li>
                        <li><%=Convert.ToDateTime(espectaculo["FechaIni"].ToString()).ToShortDateString()%></li>
                        <li class="nav-header">Fecha de fin</li>
                        <li><%= Convert.ToDateTime(espectaculo["FechaFin"].ToString()).ToShortDateString() %></li>
                        <li class="nav-header">Sala</li>
                        <li>Sala <%=espectaculo["IdSala"].ToString()%></li>
                        <% salaEspID = espectaculo["IdSala"].ToString(); %>
                        <li class="nav-header">Horarios</li>
                        <%
                            string[] listadoHorarios = espectaculo["Horarios"].ToString().Split(',');
                            string horariosTexto = "";
                            foreach (String h in listadoHorarios)
                            {
                                if(horariosTexto!="")
                                    horariosTexto += " | ";
                                horariosTexto += h;                                    
                            }
                        %>
                        <li><%= horariosTexto%></li>
                        <li class="nav-header">Precio</li>
                        <li><%=Convert.ToInt32(espectaculo["precio"])%> €</li>
                    </ul>                
                </div>
                <div class="span2 pull-right">
                    <div class="row">
                        <div class="span2">
                            <img class="pull-right"  style="clear: both" id="imgEspectaculo" src="utilidades/img_esp.aspx?id=<%=espectaculo["IDEspectaculo"].ToString()%>" alt="<%=espectaculo["Titulo"].ToString()%>" title="Cartel de <%=espectaculo["Titulo"].ToString()%>" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="span2">
                        <% 
                        if (espectaculo["NotMedia"] != DBNull.Value && espectaculo["NotMedia"] != "")
                        { 
                        %>
                            <h2 class="pull-right">Nota: <%= espectaculo["NotMedia"] %></h2>       
                        <%}
                        else
                        {%>
                            <h2 class="pull-right">Nota: -</h2>  
                        <%} %>
                        </div>
                    </div>

                    <%
                    if (Session["IdUsuario"] != null && Session["IdUsuario"] != "")
                    { %>   
                    <div class="row">
                        <span class="pull-right">Tu puntuación</span>
                        <div class="span2">
                            <ul class='star-rating pull-right' style="clear: both">
                        <%

                        string puntuacionUserPx = (puntUser * 25).ToString();
                        %>                        
                        <li class='current-rating' id="ratingControler" style='width: <%= puntuacionUserPx %>px;' title='Currently 3.5/5 Stars.'></li>
	                            <li class='starRate'><a href='#' title='1 estrella de 5' class='one-star'>1</a></li>
	                            <li class='starRate'><a href='#' title='2 estrellas de 5' class='two-stars'>2</a></li>
	                            <li class='starRate'><a href='#' title='3 estrellas de 5' class='three-stars'>3</a></li>
	                            <li class='starRate'><a href='#' title='4 estrellas de 5' class='four-stars'>4</a></li>
	                            <li class='starRate'><a href='#' title='5 estrellas de 5' class='five-stars'>5</a></li>
                            </ul>
                        <%                        
                     }
                     %>


                    <div class="row">
                        <div class="span2">
                        <% if (espectaculo["Media"] != DBNull.Value && espectaculo["Media"] != "")
                       {%>
                            <a id="mediaButton" class="btn btn-mini btn-inverse pull-right"  style="clear: both" data-toggle="modal" href="#myModal" ><i class="icon-facetime-video icon-white"></i> Ver video relacionado</a>	
                            <div class="modal hide fade in" id="myModal">
                                <div class="modal-body" >                
                                    <div id="wrapVideo">
                                        <div id="videoDiv">Cargando...</div>
                                    </div>
                                </div>
                                <div class="modal-footer">
                                    <a href="#" class="btn btn-primary" data-dismiss="modal">Cerrar</a>
                                </div>
                            </div>
                
                            <script src="http://www.google.com/jsapi" type="text/javascript"></script>
                            <script type="text/javascript">
                                google.load("swfobject", "2.1");
                            </script>    
                            <script type="text/javascript">
                                function _run() {
                                    /*
                                    * Simple player embed
                                    */

                                    // The video to load.
                                    var videoID = getId('<%=espectaculo["Media"].ToString()%>');
                                    // Lets Flash from another domain call JavaScript
                                    var params = { allowScriptAccess: "always", allowfullscreen: "true" };
                                    // The element id of the Flash embed
                                    var atts = { id: "ytPlayer" };
                                    // All of the magic handled by SWFObject (http://code.google.com/p/swfobject/)
                                    swfobject.embedSWF("http://www.youtube.com/v/" + videoID + "?version=3&enablejsapi=1&playerapiid=player1",
                                                   "videoDiv", "480", "295", "9", null, null, params, atts);
                                }

                                function getId(url) {
                                    var video_id = url.split('v=')[1];
                                    var ampersandPosition = video_id.indexOf('&');
                                    if (ampersandPosition != -1) {
                                        video_id = video_id.substring(0, ampersandPosition);
                                    }

                                    return video_id;
                                }
                                google.setOnLoadCallback(_run);
                            </script>
                            <% } %>
                        </div>
                    </div>                
                 </div>
            </div>

                </div>
            </div>

            <%
            if (Session["IdUsuario"] != null && Session["IdUsuario"] != "")
            { 
            %>
            <button class="btn btn-primary pull-right" id="btnComprar">Comprar</button><br /><br />
            <div class="row">
                <div class="span10">
                    <div id="especCompra">
                        <span class="close" id="btnComprarClose" >×</span>
                        <h3>Compra de entradas para "<%=espectaculo["Titulo"].ToString()%>"</h3>
                        <br /><br />
                        <asp:Label ID="Label2" runat="server" Text="Fecha:"></asp:Label>
                        <asp:DropDownList ID="DropDownFechas" runat="server" CssClass="span2">
                        </asp:DropDownList><br />

                        <asp:Label ID="Label1" runat="server" Text="Horario:"></asp:Label>
                        <asp:DropDownList ID="DropDownHorarios" runat="server" CssClass="span1">
                        </asp:DropDownList>
                        
                        <br /><br />
                        <p style="color: silver;width: 100px;margin: 0 auto;">▲ Orientación ▲</p>
                        <div id="drawZone">
	                    </div>
                        <br /><br />
                        <h4><span id="contReservas">0</span> asientos seleccionados</h4><br />
                        <p id="listaReservas">
                        </p>
                        <p class="pull-right">Importe: <span id="importeCompra">-</span> € 
                            <asp:Button ID="confirmCompraButton" runat="server" Text="Ir a la página de compra" onclick="confirmCompraButton_Click" CssClass="btn btn-primary btn-mini" />
                        </p>
                    </div>
                </div>
            </div>
            <% 
            }
            else
            {
                %><p class="pull-right">Debes estar <a href="login.aspx">identificado</a> para poder comprar.</p><% 
            }
            %>
            <br /> 
                    
        <%  
        } catch
        {
        %>
            <h3>No se pudo recuperar el espectaculo</h3>    
        <%  
        }
        %>
        <hr />
        <div class="row">
	        <div class="span10">            
            <% 
            try
            { %>
                <h3><%= datosCrit.Tables[0].Rows.Count %> Críticas</h3>
                <ul class="criticasList"><%
                foreach (System.Data.DataRow critica in datosCrit.Tables[0].Rows)
                {  %>
                    <li class="criticaEsp">
                        <div class="avatar-box">
                            <img src="/utilidades/img_user.aspx?id=<%= critica["idCliente"].ToString()%>" alt="avatar" />
                        </div>
                        <div class="content">
                            <div class="critica-info">
                                <p><%=critica["titulo"].ToString()%></p>
                            </div>
                            <p><%=critica["texto"].ToString()%></p>
                        </div>
                    </li> 
                <%
                }
                %></ul><%
        }
        catch (Exception ex)
        { %>
            <h3>0 Críticas</h3><%
        }

        if (Session["IdUsuario"] != null && Session["IdUsuario"] != "")
        { %>
            <div class="well">
                <label>Título</label>
                <asp:TextBox ID="tbTituloCritica" runat="server" CssClass="span3"></asp:TextBox>
                <label>Texto
                    <asp:TextBox ID="tbTextoCritica" runat="server" Height="100px" 
                    TextMode="MultiLine" Width="306px"></asp:TextBox>
                </label>
                <asp:Button ID="nuevaCritica" runat="server" Text="Enviar" 
                    CssClass="btn btn-primary" onclick="nuevaCritica_Click" />
            </div>
        <% 
        }
        else
        {
            %><p>Debes estar <a href="login.aspx">identificado</a> para poder escribir una crítica.</p><% 
        }
        %>
        </div>
    </div>

	<script type="text/javascript">
	    var espValues = {
	        idEspectaculo: '<%=espID%>'
	    };
    </script>
    <script src="js/espectaculo.js" type="text/javascript" ></script> 
</asp:Content>


