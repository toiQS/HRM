using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Data.Migrations
{
    /// <inheritdoc />
    public partial class HRMAddingIdentityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(4995), new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(4997), new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 1,
                column: "EvaluationDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 2,
                column: "EvaluationDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 3,
                column: "EvaluationDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Recruitment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 20, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5454), new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Recruitment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 20, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5458), new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 2, 32, 9, 295, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 7, 21, 18, 32, 9, 295, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 1, 32, 9, 295, DateTimeKind.Local).AddTicks(5432), new DateTime(2024, 7, 21, 17, 32, 9, 295, DateTimeKind.Local).AddTicks(5431) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 32, 9, 295, DateTimeKind.Local).AddTicks(5434), new DateTime(2024, 7, 21, 16, 32, 9, 295, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Traning",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 8, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5515), new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Traning",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 8, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 7, 21, 22, 32, 9, 295, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2566), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2575), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2025, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2577), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 1,
                column: "EvaluationDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 2,
                column: "EvaluationDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 3,
                column: "EvaluationDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Recruitment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 20, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2809), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Recruitment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deadline", "PostingDate" },
                values: new object[] { new DateTime(2024, 8, 20, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2814), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 3,
                column: "PaymentDate",
                value: new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 2, 26, 35, 595, DateTimeKind.Local).AddTicks(2772), new DateTime(2024, 7, 21, 18, 26, 35, 595, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 1, 26, 35, 595, DateTimeKind.Local).AddTicks(2787), new DateTime(2024, 7, 21, 17, 26, 35, 595, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 26, 35, 595, DateTimeKind.Local).AddTicks(2788), new DateTime(2024, 7, 21, 16, 26, 35, 595, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Traning",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 8, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2851), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Traning",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndAt", "StartAt" },
                values: new object[] { new DateTime(2024, 8, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2855), new DateTime(2024, 7, 21, 22, 26, 35, 595, DateTimeKind.Local).AddTicks(2854) });
        }
    }
}
