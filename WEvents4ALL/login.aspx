<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WEvents4ALL.login"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

    <div class="boxContent">
    <div class="form-horizontal" id="formLogin">
        <fieldset>
            <legend>Entrada de usuarios</legend>
            <div class="control-group">
                <label class="control-label" for="inputLogNick">Nick</label>
                <div class="controls">
                    <asp:TextBox ID="tbLoginUser" runat="server"></asp:TextBox>
                    <span class="help-inline hide">El nombre de usuario sólo admite caracteres alfanuméricos</span>
                </div>
            </div>
            <div class="control-group">
                <label class="control-label" for="inputLogPass">Contraseña</label>
                <div class="controls">
                    <asp:TextBox ID="tbLoginPass" runat="server" TextMode="Password"></asp:TextBox>
                    <span class="help-inline hide">La contraseña sólo admite caracteres alfanuméricos</span>
                </div>
            </div>
            <div class="form-actions">
                <asp:Button ID="btLogin" runat="server" Text="Entrar" 
                    CssClass="btn btn-primary" onclick="Login_Usuario" />
            </div>
        </fieldset>
    </div>  
</div>

</asp:Content>


