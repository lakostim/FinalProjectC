using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HRAppLib.Entities;
using HRAppLib.DAL;

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
            String phone = "123";
            String[] mySkills = {"test"};

            //Create Appicant Object

            Resume resume = new Resume(0, firstName, lastName, "test", "test", 15, mySkills, email, phone);
            Department department = new Department(0, "none", "none");
            Applicant applicant = new Applicant(0, firstName, lastName, "test", false, 15, department, resume, email, phone);

            //Push applicant data into database

            ResumeDAO resumeDAO = new ResumeDAO();
            resumeDAO.AddResumeRecord(firstName, lastName, "test", "test", 0, mySkills, email, phone);
        }
    }
}