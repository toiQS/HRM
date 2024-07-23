using HRM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HRM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Benefits> Benefits { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Recruitment> Recruitments { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Training> Trainings { get; set; }

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

            // Seeding Benefits
            modelBuilder.Entity<Benefits>().HasData(
                new Benefits { Id = 1, BenefitsName = "Health Insurance", BenefitsDescription = "Comprehensive health insurance", TypeBenefits = "Health", StartAt = DateTime.Now.AddMonths(-12), EndAt = DateTime.Now.AddMonths(12), PositionId = 1 },
                new Benefits { Id = 2, BenefitsName = "Dental Insurance", BenefitsDescription = "Comprehensive dental insurance", TypeBenefits = "Health", StartAt = DateTime.Now.AddMonths(-11), EndAt = DateTime.Now.AddMonths(13), PositionId = 2 },
                new Benefits { Id = 3, BenefitsName = "Vision Insurance", BenefitsDescription = "Comprehensive vision insurance", TypeBenefits = "Health", StartAt = DateTime.Now.AddMonths(-10), EndAt = DateTime.Now.AddMonths(14), PositionId = 3 },
                new Benefits { Id = 4, BenefitsName = "Retirement Plan", BenefitsDescription = "Company matched retirement plan", TypeBenefits = "Retirement", StartAt = DateTime.Now.AddMonths(-9), EndAt = DateTime.Now.AddMonths(15), PositionId = 4 },
                new Benefits { Id = 5, BenefitsName = "Paid Time Off", BenefitsDescription = "20 days paid time off per year", TypeBenefits = "Leave", StartAt = DateTime.Now.AddMonths(-8), EndAt = DateTime.Now.AddMonths(16), PositionId = 5 },
                new Benefits { Id = 6, BenefitsName = "Life Insurance", BenefitsDescription = "Life insurance coverage", TypeBenefits = "Life", StartAt = DateTime.Now.AddMonths(-7), EndAt = DateTime.Now.AddMonths(17), PositionId = 6 },
                new Benefits { Id = 7, BenefitsName = "Disability Insurance", BenefitsDescription = "Short and long-term disability insurance", TypeBenefits = "Disability", StartAt = DateTime.Now.AddMonths(-6), EndAt = DateTime.Now.AddMonths(18), PositionId = 7 },
                new Benefits { Id = 8, BenefitsName = "Gym Membership", BenefitsDescription = "Free gym membership", TypeBenefits = "Wellness", StartAt = DateTime.Now.AddMonths(-5), EndAt = DateTime.Now.AddMonths(19), PositionId = 8 },
                new Benefits { Id = 9, BenefitsName = "Tuition Reimbursement", BenefitsDescription = "Reimbursement for continuing education", TypeBenefits = "Education", StartAt = DateTime.Now.AddMonths(-4), EndAt = DateTime.Now.AddMonths(20), PositionId = 9 },
                new Benefits { Id = 10, BenefitsName = "Commuter Benefits", BenefitsDescription = "Subsidized commuting costs", TypeBenefits = "Commuting", StartAt = DateTime.Now.AddMonths(-3), EndAt = DateTime.Now.AddMonths(21), PositionId = 10 }
            );

            // Seeding Department
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "Engineering", Description = "Handles product development" },
                new Department { Id = 2, DepartmentName = "Human Resources", Description = "Handles employee relations" },
                new Department { Id = 3, DepartmentName = "Marketing", Description = "Handles marketing and advertising" },
                new Department { Id = 4, DepartmentName = "Sales", Description = "Handles sales and customer relations" },
                new Department { Id = 5, DepartmentName = "Finance", Description = "Handles financial operations" },
                new Department { Id = 6, DepartmentName = "Customer Support", Description = "Handles customer support" },
                new Department { Id = 7, DepartmentName = "Legal", Description = "Handles legal matters" },
                new Department { Id = 8, DepartmentName = "IT", Description = "Handles IT infrastructure" },
                new Department { Id = 9, DepartmentName = "Operations", Description = "Handles day-to-day operations" },
                new Department { Id = 10, DepartmentName = "R&D", Description = "Handles research and development" }
            );

            // Seeding Employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "John", MiddleName = "A", LastName = "Smith", FullName = "John A Smith", Address = "123 Main St", Email = "john.smith@example.com", HireDate = DateTime.Now.AddMonths(-10), DepartmentId = 1, PositionId = 1, ShiftId = 1 },
                new Employee { Id = 2, FirstName = "Jane", MiddleName = "B", LastName = "Doe", FullName = "Jane B Doe", Address = "456 Elm St", Email = "jane.doe@example.com", HireDate = DateTime.Now.AddMonths(-9), DepartmentId = 2, PositionId = 2, ShiftId = 2 },
                new Employee { Id = 3, FirstName = "Alice", MiddleName = "C", LastName = "Johnson", FullName = "Alice C Johnson", Address = "789 Pine St", Email = "alice.johnson@example.com", HireDate = DateTime.Now.AddMonths(-8), DepartmentId = 3, PositionId = 3, ShiftId = 3 },
                new Employee { Id = 4, FirstName = "Bob", MiddleName = "D", LastName = "Brown", FullName = "Bob D Brown", Address = "101 Oak St", Email = "bob.brown@example.com", HireDate = DateTime.Now.AddMonths(-7), DepartmentId = 4, PositionId = 4, ShiftId = 4 },
                new Employee { Id = 5, FirstName = "Charlie", MiddleName = "E", LastName = "Davis", FullName = "Charlie E Davis", Address = "202 Birch St", Email = "charlie.davis@example.com", HireDate = DateTime.Now.AddMonths(-6), DepartmentId = 5, PositionId = 5, ShiftId = 5 },
                new Employee { Id = 6, FirstName = "Emily", MiddleName = "F", LastName = "Clark", FullName = "Emily F Clark", Address = "303 Maple St", Email = "emily.clark@example.com", HireDate = DateTime.Now.AddMonths(-5), DepartmentId = 6, PositionId = 6, ShiftId = 6 },
                new Employee { Id = 7, FirstName = "Daniel", MiddleName = "G", LastName = "Lee", FullName = "Daniel G Lee", Address = "404 Cedar St", Email = "daniel.lee@example.com", HireDate = DateTime.Now.AddMonths(-4), DepartmentId = 7, PositionId = 7, ShiftId = 7 },
                new Employee { Id = 8, FirstName = "Sophia", MiddleName = "H", LastName = "Martinez", FullName = "Sophia H Martinez", Address = "505 Spruce St", Email = "sophia.martinez@example.com", HireDate = DateTime.Now.AddMonths(-3), DepartmentId = 8, PositionId = 8, ShiftId = 8 },
                new Employee { Id = 9, FirstName = "James", MiddleName = "I", LastName = "Davis", FullName = "James I Davis", Address = "606 Fir St", Email = "james.davis@example.com", HireDate = DateTime.Now.AddMonths(-2), DepartmentId = 9, PositionId = 9, ShiftId = 9 },
                new Employee { Id = 10, FirstName = "Ava", MiddleName = "J", LastName = "Wilson", FullName = "Ava J Wilson", Address = "707 Redwood St", Email = "ava.wilson@example.com", HireDate = DateTime.Now.AddMonths(-1), DepartmentId = 10, PositionId = 10, ShiftId = 10 }
            );

            // Seeding Performance
            modelBuilder.Entity<Performance>().HasData(
                new Performance { Id = 1, EvaluationDate = DateTime.Now.AddMonths(-1), Score = 85, Comment = "Great performance", EmployeeId = 1, TrainingId = 1, SalaryId = 1 },
                new Performance { Id = 2, EvaluationDate = DateTime.Now.AddMonths(-2), Score = 90, Comment = "Excellent work", EmployeeId = 2, TrainingId = 2, SalaryId = 2 },
                new Performance { Id = 3, EvaluationDate = DateTime.Now.AddMonths(-3), Score = 78, Comment = "Satisfactory performance", EmployeeId = 3, TrainingId = 3, SalaryId = 3 },
                new Performance { Id = 4, EvaluationDate = DateTime.Now.AddMonths(-4), Score = 92, Comment = "Outstanding performance", EmployeeId = 4, TrainingId = 4, SalaryId = 4 },
                new Performance { Id = 5, EvaluationDate = DateTime.Now.AddMonths(-5), Score = 88, Comment = "Very good performance", EmployeeId = 5, TrainingId = 5, SalaryId = 5 },
                new Performance { Id = 6, EvaluationDate = DateTime.Now.AddMonths(-6), Score = 80, Comment = "Good work", EmployeeId = 6, TrainingId = 6, SalaryId = 6 },
                new Performance { Id = 7, EvaluationDate = DateTime.Now.AddMonths(-7), Score = 75, Comment = "Needs improvement", EmployeeId = 7, TrainingId = 7, SalaryId = 7 },
                new Performance { Id = 8, EvaluationDate = DateTime.Now.AddMonths(-8), Score = 89, Comment = "Great performance", EmployeeId = 8, TrainingId = 8, SalaryId = 8 },
                new Performance { Id = 9, EvaluationDate = DateTime.Now.AddMonths(-9), Score = 84, Comment = "Satisfactory performance", EmployeeId = 9, TrainingId = 9, SalaryId = 9 },
                new Performance { Id = 10, EvaluationDate = DateTime.Now.AddMonths(-10), Score = 91, Comment = "Outstanding performance", EmployeeId = 10, TrainingId = 10, SalaryId = 10 }
            );

            // Seeding Position
            modelBuilder.Entity<Position>().HasData(
                new Position { Id = 1, PositionName = "Software Engineer", PositionDescription = "Develops software applications" },
                new Position { Id = 2, PositionName = "HR Manager", PositionDescription = "Manages HR department" },
                new Position { Id = 3, PositionName = "Marketing Specialist", PositionDescription = "Handles marketing tasks" },
                new Position { Id = 4, PositionName = "Sales Executive", PositionDescription = "Handles sales tasks" },
                new Position { Id = 5, PositionName = "Finance Analyst", PositionDescription = "Analyzes financial data" },
                new Position { Id = 6, PositionName = "Customer Support Representative", PositionDescription = "Handles customer queries" },
                new Position { Id = 7, PositionName = "Legal Advisor", PositionDescription = "Handles legal issues" },
                new Position { Id = 8, PositionName = "IT Specialist", PositionDescription = "Manages IT infrastructure" },
                new Position { Id = 9, PositionName = "Operations Manager", PositionDescription = "Manages operations" },
                new Position { Id = 10, PositionName = "Research Scientist", PositionDescription = "Conducts research and development" }
            );

            // Seeding Recruitment
            modelBuilder.Entity<Recruitment>().HasData(
                new Recruitment { Id = 1, RecruitmentPosition = "Software Engineer", PostingDate = DateTime.Now.AddMonths(-6), Deadline = DateTime.Now.AddMonths(-3), Status = "Open", RecruitmentDescription = "Looking for a Software Engineer", DepartmentId = 1 },
                new Recruitment { Id = 2, RecruitmentPosition = "HR Manager", PostingDate = DateTime.Now.AddMonths(-5), Deadline = DateTime.Now.AddMonths(-2), Status = "Open", RecruitmentDescription = "Looking for an HR Manager", DepartmentId = 2 },
                new Recruitment { Id = 3, RecruitmentPosition = "Marketing Specialist", PostingDate = DateTime.Now.AddMonths(-4), Deadline = DateTime.Now.AddMonths(-1), Status = "Closed", RecruitmentDescription = "Looking for a Marketing Specialist", DepartmentId = 3 },
                new Recruitment { Id = 4, RecruitmentPosition = "Sales Executive", PostingDate = DateTime.Now.AddMonths(-3), Deadline = DateTime.Now.AddDays(-15), Status = "Open", RecruitmentDescription = "Looking for a Sales Executive", DepartmentId = 4 },
                new Recruitment { Id = 5, RecruitmentPosition = "Finance Analyst", PostingDate = DateTime.Now.AddMonths(-2), Deadline = DateTime.Now.AddDays(-10), Status = "Closed", RecruitmentDescription = "Looking for a Finance Analyst", DepartmentId = 5 },
                new Recruitment { Id = 6, RecruitmentPosition = "Customer Support Representative", PostingDate = DateTime.Now.AddMonths(-1), Deadline = DateTime.Now.AddDays(-5), Status = "Open", RecruitmentDescription = "Looking for a Customer Support Representative", DepartmentId = 6 },
                new Recruitment { Id = 7, RecruitmentPosition = "Legal Advisor", PostingDate = DateTime.Now.AddDays(-30), Deadline = DateTime.Now.AddDays(-3), Status = "Closed", RecruitmentDescription = "Looking for a Legal Advisor", DepartmentId = 7 },
                new Recruitment { Id = 8, RecruitmentPosition = "IT Specialist", PostingDate = DateTime.Now.AddDays(-20), Deadline = DateTime.Now, Status = "Open", RecruitmentDescription = "Looking for an IT Specialist", DepartmentId = 8 },
                new Recruitment { Id = 9, RecruitmentPosition = "Operations Manager", PostingDate = DateTime.Now.AddDays(-10), Deadline = DateTime.Now.AddDays(10), Status = "Open", RecruitmentDescription = "Looking for an Operations Manager", DepartmentId = 9 },
                new Recruitment { Id = 10, RecruitmentPosition = "Research Scientist", PostingDate = DateTime.Now, Deadline = DateTime.Now.AddDays(20), Status = "Open", RecruitmentDescription = "Looking for a Research Scientist", DepartmentId = 10 }
            );

            // Seeding Salary
            modelBuilder.Entity<Salary>().HasData(
                new Salary { Id = 1, BasicSalary = 50000, Bonus = 5000, Deductions = 2000, NetSalary = 53000, PaymentDate = DateTime.Now.AddMonths(-1) },
                new Salary { Id = 2, BasicSalary = 55000, Bonus = 5500, Deductions = 2500, NetSalary = 58000, PaymentDate = DateTime.Now.AddMonths(-2) },
                new Salary { Id = 3, BasicSalary = 60000, Bonus = 6000, Deductions = 3000, NetSalary = 63000, PaymentDate = DateTime.Now.AddMonths(-3) },
                new Salary { Id = 4, BasicSalary = 65000, Bonus = 6500, Deductions = 3500, NetSalary = 68000, PaymentDate = DateTime.Now.AddMonths(-4) },
                new Salary { Id = 5, BasicSalary = 70000, Bonus = 7000, Deductions = 4000, NetSalary = 73000, PaymentDate = DateTime.Now.AddMonths(-5) },
                new Salary { Id = 6, BasicSalary = 75000, Bonus = 7500, Deductions = 4500, NetSalary = 78000, PaymentDate = DateTime.Now.AddMonths(-6) },
                new Salary { Id = 7, BasicSalary = 80000, Bonus = 8000, Deductions = 5000, NetSalary = 83000, PaymentDate = DateTime.Now.AddMonths(-7) },
                new Salary { Id = 8, BasicSalary = 85000, Bonus = 8500, Deductions = 5500, NetSalary = 88000, PaymentDate = DateTime.Now.AddMonths(-8) },
                new Salary { Id = 9, BasicSalary = 90000, Bonus = 9000, Deductions = 6000, NetSalary = 93000, PaymentDate = DateTime.Now.AddMonths(-9) },
                new Salary { Id = 10, BasicSalary = 95000, Bonus = 9500, Deductions = 6500, NetSalary = 98000, PaymentDate = DateTime.Now.AddMonths(-10) }
            );

            // Seeding Shift
            modelBuilder.Entity<Shift>().HasData(
                new Shift { Id = 1, StartAt = DateTime.Now.AddHours(-8), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("08:00") },
                new Shift { Id = 2, StartAt = DateTime.Now.AddHours(-9), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("09:00") },
                new Shift { Id = 3, StartAt = DateTime.Now.AddHours(-7), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("07:00") },
                new Shift { Id = 4, StartAt = DateTime.Now.AddHours(-8), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("08:00") },
                new Shift { Id = 5, StartAt = DateTime.Now.AddHours(-6), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("06:00") },
                new Shift { Id = 6, StartAt = DateTime.Now.AddHours(-8), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("08:00") },
                new Shift { Id = 7, StartAt = DateTime.Now.AddHours(-10), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("10:00") },
                new Shift { Id = 8, StartAt = DateTime.Now.AddHours(-8), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("08:00") },
                new Shift { Id = 9, StartAt = DateTime.Now.AddHours(-9), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("09:00") },
                new Shift { Id = 10, StartAt = DateTime.Now.AddHours(-7), EndAt = DateTime.Now, DayOfApplication = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" }, TotalHours = TimeOnly.Parse("07:00") }
            );

            // Seeding Training
            modelBuilder.Entity<Training>().HasData(
                new Training { Id = 1, TrainName = "Leadership Training", TrainDescription = "Training for leadership skills", StartAt = DateTime.Now.AddMonths(-2), EndAt = DateTime.Now.AddMonths(-1), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 2, TrainName = "Technical Training", TrainDescription = "Training for technical skills", StartAt = DateTime.Now.AddMonths(-3), EndAt = DateTime.Now.AddMonths(-2), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 3, TrainName = "Sales Training", TrainDescription = "Training for sales skills", StartAt = DateTime.Now.AddMonths(-4), EndAt = DateTime.Now.AddMonths(-3), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 4, TrainName = "Marketing Training", TrainDescription = "Training for marketing skills", StartAt = DateTime.Now.AddMonths(-5), EndAt = DateTime.Now.AddMonths(-4), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 5, TrainName = "HR Training", TrainDescription = "Training for HR skills", StartAt = DateTime.Now.AddMonths(-6), EndAt = DateTime.Now.AddMonths(-5), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 6, TrainName = "Finance Training", TrainDescription = "Training for finance skills", StartAt = DateTime.Now.AddMonths(-7), EndAt = DateTime.Now.AddMonths(-6), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 7, TrainName = "Customer Service Training", TrainDescription = "Training for customer service skills", StartAt = DateTime.Now.AddMonths(-8), EndAt = DateTime.Now.AddMonths(-7), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 8, TrainName = "Legal Training", TrainDescription = "Training for legal skills", StartAt = DateTime.Now.AddMonths(-9), EndAt = DateTime.Now.AddMonths(-8), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 9, TrainName = "IT Training", TrainDescription = "Training for IT skills", StartAt = DateTime.Now.AddMonths(-10), EndAt = DateTime.Now.AddMonths(-9), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" },
                new Training { Id = 10, TrainName = "Research Training", TrainDescription = "Training for research skills", StartAt = DateTime.Now.AddMonths(-11), EndAt = DateTime.Now.AddMonths(-10), TypeTrain = new List<string> { "Online", "In-person" }, Status = "Completed" }
            );
        }

    }
}
