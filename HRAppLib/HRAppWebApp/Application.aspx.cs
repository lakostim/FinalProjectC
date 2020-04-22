using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRAppWebApp
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.Request.IsAuthenticated)//gets the request status from HttpRequest
            {
                Response.Redirect("~/Applicants/Login.aspx");
            }
            else
            {
                //dashboardTitle.Text = $"Welcome to your dashboard {Context.User.Identity.Name}";
            }
        }
    }
}