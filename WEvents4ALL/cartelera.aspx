<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cartelera.aspx.cs" Inherits="WEvents4ALL.cartelera"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
   
<div class="row">
    <div class="span10">
       <h3>Cartelera</h3><br />
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
        </div><br />
    </div>
</div>

<div class="row">
    <div class="span9" style="padding-left: 52px;">
        <%try{
            int col = 0;
            foreach(System.Data.DataRow r in resultado.Tables[0].Rows) {
                if (System.DateTime.Now < Convert.ToDateTime(r["FechaFin"]))
                {
                    if (col == 0)
                    {
                    %>
                        <div class="row">
                        <%
                    }
                    %>
                    <div class="span4 well">
                        <div class="titol_n">
                            <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><h3><%= r["Titulo"].ToString() %></h3></a>
                        </div>
                        <div class="cartell_n">
                            <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><img class="cartelera_img" alt=<%= r["Titulo"].ToString() %> src="utilidades/img_esp.aspx?id=<%=r["IDEspectaculo"].ToString()%>" /></a>
                            <a class="btn btn-mini btn-success" href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><i class="icon-tag icon-white"></i> Detalles</a>
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
                   <%
                   if (col == 1)
                   {
                       %>
                       </div>
                       <% col = 0;
                   } 
                   else
                       col=1;
                } 
            } 
            if (col == 1)
            {
                %>
                </div>
                <% col = 0;
            } 
                    
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        %>

    </div>
</div>
</asp:Content>
