<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="acercade.aspx.cs" Inherits="WEvents4ALL.acercade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script type="text/javascript" src="js/acercade.js"></script>

<h2>¿Donde estamos?</h2>
<div class="well">
    <div class="row">
        <div class="span4">
            <div id="text">
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
                <p>Nyan nyan nyan nyan</p>
            </div>
        </div>
        <div class="span5">
            <div id="map_canvas"></div>
        </div>
    </div>
</div>

</asp:Content>
