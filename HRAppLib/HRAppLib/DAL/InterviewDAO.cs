using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAppLib.DAL.LibDSTableAdapters;
using HRAppLib.Entities;
/**
 * @author ${IΔN IbrΔhim}
 *this class comunicates with all tables to form a one single interview 
 * ${tags}
 */
namespace HRAppLib.DAL
{
    public class InterviewDAO
    {
        private LibDS _libDS = new LibDS();
        private InterviewTableAdapter _interviewTA = new InterviewTableAdapter();
        private ApplicantsTableAdapter _appTA = new ApplicantsTableAdapter();
        private JobTableAdapter _jobTA = new JobTableAdapter();
        private LibDS.InterviewDataTable _intDT = new LibDS.InterviewDataTable();

        public InterviewDAO()
        {
            _interviewTA.Fill(_intDT);
            _appTA.Fill(_libDS.Applicants);
            _jobTA.Fill(_libDS.Job);
          
        }
        public void AddResumeRecord(int interviewID, string[] questions, string[] answers, int score, int jobID, int applicantID, DateTime interviewDate)
        {
            _interviewTA.Insert(jobID, applicantID, interviewDate , score, string.Join(",", questions) , string.Join(",", answers)  );
        }
        public List<Interviews> ReadAll()
        {
            List<Interviews> interviews = new List<Interviews>();
            foreach (LibDS.InterviewRow interRow in _libDS.Interview.Rows)
            {
                LibDS.ApplicantsRow appRow = interRow.ApplicantsRow;
                LibDS.JobRow jobRow = interRow.JobRow;
                LibDS.DepartmentsRow departmentRow = appRow.DepartmentsRow;
                LibDS.ResumesRow resumeRow = appRow.ResumesRow;
                interviews.Add(new Interviews(interRow.InterviewID, interRow.questions.Split(','),interRow.answers_.Split(','),interRow.score,
                    new Job(jobRow.JobID,jobRow.Description,jobRow.Responsibilities,jobRow.Requirements,jobRow.Experience),
                    new Applicant(appRow.Id, appRow.FirstName, appRow.LastName, appRow.Role, appRow.IsEmployeed, (float)appRow.Salary,
                    new Department(departmentRow.DepartmentID, departmentRow.Name, departmentRow.Location),
                    new Resume(resumeRow.ResumeID, resumeRow.FirstName, resumeRow.LastName, resumeRow.Address, resumeRow.PreviousJob, resumeRow.Experience,
                    new[] { resumeRow.Skills }, resumeRow.Email, resumeRow.Phone), appRow.Email, appRow.PhoneNumber),interRow.interviewDate));
            }

            return interviews;
        }


    }
}
