using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRAppWebApp
{
    public partial class ResumeUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.Request.IsAuthenticated)//gets the request status from HttpRequest
            {
                Response.Redirect("~/Applicants/Login.aspx");
            }

            //If resume exists for the user then fill each form input with data from database
            //This was user can edit existing resume data

            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtAddress.Text = "";
            TxtPreviousJob.Text = "";
            TxtExperience.Text = "";
            TxtSkills.Text = "";
            TxtEmail.Text = "";
            TxtPhone.Text = "";


        }
    }
}