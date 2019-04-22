<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="timeLog.aspx.cs" Inherits="hw03_davis.timeLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Time Log</h2>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="default.aspx">Home Page</asp:HyperLink>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>Date</td>
                    <td>Time</td>
                    <td>Hours</td>
                    <td>Total</td>
                </tr>
                <tr>
                    <td>8 Mar, 19</td>
                    <td>2:00pm to 4:00pm</td>
                    <td>2</td>
                    <td>2</td>
                </tr>
                <tr>
                    <td>11 Mar, 19</td>
                    <td>7:30pm to 8:30pm</td>
                    <td>1</td>
                    <td>3</td>
                </tr>
                <tr>
                    <td>12 Mar, 19</td>
                    <td>1:00pm to 2:00pm</td>
                    <td>1</td>
                    <td>4</td>
                </tr>
                <tr>
                    <td>13 Mar, 19</td>
                    <td>3:00pm to 4:30pm</td>
                    <td>1.5</td>
                    <td>5.5</td>
                </tr>
                <tr>
                    <td>14 Mar, 19</td>
                    <td>4:00pm to 5:30pm</td>
                    <td>1.5</td>
                    <td>7</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
