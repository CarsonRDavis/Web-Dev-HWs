<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="summary.aspx.cs" Inherits="hw03_davis.summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summary</title>
    <style>
        .left{
            float:left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Ticket Holders for
                <asp:Label ID="lblEventName" runat="server" ForeColor="Red"></asp:Label>
            </h2>

                <div class="left">
                    <asp:Button ID="btnPurchaseTickets" runat="server" Text="Purchase More Tickets" OnClick="btnPurchaseTickets_Click" />
                &nbsp;Sort:</div>

                <asp:RadioButtonList ID="rblSort" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rblSort_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Selected="True" Value="0">Order Purchased</asp:ListItem>
                    <asp:ListItem Value="1">Name</asp:ListItem>
                    <asp:ListItem Value="2">Seat</asp:ListItem>
                </asp:RadioButtonList>

            <br />
            Remove Ticket Holder: <asp:DropDownList ID="ddlAttendees" runat="server">
            </asp:DropDownList>
&nbsp;<asp:Button ID="btnRemove" runat="server" Text="Remove" OnClick="btnRemove_Click" />
            <br />
            <br />

            <asp:TextBox ID="tbxDisplay" runat="server" Height="236px" Width="461px" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
</body>
</html>
