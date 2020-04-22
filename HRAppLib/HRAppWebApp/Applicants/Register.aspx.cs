using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HRAppWebApp.Applicants
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BRegister_Click(object sender, EventArgs e)
        {
            String firstName = TxtFirstName.Text;
            String lastName = TxtLastName.Text;
            String email = TxtEmail.Text;
            String userName = TxtUsername.Text;
            String password = TxtPassword.Text;

            //Create Appicant Object
            //Push applicant data into database
        }
    }
}