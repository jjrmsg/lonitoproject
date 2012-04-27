<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ranking.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<h1>Ranking</h1>
<h2 class="rank_h2">Top 5 Cine</h2>
    <table class="rank_table">
        <tr>
            <td class="colfoto">
                <img alt="fot_cazafantasm" src="/img/carteles/cazafan.gif"  class="rank_img"/>
            </td>
            <td class="restocol">
                <p>Los Caza Fantasmas</p>
            </td>
            <td class="restocol">
                <p>9.5</p>
            </td>
        </tr>
        <tr>
            <td class="colfoto">
                <img alt="fot_reyleon" src="/img/carteles/reyleon.gif"  class="rank_img"/>
            </td>
            <td class="restocol">
                <p>El Rey Leon</p>
            </td>
            <td class="restocol">
                <p>8.7</p>
            </td>
        </tr>
        <tr>
            <td class="colfoto">
                <img alt="fot_hook" src="/img/carteles/cazafan.gif"  class="rank_img"/>
            </td>
            <td class="restocol">
                <p>Caza Fantasmas 2</p>
            </td>
            <td class="restocol">
                <p>8.1</p>
            </td>
        </tr>
                <tr>
            <td class="colfoto">
                <img alt="fot_inmortales" src="/img/carteles/los_inmortales.jpg" class="rank_img"/>
            </td>
            <td class="restocol">
                <p>Los Inmortals</p>
            </td>
            <td class="restocol">
                <p>7.6</p>
            </td>
        </tr>
                <tr>
            <td class="colfoto">
                <img alt="fot_vengadores" src="/img/carteles/los vengadores.jpg" class="rank_img" />
            </td>
            <td class="restocol">
                <p>Los Vengadores</p>
            </td>
            <td class="restocol">
                <p>7.2</p>
            </td>
        </tr>
    </table>
</asp:Content>
