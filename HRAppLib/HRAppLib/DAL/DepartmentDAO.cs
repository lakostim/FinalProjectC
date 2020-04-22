using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRAppLib.DAL.LibDSTableAdapters;
using HRAppLib.Entities;

namespace HRAppLib.DAL
{
    public class DepartmentDAO
    {

        private DepartmentsTableAdapter _departmentsTableAdapter = new DepartmentsTableAdapter();

        private LibDS.DepartmentsDataTable _departmentsDataTable =
            new LibDS.DepartmentsDataTable();

        public DepartmentDAO()
        {

            _departmentsTableAdapter.Fill(_departmentsDataTable);
        }

        //add a record
        public void AddDepartmentRecord(Department department)
        {
            _departmentsTableAdapter.Insert( department.DepartmentName, department.Location);
        }

        //retrieve all records
        public List<Department> ReadAll()
        {
            List<Department> departments = new List<Department>();
            foreach (LibDS.DepartmentsRow departmentRow in _departmentsDataTable.Rows)
            {
                departments.Add(new Department(departmentRow.DepartmentID, departmentRow.Name,
                    departmentRow.Location));
            }

            return departments;
        }
    }
}
    
