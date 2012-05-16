<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="acercade.aspx.cs" Inherits="WEvents4ALL.acercade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script type="text/javascript" src="js/acercade.js"></script>

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
        </div>
    </div>
</div>

<h2>¿Pero como llego?</h2>
<div class="well">
    <div class="row">
        <div class="span10">
            <div id="mapa_content2"></div>
            <button class="btn btn-primary" id="geoloc" type="button"><i class="icon-road icon-white"></i> Llévame </button>
        </div>
    </div>
</div>

</asp:Content>
