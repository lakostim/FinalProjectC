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

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Employee name cannot be blank");
                _name = value;
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
        public Employee(int employeeId, string name, float hourlySalary, Department department)
        {
            _employeeId = employeeId;
            Name = name;
            HourlySalary = hourlySalary;
            Department=department;
        }

        public override string ToString() => $"{EmployeeId},{Name},{HourlySalary},{Department}";

    }
}
