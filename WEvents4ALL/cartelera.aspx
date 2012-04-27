<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cartelera.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
   
    <div id="botones" class="menu">
        <asp:Button ID="Button1" runat="server" Text="Cine" BorderStyle="Outset" 
            Height="40px" Width="80px"/>
        <asp:Button ID="Button2" runat="server" Text="Concierto" BorderStyle="Outset" 
            Height="40px" Width="80px" />
        <asp:Button ID="Button3" runat="server" Text="Teatro" BorderStyle="Outset" 
            Height="40px" Width="80px" />
    </div>


    

    <div id="b1" class="bloque">
        <div id="c1" class="cartel">
            <img id="f1" class="tamCartel" alt="los vengadores" src="/img/carteles/los vengadores.jpg"/>
        </div>
        <div id="t1" class="titulo">
            Los Vengadores
        </div>
        <div id="fa1" class="fecha">
            16:00
        </div>
        <div id="fa2" class="fecha">
            19:00
        </div>
        <div id="fa3" class="fecha">
            22:00
        </div>
    </div>

    <div id="b2" class="bloque">
        <div id="c2" class="cartel">
            <img id="f2" class="tamCartel" alt="hook" src="/img/carteles/hook.png" />
        </div>
        <div id="t2" class="titulo">
            Hook
        </div>
        <div id="fb1" class="fecha">
            16:00
        </div>
        <div id="fb2" class="fecha">
            19:00
        </div>
        <div id="fb3" class="fecha">
            22:00
        </div>
    </div>
    
    </asp:Content>
