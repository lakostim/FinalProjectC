using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAppLib.Entities
{
    public class Department
    {
        private readonly int _departmentNumber;
        public int DepartmentNumber =>_departmentNumber;

        private string _departmentName;
        public string DepartmentName
        {
            get => _departmentName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Department name cannot be blank");
                _departmentName = value;
            }
        }

        private string _location;
        public string Location
        {
            get => _location;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Location cannot be blank");
                _location = value;
            }
        }

        public Department(int departmentNumber, string departmentName, string location)
        {
            _departmentNumber = departmentNumber;
            DepartmentName = departmentName;
            Location = location;
        }

        public override string ToString() => $"{DepartmentNumber},{DepartmentName},{Location}";
    }
}
