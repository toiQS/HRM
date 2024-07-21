using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HRM.Data.Migrations
{
    /// <inheritdoc />
    public partial class HRMSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Benefits",
                columns: new[] { "Id", "BenefitsDescription", "BenefitsName", "EndAt", "StartAt", "TypeBenefits" },
                values: new object[,]
                {
                    { 1, "Covers medical expenses", "Health Insurance", new DateTime(2025, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2556), "Medical" },
                    { 2, "Access to gym facilities", "Gym Membership", new DateTime(2025, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2575), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2575), "Wellness" },
                    { 3, "Vacation and sick leave", "Paid Time Off", new DateTime(2025, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2577), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2576), "Leave" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "DepartmentName", "Description" },
                values: new object[,]
                {
                    { 1, "Human Resources", "Handles HR tasks" },
                    { 2, "Development", "Handles software development tasks" },
                    { 3, "Sales", "Handles sales and customer relations" }
                });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "BasicSalary", "Bonus", "Deductions", "NetSalary", "PaymentDate" },
                values: new object[,]
                {
                    { 1, 60000f, 5000f, 2000f, 63000f, new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2830) },
                    { 2, 80000f, 10000f, 3000f, 87000f, new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2831) },
                    { 3, 70000f, 7000f, 2500f, 74500f, new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2832) }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "DayOfApplication", "EndAt", "StartAt", "TotalHouse" },
                values: new object[,]
                {
                    { 1, "[]", new DateTime(2024, 7, 22, 2, 26, 35, 595, DateTimeKind.Local).AddTicks(2772), new DateTime(2024, 7, 21, 18, 26, 35, 595, DateTimeKind.Local).AddTicks(2767), new TimeOnly(8, 0, 0) },
                    { 2, "[]", new DateTime(2024, 7, 22, 1, 26, 35, 595, DateTimeKind.Local).AddTicks(2787), new DateTime(2024, 7, 21, 17, 26, 35, 595, DateTimeKind.Local).AddTicks(2786), new TimeOnly(8, 0, 0) },
                    { 3, "[]", new DateTime(2024, 7, 22, 0, 26, 35, 595, DateTimeKind.Local).AddTicks(2788), new DateTime(2024, 7, 21, 16, 26, 35, 595, DateTimeKind.Local).AddTicks(2788), new TimeOnly(8, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Traning",
                columns: new[] { "Id", "EndAt", "StartAt", "Status", "TrainDescription", "TrainName", "TypeTrain" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2851), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2851), "Ongoing", "Training for software development", "Software Development", "[]" },
                    { 2, new DateTime(2024, 8, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2854), "Ongoing", "Training for sales skills", "Sales Skills", "[]" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "BenefitsId", "PositonDescription", "PositonName" },
                values: new object[,]
                {
                    { 1, 1, "Manages HR tasks", "HR Manager" },
                    { 2, 2, "Develops software", "Developer" },
                    { 3, 3, "Handles sales and customer relations", "Sales Executive" }
                });

            migrationBuilder.InsertData(
                table: "Recruitment",
                columns: new[] { "Id", "Deadline", "DepartmentId", "Position", "PostingDate", "RecruitmentDescription", "Requestment", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 20, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2809), 2, "Developer", new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2808), "Looking for a skilled developer", "[]", "Open" },
                    { 2, new DateTime(2024, 8, 20, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2814), 3, "Sales Executive", new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2814), "Looking for a skilled sales executive", "[]", "Open" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "DepartmentId", "Email", "FirstName", "FullName", "HireDate", "LastName", "MiddleName", "PositionId", "ShiftId" },
                values: new object[,]
                {
                    { 1, "123 Main St", 1, "john.doe@example.com", "John", "John A. Doe", new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2721), "Doe", "A.", 1, 1 },
                    { 2, "456 Elm St", 2, "jane.smith@example.com", "Jane", "Jane B. Smith", new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2724), "Smith", "B.", 2, 2 },
                    { 3, "789 Oak St", 3, "bob.brown@example.com", "Bob", "Bob C. Brown", new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2726), "Brown", "C.", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Performance",
                columns: new[] { "Id", "Comment", "EmployeeId", "EvaluationDate", "SalaryId", "Score", "TraningId" },
                values: new object[,]
                {
                    { 1, "Good performance", 1, new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2876), 1, 85, 1 },
                    { 2, "Excellent performance", 2, new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2879), 2, 90, 1 },
                    { 3, "Satisfactory performance", 3, new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2880), 3, 80, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recruitment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recruitment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Traning",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Traning",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Position",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3);

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
        }
    }
}
