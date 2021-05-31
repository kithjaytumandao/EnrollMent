using Microsoft.EntityFrameworkCore.Migrations;

namespace EnrollMent.Migrations
{
    public partial class NewEnroll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudAge = table.Column<int>(type: "int", nullable: false),
                    StudAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudCourse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudSCYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
