<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="WEvents4ALL.ranking"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<h3>Ranking</h3>


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
        
        
        
        string foto="";
        string titulo = "";
       // string titulo=random;
       int ventas=0;
       int cont=0;
       Response.Write("<ul class=\"rank_lista\">");

       try
       {
           foreach (System.Data.DataRow da in resultado.Tables[0].Rows)
           {
               if (cont < 5)
               {
                   titulo = da[0].ToString();
                   ventas = Convert.ToInt16(da[2].ToString());
                   Response.Write("<li class=\"rank_fila\">");
                   %>
                   <img class="rank_img" alt="<%= titulo %>" src="utilidades/img_esp.aspx?id=<%=da["IDEspectaculo"].ToString()%>" />
                   <%            
                   //Response.Write("<img alt=\"" + titulo + "\" src=\"/img/carteles/cazafan.gif\"  class=\"rank_img\"/>");
                   Response.Write("<p class=\"rank_tit\">" + titulo + "<span class=\"rank_nota\">" + ventas + "</span></p>");
                   Response.Write("</li>");
               }
               cont++;
           }
       }
       catch (Exception ex)
       {
           Response.Write(ex.Message);
       }
           Response.Write("</ul>");
       
    %>
   

</asp:Content>
