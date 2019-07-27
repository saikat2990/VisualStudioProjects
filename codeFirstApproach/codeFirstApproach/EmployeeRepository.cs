using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirstApproach
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments() {

            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.Departments.ToList();
        }

        public List<Employee> GetEmployees()
        {

            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            return employeeDBContext.Employees.ToList();
        }
    }
}