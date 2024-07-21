using HRM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HRM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Benefits> Benefits { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Recruitment> Recruitment { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Traning> Traning { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
            @"Server=AKAI\SQLEXPRESS;Database=HRM;Trusted_Connection=True;MultipleActiveResultSets=true;trustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Remove the AspNet prefix from table names
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName != null && tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }

            // Seed data for Benefits
            modelBuilder.Entity<Benefits>().HasData(
                new Benefits { Id = 1, BenefitsName = "Health Insurance", BenefitsDescription = "Covers medical expenses", TypeBenefits = "Medical", StartAt = DateTime.Now, EndAt = DateTime.Now.AddYears(1) },
                new Benefits { Id = 2, BenefitsName = "Gym Membership", BenefitsDescription = "Access to gym facilities", TypeBenefits = "Wellness", StartAt = DateTime.Now, EndAt = DateTime.Now.AddYears(1) },
                new Benefits { Id = 3, BenefitsName = "Paid Time Off", BenefitsDescription = "Vacation and sick leave", TypeBenefits = "Leave", StartAt = DateTime.Now, EndAt = DateTime.Now.AddYears(1) }
            );

            // Seed data for Department
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "Human Resources", Description = "Handles HR tasks" },
                new Department { Id = 2, DepartmentName = "Development", Description = "Handles software development tasks" },
                new Department { Id = 3, DepartmentName = "Sales", Description = "Handles sales and customer relations" }
            );

            // Seed data for Employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "John", MiddleName = "A.", LastName = "Doe", FullName = "John A. Doe", Address = "123 Main St", Email = "john.doe@example.com", HireDate = DateTime.Now, DepartmentId = 1, PositionId = 1, ShiftId = 1 },
                new Employee { Id = 2, FirstName = "Jane", MiddleName = "B.", LastName = "Smith", FullName = "Jane B. Smith", Address = "456 Elm St", Email = "jane.smith@example.com", HireDate = DateTime.Now, DepartmentId = 2, PositionId = 2, ShiftId = 2 },
                new Employee { Id = 3, FirstName = "Bob", MiddleName = "C.", LastName = "Brown", FullName = "Bob C. Brown", Address = "789 Oak St", Email = "bob.brown@example.com", HireDate = DateTime.Now, DepartmentId = 3, PositionId = 3, ShiftId = 3 }
            );

            // Seed data for Position
            modelBuilder.Entity<Position>().HasData(
                new Position { Id = 1, PositonName = "HR Manager", PositonDescription = "Manages HR tasks", BenefitsId = 1 },
                new Position { Id = 2, PositonName = "Developer", PositonDescription = "Develops software", BenefitsId = 2 },
                new Position { Id = 3, PositonName = "Sales Executive", PositonDescription = "Handles sales and customer relations", BenefitsId = 3 }
            );

            // Seed data for Shift
            modelBuilder.Entity<Shift>().HasData(
                new Shift { Id = 1, StartAt = DateTime.Now.AddHours(-4), EndAt = DateTime.Now.AddHours(4), TotalHouse = TimeOnly.FromTimeSpan(new TimeSpan(8, 0, 0)) },
                new Shift { Id = 2, StartAt = DateTime.Now.AddHours(-5), EndAt = DateTime.Now.AddHours(3), TotalHouse = TimeOnly.FromTimeSpan(new TimeSpan(8, 0, 0)) },
                new Shift { Id = 3, StartAt = DateTime.Now.AddHours(-6), EndAt = DateTime.Now.AddHours(2), TotalHouse = TimeOnly.FromTimeSpan(new TimeSpan(8, 0, 0)) }
            );

            // Seed data for Recruitment
            modelBuilder.Entity<Recruitment>().HasData(
                new Recruitment { Id = 1, Position = "Developer", PostingDate = DateTime.Now, Deadline = DateTime.Now.AddDays(30), Status = "Open", RecruitmentDescription = "Looking for a skilled developer", DepartmentId = 2 },
                new Recruitment { Id = 2, Position = "Sales Executive", PostingDate = DateTime.Now, Deadline = DateTime.Now.AddDays(30), Status = "Open", RecruitmentDescription = "Looking for a skilled sales executive", DepartmentId = 3 }
            );

            // Seed data for Salary
            modelBuilder.Entity<Salary>().HasData(
                new Salary { Id = 1, BasicSalary = 60000, Bonus = 5000, Deductions = 2000, NetSalary = 63000, PaymentDate = DateTime.Now },
                new Salary { Id = 2, BasicSalary = 80000, Bonus = 10000, Deductions = 3000, NetSalary = 87000, PaymentDate = DateTime.Now },
                new Salary { Id = 3, BasicSalary = 70000, Bonus = 7000, Deductions = 2500, NetSalary = 74500, PaymentDate = DateTime.Now }
            );

            // Seed data for Training
            modelBuilder.Entity<Traning>().HasData(
                new Traning { Id = 1, TrainName = "Software Development", TrainDescription = "Training for software development", StartAt = DateTime.Now, EndAt = DateTime.Now.AddMonths(1), Status = "Ongoing" },
                new Traning { Id = 2, TrainName = "Sales Skills", TrainDescription = "Training for sales skills", StartAt = DateTime.Now, EndAt = DateTime.Now.AddMonths(1), Status = "Ongoing" }
            );

            // Seed data for Performance
            modelBuilder.Entity<Performance>().HasData(
                new Performance { Id = 1, EvaluationDate = DateTime.Now, Score = 85, Comment = "Good performance", EmployeeId = 1, TraningId = 1, SalaryId = 1 },
                new Performance { Id = 2, EvaluationDate = DateTime.Now, Score = 90, Comment = "Excellent performance", EmployeeId = 2, TraningId = 1, SalaryId = 2 },
                new Performance { Id = 3, EvaluationDate = DateTime.Now, Score = 80, Comment = "Satisfactory performance", EmployeeId = 3, TraningId = 2, SalaryId = 3 }
            );
        }
    }
}
