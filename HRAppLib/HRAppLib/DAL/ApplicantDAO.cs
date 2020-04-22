using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAppLib.DAL.LibDSTableAdapters;
using HRAppLib.Entities;

namespace HRAppLib.DAL
{
    public class ApplicantDAO
    {
        private LibDS _libDS = new LibDS();
        private ApplicantsTableAdapter _appTA = new ApplicantsTableAdapter();
        private DepartmentsTableAdapter _depTA = new DepartmentsTableAdapter();
        private LibDS.ApplicantsDataTable _empDT = new LibDS.ApplicantsDataTable ();
        private ResumesTableAdapter _resumeTA = new ResumesTableAdapter();

        public ApplicantDAO()
        {
            _appTA.Fill(_empDT);
            _appTA.Fill(_libDS.Applicants);
            _depTA.Fill(_libDS.Departments);
        }
        public void AddApplicantRecord(string firstName, string lastName, string role, bool isEmployed, float hourlySalary, int department, int resumeID, string email, string phone)
        {
            _appTA.Insert(firstName,  lastName,  role, hourlySalary, resumeID, isEmployed, email, phone, department);
        }
        public List<Applicant> ReadAll()
        {
            List<Applicant> applicants = new List<Applicant>();
            foreach (LibDS.ApplicantsRow appRow in _libDS.Applicants.Rows)
            {
                LibDS.DepartmentsRow departmentRow = appRow.DepartmentsRow;
                LibDS.ResumesRow resumeRow = appRow.ResumesRow;
                applicants.Add(new Applicant(appRow.Id,appRow.FirstName,appRow.LastName,appRow.Role,appRow.IsEmployeed,(float)appRow.Salary,
                    new Department (departmentRow.DepartmentID,departmentRow.Name,departmentRow.Location),
                    new Resume(resumeRow.ResumeID,resumeRow.FirstName,resumeRow.LastName,resumeRow.Address,resumeRow.PreviousJob,resumeRow.Experience,new[] { resumeRow.Skills },resumeRow.Email,resumeRow.Phone),appRow.Email,appRow.PhoneNumber));
            }

            return applicants;
        }

    }
}
