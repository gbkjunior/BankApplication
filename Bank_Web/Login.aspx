﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bank_Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 757px;
        }
        .auto-style1 {
            width: 296px;
        }
        .auto-style2 {
            width: 311px;
        }
        #Text1 {
            width: 265px;
            margin-left: 0px;
        }
        .auto-style3 {
            width: 292px;
        }
        #Text2 {
            width: 265px;
            margin-left: 0px;
        }
        #Text3 {
            width: 265px;
            margin-left: 0px;
        }
        #txtCustName {
            width: 323px;
            height: 26px;
            margin-top: 0px;
        }
        #txtCustAddress {
            width: 316px;
            height: 28px;
            margin-left: 0px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
        #txtCustTelephone {
            width: 320px;
            height: 25px;
            margin-top: 0px;
        }
        #txtCustName0 {
            width: 323px;
            height: 26px;
            margin-top: 15px;
        }
        #txtCustAddress0 {
            width: 316px;
            height: 44px;
            margin-left: 0px;
            margin-top: 17px;
            margin-bottom: 0px;
        }
        #txtCustTelephone0 {
            width: 320px;
            height: 25px;
            margin-top: 13px;
        }
        .auto-style4 {
            width: 292px;
            height: 86px;
        }
        .auto-style6 {
            width: 292px;
            height: 96px;
        }
        .auto-style7 {
            height: 96px;
        }
        .auto-style8 {
            height: 86px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 965px">

            <br />
            <br />
            <img alt="" draggable="auto" src="images/YESBANKLOGO.jpg" style="width: 1053px; height: 103px; position: relative;" /><br />
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
    </form>
</body>
</html>
