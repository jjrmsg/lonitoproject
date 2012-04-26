<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">




    <p style="height: 187px">
        <img alt="" src="" style="width: 113px" />

        <asp:Label ID="LabelNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        <asp:Label ID="LabelApellidos" runat="server" Text="Apellidos"></asp:Label>
        <asp:TextBox ID="TextBoxApellidos" runat="server"></asp:TextBox>
    </p>

    <asp:Label ID="LabelNIF" runat="server" Text="NIF"></asp:Label>
    <asp:TextBox ID="TextBoxNIF" runat="server"></asp:TextBox>



</asp:Content>
