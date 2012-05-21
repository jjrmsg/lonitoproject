<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" Inherits="WEvents4ALL.ranking"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

<%       
string tipo = Request.QueryString["tipo"];
%>

<div class="row">
    <div class="span10">
        <div class="span9">
            <h3>Ranking</h3><br />
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
        </div>
    </div>
</div>
<div class="row">
    <div class="span10">
        <br />
        <%
        string titulo = "";
        string id = "";
       int numVotos=0;
       int nota;
       int cont=0;
       Response.Write("<ul class=\"rank_lista span9\">");

       try
       {
           foreach (System.Data.DataRow da in resultado.Tables[0].Rows)
           {
               if (cont < 5)
               {
                   titulo = da[0].ToString();
                   numVotos = Convert.ToInt16(da[2].ToString());
                   nota = Convert.ToInt16(da[3].ToString());
                   Response.Write("<li class=\"rank_fila\">");
                   id = da[1].ToString();
                   %>
                   <img class="rank_img" alt="<%= titulo %>" src="utilidades/img_esp.aspx?id=<%=id%>" />
                   <%        

                       Response.Write("<p class=\"rank_tit\"><a href=\"espectaculo.aspx?id=" + id + "\">" + titulo + "</a><span class=\"rank_nota\">(" + numVotos + " votos)");
                       switch(nota){
                           case 0: Response.Write("<i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i></span></p>");
                               break;
                           case 1: Response.Write("<i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star\"></i></span></p>");
                               break;
                           case 2: Response.Write("<i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i></span></p>"); 
                               break;
                           case 3: Response.Write("<i class=\"icon-star-empty\"></i><i class=\"icon-star-empty\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i></span></p>");
                               break;
                           case 4: Response.Write("<i class=\"icon-star-empty\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i></span></p>");
                               break;
                           default: Response.Write("<i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i><i class=\"icon-star\"></i></span></p>");
                               break;                        
                       }
                       //Response.Write("<i class=\"icon-star\"></i>");
                      
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
       </div>
</div>

</asp:Content>
