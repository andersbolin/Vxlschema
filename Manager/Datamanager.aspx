<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Datamanager.aspx.cs" Inherits="Manager_Datamanager" %>

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
    <h4>
        Databas Manager
    </h4>
        <h5>
            Hantera värden i databasen med att ange typ av action och sen vilka värden som skall anges. <br />
            <br />
            Typ av action:    
            <asp:DropDownList ID="DropDownList1" runat="server" Width="146px">
            <asp:ListItem Value="0">Lägg till</asp:ListItem>
            <asp:ListItem Value="1">Ta bort</asp:ListItem>
            <asp:ListItem Value="2">Ändra</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Tur nummer: <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
            <br />
            Start tid:<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
            <br />
            Slut tid:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Utför" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </h5>
    </form>
</body>
</html>
