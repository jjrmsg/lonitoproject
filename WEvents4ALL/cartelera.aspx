<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="cartelera.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
   
    
    <asp:Button ID="Button1" runat="server" Text="Cine" BorderStyle="None" />
    <asp:Button ID="Button2" runat="server" Text="Concierto" BorderStyle="None" />
    <asp:Button ID="Button3" runat="server" Text="Teatro" BorderStyle="None" />
    <br />
    
    <asp:Table ID="Table1" runat="server" Width="1000px" BorderStyle="None">
        <asp:TableRow runat="server" BorderStyle="None">
            <asp:TableCell ID="TableCell1" runat="server" BorderStyle="None" HorizontalAlign="Center">
                <asp:Image ID="Image1" ImageUrl="img/carteles/los vengadores.jpg" runat="server" Width="200"/><br />
                <asp:Label ID="Label1" runat="server" Text="Los Vengadores"></asp:Label>
            </asp:TableCell>
            <asp:TableCell ID="TableCell2" runat="server" BorderStyle="None" HorizontalAlign="Center">
                <asp:Image ID="Image2" ImageUrl="img/carteles/cazafan.gif" runat="server" Width="200"/><br />
                <asp:Label ID="Label2" runat="server" Text="Cazafantasmas"></asp:Label>
            </asp:TableCell>    
            <asp:TableCell ID="TableCell3" runat="server" BorderStyle="None" HorizontalAlign="Center">
                <asp:Image ID="Image3" ImageUrl="img/carteles/hook.png" runat="server" Width="200"/><br />
                <asp:Label ID="Label3" runat="server" Text="Hook"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server" BorderStyle="None">
            <asp:TableCell ID="TableCell4" runat="server" BorderStyle="None" HorizontalAlign="Center">
                <asp:Image ID="Image4" ImageUrl="img/carteles/los_inmortales.jpg" runat="server" Width="200"/><br />
                <asp:Label ID="Label4" runat="server" Text="Los Inmortales"></asp:Label>
            </asp:TableCell>
            <asp:TableCell ID="TableCell5" runat="server" BorderStyle="None" HorizontalAlign="Center">
                <asp:Image ID="Image5" ImageUrl="img/carteles/reyleon.gif" runat="server" Width="200"/><br />
                <asp:Label ID="Label5" runat="server" Text="El Rey León"></asp:Label>
            </asp:TableCell>
            <asp:TableCell ID="TableCell6" runat="server" BorderStyle="None" HorizontalAlign="Center"></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server" BorderStyle="None">
            <asp:TableCell ID="TableCell7" runat="server" BorderStyle="None" HorizontalAlign="Center"></asp:TableCell>
            <asp:TableCell ID="TableCell8" runat="server" BorderStyle="None" HorizontalAlign="Center"></asp:TableCell>
            <asp:TableCell ID="TableCell9" runat="server" BorderStyle="None" HorizontalAlign="Center"></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </asp:Content>
