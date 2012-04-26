<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">


 <!-- <div class="login"> -->
    

    <div id="PanelUsuario" class="login">

        <asp:Label ID="Usuario" runat="server" Text="Usuario"></asp:Label>
        <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
    
    
   <!-- <p> -->
        <asp:TextBox ID="TextBoxUsuario" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
    

    <input id="Submit1" type="submit" value="submit" />
    
    </div>



</asp:Content>


