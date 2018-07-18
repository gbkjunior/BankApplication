using BankingApplication_BLL;
using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Data;
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
            if (Session["CustomerID"] != null)
            {
                var menu = Master.FindControl("HomeMenu") as Menu;

                foreach (MenuItem mi in menu.Items)
                {
                    if (mi.Value == "login")
                    {
                        mi.Text = "Log Out";
                    }
                }
            }
            //int custID = (int)Session["CustomerID"];
            if (!(String.IsNullOrEmpty(Session["selectedAccountID"] + "") || String.IsNullOrEmpty(Session["CustomerID"] + "")))
            {
                int selectedAccount = (int)Session["selectedAccountID"];
                int custID = (int)Session["CustomerID"];
                Login objLogin = new Login();
                var objTransactionBLL = new Transactions_BLL();
                var objAccountsBLL = new Accounts_BLL();
                
                double getBalanceValue = objAccountsBLL.GetBalance(custID, selectedAccount);
                //string acctType = objAccountsBLL.GetAccountTypeByID(selectedAccount).GetAccountType().ToString();
                //lblCheckAccBalance.Text = lblCheckAccBalance.Text + " " + acctType + " Account balance is: " + getBalanceValue + " ";
                GetDataTableData();
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void gridTransactions_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
        {
            gridTransactions.PageIndex = e.NewPageIndex;
            Page_Load(sender, e);
        }

        protected void btnShowTrans_Click(object sender, EventArgs e)
        {
            
            gridTransactions.Visible = !gridTransactions.Visible;
            if (!gridTransactions.Visible)
            {
                btnShowTrans.Text = "Show Transactions";
            }
            else
                btnShowTrans.Text = "Hide Transactions";
        }

        protected List<Transactions> GetTransList()
        {
            int selectedCustomerID = (int)Session["CustomerID"];
            int selectedAccount = (int)Session["selectedAccountID"];

            List<Transactions> lstTransactions = new List<Transactions>();
            List<String> lstNewTransactions = new List<String>();
            var objTransactionsBLL = new Transactions_BLL();
            lstTransactions = objTransactionsBLL.GetTransactionsByID(selectedCustomerID, selectedAccount);
            foreach(var i in lstTransactions)
            {
                lstNewTransactions.Add(i.GetTransactionType().ToString());
                lstNewTransactions.Add(i.GetDate().ToString());
            }
            return lstTransactions;
        }

        protected void GetDataTableData()
        {

            //gridTransactions.DataSource = GetTransList().ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Account Type");
            dt.Columns.Add("Transaction Type");
            dt.Columns.Add("Transaction Date");
            dt.Columns.Add("Amount");

            foreach (var i in GetTransList())
            {
                dt.Rows.Add(i.GetAccountType(), i.GetTransactionType(), i.GetDate(), i.GetAmount());
            }
            gridTransactions.DataSource = dt;
            gridTransactions.DataBind();

        }
    }
}