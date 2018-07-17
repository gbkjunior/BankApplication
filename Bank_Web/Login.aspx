<%@ Page Title="" Language="C#" MasterPageFile="~/BankMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bank_Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <style type="text/css">
    .auto-style9 {
        width: 212px;
    }
    .auto-style10 {
        width: 148px;
    }
    .auto-style11 {
        width: 356px;
    }
    .auto-style12 {
        width: 100%;
        height: 768px;
        background-image: url('images/Login-Landing%20page/Group%2026.png');
    }
    .auto-style13 {
        margin-left: 24px;
    }
    .auto-style14 {
        width: 356px;
        height: 55px;
    }
    .auto-style15 {
        width: 100%;
        margin-bottom: 0px;
    }
    .auto-style17 {
        margin-left: 26px;
    }
        .auto-style25 {
            width: 322px;
        margin-left: 5px;
    }
        .auto-style35 {
            width: 356px;
            height: 47px;
        }
        .auto-style42 {
            width: 100%;
            height: 140px;
        }
        .auto-style43 {
            
            width: 165px;
            height: 24px;
        }
        .auto-style44 {
            width: 353px;
            height: 24px;
        }
        .auto-style45 {
            height: 24px;
            width: 237px;
        }
        .auto-style51 {
            height: 24px;
        }
        .auto-style52 {
            width: 165px;
        height: 44px;
    }
        .auto-style53 {
            width: 353px;
        height: 44px;
    }
        .auto-style54 {
            width: 237px;
        height: 44px;
    }
    .auto-style55 {
        height: 44px;
    }
    .auto-style56 {
        width: 165px;
        height: 54px;
    }
    .auto-style57 {
        width: 353px;
        height: 54px;
    }
    .auto-style58 {
        width: 237px;
        height: 54px;
    }
    .auto-style59 {
        height: 54px;
    }
    .auto-style60 {
        width: 165px;
        height: 37px;
    }
    .auto-style61 {
        width: 353px;
        height: 37px;
    }
    .auto-style62 {
        width: 237px;
        height: 37px;
    }
    .auto-style63 {
        height: 37px;
    }
    .auto-style65 {
        width: 165px;
        height: 44px;
        font-family: "segoe UI", Tahoma, Geneva, Verdana, sans-serif;
        color: white;
    }
    .auto-style66 {
        margin-left: 1px;
        margin-top: 7px;
        margin-bottom: 9px;
    }
    .auto-style67 {
        margin-top: 3px;
    }
    .auto-style68 {
        margin-left: 5px;
        margin-top: 3px;
    }
        .auto-style71 {
            width: 165px;
            height: 17px;
            font-family: "segoe UI", Tahoma, Geneva, Verdana, sans-serif;
            color: white;
        }
        .auto-style72 {
            width: 353px;
            height: 17px;
        }
        .auto-style73 {
            height: 17px;
            width: 237px;
        }
        .auto-style74 {
            height: 17px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="c1" runat="server">

    <div class="auto-style12" style="background-image: url('images/Login-Landing%20page/Group%2026.png'); display: block; ">


        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style10">


        <asp:Label ID="lblCustomer" runat="server" Text="Customer ID:" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style9">
            <asp:TextBox ID="txtCustomerID" runat="server" Width="186px" Height="19px" CssClass="offset-sm-0"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCustomerID" ErrorMessage="Please enter customerID" ForeColor="Red" ValidationGroup="valGroupLogin">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
        <asp:Label ID="lblPassword" runat="server" ForeColor="White" Text="Password:"></asp:Label>
                </td>
                <td class="auto-style9">
            <asp:TextBox ID="txtPassword" runat="server" Height="19px" Width="186px" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage=" Please enter password" ForeColor="Red" ValidationGroup="valGroupLogin">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <table class="auto-style15">
            <tr>
                <td class="auto-style11">
        
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Please Enter valid customer ID value" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
        <asp:Button ID="btnLogin" runat="server" BackColor="#99CCFF" Height="40px" OnClick="btnLogin_Click" Text="Login" Width="232px" CssClass="auto-style13" ValidationGroup="valGroupLogin" />
                </td>
            </tr>
            <tr>
                <td class="auto-style35">
                    <asp:Button ID="btnRegister" runat="server" Height="35px" OnClick="btnRegister_Click" Text="Register" Width="232px" BackColor="#99CCFF" CssClass="auto-style17" CausesValidation="False" ValidationGroup="valGroupRegister" />
                    <br />
                </td>
            </tr>
        </table>
        <asp:MultiView ID="RegisterView" runat="server" OnActiveViewChanged="RegisterView_ActiveViewChanged" ActiveViewIndex="-1">
            <asp:View ID="viewSuccessRegister" runat="server">
                <asp:Label ID="lblSuccessRegister" runat="server" Text="You have successfully registered,  " Visible="False" Font-Names="Segoe UI" ForeColor="White"></asp:Label>
            </asp:View>
            <br />
            <asp:View ID="viewRegister" runat="server">
                <table class="auto-style42">
                    <tr>
                        <td class="auto-style43" style="color: #FFFFFF; font-family: 'segoe UI', Tahoma, Geneva, Verdana, sans-serif">Full Name:</td>
                        <td class="auto-style44">
                            &nbsp;<asp:TextBox ID="txtCustName" runat="server" CssClass="auto-style66" Height="20px" Width="320px"></asp:TextBox>
                            <br />
                        </td>
                        <td class="auto-style45">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter Customer Name" ForeColor="Red" ControlToValidate="txtCustName" ValidationGroup="valGroupRegister">*</asp:RequiredFieldValidator>
                        </td>
                        <td class="auto-style51">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style60" style="color: #FFFFFF; font-family: 'segoe UI', Tahoma, Geneva, Verdana, sans-serif">Email ID:</td>
                        <td class="auto-style61">&nbsp;<asp:TextBox ID="txtCustEmail" runat="server" CssClass="auto-style67" Width="320px"></asp:TextBox>
                            <br />
                        </td>
                        <td class="auto-style62">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCustEmail" ErrorMessage="Please enter email ID" ForeColor="Red" ValidationGroup="valGroupRegister">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtCustEmail" ErrorMessage="Enter Valid Email Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="valGroupRegister"></asp:RegularExpressionValidator>
                        </td>
                        <td class="auto-style63"></td>
                    </tr>
                    <tr>
                        <td class="auto-style65">Password:</td>
                        <td class="auto-style53">
                            <asp:TextBox ID="txtCustPassword" runat="server" CssClass="auto-style68" TextMode="Password" Width="320px"></asp:TextBox>
                            &nbsp;<br />
                        </td>
                        <td class="auto-style54">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter Customer Name" ForeColor="Red" ControlToValidate="txtCustPassword" ValidationGroup="valGroupRegister">*</asp:RequiredFieldValidator>
                            &nbsp;</td>
                        <td class="auto-style55">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style65">Confirm Password:</td>
                        <td class="auto-style53">
                            <asp:TextBox ID="txtCustConfirmPass" runat="server" CssClass="auto-style68" Width="320px" TextMode="Password"></asp:TextBox>
                        </td>
                        <td class="auto-style54">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter Customer Name" ForeColor="Red" ControlToValidate="txtCustConfirmPass" ValidationGroup="valGroupRegister">*</asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="txtCustConfirmPass" ControlToValidate="txtCustPassword" ErrorMessage="Passwords do not match" ForeColor="Red" ValidationGroup="valGroupRegister"></asp:CompareValidator>
                        </td>
                        <td class="auto-style55">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style71">Date of Birth:</td>
                        <td class="auto-style72">
                            <asp:TextBox ID="txtCustDOB" runat="server" CssClass="auto-style68" TextMode="Date" Width="320px"></asp:TextBox>
                            &nbsp;&nbsp;</td>
                        <td class="auto-style73">
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtCustDOB" ErrorMessage="Please enter a valid date " ForeColor="Red" MaximumValue="2001/01/01" MinimumValue="1900/01/01" ValidationGroup="valGroupRegister"></asp:RangeValidator>
                        </td>
                        <td class="auto-style74"></td>
                    </tr>
                    <tr>
                        <td class="auto-style52" style="font-family: 'segoe UI', Tahoma, Geneva, Verdana, sans-serif; color: white;">Telephone:</td>
                        <td class="auto-style53">
                            &nbsp;<asp:TextBox ID="txtCustTelephone" runat="server" CssClass="auto-style68" Height="21px" Width="320px"></asp:TextBox>
                        </td>
                        <td class="auto-style54">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCustTelephone" ErrorMessage="Please enter valid number" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ValidationGroup="valGroupRegister"></asp:RegularExpressionValidator>
                        </td>
                        <td class="auto-style55">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style56" style="font-family: 'segoe UI', Tahoma, Geneva, Verdana, sans-serif; color: white;">Address:</td>
                        <td class="auto-style57">
                            <textarea id="txtCustAddress" class="auto-style25" cols="20" name="S1" rows="2"></textarea></td>
                        <td class="auto-style58"></td>
                        <td class="auto-style59"></td>
                    </tr>
                    <tr>
                        <td class="auto-style56" style="font-family: 'segoe UI', Tahoma, Geneva, Verdana, sans-serif; color: white;">&nbsp;</td>
                        <td class="auto-style57">&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnAddCustomer" runat="server" BackColor="#99CCFF" CausesValidation="False" OnClick="btnAddCustomer_Click" Text="Submit" Width="135px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCancel0" runat="server" BackColor="#99CCFF" CausesValidation="False" OnClick="btnCancel_Click" Text="Cancel" Width="135px" />
                        </td>
                        <td class="auto-style58">&nbsp;</td>
                        <td class="auto-style59">&nbsp;</td>
                    </tr>
                </table>
            </asp:View>

            <br />
            
            <br />
        </asp:MultiView>
        <br />
        &nbsp;
                            <br />

    </div>
</asp:Content>
