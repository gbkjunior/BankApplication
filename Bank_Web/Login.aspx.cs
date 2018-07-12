using BankingApplication_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Web
{
    public partial class Login : System.Web.UI.Page
    {
        int customerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string custID = txtCustomerID.Text;
            bool checkCustID = int.TryParse(custID, out int custIDValue);
            if (!checkCustID)
            {
                lblError.Visible = true;
            }
            else
            {
                var objCustomerBLL = new Customers_BLL();

                bool checkCust = objCustomerBLL.validateCustomer(custIDValue);
                if (checkCust)
                {
                    customerID = Convert.ToInt32(txtCustomerID.Text);
                    Session["CustomerID"] = customerID;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblError.Text = "Your customerID is not found. Please try again!";
                    lblError.Visible = true;
                }
            }
        }

        protected void LoginView1_ViewChanged(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            RegisterView.SetActiveView(viewRegister);
        }

        protected void RegisterView_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        public string DataToSend
        {
            get
            {
                return txtCustomerID.Text;
            }
            
        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string custName = Request.Form["txtCustName"];
            string custAddress = Request.Form["txtCustAddress"];
            string custTelephone = Request.Form["txtCustTelephone"];
            if(custName == "")
            {
                lblErrorName.Visible = !lblErrorName.Visible;
            }
            else
            {
                var objCustomerBLL = new Customers_BLL();

                int custID = objCustomerBLL.AddNewCustomer(custName, custAddress, custTelephone);
                RegisterView.Views.Remove(viewRegister);

                RegisterView.SetActiveView(viewSuccessRegister);
                lblSuccessRegister.Text = lblSuccessRegister.Text +custName+ ". Your customerID is" + custID + ".";
                lblSuccessRegister.Visible = true;
                btnLogin.Enabled = true;
            }
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            viewRegister.EnableViewState = false;
            RegisterView.ActiveViewIndex = 0;
        }

        public int GetCustomerID()
        {
            return this.customerID;
        }
    }
}