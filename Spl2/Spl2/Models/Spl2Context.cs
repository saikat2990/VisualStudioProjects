using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spl2.Models
{
    public class Spl2Context:DbContext
    {
        public Spl2Context(DbContextOptions<Spl2Context> options) : base(options)
        {

        }
        public DbSet<DailyStudentServiceList> dailyStudentServiceLists { get; set; }

        public DbSet<DrugInfoPerStudent> drugInfoPerStudents { get; set; }
    }
}
