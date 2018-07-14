<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Bank_Web.Home" MasterPageFile="~/BankMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

    <div style="height: 507px">
        <br />
        <br />
        <asp:Menu ID="HomeMenu" runat="server" Orientation="Horizontal" CssClass="menu" Font-Names="Segoe UI" OnMenuItemClick="Menu1_MenuItemClick">
            <Items>
                <asp:MenuItem Text="Home" NavigateUrl="Home.aspx" />
                <asp:MenuItem Text="Contact us" NavigateUrl="ContactUs.aspx" />
                <asp:MenuItem Text="About us" NavigateUrl="AboutUs.aspx" />
            </Items>
        </asp:Menu>
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
        &nbsp;
            <br />
        &nbsp;&nbsp;
            <asp:GridView ID="gridAccountBalances" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridAccountBalances_RowCommand">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="SelectAccount"  Text="Select Account"  />
                </Columns>
            </asp:GridView>
        &nbsp;<br />
        &nbsp;&nbsp;&nbsp;
            <br />
        &nbsp;&nbsp;&nbsp;
            <br />
        <br />
        <table style="width: 34%; height: 145px; margin-left: 24px; margin-top: 2px;">
            <tr>
                <td>
                    <asp:DropDownList ID="dropAccountList" runat="server" Width="350px" InitialValue="-1" OnSelectedIndexChanged="dropAccountList_SelectedIndexChanged" DataTextField="SelectAccountDropList">
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
</asp:Content>
