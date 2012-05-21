<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ventas.aspx.cs" Inherits="WEvents4ALL.ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

    <div class="row">
        <div class="span10">
            <h3>Resumen ventas</h3>
            <br />
            <ul class="nav nav-list">
            <% 
                int totalPrecio = 0; // Acumulamos el precio de cada venta para mostrar un total
                if (listado.Count != 0)
                {
                    // Recorremos los espectaculos
                    foreach (Dictionary<string, object> espectaculo in listado)
                    {
                        %><li class="nav-header">
                            <a href="espectaculo.aspx?id=<%= espectaculo["id"]%>"><%= espectaculo["titulo"]%></a>
                        </li>
                        <%
                        // Recorremos todas las ventas de ese espectaculo
                        foreach (Dictionary<string, string> pventa in (ArrayList)espectaculo["preventas"])
                        {
                            %>
                            <li>
                                Asiento: <%= pventa["asiento"]%> | Precio: <%= pventa["precio"]%> € | Hora: <%= pventa["hora"]%> | Fecha: <%= pventa["fecha"]%> 
                            </li>
                            <%
                            // Añadimos el precio de la venta al total
                            totalPrecio += Convert.ToInt32(pventa["precio"]);
                        }
                    }
                }
                else
                {
                    %><p>No has seleccionado ningún asiento, aquí aparecerán un listado de todos los asientos seleccionados y podras confirmar la compra.</p><%
                }
            %>
            </ul>
        </div>
    </div>
   
    <div class="row">
        <div class="span10">
        <%
        // Si no hay ventas no mostramos el boton de compra, mostramos el de ir a inicio
        if (listado.Count != 0 && mode==0)
        {
            %>
            <p class="pull-right">Precio total <%=totalPrecio %> € 
            <asp:Button ID="terminarCompra" runat="server" Text="Comprar" CssClass="btn btn-primary" onclick="terminarCompra_Click" />
            </p>
            <%
        }
        else if (mode != 0)
        {
            %>
            <a class="btn btn-primary pull-right" href="index.aspx">Volver a la página de inicio</a>
            <%
        }
        %>
        </div>
    </div>

</asp:Content>
