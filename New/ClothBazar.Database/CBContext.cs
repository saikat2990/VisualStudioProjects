using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Database
{
    public class CBContext:DbContext,IDisposable
    {
        public CBContext(): base("dbconnection1")
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catagory>().Property(p => p.name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(p => p.name).IsRequired().HasMaxLength(50);
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Catagory> catagories { get; set; }
        public DbSet<Config> configurations { get; set; }
    }
}
