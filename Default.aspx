<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<!--
    Author: Scott Robinson
    December 2016
    XML Final Project
    The goal of this application is to allow users to select a variety of football leagues and view the teams with the most titles won and the amount of European
    titles they have won.
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--Text to tell the user to select a league.-->
        Select A League&nbsp;&nbsp;
        <!--DropDownList containing the leagues.-->
        <asp:DropDownList ID="ddlCats" runat="server">
        </asp:DropDownList>
        <br />
    
    </div>
        <!--Button to change which team information is being displayed-->
        <asp:Button ID="btnGo" runat="server" Text="Show Team Information" OnClick="btnGo_Click" />
        <br />
        <br />
        <br />
        <!--The listbox where team information is shown.-->
        <asp:ListBox ID="lstItems" runat="server" Height="177px" Width="439px"></asp:ListBox>
        <br />
        <br />
    </form>
</body>
</html>
