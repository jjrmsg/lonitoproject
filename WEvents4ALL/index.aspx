<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEvents4ALL.index"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">



<!--<div id="carrusel">
    <img id="banner" src="/img/layout/banner.png" alt="" title="" />
</div>
<br />
<hr />

<div id="noticias">
    <div class="new">
        <div class="cabecera">
            <b>El caballero oscuro</b>
        </div>
        <div class="cuerpo">
            <div class="imgNoticia">
                <img id="cart" src="/img/layout/dark.jpg" alt="" title="" />
            </div>
            <div class="descripcion">
                Batman (Christian Bale) regresa para continuar su guerra contra el crimen. Con la ayuda del teniente Jim Gordon y del Fiscal del Distrito Harvey Dent, Batman se propone destruir el crimen organizado en la ciudad de Gotham. El triunvirato demuestra su eficacia, pero, de repente, aparece Joker, un nuevo criminal que desencadena el caos y tiene aterrados a los ciudadanos. 
            </div>
        </div>
    </div>
</div>-->
<script type="text/javascript">

    //Google+
    window.___gcfg = { lang: 'es' };

    (function () {
        var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;
        po.src = 'https://apis.google.com/js/plusone.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
    })();


    //Twitter
    !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = "//platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");

    //Facebook
    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/es_ES/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));

    //Carrusel de imágenes
    $('.carousel').carousel()
    $('.carousel').carousel({
        interval: 2000
    })
</script>

<html itemscope itemtype="http://schema.org/Blog">


<div id="myCarousel" class="carousel">
      <!-- Carousel items -->
      <div class="carousel-inner">
            <div class="active item"><img src="/img/layout/banner.jpg" alt=""></div>
            <div class="item"><img src="/img/layout/banner2.jpg" alt=""></div>
            <div class="item"><img src="/img/layout/banner3.jpg" alt=""></div>
      </div>
      <!-- Carousel nav -->
      <a class="carousel-control left" href="#myCarousel" data-slide="prev">&lsaquo;</a>
      <a class="carousel-control right" href="#myCarousel" data-slide="next">&rsaquo;</a>
</div>

<%foreach(System.Data.DataRow r in esp.Tables[0].Rows) { %>
    <div class="boxContent">
        <div class="row">
            <div class="span9">
                <div class="titulo_n">
                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><span itemprop="name"><h3><%= r["Titulo"].ToString() %></h3></span></a>
                </div>
                <div class="poster_n">
                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><img class="rank_img" alt=<%= r["Titulo"].ToString() %> src="utilidades/img_esp.aspx?id=<%=r["IDEspectaculo"].ToString()%>" /></a>
                    <a class="btn btn-success" href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><i class="icon-tag icon-white"></i> Detalles</a>
                </div>
                <div class="descripcion_n">
                    <span itemprop="description"><%= r["Descripcion"].ToString() %>
                </div>
                <div class="social_n">
                    <div class="socialBox"><g:plusone annotation="none"></g:plusone></div>
                    <div class="socialBox"><a href="https://twitter.com/share" class="twitter-share-button" data-url="http://www.events4all.com" data-text="Estrenamos <%= r["Titulo"].ToString()%>" data-lang="es" data-hashtags="Events4All">Twittear</a></div>
                    <div class="socialBox"><div class="fb-like" data-href="http://www.events4all.com" data-send="false" data-layout="button_count" data-width="390" data-show-faces="false" data-font="tahoma"></div></div>
                </div>
            </div>
        </div>
    </div>
<%} %>

</asp:Content>
