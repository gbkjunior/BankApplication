using BankingApplication_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}