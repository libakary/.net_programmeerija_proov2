using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesAriulesanne.Migrations
{
    public partial class Addedurituseduritusekulastused : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrituseKulastused",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EraisikID = table.Column<int>(type: "int", nullable: false),
                    EttevotjaID = table.Column<int>(type: "int", nullable: false),
                    UritusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrituseKulastused", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UrituseKulastused_Eraisik_EraisikID",
                        column: x => x.EraisikID,
                        principalTable: "Eraisik",
                        principalColumn: "EraisikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrituseKulastused_Ettevotja_EttevotjaID",
                        column: x => x.EttevotjaID,
                        principalTable: "Ettevotja",
                        principalColumn: "EttevotjaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrituseKulastused_Uritus_UritusID",
                        column: x => x.UritusID,
                        principalTable: "Uritus",
                        principalColumn: "UritusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UrituseKulastused_EraisikID",
                table: "UrituseKulastused",
                column: "EraisikID");

            migrationBuilder.CreateIndex(
                name: "IX_UrituseKulastused_EttevotjaID",
                table: "UrituseKulastused",
                column: "EttevotjaID");

            migrationBuilder.CreateIndex(
                name: "IX_UrituseKulastused_UritusID",
                table: "UrituseKulastused",
                column: "UritusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrituseKulastused");
        }
    }
}
