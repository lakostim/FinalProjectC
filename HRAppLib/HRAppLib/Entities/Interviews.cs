using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppLib.Entities
{
    public class Interviews
    {
        private string[] _questions;
        private string[] _answers;
        private int _score;
        private readonly int _interviewID;
        private int _jobID;
        private int _aapplicantID;
        private DateTime _interviewDate;
        public int InterviewID => _interviewID;
        public string[] Questions
        {


            get { return _questions; }
            set { _questions = value; }
        }
        public string[] Answers
        {


            get { return _answers; }
            set { _answers = value; }
        }

    }
}
