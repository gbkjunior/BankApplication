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
            switch (HomeMenu.SelectedItem.Text)
            {
                case "Login": Panel loginPanel = c1.FindControl("pnlLogin") as Panel;
                    loginPanel.Visible = true;
                    break;
                case "Log Out":
                    Session["CustomerID"] = null;
                    //clear the customerIdsession
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/Login.aspx");
                    break;
                case "Register": MultiView mview = c1.FindControl("RegisterView") as MultiView;
                    View view = c1.FindControl("viewRegister") as View;
                    mview.ActiveViewIndex = 0;
                    
                    mview.SetActiveView(view);
                    break;
            }
        }
    }
}