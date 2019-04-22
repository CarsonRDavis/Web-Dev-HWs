<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="hw02._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HW02 - Carson Davis</title>
    <style>
        .leftAlign{
            float:left;
        }
        .auto-style1 {
            float: left;
            width: 141px;
            height: 231px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div aria-sort="none">
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="timeLog.aspx">Time Log</asp:HyperLink>
            <br />
            <h2>Course Registration System</h2>
            <asp:CheckBoxList ID="cblExtras" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="1000">Dorm</asp:ListItem>
                <asp:ListItem Value="500">Meal Plan</asp:ListItem>
                <asp:ListItem Value="50">Football Tickets</asp:ListItem>
            </asp:CheckBoxList>
            <br />

            <div class="leftAlign">
                Available Classes
                <br />
                <asp:ListBox ID="lbxAvailableClasses" runat="server" Height="213px" Width="138px" SelectionMode="Multiple"></asp:ListBox>
            </div>

            <div class="auto-style1">
                <br />
                <br />
                <br />
                &nbsp;
                <br />
                &nbsp;
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click1" Text="Add" CausesValidation="False" />
                <br />
                &nbsp;
                <asp:Button ID="btnRemove" runat="server" Text="Remove" OnClick="btnRemove_Click" CausesValidation="False" />
                <br />
                &nbsp;
                <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" CausesValidation="False" />
                <br />
                &nbsp;
                Total Hours: <asp:Label ID="lblHours" runat="server"></asp:Label>
                <br />
                &nbsp;
                Total Cost:
                <asp:Label ID="lblCost" runat="server"></asp:Label>
            </div>

            <div>
                Registered Classes<br />
                <asp:ListBox ID="lbxRegisteredClasses" runat="server" Height="213px" Width="138px" SelectionMode="Multiple"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;
            </div>

            <asp:Label ID="lblError1" runat="server" ForeColor="Red"></asp:Label>
            <br />
            Class Number: <asp:TextBox ID="tbxClassNumber" runat="server"></asp:TextBox>
            &nbsp;Credits:
            <asp:TextBox ID="tbxCredits" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnMakeAvailable" runat="server" Text="Make Available" OnClick="btnMakeAvailable_Click" />
            &nbsp;<asp:Button ID="btnRemoveAvailable" runat="server" Text="Remove from Available" OnClick="btnRemoveAvailable_Click" />
            <br />
            <asp:Label ID="lblError2" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbxCredits" ErrorMessage="Credits must be between 1 and 10 inclusive" ForeColor="Red" MaximumValue="10" MinimumValue="1" Type="Integer"></asp:RangeValidator>
            <br />
        </div>
    </form>
</body>
</html>
