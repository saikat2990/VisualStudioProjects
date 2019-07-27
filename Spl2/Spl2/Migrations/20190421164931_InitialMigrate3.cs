using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spl2.Migrations
{
    public partial class InitialMigrate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drugInfoPerStudents",
                table: "drugInfoPerStudents");

            migrationBuilder.DropIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dailyStudentServiceLists",
                table: "dailyStudentServiceLists");

            migrationBuilder.DropColumn(
                name: "drugId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropColumn(
                name: "DailyStudentServixeListId",
                table: "drugInfoPerStudents");

            migrationBuilder.DropColumn(
                name: "DailyStudentServixeListId",
                table: "dailyStudentServiceLists");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "drugInfoPerStudents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DailyStudentServiceListSession",
                table: "drugInfoPerStudents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Session",
                table: "drugInfoPerStudents",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Session",
                table: "dailyStudentServiceLists",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drugInfoPerStudents",
                table: "drugInfoPerStudents",
                column: "name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dailyStudentServiceLists",
                table: "dailyStudentServiceLists",
                column: "Session");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServiceListSession",
                table: "drugInfoPerStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drugInfoPerStudents",
                table: "drugInfoPerStudents");

            migrationBuilder.DropIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServiceListSession",
                table: "drugInfoPerStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dailyStudentServiceLists",
                table: "dailyStudentServiceLists");

            migrationBuilder.DropColumn(
                name: "DailyStudentServiceListSession",
                table: "drugInfoPerStudents");

            migrationBuilder.DropColumn(
                name: "Session",
                table: "drugInfoPerStudents");

            migrationBuilder.DropColumn(
                name: "Session",
                table: "dailyStudentServiceLists");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "drugInfoPerStudents",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "drugId",
                table: "drugInfoPerStudents",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "DailyStudentServixeListId",
                table: "drugInfoPerStudents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DailyStudentServixeListId",
                table: "dailyStudentServiceLists",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_drugInfoPerStudents",
                table: "drugInfoPerStudents",
                column: "drugId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dailyStudentServiceLists",
                table: "dailyStudentServiceLists",
                column: "DailyStudentServixeListId");

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
    }
}
