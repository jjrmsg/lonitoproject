<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="espectaculo.aspx.cs" Inherits="WEvents4ALL.espectaculo"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

    <div class="row">
	    <div class="span10">
        <%  
        string salaEspID = "";
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
                        <li class="nav-header">Descripción</li>
                        <li><%=espectaculo["Descripcion"].ToString()%></li>
                        <li class="nav-header">Tipo de espectáculo</li>
                        <li><%=espectaculo["Tipo"].ToString()%></li>
                        <li class="nav-header">Fecha de inicio</li>
                        <li><%=espectaculo["FechaIni"].ToString()%></li>
                        <li class="nav-header">Fecha de fin</li>
                        <li><%=espectaculo["FechaFin"].ToString()%></li>
                        <li class="nav-header">Sala</li>
                        <li>Sala <%=espectaculo["IdSala"].ToString()%></li>
                        <% salaEspID = espectaculo["IdSala"].ToString(); %>
                        <li class="nav-header">Horarios</li>
                        <li>16:00 | 18:00 | 20:00 | 22:00 | 00:00</li>
                    </ul>                
                </div>
                <div class="span2 pull-right">
                    <img class="pull-right" id="imgEspectaculo" src="utilidades/img_esp.aspx?id=<%=espectaculo["IDEspectaculo"].ToString()%>" alt="<%=espectaculo["Titulo"].ToString()%>" title="Cartel de <%=espectaculo["Titulo"].ToString()%>" />
                    <ul class='star-rating pull-right'>
	                    <li class='current-rating'> style='width:105px;' Currently 3.5/5 Stars.</li>
	                    <li><a href='#' title='1 star out of 5' class='one-star'>1</a></li>
	                    <li><a href='#' title='2 stars out of 5' class='two-stars'>2</a></li>
	                    <li><a href='#' title='3 stars out of 5' class='three-stars'>3</a></li>
	                    <li><a href='#' title='4 stars out of 5' class='four-stars'>4</a></li>
	                    <li><a href='#' title='5 stars out of 5' class='five-stars'>5</a></li>
                    </ul>		
                </div>
            </div>
            <button class="btn btn-primary pull-right" id="btnComprar">Comprar</button><br /><br />
            <div id="especCompra">
                <span class="close" id="btnComprarClose" >×</span>
                <h3>Compra de entradas para "<%=espectaculo["Titulo"].ToString()%>"</h3>
                <br /><br />
                <asp:Label ID="Label1" runat="server" Text="Horario:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>20:00</asp:ListItem>
                    <asp:ListItem>22:00</asp:ListItem>
                    <asp:ListItem>00:00</asp:ListItem>
                </asp:DropDownList>
                <br /><br />
                <div id="drawZone">
	            </div>
                <br /><br />
                <h4>4 asientos seleccionados</h4>
                <p>A 8-5 / A 8-6 / A 8-7 / A 8-8</p>
                <p class="pull-right">Importe: 36 € <button class="btn btn-primary"><i class="icon-shopping-cart icon-white"></i> Comprar</button></p>
            </div>
            <br />

        <%  
        } catch
        {
        %>
            <h3>No se pudo recuperar el espectaculo</h3>
    
        <%  
        }
        %>

         </div>
    </div>
    <hr />
    <div class="row">
	    <div class="span10">
            
        <% 
        try
        { %>
            <h3><%= datosCrit.Tables[0].Rows.Count %> Críticas</h3>
            <ul class="criticasList"><%
            foreach (System.Data.DataRow critica in datosCrit.Tables[0].Rows)
            {
            %>
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
        %>                  
            
            
        <% if (Session["IdUsuario"] != null && Session["IdUsuario"] != "")
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
        <% } %>
        </div>
    </div>


	<script type="text/javascript">
	    $.getJSON('/api/sala_data.aspx', { id: '<%=salaEspID%>' }, function (data) {
            console.log(data);
            $("#drawZone").empty();
            for (i in data.secciones)
            {
                var fil = data.secciones[i].filas;
                var col = data.secciones[i].columnas;
                dibujar(fil,col);
            }
        });

        function dibujar (filas, colum) {
			
			var seccion = $("<div></div>", {
				class: "seccionBox"
			}).appendTo("#drawZone");

			for(var j = 0; j < filas; j++)
			{
				var fila = $("<div></div>", {
					class: "fila"
				}).appendTo(seccion);
					
				for(var k = 0; k < colum; k++)
				{
					var asiento = $("<div></div>", {
						class: "asiento",
						text: "o"
					}).appendTo(fila);									
				}
			}
		}

		$('.asiento').live('click', function (event) {
            $(".popover").remove();
		    var posAsiento = "";
		    posAsiento = $(this).parents(".seccionBox").index() + 1 + ":";
		    posAsiento += $(this).parent(".fila").index() + 1 + ":";
		    posAsiento += $(this).index() + 1;
		    $(this).popover({
		        placement: 'right',

		        trigger: 'manual',
		        title: 'Asiento ' + posAsiento,
		        content: '<a href="#" class="btn btn-info"><i class="icon-plus icon-white"></i> Añadir a la compra</a>'
		    });
		    $(this).popover('show');
		});

		
        document.getElementById("btnComprar").onclick = function (e) {
            $("#especCompra").slideDown();
            this.style.display = "none";
            e.preventDefault();
        };

        $("#btnComprarClose").on('click', function () {
            // Quitamos cualquier popover que estuviese abierto
            $(".popover").remove();
            $("#especCompra").css('display', 'none');
            $("#btnComprar").fadeIn('slow');        
        });
    
    </script>
</asp:Content>


