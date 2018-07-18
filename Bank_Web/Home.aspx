<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Bank_Web.Home" MasterPageFile="~/BankMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <style type="text/css">
        .auto-style10 {
        width: 493px;
    }
    .auto-style11 {
        margin-left: 0px;
    }
    .auto-style12 {
        width: 224px;
    }
    .auto-style13 {
        width: 370px;
    }
    .auto-style14 {
        width: 384px;
    }
    .auto-style15 {
        width: 487px;
    }
    .auto-style16 {
        width: 306px;
    }
    .auto-style17 {
        margin-left: 29px;
    }
    .auto-style18 {
        margin-left: 29;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

    <div style="height: 507px">
        <br />
        <br />
        
        <table style="width: 100%;">
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">
            <asp:Label ID="lblWelcome" runat="server" Enabled="False" Text="Welcome "></asp:Label>
                </td>
                <td>
            <asp:Button ID="btnLogout" runat="server" BackColor="#99CCFF" OnClick="btnLogout_Click" Text="Log Out" Width="87px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style14">
            <asp:Label ID="lblOptions" runat="server" Text="Please choose from the following options:"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        &nbsp;&nbsp;
        <br />
        &nbsp;
            <br />
        <table style="width: 100%;">
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">
        
            <asp:GridView ID="gridAccountBalances" class="gridViewAccBalances" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="GridAccountBalances_RowCommand" BackColor="White" BorderColor="#99CCFF" Font-Names="Segoe UI" ForeColor="Black" CssClass="auto-style11">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Withdraw"  Text="Withdraw"  >
                    <ControlStyle BackColor="#7A9DFF" Font-Names="Segoe UI" ForeColor="White" />
                    </asp:ButtonField>
                    <asp:ButtonField ButtonType="Button" CommandName="Deposit"  Text="Deposit"  >
                    <ControlStyle BackColor="#7A9DFF" Font-Names="Segoe UI" ForeColor="White" />
                    </asp:ButtonField>
                    <asp:ButtonField ButtonType="Button" CommandName="SelectAccount"  Text="View Transactions"  >
                    <ControlStyle BackColor="#7A9DFF" Font-Names="Segoe UI" ForeColor="White" />
                    </asp:ButtonField>
                </Columns>
                <EditRowStyle BackColor="White" />
                <HeaderStyle BackColor="Black" Font-Names="Segoe UI" ForeColor="White" />
            </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;
        &nbsp;<br />
        &nbsp;&nbsp;&nbsp;<table style="width:100%;">
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtInput" runat="server" Visible="False" Width="413px" CssClass="auto-style17" OnTextChanged="txtInput_TextChanged"></asp:TextBox>
                &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtInput" ErrorMessage="Please enter an amount value" Font-Names="Segoe UI" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtInput" ErrorMessage="Please enter a valid amount value" Font-Names="Segoe UI" ForeColor="Red" MaximumValue="999999999999999" MinimumValue="0"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                &nbsp;
                    </td>
                <td class="auto-style15">&nbsp;&nbsp;&nbsp;&nbsp; 
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style15">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnSubmitAmount" runat="server" BackColor="#99CCFF" OnClick="btnSubmitAmount_Click" Text="Submit" Visible="False" Width="117px" CssClass="auto-style18"  />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnCancelInput" runat="server" BackColor="#99CCFF" Text="Cancel" Visible="False" Width="120px" CausesValidation="False" OnClick="btnCancelInput_Click" />
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
            <br />
        &nbsp;&nbsp;&nbsp;
            <br />
        <br />
    </div>
</asp:Content>
