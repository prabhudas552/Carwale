<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:radiobuttonlist id="calcType" runat="server">
            <asp:ListItem Text="Integer" Selected="True" Value="int"></asp:ListItem>
            <asp:ListItem Text="Binary" Value="bin"></asp:ListItem>
            <asp:ListItem Text="String" Value="string"></asp:ListItem>
        </asp:radiobuttonlist>
        <p><label>Input A: </label><input id="inp_a" runat="server"/></p>
        <p><label>Input B: </label><input id="inp_b" runat="server"/></p>
        <b><label id="output" runat="server">-</label></b>
        <p>
            <asp:button runat="server" id="add" Text="Add"/>
            <asp:button runat="server" id="sub" Text="Sub"/>
        </p>
        <p>
            <asp:button runat="server" id="mul" Text="Mul"/>
            <asp:button runat="server" id="div" Text="Div"/>
        </p>
    </form>
</body>
</html>
