<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Bank_Web.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 507px">
            <img alt="" draggable="auto" src="images/YESBANKLOGO.jpg" style="width: 1053px; height: 103px; position: relative;" /><br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblWelcome" runat="server" Enabled="False" Text="Welcome "></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblOptions" runat="server" Text="Please choose from the following options:"></asp:Label>
            <br />
            <br />
            <table style="width: 34%; height: 145px; margin-left: 24px; margin-top: 2px;">
                <tr>
                    <td>
                        <asp:Button ID="btnChecking" runat="server" BackColor="#99CCFF" Text="Checking" Width="351px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSaving" runat="server" BackColor="#99CCFF" Text="Savings" Width="351px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLoan" runat="server" BackColor="#99CCFF" Text="Loan" Width="351px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
