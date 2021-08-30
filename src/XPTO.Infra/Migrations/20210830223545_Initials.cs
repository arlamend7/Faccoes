using Microsoft.EntityFrameworkCore.Migrations;

namespace XPTO.Infra.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FaccaoEntity",
                columns: table => new
                {
                    IdFaccao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UFOrigem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoOrigem = table.Column<int>(type: "int", nullable: false),
                    NomeLider = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaccaoEntity", x => x.IdFaccao);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FaccaoEntity");
        }
    }
}
