using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro_DataAccess.Migrations
{
    public partial class addCustomerObjective : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    AuthorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWeight = table.Column<double>(type: "float", nullable: false),
                    Trainer_Id = table.Column<int>(type: "int", nullable: false),
                    ScheduledSession_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objectives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LostWeight = table.Column<double>(type: "float", nullable: false),
                    DistanceKm = table.Column<double>(type: "float", nullable: false),
                    AchievedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objectives", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AuthorEmail", "BirthDate", "FirstName", "LastName", "Photo", "ScheduledSession_Id", "StartWeight", "Trainer_Id" },
                values: new object[,]
                {
                    { 1, "arthurLaroche@gmail.com", new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", "Laroche", "", 3, 0.0, 3 },
                    { 2, "DelimaCaillou@gmail.com", new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Délima", "Caillou", "", 3, 0.0, 2 },
                    { 3, "fredcaillou@gmail.com", new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fred", "Caillou", "", 3, 0.0, 3 },
                    { 4, "berthaLaroche@gmail.com", new DateTime(1965, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bertha", "Laroche", "", 3, 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Objectives",
                columns: new[] { "Id", "AchievedDate", "Customer_Id", "DistanceKm", "LostWeight", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0.0, 5.0, "" },
                    { 2, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0.0, 5.0, "" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0.0, 5.0, "" },
                    { 4, new DateTime(2022, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0.0, 10.0, "" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0.0, 5.0, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Objectives");
        }
    }
}
