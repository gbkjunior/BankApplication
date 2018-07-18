using BankingApplication_BLL;
using BankingApplication_BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Web
{
    public partial class Home : System.Web.UI.Page
    {
        public static string commandName;
        public static int commandIndex;
        public static int selectedAccountID;
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
                    else if (mi.Value == "register")
                        mi.Text = "";
                }
            }
            

            
            Session["selectedAccountID"] = null;
            //session verify if it has an ID or not, if not , redirect to the login
            if (String.IsNullOrEmpty(Session["CustomerID"]+ ""))
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                var objCustomerBLL = new Customers_BLL();
                var objTransactionsBLL = new Transactions_BLL();
                int selectedCustomerID = (int)Session["CustomerID"];

                //List<Transactions> lstAccountBalances;
                //lstAccountBalances = objTransactionsBLL.GetAllAccountBalances(selectedCustomerID);
                List<double> lstBalance = new List<double>();
                for(int i = 1; i < 4; i++)
                {
                    lstBalance.Add(objTransactionsBLL.GetBalance(selectedCustomerID, i));
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("Account Type");
                dt.Columns.Add("Balance");

                dt.Rows.Add("Checking");
                dt.Rows.Add("Savings");
                dt.Rows.Add("Loan");

                for (int i = 0; i< lstBalance.Count;i++)
                {
                    dt.Rows[i]["Balance"] = lstBalance[i];
                }
                lblWelcome.Text = "Welcome " + objCustomerBLL.GetCustomerName(selectedCustomerID);

                gridAccountBalances.DataSource = dt;
                gridAccountBalances.DataBind();
            }
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["CustomerID"] = null;
            //clear the customerIdsession
            FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }

        

        

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void GridAccountBalances_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if(e.CommandName=="SelectAccount")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                switch (index)
                {
                    case 0: Session["selectedAccountID"] = 1;
                        break;
                    case 1: Session["selectedAccountID"] = 2;
                        break;
                    case 2: Session["selectedAccountID"] = 3;
                        break;
                }
                // Retrieve the row that contains the button 
                // from the Rows collection.
                Response.Redirect("Account.aspx");
            }
            else if (e.CommandName == "Deposit")
            {
                commandName = "Deposit";
                commandIndex = Convert.ToInt32(e.CommandArgument);
                switch (commandIndex)
                {
                    case 0:
                        selectedAccountID = 1;
                        break;
                    case 1:
                        selectedAccountID = 2;
                        break;
                    case 2:
                        selectedAccountID = 3;
                        break;
                }
                txtInput.Visible = true;
                btnSubmitAmount.Visible = true;
                btnCancelInput.Visible = true;
            }
            else if (e.CommandName == "Withdraw")
            {
                commandName = "Withdraw";
                commandIndex = Convert.ToInt32(e.CommandArgument);
                
                switch (commandIndex)
                {
                    case 0:
                        selectedAccountID = 1;
                        PassToSubmitClick(e);
                        break;
                    case 1:
                        selectedAccountID = 2;
                        break;
                    case 2:
                        selectedAccountID = 3;
                        break;
                }
                txtInput.Visible = true;
                btnSubmitAmount.Visible = true;
                btnCancelInput.Visible = true;

                
            }
        }

        protected void DepositAmount(int index)
        {

        }

        protected void btnSubmitAmount_Click(object sender, EventArgs ee)
        {
            string amt = txtInput.Text;
            bool checkAmt = double.TryParse(amt, out double amtValue);
            if (checkAmt)
            {
                int selectedCustomerID = (int)Session["CustomerID"];
                var objTransactionsBLL = new Transactions_BLL();


                
                if(commandName == "Deposit")
                {
                    objTransactionsBLL.Deposit(selectedCustomerID, selectedAccountID, amtValue);
                }
                else if(commandName == "Withdraw")
                {
                    objTransactionsBLL.Withdraw(selectedCustomerID, selectedAccountID, amtValue);
                }
                //if (gvr.NamingContainer.FindControl("Withdraw"))
                //{
                //    objTransactionsBLL.Withdraw(selectedCustomerID, selectedAccountID, amtValue);
                //}
                //else if (row.Cells[1].Text == "Deposit")
                //{
                //    objTransactionsBLL.Deposit(selectedCustomerID, selectedAccountID, amtValue);
                //}





            }
        }

        protected void btnCancelInput_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtInput.Visible = false;
            btnSubmitAmount.Visible = false;
            btnCancelInput.Visible = false;
        }

        protected void PassToSubmitClick(GridViewCommandEventArgs e)
        {

        }

        protected void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}