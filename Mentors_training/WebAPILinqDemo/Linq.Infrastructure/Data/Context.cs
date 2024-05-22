using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Linq.core.Models;
using System.Threading.Tasks;

namespace Linq.Infrastructure.Data
{
    
        public class Context : DbContext
        {
            public Context(DbContextOptions<Context> options) : base(options)
            {
            }

            // DbSet for each entity
            public DbSet<EmployeeModel> Employees { get; set; }
            public DbSet<DepartmentModel> Department { get; set; }

            // Configure entity mappings in OnModelCreating method
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Map EmployeeModel to customer table
                modelBuilder.Entity<EmployeeModel>().ToTable("Employees");
            modelBuilder.Entity<DepartmentModel>().ToTable("Department");
            }
        }
}

