using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spl2.Migrations
{
    public partial class InitialMigrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "drugInfoPerStudents",
                columns: table => new
                {
                    drugId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    amount = table.Column<int>(nullable: false),
                    DailyStudentServiceListDailyStudentServixeListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugInfoPerStudents", x => x.drugId);
                    table.ForeignKey(
                        name: "FK_drugInfoPerStudents_dailyStudentServiceLists_DailyStudentServiceListDailyStudentServixeListId",
                        column: x => x.DailyStudentServiceListDailyStudentServixeListId,
                        principalTable: "dailyStudentServiceLists",
                        principalColumn: "DailyStudentServixeListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_drugInfoPerStudents_DailyStudentServiceListDailyStudentServixeListId",
                table: "drugInfoPerStudents",
                column: "DailyStudentServiceListDailyStudentServixeListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drugInfoPerStudents");
        }
    }
}
