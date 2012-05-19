<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="acercade.aspx.cs" Inherits="WEvents4ALL.acercade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script type="text/javascript" src="js/acercade.js"></script>
<script src="js/jquery.qtip-1.0.0-rc3.min.js" type="text/javascript" ></script> 

<h2>¿Donde estamos?</h2>
<div class="well">
    <div class="row">
        <div class="span4">
            <div id="text">
                <h3>La Llotja</h3>
                <p>La Llotja Sala Cultural es un espacio cultural, inaugurado en 2008, que ocupa una gran parte del edificio de la antigua lonja de frutas y verduras (El Prao) del barrio de Altabix, tras la reforma de este edificio construido entre los años 1941 y 1942.</p>
                <h3>Localización</h3>
                <p>Plaça de la Llotja</p>
                <p>03202 Elche - Alicante</p>
            </div>
        </div>
        <div class="span5">
            <div id="mapa_content"></div>
            <button class="btn btn-primary" id="geoloc" type="button"><i class="icon-road icon-white"></i> Llévame </button>
        </div>
    </div>
</div>

<h2>Nuestras instalaciones</h2>
<div class="well">
    <div class="row">
        <div class="span10">
            <div id="instal">
                <img src="img/layout/mapa.jpg" width="600" height="341" border="0" usemap="#map" />
                
                <map name="map">
                    <area title="Aforo: <%= aforo[1] %>" shape="rect" coords="17,27,157,174" alt="Sala 1"  href="#Sala1" />
                    <area title="Aforo: <%= aforo[2] %>" shape="rect" coords="17,174,157,316" alt="Sala 2"  href="#Sala2" />
                    <area title="Aforo: <%= aforo[4] %>" shape="rect" coords="444,173,584,316" alt="Sala 4"  href="#Sala4" />
                    <area title="Aforo: <%= aforo[3] %>" shape="rect" coords="445,28,584,173" alt="Sala 3"  href="#Sala3" />
                    <area title="Un espacio donde meditar y reflexionar sobre lo que acabas de ver." shape="rect" coords="377,28,445,64" alt="Baños"  href="#Baños" />
                    <area title="Aquí podrás comprar tus entradas o recogerlas si las había comprado previamente a través de nuestra web." shape="rect" coords="242,131,363,201" alt="Taquillas"  href="#Taquillas" />
                    <area title="Aquí podras comprar todo tipo de golosinas y refrescos para afrontar todo tipo de espectáculos con el estomago lleno." shape="rect" coords="158,27,283,83" alt="Comida"  href="#Comida" />
                </map>
            </div>
        </div>
    </div>
</div>

</asp:Content>
