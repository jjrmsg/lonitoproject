<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<h3>Ranking</h3>
<p class="rank_">Top 5 Cine</p>



    <ul class="rank_lista">
        <li class="rank_fila">
            <img alt="fot_cazafantasm" src="/img/carteles/cazafan.gif"  class="rank_img"/>
            <p class="rank_tit">Los Caza Fantasmas<span class="rank_nota">9.5</span></p>
        </li>
        <li class="rank_fila">
            <img alt="fot_hook" src="/img/carteles/hook.png"  class="rank_img"/> 
            <p class="rank_tit">Hook <span class="rank_nota">9.1</span></p>
        </li>
        <li class="rank_fila">
            <img alt="fot_cazafantasm" src="/img/carteles/reyleon.gif"  class="rank_img"/>
            <p class="rank_tit">El Rey Leon <span class="rank_nota">8.4</span></p>
        </li>
        <li class="rank_fila">
            <img alt="fot_inmortales" src="/img/carteles/los_inmortales.jpg"  class="rank_img" />
            <p class="rank_tit">Los Inmortales<span class="rank_nota">8.1</span></p>
        </li>
        <li class="rank_fila">
            <img alt="fot_los_vengadores" src="/img/carteles/los vengadores.jpg"  class="rank_img"/>
            <p class="rank_tit">Los Vengadores <span class="rank_nota">7.7</span></p></li>
    </ul>

</asp:Content>
