using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAppLib.DAL.LibDSTableAdapters;
using HRAppLib.Entities;

namespace HRAppLib.DAL
{
    public class JobDAO
    {
        private JobTableAdapter _jobTA = new JobTableAdapter();
        private LibDS.JobDataTable _jobDT = new LibDS.JobDataTable();
        public JobDAO()
        {
            _jobTA.Fill(_jobDT);
        }
        public void AddJobRecord(string description, string responsibilities, string requirements, int experience)
        {
            _jobTA.Insert( description,  responsibilities, experience, requirements);
        }

        //retrieve all records
        public List<Job> ReadAll()
        {
            List<Job> jobs = new List<Job>();
            foreach (LibDS.JobRow jobRaw in _jobDT.Rows)
            {
                jobs.Add(new Job(jobRaw.JobID,jobRaw.Description,jobRaw.Responsibilities,jobRaw.Requirements,jobRaw.Experience));
            }

            return jobs;
        }
    }
}
