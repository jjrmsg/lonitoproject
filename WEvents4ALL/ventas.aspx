<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ventas.aspx.cs" Inherits="WEvents4ALL.ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">





    <div class="row">
        <div class="span10">
            <h3>Resumen ventas</h3>
            <br />
            <ul class="nav nav-list">
            <% 
                if (listado.Count != 0)
                {
                    foreach (Dictionary<string, object> espectaculo in listado)
                    {
                        %><li class="nav-header">
                            <a href="espectaculo.aspx?id=<%= espectaculo["id"]%>"><%= espectaculo["titulo"]%></a>
                        </li>
                        <%

                        foreach (Dictionary<string, string> pventa in (ArrayList)espectaculo["preventas"])
                        {
                            %>
                            <li>
                                Asiento: <%= pventa["asiento"]%> | Precio: <%= pventa["precio"]%> | Hora: <%= pventa["hora"]%> | Fecha: <%= pventa["fecha"]%> 
                            </li>
                            <%
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
        <%if (listado.Count != 0 && mode==0)
        {
            %>
            <asp:Button ID="terminarCompra" runat="server" Text="Comprar" CssClass="btn btn-primary pull-right" onclick="terminarCompra_Click" />
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
