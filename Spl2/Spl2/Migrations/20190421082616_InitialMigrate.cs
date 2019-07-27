using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spl2.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dailyStudentServiceLists",
                columns: table => new
                {
                    DailyStudentServixeListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    studentname = table.Column<string>(type: "varchar(100)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    problemDetails = table.Column<string>(type: "varchar(600)", nullable: false),
                    DrugList = table.Column<string>(type: "varchar(7000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailyStudentServiceLists", x => x.DailyStudentServixeListId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dailyStudentServiceLists");
        }
    }
}
