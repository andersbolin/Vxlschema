<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarView.aspx.cs" Inherits="CalendarView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Växlare Gbg Schemaberäkning</title>
    <link href="../StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <ul>
        <li><a href="../Default.aspx">Home</a></li>
        <li><a href="../SchemaCalculation.aspx">Schema</a></li>
        <li><a href="../news.aspx">News</a></li>
        <li><a href="../contact.aspx">Contact</a></li>
        <li style="float:right"><a class="active" href="../about.aspx">About</a></li>
    </ul>
    <div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="40px" Width="160px" CellSpacing="3" DataKeyNames="Måndag,Tisdag,Onsdag,Torsdag,Fredag,Lördag,Söndag">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" Font-Underline="False" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
