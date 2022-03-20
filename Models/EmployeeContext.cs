using System;
using Microsoft.EntityFrameworkCore;


namespace CRUDEmployeeAPI.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasIndex(p => new { p.FirstName, p.LastName, p.Email }).IsUnique();
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Swami",
                LastName = "Vivekanand",
                Email = "sv@gmail.com",
                Age = 143

            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "SubhashChandra",
                LastName = "Bose",
                Email = "scb@gmail.com",
                Age = 125
            });
        }
    }
}
