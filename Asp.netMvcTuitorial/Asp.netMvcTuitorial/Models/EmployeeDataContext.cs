using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.netMvcTuitorial.Models
{
    public class EmployeeDataContext : DbContext
    {
        public DbSet<EmployeeData> EmployeeDatas { get; set; }

    }
}