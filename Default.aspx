<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Växlare Gbg Schemaberäkning</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />    
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
    </div>
    <div>       
         <h2>
             Schema räknare Vxl Gbg
         </h2>
           
         <h3>
             Beräknar ditt schema beroende på vilket nyckel tal du anger och vilken dag du vill räkna från. Resultatet går att skriva ut. Klicka på beräkna eller välj Schema i menyn för att komma till räknaren. <br />
             <asp:Button ID="Button1" runat="server" CssClass="StyleSheet.css" Text="Beräkna" BorderColor="#333333" Font-Bold="True" PostBackUrl="~/SchemaCalculation.aspx" />
         </h3>       
    </div>
    </form>
    </body>
</html>
