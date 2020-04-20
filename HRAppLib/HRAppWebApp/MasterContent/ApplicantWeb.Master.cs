using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HRAppWebApp.MasterContent
{
    public partial class ApplicantWeb : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Context.Request.IsAuthenticated)//gets the request status from HttpRequest
            {
                LblMessage.Text = $"Welcome {Context.User.Identity.Name}";
            }
            else
            {
                LblMessage.Text = "Welcome user";
            }
            BLogin.Visible = !Context.Request.IsAuthenticated;
            BRegister.Visible = !Context.Request.IsAuthenticated;
            BLogout.Visible = Context.Request.IsAuthenticated;
        }
        protected void OnLogin(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
        protected void OnRegister(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }
        protected void OnLogout(object sender, EventArgs e)
        {
            //removes the authentication ticket form browser, so that subsequent requests are not "authenticated"
            FormsAuthentication.SignOut();

            //Moving away from the page that is not accessible any more
            Response.Redirect("~/Application.aspx");
        }
    }
}