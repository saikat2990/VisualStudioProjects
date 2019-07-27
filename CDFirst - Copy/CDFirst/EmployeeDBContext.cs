using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CDFirst
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures();
 
            //splitting table

            /*modelBuilder.Entity<Employee>()
                .Map(map =>
                {
                    map.Properties(p => new
                    {
                        p.Name, p.Gender
                    });
                    map.ToTable("Employee");
                })

                .Map(map =>
                 {
                     map.Properties(p => new
                     {
                         p.Salary
                     });
                 });*/

            base.OnModelCreating(modelBuilder);
        }


    }
}