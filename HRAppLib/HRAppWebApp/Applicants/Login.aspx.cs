using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HRAppWebApp.Applicants
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnRequestLogin(object sender, EventArgs e)
        {
            string userName = TxtUsername.Text;
            string password = TxtPassword.Text;

            //check the user name and password 
            bool isAuthenticated = (userName == "mike" && password == "");

            //if valid generate an authentication ticket and add it to response cookies
            if (isAuthenticated)
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(userName, false, 10);
                string encTicket = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                //redirect the user to an appropriate page
                FormsAuthentication.RedirectFromLoginPage(userName, false);
            }

        }
    }
}