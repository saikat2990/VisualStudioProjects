using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tirtha.Models;

namespace Tirtha
{
    public class CBContext : DbContext, IDisposable
    {
        public CBContext() : base("dbconnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
        public DbSet<Product> products { get; set; }

    }
}