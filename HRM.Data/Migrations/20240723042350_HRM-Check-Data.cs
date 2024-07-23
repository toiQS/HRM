using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Data.Migrations
{
    /// <inheritdoc />
    public partial class HRMCheckData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Salarys_SalaryId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Tranings_TraningId",
                table: "Performances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tranings",
                table: "Tranings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salarys",
                table: "Salarys");

            migrationBuilder.RenameTable(
                name: "Tranings",
                newName: "Trainings");

            migrationBuilder.RenameTable(
                name: "Salarys",
                newName: "Salaries");

            migrationBuilder.RenameColumn(
                name: "TotalHouse",
                table: "Shifts",
                newName: "TotalHours");

            migrationBuilder.RenameColumn(
                name: "PositonName",
                table: "Positions",
                newName: "PositionName");

            migrationBuilder.RenameColumn(
                name: "PositonDescription",
                table: "Positions",
                newName: "PositionDescription");

            migrationBuilder.RenameColumn(
                name: "TraningId",
                table: "Performances",
                newName: "TrainingId");

            migrationBuilder.RenameIndex(
                name: "IX_Performances_TraningId",
                table: "Performances",
                newName: "IX_Performances_TrainingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainings",
                table: "Trainings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 8, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 8, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 9, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 9, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 10, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 10, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 11, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(323), new DateTime(2023, 11, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 12, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(325), new DateTime(2023, 12, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(334), new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 9, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2023, 10, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2023, 11, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2023, 12, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2024, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "HireDate",
                value: new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "HireDate",
                value: new DateTime(2024, 5, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "HireDate",
                value: new DateTime(2024, 6, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "EvaluationDate",
                value: new DateTime(2024, 6, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "EvaluationDate",
                value: new DateTime(2024, 5, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "EvaluationDate",
                value: new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "EvaluationDate",
                value: new DateTime(2024, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "EvaluationDate",
                value: new DateTime(2024, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 6,
                column: "EvaluationDate",
                value: new DateTime(2024, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 7,
                column: "EvaluationDate",
                value: new DateTime(2023, 12, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 8,
                column: "EvaluationDate",
                value: new DateTime(2023, 11, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 9,
                column: "EvaluationDate",
                value: new DateTime(2023, 10, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 10,
                column: "EvaluationDate",
                value: new DateTime(2023, 9, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 8, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(626), new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 13, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(632), new DateTime(2024, 5, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 18, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 6, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 20, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(636), new DateTime(2024, 6, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 7, 3, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 2, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 7, 13, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 12, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 6, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 5, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "PaymentDate",
                value: new DateTime(2024, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "PaymentDate",
                value: new DateTime(2023, 11, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "PaymentDate",
                value: new DateTime(2023, 10, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Salaries",
                keyColumn: "Id",
                keyValue: 10,
                column: "PaymentDate",
                value: new DateTime(2023, 9, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(711), new DateTime(2024, 7, 23, 3, 23, 50, 101, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 7, 23, 2, 23, 50, 101, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 7, 23, 4, 23, 50, 101, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 7, 23, 3, 23, 50, 101, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(829), new DateTime(2024, 7, 23, 5, 23, 50, 101, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 7, 23, 3, 23, 50, 101, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 7, 23, 1, 23, 50, 101, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(846), new DateTime(2024, 7, 23, 3, 23, 50, 101, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(852), new DateTime(2024, 7, 23, 2, 23, 50, 101, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 7, 23, 4, 23, 50, 101, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 6, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(888), new DateTime(2024, 5, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 4, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 3, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(898), new DateTime(2024, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 2, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 1, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(904), new DateTime(2023, 12, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(913), new DateTime(2023, 11, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 11, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(916), new DateTime(2023, 10, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 10, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(919), new DateTime(2023, 9, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Trainings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 9, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(922), new DateTime(2023, 8, 23, 11, 23, 50, 101, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Salaries_SalaryId",
                table: "Performances",
                column: "SalaryId",
                principalTable: "Salaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Trainings_TrainingId",
                table: "Performances",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Salaries_SalaryId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Trainings_TrainingId",
                table: "Performances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainings",
                table: "Trainings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.RenameTable(
                name: "Trainings",
                newName: "Tranings");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "Salarys");

            migrationBuilder.RenameColumn(
                name: "TotalHours",
                table: "Shifts",
                newName: "TotalHouse");

            migrationBuilder.RenameColumn(
                name: "PositionName",
                table: "Positions",
                newName: "PositonName");

            migrationBuilder.RenameColumn(
                name: "PositionDescription",
                table: "Positions",
                newName: "PositonDescription");

            migrationBuilder.RenameColumn(
                name: "TrainingId",
                table: "Performances",
                newName: "TraningId");

            migrationBuilder.RenameIndex(
                name: "IX_Performances_TrainingId",
                table: "Performances",
                newName: "IX_Performances_TraningId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tranings",
                table: "Tranings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salarys",
                table: "Salarys",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3941), new DateTime(2023, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 8, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3946), new DateTime(2023, 8, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3948), new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3950), new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3952), new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3954), new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3956), new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3960), new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2026, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3962), new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "HireDate",
                value: new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "HireDate",
                value: new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "HireDate",
                value: new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 1,
                column: "EvaluationDate",
                value: new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 2,
                column: "EvaluationDate",
                value: new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 3,
                column: "EvaluationDate",
                value: new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 4,
                column: "EvaluationDate",
                value: new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 5,
                column: "EvaluationDate",
                value: new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 6,
                column: "EvaluationDate",
                value: new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 7,
                column: "EvaluationDate",
                value: new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 8,
                column: "EvaluationDate",
                value: new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 9,
                column: "EvaluationDate",
                value: new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "Performances",
                keyColumn: "Id",
                keyValue: 10,
                column: "EvaluationDate",
                value: new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4249), new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 7, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4253), new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 12, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 17, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 19, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4262), new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 7, 2, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 1, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4266), new DateTime(2024, 7, 12, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "Recruitments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 11, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4267), new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 4,
                column: "PaymentDate",
                value: new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 5,
                column: "PaymentDate",
                value: new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 6,
                column: "PaymentDate",
                value: new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 7,
                column: "PaymentDate",
                value: new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 8,
                column: "PaymentDate",
                value: new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 9,
                column: "PaymentDate",
                value: new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Salarys",
                keyColumn: "Id",
                keyValue: 10,
                column: "PaymentDate",
                value: new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4328), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 7, 22, 11, 50, 45, 572, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4431), new DateTime(2024, 7, 22, 13, 50, 45, 572, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4437), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 7, 22, 14, 50, 45, 572, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4454), new DateTime(2024, 7, 22, 10, 50, 45, 572, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4465), new DateTime(2024, 7, 22, 12, 50, 45, 572, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 7, 22, 11, 50, 45, 572, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Shifts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4475), new DateTime(2024, 7, 22, 13, 50, 45, 572, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 6, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4506), new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 5, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 4, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 3, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4516), new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 2, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4519), new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 1, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4521), new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 12, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4524), new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 11, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4527), new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 10, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4530), new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Tranings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2023, 9, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4532), new DateTime(2023, 8, 22, 20, 50, 45, 572, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Salarys_SalaryId",
                table: "Performances",
                column: "SalaryId",
                principalTable: "Salarys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Tranings_TraningId",
                table: "Performances",
                column: "TraningId",
                principalTable: "Tranings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
