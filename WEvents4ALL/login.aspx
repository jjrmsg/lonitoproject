<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WEvents4ALL.login"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">


 
 <div id="acceso" class="login">
    

    <fieldset>
        <label for="usuario">Usuario:</label>
        <input id="usuario" name="user" size="10" type="text" />
        <br />
        <label for="password">Password:</label>
        <input id="password" name="pass" size="10" type="password" />
        <br />
        <br />
        <input id="Submit1" type="submit" value="Entrar" />
    
   <!-- <p> -->

   </fieldset>

    
    
 </div>   


</asp:Content>


