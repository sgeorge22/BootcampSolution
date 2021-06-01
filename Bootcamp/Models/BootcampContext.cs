using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp.Models
{
    public class BootcampContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Assessment> Assessments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) // one time sets up the connection between sqlserver - slide311
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress01;database=BootcampDb;trusted_connection=true;";
                builder.UseSqlServer(connStr); //runs the first time anything in our code uses the DbContext

            }
        }
        protected override void OnModelCreating(ModelBuilder builder) //where you put the fluent_abi - slide312
        {

        }
    }
}
