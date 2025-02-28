using ConsoleApp29.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.data
{
    internal class coursedbcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=. ;Database=iti;Trusted_Connection=true;Encrypt=false;");
        }
        public DbSet<student> Student { get; set; }
        public DbSet<department> Department { get; set; }
        public DbSet<course> Course { get; set; }
        public DbSet<instructor> Instructor { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
