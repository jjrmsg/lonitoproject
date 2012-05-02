<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="WEvents4ALL.ranking"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<h3>Ranking</h3>

    <%
        string tipo = Request.QueryString["tipo"];
        Response.Write("<ul id=\"tipoEvento\">");
        if (tipo == "teatro")
        {
            Response.Write("<li><a href=\"?tipo=cine\">Cine</a></li>");
            Response.Write("<li><a href=\"?tipo=concierto\">Concierto</a></li>");
            Response.Write("<li><a  class=\"tipoEventoSel\" href=\"?tipo=teatro\">Teatro</a></li>");
        }
        else if (tipo == "concierto")
        {
            Response.Write("<li><a href=\"?tipo=cine\">Cine</a></li>");
            Response.Write("<li><a class=\"tipoEventoSel\" href=\"?tipo=concierto\">Concierto</a></li>");
            Response.Write("<li><a href=\"?tipo=teatro\">Teatro</a></li>");
        }
        else
        {
            Response.Write("<li><a class=\"tipoEventoSel\" href=\"?tipo=cine\">Cine</a></li>");
            Response.Write("<li><a href=\"?tipo=concierto\">Concierto</a></li>");
            Response.Write("<li><a href=\"?tipo=teatro\">Teatro</a></li>");
        }
        Response.Write("</ul>");
        
        string foto="";
        string titulo="titulo fijo";
        string ventas="9.8";
        
        
        Response.Write("<ul class=\"rank_lista\">");
        for (int  i= 0;  i< 5; i++)
			{
                Response.Write("<li class=\"rank_fila\">");
                Response.Write("<img alt=\""+titulo+"\" src=\"/img/carteles/cazafan.gif\"  class=\"rank_img\"/>");
                Response.Write("<p class=\"rank_tit\">"+titulo+"<span class=\"rank_nota\">"+ventas+"</span></p>");
                Response.Write("</li>");
			}
        Response.Write("</ul>");
    %>
   

</asp:Content>
