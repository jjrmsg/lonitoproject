<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WEvents4ALL.index"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

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
    $(document).ready(function () {
        $('.carousel').carousel({
            interval: 5000
        });
    });
</script>

<html itemscope itemtype="http://schema.org/Blog">


<div id="myCarousel" class="carousel slide">
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

<%
    try
    {%>

        <div class="row">
            <div class="span10">
                <h3>Últimos espectáculos</h3><br />
                <div class="row">
                    <div class="span7">
                    <%foreach (System.Data.DataRow r in esp.Tables[0].Rows)
                    { %>           
                        <div class="row">
                            <div class="span7 well">
                                <div class="titulo_n">
                                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><span itemprop="name"><h3><%= r["Titulo"].ToString()%></h3></span></a>
                                </div>
                                <div class="poster_n">
                                    <a href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><img alt="<%= r["Titulo"].ToString() %>" src="utilidades/img_esp.aspx?id=<%=r["IDEspectaculo"].ToString()%>" /></a>
                                </div>
                                <div class="descripcion_n">
                                    <span itemprop="description"><%= r["Descripcion"].ToString()%>
                                </div>
  
                                <div class="row">
                                    <div class="span7">
                                        <div class="detailBox"><a class="btn btn-success" href="/espectaculo.aspx?id=<%= r["IDEspectaculo"].ToString() %>"><i class="icon-tag icon-white"></i> Detalles</a></div>
                                        <div class="socialBox">
                                            <g:plusone annotation="none"></g:plusone>
                                            <a href="https://twitter.com/share" class="twitter-share-button" data-url="http://www.events4all.com" data-text="Estrenamos <%= r["Titulo"].ToString()%>" data-lang="es" data-hashtags="Events4All">Twittear</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>            
                <%  }%>                           
                    </div>

                    <div class="span3">
                        <script charset="utf-8" src="http://widgets.twimg.com/j/2/widget.js"></script>
                        <script>
                            new TWTR.Widget({
                                version: 2,
                                type: 'search',
                                search: 'Events4All #Events4All',
                                interval: 30000,
                                title: '',
                                subject: '',
                                width: 210,
                                height: 300,
                                theme: {
                                    shell: {
                                        background: '#eeeeee',
                                        color: '#121212'
                                    },
                                    tweets: {
                                        background: '#ffffff',
                                        color: '#444444',
                                        links: '#3d9fcc'
                                    }
                                },
                                features: {
                                    scrollbar: false,
                                    loop: true,
                                    live: true,
                                    behavior: 'default'
                                }
                            }).render().start();
                        </script>
                        <div class="verticalBanner">
                            <img src="/img/layout/vertical_banner.jpg" />
                        </div>
                        <div class="verticalBanner">
                            <img src="/img/layout/10perc_discount.png" />
                        </div>
                        <div class="verticalBanner">
                            <img src="/img/layout/vertical_banner2.png" />
                        </div>
                    </div>
                </div>
            </div>
        </div>


    <%}
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    %>
</asp:Content>
