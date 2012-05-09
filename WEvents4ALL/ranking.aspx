<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="WEvents4ALL.ranking"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<h3>Ranking</h3>


   <%
       
        string tipo = Request.QueryString["tipo"];

       %>
       <div class="btn-group" data-toggle="buttons-radio">
       

         <%if (tipo == "Teatro")
        {%>
                    <a class="btn" href="/ranking.aspx?tipo=Cine"><i class="icon-film"></i> Cine</a>
                    <a class="btn active" href="/ranking.aspx?tipo=Teatro"><i class="icon-star"></i> Teatro</a>
                    <a class="btn" href="/ranking.aspx?tipo=Concierto"><i class="icon-music"></i> Concierto</a>
       <% }
        else if (tipo == "Concierto")
        {%>
                    <a class="btn" href="/ranking.aspx?tipo=Cine"><i class="icon-film"></i> Cine</a>
                    <a class="btn" href="/ranking.aspx?tipo=Teatro"><i class="icon-star"></i> Teatro</a>
                    <a class="btn active" href="/ranking.aspx?tipo=Concierto"><i class="icon-music"></i> Concierto</a>
        <%}
        else
        {%>
                    <a class="btn active" href="/ranking.aspx?tipo=Cine"><i class="icon-film"></i> Cine</a>
                    <a class="btn" href="/ranking.aspx?tipo=Teatro"><i class="icon-star"></i> Teatro</a>
                    <a class="btn" href="/ranking.aspx?tipo=Concierto"><i class="icon-music"></i> Concierto</a>
        <%}%>
        </div>
  
        <%
        string titulo = "";
        string id = "";
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
                   id = da[1].ToString();
                   %>
                   <img class="rank_img" alt="<%= titulo %>" src="utilidades/img_esp.aspx?id=<%=da["IDEspectaculo"].ToString()%>" />
                   <%        

                       Response.Write("<p class=\"rank_tit\"><a href=\"espectaculo.aspx?id=" + id + "\">" + titulo + "</a><span class=\"rank_nota\">(" + ventas + " votos) <i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i></span></p>");
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
