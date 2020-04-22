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

        protected void BApply_Click(object sender, EventArgs e)
        {
            //Get all form data
            String firstName = TxtFirstName.Text;
            String lastName = TxtLastName.Text;
            String address = TxtAddress.Text;
            String previousJob = TxtPreviousJob.Text;
            int phoneNumber = int.Parse(TxtPhone.Text);
            String email = TxtEmail.Text;



        }
    }
}