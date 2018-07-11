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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogout" runat="server" BackColor="#99CCFF" OnClick="btnLogout_Click" Text="Log Out" Width="87px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblOptions" runat="server" Text="Please choose from the following options:"></asp:Label>
            <br />
            <br />
            <table style="width: 34%; height: 145px; margin-left: 24px; margin-top: 2px;">
                <tr>
                    <td>
                        <asp:DropDownList ID="dropAccountList" runat="server" Width="350px" InitialValue ="-1" OnSelectedIndexChanged="dropAccountList_SelectedIndexChanged" DataTextField="SelectAccountDropList">
                            <asp:ListItem>--Select Account--</asp:ListItem>
                            <asp:ListItem>Checking Account</asp:ListItem>
                            <asp:ListItem>Saving Account</asp:ListItem>
                            <asp:ListItem>Loan Account</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSubmitAccount" runat="server" BackColor="#99CCFF" OnClick="btnSubmitAccount_Click" Text="Submit" Width="157px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
