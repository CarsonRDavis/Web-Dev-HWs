<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hw06_dgibson.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HW 06 - Patient Management System</title>
    <link href="site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>HW 6 - Your Name</h2>
        <h3>Patient Management System, <a href="hw6_gradeReport.xlsx">Grade Report</a>, <a href="hw6_timeLog.xlsx">Time Log</a></h3>

        <hr />

        <p><strong>Patients</strong></p>
        <asp:GridView ID="gvPatients" runat="server">
		</asp:GridView>
		<asp:Label ID="lblDeletePatientFailure" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button runat="server" Text="Add Patient" />
&nbsp;Last Name
        <asp:TextBox ID="txtLName" runat="server" Width="75px"></asp:TextBox>
&nbsp;First Name
        <asp:TextBox ID="txtFName" runat="server" Width="75px"></asp:TextBox>
&nbsp;Address
        <asp:TextBox ID="txtAddress" runat="server" Width="150px"></asp:TextBox>
        <br />
        <p>
            Total charges for selected patient:
            <asp:Label ID="lblTotalCharges" runat="server" Font-Bold="True" 
                ForeColor="Red" Text="Put total charges here"></asp:Label>
            <br />
        </p>
        <p>
            <strong>Visits - </strong>
            <asp:Label ID="lblPatient" runat="server" 
                Text="Put Selected Patient Name Here: LName, FName" Font-Bold="True" 
                ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:GridView ID="gvVisits" runat="server">
			</asp:GridView>
			<asp:Label ID="lblDeleteVisitFailure" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnAddVisit" runat="server" Text="Add Visit" />
            &nbsp;Date
        <asp:TextBox ID="txtDate" runat="server" Width="75px"></asp:TextBox>
            &nbsp;Charge
        <asp:TextBox ID="txtCharge" runat="server" Width="75px"></asp:TextBox>
            &nbsp;Notes
        <asp:TextBox ID="txtNotes" runat="server" Width="150px"></asp:TextBox>
        </p>
        <p>
            <strong>Prescriptions - </strong>
            <asp:Label ID="lblVisitDate" runat="server" Text="Put Selected Visit Date Here" 
                Font-Bold="True" ForeColor="Red"></asp:Label>
        </p>
        <p>
            <asp:GridView ID="gvPrescriptions" runat="server">
			</asp:GridView>
        </p>
        <p>
        <asp:Button ID="btnAddPrescriptions" runat="server" Text="Add Prescription" />
            &nbsp;Drug Name
        <asp:TextBox ID="txtDrugName" runat="server" Width="75px"></asp:TextBox>
            &nbsp;Instructions
        <asp:TextBox ID="txtInstructions" runat="server" Width="170px"></asp:TextBox>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtMsg" runat="server" Height="259px" TextMode="MultiLine" Width="698px"></asp:TextBox>
		</p>

       <hr />

        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        </div>
    </form>
</body>

</html>
