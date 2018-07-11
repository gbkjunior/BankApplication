using BankingApplication_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var objCustomerBLL = new Customers_BLL();
            
            lblWelcome.Text = "Welcome " + objCustomerBLL.GetCustomerName(Convert.ToInt32(Request.QueryString["CustomerID"]));
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }

        protected void dropAccountList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SelectAccountDropList"] = dropAccountList.SelectedIndex; 
        }

        protected void btnSubmitAccount_Click(object sender, EventArgs e)
        {

            Response.Redirect("Account.aspx");
        }
    }
}