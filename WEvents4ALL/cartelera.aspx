<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cartelera.aspx.cs" Inherits="WEvents4ALL.cartelera"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
   <h3>Cartelera</h3>

    <ul id="tipoEvento">
        <li><a class="tipoEventoSel" href="#">Cine</a></li>
        <li><a href="#">Concierto</a></li>
        <li><a href="#">Teatro</a></li>
    </ul>
    
    
    
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
