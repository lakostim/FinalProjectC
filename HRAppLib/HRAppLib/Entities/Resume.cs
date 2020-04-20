using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppLib.Entities
{
    public class Resume
    {
        private string _firstName;
        public string FirstNameme
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Employee First name cannot be blank");
                _firstName = value;
            }
        }

        private string _lastName;
        public string lastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Employee Last name cannot be blank");
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
                    throw new ArgumentException("Employee Address cannot be blank");
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
                if (value <0)
                    throw new ArgumentException("Experiance cannot be set to a negatgive value");

                _experience = value;
            }
        }

    }
}

