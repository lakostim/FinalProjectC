using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//entity to form employee data object
namespace HRAppLib.Entities
{
    public class Applicant
    {
        private readonly int _applicantId;
        public int ApplicantId =>_applicantId;

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
        public Resume qualification { get; set; }
        public Applicant(int employeeId, string name, float hourlySalary, Department department)
        {
            _employeeId = employeeId;
            Name = name;
            HourlySalary = hourlySalary;
            Department=department;
        }

        public override string ToString() => $"{EmployeeId},{Name},{HourlySalary},{Department}";

    }
}
