﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hw05.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HW 05</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            border-style: solid;
            border-width: 1px;
        }
        .auto-style2 {
            font-size: small;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>HW 5 - Properties</h2>
    <p> <a href="Patients1.aspx">Patients 1</a>
		<a href="Patients2.aspx">Patients 2</a>
		<a href="Patients3.aspx">Patients 3</a>
        <asp:HyperLink ID="timeLog" runat="server" NavigateUrl="timeLog.aspx">Time Log</asp:HyperLink>
    </p>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <p>
                    <table class="auto-style1">
                        <tr>
                            <td>Num Properties: </td>
                            <td>
                                <asp:Label ID="lblNumProperties" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Avg Price:</td>
                            <td>
                                <asp:Label ID="lblAveragePrice" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Num Above Avg: </td>
                            <td>
                                <asp:Label ID="lblNumAboveAvgPrice" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </p>
                <p>
                    Sort:<asp:RadioButtonList ID="rblSortType" runat="server" AutoPostBack="True" onSelectedindexchanged="rblSortType_SelectedIndexChanged" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem Selected="True">Price</asp:ListItem>
                        <asp:ListItem>Sq. Feet</asp:ListItem>
                    </asp:RadioButtonList>
                </p>
                <p>
                    All Properties<br /> <span class="auto-style2">Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sq.Feet&nbsp; Beds&nbsp; Baths&nbsp; Year Built&nbsp; $/Sq.Foot</span><br class="auto-style2" />
                    <asp:TextBox ID="txtProperties" runat="server" Height="232px" TextMode="MultiLine" Width="455px"></asp:TextBox>
                    <br />
                    <br />
                    Debug Info<br />
                    </p>
            
                <p>
                    <asp:TextBox ID="txtMsg" runat="server" Height="232px" TextMode="MultiLine" Width="503px"></asp:TextBox>
                </p>
            
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
