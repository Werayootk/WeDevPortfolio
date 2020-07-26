using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDevPortfolio.Migrations
{
    public partial class CrateTableProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(maxLength: 150, nullable: false),
                    ProjectContent = table.Column<string>(maxLength: 500, nullable: true),
                    ProjectStatus = table.Column<string>(maxLength: 50, nullable: true),
                    ProjectURL = table.Column<string>(maxLength: 500, nullable: true),
                    ProjectURLIMG = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
