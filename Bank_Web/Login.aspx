
<%@ Page Title="" Language="C#" MasterPageFile="~/BankMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bank_Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

        <div style="height: 965px">

           
            <br />
            <br />

           
            <asp:Label ID="lblCustomer" runat="server" Text="Customer ID:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server" Width="186px" Height="19px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Please Enter valid customer ID value" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <table style="width: 100%; height: 164px;">
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnLogin" runat="server" BackColor="#99CCFF" Height="40px" OnClick="btnLogin_Click" style="margin-left: 43px" Text="Login" Width="232px" />
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btnRegister" runat="server" Height="35px" OnClick="btnRegister_Click" style="margin-left: 43px" Text="Register" Width="232px" BackColor="#99CCFF" />
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:MultiView ID="RegisterView" runat="server" OnActiveViewChanged="RegisterView_ActiveViewChanged" ActiveViewIndex="-1">
                <asp:View ID="viewSuccessRegister" runat="server">
                    <asp:Label ID="lblSuccessRegister" runat="server" Text="You have successfully registered,  " Visible="False"></asp:Label>
                </asp:View>
                <br />
                <asp:View ID="viewRegister" runat="server">
                    <table style="width: 100%; height: 340px;">
                        <tr>
                            <td class="auto-style4">Full Name:</td>
                            <td class="auto-style8">
                                <input id="txtCustName" name="txtCustName" type="text" />
                                <br />
                                <asp:Label ID="lblErrorName" runat="server" ForeColor="Red" Text="Name field cannot be empty" Visible="False"></asp:Label>
                            </td>
                            <td class="auto-style8"></td>
                        </tr>
                        <tr>
                            <td class="auto-style6">Address:</td>
                            <td class="auto-style7">
                                &nbsp;<input id="txtCustAddress" name="txtCustAddress" type="text" /><br />
                            </td>
                            <td class="auto-style7"></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Telephone:</td>
                            <td>
                                <input id="txtCustTelephone" name="txtCustTelephone" type="text" />
                                <br />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnAddCustomer" runat="server" BackColor="#99CCFF" OnClick="btnAddCustomer_Click" Text="Submit" Width="135px" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnCancel" runat="server" BackColor="#99CCFF" Text="Cancel" Width="135px" OnClick="btnCancel_Click" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </asp:View>
                
                <br />
                <br />
            </asp:MultiView>
            <br />
            <br />

        </div>
   </asp:Content>