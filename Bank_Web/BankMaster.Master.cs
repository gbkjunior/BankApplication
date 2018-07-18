using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Web
{
    public partial class BankMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void HomeMenu_MenuItemClick(object sender, MenuEventArgs e)
        {
            MultiView mview = c1.FindControl("MultiViewLogin") as MultiView;
            switch (HomeMenu.SelectedItem.Text)
            {
                
                case "Login": View loginView =c1.FindControl("LoginView") as View;
                    mview.SetActiveView(loginView);
                    break;
                case "Log Out":
                    Session["CustomerID"] = null;
                    //clear the customerIdsession
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/Login.aspx");
                    break;
                case "Register": 
                    
                    mview.Visible = true;
                    View view = c1.FindControl("viewRegister") as View;
                    //mview.ActiveViewIndex = 0;
                    
                    mview.SetActiveView(view);
                    break;
                case "Home": Session["selectedAccountID"] = null;
                    Response.Redirect("Home.axpx");
                    break;
            }
        }
    }
}