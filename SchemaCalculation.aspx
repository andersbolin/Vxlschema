<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SchemaCalculation.aspx.cs" Inherits="SchemaCalculation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Växlare Gbg Schemaberäkning</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <ul>
        <li><a href="../Default.aspx">Home</a></li>
        <li><a href="../SchemaCalculation.aspx">Schema</a></li>
        <li><a href="../news.aspx">News</a></li>
        <li><a href="../contact.aspx">Contact</a></li>
        <li style="float:right"><a class="active" href="../about.aspx">About</a></li>
    </ul>
    <div>
        <h4>
            Schema beräknare
        </h4>
        <h5>
            Nyckeltal:  
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
            </asp:DropDownList> 
            

        </h5>
        <h5>
            Startdatum: <br />
            <asp:TextBox ID="DateTextBox" runat="server"  />
            <asp:Image ID="Image1" runat="server" ImageUrl="../jquery-ui-1.11.4.custom/images/calender.png" />
            <ajaxToolkit:CalendarExtender ID="CalendarExtender1" 
                runat="server" TargetControlID="DateTextBox" Format="yyyy-MM-dd"
                PopupButtonID="Image1">
            </ajaxToolkit:CalendarExtender> <br /> <br /><br /><br />
            Slutdatum: <br />
            <asp:TextBox ID="DateTextBox1" runat="server"  />
            <asp:Image ID="Image2" runat="server" ImageUrl="../jquery-ui-1.11.4.custom/images/calender.png" />
            <ajaxToolkit:CalendarExtender ID="CalendarExtender2" 
                runat="server" TargetControlID="DateTextBox1" Format="yyyy-MM-dd"
                PopupButtonID="Image2">
            </ajaxToolkit:CalendarExtender>
            
            
             <br /> <br />
            &nbsp;<asp:Button ID="Button1" PostBackUrl="../Schema.aspx" runat="server" Text="Beräkna" />

            <br />
            

        </h5>
    </div>
    </form>
</body>
</html>
