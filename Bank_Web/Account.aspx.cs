using BankingApplication_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Web
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int custID = (int)Session["customerID"];
            if (Session["SelectAccountDropList"] != null)
            {
                int selectedAccount = (int)Session["SelectAccountDropList"];
                Login objLogin = new Login();
                var objTransactionBLL = new Transactions_BLL();
                Console.WriteLine(custID);
                double getBalanceValue = objTransactionBLL.GetBalance(custID, selectedAccount);
                lblCheckAccBalance.Text = lblCheckAccBalance.Text + "" + getBalanceValue + "";
            }
        }
    }
}