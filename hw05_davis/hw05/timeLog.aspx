<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="timeLog.aspx.cs" Inherits="hw05.timeLog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Time Log</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Default.aspx">Home Page</asp:HyperLink>
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
                    <td>10 Apr, 2019</td>
                    <td>1:30 to 4:30</td>
                    <td>3</td>
                    <td>3</td>
                </tr>
                <tr>
                    <td>13 Apr, 2019</td>
                    <td>12:00pm to 5:00pm</td>
                    <td>5</td>
                    <td>8</td>
                </tr>
                <tr>
                    <td>14 Apr, 2019</td>
                    <td>3:00pm to 5:00pm</td>
                    <td>2</td>
                    <td>10</td>
                </tr>
                <tr>
                    <td>15 Apr, 2019</td>
                    <td>3:00pm to 5:30pm</td>
                    <td>2.5</td>
                    <td>12.5</td>
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
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
