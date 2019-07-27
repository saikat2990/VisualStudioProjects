using Microsoft.EntityFrameworkCore.Migrations;

namespace Spl2.Migrations
{
    public partial class InitialMigrate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServiceListSession",
                table: "drugInfoPerStudents");

            migrationBuilder.DropIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServiceListSession",
                table: "drugInfoPerStudents");

            migrationBuilder.DropColumn(
                name: "DailyStudentServiceListSession",
                table: "drugInfoPerStudents");

            migrationBuilder.CreateIndex(
                name: "IX_drugInfoPerStudents_Session",
                table: "drugInfoPerStudents",
                column: "Session");

            migrationBuilder.AddForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_Session",
                table: "drugInfoPerStudents",
                column: "Session",
                principalTable: "dailyStudentServiceLists",
                principalColumn: "Session",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_Session",
                table: "drugInfoPerStudents");

            migrationBuilder.DropIndex(
                name: "IX_drugInfoPerStudents_Session",
                table: "drugInfoPerStudents");

            migrationBuilder.AddColumn<string>(
                name: "DailyStudentServiceListSession",
                table: "drugInfoPerStudents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServiceListSession",
                table: "drugInfoPerStudents",
                column: "DailyStudentServiceListSession");

            migrationBuilder.AddForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServiceListSession",
                table: "drugInfoPerStudents",
                column: "DailyStudentServiceListSession",
                principalTable: "dailyStudentServiceLists",
                principalColumn: "Session",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
