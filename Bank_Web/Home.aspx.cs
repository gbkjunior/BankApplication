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
            //session verify if it has an ID or not, if not , redirect to the login

            var objCustomerBLL = new Customers_BLL();
            int selectedCustomerID = (int)Session["CustomerID"];

            lblWelcome.Text = "Welcome " + objCustomerBLL.GetCustomerName(selectedCustomerID);
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //clear the customerIdsession
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