using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApproachForInsertUpdate
{
    public class EmployeeRepository
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();

        public List<Employee> GetEmployees() {
            return employeeDBContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee) {

            employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee) {
            Employee updateEmployee = employeeDBContext.Employees.FirstOrDefault(x => x.Id == employee.Id);
            updateEmployee.Name = employee.Name;
            updateEmployee.Gender = employee.Gender;
            updateEmployee.salary = employee.salary;
            employeeDBContext.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            Employee deleteEmployee = employeeDBContext.Employees.FirstOrDefault(x => x.Id == employee.Id);
            employeeDBContext.Employees.Remove(deleteEmployee);
            employeeDBContext.SaveChanges();
        }
    }
}