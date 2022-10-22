using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesAriulesanne.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eraisik",
                columns: table => new
                {
                    EraisikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isikukood = table.Column<long>(type: "bigint", nullable: false),
                    Maksmisviis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lisainfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eraisik", x => x.EraisikID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eraisik");
        }
    }
}
