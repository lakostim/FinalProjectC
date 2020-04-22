using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppLib.Entities
{
    public class Job
    {
        private string _description;
        private string _responsibilities;
        private int _experience;
        private string _requirements;

        private readonly int _jobID;
        public int JobID => _jobID;

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
            }
        }
        public string Responsibilities
        {
            get => _responsibilities;
            set
            {
                _responsibilities = value;
            }
        }
        public string Requirements
        {
            get => _requirements;
            set
            {
                 _requirements = value;
            }
        }
        public int Experience
        {
            get => _experience;
            set
            {
                _experience = value;
            }
        }

        public Job(int jobID, string description, string responsibilities, string requirements, int experience)
        {
            _jobID = jobID;
            Description = description;
            Responsibilities = responsibilities;
            Requirements = requirements;
            Experience = experience;
        }

        public override string ToString()
        {
            return $"{_jobID},{Description},{Responsibilities},{Requirements},{Experience}";
        }
    }
}
