using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRM.Data.Migrations
{
    /// <inheritdoc />
    public partial class HRMseedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName", "Description" },
                values: new object[,]
                {
                    { 1, "Engineering", "Handles product development" },
                    { 2, "Human Resources", "Handles employee relations" },
                    { 3, "Marketing", "Handles marketing and advertising" },
                    { 4, "Sales", "Handles sales and customer relations" },
                    { 5, "Finance", "Handles financial operations" },
                    { 6, "Customer Support", "Handles customer support" },
                    { 7, "Legal", "Handles legal matters" },
                    { 8, "IT", "Handles IT infrastructure" },
                    { 9, "Operations", "Handles day-to-day operations" },
                    { 10, "R&D", "Handles research and development" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "PositonDescription", "PositonName" },
                values: new object[,]
                {
                    { 1, "Develops software applications", "Software Engineer" },
                    { 2, "Manages HR department", "HR Manager" },
                    { 3, "Handles marketing tasks", "Marketing Specialist" },
                    { 4, "Handles sales tasks", "Sales Executive" },
                    { 5, "Analyzes financial data", "Finance Analyst" },
                    { 6, "Handles customer queries", "Customer Support Representative" },
                    { 7, "Handles legal issues", "Legal Advisor" },
                    { 8, "Manages IT infrastructure", "IT Specialist" },
                    { 9, "Manages operations", "Operations Manager" },
                    { 10, "Conducts research and development", "Research Scientist" }
                });

            migrationBuilder.InsertData(
                table: "Salarys",
                columns: new[] { "Id", "BasicSalary", "Bonus", "Deductions", "NetSalary", "PaymentDate" },
                values: new object[,]
                {
                    { 1, 50000f, 5000f, 2000f, 53000f, new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4291) },
                    { 2, 55000f, 5500f, 2500f, 58000f, new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4293) },
                    { 3, 60000f, 6000f, 3000f, 63000f, new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4295) },
                    { 4, 65000f, 6500f, 3500f, 68000f, new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4296) },
                    { 5, 70000f, 7000f, 4000f, 73000f, new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4297) },
                    { 6, 75000f, 7500f, 4500f, 78000f, new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4299) },
                    { 7, 80000f, 8000f, 5000f, 83000f, new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4300) },
                    { 8, 85000f, 8500f, 5500f, 88000f, new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4301) },
                    { 9, 90000f, 9000f, 6000f, 93000f, new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4303) },
                    { 10, 95000f, 9500f, 6500f, 98000f, new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4304) }
                });

            migrationBuilder.InsertData(
                table: "Shifts",
                columns: new[] { "Id", "DayOfApplication", "EndAt", "StartAt", "TotalHouse" },
                values: new object[,]
                {
                    { 1, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4328), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4328), new TimeOnly(8, 0, 0) },
                    { 2, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 7, 22, 11, 50, 45, 572, DateTimeKind.Local).AddTicks(4424), new TimeOnly(9, 0, 0) },
                    { 3, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4431), new DateTime(2024, 7, 22, 13, 50, 45, 572, DateTimeKind.Local).AddTicks(4431), new TimeOnly(7, 0, 0) },
                    { 4, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4436), new TimeOnly(8, 0, 0) },
                    { 5, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 7, 22, 14, 50, 45, 572, DateTimeKind.Local).AddTicks(4442), new TimeOnly(6, 0, 0) },
                    { 6, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4448), new TimeOnly(8, 0, 0) },
                    { 7, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4454), new DateTime(2024, 7, 22, 10, 50, 45, 572, DateTimeKind.Local).AddTicks(4453), new TimeOnly(10, 0, 0) },
                    { 8, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4465), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4464), new TimeOnly(8, 0, 0) },
                    { 9, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 7, 22, 11, 50, 45, 572, DateTimeKind.Local).AddTicks(4470), new TimeOnly(9, 0, 0) },
                    { 10, "[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]", new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 7, 22, 13, 50, 45, 572, DateTimeKind.Local).AddTicks(4475), new TimeOnly(7, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Tranings",
                columns: new[] { "Id", "EndAt", "StartAt", "Status", "TrainDescription", "TrainName", "TypeTrain" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4506), new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4505), "Completed", "Training for leadership skills", "Leadership Training", "[\"Online\",\"In-person\"]" },
                    { 2, new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4509), "Completed", "Training for technical skills", "Technical Training", "[\"Online\",\"In-person\"]" },
                    { 3, new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4512), "Completed", "Training for sales skills", "Sales Training", "[\"Online\",\"In-person\"]" },
                    { 4, new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4516), new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4515), "Completed", "Training for marketing skills", "Marketing Training", "[\"Online\",\"In-person\"]" },
                    { 5, new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4518), "Completed", "Training for HR skills", "HR Training", "[\"Online\",\"In-person\"]" },
                    { 6, new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4521), "Completed", "Training for finance skills", "Finance Training", "[\"Online\",\"In-person\"]" },
                    { 7, new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4524), new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4524), "Completed", "Training for customer service skills", "Customer Service Training", "[\"Online\",\"In-person\"]" },
                    { 8, new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4526), "Completed", "Training for legal skills", "Legal Training", "[\"Online\",\"In-person\"]" },
                    { 9, new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4529), "Completed", "Training for IT skills", "IT Training", "[\"Online\",\"In-person\"]" },
                    { 10, new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 8, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4532), "Completed", "Training for research skills", "Research Training", "[\"Online\",\"In-person\"]" }
                });

            migrationBuilder.InsertData(
                table: "Benefits",
                columns: new[] { "Id", "BenefitsDescription", "BenefitsName", "EndAt", "PositionId", "StartAt", "TypeBenefits" },
                values: new object[,]
                {
                    { 1, "Comprehensive health insurance", "Health Insurance", new DateTime(2025, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3941), 1, new DateTime(2023, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3922), "Health" },
                    { 2, "Comprehensive dental insurance", "Dental Insurance", new DateTime(2025, 8, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3946), 2, new DateTime(2023, 8, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3944), "Health" },
                    { 3, "Comprehensive vision insurance", "Vision Insurance", new DateTime(2025, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3948), 3, new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3947), "Health" },
                    { 4, "Company matched retirement plan", "Retirement Plan", new DateTime(2025, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3950), 4, new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3949), "Retirement" },
                    { 5, "20 days paid time off per year", "Paid Time Off", new DateTime(2025, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3952), 5, new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3951), "Leave" },
                    { 6, "Life insurance coverage", "Life Insurance", new DateTime(2025, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3954), 6, new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3953), "Life" },
                    { 7, "Short and long-term disability insurance", "Disability Insurance", new DateTime(2026, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3956), 7, new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3955), "Disability" },
                    { 8, "Free gym membership", "Gym Membership", new DateTime(2026, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3958), 8, new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3957), "Wellness" },
                    { 9, "Reimbursement for continuing education", "Tuition Reimbursement", new DateTime(2026, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3960), 9, new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3959), "Education" },
                    { 10, "Subsidized commuting costs", "Commuter Benefits", new DateTime(2026, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3962), 10, new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3961), "Commuting" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "DepartmentId", "Email", "FirstName", "FullName", "HireDate", "LastName", "MiddleName", "PositionId", "ShiftId" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, "john.smith@example.com", "John", "John A Smith", new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4124), "Smith", "A", 1, 1 },
                    { 2, "456 Elm St", 2, "jane.doe@example.com", "Jane", "Jane B Doe", new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4127), "Doe", "B", 2, 2 },
                    { 3, "789 Pine St", 3, "alice.johnson@example.com", "Alice", "Alice C Johnson", new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4130), "Johnson", "C", 3, 3 },
                    { 4, "101 Oak St", 4, "bob.brown@example.com", "Bob", "Bob D Brown", new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4132), "Brown", "D", 4, 4 },
                    { 5, "202 Birch St", 5, "charlie.davis@example.com", "Charlie", "Charlie E Davis", new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4134), "Davis", "E", 5, 5 },
                    { 6, "303 Maple St", 6, "emily.clark@example.com", "Emily", "Emily F Clark", new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4136), "Clark", "F", 6, 6 },
                    { 7, "404 Cedar St", 7, "daniel.lee@example.com", "Daniel", "Daniel G Lee", new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4143), "Lee", "G", 7, 7 },
                    { 8, "505 Spruce St", 8, "sophia.martinez@example.com", "Sophia", "Sophia H Martinez", new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4145), "Martinez", "H", 8, 8 },
                    { 9, "606 Fir St", 9, "james.davis@example.com", "James", "James I Davis", new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4147), "Davis", "I", 9, 9 },
                    { 10, "707 Redwood St", 10, "ava.wilson@example.com", "Ava", "Ava J Wilson", new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4149), "Wilson", "J", 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Recruitments",
                columns: new[] { "Id", "Deadline", "DepartmentId", "PostingDate", "RecruitmentDescription", "RecruitmentPosition", "Requestment", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4247), 1, new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4246), "Looking for a Software Engineer", "Software Engineer", "[]", "Open" },
                    { 2, new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4249), 2, new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4249), "Looking for an HR Manager", "HR Manager", "[]", "Open" },
                    { 3, new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4251), 3, new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4251), "Looking for a Marketing Specialist", "Marketing Specialist", "[]", "Closed" },
                    { 4, new DateTime(2024, 7, 7, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4253), 4, new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4253), "Looking for a Sales Executive", "Sales Executive", "[]", "Open" },
                    { 5, new DateTime(2024, 7, 12, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4259), 5, new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4258), "Looking for a Finance Analyst", "Finance Analyst", "[]", "Closed" },
                    { 6, new DateTime(2024, 7, 17, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4261), 6, new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4260), "Looking for a Customer Support Representative", "Customer Support Representative", "[]", "Open" },
                    { 7, new DateTime(2024, 7, 19, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4262), 7, new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4262), "Looking for a Legal Advisor", "Legal Advisor", "[]", "Closed" },
                    { 8, new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4264), 8, new DateTime(2024, 7, 2, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4264), "Looking for an IT Specialist", "IT Specialist", "[]", "Open" },
                    { 9, new DateTime(2024, 8, 1, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4266), 9, new DateTime(2024, 7, 12, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4265), "Looking for an Operations Manager", "Operations Manager", "[]", "Open" },
                    { 10, new DateTime(2024, 8, 11, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4267), 10, new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4267), "Looking for a Research Scientist", "Research Scientist", "[]", "Open" }
                });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "Id", "Comment", "EmployeeId", "EvaluationDate", "SalaryId", "Score", "TraningId" },
                values: new object[,]
                {
                    { 1, "Great performance", 1, new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4174), 1, 85, 1 },
                    { 2, "Excellent work", 2, new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4177), 2, 90, 2 },
                    { 3, "Satisfactory performance", 3, new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4179), 3, 78, 3 },
                    { 4, "Outstanding performance", 4, new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4180), 4, 92, 4 },
                    { 5, "Very good performance", 5, new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4181), 5, 88, 5 },
                    { 6, "Good work", 6, new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4183), 6, 80, 6 },
                    { 7, "Needs improvement", 7, new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4184), 7, 75, 7 },
                    { 8, "Great performance", 8, new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4185), 8, 89, 8 },
                    { 9, "Satisfactory performance", 9, new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4187), 9, 84, 9 },
                    { 10, "Outstanding performance", 10, new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4188), 10, 91, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
