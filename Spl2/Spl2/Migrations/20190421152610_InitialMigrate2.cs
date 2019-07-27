using Microsoft.EntityFrameworkCore.Migrations;

namespace Spl2.Migrations
{
    public partial class InitialMigrate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServiceListDailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServiceListDailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropColumn(
                name: "DailyStudentServiceListDailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.AddColumn<int>(
                name: "DailyStudentServixeListId",
                table: "drugInfoPerStudents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServixeListId",
                table: "drugInfoPerStudents",
                column: "DailyStudentServixeListId");

            migrationBuilder.AddForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServixeListId",
                table: "drugInfoPerStudents",
                column: "DailyStudentServixeListId",
                principalTable: "dailyStudentServiceLists",
                principalColumn: "DailyStudentServixeListId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropColumn(
                name: "DailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.AddColumn<int>(
                name: "DailyStudentServiceListDailyStudentServixeListId",
                table: "drugInfoPerStudents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServiceListDailyStudentServixeListId",
                table: "drugInfoPerStudents",
                column: "DailyStudentServiceListDailyStudentServixeListId");

            migrationBuilder.AddForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServiceListDailyStudentServixeListId",
                table: "drugInfoPerStudents",
                column: "DailyStudentServiceListDailyStudentServixeListId",
                principalTable: "dailyStudentServiceLists",
                principalColumn: "DailyStudentServixeListId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
