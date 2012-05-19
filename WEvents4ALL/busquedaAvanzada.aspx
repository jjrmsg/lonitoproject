<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="busquedaAvanzada.aspx.cs" Inherits="WEvents4ALL.busquedaAvanzada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<h3>Busqueda Avanzada</h3>
<br />

<div class="bus_av_busqueda">
    <p><label class="bus_av_label">Nombre</label><asp:TextBox ID="TextBox1" runat="server" CssClass="bus_av_imput"></asp:TextBox></p>
    
    <p><label class="bus_av_label">Tipo </label> <asp:DropDownList ID="DropDownList1" runat="server" CssClass="bus_av_imput">
                            <asp:ListItem Value=""></asp:ListItem>
                            <asp:ListItem >Cine</asp:ListItem>
                            <asp:ListItem >Teatro</asp:ListItem>
                            <asp:ListItem >Concierto</asp:ListItem>
                            </asp:DropDownList>
    </p>
    
    <p>
        <span class="bus_av_label">Fecha inicio </span>
			  <div class="input-append date" id="bus_av_dp1" data-date="01-01-2012" data-date-format="dd-mm-yyyy">
				<input class="span2" size="16" type="text" value="01-01-2012">
				<span class="add-on"><i class="icon-th"></i></span>
			  </div><br />
                <span class="bus_av_label">Fecha fin </span>
        <div class="input-append date" id="bus_av_dp2" data-date="31-12-2012" data-date-format="dd-mm-yyyy">
          <input class="span2" size="16" type="text" value="31-12-2012" >
            <span class="add-on"><i class="icon-th"></i></span>
        </div>
    </p>
    <asp:Button ID="Button1_bus_av" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="EventoClick_bus_av" />
</div>



<div class="bus_av_resultado">
<%
        string titulo = "";
        string id = "";

       Response.Write("<ul class=\"rank_lista\">");

       try
       {
           if(resultado!=null)
               foreach (System.Data.DataRow da in resultado.Tables[0].Rows)
               {
                       titulo = da[0].ToString();
                       Response.Write("<li class=\"rank_fila\">");
                       id = da[1].ToString();
                       %>
                       <img class="rank_img" alt="<%= titulo %>" src="utilidades/img_esp.aspx?id=<%=id%>" />
                       <%        

                       Response.Write("<p class=\"rank_tit\"><a href=\"espectaculo.aspx?id=" + id + "\">" + titulo + "</a></p>");
               }
               Response.Write("</li>");

       }
       catch (Exception ex)
       {
           Response.Write(ex.Message);
       }
           Response.Write("</ul>");
       
    %>
</div>


<script>
    $('#bus_av_dp1').datepicker();
    $('#bus_av_dp2').datepicker();
</script>

</asp:Content>
