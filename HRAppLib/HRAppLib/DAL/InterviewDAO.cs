using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAppLib.DAL.LibDSTableAdapters;
using HRAppLib.Entities;

namespace HRAppLib.DAL
{
    public class InterviewDAO
    {
        private LibDS _libDS = new LibDS();
        private InterviewTableAdapter _interviewTA = new InterviewTableAdapter();
        private ApplicantsTableAdapter _appTA = new ApplicantsTableAdapter();
        private JobTableAdapter _jobTA = new JobTableAdapter();
        private LibDS.InterviewDataTable _empDT = new LibDS.InterviewDataTable();

      
    }
}
