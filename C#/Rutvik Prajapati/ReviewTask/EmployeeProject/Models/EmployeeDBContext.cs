using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.API.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = TestEmployeeDB; Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(x => x.Id)
                .UseIdentityColumn()
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(x => x.Name)
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(x => x.Address)
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(x => x.IsDelete);
               

        }
    }
}
