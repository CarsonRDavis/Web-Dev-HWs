<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="hw03_davis._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HW 03 - Carson Davis</title>
    <style>
        .left{
            float:left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>HW 03 - Carson Davis</h1>
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="timeLog.aspx">Time Log</asp:HyperLink>
            &nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="classDiagram.aspx">Class Diagram </asp:HyperLink>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" GroupingText="Create Event">
                <br />
                Event Name:
                <asp:TextBox ID="tbxEventName" runat="server"></asp:TextBox>
                <br />
                <br />
                Available Seat Numbers: First:
                <asp:TextBox ID="tbxFirstSeat" runat="server" Width="50px"></asp:TextBox>
                &nbsp;Last:
                <asp:TextBox ID="tbxLastSeat" runat="server" Width="50px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnMakeEvent" runat="server" Text="Make Event" OnClick="btnMakeEvent_Click" />
                &nbsp;<asp:Button ID="btnStartOver" runat="server" Text="Start Over" OnClick="btnStartOver_Click" />
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel2" runat="server" GroupingText="Purchase Ticket">
                <br />
                Name:
                <asp:TextBox ID="tbxTicketName" runat="server"></asp:TextBox>
                &nbsp;Age:
                <asp:TextBox ID="tbxTicketAge" runat="server" Width="50px"></asp:TextBox>
                <br />
                <br />
                Pick Seat:
                <asp:Label ID="lblSeatsAvailable" runat="server"></asp:Label>
                &nbsp;Avaiable<br />
                <br />
                <div class="left">
                    <asp:ListBox ID="lbxAvailableSeats" runat="server" Height="190px" Width="41px"></asp:ListBox>
                </div>
                <div class="left">
                    <br />
                    <br />
                    <br />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnPurchase" runat="server" Text="Purchase" OnClick="btnPurchase_Click" />
                    <br />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnEventSummary" runat="server" Text="Event Summary" OnClick="btnEventSummary_Click" />
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
