using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro_DataAccess.Migrations
{
    public partial class SpecialityTrainer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Perte de poids" },
                    { 2, "Course" },
                    { 3, "Althérophilie" },
                    { 4, "Réhabilitation" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Active", "AuthorEmail", "FirstName", "LastName", "Photo", "Speciality_Id" },
                values: new object[,]
                {
                    { 1, true, "Chrystal.lapierre@juliepro.ca", "Chrysal", "Lappierre", "8624af64-2685-459a-a1cc-816c0695d760.png", 1 },
                    { 2, true, "Felix.trudeau@juliePro.ca", "Félix", "Trudeau", "a202bae3-e6bb-40f0-84cf-e4b11627ba1c.png", 2 },
                    { 3, false, "Frank.StJohn@juliepro.ca", "François", "Saint-John", "aedd9532-1395-42a2-8ae6-56f0e2ab49b5.png", 1 },
                    { 4, true, "JC.Bastien@juliepro.ca", "Jean-Claude", "Bastien", "d7bcc6d9-0599-42aa-8305-3c1ae5a4505c.png", 4 },
                    { 5, true, "JinLee.godette@juliepro.ca", "Jin Lee", "Godette", "E3Rcc6d9-0599-42aa-8305-3c1ae5a4512v.png", 3 },
                    { 6, true, "Karine.Lachance@juliepro.ca", "Karine", "Lachance", "b333bae3-e6bb-40f0-84cf-e4b11627ba1c.png", 2 },
                    { 7, false, "Ramone.Esteban@juliepro.ca", "Ramone", "Esteban", "waqd9532-1395-42a2-8ae6-56f0e2ab49e9.png", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
