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
//entity to form employee data object
namespace HRAppLib.Entities
{
    public class Applicant
    {
        private readonly int _applicantId;
        public int ApplicantId =>_applicantId;

        private string _firstName;
        public string FirstName
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
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Employee Last name cannot be blank");
                _lastName = value;
            }
        }

        private string _role;
        public string Role
        {
            get => _role;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Employee Role cannot be blank");
                _role = value;
            }
        }

        public bool _isEmployed;


        private float _hourlySalary;
        public float HourlySalary
        {
            get => _hourlySalary;
            set
            {
                if (value<15)
                    throw new ArgumentException("Salary cannot be lesser than the minimum pay rate");
                _hourlySalary = value;
            }
        }

        public Department Department { get; set; }
        public Resume Resume { get; set; }
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

        public Applicant(int applicantId, string firstNameme, string lastName, string role, bool isEmployed, float hourlySalary, Department department, Resume resume, string email, string phone)
        {
            _applicantId = applicantId;
            FirstName = firstNameme;
            LastName = lastName;
            Role = role;
            _isEmployed = isEmployed;
            HourlySalary = hourlySalary;
            Department = department;
            this.Resume = resume;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{ApplicantId}{FirstName},{LastName},{Role},{_isEmployed},{HourlySalary},{Department},{Resume},{Email},{Phone}";
        }
    }
}
