using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//entity to form employee data object
namespace HRAppLib.Entities
{
    public class Employee
    {
        private readonly int _employeeId;
        public int EmployeeId =>_employeeId;

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
        public Employee(int employeeId, string firstName, string lastName, float hourlySalary, Department department)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            HourlySalary = hourlySalary;
            Department=department;
        }

        public override string ToString() => $"{EmployeeId},{FirstName},{HourlySalary},{Department}";

    }
}
