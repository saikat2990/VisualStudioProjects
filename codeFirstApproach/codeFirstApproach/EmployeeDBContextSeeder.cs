using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace codeFirstApproach
{
    public class EmployeeDBContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            Department department1 = new Department()
            {
                Name = "IIT",
                Location = "New York"
            };

            Department department2 = new Department()
            {
                Name = "IR",
                Location = "London"
            };

            Employee Employee1 = new Employee()
            {
                FirstName = "Goru",
                LastName = "Bolod",
                Gender = "Male",
                Salary=40000,
                DevelopID = 1,
                jobTitle="kamla"
            };

            context.Departments.Add(department1);
            context.Departments.Add(department2);
            context.Employees.Add(Employee1);
            base.Seed(context);
        }
    }
}