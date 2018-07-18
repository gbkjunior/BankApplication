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
            Session["CustomerID"] = null;
            lblError.Visible = false;
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string custID = txtCustomerID.Text;
            string custPassword = txtPassword.Text;

            bool checkCustID = int.TryParse(custID, out int custIDValue);
            
            if (!checkCustID && custPassword.ToString() == null)
            {
                lblError.Visible = true;
            }
            else
            {
                var objCustomerBLL = new Customers_BLL();

                bool checkCust = objCustomerBLL.validateCustomer(custIDValue, custPassword);
                if (checkCust)
                {
                    customerID = Convert.ToInt32(txtCustomerID.Text);
                    Session["CustomerID"] = customerID;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    lblError.Text = "Your customerID and password do not match. Please try again!";
                    lblError.Visible = true;
                }
            }
        }

        protected void LoginView1_ViewChanged(object sender, EventArgs e)
        {

        }

        //protected void btnRegister_Click(object sender, EventArgs e)
        //{
            
        //    btnLogin.Enabled = false;
        //    MultiViewLogin.SetActiveView(viewRegister);
        //}

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
            btnAddCustomer.CausesValidation = true;
            string custName = txtCustName.Text;
            string custEmail = txtCustEmail.Text;
            string custPassword = txtCustPassword.Text;
            string custDOB = txtCustDOB.Text;
            string custAddress = txtCustAddress.Text;
            string custTelephone = txtCustTelephone.Text;
            if(custName == "")
            {
                //lblErrorName.Visible = !lblErrorName.Visible;
            }
            else
            {
                var objCustomerBLL = new Customers_BLL();
                var objAccountsBLL = new Accounts_BLL();
                int custID = objCustomerBLL.AddNewCustomer(custName,custEmail,custPassword, custDOB, custTelephone, custAddress);

                for (int i = 1; i < 4; i++)
                    objAccountsBLL.AddCustomerAccount(custID, i, 100);

                MultiViewLogin.Views.Remove(viewRegister);

                MultiViewLogin.SetActiveView(viewSuccessRegister);
                lblSuccessRegister.Text = lblSuccessRegister.Text +custName+ ". Your customerID is" + custID + ".";
                lblSuccessRegister.Visible = true;
                btnLogin.Enabled = true;
            }
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            viewRegister.EnableViewState = false;
            MultiViewLogin.ActiveViewIndex = 0;
        }

        public int GetCustomerID()
        {
            return this.customerID;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click1(object sender, EventArgs e)
        //{
        //    pnlLogin.Visible = false;
        //}
    }
}