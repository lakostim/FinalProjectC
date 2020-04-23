using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * @author ${IanIbrahim}
 *
 * ${tags}
 */
namespace HRAppLib.Entities
{
    public class Interviews
    {
        private string[] _questions;
        private string[] _answers;
        private int _score;
        private readonly int _interviewID;
        private Job _job;
        private Applicant applicant;
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
        public int Score
        {


            get { return _score; }
            set { _score = value; }
        }
        public Job Job { get; set; }
        public Applicant Applicant { get; set; }
        public DateTime InterviewDate { get; set; }

        public Interviews(int interviewID, string[] questions, string[] answers, int score, Job job, Applicant applicant, DateTime interviewDate)
        {
            _interviewID = interviewID;
            Questions = questions;
            Answers = answers;
            Score = score;
            Job = job;
            Applicant = applicant;
            InterviewDate = interviewDate;
        }
    }
}