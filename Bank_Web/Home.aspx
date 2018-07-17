<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Bank_Web.Home" MasterPageFile="~/BankMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

    <div style="height: 507px">
        <br />
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
        &nbsp;
            <br />
        &nbsp;&nbsp;
            <asp:GridView ID="gridAccountBalances" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridAccountBalances_RowCommand">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Withdraw"  Text="Withdraw"  />
                    <asp:ButtonField ButtonType="Button" CommandName="Deposit"  Text="Deposit"  />
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
                    <asp:TextBox ID="txtInput" runat="server" Visible="False" Width="361px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;<asp:Button ID="btnSubmitAmount" runat="server" BackColor="#99CCFF" OnClick="btnSubmitAmount_Click1" Text="Submit" Visible="False" Width="109px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCancelInput" runat="server" BackColor="#99CCFF" Text="Cancel" Visible="False" Width="120px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
