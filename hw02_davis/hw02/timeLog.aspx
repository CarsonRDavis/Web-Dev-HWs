<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="timeLog.aspx.cs" Inherits="hw02.timeLog" %>

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
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="default.aspx">Back</asp:HyperLink>
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
                    <td>18 Feb, 19</td>
                    <td>4:00pm to 5:00pm</td>
                    <td>1</td>
                    <td>1</td>
                </tr>
                <tr>
                    <td>19 Feb, 19</td>
                    <td>8:00am to 10:00am</td>
                    <td>2</td>
                    <td>3</td>
                </tr>
                <tr>
                    <td>20 Feb, 19</td>
                    <td>8:00am to 11:00am</td>
                    <td>3</td>
                    <td>6</td>
                </tr>
                <tr>
                    <td>23 Feb, 19</td>
                    <td>12:00pm to 3:00am</td>
                    <td>3</td>
                    <td>9</td>
                </tr>
                <tr>
                    <td>25 Feb, 19</td>
                    <td>2:30pm to 3:30pm</td>
                    <td>1</td>
                    <td>10</td>
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
        </div>
    </form>
</body>
</html>
