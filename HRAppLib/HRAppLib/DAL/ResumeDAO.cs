using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAppLib.DAL.LibDSTableAdapters;
using HRAppLib.Entities;


namespace HRAppLib.DAL
{
    public class ResumeDAO
    {
        private ResumesTableAdapter _resTA = new ResumesTableAdapter();

        private LibDS.ResumesDataTable _resDT =
            new LibDS.ResumesDataTable();
        public ResumeDAO()
        {

            _resTA.Fill(_resDT);
        }

        //add a record
        public void AddResumeRecord(string firstName, string lastName, string address, string previousJob, int experience, string[] mySkills, string email, string phone)
        {
            _resTA.Insert(  firstName,  lastName,  address,  previousJob,experience,  String.Join(",", mySkills),  email,  phone);
        }

        //retrieve all records
        public List<Resume> ReadAll()
        {
            List<Resume> resumes = new List<Resume>();
            foreach (LibDS.ResumesRow resumeRow in _resDT.Rows)
            {
                resumes.Add(new Resume(resumeRow.ResumeID, resumeRow.FirstName, resumeRow.LastName, resumeRow.Address, resumeRow.PreviousJob, resumeRow.Experience, new[] { resumeRow.Skills }, resumeRow.Email, resumeRow.Phone));
            }

            return resumes;
        }
    }
}
