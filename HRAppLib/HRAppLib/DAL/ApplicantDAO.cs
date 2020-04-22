using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAppLib.DAL.LibDSTableAdapters;

namespace HRAppLib.DAL
{
    public class ApplicantDAO
    {
        private LibDS _libDS = new LibDS();
        private ApplicantsTableAdapter _appTA = new ApplicantsTableAdapter();
        private DepartmentsTableAdapter departmentsTableAdapter = new DepartmentsTableAdapter();

         public void AddEmployeeRecord(string firstName, string lastName, string role, bool isEmployed, float hourlySalary, int department, int resumeID, string email, string phone)
        {
            _appTA.Insert(firstName,  lastName,  role, hourlySalary, resumeID, isEmployed, email, phone, department);
        }
            }
}
