using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuliePro_DataAccess.Migrations
{
    public partial class ajoutDesSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Trainers_Speciality_Id",
                table: "Trainers",
                column: "Speciality_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Specialities_Speciality_Id",
                table: "Trainers",
                column: "Speciality_Id",
                principalTable: "Specialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Specialities_Speciality_Id",
                table: "Trainers");

            migrationBuilder.DropIndex(
                name: "IX_Trainers_Speciality_Id",
                table: "Trainers");
        }
    }
}
