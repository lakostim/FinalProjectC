using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppLib.Entities
{
    public class Resume
    {
        private int _id;
        public int ID
        {
            get { return _id; }
        }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Applicant First name cannot be blank");
                _firstName = value;
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Applicant Last name cannot be blank");
                _lastName = value;
            }
        }

        private string _address;
        public string Address
        {
            get => _address;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Applicant Address cannot be blank");
                _address = value;
            }
        }

        private string _previousJob;
        public string PreviousJob
        {
            get => _previousJob;
            set
            {
                _previousJob = value;
            }
        }

        public int _experience;
        public int Experience
        {
            get => _experience;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Experiance cannot be set to a negatgive value");

                _experience = value;
            }
        }

        private string[] _mySkills;
        public string[] Skills{

            
                get { return _mySkills; }
                set { _mySkills = value; }
            }

        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Applicant Email cannot be blank");
                _email = value;
            }
        }

        private string _phone;
        public string Phone
        {
            get => _phone;
            set
            {

                _phone = value;
            }
        }

        public Resume(int id,string firstName,  string lastName, string address,  string previousJob, int experience, string[] mySkills, string email, string phone)
        {
            _id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PreviousJob = previousJob; 
            Experience = experience;
            Skills = mySkills; 
            Email = email;
            Phone = phone;
         
        }

        public override string ToString()
        {
            return $"{ID}{FirstName},{LastName},{Address},{PreviousJob},{Experience},{Skills},{Email},{Phone}";
        }
    }
}

