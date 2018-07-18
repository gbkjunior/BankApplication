<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Bank_Web.Account"  MasterPageFile="~/BankMaster.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <style type="text/css">
    .auto-style10 {
        margin-left: 21px;
    }
    .auto-style11 {
        width: 462px;
    }
    .auto-style12 {
        width: 176px;
    }
    .auto-style13 {
        height: 260px;
    }
    .auto-style14 {
        width: 298px;
        height: 260px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

        <div>
            </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table style="width: 100%;">
    <tr>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style12"><asp:Button ID="btnShowTrans" runat="server" BackColor="#99CCFF" OnClick="btnShowTrans_Click" Text="Hide Transactions" Width="171px" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
<br />
&nbsp; &nbsp;&nbsp;&nbsp;<table style="width: 100%;">
    <tr>
        <td class="auto-style13"></td>
        <td class="auto-style14">
        <asp:GridView ID="gridTransactions" runat="server" AllowPaging="True" OnPageIndexChanging="gridTransactions_SelectedIndexChanged" PageSize="5" CssClass="auto-style10">
            <HeaderStyle BackColor="Black" Font-Names="Segoe UI" ForeColor="White" />
        </asp:GridView>
        </td>
        <td class="auto-style13"></td>
    </tr>
</table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
  </asp:Content>